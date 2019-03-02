Imports System.Data.OleDb
Imports System.IO
Imports WIA
Public Class BuchNeu

    Dim BuchID As String
    Dim selDB As New dbHandling
    Dim BuchNeu As Boolean = True
    Sub New(openArgs As String)

        InitializeComponent()

        'If openArgs = "#" Then
        '    'TODO: prüfen, ob entfallen kann, da bei FormAufruf BuchVorhanden-Flag gesetzt wird
        '    BuchNeu = False
        'Else
        '    BuchID = openArgs

        'End If
    End Sub
    Private Sub BuchNeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GenreLinkTableAdapter.Fill(Me._BookCMS_singleDataSet.GenreLink)
        Me.SachgruppeTableAdapter.Fill(Me._BookCMS_singleDataSet.Sachgruppe)
        Me.LanguageTableAdapter.Fill(Me._BookCMS_singleDataSet.Language)
        Me.SerienTableAdapter.Fill(Me._BookCMS_singleDataSet.Serien)
        Me.BuchTypTableAdapter.Fill(Me._BookCMS_singleDataSet.BuchTyp)
        Me.StandortTableAdapter.Fill(Me._BookCMS_singleDataSet.Standort)
        Me.BindungTableAdapter.Fill(Me._BookCMS_singleDataSet.Bindung)
        Me.DruckereiTableAdapter.Fill(Me._BookCMS_singleDataSet.Druckerei)
        Me.VerlagsOrtTableAdapter.Fill(Me._BookCMS_singleDataSet.VerlagsOrt)
        Me.VerlagTableAdapter.Fill(Me._BookCMS_singleDataSet.Verlag)
        'Me.BuchTableAdapter.Fill(Me._BookCMS_singleDataSet.Buch)
        Me.AutorRolleTableAdapter.Fill(Me._BookCMS_singleDataSet.AutorRolle)
        Me.PersonTableAdapter.Fill(Me._BookCMS_singleDataSet.Person)
        Me.AutorBuchLinkTableAdapter.Fill(Me._BookCMS_singleDataSet.AutorBuchLink)
        If dbHandling.BuchVorhanden = True Then
            MsgBox("Buch bereits vorhanden!")
            Close()
            'Me.BuchTableAdapter.Fill(Me._BookCMS_singleDataSet.Buch)
            'BuchBindingSource.Filter = "ID=" & BuchID
        End If
        'ComboBoxen vorbelegen
        If dbHandling.BuchVorhanden = False Then
            For Each page As TabPage In TabControl1.TabPages
                For Each cont As Control In page.Controls
                    ' MsgBox(cont.Name)
                    If TypeOf cont Is ComboBox Then

                        DirectCast(cont, ComboBox).Text = "Bitte auswählen"
                    End If
                Next
            Next
        End If
        AutorBuchLinkBindingSource.Filter = "id=0"
        AutorSortTextBox.Visible = False
        'CoverImage vorbelegen:
        If dbHandling.BuchVorhanden = False Then
            ImagePictureBox.Image = My.Resources.buchAdd
            PictureBox1.Image = Nothing
        End If

        ' MsgBox("Genere: " & GenreLinkBindingSource.Count)
        Dim genre = From p In _BookCMS_singleDataSet.Sachgruppe Select p

        'DataGridView1.DataSource = buch.AsDataView
        For Each eintrag In genre
            CheckedListBox1.Items.Add(eintrag.Sachgruppe)
        Next

        CheckedListBox1.DataSource = genre.AsDataView
        'CheckedListBox1.DataSource = SachgruppeBindingSource
        CheckedListBox1.DisplayMember = "Sachgruppe"
        CheckedListBox1.ValueMember = "GenreID"


    End Sub
    Private Sub createID(ByRef sTitel As String)
        Dim newDataRow As _BookCMS_singleDataSet.BuchRow
        Dim iLen As Integer = 20
        Dim TitelIndex As String = ""
        Dim sSig As String = (lastID("Select max(Signatur) FROM Buch") + 1).ToString("0000")
        newDataRow = _BookCMS_singleDataSet.Buch.NewBuchRow
        newDataRow.Titel = sTitel
        newDataRow.TitleSort = sTitel
        ' sTitel = UCase(sTitel)
        If sTitel.Length < 20 Then iLen = sTitel.Length
        ' MsgBox(sTitle.Length)
        TitelIndex = sTitel.Substring(0, iLen)
        newDataRow.TitelIndex = UCase(delChar(TitelIndex))
        newDataRow.Signatur = sSig
        _BookCMS_singleDataSet.Buch.Rows.Add(newDataRow)
        Validate()
        BuchBindingSource.EndEdit()
        BuchTableAdapter.Update(_BookCMS_singleDataSet.Buch)
        BuchTableAdapter.Fill(_BookCMS_singleDataSet.Buch)
        '  MsgBox("stop, in Acces neuen Datensatz prüfen")
        BuchID = CStr(lastID("SELECT max(ID) FROM Buch"))
        'Titel und ID werden in Form1 jetzt angezeigt
        BuchBindingSource.Filter = "ID=" & BuchID
        dbHandling.BuchVorhanden = True
    End Sub
    Private Function LastID(sString As String) As Int16
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

    Private Sub BuchBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        saveAll()

    End Sub
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
    Private Sub BtnAddAutor_Click(sender As Object, e As EventArgs) Handles BtnAddAutor.Click
        Dim newBuchAutor = _BookCMS_singleDataSet.AutorBuchLink.NewAutorBuchLinkRow
        With newBuchAutor
            .BuchID = CInt(BuchID)
            .PersonID = CInt(CBPerson.SelectedValue)
            .RolleID = CInt(CBRolle.SelectedValue)
        End With
        _BookCMS_singleDataSet.AutorBuchLink.AddAutorBuchLinkRow(newBuchAutor)
        AutorBuchLinkBindingSource.Filter = "BuchID=" & BuchID.ToString
    End Sub
    Private Sub saveAll()
        'zu sichern sind nur die Tabellen Buch, AutorBuchLink und GenreLink. Alle anderen Tabellen werden nicht geändert
        SaveChangeGenre()
        Validate()
        AutorBuchLinkBindingSource.EndEdit()
        GenreLinkBindingSource.EndEdit()
        BuchBindingSource.EndEdit()
        Try
            TableAdapterManager.UpdateAll(_BookCMS_singleDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        AutorBuchLinkBindingSource.Filter = "BuchID=" & BuchID.ToString
        If AutorBuchLinkBindingSource.Count = 0 Then
            MsgBox("Bitte Autor eingeben!")
            Exit Sub
        End If
        CreatAutorSort()

        If MsgBox("Änderungen ok?", vbYesNo) = vbNo Then Exit Sub
        saveAll()

        'AutorBuchLink speichern - besser bei Änderung AutorBuchLinkDataGridView auslösen, um mehr als einen Autor eingeben zu können!
        ' AktAutorBuchLink()
    End Sub

    Private Sub TitelTextBox_Leave(sender As Object, e As EventArgs) Handles TitelTextBox.Leave
        If dbHandling.BuchVorhanden Then Exit Sub
        createID(TitelTextBox.Text)
        '  BuchBilderBindingSource.Filter = "BookID=" & BuchID
        GenreLinkBindingSource.Filter = "BuchID=" & BuchID
        setCheckBox()
        listBoxFill()
    End Sub

    ' Private Sub AutorBuchLinkDataGridView_Leave(sender As Object, e As EventArgs) Handles AutorBuchLinkDataGridView.Leave
    Private Sub CreatAutorSort()
        Dim dummy As Integer = 0
        Dim sTempAutor As String = ""
        Dim sAutor As String = ""
        ' MsgBox(DirectCast(AutorBuchLinkBindingSource.Current, DataRowView).Item("PersonID").ToString())

        AutorBuchLinkDataGridView.EndEdit()

        For i = 0 To AutorBuchLinkDataGridView.RowCount - 1
            ' MsgBox(i & " - " & AutorBuchLinkDataGridView.Rows.Item(i).Cells(2).Value.ToString)
            If IsDBNull(AutorBuchLinkDataGridView.Rows.Item(i).Cells(2).Value) Then
                MsgBox("Bitte Autor und Rolle einegeben!")
                Exit Sub
            End If
            Select Case CInt(AutorBuchLinkDataGridView.Rows.Item(i).Cells(2).Value)
                Case 1, 2, 3, 7 'TODO: Muss später in Settings eingestellt werden. Jetzt sind nur Autor, Co-Autor, Herausgeber ... ausgewählt
                    'If CInt(AutorBuchLinkDataGridView.Rows.Item(i).Cells(2).Value) > 0 Then 'Voreingestellt mit Autor = 7
                    dummy = CInt(AutorBuchLinkDataGridView.Rows.Item(i).Cells(1).Value)
                    Dim person = From p In _BookCMS_singleDataSet.Person Where p.PersonID = dummy Select p.Name

                    For Each sName In person
                        sTempAutor = sName
                        Exit For
                    Next
                    sAutor &= sTempAutor & ", "
            End Select
            ' End If
        Next
        ' MsgBox(sAutor.Substring(0, Len(sAutor) - 2))
        AutorSortTextBox.Visible = True
        AutorSortTextBox.Text = sAutor.Substring(0, sAutor.Length - 2)
    End Sub

    Private Sub btPersonNeu_Click(sender As Object, e As EventArgs) Handles btPersonNeu.Click
        Dim f As New PersonenListe
        f.ShowDialog()
        PersonTableAdapter.Fill(_BookCMS_singleDataSet.Person)
    End Sub
    Private Sub setCheckBox()

        For i = 0 To GenreLinkDataGridView.RowCount - 1
            Dim dummy As String = GenreLinkDataGridView.Rows(i).Cells(1).Value.ToString
            CheckedListBox1.SelectedValue = dummy
            ' MsgBox(i & "-" & dummy)
            CheckedListBox1.SetItemChecked(CheckedListBox1.SelectedIndex, True)

        Next
    End Sub

    Private Sub listBoxFill()
        unCheckBox()
        For i = 0 To GenreLinkDataGridView.RowCount - 1
            Dim dummy As String = GenreLinkDataGridView.Rows(i).Cells(1).Value.ToString
            For j = 0 To CheckedListBox1.Items.Count - 1
                Dim oem As DataRowView
                oem = DirectCast(CheckedListBox1.Items.Item(j), DataRowView)
                If CInt(oem.Row(0)) = CInt(dummy) Then
                    CheckedListBox1.SetItemChecked(j, True)
                    ListBox1.Items.Add(oem.Row(0).ToString & "-" & oem.Row(2).ToString)
                End If
            Next
        Next
    End Sub
    Private Sub unCheckBox()
        ListBox1.Items.Clear()
        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, False)
        Next
    End Sub
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        For j = 0 To CheckedListBox1.Items.Count - 1
            Dim oem As DataRowView
            oem = DirectCast(CheckedListBox1.Items.Item(j), DataRowView)
            If CheckedListBox1.GetItemChecked(j) Then
                ListBox1.Items.Add(oem.Row(0).ToString & "-" & oem.Row(2).ToString)
            End If

        Next
    End Sub
    Private Sub SaveChangeGenre()
        Dim sgID() As String
        Dim nRow As _BookCMS_singleDataSet.GenreLinkRow
        nRow = Me._BookCMS_singleDataSet.GenreLink.NewGenreLinkRow()
        For i = GenreLinkDataGridView.Rows.Count - 1 To 0 Step -1
            ' MsgBox(i & " - " & GenreLinkDataGridView.Rows(i).Cells(1).Value.ToString)
            GenreLinkDataGridView.Rows.RemoveAt(i)
        Next
        For i = 0 To ListBox1.Items.Count - 1
            sgID = Split(ListBox1.Items(i).ToString, "-")
            ' MsgBox(sgID(0))
            ' With GenreLinkDataGridView
            nRow = _BookCMS_singleDataSet.GenreLink.NewGenreLinkRow()
            nRow.BuchID = CInt(IDTextBox.Text)
            nRow.SachgruppeID = CInt(sgID(0))
            _BookCMS_singleDataSet.GenreLink.Rows.Add(nRow)
            Validate()
            'GenreLinkTableAdapter.Fill(_BookCMS_singleDataSet.GenreLink)
            'GenreLinkBindingSource.Filter = "BuchID=" & id

            '' End With
            'MsgBox(GenreLinkBindingSource.Count)
        Next
    End Sub

    Private Sub btImageInput_Click(sender As Object, e As EventArgs) Handles btImageInput.Click
        PictureBox1.Image = Clipboard.GetImage()

        If PictureBox1.Image Is Nothing Then
            MsgBox("Kein Bild in der Zwischenablage!")
            Exit Sub
        End If
        PictureHandle()

    End Sub
    Private Sub PictureHandle()
        Dim ergeb As DialogResult
        Dim thumbName As String = dbHandling.CoverPath & IDTextBox.Text & ".jpg"

        Dim bm As Bitmap = CType(PictureBox1.Image, Bitmap)
        'BuchBilderBindingSource.AddNew()
        'BookIDTextBox.Text = IDTextBox.Text
        If PictureBox1 IsNot Nothing Then
            imageResize(bm)
            ImagePictureBox.Image = PictureBox1.Image
        End If
        If File.Exists(thumbName) Then
            ergeb = MessageBox.Show("Ersetzen oder abbrechen?", "Cover bereits vorhanden!", MessageBoxButtons.OKCancel)
            If ergeb = vbCancel Then Exit Sub
            File.Delete(thumbName)
        End If
        PictureBox1.Image.Save(thumbName, System.Drawing.Imaging.ImageFormat.Jpeg)


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

    Private Sub BtScann_Click(sender As Object, e As EventArgs) Handles BtScann.Click
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\BookCMS-Temp"
        Dim wiaDialog As New WIA.CommonDialog
        If (Not Directory.Exists(path) = True) Then
            ' MsgBox(path & " nicht vorhanden")
            Directory.CreateDirectory(path)
        End If
        Try
            ' Hier: Parameter etwas präzisiert (sicher ist sicher ;-)
            Dim wiaImage As WIA.IImageFile = wiaDialog.ShowAcquireImage(
              WIA.WiaDeviceType.ScannerDeviceType,
              WiaImageIntent.UnspecifiedIntent,
              WiaImageBias.MaximizeQuality,
              WIA.FormatID.wiaFormatJPEG)
            If File.Exists(path & "\temp.jpg") Then
                File.Delete(path & "\temp.jpg")
            End If
            wiaImage.SaveFile(path & "\temp.jpg")
            PictureBox1.Load(path & "\temp.jpg")

        Catch ex As Exception
            MessageBox.Show(
              "Ein Fehler ist aufgetreten! Überprüfen Sie ob das Gerät Eingeschaltet und angeschlossen ist." &
              Environment.NewLine & ex.Message)

        End Try
        '    Try
        '        Me._twain32.Acquire()
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try
        'End Sub
        'Private Sub AcquireCompletedEventHandler(ByVal sender As Object, ByVal e As EventArgs) Handles _twain32.AcquireCompleted
        '    If (_twain32.ImageCount < 0) Then Exit Sub

        '    Dim bmp As New Bitmap(_twain32.GetImage(0))
        '    PictureBox1.Image = bmp
        PictureHandle()
    End Sub
End Class