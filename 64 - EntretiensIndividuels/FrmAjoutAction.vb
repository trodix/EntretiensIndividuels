Public Class FrmAjoutAction

    Property _maClsSQLCollab As New ClsSQLCollaborateur
    Property _maClsSQLEnt As New ClsSQLEntretiens
    Property _maClsAction As New ClsSQLAction
    Property _entretien As ClsEntretien

    Private Sub FrmAjoutAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Label_Collaborateur.Text = _maClsSQLCollab._lesCollaborateurs(_entretien._idCollaborateur)._libelleCollaborateur
        'Label_Entretien.Text = _entretien._DateEntretien


        For Each Collab As ClsCollaborateur In _maClsSQLCollab._lesCollaborateurs.Values
            Dim leCollabLibelle As String = Collab._libelleCollaborateur
            Cmb_Collaborateur.Items.Add(leCollabLibelle)
        Next

        For Each Ent As ClsEntretien In _maClsSQLEnt._lesEntretiens.Values 'chercher les entretiens du collab selectionné
            Dim leEntDateSuivi As String = Ent._DateEntretienSuivi
            Cmb_Entretien.Items.Add(leEntDateSuivi)
        Next

    End Sub

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs) Handles Btn_Entretiens.Click
        Dim _f As New FrmMesEntretiens
        _f.Show()
        Close()
    End Sub

    Private Sub DGV_Action_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Action.CellMouseClick

        'Dim words() As String

        If e.RowIndex <> -1 Then
            If e.ColumnIndex = DGV_Action.Columns("Col_Valider").Index Then

                Dim currentRowIndex = e.RowIndex

                Dim currentDescriptif As String = DGV_Action.Item(1, currentRowIndex).Value
                Dim currentRespAction As String = DGV_Action.Item(2, currentRowIndex).Value
                Dim currentDelai As Date = DGV_Action.Item(3, currentRowIndex).Value
                Dim currentSuiviCom As String = DGV_Action.Item(4, currentRowIndex).Value
                Dim currentStatutPDCA As Char = DGV_Action.Item(5, currentRowIndex).Value

                'words = Cmb_Collaborateur.SelectedValue.split("-")
                'words = Cmb_Collaborateur.SelectedItem.split("-")

                Dim currentidCollab As Integer = getIdByName(Cmb_Collaborateur.SelectedItem)

                'words = Cmb_Entretien.SelectedItem.split("-")
                Dim currentidEnt As Integer = getIdByLibelle(Cmb_Entretien.SelectedItem)


                Dim currentAction As New ClsAction(currentDescriptif, currentRespAction, currentDelai, currentSuiviCom, currentStatutPDCA, currentidCollab, currentidEnt)
                _maClsAction.InsertAction(currentAction)

            End If
        End If
    End Sub

    Private Function getIdByName(nom As String)
        Dim key As Integer
        For Each collab As ClsCollaborateur In _maClsSQLCollab._lesCollaborateurs.Values
            If collab._libelleCollaborateur.Equals(Name) Then
                key = collab._idCollaborateur
            End If
        Next
        Return key
    End Function

    Private Function getIdByLibelle(libelle As String)
        Dim key As Integer
        For Each ent As ClsEntretien In _maClsSQLEnt._lesEntretiens.Values
            If ent._DateEntretienSuivi.Equals(libelle) Then
                key = ent._idEntretien
            End If
        Next
        Return key
    End Function
End Class