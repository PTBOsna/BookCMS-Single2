Imports System.IO
Imports System.Text.RegularExpressions ' für RegEx erforderlich
Imports System.Data.OleDb
Public Class BuchNeuDNB
    Dim sText As String = ""
    Dim web As New WebBrowser
    Dim sInhalt As String = ""
    Dim BuchID As String = ""
    Dim AutorID As String = ""
    'BuchVorhanden Flag in Modul definiert, da Form-Übergreifend
    'Dim BuchVorhanden As Boolean = False
    Dim PersonVorhanden As Boolean = False
    Dim VerlagVorhanden As Boolean = False
    Dim OrtVorhanden As Boolean = False
    Dim Uebernommen As Boolean = False
    Dim CoverVorhanden As Boolean = False
    Dim CoverOnlineVorhanden As Boolean = False
    Dim f As WebInput
    Dim selDB As New dbHandling

    Sub New(openArgs As String)
        Dim s() As String
        InitializeComponent()
        s = Split(openArgs, "#")
        sText = s(0) 'URL für MARC21-Datensatz aus DNBConnect übergeben.
        BuchID = s(1) 'BuchID wenn Buch bereits vorhanden ist (Edit/Update)
        ' MsgBox(sText)
    End Sub
    Private Sub BuchNeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        loadAll()
        lblBestand.Visible = False
        If dbHandling.BuchVorhanden Then
            BuchBindingSource.Filter = "ID=" & BuchID
            lblBestand.Visible = False
        End If
        sInput()

        If dbHandling.BuchVorhanden = False Then
            ' checkTitle(f.dnbTitel)
            cbTrue()
        End If
        ''checkCover()
        loadCover()
        'checkTitelIndex()
        checkAutor(f.dnbAutorSort)
        ''Coautor oder Übersetzer
        If Not String.IsNullOrEmpty(f.dnbPerson) Then
            If Not f.dnbPerson.Contains(f.dnbAutorSort) Then
                checkAutor(f.dnbPerson)
            End If
        End If
        checkVerlag(f.dnbVerlag, f.dnbVerlagsOrt)
        chkVerlagsOrt(f.dnbVerlagsOrt)
        LetzteAenderungTextBox.Text = Now.ToLongDateString
        'Genre Vorbereiten
        Dim genre = From p In _BookCMS_singleDataSet.Sachgruppe Select p
        For Each eintrag In genre
            CheckedListBox1.Items.Add(eintrag.Sachgruppe)
        Next
        CheckedListBox1.DataSource = genre.AsDataView
        CheckedListBox1.DisplayMember = "Sachgruppe"
        CheckedListBox1.ValueMember = "GenreID"
        GenreLinkBindingSource.Filter = "BuchID=" & BuchID
        setCheckBox()
        listBoxFill()
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub loadAll()
        'Me.BibliothekTableAdapter.Fill(Me._BookCMS_singleDataSet.Bibliothek)
        Me.GenreLinkTableAdapter.Fill(Me._BookCMS_singleDataSet.GenreLink)
        Me.LandTableAdapter.Fill(Me._BookCMS_singleDataSet.Land)
        BuchTableAdapter.Fill(_BookCMS_singleDataSet.Buch)
        Me.AutorBuchLinkTableAdapter.Fill(Me._BookCMS_singleDataSet.AutorBuchLink)
        Me.VerlagsOrtTableAdapter.Fill(Me._BookCMS_singleDataSet.VerlagsOrt)
        Me.VerlagTableAdapter.Fill(Me._BookCMS_singleDataSet.Verlag)
        Me.AutorRolleTableAdapter.Fill(Me._BookCMS_singleDataSet.AutorRolle)
        Me.PersonTableAdapter.Fill(Me._BookCMS_singleDataSet.Person)
        Me.LanguageTableAdapter.Fill(Me._BookCMS_singleDataSet.Language)
        Me.SachgruppeTableAdapter.Fill(Me._BookCMS_singleDataSet.Sachgruppe)
        Me.BindungTableAdapter.Fill(Me._BookCMS_singleDataSet.Bindung)
        Me.DruckereiTableAdapter.Fill(Me._BookCMS_singleDataSet.Druckerei)
        Me.BuchTypTableAdapter.Fill(Me._BookCMS_singleDataSet.BuchTyp)
        Me.StandortTableAdapter.Fill(Me._BookCMS_singleDataSet.Standort)
    End Sub
    Private Sub sInput()
        Dim savePath As String = Application.StartupPath & "\dateiname.xml"
        Dim dummy As String = ""
        Dim sInhalt As String = ""
        Dim df_id As Int16 'String = ""
        f = New WebInput
        'zunächst leeren
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        LblCoverVorhanden.Visible = False
        ' MsgBox(savePath)
        If dbHandling.testlauf = True Then
            If File.Exists(savePath) Then Kill(savePath)
            Try
                My.Computer.Network.DownloadFile(sText, savePath)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            savePath = sText
        End If

        NewDataSet.Clear() 'vorhandene Einträge löschen
        NewDataSet.ReadXml(savePath)
        'Dim i As Integer = 0
        '  MsgBox(NewDataSet,.datafield.Count)
        For Each sDatafield In NewDataSet.datafield
            df_id = CShort(sDatafield.datafield_Id)
            Select Case sDatafield.tag
                Case "016"

                    f.dnbDNB = findSubfield("DCC.", sDatafield.datafield_Id, "a") 'DNB-Nummer
                    CheckedListBox2.Items.Add(sDatafield.tag & " - DCC " & f.dnbDNB)
                Case "020"
                    f.dnbISBN = findSubfield("ISBN", df_id, "a") ' ISBN
                    CheckedListBox2.Items.Add(sDatafield.tag & " - ISBN " & f.dnbISBN)
                    f.dnbPreis &= findSubfield("Preis", df_id, "c")
                    dummy = findSubfield("ISBN", df_id, "a")
                    'ISBN-13 ausfiltern
                    If Len(dummy) > 11 Then f.dnbBARCode = DelCharText(dummy)
                    f.dnbISBN = findSubfield("ISBN - ", df_id, "9") ' ISBN
                    '  If Not String.IsNullOrEmpty(TextBox2.Text) Then TextBox22.Text = findSubfield("ISBN - ", df_id, "9")
                Case "024"
                    'TextBox24.Text = findSubfield("ISBN 13 ", df_id, "a")
                Case "041"
                    f.dnbSprache = findSubfield("Sprache", df_id, "a")
                    f.dnbOrgLang = findSubfield("Orinalsprache", df_id, "h")
                Case "100"
                    f.dnbAutorSort = findSubfield("Autor, sort.", df_id, "a")
                    CheckedListBox2.Items.Add(sDatafield.tag & " - Autor- " & f.dnbAutorSort)
                    f.dnbAutorArt = findSubfield("Autor, sort.", df_id, "4")
                Case "082"
                    f.dnbDDC &= findSubfield("DCC.", df_id, "a") & "; "
                Case "084"
                    f.dnbDDC &= findSubfield("DCC.", df_id, "a") & "; "
                Case "240"
                    f.dnbOrgTitel = findSubfield("Orig. Titel", df_id, "a") 'Autor: Code ist aus MARC21 Feldbeschreibung zu entnehmen
                Case "245"
                    f.dnbTitel = findSubfield("Titel", df_id, "a") 'Titel

                    CheckedListBox2.Items.Add(sDatafield.tag & " - Titel - " & f.dnbTitel)
                    f.dnbSubTitle = findSubfield("Untertitel", df_id, "b") 'tritelzusatz
                    CheckedListBox2.Items.Add(sDatafield.tag & " - Untertitel - " & f.dnbSubTitle)
                    If String.IsNullOrEmpty(f.dnbAutorSort) Then f.dnbAutorSort = findSubfield("Autor", df_id, "c") 'Untettitel
                    CheckedListBox2.Items.Add(sDatafield.tag & " - AutorSort- " & f.dnbAutorSort)
                Case "250"
                    f.dnbAuflage = findSubfield("Auflage", df_id, "a")
                    CheckedListBox2.Items.Add(sDatafield.tag & " - Auflage- " & f.dnbAuflage)
                Case "264"
                    f.dnbVerlag = findSubfield("Verlag", df_id, "b") 'Verlag
                    CheckedListBox2.Items.Add(sDatafield.tag & " - Verlag- " & f.dnbVerlag)
                    f.dnbVerlagsOrt = findSubfield("Verlagsort", df_id, "a") 'Verlagssort
                    CheckedListBox2.Items.Add(sDatafield.tag & " - Verlagsort- " & f.dnbVerlagsOrt)
                    f.dnbVeroef = findSubfield("Jahr", df_id, "c") 'Erscheinungsjahr
                    CheckedListBox2.Items.Add(sDatafield.tag & " - Jahr- " & f.dnbVeroef)
                Case "300"
                    f.dnbSeiten = Regex.Match(findSubfield("Seiten", df_id, "a"), ".*[0-9]").ToString 'Erscheinungsjahr
                    CheckedListBox2.Items.Add(sDatafield.tag & " - Seiten- " & f.dnbSeiten)
                    f.dnbGroesse = findSubfield("Dimension", df_id, "c") 'Erscheinungsjahr
                    CheckedListBox2.Items.Add(sDatafield.tag & " - Größe- " & f.dnbGroesse)
                    'TextBox25.Text = findSubfield("Begleitmaterial", df_id, "e")
                Case "490"
                    f.dnbSerie = findSubfield("Sammlung", df_id, "a")
                    CheckedListBox2.Items.Add(sDatafield.tag & " - Sammlung- " & f.dnbSerie)
                    'TextBox17.Text = findSubfield("Sam.Nr.", df_id, "v") 'Erscheinungsjahr
                Case "650"
                    f.dnbStichworte &= findSubfield("Bindung", df_id, "a") & "; "
                    CheckedListBox2.Items.Add(sDatafield.tag & " - Stichworte- " & f.dnbStichworte)
                Case "653"
                    'txtBindung.Text &= findSubfield("Bindung", df_id, "a")
                    f.dnbAnmerk &= findSubfield("Strichworte", df_id, "a") & "; "
                    CheckedListBox2.Items.Add(sDatafield.tag & " - Anmerk.- " & f.dnbAnmerk)
                Case "700"
                    f.dnbPerson = findSubfield("Mitautor", df_id, "a")
                    CheckedListBox2.Items.Add(sDatafield.tag & " - Person- " & f.dnbPerson)
                    f.dnbPersonArt = findSubfield("PersonArt", df_id, "4")
                    CheckedListBox2.Items.Add(sDatafield.tag & " - Art- " & f.dnbPersonArt)
                    'TextBox27.Text = findSubfield("Mitautor-Land", df_id, "4")
                Case "856"
                    sInhalt = findSubfield("Inhalt", df_id, "u")
            End Select
            'i += 1 '+If sDatafield.tag = "100" Then iId = sDatafield.datafield_Id 'MsgBox(sDatafield.datafield_Id & "-" & sDatafield.tag)
        Next
        If Not sInhalt.IndexOf("/04") > 0 Then
            ' MsgBox("enthält kein /04"-> pdf-Datei)
            Try
                web.Navigate(sInhalt)
                ' MsgBox(web.DocumentType)
                While web.ReadyState <> WebBrowserReadyState.Complete
                    Application.DoEvents()
                End While
                'If (web.Document.GetElementById("searchresult") IsNot Nothing) Then
                f.dnbInhalt = web.Document.Body.InnerText
                'End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        fillTXT()
        If dbHandling.BuchVorhanden = False Then
            createID(f.dnbTitel)
            TitleSortTextBox.Text = f.dnbTitel
        End If
    End Sub
    'Aufruf aus inputFromWeb() zum Ermittln der Feldinhalte aus MARC21
    Function findSubfield(ByVal sName As String, id As Integer, sCode As String) As String
        Dim ergeb As String = ""
        Dim i As Int16 = 0
        For Each sSubfield In NewDataSet.subfield
            If sSubfield.datafield_Id = id And sSubfield.code = sCode Then
                ergeb &= sSubfield.subfield_text
                If i > 1 Then ergeb = "; " & ergeb
                i = CShort(i + 1)
            End If
        Next


        Dim chg_u As String = "u" & ChrW(776)
        Dim chg_o As String = "o" & ChrW(776)
        Dim chg_a As String = "a" & ChrW(776)
        ' wort = Regex.Replace(sText, ChrW(776), "")
        ergeb = Regex.Replace(ergeb, chg_u, "ü")
        ergeb = Regex.Replace(ergeb, chg_o, "ö")
        ergeb = Regex.Replace(ergeb, chg_a, "ä")
        Return ergeb
    End Function
    Private Sub fillTXT()

        txtDNB.Text = f.dnbDNB
        txtISBN.Text = f.dnbISBN
        txtPreis.Text = f.dnbPreis
        txtSprache.Text = f.dnbSprache
        '= f.dnbOrgLang
        txtAutorSort.Text = f.dnbAutorSort
        txtAutorArt.Text = f.dnbAutorArt
        txtDDC.Text = f.dnbDDC
        txtOrgTitel.Text = f.dnbOrgTitel
        TxtTitel.Text = f.dnbTitel
        TxtUTitel.Text = f.dnbSubTitle
        txtAuflage.Text = f.dnbAuflage
        txtVerlag.Text = ReplaceBrckets(f.dnbVerlag)
        txtVerlagOrt.Text = ReplaceBrckets(f.dnbVerlagsOrt)
        txtVeroeff.Text = ReplaceBrckets(f.dnbVeroef)
        txtSeiten.Text = f.dnbSeiten
        txtGroesse.Text = f.dnbGroesse
        txtSerie.Text = f.dnbSerie
        txtStWorte.Text = f.dnbStichworte
        txtAnmerk.Text = f.dnbAnmerk
        txtPerson.Text = f.dnbPerson
        txtPersonArt.Text = f.dnbPersonArt
        txtKurz.Text = f.dnbInhalt
        txtBarCode.Text = f.dnbBARCode
    End Sub
    'Wenn Titel noch nicht vorhanden, neuen Datensatz erstellen, speichern und neu laden um ID zu bekommen
    Private Sub createID(ByRef sTitel As String)
        Dim newDataRow As _BookCMS_singleDataSet.BuchRow
        Dim iLen As Integer = 20
        Dim orgTitel As String = delControl(sTitel)
        sTitel = UCase(sTitel)
        If sTitel.Length < 20 Then iLen = sTitel.Length
        ' MsgBox(sTitle.Length)
        sTitel = sTitel.Substring(0, iLen)
        newDataRow = _BookCMS_singleDataSet.Buch.NewBuchRow
        newDataRow.Titel = orgTitel
        newDataRow.TitelIndex = delChar(sTitel)
        _BookCMS_singleDataSet.Buch.Rows.Add(newDataRow)
        Validate()
        BuchBindingSource.EndEdit()
        BuchTableAdapter.Update(_BookCMS_singleDataSet.Buch)
        BuchTableAdapter.Fill(_BookCMS_singleDataSet.Buch)
        ' MsgBox("stop, in Acces neuen Datensatz prüfen")
        BuchID = CStr(lastID("SELECT max(ID) FROM Buch"))
        'Titel und ID werden in Form1 jetzt angezeigt
        BuchBindingSource.Filter = "ID=" & BuchID
        'Signatur ermitteln und vorschlagen
        txtSignatur.Text = (lastID("Select max(Signatur) FROM Buch") + 1).ToString("0000")
        If String.IsNullOrEmpty(SignaturTextBox.Text) Then SignaturTextBox.Text = txtSignatur.Text
    End Sub
    'Letzte ID ermitteln (Aufruf aus CreateID u.a.)
    Private Function lastID(sString As String) As Int16
        Dim anzahlDS As Int16 = 0
        Dim dbh As New dbHandling

        'Dim ConnectionString As String = dbh.GetConnectionStringByProvider("System.Data.OleDb")
        Dim Con As OleDbConnection = New OleDb.OleDbConnection(dbHandling.conStr)
        Dim cmd As New OleDbCommand(sString, Con)
        Try
            cmd.CommandText = sString '"SELECT max(ID) FROM Buch"
            'cmd.Connection.Open()
            Con.Open()
            anzahlDS = CShort(cmd.ExecuteScalar())
            Return anzahlDS
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Con.Close()
        End Try
        ' MsgBox(cmd.ExecuteScalar())
        'MessageBox.Show(anzahlDS.ToString)
        Return anzahlDS
    End Function
    'Nur Ziffern zulassen (für BarCode)
    Function DelCharText(altertext As String) As String
        Dim sb As New System.Text.StringBuilder
        For Each zeichen In altertext
            If Char.IsDigit(zeichen) Then
                sb.Append(zeichen)
            End If
            ' Return sb.ToString
        Next
        Return sb.ToString
    End Function
    'Aus Text alle Steuerzeichen entfernen (für IndexTitel)
    Function delChar(ByRef sb As String) As String
        'alle Sonderzeichen entfernen
        For i As Integer = sb.Length - 1 To 0 Step -1
            If Not Char.IsLetterOrDigit(sb(i)) Then
                sb = sb.Remove(i, 1)
                ' MsgBox(i & "-" & sb(i) & "-" & sb)
            End If
        Next
        Return sb
    End Function
    'Controls aus Titel entfernen
    Private Function delControl(ByVal sTitel As String) As String
        If String.IsNullOrEmpty(sTitel) Then
            Return sTitel
            Exit Function
        End If
        For i As Integer = sTitel.Length - 1 To 0 Step -1
            If Char.IsControl(sTitel(i)) Then
                sTitel = sTitel.Remove(i, 1)
            End If
        Next
        Return sTitel
    End Function
    Function ReplaceBrckets(sText As String) As String
        If String.IsNullOrEmpty(sText) Then
            Return Nothing
            Exit Function
        End If
        Replace(sText, "[", "")
        Replace(sText, "]", "")
        Return sText
    End Function
    'Felder Checked
    Private Sub cbTrue()
        For Each cb In {CheckBox1, CheckBox10, CheckBox11, CheckBox12, CheckBox13, CheckBox14, CheckBox15, CheckBox16, CheckBox17, CheckBox18, CheckBox19, CheckBox2, CheckBox20, CheckBox21, CheckBox22, CheckBox23, CheckBox3, CheckBox4, CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox24, CheckBox25, CheckBox26, CheckBox27}
            cb.Checked = True ' = Color.Red 'If String.IsNullOrEmpty(tb.Text) Then tb.Text = "-----"
        Next
    End Sub
    Private Sub checkCover()
        ' Dim ergeb As DialogResult
        'Dim Cover = From p In _BookCMS_SingleDataSet.BuchBilder Where p.BookID = CInt(BuchID) Select p
        'If Cover.Count > 1 Then
        '    MsgBox("Mehr als ein Coverbild eingetragen!" & vbCrLf & "Bitte Tabelle prüfen!",, "Achtung!")
        '    Exit Sub
        'End If
        Dim CoverID As String = dbHandling.CoverPath & BuchID & ".jpg"

        If File.Exists(CoverID) Then
            MsgBox("Cover im Bestand breits vorhanden")
            ' BuchBilderBindingSource.Filter = "BookID=" & BuchID
            CoverVorhanden = True
            ImagePictureBox.Visible = True
            LblCoverVorhanden.Visible = True
            CheckBoxCover.Checked = False
            ImagePictureBox.Load(CoverID)
        Else
            MsgBox("noch kein Cover im Bestand vorhanden")
            CoverVorhanden = False
            ImagePictureBox.Visible = False
            LblCoverVorhanden.Visible = False
            CheckBoxCover.Checked = True
            ImagePictureBox.Image = My.Resources.buchAdd
        End If

    End Sub
    'Prüfen ob Person im Bestand
    Private Sub checkAutor(ByVal sAutor As String)
        'Dim splitAutor() As String
        Dim openArgs As String = ""
        Dim dummy As String = ""
        Dim sAutorOrg As String = ""
        If String.IsNullOrEmpty(sAutor) Then
            ' MsgBox(sAutor)
            Exit Sub
        End If
        AutorBuchLinkDataGridView.Visible = False
        PersonVorhanden = False 'Voreinstellung
        sAutor = Regex.Replace(sAutor, vbCr, "")
        ReplaceBrckets(sAutor)
        sAutor = Trim(sAutor)
        sAutorOrg = sAutor
        sAutor &= "*"
        'MsgBox(sAutor.Length & " - " & sAutor)
        Do Until PersonVorhanden = True
            'DB-Abfrage
            Dim Personen = From p In _BookCMS_singleDataSet.Person Where p.SortBy Like sAutor Select p.PersonID, p.SortBy
            If Personen.Count > 0 Then

                PersonVorhanden = True
                AutorBuchLinkDataGridView.Visible = True 'DG sichtbar machen
                'Mit vorhandener Person weiter
                ' While reader.Read()
                For Each Person In Personen
                    AutorID = Person.PersonID.ToString
                    ' MsgBox("Autor: " & AutorID)
                Next
                'AutorID = Person.per reader("PersonID")
                'wenn Autor und Buch vorhadnen:
                If dbHandling.BuchVorhanden And PersonVorhanden Then
                    'prüfen ob auch Eintrag in Tabelle AutorBuchLink vorhanden
                    AutorBuchLinkBindingSource.Filter = "PersonID=" & AutorID
                    If AutorBuchLinkBindingSource.Count > 0 Then
                        Dim rowCurrent = DirectCast(DirectCast(AutorBuchLinkBindingSource.Current, DataRowView).Row, _BookCMS_singleDataSet.AutorBuchLinkRow)
                        'MsgBox(rowCurrent.BuchID & " - " & rowCurrent.PersonID)
                    Else
                        MsgBox("Kein Eintrag in AutorBuchLink - wird jetzt aktualisiert!")
                        AktAutorBuchLink()
                    End If
                    'dann mache nichts

                    FillAutorSort()
                    Exit Sub
                End If
                'Wenn Autor vorhanden, Buch aber neu:
                If dbHandling.BuchVorhanden = False Then
                    AktAutorBuchLink() 'Neuer Eintrag in Tabelle AutorBuchLink
                    FillAutorSort()
                    AutorSortTextBox.Text = sAutorOrg
                    Exit Sub
                End If

                'FillAutorSort()
                AutorSortTextBox.Text = sAutorOrg
                Exit Sub
            End If
            'Neuer Autor
            MsgBox("Neue Person " & sAutor & " wird jetzt eingetragen!")
            openArgs = TxtTitel.Text & "#" & sAutorOrg '& "#" & txtAutorArt.Text
            Dim f As New PersonNeu(openArgs) 'BuchNeu(openArgs)
                f.ShowDialog()
            PersonVorhanden = True
        Loop
        'Person jetzt vorhanden
        ' FillAutorSort()
        AutorID = lastID("Select max(PersonID) FROM Person").ToString
        AktAutorBuchLink() 'Neuer Eintrag in Tabelle AutorBuchLink
        AutorBuchLinkBindingSource.Filter = "BuchID=" & BuchID 'DG füllen
        AutorBuchLinkDataGridView.Visible = True 'DG sichtbar machen
        ActAutorSort()
        'AutorSortTextBox.Text = sAutorOrg
    End Sub
    Private Sub PersonNeu()

    End Sub
    Private Sub AktAutorBuchLink()
        Dim newDatenRow As _BookCMS_singleDataSet.AutorBuchLinkRow
        newDatenRow = Me._BookCMS_singleDataSet.AutorBuchLink.NewAutorBuchLinkRow
        newDatenRow.BuchID = CInt(BuchID)
        newDatenRow.PersonID = CInt(AutorID)
        newDatenRow.RolleID = 7 'Vorbelegt mit "Autor"
        _BookCMS_singleDataSet.AutorBuchLink.Rows.Add(newDatenRow)
        Validate()
        AutorBuchLinkBindingSource.EndEdit()
        AutorBuchLinkTableAdapter.Update(_BookCMS_singleDataSet.AutorBuchLink)
        TableAdapterManager.UpdateAll(_BookCMS_singleDataSet)
        'PersonTableAdapter.Connection = selDB.con
        PersonTableAdapter.Fill(_BookCMS_singleDataSet.Person)
        AutorBuchLinkTableAdapter.Fill(_BookCMS_singleDataSet.AutorBuchLink)
    End Sub
    Private Sub FillAutorSort()
        AutorBuchLinkBindingSource.Filter = "BuchID=" & BuchID
        If String.IsNullOrEmpty(AutorSortTextBox.Text) Then AutorSortTextBox.Text = txtAutorSort.Text
    End Sub
    Private Sub ActAutorSort()
        Dim dummy As Integer = 0
        Dim sTempAutor As String = Nothing
        Dim sAutor As String = Nothing
        If AutorBuchLinkDataGridView.Rows.Count > 0 Then
            For i = 0 To AutorBuchLinkDataGridView.Rows.Count - 2 '-2, da die AddNew-Reihe mit gezählt wird

                dummy = CInt(AutorBuchLinkDataGridView.Rows.Item(i).Cells(2).Value)
                Dim person = From p In _BookCMS_singleDataSet.Person Where p.PersonID = dummy Select p.SortBy

                For Each sName In person
                    sTempAutor = sName
                    Exit For
                Next
                sAutor &= sTempAutor & "; "
                '    End If
            Next
            AutorSortTextBox.Text = sAutor.Substring(0, Len(sAutor) - 2)
        Else
            MsgBox("Keine Person angegeben!")
            Exit Sub
        End If

    End Sub
    'prüfen, ob Verlag im Bestand
    Private Sub checkVerlag(ByVal sVerlag As String, sOrt As String)
        Dim sString1 = sVerlag

        Dim iLen As Integer = 15
        sVerlag = Regex.Replace(sVerlag, vbCr, "")
        ReplaceBrckets(sVerlag)
        sOrt = Regex.Replace(sOrt, vbCr, "")
        ReplaceBrckets(sOrt)
        sString1 = Trim(sVerlag)
        Dim openArgs As String = sVerlag & "#" & sOrt
        If sVerlag.Length < 15 Then iLen = sVerlag.Length
        ' MsgBox(sTitle.Length)
        sVerlag = sVerlag.Substring(0, iLen) & "*"
        'MsgBox("Verlag: " & sString1)
        ' sString2 = Trim(sOrt)
        ' MsgBox(sString2)
        Dim Verlag = From v In _BookCMS_singleDataSet.Verlag Where v.SortBy Like sVerlag Select v.PublisherID, v.SortBy

        If Verlag.Count > 0 Then
            For Each vl In Verlag
                VerlagsIDTextBox.Text = vl.PublisherID.ToString
            Next
            VerlagVorhanden = True

        Else
            VerlagVorhanden = False
            If MsgBox("Verlag (" & sVerlag & ") noch nicht vorhanden! Neu Eingeben?", vbYesNo) = vbNo Then
                'VerlagsIDTextBox.Text = "-1"
                Exit Sub
            End If

            Dim f As New VerlagNeu(openArgs)
            ' f.VerlagBindingSource.DataSource = _BookCMS_SingleDataSet
            f.ShowDialog()
            VerlagTableAdapter.Fill(_BookCMS_singleDataSet.Verlag)
            'rekursiver Aufruf
            checkVerlag(sString1, sOrt)
        End If

        VerlagBindingSource.Filter = "PublisherID=" & VerlagsIDTextBox.Text

    End Sub
    Private Sub chkVerlagsOrt(ByVal VerlagsOrt As String)
        Dim sOrt As String = Regex.Replace(VerlagsOrt, vbCr, "").Replace("[", "").Replace("]", "")
        sOrt = Trim(sOrt)
        ReplaceBrckets(sOrt)
        Dim ort = From o In _BookCMS_singleDataSet.VerlagsOrt Where o.SortBy Like sOrt Select o.ID, o.SortBy
        If ort.Count > 0 Then
            For Each ot In ort
                OrtIDTextBox1.Text = ot.ID.ToString
            Next
            OrtVorhanden = True

        Else
            OrtVorhanden = False
            If MsgBox("Verlagsort (" & sOrt & ") noch nicht vorhanden! Neu Eingeben?", vbYesNo) = vbNo Then
                'VerlagsIDTextBox.Text = "-1"
                Exit Sub
            End If

            Dim f As New VerlagsOrtNeu(VerlagsOrt)
            f.VerlagsOrtBindingSource.DataSource = _BookCMS_singleDataSet
            f.ShowDialog()
            VerlagsOrtTableAdapter.Connection = selDB.con
            VerlagsOrtTableAdapter.Fill(_BookCMS_singleDataSet.VerlagsOrt)
            'rekursiver Aufruf
            chkVerlagsOrt(VerlagsOrt)
        End If
        VerlagsOrtBindingSource.Filter = "ID=" & OrtIDTextBox1.Text
    End Sub
    'GenreCheckedListBox -> Checked aus GenreLinkDataGridView übernehmen
    'Einstellung des GridView: AllowAddRow -> false! (sonst stimmt RowCount nicht)
    Private Sub setCheckBox()
        For i = 0 To GenreLinkDataGridView.RowCount - 1
            Dim dummy As String = GenreLinkDataGridView.Rows(i).Cells(2).Value.ToString
            CheckedListBox1.SelectedValue = dummy
            'MsgBox(i & "-" & dummy)
            CheckedListBox1.SetItemChecked(CInt(CheckedListBox1.SelectedIndex), True)
        Next
    End Sub
    'Genrelistbox-Einträge aus GenreLinkDataGridView übernehmen
    Private Sub listBoxFill()
        unCheckBox()
        For i = 0 To GenreLinkDataGridView.RowCount - 1
            Dim dummy As String = GenreLinkDataGridView.Rows(i).Cells(2).Value.ToString
            For j = 0 To CheckedListBox1.Items.Count - 1
                Dim oem As DataRowView
                oem = DirectCast(CheckedListBox1.Items.Item(j), DataRowView)
                If CInt(oem.Row(0)) = CInt(dummy) Then
                    CheckedListBox1.SetItemChecked(j, True)
                    ListBoxGenre.Items.Add(oem.Row(0).ToString & "-" & oem.Row(2).ToString)
                End If
            Next
        Next
    End Sub
    'Genrelistbox auf unchecked zurücksetzen
    Private Sub unCheckBox()
        ListBoxGenre.Items.Clear()
        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, False)
        Next
    End Sub
    'Gernrelistbox aus CheckedListbox füllen
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        ListBoxGenre.Items.Clear()
        For j = 0 To CheckedListBox1.Items.Count - 1
            Dim oem As DataRowView
            oem = DirectCast(CheckedListBox1.Items.Item(j), DataRowView)
            If CheckedListBox1.GetItemChecked(j) Then
                ListBoxGenre.Items.Add(oem.Row(0).ToString & "-" & oem.Row(2).ToString)
            End If
        Next
    End Sub
    Private Sub loadCover()
        ImagePictureBox.Visible = False
        If dbHandling.BuchVorhanden Then checkCover()

        Try
            PictureBox1.Load("https://portal.dnb.de/opac/mvb/cover.htm?isbn=" & txtBarCode.Text)
        Catch ex As Exception
        End Try
        Dim bm As Bitmap = CType(PictureBox1.Image, Bitmap)
        If bm Is Nothing Then
            MsgBox("Kein Cover Online vorhanden")
            Exit Sub
        End If
        'ImagePictureBox.Visible = True
        'Größe auf h=200 begrenzen und daraus Breite berechnen
        ' imageResize(bm)
        PictureHandle()
        CoverOnlineVorhanden = True

    End Sub
    Private Sub PictureHandle()
        ' Dim ergeb As DialogResult


        Dim bm As Bitmap = CType(PictureBox1.Image, Bitmap)

        If PictureBox1 IsNot Nothing Then
            imageResize(bm)
            ImagePictureBox.Image = PictureBox1.Image
        End If



    End Sub
    Private Sub imageResize(ByVal bm As Bitmap)
        Dim sz As Size
        Dim f As Double = 200 / bm.Height
        sz.Height = 200
        sz.Width = CInt(bm.Width * f)
        'MsgBox(sz.Height & "/" & sz.Width)
        PictureBox1.Image = ResizeBitmap(bm, sz)
    End Sub
    'Größe Bitmap ändern
    Public Shared Function ResizeBitmap(ByVal Bitmap As Bitmap, ByVal NewSize As Size) As Bitmap
        Dim bmp As New Bitmap(NewSize.Width, NewSize.Height, Bitmap.PixelFormat)
        With Graphics.FromImage(bmp)
            .DrawImage(Bitmap, 0, 0, NewSize.Width, NewSize.Height)
        End With
        Return bmp
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LetzteAenderungTextBox.Text = DateTimePicker1.Text
    End Sub
    Private Sub meClose()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cbFalse()
    End Sub
    Private Sub cbFalse()
        For Each cb In {CheckBox1, CheckBox10, CheckBox11, CheckBox12, CheckBox13, CheckBox14, CheckBox15, CheckBox16, CheckBox17, CheckBox18, CheckBox19, CheckBox2, CheckBox20, CheckBox21, CheckBox22, CheckBox23, CheckBox3, CheckBox4, CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox24, CheckBox25, CheckBox26, CheckBox27} 'hier alle Textboxen reinschreiben, die du prüfen willst
            cb.Checked = False ' = Color.Red 'If String.IsNullOrEmpty(tb.Text) Then tb.Text = "-----"
        Next
        ' chkRed()
    End Sub

    Private Sub btSvae_Click(sender As Object, e As EventArgs) Handles btSvae.Click
        If Uebernommen = False Then
            CheckToSave()
        End If
        If CoverOnlineVorhanden And CheckBoxCover.Checked Then
            Dim thumbName As String = dbHandling.CoverPath & IDTextBox.Text & ".jpg"
            PictureBox1.Image.Save(thumbName, System.Drawing.Imaging.ImageFormat.Jpeg)

        End If


        If String.IsNullOrEmpty(TxtTitel.Text) Or String.IsNullOrEmpty(TitelTextBox.Text) Then
            MsgBox("Bitte einen Titel eingeben")
            Exit Sub
        End If
        If String.IsNullOrEmpty(SignaturTextBox.Text) Then
            MsgBox("Bitte Signatur eingeben")
            Exit Sub
        End If
        If String.IsNullOrEmpty(SachgruppeIDTextBox.Text) Then SachgruppeIDTextBox.Text = "-1"
        If String.IsNullOrEmpty(TypIDTextBox.Text) Then TypIDTextBox.Text = "-1"
        SaveChangeGenre()
        Validate()
        BuchBindingSource.EndEdit()

        ' SerienBindingSource.EndEdit()
        GenreLinkBindingSource.EndEdit()
        SachgruppeBindingSource.EndEdit()
        'LanguageBindingSource.EndEdit()
        'StandortBindingSource.EndEdit()
        'BuchBilderBindingSource.EndEdit()
        PersonBindingSource.EndEdit()
        AutorBuchLinkBindingSource.EndEdit()
        AutorRolleBindingSource.EndEdit()
        If _BookCMS_singleDataSet.HasChanges() Then
            If MsgBox("Änderungen ok?", vbYesNo) = vbNo Then Exit Sub
            saveAll()
            ' selDB.con.Close()
        End If
        If dbHandling.BuchVorhanden = False Then checkBuchNeu()
        For i = 1 To 10000
        Next
        Close()
    End Sub
    Private Sub SaveChangeGenre()
        Dim sgID() As String
        Dim nRow As _BookCMS_singleDataSet.GenreLinkRow
        nRow = Me._BookCMS_singleDataSet.GenreLink.NewGenreLinkRow()
        For i = GenreLinkDataGridView.Rows.Count - 1 To 0 Step -1
            GenreLinkDataGridView.Rows.RemoveAt(i)
        Next
        For i = 0 To ListBoxGenre.Items.Count - 1
            sgID = Split(ListBoxGenre.Items(i).ToString, "-")
            ' MsgBox(sgID(0))
            ' With GenreLinkDataGridView
            nRow = _BookCMS_singleDataSet.GenreLink.NewGenreLinkRow()
            nRow.BuchID = CInt(BuchID)
            nRow.SachgruppeID = CInt(sgID(0))
            _BookCMS_singleDataSet.GenreLink.Rows.Add(nRow)
            ' End With
        Next
    End Sub
    Private Sub CheckToSave()
        If CheckBox1.Checked Then
            TitelTextBox.Text = TxtTitel.Text
            TxtTitel.BackColor = Color.LightGreen
        Else
            TxtTitel.BackColor = Color.Red
        End If
        If CheckBox2.Checked Then
            UntertitelTextBox.Text = TxtUTitel.Text
            TxtUTitel.BackColor = Color.LightGreen
        Else
            TxtUTitel.BackColor = Color.Red
        End If
        If CheckBox3.Checked Then
            VeroeffentlichtTextBox.Text = txtVeroeff.Text
            txtVeroeff.BackColor = Color.LightGreen
        Else
            txtVeroeff.BackColor = Color.Red
        End If
        If CheckBox4.Checked Then
            CopyrightDatumTextBox.Text = txtCopyrDat.Text
            txtCopyrDat.BackColor = Color.LightGreen
        Else
            txtCopyrDat.BackColor = Color.Red
        End If

        If CheckBox6.Checked Then
            'VerlagsIDTextBox.Text = txtVerlag.Text
            txtVerlag.BackColor = Color.LightGreen
        Else
            txtVerlag.BackColor = Color.Red
        End If
        If CheckBox7.Checked Then
            'ort = txtVerlagsOrt.Text
            txtVerlagOrt.BackColor = Color.LightGreen
        Else
            txtVerlagOrt.BackColor = Color.Red
        End If
        If CheckBox8.Checked Then
            ' = txtDruckerei.Text
            txtDruckerei.BackColor = Color.LightGreen
        Else
            txtDruckerei.BackColor = Color.Red
        End If
        If CheckBox9.Checked Then
            ISBNTextBox.Text = txtISBN.Text
            txtISBN.BackColor = Color.LightGreen
        Else
            txtISBN.BackColor = Color.Red
        End If
        If CheckBox10.Checked Then
            DDCTextBox.Text = txtDDC.Text
            txtDDC.BackColor = Color.LightGreen
        Else
            txtDDC.BackColor = Color.Red
        End If
        If CheckBox11.Checked Then
            LCCNTextBox.Text = txtLCCN.Text
            txtLCCN.BackColor = Color.LightGreen
        Else
            LCCNTextBox.BackColor = Color.Red
        End If
        If CheckBox12.Checked Then
            ' LandDTextBox.Text = txtLand.Text
            txtLand.BackColor = Color.LightGreen
        Else
            txtLand.BackColor = Color.Red
        End If
        If CheckBox13.Checked Then
            'SprachenIDTextBox.Text = txtSprache.Text
            txtSprache.BackColor = Color.LightGreen
        Else
            txtSprache.BackColor = Color.Red
        End If
        If CheckBox14.Checked Then
            'BindungIDTextBox.Text = txtBindung.Text
            txtBindung.BackColor = Color.LightGreen
        Else
            txtBindung.BackColor = Color.Red
        End If
        If CheckBox15.Checked Then
            AuiflageTextBox.Text = txtAuflage.Text
            txtAuflage.BackColor = Color.LightGreen
        Else
            txtAuflage.BackColor = Color.Red
        End If
        If CheckBox16.Checked Then
            'SerienIDTextBox.Text = txtSerie.Text
            txtSerie.BackColor = Color.LightGreen
        Else
            txtSerie.BackColor = Color.Red
        End If
        If CheckBox17.Checked Then
            SeitenTextBox.Text = txtSeiten.Text
            txtSeiten.BackColor = Color.LightGreen
        Else
            txtSeiten.BackColor = Color.Red
        End If
        If CheckBox18.Checked Then
            OriginalTitelTextBox.Text = txtOrgTitel.Text
            txtOrgTitel.BackColor = Color.LightGreen
        Else
            txtOrgTitel.BackColor = Color.Red
        End If
        If CheckBox19.Checked Then
            OriginalUntertitelTextBox.Text = txtOrgUT.Text
            txtOrgUT.BackColor = Color.LightGreen
        Else
            txtOrgUT.BackColor = Color.Red
        End If
        If CheckBox20.Checked Then
            ' OriginalSpracheIDTextBox.Text = txtOrgLang.Text
            txtOrgLang.BackColor = Color.LightGreen
        Else
            txtOrgLang.BackColor = Color.Red
        End If
        If CheckBox21.Checked Then
            VerkaufspreisTextBox.Text = txtPreis.Text
            txtPreis.BackColor = Color.LightGreen
        Else
            txtPreis.BackColor = Color.Red
        End If
        If CheckBox22.Checked Then
            If txtBarCode.Text.Length > 49 Then
                txtBarCode.Text = txtBarCode.Text.Substring(0, 40)
            End If
            BarCodeTextBox.Text = txtBarCode.Text
            txtBarCode.BackColor = Color.LightGreen
        Else
            txtBarCode.BackColor = Color.Red
        End If
        If CheckBox23.Checked Then
            Dim_HeightTextBox.Text = txtGroesse.Text
            txtGroesse.BackColor = Color.LightGreen
        Else
            txtGroesse.BackColor = Color.Red
        End If
        If CheckBox24.Checked Then
            StichworteTextBox.Text = txtStWorte.Text
            txtStWorte.BackColor = Color.LightGreen
        Else
            txtStWorte.BackColor = Color.Red
        End If
        If CheckBox25.Checked Then
            Anmerkungen_PlainTextTextBox.Text = txtAnmerk.Text
            txtAnmerk.BackColor = Color.LightGreen
        Else
            txtAnmerk.BackColor = Color.Red
        End If
        If CheckBox26.Checked Then
            Synopsis_PlainTextTextBox.Text = txtKurz.Text
            txtKurz.BackColor = Color.LightGreen
        Else
            txtKurz.BackColor = Color.Red
        End If
        If CheckBox27.Checked Then
            DNBTextBox.Text = txtDNB.Text
            txtKurz.BackColor = Color.LightGreen
        Else
            txtKurz.BackColor = Color.Red
        End If
    End Sub
    'prüfen, ob Hauptfelder eingetragen wurden
    Private Sub checkBuchNeu()
        Dim indexOk As Boolean = False
        Dim AutorOk As Boolean = False
        Dim SignatOk As Boolean = False

        BuchTableAdapter.Fill(_BookCMS_singleDataSet.Buch)
        Try
            Dim nbuch = From p In _BookCMS_singleDataSet.Buch Where p.ID = CInt(BuchID) Select p.TitelIndex, p.AutorSort, p.Signatur

            If nbuch.Count > 0 Then
                For Each eintrag In nbuch
                    If eintrag.TitelIndex.Length > 1 Then indexOk = True
                    If eintrag.AutorSort.Length > 1 Then AutorOk = True
                    If eintrag.Signatur.Length > 1 Then SignatOk = True
                Next
            End If
        Catch ex As Exception
            MsgBox("Fehler bei der Datenübernahme!" & vbCrLf & "Bitte manuell prüfen und Datensatz ggf. löschen!")
            Me.Close()
        End Try

        If indexOk Or AutorOk Or SignatOk Then
            Me.Close()
        Else
            MsgBox("Fehler bei der Datenübernahme!" & vbCrLf & "Bitte manuell prüfen und Datensatz ggf. löschen!")
            Me.Close()
        End If

        Me.Close()
    End Sub
    Private Sub saveAll()
        Try
            PersonTableAdapter.Update(_BookCMS_singleDataSet.Person)
            AutorRolleTableAdapter.Update(_BookCMS_singleDataSet.AutorRolle)
            AutorBuchLinkTableAdapter.Update(_BookCMS_singleDataSet.AutorBuchLink)
            BuchTableAdapter.Update(_BookCMS_singleDataSet.Buch)
            ' BuchBilderTableAdapter.Update(_BookCMS_SingleDataSet.BuchBilder)
            TableAdapterManager.UpdateAll(_BookCMS_singleDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AutorSortTextBox_Click(sender As Object, e As EventArgs) Handles AutorSortTextBox.Click
        ActAutorSort()
    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox11.SelectedIndexChanged
        If ComboBox11.SelectedIndex <> -1 Then
            TypIDTextBox.Text = ComboBox11.SelectedValue.ToString
        End If
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox10.SelectedIndexChanged
        If ComboBox10.SelectedIndex <> -1 Then
            SachgruppeIDTextBox.Text = ComboBox10.SelectedValue.ToString
        End If
    End Sub
End Class