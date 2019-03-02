Public Class PersonenListe
    Private Sub PersonBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PersonBindingNavigatorSaveItem.Click
        savePerson()
    End Sub

    Private Sub PersonenListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PersonTableAdapter.Fill(Me._BookCMS_singleDataSet.Person)

    End Sub
    Private Sub savePerson()
        If NameTextBox.Text = Nothing Then
            MsgBox("Bitte Feld 'Angezeigt als' ausfüllen!")
            Exit Sub
        End If
        Validate()
        PersonBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me._BookCMS_singleDataSet)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        savePerson()
        ' End If
        Me.Close()
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        PersonBindingSource.Filter = "SortBy like '*" & TextBox1.Text & "*'"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PersonBindingSource.RemoveFilter()
        TextBox1.Text = ""
    End Sub
End Class