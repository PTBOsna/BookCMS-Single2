Public Class DelTitleControl

    Dim myCount As Integer = 0
    Private Sub DelTitleControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim teststing As String = "Das Feuerschiff"
        BuchTableAdapter.Fill(_BookCMS_singleDataSet.Buch)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Cursor.Current = Cursors.WaitCursor
        Dim dummy As String = Nothing
        Dim buch = From q In _BookCMS_singleDataSet.Buch Where q.ID > 0
        For Each element In buch
            dummy = element.Titel
            dummy = delControl(dummy)
            ' testString = testString + dummy
            element.Titel = dummy
        Next
        ' TextBox2.Text = testString
        Me.Validate()
        Me.BuchBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._BookCMS_singleDataSet)
        Cursor.Current = Cursors.Default
        Dim ergeb As DialogResult = MessageBox.Show("Es wurden " & _BookCMS_singleDataSet.Buch.Count.ToString & " Büchertitel überprüft und " & myCount & " Steuerzeichen entfernt", "Ergebnis", MessageBoxButtons.OK)
        If ergeb = vbOK Then Close()
    End Sub
    Private Function delControl(ByVal sTitel As String) As String

        myCount = 0
        If String.IsNullOrEmpty(sTitel) Then
            Return sTitel
            Exit Function
        End If
        For i As Integer = sTitel.Length - 1 To 0 Step -1

            If Char.IsControl(sTitel(i)) Then
                sTitel = sTitel.Remove(i, 1)
                myCount = +1
            End If
        Next
        Return sTitel
    End Function
End Class