Public Class FrmSolde

    Property _fEnt As FrmAjoutEntretien

    Property _authUser As ClsUtilisateur = Nothing

    Property _lesActionsSQL As New ClsSQLAction
    Property _lesActionsAGererCollab As New Dictionary(Of Integer, ClsAction)
    Property _idCollabClicked As Integer = -1
    Property _ActionsChecked As New List(Of Integer)
    Property _ActionsNonChecked As New List(Of Integer)

    Private Sub FrmSolde_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Visible = True

        For Each action As ClsAction In _lesActionsAGererCollab.Values
            DGV_Solde.Rows.Add(action._idAction, action._DateCreation, action._Objectif, action._Delai, action._StatutPDCA)
        Next

    End Sub

    Private Sub DGV_Solde_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Solde.CellValueChanged

        If e.ColumnIndex = Col_Recup.Index And e.RowIndex <> -1 Then

            Dim idAction As Integer = DGV_Solde(0, e.RowIndex).Value.ToString

            If Not _ActionsChecked.Contains(idAction) Then
                _ActionsChecked.Add(idAction)
            Else
                _ActionsChecked.Remove(idAction)
            End If
        End If

    End Sub

    Private Sub DGV_Solde_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Solde.CellMouseUp

        If e.ColumnIndex = Col_Recup.Index And e.RowIndex <> -1 Then
            DGV_Solde.EndEdit()
        End If

    End Sub

    Private Sub Btn_ValidRecup_Click(sender As Object, e As EventArgs) Handles Btn_ValidRecup.Click

        For Each action As ClsAction In _lesActionsAGererCollab.Values
            If Not _ActionsChecked.Contains(action._idAction) Then
                _ActionsNonChecked.Add(action._idAction)
            End If
        Next

        _fEnt._lesActionsARecuperer = _ActionsChecked
        _fEnt._lesActionsASolder = _ActionsNonChecked
        Close()

    End Sub

End Class