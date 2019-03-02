Imports System.IO
Public Class startform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim f As New Form1
        'f.Show()

        Me.Close()
    End Sub

    Private Sub startform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BibliothekTableAdapter.Fill(Me._BookCMS_singleDataSet.Bibliothek)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim f As New ListeBibliotheken
        'f.ShowDialog()
        'BibliothekTableAdapter.Fill(_BookCMS_singleDataSet.Bibliothek)
    End Sub
End Class