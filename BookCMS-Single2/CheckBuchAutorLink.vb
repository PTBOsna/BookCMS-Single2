Public Class CheckBuchAutorLink
    Private Sub CheckBuchAutorLink_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_BookCMS_singleDataSet.AutorRolle". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.AutorRolleTableAdapter.Fill(Me._BookCMS_singleDataSet.AutorRolle)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_BookCMS_singleDataSet.Person". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.PersonTableAdapter.Fill(Me._BookCMS_singleDataSet.Person)
        Me.BuchTableAdapter.Fill(Me._BookCMS_singleDataSet.Buch)
        Me.AutorBuchLinkTableAdapter.Fill(Me._BookCMS_singleDataSet.AutorBuchLink)
        FillListView()
    End Sub
    Private Sub FillListView()
        ListBox1.Items.Clear()
        Dim tbLink = From q In _BookCMS_singleDataSet.AutorBuchLink
        For Each link In tbLink
            Dim tbBuch = From r In _BookCMS_singleDataSet.Buch Where r.ID = link.BuchID
            'wenn nicht vorhanden, anezigen
            If tbBuch.Count = 0 Then
                ListBox1.Items.Add("LinkListe ID: " & link.id & " mit Buch: " & link.BuchID & " und Person: " & link.PersonID)
                ListBox1.ValueMember = link.id.ToString
            End If
        Next
        Label1.Text = ListBox1.Items.Count & " feherlhafe Verknüpfung(en)"
    End Sub
    Private Sub SaveAll()
        Me.Validate()
        Me.AutorBuchLinkBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me._BookCMS_singleDataSet)
    End Sub


    Private Sub AutorBuchLinkBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AutorBuchLinkBindingNavigatorSaveItem.Click
        SaveAll()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim ergeb() As String
        ergeb = Split(ListBox1.SelectedItem.ToString)
        SucheZeileundMarkiere(ergeb(2))
        BtDel.Text = "ID " & ergeb(2) & " löschen"
        'MsgBox(ergeb(2))
    End Sub
    Private Function SucheZeileundMarkiere(ByVal sSuchWert As String) As Integer
        Try
            For i As Integer = 0 To AutorBuchLinkDataGridView.Rows.Count - 1
                If AutorBuchLinkDataGridView.Rows(i).Cells(0).Value.ToString = sSuchWert Then
                    'Markiert die Zeile
                    AutorBuchLinkDataGridView.Rows(i).Selected = True
                    'Scrollt zur Angegeben(markierten) Zeile
                    AutorBuchLinkDataGridView.FirstDisplayedScrollingRowIndex = i
                    'und kennzeichet sie als CorrentRow
                    AutorBuchLinkDataGridView.CurrentCell = AutorBuchLinkDataGridView.Rows(i).Cells(0)
                    Exit Function
                End If
            Next
        Catch ex As Exception

        End Try
    End Function

    Private Sub BtDel_Click(sender As Object, e As EventArgs) Handles BtDel.Click
        If MsgBox("Datensatz löschen?", vbOKCancel) = vbOK Then
            AutorBuchLinkBindingSource.RemoveCurrent()
            SaveAll()
            FillListView()

        End If

    End Sub
End Class