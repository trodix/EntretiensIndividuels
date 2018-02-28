Public Class FrmAjoutAction

    Property _maClsSQLCollab As New ClsSQLCollaborateur
    Property _maClsSQLEnt As New ClsSQLEntretiens
    Property _maClsAction As New ClsSQLAction
    Property _entretien As ClsEntretien
    Property _selectedCollabId As Integer = -1
    Property _selectedEntId As Integer = -1

    Private Sub FrmAjoutAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each Collab As ClsCollaborateur In _maClsSQLCollab._lesCollaborateurs.Values
            Cmb_Collaborateur.Items.Add(Collab._idCollaborateur & " - " & Collab._libelleCollaborateur)
        Next

    End Sub

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs) Handles Btn_Entretiens.Click
        Dim _f As New FrmMesEntretiens
        _f.Show()
        Close()
    End Sub

    Private Sub DGV_Action_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Action.CellMouseClick

        If e.RowIndex <> -1 Then
            If e.ColumnIndex = DGV_Action.Columns("Col_Valider").Index Then

                Dim currentRowIndex = e.RowIndex

                Dim currentDescriptif As String = DGV_Action.Item(1, currentRowIndex).Value
                Dim currentRespAction As String = DGV_Action.Item(2, currentRowIndex).Value
                Dim currentDelai As Date = DGV_Action.Item(3, currentRowIndex).Value
                Dim currentSuiviCom As String = DGV_Action.Item(4, currentRowIndex).Value
                Dim currentStatutPDCA As Char = DGV_Action.Item(5, currentRowIndex).Value

                Dim currentAction As New ClsAction(currentDescriptif, currentRespAction, currentDelai, currentSuiviCom, currentStatutPDCA, _selectedCollabId, _selectedEntId)

                If _selectedCollabId <> -1 And _selectedEntId <> -1 Then
                    _maClsAction.InsertAction(currentAction)
                    MessageBox.Show("Action ajoutée avec succès", "Ajout d'actions", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Action non ajoutée, seletionnez un collaborateur et un entretien", "Ajout d'actions", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub Cmb_Collaborateur_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmb_Collaborateur.SelectedValueChanged


        _selectedCollabId = Cmb_Collaborateur.SelectedItem.split("-")(0)
        Cmb_Entretien.Items.Clear()
        Cmb_Entretien.SelectedText = ""

        For Each Ent As ClsEntretien In _maClsSQLEnt._lesEntretiens.Values 'chercher les entretiens du collab selectionné
            If Ent._idCollaborateur = _selectedCollabId Then
                Cmb_Entretien.Items.Add(Ent._idEntretien & " - " & Ent._DateEntretienSuivi)
            End If
        Next

    End Sub

    Private Sub Cmb_Entretien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Entretien.SelectedIndexChanged
        _selectedEntId = Cmb_Entretien.SelectedItem.split("-")(0)
    End Sub
End Class