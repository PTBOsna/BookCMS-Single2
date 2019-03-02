Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Win32
Imports System.Configuration
Public Class dbHandling
    Public Shared sDataPath As String
    Public con As New OleDbConnection
    Public Shared conStr As String 'ConnectingString
    Public dbName As String
    Public currBiblio As String
    Public Shared CurrDB As String
    Public Shared CoverPath As String
    Public Shared StartRolle As String
    Public Shared WebDNB As String
    Public Shared BuchVorhanden As Boolean = False
    Public Shared testlauf As Boolean = False

    Public Sub TxtReader()
        'Dim objStreamReader As StreamReader
        'Dim strLine As String
        Dim sText As String = ""
        Dim ergeb As List(Of String) = New List(Of String)
        'Dim zeile() As String
        'Dim gd As GrundDaten
        'Pass the file path and the file name to the StreamReader constructor.
        '  MsgBox(Environment.SpecialFolder.UserProfile.ApplicationData)
        Dim IniPath As String = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Daten\BookCMS.ini")
        ' MsgBox(IniPath)
        If File.Exists(IniPath) Then
            'If File.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Daten\BookCMS.ini") Then
            ' objStreamReader = New StreamReader(System.AppDomain.CurrentDomain.BaseDirectory & "Daten\BookCMS.ini")
            ' MsgBox(System.AppDomain.CurrentDomain.BaseDirectory & "FreeDMS.ini")
            Dim allLines() As String = System.IO.File.ReadAllLines(IniPath)
            ergeb.Clear()

            For Each line As String In allLines
                ergeb.Add(line)
                'MsgBox(line)
            Next
            ''Read the first line of text.
            'strLine = objStreamReader.ReadLine

            ''Continue to read until you reach the end of the file.
            'Do While Not strLine Is Nothing

            '    'Write the line to the Console window.
            '    'Console.WriteLine(strLine)
            '    sText += strLine
            '    'Read the next line.
            '    strLine = objStreamReader.ReadLine

            'Loop

            'Close the file.
            dbName = ergeb(0)
            sDataPath = CheckPath(ergeb(1))
            CoverPath = CheckPath(ergeb(2))
            StartRolle = ergeb(3)
            WebDNB = ergeb(4)

            CurrDB = sDataPath & dbName
        Else
            'Wenn ini nicht vorhanden, Programm abbrechen
            MsgBox("Die Datei BookCMS.ini wurde nicht gefunden oder ist Fehlerhaft. Bitte prüfen")

            'Für ersten Aufruf, wenn noch keine currDB in der ini eingetragen wurde:
        End If
        'If String.IsNullOrEmpty(CurrDB) Then
        '    CurrDB = sDataPath & "BookCMS-StartDB.mdb"

        '    Exit Sub
        'End If

    End Sub
    Function CheckPath(ByRef cPath As String) As String
        If Len(cPath) <= 0 Then
            cPath = Nothing
            Return cPath
            Exit Function
        End If
        Dim substring As String = cPath.Substring(Len(cPath) - 1, 1)
        If substring = "\" Then
            Return cPath
        Else
            Return cPath & "\"
        End If

    End Function

    Public Sub TxtWriter()
        ' Dim gd As GrundDaten
        Dim objStreamWriter As StreamWriter
        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter = New StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory & "Daten\BookCMS.ini")

        'Write a lines of text.
        objStreamWriter.WriteLine(dbName)
        objStreamWriter.WriteLine(sDataPath)
        objStreamWriter.WriteLine(CoverPath)
        objStreamWriter.WriteLine(StartRolle)
        objStreamWriter.WriteLine(WebDNB)

        'Close the file.
        objStreamWriter.Close()
        CurrDB = CheckPath(sDataPath) & dbName
    End Sub

    Public Function CheckForSoftwareInstallation(ByVal name As String) As Boolean
        '-- Get all software names installed by Windows Installer --
        Dim softwareList As List(Of String) = New List(Of String)
        Dim products As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Classes\Installer\Products")
        For Each keyName As String In products.GetSubKeyNames
            For Each valueName As String In products.OpenSubKey(keyName).GetValueNames
                If (valueName = "ProductName") Then
                    Dim entry As String = products.OpenSubKey(keyName).GetValue("ProductName").ToString
                    If (Not (entry) Is Nothing) Then
                        softwareList.Add(UCase(entry))
                    End If

                End If

            Next
        Next

        'MsgBox(ergeb)
        '-- check if searched software is included --
        Dim found As Boolean = False
        For Each sName As String In softwareList
            If sName.Contains(UCase(name)) Then
                found = True
            End If

        Next
        Return found
    End Function
    Shared Sub AddConnectionStrings()

        ' Get the count of the connection strings.
        Dim connStrCnt As Integer =
    ConfigurationManager.ConnectionStrings.Count

        ' Define the string name.
        Dim csName As String =
    "ConnStr" + connStrCnt.ToString()

        ' Get the configuration file.
        Dim config _
    As System.Configuration.Configuration =
    ConfigurationManager.OpenExeConfiguration(
    ConfigurationUserLevel.None)

        ' Add the connection string.
        Dim csSection _
    As ConnectionStringsSection =
    config.ConnectionStrings
        csSection.ConnectionStrings.Add(
    New ConnectionStringSettings(csName,
    "LocalSqlServer: data source=127.0.0.1;Integrated Security=SSPI;" + "Initial Catalog=aspnetdb", "System.Data.SqlClient"))

        ' Save the configuration file.
        config.Save(ConfigurationSaveMode.Modified)

        Console.WriteLine("Connection string added.")

    End Sub 'AddConnectionStrings
    Public Function GetConnectionStringByProvider(ByVal providerName As String) As String

        'Return Nothing on failure.
        Dim returnValue As String = Nothing

        ' Get the collection of connection strings.
        Dim settings As ConnectionStringSettingsCollection =
        ConfigurationManager.ConnectionStrings

        ' Walk through the collection and return the first 
        ' connection string matching the providerName.
        If Not settings Is Nothing Then
            For Each cs As ConnectionStringSettings In settings
                If cs.ProviderName = providerName Then
                    returnValue = cs.ConnectionString
                    Exit For
                End If
            Next
        End If

        Return returnValue
    End Function


End Class
Namespace My
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        Public Sub SetUserOverride(ByVal BezeichnungDesSettings As String, ByVal Value As String)
            Me(BezeichnungDesSettings) = Value
        End Sub
    End Class
End Namespace
