Public Class VerlagsortListe
    Private Sub VerlagsOrtBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VerlagsOrtBindingNavigatorSaveItem.Click
        SaveAll()
    End Sub

    Private Sub VerlagsortListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_BookCMS_singleDataSet.VerlagsOrt". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.VerlagsOrtTableAdapter.Fill(Me._BookCMS_singleDataSet.VerlagsOrt)

    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        SaveAll()
        Close()
    End Sub
    Private Sub SaveAll()
        Me.Validate()
        Me.VerlagsOrtBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._BookCMS_singleDataSet)
    End Sub
End Class