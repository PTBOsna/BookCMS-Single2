Public Class CheckBuchGenreLink
    Private Sub CheckBuchGenreLink_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_BookCMS_singleDataSet.Buch". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.BuchTableAdapter.Fill(Me._BookCMS_singleDataSet.Buch)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_BookCMS_singleDataSet.GenreLink". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.GenreLinkTableAdapter.Fill(Me._BookCMS_singleDataSet.GenreLink)
        FillListView()
    End Sub
    Private Sub FillListView()
        ListBox1.Items.Clear()
        Dim tbLink = From q In _BookCMS_singleDataSet.GenreLink
        For Each link In tbLink
            Dim tbBuch = From r In _BookCMS_singleDataSet.Buch Where r.ID = link.BuchID
            'wenn nicht vorhanden, anezigen
            If tbBuch.Count = 0 Then
                ListBox1.Items.Add("LinkListe ID: " & link.id & " mit Buch: " & link.BuchID & " und Sachgruppe: " & link.SachgruppeID)
                ListBox1.ValueMember = link.id.ToString
            End If
        Next
        Label1.Text = ListBox1.Items.Count & " feherlhafe Verknüpfung(en)"
    End Sub

    Private Sub BtCancel_Click(sender As Object, e As EventArgs) Handles BtCancel.Click
        Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim ergeb() As String
        ergeb = Split(ListBox1.SelectedItem.ToString)
        SucheZeileundMarkiere(ergeb(2))
        BtDel.Text = "ID " & ergeb(2) & " löschen"
        'MsgBox(ergeb(2))
    End Sub
    Private Function SucheZeileundMarkiere(ByVal sSuchWert As String) As Boolean
        Try
            For i As Integer = 0 To GenreLinkDataGridView.Rows.Count - 1
                If GenreLinkDataGridView.Rows(i).Cells(0).Value.ToString = sSuchWert Then
                    'Markiert die Zeile
                    GenreLinkDataGridView.Rows(i).Selected = True
                    'Scrollt zur Angegeben(markierten) Zeile
                    GenreLinkDataGridView.FirstDisplayedScrollingRowIndex = i
                    'und kennzeichet sie als CorrentRow
                    GenreLinkDataGridView.CurrentCell = GenreLinkDataGridView.Rows(i).Cells(0)
                    Return True
                    Exit Function
                End If
            Next
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Sub BtDel_Click(sender As Object, e As EventArgs) Handles BtDel.Click
        If MsgBox("Datensatz löschen?", vbOKCancel) = vbOK Then
            GenreLinkBindingSource.RemoveCurrent()
            SaveAll()
            FillListView()

        End If
    End Sub
    Private Sub SaveAll()
        Me.Validate()
        Me.GenreLinkBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._BookCMS_singleDataSet)
    End Sub
End Class