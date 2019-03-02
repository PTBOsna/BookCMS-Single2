Public Class TypListe
    Dim hasChanged As Boolean = False

    Private Sub BuchTypBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BuchTypBindingNavigatorSaveItem.Click
        SaveBuchTyp()
    End Sub
    Private Sub SaveBuchTyp()
        Me.Validate()
        Me.BuchTypBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._BookCMS_singleDataSet)

    End Sub
    Private Sub TypListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_BookCMS_singleDataSet.BuchTyp". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.BuchTypTableAdapter.Fill(Me._BookCMS_singleDataSet.BuchTyp)

    End Sub

    Private Sub BuchTypTextBox_TextChanged(sender As Object, e As EventArgs) Handles BuchTypTextBox.TextChanged
        If String.IsNullOrEmpty(SortByTextBox.Text) Then SortByTextBox.Text = BuchTypTextBox.Text
    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        If SortByTextBox.Text = Nothing Then
            MsgBox("Bitte Feld 'Sortiert' ausfüllen!")
            Exit Sub
        End If
        Me.Validate()
        Me.BuchTypBindingSource.EndEdit()


        If hasChanged Then
            If MsgBox("Änderungen ok?", vbYesNo) = vbNo Then Exit Sub
            SaveBuchTyp()
        End If
        Me.Close()
    End Sub

    Private Sub BuchTypDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles BuchTypDataGridView.CellValueChanged
        hasChanged = True
    End Sub

    Private Sub Notiz_PlainTextTextBox_TextChanged(sender As Object, e As EventArgs) Handles Notiz_PlainTextTextBox.TextChanged
        LblAnzahlZeichen.Text = "Noch " & 255 - LblAnzahlZeichen.Text.Length & " Zeichen"
    End Sub

End Class