Public Class VerlagNeu
    Dim sVerlag As String = ""
    Dim sOrt As String = ""
    Sub New(openArgs As String)

        InitializeComponent()
        sVerlag = openArgs
        Dim s = Split(openArgs, "#")
        sOrt = s(1)
        sVerlag = s(0)
        ' MsgBox(sText)
    End Sub
    Private Sub VerlagNeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.VerlagTableAdapter.Fill(Me._BookCMS_singleDataSet.Verlag)
        VerlagTextBox.Text = sVerlag & ", " & sOrt
        SortByTextBox.Text = sVerlag
        Addresse_PlainTextTextBox.Text = sOrt
        MarkedCheckBox.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Speichern und zurück?", vbYesNo) = vbYes Then
            If SortByTextBox.Text Is Nothing Then
                MsgBox("Bitte das Fels 'Sort By' ausfüllen!")
                Exit Sub
            End If
            Dim newVerlagsRow = _BookCMS_singleDataSet.Verlag.NewVerlagRow()
            newVerlagsRow.SortBy = SortByTextBox.Text
            newVerlagsRow.Verlag = VerlagTextBox.Text
            If MarkedCheckBox.Checked Then
                newVerlagsRow.Marked = True
            Else
                newVerlagsRow.Marked = False
            End If
            _BookCMS_singleDataSet.Verlag.Rows.Add(newVerlagsRow)
            Validate()
            VerlagTableAdapter.Update(_BookCMS_singleDataSet.Verlag)
            Close()
        Else
            Exit Sub
        End If

    End Sub
End Class