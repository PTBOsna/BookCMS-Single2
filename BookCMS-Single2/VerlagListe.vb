Public Class VerlagListe
    Dim hasChanged As Boolean = False
    Private Sub VerlagBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VerlagBindingNavigatorSaveItem.Click
        SaveVerlag()

    End Sub
    Private Sub SaveVerlag()
        Me.Validate()
        Me.VerlagBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._BookCMS_singleDataSet)
    End Sub
    Private Sub VerlagListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_BookCMS_singleDataSet.Verlag". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.VerlagTableAdapter.Fill(Me._BookCMS_singleDataSet.Verlag)

    End Sub

    Private Sub VerlagTextBox_TextChanged(sender As Object, e As EventArgs) Handles VerlagTextBox.TextChanged
        If String.IsNullOrEmpty(SortByTextBox.Text) Then SortByTextBox.Text = VerlagTextBox.Text
    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        If SortByTextBox.Text = Nothing Then
            MsgBox("Bitte Feld 'Sortiert' ausfüllen!")
            Exit Sub
        End If
        Me.Validate()
        Me.VerlagBindingSource.EndEdit()


        If hasChanged Then
            If MsgBox("Änderungen ok?", vbYesNo) = vbNo Then Exit Sub
            SaveVerlag()
        End If
        Me.Close()
    End Sub

    Private Sub VerlagDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles VerlagDataGridView.CellValueChanged
        hasChanged = True
    End Sub
End Class