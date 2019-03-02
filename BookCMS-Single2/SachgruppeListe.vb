Public Class SachgruppeListe
    Private Sub SachgruppeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SachgruppeBindingNavigatorSaveItem.Click
        SaveSachgruppe()

    End Sub

    Private Sub SachgruppeListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_BookCMS_singleDataSet.Sachgruppe". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.SachgruppeTableAdapter.Fill(Me._BookCMS_singleDataSet.Sachgruppe)

    End Sub
    Dim hasChanged As Boolean = False
    Private Sub StandortTextBox_TextChanged(sender As Object, e As EventArgs) Handles SachgruppeTextBox.TextChanged
        If String.IsNullOrEmpty(SortByTextBox.Text) Then SortByTextBox.Text = SachgruppeTextBox.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SortByTextBox.Text = Nothing Then
            MsgBox("Bitte Feld 'Sortiert' ausfüllen!")
            Exit Sub
        End If
        Me.Validate()
        Me.SachgruppeBindingSource.EndEdit()


        If hasChanged Then
            If MsgBox("Änderungen ok?", vbYesNo) = vbNo Then Exit Sub
            SaveSachgruppe()
        End If
        Me.Close()
    End Sub
    Private Sub SaveSachgruppe()
        Me.Validate()
        Me.SachgruppeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._BookCMS_singleDataSet)
    End Sub

    Private Sub StandortDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles SachgruppeDataGridView.CellValueChanged
        hasChanged = True
    End Sub
End Class