Imports System.ComponentModel
Imports System.Configuration
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1

    Dim BookID As String = Nothing
    Dim selDB As New dbHandling
    Dim tempPath As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MsgBox(selDB.dbName & vbCrLf & dbHandling.sDataPath & vbCrLf & dbHandling.CurrDB)
        'Vorbereitung DB
        'Prüfen ob eine DB-Datei vorhanden
        selDB.TxtReader()
        If dbHandling.sDataPath = Nothing Then
            dbHandling.sDataPath = IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Daten")
        End If

        Dim Files() As String = Directory.GetFiles(dbHandling.sDataPath, "BookCMS*.accdb")
        'je nach Anzahl der gefundenen Dateien handeln
        Select Case Files.Length
            Case 0 ' keine Startdatei vorhanden, also suchen
                MyFileDialog("Bitte die Start-DB auswählen!")
            Case 1  ' eine Startdatei vorhanden
                If IO.Path.GetFileName(Files(0)) = selDB.dbName Then
                    ' MsgBox(Files(0))
                    dbHandling.CurrDB = Files(0)
                Else
                    MyFileDialog("Bitte die Datenbank auswählen!")
                    selDB.dbName = IO.Path.GetFileName(dbHandling.CurrDB)
                    dbHandling.sDataPath = IO.Path.GetDirectoryName(dbHandling.CurrDB)
                End If

            Case > 1 'Mehrere DB-Dateien vorhanden: eine auswählen
                MyFileDialog("Es sind mehrere Dateien vorhanden! Bitte die Start-DB auswählen!")
            Case Else
                MsgBox("Keine Datei vorhanden. Anwendung wird geschlossen")
                Close()
        End Select
        'Die INI aktualisieren
        selDB.TxtWriter()

        'und den connectionString aktualiseren
        Dim MeinNeuerConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & dbHandling.CurrDB & "'"
        My.Settings.SetUserOverride("BookCMS_singleConnectionString", MeinNeuerConnectionString)
        dbHandling.conStr = MeinNeuerConnectionString

        ToolStripStatusLabel2.Text = My.Settings.BookCMS_singleConnectionString
        Dim currID As String = Nothing
        BuchDataGridView.Dock = DockStyle.Fill
        PersonBuchDataGridView.Dock = DockStyle.Fill
        PersonBuchDataGridView.Visible = False
        Button1.Visible = False
        TextBox2.Text = ""
        CbKategorie.Text = "Bitte auswählen"
        CBSachgruppe.Text = "Bitte auswählen"

        ''Vorbereitungen
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\BookCMS-Temp"
        If (Not Directory.Exists(path) = True) Then
            ' MsgBox(path & " nicht vorhanden")
            Directory.CreateDirectory(path)
        End If
        'dbHandling.AddConnectionStrings()
        'End
        Cursor.Current = Cursors.WaitCursor
        'ToolStrip1.Width = CInt(Me.Width * 0.5)
        ToolStripProgressBar1.Visible = False

        'Vorbereitung
        Cursor.Current = Cursors.WaitCursor
        'testen ob Access installiert ist 
        If Not selDB.CheckForSoftwareInstallation("access") = True Then
            Me.TopMost = True
            MsgBox("Microsoft Access ist nicht installiert!" & vbCrLf & "Wenn nicht vorhanden, bitte die kostenlose Runtime" & vbCrLf & "https://www.microsoft.com/de-de/download/details.aspx?id=4438" & vbCrLf & "installieren und FreeDMS neu starten!")
            End
        End If

        'Vorbereiten für Datei
        'Aufräumen

        For Each a As String In IO.Directory.GetFiles(tempPath)
            Try
                File.Delete(a)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Next

        If Not File.Exists(dbHandling.CurrDB) Then
            MsgBox("Die Datenbank-Datei fehlt oder wurde verschoben!" & vbCrLf & "Die Anwendung wird geschlossen!")
            End
        End If
        LoadAll()
        FillTVTitel()
        FillTreeView(7)
        CbRolle.Visible = False
        CbRolle.SelectedValue = 7
        'Aktuelles Cover laden und anzeigen
        If BuchDataGridView.Rows.Count > 0 Then
            currID = dbHandling.CoverPath & BuchDataGridView.Rows(BuchDataGridView.CurrentRow.Index).Cells(0).Value.ToString & ".jpg"
        End If
        'MsgBox(dbHandling.sDataPath & "thumbs\")
        If File.Exists(currID) Then
            CoverPictureBox.Load(currID)
        Else
            CoverPictureBox.Image = My.Resources.buchAdd
        End If
        Me.WindowState = FormWindowState.Maximized
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub MyFileDialog(ByVal sTitel As String)
        With OpenFileDialog1
            .Title = sTitel
            .Filter = "BookCMS (BookCMS*.accdb)|BookCMS*.accdb"
            .InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory
            .FileName = ""
            .ShowDialog()
            If String.IsNullOrEmpty(.FileName) Then Exit Sub
            dbHandling.CurrDB = .FileName
            'prüfen of entsprechende xml-Datei existiert 
        End With
    End Sub

    Private Sub FirstStart()
        'Beim 1. Start wird der Pfad der App als appDataPath genommen
        If dbHandling.sDataPath = Nothing Then
            dbHandling.sDataPath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Daten\BookCMS-single.accdb")
            ' Dim sDataPath As String = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Daten\BookCMS-single.accdb")
            'Dim appDataPath As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile.ApplicationData.LocalApplicationData), "BookCMS\BookCMS-single.accdb")
            dbHandling.sDataPath = System.IO.Path.GetDirectoryName(dbHandling.sDataPath)
            selDB.dbName = "BookCMS-single.accdb"
            selDB.TxtWriter()
        End If
    End Sub

    Private Sub LoadAll()
        Me.GenreLinkTableAdapter.Fill(Me._BookCMS_singleDataSet.GenreLink)
        Me.AutorBuchLinkTableAdapter.Fill(Me._BookCMS_singleDataSet.AutorBuchLink)
        Me.PersonTableAdapter.Fill(Me._BookCMS_singleDataSet.Person)
        Me.StandortTableAdapter.Fill(Me._BookCMS_singleDataSet.Standort)
        Me.SachgruppeTableAdapter.Fill(Me._BookCMS_singleDataSet.Sachgruppe)
        Me.BuchTypTableAdapter.Fill(Me._BookCMS_singleDataSet.BuchTyp)
        VerlagTableAdapter.Fill(Me._BookCMS_singleDataSet.Verlag)
        Me.BuchTableAdapter.Fill(Me._BookCMS_singleDataSet.Buch)
        Me.AutorRolleTableAdapter.Fill(Me._BookCMS_singleDataSet.AutorRolle)
        Me.PersonBuchTableAdapter.Fill(Me._BookCMS_singleDataSet.PersonBuch)
        'PersonBuchBindingSource.Filter = "Bibliothek=" & selDB.currBiblio
        'PersonBuchBindingSource.Sort = "SortBy"
        'PersonBuchBindingSource1.Filter = "Bibliothek=" & selDB.currBiblio
        'PersonBuchBindingSource1.Sort = "SortBy"

        lblFound.Text = "Gefunden: " & BuchBindingSource.Count.ToString
    End Sub
    Private Sub SaveAll()
        Cursor.Current = Cursors.WaitCursor
        Validate()
        ' BuchPersonBindingSource.EndEdit()
        BuchTypBindingSource.EndEdit()
        VerlagBindingSource.EndEdit()
        AutorBuchLinkBindingSource.EndEdit()
        SachgruppeBindingSource.EndEdit()
        GenreLinkBindingSource.EndEdit()
        Try
            TableAdapterManager.UpdateAll(_BookCMS_singleDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Cursor.Current = Cursors.Default

    End Sub
    Private Sub FillTVTitel()
        TVTitel.Nodes.Clear()
        Dim topNode As New TreeNode("Titel")
        'TVPerson.Nodes.Add(topNode)
        topNode.Tag = "r;0"
        TVTitel.Font = New Font("Arial", 10, FontStyle.Bold)
        topNode.NodeFont = New Font(FontFamily.GenericSansSerif, FontStyle.Bold)
        topNode.Tag = "0"
        'Add topNode to the TreeView.
        TVTitel.Nodes.Add(topNode)

        Dim NodeAlpha As TreeNode 'NodeMandant

        NodeAlpha = New TreeNode()
        'NodeTitel = New TreeNode()
        For i As Integer = 48 To 57
            NodeAlpha = New TreeNode(Chr(i)) 'With {
            topNode.NodeFont = New Font("Arial", 9, FontStyle.Bold)
            topNode.Nodes.Add(NodeAlpha) 'TVPerson.Nodes.Add(NodeMandant)
            NodeAlpha.Tag = i
        Next
        For I As Integer = 65 To 90
            NodeAlpha = New TreeNode(Chr(I)) 'With {
            topNode.NodeFont = New Font("Arial", 9, FontStyle.Bold)
            topNode.Nodes.Add(NodeAlpha) 'TVPerson.Nodes.Add(NodeMandant)
            NodeAlpha.Tag = I

        Next
        topNode.Expand()
    End Sub
    Private Sub FillTreeView(ByVal rolle As Integer)
        TVPerson.Nodes.Clear()
        Dim topNode As New TreeNode("Namen")
        'TVPerson.Nodes.Add(topNode)
        topNode.Tag = "t;0"
        TVPerson.Font = New Font("Arial", 10, FontStyle.Bold)
        topNode.NodeFont = New Font(FontFamily.GenericSansSerif, FontStyle.Bold)
        'Add topNode to the TreeView.
        TVPerson.Nodes.Add(topNode)
        Dim NodeAlpha As TreeNode 'NodeMandant
        Dim NodeAutor As TreeNode
        Dim sChar As Integer = 0
        NodeAlpha = New TreeNode()
        NodeAutor = New TreeNode()

        For I As Integer = 65 To 90
            sChar = I
            NodeAlpha = New TreeNode(Chr(I)) 'With {
            '    .Name = myMandant.id.ToString
            '}
            topNode.NodeFont = New Font("Arial", 9, FontStyle.Bold)
            topNode.Nodes.Add(NodeAlpha) 'TVPerson.Nodes.Add(NodeMandant)
            NodeAlpha.Tag = "#;" & I.ToString

            'SubNode Name

            Dim myAutor = From p In _BookCMS_singleDataSet.PersonBuch Where p.SortBy(0) = Chr(sChar) And p.RolleID = rolle Group By p.SortBy, p.PersonID Into Group Order By SortBy
            ' MsgBox(myAutor.Count.ToString)
            For Each autor In myAutor
                If Not IsDBNull(autor.SortBy) Then
                    NodeAutor = New TreeNode(autor.SortBy, 0, 0) 'With {
                    '    .Name = myAkte.id.ToString
                    '}

                    NodeAlpha.Nodes.Add(NodeAutor)
                    NodeAutor.Tag = "a;" & autor.PersonID
                    'NodeAutor.Collapse()
                End If
            Next
        Next

        topNode.Expand()

    End Sub
    Private Sub TVTitel_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVTitel.AfterSelect
        Dim id As String = Nothing
        Dim selTag As Integer = CInt(TVTitel.SelectedNode.Tag)
        Dim sString As String = "Titel like'" '"Bibliothek = " & selDB.currBiblio & " AND Titel like '"
        ' MsgBox(selTag.ToString)
        Select Case selTag
            Case 48 To 57
                sString = sString + Chr(selTag) + "*'"
            Case 65 To 90
                Select Case selTag
                    Case 65
                        sString = sString + "A*' OR Titel like 'Ä*'"
                    Case 79
                        sString = sString + "O*' OR Titel like 'Ö*'"
                    Case 85
                        sString = sString + "U*' OR Titel like 'Ü*'"
                    Case Else
                        sString = sString + Chr(selTag) + "*'"
                End Select
            Case Else
                sString = sString + "*'"
        End Select
        ' MsgBox(sString)
        BuchBindingSource.Filter = sString
        BuchBindingSource.Sort = "Titel"
        lblFound.Text = "Gefunden: " & BuchBindingSource.Count.ToString
        If BuchBindingSource.Count = 0 Then
            MsgBox("Kein Eintrag")
            'BuchBindingSource.Filter = "Bibliothek=" & selDB.currBiblio
            'BuchBindingSource.Sort = "Titel"
            Exit Sub
        End If
        'PersonBuchBindingSource1.Filter = sString
        'If PersonBuchBindingSource1.Count = 0 Then
        '    MsgBox("Kein Eintrag")
        '    PersonBuchBindingSource1.Filter = "Bibliothek=" & selDB.currBiblio
        '    Exit Sub
        'End If
        MarkBook()
        id = GetBooK_ID()
        If id <> "#" Then
            BuchBindingSource1.Filter = "id=" & id '& "AND Bibliothek=" & selDB.currBiblio
            BuchBindingSource.Sort = "Titel"
            LoadCover(id)
        End If
    End Sub

    Private Sub TVPerson_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVPerson.AfterSelect
        Dim sNode() As String
        Dim Filter As String = Nothing
        Dim id As String = Nothing
        sNode = Split(TVPerson.SelectedNode.Tag.ToString, ";")
        Select Case sNode(0)
            Case "t"
                Filter = "SortBy like '*' And RolleID=" & CbRolle.SelectedValue.ToString '& " AND Bibliothek=" & selDB.currBiblio
            Case "#"
                Filter = "SortBy like '" & Chr(CInt(sNode(1))) & "*' And RolleID=" & CbRolle.SelectedValue.ToString '& " AND Bibliothek=" & selDB.currBiblio
            Case Else
                Filter = "PersonID=" & sNode(1) & " And RolleID=" & CbRolle.SelectedValue.ToString ' & " AND Bibliothek=" & selDB.currBiblio
        End Select

        'MsgBox("AutorSort like '*" & tNode & "*'")
        PersonBuchBindingSource1.Filter = Filter
        PersonBuchBindingSource1.Sort = "SortBy"
        If PersonBuchBindingSource1.Count = 0 Then
            MsgBox("Kein Eintrag")
            'PersonBuchBindingSource1.Filter = "Bibliothek=" & selDB.currBiblio
            'PersonBuchBindingSource1.Sort = "SortBy"
            Exit Sub
        End If
        'BuchBilderBindingSource.Filter = "BookID=" &
        lblFound.Text = "Gefunden: " & PersonBuchBindingSource1.Count.ToString
        ''Abfrage zur Cover-Anzeige
        'If BuchBindingSource.Count = 0 Then Exit Sub
        MarkPersonBook()
        id = GetPersonBook_ID()
        If id <> "#" Then
            BuchBindingSource1.Filter = "id=" & id
            LoadCover(id)
        End If


    End Sub
    Private Function MarkBook() As Boolean
        Try
            BuchDataGridView.CurrentCell = BuchDataGridView.Rows(0).Cells(1)
            BuchDataGridView.Rows(0).Selected = True
        Catch ex As Exception
            MarkBook = False
            Exit Function
        End Try
        MarkBook = True
    End Function

    Private Function MarkPersonBook() As Boolean
        Try
            PersonBuchDataGridView.CurrentCell = PersonBuchDataGridView.Rows(0).Cells(1)
        Catch ex As Exception
            MarkPersonBook = False
            Exit Function
        End Try
        MarkPersonBook = True
    End Function
    Private Sub PersonBuchDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PersonBuchDataGridView.CellClick
        If PersonBuchDataGridView.Rows.Count = 0 Then
            MsgBox("Kein Eintrag")
            Exit Sub
        End If
        BookID = GetPersonBook_ID()
        If BookID <> "#" Then
            BuchBindingSource1.Filter = "ID=" & BookID
            LoadCover(BookID)
            ToolStripStatusLabel1.Text = "ID " & BookID
        Else
            MsgBox("Kein Eintrag vorhanden")
        End If
    End Sub
    Private Sub BuchDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BuchDataGridView.CellClick

        If BuchDataGridView.Rows.Count = 0 Then
            MsgBox("Kein Eintrag")
            Exit Sub
        End If

        BookID = GetBooK_ID()

        If BookID <> "#" Then
            BuchBindingSource1.Filter = "ID=" & BookID
            ToolStripStatusLabel1.Text = "ID " & BookID
            LoadCover(BookID)
        End If



    End Sub
    Private Sub LoadCover(ByVal id As String)
        Dim coverID As String = dbHandling.CoverPath & id & ".jpg"
        ' MsgBox(dbHandling.sDataPath & "thumbs\")
        If File.Exists(coverID) Then
            CoverPictureBox.Load(coverID)
        Else
            CoverPictureBox.Image = My.Resources.buchAdd
        End If
    End Sub


    Private Sub CbRolle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbRolle.SelectedIndexChanged
        If CbRolle.SelectedIndex <> -1 Then
            FillTreeView(CInt(CbRolle.SelectedValue))
        End If
    End Sub

    Private Sub BibliothekenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BibliothekenToolStripMenuItem.Click
        'Dim f As New ListeBibliotheken
        'f.ShowDialog()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click, ToolStripButtonClose.Click
        SaveAll()
        Close()
    End Sub

    Private Sub BuchTypToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuchTypToolStripMenuItem.Click
        'Dim f As New ListeBookType
        'f.ShowDialog()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim id As String = Nothing
        Select Case TabControl1.SelectedIndex
            Case 0
                BuchBindingSource.RemoveFilter()
                lblFound.Text = "Gefunden: " & BuchBindingSource1.Count.ToString
                'PersonBuchDataGridView.DataSource = BuchBindingSource
                BuchDataGridView.Visible = True
                PersonBuchDataGridView.Visible = False
                CbRolle.Visible = False
                BuchDataGridView.CurrentCell = BuchDataGridView.Rows(0).Cells(1)
                '  BuchDataGridView.Rows(0).Cells(1).Selected = True
                id = GetBooK_ID()
                If id <> "#" Then
                    BuchBindingSource1.Filter = "id=" & id
                    LoadCover(id)
                End If
            Case 1
                PersonBuchBindingSource1.RemoveFilter()
                lblFound.Text = "Gefunden: " & PersonBuchBindingSource1.Count.ToString
                CbRolle.Visible = True
                BuchDataGridView.Visible = False
                PersonBuchDataGridView.Visible = True
                PersonBuchDataGridView.CurrentCell = PersonBuchDataGridView.Rows(0).Cells(1)
                id = GetPersonBook_ID()
                If id <> "#" Then
                    BuchBindingSource1.Filter = "id=" & id
                    LoadCover(id)
                End If


        End Select
    End Sub
    Private Function GetPersonBook_ID() As String
        Dim rwBuch = DirectCast(DirectCast(PersonBuchBindingSource1.Current, DataRowView).Row, _BookCMS_singleDataSet.PersonBuchRow)
        If rwBuch.BuchID <> 0 Then
            Return rwBuch.BuchID.ToString
        Else
            Return "#"
        End If
    End Function
    Private Function GetBooK_ID() As String
        Dim rwBuch = DirectCast(DirectCast(BuchBindingSource.Current, DataRowView).Row, _BookCMS_singleDataSet.BuchRow)
        If rwBuch.ID <> 0 Then
            Return rwBuch.ID.ToString
        Else
            Return "#"
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        showDetails()
    End Sub
    Private Sub showDetails()
        Cursor.Current = Cursors.WaitCursor
        Dim aktIndex As Integer = BuchDataGridView.CurrentRow.Index
        'Überprüfen, ob so ok
        Dim openArgs As String
        Try
            openArgs = BookID 'DirectCast(BuchBindingSource.Current, DataRowView).Item("ID").ToString 'Variante für Option strict on!
            Dim f As New BuchDetail(openArgs)

            f.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' selectDB(selDB.dbName)
        'loadAll()
        Try
            BuchDataGridView.Rows(aktIndex).Selected = True
            BuchDataGridView.CurrentCell = BuchDataGridView.Rows(aktIndex).Cells(1)
            Cursor.Current = Cursors.Default
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        dbHandling.BuchVorhanden = False
        Dim openArgs As String = "#"
        Dim f As New DNBConnect(openArgs)
        f.ShowDialog()
        dbHandling.BuchVorhanden = True
        BuchTableAdapter.Fill(Me._BookCMS_singleDataSet.Buch)
    End Sub

    Private Sub ToolStripButtonDel_Click(sender As Object, e As EventArgs) Handles ToolStripButtonDel.Click
        Dim BookID As Integer
        Dim sTitel As String = Nothing
        Dim sPerson As String = Nothing
        Dim ax As Integer = BuchDataGridView.CurrentRow.Index

        'BuchID aus DG auslesen 
        BookID = CInt(GetBooK_ID())  'CInt(BuchDataGridView.Rows(BuchDataGridView.CurrentRow.Index).Cells(0).Value))

        'Buch Finden und als CurrentRow festlegen
        BuchBindingSource.Filter = "ID=" & BookID.ToString
        If BuchBindingSource.Count = 0 Then
            MsgBox("Buch nicht im Bestand vorhanden!")
            Exit Sub
        End If
        Dim rowCurrent = DirectCast(DirectCast(BuchBindingSource.Current, DataRowView).Row, _BookCMS_singleDataSet.BuchRow)
        sTitel = rowCurrent.Titel

        If MsgBox("Buch '" & sTitel & "' Wirklich löschen?", vbYesNo, "Buch löschen!") = vbNo Then Exit Sub
        'Person-ID finden
        AutorBuchLinkBindingSource.Filter = "BuchID=" & BookID.ToString
        If AutorBuchLinkBindingSource.Count > 0 Then
            Dim PersonCurrent = DirectCast(DirectCast(AutorBuchLinkBindingSource.Current, DataRowView).Row, _BookCMS_singleDataSet.AutorBuchLinkRow)
            AutorBuchLinkBindingSource.Filter = "PersonID=" & PersonCurrent.PersonID

            If AutorBuchLinkBindingSource.Count > 1 Then
                'Mehr als eine Verknüpfung (Autor hat mehre als einen Titel) dann nur AutorBuchLink löschen
                MsgBox("Autor wird nicht gelöscht, da weitere Titel vom Autor vorhanden sind!")
                AutorBuchLinkBindingSource.RemoveCurrent()
            Else
                'sonst Person auch noch Person löschen
                PersonBindingSource.Filter = "PersonID=" & PersonCurrent.PersonID
                AutorBuchLinkBindingSource.RemoveCurrent()
                PersonBindingSource.RemoveCurrent()
            End If
        End If
        'jetzt weiter löschen
        'Cover
        'zunächst aus Picturbox entfernen
        CoverPictureBox.Dispose()

        Try
            Kill(dbHandling.CoverPath & BookID & ".jpg")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Genre-Verknüpfung
        GenreLinkBindingSource.Filter = "BuchID=" & BookID
        If GenreLinkBindingSource.Count > 0 Then
            GenreLinkBindingSource.RemoveCurrent()
        End If
        'und das Buch
        BuchBindingSource.RemoveCurrent()
        'alles gelöscht, jetzt aktualisieren
        ' BuchDataGridView.BeginEdit(True)
        'und Update der TableAdapter 
        Try
            'BuchDataGridView.Rows.Remove(BuchDataGridView.CurrentRow)
            Validate()
            AutorBuchLinkBindingSource.EndEdit()
            PersonBindingSource.EndEdit()
            GenreLinkBindingSource.EndEdit()
            BuchBindingSource.EndEdit()
            AutorBuchLinkTableAdapter.Update(_BookCMS_singleDataSet.AutorBuchLink)
            PersonTableAdapter.Update(_BookCMS_singleDataSet.Person)
            GenreLinkTableAdapter.Update(_BookCMS_singleDataSet.GenreLink)
            BuchTableAdapter.Update(_BookCMS_singleDataSet.Buch)
            'TableAdapterManager.UpdateAll(_BookCMS_singleDataSet)
        Catch ex As Exception
            MsgBox("Fehler beim Löschen! " & vbCrLf & ex.Message)
            Exit Sub
        End Try

        MsgBox(sTitel & " wurde gelöscht.")
        BuchBindingSource.RemoveFilter()
        MarkBook()
    End Sub

    Private Sub BuchAutorVerknüpfungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuchAutorVerknüpfungToolStripMenuItem.Click
        Dim f As New CheckBuchAutorLink
        f.ShowDialog()
    End Sub

    Private Sub BuchSachgruppeVerknüpfungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuchSachgruppeVerknüpfungToolStripMenuItem.Click
        Dim f As New CheckBuchGenreLink
        f.ShowDialog()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim s As String = TextBox2.Text
        TabControl1.SelectedIndex = 0
        '   BuchTypBindingSource1.Filter = "id=0"
        BuchBindingSource.Filter = "Titel like '*" & s & "*' OR AutorSort like '*" & s & "*' OR ISBN like '*" & s & "*' OR Signatur like '*" & s & "'"
        lblFound.Text = "Gefunden: " & BuchBindingSource.Count.ToString
        MarkBook()
        Button1.Visible = True
    End Sub

    Private Sub CbKategorie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbKategorie.SelectedIndexChanged
        TabControl1.SelectedIndex = 0
        If Not CbKategorie.SelectedValue Is Nothing Then
            BuchBindingSource.Filter = "TypID = " & CbKategorie.SelectedValue.ToString
            lblFound.Text = "Gefunden: " & BuchBindingSource.Count.ToString
            MarkBook()
            Button1.Visible = True

        End If
    End Sub

    Private Sub CBSachgruppe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSachgruppe.SelectedIndexChanged
        TabControl1.SelectedIndex = 0
        If Not CBSachgruppe.SelectedValue Is Nothing Then
            BuchBindingSource.Filter = "SachgruppeID = " & CBSachgruppe.SelectedValue.ToString
            lblFound.Text = "Gefunden: " & BuchBindingSource.Count.ToString
            MarkBook()
            Button1.Visible = True

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuchBindingSource.RemoveFilter()
        'BuchBindingSource.Filter = "ID>0"
        'TabControl2.Enabled = True
        TextBox2.Text = ""
        CbKategorie.Text = "Bitte auswählen"
        CBSachgruppe.Text = "Bitte auswählen"
        Button1.Visible = False
        lblFound.Text = "Gefunden: " & BuchBindingSource.Count.ToString
        MarkBook()
    End Sub

    Private Sub ToolStripButtonAdd_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAdd.Click
        dbHandling.BuchVorhanden = False
        Dim openArgs As String = "#"

        Dim f As New BuchNeu(openArgs)

        f.ShowDialog()
        dbHandling.BuchVorhanden = True
        'loadAll()

        BuchTableAdapter.Fill(_BookCMS_singleDataSet.Buch)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click, SpeichernToolStripMenuItem.Click
        SaveAll()
    End Sub

    Public Sub StartRefresh()
        'SetCurrDoc()
        Try
            BGWRefresh.RunWorkerAsync()
            ToolStripButtonReload.Enabled = False
            ToolStripProgressBar1.Visible = True
            ' MsgBox("BW run")
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub



    Private Sub BGWRefresh_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGWRefresh.RunWorkerCompleted
        ToolStripStatusLabel1.Text = "Aktualisierung beendet"
        ToolStripProgressBar1.Visible = False
        ToolStripButtonReload.Enabled = True
        'LoadLvDok(LvScanInput)

        'DokumenteDataGridView.DataSource = DokumenteBindingSource
        'FillTreeView()
        'SetCurrDoc()

    End Sub

    Private Sub BGWRefresh_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGWRefresh.DoWork
        ToolStripStatusLabel1.Text = "Aktualisierung läuft"
        BuchBindingSource.RemoveFilter()
        PersonBuchBindingSource1.RemoveFilter()
        SaveAll()
        '----------Um aktualisierungsfehler im DG abzufangen
        Dim mCM As CurrencyManager
        mCM = CType(Me.BindingContext(BuchDataGridView), CurrencyManager)
        mCM.Refresh()
        '----------
        LoadAll()
        MarkBook()
    End Sub

    Private Sub ToolStripButtonReload_Click(sender As Object, e As EventArgs) Handles ToolStripButtonReload.Click
        StartRefresh()
        'SaveAll()
        ''selectDB(My.Settings.LastDB)
        'LoadAll()
    End Sub

    Private Sub BücherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BücherToolStripMenuItem.Click
        Dim f As New PersonenListe
        f.ShowDialog()
    End Sub

    Private Sub StandortteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandortteToolStripMenuItem.Click
        Dim f As New StandortListe
        f.ShowDialog()
    End Sub

    Private Sub SachgruppenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SachgruppenToolStripMenuItem.Click
        Dim f As New SachgruppeListe
        f.ShowDialog()
    End Sub

    Private Sub BuchTypenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuchTypenToolStripMenuItem.Click
        Dim f As New TypListe
        f.ShowDialog()
    End Sub

    Private Sub VerlageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerlageToolStripMenuItem.Click
        Dim f As New VerlagListe
        f.ShowDialog()
    End Sub

    Private Sub OptionenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionenToolStripMenuItem.Click
        Dim f As New settings
        f.ShowDialog()
    End Sub

    Private Sub SonderzeichenInTitelEntfernenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SonderzeichenInTitelEntfernenToolStripMenuItem.Click
        Dim f As New DelTitleControl
        f.ShowDialog()
    End Sub

    Private Sub VerlagsorteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerlagsorteToolStripMenuItem.Click
        Dim f As New VerlagsortListe
        f.ShowDialog()
    End Sub
End Class

