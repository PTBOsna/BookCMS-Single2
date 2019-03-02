Public Class testform

    'Startformular
    Private Sub testform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PersonBuchTableAdapter.Fill(Me._BookCMS_singleDataSet.PersonBuch)
        Dim Abfrage = From personbuch In _BookCMS_singleDataSet.PersonBuch Where personbuch.Titel Like "*" And personbuch.Bibliothek = 1 Group By personbuch.Titel Into Group
        If Abfrage.Count > 0 Then
            PersonBuchDataGridView.DataSource = Abfrage.ToList()
        End If
    End Sub
End Class