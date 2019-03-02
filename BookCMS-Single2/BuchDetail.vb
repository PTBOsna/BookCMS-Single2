
Imports System.IO
Imports wia
Public Class BuchDetail

    Dim id As String = ""

    Dim editOnline As Boolean = False
    Sub New(openArgs As String)
        InitializeComponent()
        id = openArgs

    End Sub
    Private Sub BuchDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_BookCMS_singleDataSet.Bindung". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.BindungTableAdapter.Fill(Me._BookCMS_singleDataSet.Bindung)
        Me.AutorRolleTableAdapter.Fill(Me._BookCMS_singleDataSet.AutorRolle)
        Me.PersonTableAdapter.Fill(Me._BookCMS_singleDataSet.Person)
        Me.LanguageTableAdapter.Fill(Me._BookCMS_singleDataSet.Language)
        Me.SerienTableAdapter.Fill(Me._BookCMS_singleDataSet.Serien)
        Me.StandortTableAdapter.Fill(Me._BookCMS_singleDataSet.Standort)
        Me.DruckereiTableAdapter.Fill(Me._BookCMS_singleDataSet.Druckerei)
        Me.VerlagTableAdapter.Fill(Me._BookCMS_singleDataSet.Verlag)
        Me.VerlagsOrtTableAdapter.Fill(Me._BookCMS_singleDataSet.VerlagsOrt)
        Me.GenreLinkTableAdapter.Fill(Me._BookCMS_singleDataSet.GenreLink)
        Me.SachgruppeTableAdapter.Fill(Me._BookCMS_singleDataSet.Sachgruppe)
        Me.BuchTypTableAdapter.Fill(Me._BookCMS_singleDataSet.BuchTyp)
        Me.AutorBuchLinkTableAdapter.Fill(Me._BookCMS_singleDataSet.AutorBuchLink)
        Me.BuchTableAdapter.Fill(Me._BookCMS_singleDataSet.Buch)
        Dim currID As String = Nothing
        'Scannerauswahl
        'Try
        '    _twain32.OpenDSM()
        '    'Fill list of data sorces
        '    Me.dataSourcesToolStripComboBox.Items.Clear()
        '    For i = 0 To Me._twain32.SourcesCount - 1 Step 1
        '        Me.dataSourcesToolStripComboBox.Items.Add(Me._twain32.GetSourceProductName(i))
        '    Next
        '    If Me._twain32.SourcesCount > 0 Then
        '        Me.dataSourcesToolStripComboBox.SelectedIndex = Me._twain32.SourceIndex
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        currID = dbHandling.CoverPath & id & ".jpg"
        ' currID = dbHandling.CoverPath & id & ".jpg"
        BuchBindingSource.Filter = "ID=" & id
        If File.Exists(currID) Then
            ImagePictureBox1.Load(currID)
        Else
            ImagePictureBox1.Image = My.Resources.buchAdd
        End If
        '  MsgBox(BuchBindingSource.Count.ToString)
        AutorBuchLinkBindingSource.Filter = "BuchID=" & id
        'aus BuchBindingSource VerlagsID holen
        Dim rwBuch = DirectCast(DirectCast(BuchBindingSource.Current, DataRowView).Row, _BookCMS_singleDataSet.BuchRow)
        If rwBuch.IsVerlagsIDNull Then MsgBox("VerlagsID is DBNull")

        'Prüfen, ob Autor vorhanden
        If AutorBuchLinkBindingSource.Count <> 0 Then

            AutorBuchLinkDataGridView1.Visible = True
        Else
            MsgBox("Kein Autor vorhanden!, Bitte überprüfen!")
            'Dim f As New BuchAutorEdit(id)
            'f.ShowDialog()
            'AutorBuchLinkTableAdapter.Fill(_BookCMS_singleDataSet.AutorBuchLink)
            '' AutorBuchLinkDataGridView1.Visible = False
        End If


        'BuchBilderBindingSource.Filter = "BookID=" & id
        GenreLinkBindingSource.Filter = "BuchID=" & id

        ' MsgBox("Genere: " & GenreLinkBindingSource.Count)
        ' Dim genre = From p In _BookCMS_singleDataSet.Sachgruppe Select p
        Dim genre = From p In _BookCMS_singleDataSet.Sachgruppe Select p

        For Each eintrag In genre
            CheckedListBox1.Items.Add(eintrag.Sachgruppe)
        Next

        CheckedListBox1.DataSource = genre.AsDataView
        ' CheckedListBox1.DataSource = SachgruppeBindingSource
        CheckedListBox1.DisplayMember = "Sachgruppe"
        CheckedListBox1.ValueMember = "GenreID"
        setCheckBox()
        listBoxFill()
        BtSaveImage.Visible = False
        LblSpeicherOrt.Visible = False
        Export()
    End Sub
    Private Sub setCheckBox()

        For i = 0 To GenreLinkDataGridView.RowCount - 1
            Dim dummy As String = GenreLinkDataGridView.Rows(i).Cells(1).Value.ToString
            'CheckedListBox1.SelectedValue = dummy
            '' MsgBox(i & "-" & dummy)
            'CheckedListBox1.SetItemChecked(CheckedListBox1.SelectedIndex, True)

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
            If Not oem.Row Is Nothing Then
                If CheckedListBox1.GetItemChecked(j) Then
                    ListBox1.Items.Add(oem.Row(0).ToString & "-" & oem.Row(2).ToString)
                End If
            End If
        Next
    End Sub
    Private Sub saveAll()
        SachgruppeTableAdapter.Update(_BookCMS_singleDataSet.Sachgruppe)
        PersonTableAdapter.Update(_BookCMS_singleDataSet.Person)
        AutorRolleTableAdapter.Update(_BookCMS_singleDataSet.AutorRolle)
        AutorBuchLinkTableAdapter.Update(_BookCMS_singleDataSet.AutorBuchLink)
        GenreLinkTableAdapter.Update(_BookCMS_singleDataSet.GenreLink)
        TableAdapterManager.UpdateAll(_BookCMS_singleDataSet)
    End Sub

    Private Sub BuchDetails_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Validate() 'nochn Bug: DGV kriegt beim Disposen einen ZeilenIndex-Fehler, wenn sich die ZufügeZeile im Edit-Modus befindet        Me.SuspendLayout()
        With Me.Controls
            'Controls könnten sich theor. auch gegenseitig disposen, über Events. dieses hier disposed ganz sicher immer das letzte Element was noch da ist
            While .Count > 0 : .Item(.Count - 1).Dispose() : End While
        End With
    End Sub

    Private Sub SpeichernToolStripButton_Click(sender As Object, e As EventArgs) Handles SpeichernToolStripButton.Click
        Validate()
        SaveChangeGenre()
        BuchBindingSource.EndEdit()
        'BuchBilderBindingSource.EndEdit()
        SerienBindingSource.EndEdit()
        GenreLinkBindingSource.EndEdit()
        SachgruppeBindingSource.EndEdit()
        LanguageBindingSource.EndEdit()
        StandortBindingSource.EndEdit()
        ' BuchBilderBindingSource.EndEdit()
        PersonBindingSource.EndEdit()
        AutorBuchLinkBindingSource.EndEdit()
        AutorRolleBindingSource.EndEdit()
        saveAll()
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


    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Dim openArgs As String = ""
        dbHandling.BuchVorhanden = True
        If ISBNTextBox.Text = Nothing Then
            openArgs = TitelTextBox.Text & "#" & IDTextBox.Text
        Else
            openArgs = ISBNTextBox.Text & "#" & IDTextBox.Text
        End If

        Dim f As New DNBConnect(openArgs)
        f.ShowDialog()
        dbHandling.BuchVorhanden = False
        editOnline = True
    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        If editOnline = False Then
            AutorBuchLinkBindingSource.Filter = "BuchID=" & id
            If AutorBuchLinkBindingSource.Count = 0 Then
                MsgBox("Bitte Autor eingeben!")
                Exit Sub
            End If
            SaveChangeGenre()
            Validate()
            BuchBindingSource.EndEdit()
            ' BuchBilderBindingSource.EndEdit()
            SerienBindingSource.EndEdit()
            GenreLinkBindingSource.EndEdit()
            SachgruppeBindingSource.EndEdit()
            LanguageBindingSource.EndEdit()
            StandortBindingSource.EndEdit()

            PersonBindingSource.EndEdit()
            AutorBuchLinkBindingSource.EndEdit()
            AutorRolleBindingSource.EndEdit()
            ' If _BookCMS_singleDataSet.HasChanges() Then
            If MsgBox("Änderungen ok?", vbYesNo) = vbNo Then Exit Sub
                If PictureBox1.Image IsNot Nothing Then
                    PictureHandle()
                End If
                saveAll()
            End If
        '  End If
        '_twain32.CloseDSM()
        '_twain32.CloseDataSource()
        '_twain32.Dispose()
        Me.Close()
    End Sub
    'Korrektur eines WinForm-Bugs beim Schließen des DataGridViews
    Private Sub form4_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Validate() 'nochn Bug: DGV kriegt beim Disposen einen ZeilenIndex-Fehler, wenn sich die ZufügeZeile im Edit-Modus befindet
        Me.SuspendLayout()
        With Me.Controls
            'Controls könnten sich theor. auch gegenseitig disposen, über Events. dieses hier disposed ganz sicher immer das letzte Element was noch da ist
            While .Count > 0 : .Item(.Count - 1).Dispose() : End While
        End With
    End Sub

    Private Sub btClipbord_Click(sender As Object, e As EventArgs) Handles btClipbord.Click
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

        If PictureBox1 IsNot Nothing Then
            imageResize(bm)
            ImagePictureBox1.Image = PictureBox1.Image
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


    Private Sub Export()
        Dim ExportStr As String = Nothing
        ExportStr = TitelTextBox.Text & vbCrLf & vbCrLf
        ExportStr += TitelTextBox.Text & vbCrLf
        If Not String.IsNullOrEmpty(UntertitelTextBox.Text) Then
            ExportStr += UntertitelTextBox.Text & vbCrLf
        End If
        ExportStr += "Autor: " & AutorSortTextBox.Text & vbCrLf
        ExportStr += "Verlag: " & CbVerlag.Text & vbCrLf
        If Not String.IsNullOrEmpty(AuflageTextBox.Text) Then
            ExportStr += "Auflage: " & AuflageTextBox.Text & vbCrLf
        End If
        If Not String.IsNullOrEmpty(VeroeffentlichtTextBox.Text) Then
            ExportStr += "Veröffentlicht: " & VeroeffentlichtTextBox.Text & vbCrLf
        End If
        If Not String.IsNullOrEmpty(VerkaufspreisTextBox.Text) Then
            ExportStr += "Neupreis: " & VerkaufspreisTextBox.Text
        End If
        If Not String.IsNullOrEmpty(VerkaufspreisTextBox.Text) Then
            ExportStr += "Neupreis: " & VerkaufspreisTextBox.Text & vbCrLf & vbCrLf
        End If
        ExportStr += "Gebraucht. Preis zzgl 5 € Versandkosten"
        TextBox1.Text = ExportStr

        If ImagePictureBox1 IsNot Nothing Then

            PictureBox2.Image = ImagePictureBox1.Image
            BtSaveImage.Visible = True
            LblSpeicherOrt.Visible = True
        End If
    End Sub

    Private Sub BtSaveImage_Click(sender As Object, e As EventArgs) Handles BtSaveImage.Click
        Dim bildPfad As String = Nothing
        With FolderBrowserDialog1
            .Description = "Speicherort für Cover-Export"
            .RootFolder = Environment.SpecialFolder.CommonPictures
            If .ShowDialog = DialogResult.OK Then
                bildPfad = .SelectedPath & "\"
            End If
        End With

        PictureBox2.Image.Save(bildPfad & Format(Now, "dd-mm-yy") & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        LblSpeicherOrt.Text = bildPfad & Format(Now, "dd-mm-yy") & ".jpg"
    End Sub

    Private Sub BtScann_Click(sender As Object, e As EventArgs) Handles BtScann.Click
        ScanImage()
        'Try
        '    Me._twain32.Acquire()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        'Dim CD As New WIA.CommonDialog
        'Dim F As WIA.ImageFile = CD.ShowAcquireImage(WIA.WiaDeviceType.ScannerDeviceType)

        'PictureBox1.Image = F
        '' F.SaveFile("C:\Temp\WIA." + F.FileExtension)

    End Sub
    'Private Sub AcquireCompletedEventHandler(ByVal sender As Object, ByVal e As EventArgs) Handles _twain32.AcquireCompleted
    '    If (_twain32.ImageCount < 0) Then Exit Sub

    '    Dim bmp As New Bitmap(_twain32.GetImage(0))
    '    PictureBox1.Image = bmp
    '    PictureHandle()
    'End Sub
    Public Function ScanImage() As Boolean
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
            Return True
        Catch ex As Exception
            MessageBox.Show(
              "Ein Fehler ist aufgetreten! Überprüfen Sie ob das Gerät Eingeschaltet und angeschlossen ist." &
              Environment.NewLine & ex.Message)
            Return Nothing
        End Try
    End Function
    Private Sub AutorBuchLinkDataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles AutorBuchLinkDataGridView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            AutorBuchLinkDataGridView1.Rows.Remove(AutorBuchLinkDataGridView1.CurrentRow)
        End If

    End Sub

    Private Sub BtnAddAutor_Click(sender As Object, e As EventArgs) Handles BtnAddAutor.Click
        Dim newBuchAutor = _BookCMS_singleDataSet.AutorBuchLink.NewAutorBuchLinkRow
        With newBuchAutor
            .BuchID = CInt(id)
            .PersonID = CInt(CBPerson.SelectedValue)
            .RolleID = CInt(CBRolle.SelectedValue)
        End With
        _BookCMS_singleDataSet.AutorBuchLink.AddAutorBuchLinkRow(newBuchAutor)
        AutorBuchLinkBindingSource.Filter = "BuchID=" & id.ToString
        ActAutorSort()
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If AutorBuchLinkDataGridView1.Rows.Count > 0 Then
            Try
                AutorBuchLinkDataGridView1.Rows.Remove(AutorBuchLinkDataGridView1.CurrentRow)
                ActAutorSort()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub ActAutorSort()
        Dim dummy As Integer = 0
        Dim sTempAutor As String = Nothing
        Dim sAutor As String = Nothing
        If AutorBuchLinkDataGridView1.Rows.Count > 0 Then
            For i = 0 To AutorBuchLinkDataGridView1.Rows.Count - 1 '-2, da die AddNew-Reihe mit gezählt wird

                dummy = CInt(AutorBuchLinkDataGridView1.Rows.Item(i).Cells(1).Value)
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

    Private Sub AutorSortTextBox_Click(sender As Object, e As EventArgs) Handles AutorSortTextBox.Click
        ActAutorSort()
    End Sub
End Class