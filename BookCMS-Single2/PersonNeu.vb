Public Class PersonNeu
    Dim sAutor As String = ""
    Dim sBuch As String = ""
    Dim sDB As New dbHandling
    Sub New(openArgs As String)
        Dim s() As String
        InitializeComponent()
        s = Split(openArgs, "#")
        sAutor = s(1)
        sBuch = s(0)
        ' MsgBox(sText)
    End Sub
    Private Sub PersonNeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_BookCMS_singleDataSet.Land". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.LandTableAdapter.Fill(Me._BookCMS_singleDataSet.Land)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_BookCMS_singleDataSet.Person". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.PersonTableAdapter.Fill(Me._BookCMS_singleDataSet.Person)
        PersonBindingSource.AddNew()
        NameTextBox.Text = sAutor
        If Not sAutor.Contains(",") Then
            MsgBox(sAutor & vbCrLf & "Bitte Namen manuell eingeben!")
            Exit Sub
        End If
        SortByTextBox.Text = sAutor
        Dim NamePart() As String
        NamePart = Split(SortByTextBox.Text, ",")
        NameTextBox.Text = Trim(NamePart(1)) & " " & NamePart(0)
    End Sub

    Private Sub EinfügenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinfügenToolStripMenuItem.Click
        If My.Computer.Clipboard.ContainsText Then
            If TypeOf ActiveControl Is RichTextBox Then
                ActiveControl.Text &= My.Computer.Clipboard.GetText
            End If
        End If
    End Sub

    Private Sub KopierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KopierenToolStripMenuItem.Click
        If TypeOf ActiveControl Is RichTextBox Then
            My.Computer.Clipboard.SetText(CType(Me.ActiveControl, TextBox).SelectedText)
        End If
    End Sub

    Private Sub AusschneidenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AusschneidenToolStripMenuItem.Click
        Dim cText As RichTextBox

        If TypeOf ActiveControl Is RichTextBox Then
            cText = CType(Me.ActiveControl, RichTextBox)
            cText.Cut()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Speichern und zurück?", vbYesNo) = vbYes Then
            Me.Validate()
            Me.PersonBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._BookCMS_singleDataSet)
            Close()
        Else
            Exit Sub
        End If
    End Sub
End Class