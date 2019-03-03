Public Class AutorRolleListe
    Dim hasChanged As Boolean = False
    Private Sub AutorRolleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AutorRolleBindingNavigatorSaveItem.Click
        SaveRolle()
    End Sub

    Private Sub AutorRolleListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_BookCMS_singleDataSet.AutorRolle". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.AutorRolleTableAdapter.Fill(Me._BookCMS_singleDataSet.AutorRolle)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If AutorKurzTextBox.Text = Nothing Then
            MsgBox("Bitte Feld 'Sortiert' ausfüllen!")
            Exit Sub
        End If
        Me.Validate()
        Me.AutorRolleBindingSource.EndEdit()


        If hasChanged Then
            If MsgBox("Änderungen ok?", vbYesNo) = vbNo Then Exit Sub
            SaveRolle()
        End If
        Me.Close()
    End Sub
    Private Sub SaveRolle()
        Me.Validate()
        Me.AutorRolleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._BookCMS_singleDataSet)
    End Sub
End Class