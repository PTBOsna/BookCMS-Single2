Public Class settings
    Dim hnd As New dbHandling
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutorRolleTableAdapter.Fill(Me._BookCMS_singleDataSet.AutorRolle)

        hnd.TxtReader()
        TxtApplicationPath.Text = dbHandling.sDataPath
        TxtCover.Text = dbHandling.CoverPath
        TxtWebDNB.Text = dbHandling.WebDNB
        LblCurrDB.Text = "Aktuelle Datenbank: " & hnd.dbName
        If String.IsNullOrEmpty(dbHandling.StartRolle) Then
            CbStartRolle.Text = "Bitte auswählen"
        Else
            CbStartRolle.SelectedValue = CInt(dbHandling.StartRolle)
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TxtWebDNB.Text.Contains("http:") Or TxtWebDNB.Text.Contains("https:") Then
            Process.Start(TxtWebDNB.Text)
        Else
            Process.Start("http:\\wwww.ing-buero-ptb-berlin.de")
        End If
    End Sub
    Private Sub BtDaten_Click(sender As Object, e As EventArgs) Handles BtDaten.Click
        With FolderBrowserDialog2
            .Description = "Bitte Datenordner auswählen"
            .SelectedPath = System.AppDomain.CurrentDomain.BaseDirectory
            .ShowDialog()
            If String.IsNullOrEmpty(.SelectedPath) Then Exit Sub
            TxtApplicationPath.Text = .SelectedPath
        End With
    End Sub
    Private Sub BtCoverDialog_Click(sender As Object, e As EventArgs) Handles BtCoverDialog.Click
        With FolderBrowserDialog1
            .Description = "Bitte Ordner für die Buch-Cover auswählen"
            .SelectedPath = System.AppDomain.CurrentDomain.BaseDirectory
            .ShowDialog()
            If String.IsNullOrEmpty(.SelectedPath) Then Exit Sub
            TxtCover.Text = .SelectedPath
        End With
    End Sub
    Private Sub BtCancel_Click(sender As Object, e As EventArgs) Handles BtCancel.Click
        Close()
    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        dbHandling.sDataPath = TxtApplicationPath.Text
        dbHandling.CoverPath = TxtCover.Text
        dbHandling.WebDNB = TxtWebDNB.Text
        If CbStartRolle.SelectedIndex <> -1 Then
            dbHandling.StartRolle = CbStartRolle.SelectedValue.ToString
        End If
        hnd.TxtWriter()
        MsgBox("Änderungen werden erst nach Neustart des Programms wirksam!")
        Close()
    End Sub
End Class