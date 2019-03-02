Public Class StandortListe
    Dim hasChanged As Boolean = False
    Private Sub StandortBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StandortBindingNavigatorSaveItem.Click
        saveStandort()
    End Sub

    Private Sub StandortListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StandortTableAdapter.Fill(_BookCMS_singleDataSet.Standort)
    End Sub
    Private Sub StandortTextBox_TextChanged(sender As Object, e As EventArgs) Handles StandortTextBox.TextChanged
        If String.IsNullOrEmpty(SortByTextBox.Text) Then SortByTextBox.Text = StandortTextBox.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SortByTextBox.Text = Nothing Then
            MsgBox("Bitte Feld 'Sortiert' ausfüllen!")
            Exit Sub
        End If
        Me.Validate()
        Me.StandortBindingSource.EndEdit()


        If hasChanged Then
            If MsgBox("Änderungen ok?", vbYesNo) = vbNo Then Exit Sub
            saveStandort()
        End If
        Me.Close()
    End Sub
    Private Sub saveStandort()
        Me.Validate()
        Me.StandortBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._BookCMS_singleDataSet)
    End Sub

    Private Sub StandortDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles StandortDataGridView.CellValueChanged
        hasChanged = True
    End Sub
End Class