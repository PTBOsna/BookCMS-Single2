Imports System.IO
Imports System.Xml

Public Class InstallBookCMS
    'Pfade
    'für Testlauf:
    Dim Aktpath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile.LocalApplicationData) & "\BookCMS"
    'sonst:
    'Dim AktPath As String = System.AppDomain.CurrentDomain.BaseDirectory
    Dim dbPath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile.LocalApplicationData) & "\BookCMS"  'Pfad der Access-DB
    Dim AppPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & "\BookCMS" 'Pfad der  Anwendung
    Dim CoverPath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile.LocalApplicationData) & "\BookCMS\Cover"  'Pfad der Cover-Images
    'ConnectioString inhalte
    Dim conStr_Name As String = Nothing
    Dim conStr_conectionString As String = Nothing
    Dim conStr_Provider As String = Nothing

    Private Sub InstallBookCMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Zeigt die im Install-Verzeichnis enthaltenen Vorschläge an
        '1. das Installverzeichnis
        LblAktDB.Text = AktPath
        '2. Vorschlag der Pfade
        txtAppPath.Text = AppPath
        txtDBPath.Text = dbPath
        txtCoverPath.Text = CoverPath
        XmlConfigReader()
    End Sub
    Private Sub Disclaimer()
        MsgBox("Sie müssen sicher sein, dass Sie für den gewählten Ordner die volle Zugriffsberechtigung haben!" & vbCrLf & "Wenn Sie nicht sicher sind, nutzen Sie die vorgeschlagenen Ordner!")
    End Sub
    Private Sub BtChangeDataPaht_Click(sender As Object, e As EventArgs) Handles BtChangeDataPaht.Click
        Disclaimer()
        With FolderBrowserDialog1
            .Description = "Daten-Ordner wählen"
            .SelectedPath = Environment.CurrentDirectory
            If .ShowDialog() = DialogResult.OK Then
                dbPath = .SelectedPath
                txtDBPath.Text = dbPath
            End If
        End With
    End Sub

    Private Sub BrChangeAppPath_Click(sender As Object, e As EventArgs) Handles BrChangeAppPath.Click
        Disclaimer()
        With FolderBrowserDialog1
            .Description = "Installstions-Ordner wählen"
            .SelectedPath = "C:\"
            '  .RootFolder = Environment.CurrentDirectory
            If .ShowDialog() = DialogResult.OK Then
                AppPath = .SelectedPath
                txtAppPath.Text = AppPath
            End If
        End With
    End Sub

    Private Sub BtCoverPath_Click(sender As Object, e As EventArgs) Handles BtCoverPath.Click
        Disclaimer()
        With FolderBrowserDialog1
            .Description = "Ordner für Cover wählen"
            .SelectedPath = dbPath & "\Daten"
            '  .RootFolder = Environment.CurrentDirectory
            If .ShowDialog() = DialogResult.OK Then
                CoverPath = .SelectedPath
                txtCoverPath.Text = CoverPath
            End If
        End With
    End Sub
    Private Sub CheckFolder(ByRef myFolder As String)
        If Not IO.Directory.Exists(myFolder) Then
            ' Nein! Jetzt erstellen...
            Try
                IO.Directory.CreateDirectory(myFolder)
                ' Ordner wurde korrekt erstellt!
            Catch ex As Exception
                ' Ordner wurde nich erstellt
                MsgBox(ex.Message & vbCrLf & "Evt. besitzen Sie nicht die ausreichenden Rechte. Bitte prüfen!")
            End Try
        End If
    End Sub
    Public Sub TxtWriter(ByVal iniPath As String)
        ' Dim gd As GrundDaten
        Dim dbName As String = Nothing
        Dim StartRolle As String = ""
        Dim WebDNB As String = ""
        Dim files() = New IO.DirectoryInfo(iniPath).GetFiles("*.accdb", IO.SearchOption.AllDirectories)
        If files.Count = 0 Then
            MsgBox("Die Datenbank-Datei fehlt! Bitte prüffen!")
            Exit Sub
        End If

        For Each file In files
            'MessageBox.Show(file.Name)
            dbName = file.Name
        Next file
        'INI liegt noch im Installationspfad!
        If File.Exists(iniPath & "\BookCMS.ini") Then
            Dim objStreamWriter As StreamWriter
            objStreamWriter = New StreamWriter(iniPath & "\BookCMS.ini")

            'Write a lines of text.
            objStreamWriter.WriteLine(dbName)
            objStreamWriter.WriteLine(dbPath)
            objStreamWriter.WriteLine(CoverPath)
            objStreamWriter.WriteLine(StartRolle)
            objStreamWriter.WriteLine(WebDNB)

            'Close the file.
            objStreamWriter.Close()
        Else
            MsgBox("Die Datei BookCMS.ini fehlt! Bitte prüfen")
        End If
    End Sub
    'Reader für die includierte connectio.xml
    Private Sub XMLReader()

        Dim mpath As String = Path.Combine(Aktpath, "BookCMSConnection.xml")
        Try
            Dim xDoc As New XmlDocument
            xDoc.Load(mpath) 'oder xdoc.loadxml(string_mit_xml)
            Dim rootNode As XmlNode = xDoc.DocumentElement


            For Each child As XmlNode In rootNode.ChildNodes
                ListBox1.Items.Add(child.Attributes("name").Value)
                ListBox1.Items.Add(child.Attributes("connectionString").Value)
                ListBox1.Items.Add(child.Attributes("providerName").Value)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub XmlConfigReader()

        Dim mpath As String = Path.Combine(Aktpath, "BookCMS-Single2.exe.config") '"BookCMSConnection.xml")
        Try
            Dim xDoc As New XmlDocument
            xDoc.Load(mpath) 'oder xdoc.loadxml(string_mit_xml)
            Dim rootNode As XmlNode = xDoc.DocumentElement
            For Each el As XmlNode In rootNode
                ' MsgBox(el.Name)
                If el.Name = "connectionStrings" Then
                    For Each child As XmlNode In el.ChildNodes 'rootNode.ChildNodes
                        conStr_Name = child.Attributes("name").Value
                        ListBox1.Items.Add(conStr_Name)
                        conStr_Provider = child.Attributes("providerName").Value
                        conStr_conectionString = (child.Attributes("connectionString").Value)
                        ListBox1.Items.Add(conStr_Provider)
                        ListBox1.Items.Add(conStr_conectionString)
                    Next
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub xmlDocWriter(ByVal iniPath As String)
        Dim mpath As String = Path.Combine(iniPath, "BookCMSConnection.xml")
        Try
            Dim xDoc As New XmlDocument
            xDoc.Load(mpath) 'oder xdoc.loadxml(string_mit_xml)
            Dim rootNode As XmlNode = xDoc.DocumentElement


            For Each child As XmlNode In rootNode.ChildNodes
                child.Attributes("name").Value = conStr_Name
                child.Attributes("connectionString").Value = conStr_conectionString
                child.Attributes("providerName").Value = conStr_Provider
            Next
            xDoc.Save(mpath)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ExtractConString(ByVal conStr As String)

    End Sub
    Private Sub BtInst_Click(sender As Object, e As EventArgs) Handles BtInst.Click
        '1. gewählte Speicherorte prüfen und ggf. erstellen
        CheckFolder(AppPath)
        CheckFolder(dbPath)
        CheckFolder(CoverPath)
        '2. Speicherorte in Ini und config eintragen
        TxtWriter(AktPath) 'für die INI
        xmlDocWriter(Aktpath)
        '3. App, INI und config nach AppPath verschieben -> sollte schon im SetUp erfolgt sein!
        '4. accdb nach dbPath verschieben
    End Sub
End Class