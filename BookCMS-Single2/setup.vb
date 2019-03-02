Imports System.IO
Public Class setup
    Dim AppPath As String = System.AppDomain.CurrentDomain.BaseDirectory
    Dim a As String = CType(Environment.SpecialFolder.System.ApplicationData.LocalApplicationData, String)
    Dim DataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.System.ApplicationData.LocalApplicationData)
    Private Sub setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mpath As String = Nothing
        'SpecalFolder auslesen
        lblAppPath.Text = "Anwendungspfad: " & AppPath
        lblDataPath.Text = "Datenpfad: " & DataPath
        mpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System.ApplicationData.LocalApplicationData), "BookCMS")
        MsgBox(mpath)
        'ListBox1.Items.Clear()
        Try
            Dim filea() As String = IO.Directory.GetFiles(mpath, "*.*", IO.SearchOption.AllDirectories)
            For Each file In filea
                ListBox1.Items.Add(file)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class