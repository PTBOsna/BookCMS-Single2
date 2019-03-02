Public Class VerlagsOrtNeu
    Dim vOrt As String = ""
    Dim sDB As New dbHandling
    Sub New(openArgs As String)

        InitializeComponent()
        vOrt = openArgs
        ' MsgBox(sText)
    End Sub
    Private Sub VerlagsOrtNeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_BookCMS_singleDataSet.VerlagsOrt". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.VerlagsOrtTableAdapter.Fill(Me._BookCMS_singleDataSet.VerlagsOrt)
        VerlagsortTextBox.Text = vOrt
        SortByTextBox.Text = vOrt
        MarkedCheckBox.Checked = True
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Speichern und zurück?", vbYesNo) = vbYes Then
            Dim newOrtRow = _BookCMS_singleDataSet.VerlagsOrt.NewVerlagsOrtRow
            newOrtRow.SortBy = SortByTextBox.Text
            newOrtRow.Verlagsort = VerlagsortTextBox.Text
            If MarkedCheckBox.Checked Then
                newOrtRow.Marked = True
            Else
                newOrtRow.Marked = False
            End If
            _BookCMS_singleDataSet.VerlagsOrt.Rows.Add(newOrtRow)
            Validate()
            VerlagsOrtTableAdapter.Update(_BookCMS_singleDataSet.VerlagsOrt)
            Close()
        Else
            Exit Sub
        End If
    End Sub
End Class