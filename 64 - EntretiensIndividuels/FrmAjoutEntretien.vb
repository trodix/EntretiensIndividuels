Public Class FrmAjoutEntretien

    Property _maClsSQLCollab As New ClsSQLCollaborateur
    Property _maClsSQLEntretien As New ClsSQLEntretiens
    'Property _leCollab As ClsCollaborateur

    Private Sub FrmAjoutEntretien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label_Titre.Text = "Créer des entretiens"



        'For i As Integer = 0 To DGV_Entretien.Rows.Count - 1
        '    DGV_Entretien.Rows(i).Cells("Col_idCollab").DefaultNewRowValue = _leCollab._idCollaborateur
        'Next

        For Each Collab As ClsCollaborateur In _maClsSQLCollab._lesCollaborateurs.Values
            Dim leCollabId As Integer = Collab._idCollaborateur
            Dim leCollabLibelle As String = Collab._libelleCollaborateur
            Cmb_Collaborateur.Items.Add(leCollabId & " - " & leCollabLibelle)
        Next

    End Sub

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs) Handles Btn_Entretiens.Click
        Dim _f As New FrmMesEntretiens
        _f.Show()
        Close()
    End Sub

    Private Sub DGV_Entretien_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Entretien.CellMouseClick

        Dim words() As String

        If e.RowIndex <> -1 Then
            If e.ColumnIndex = DGV_Entretien.Columns("Col_Valider").Index Then

                ' 0 Col_idEntretien
                ' 1 Col_DateEntretien
                ' 2 Col_DateEntSuivi
                ' 3 Col_idCollab
                ' 4 Col_Document

                Dim currentRowIndex = e.RowIndex

                Dim currentDateEntretien As Date = DGV_Entretien.Item(1, currentRowIndex).Value
                Dim currentDateEntSuivi As Date = DGV_Entretien.Item(2, currentRowIndex).Value

                words = Cmb_Collaborateur.SelectedItem.Split("-")
                Dim currentIdCollab As Integer = words(0)

                Dim currentEntretien As New ClsEntretien(currentDateEntretien, currentDateEntSuivi, currentIdCollab)
                _maClsSQLEntretien.InsertEntretien(currentEntretien)

            End If
        End If

    End Sub

End Class
