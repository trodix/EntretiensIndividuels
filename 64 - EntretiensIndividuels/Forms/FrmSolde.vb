Public Class FrmSolde

    Property _lesActionsSQL As New ClsSQLAction
    Property _lesActionsASolderCollab As New Dictionary(Of Integer, ClsAction)
    Property _idCollabClicked As Integer
    Property _ActionsChecked As List(Of Integer)
    Property _ActionsNonChecked As List(Of Integer)

    Private Sub FrmSolde_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _lesActionsASolderCollab = _lesActionsSQL.readLesActionsNonSoldeCollab(_idCollabClicked)

        For Each action As ClsAction In _lesActionsASolderCollab.Values
            DGV_Solde.Rows.Add(action._idAction, action._DateCreation, action._Objectif, action._Delai, action._StatutPDCA)
        Next

    End Sub

    Private Sub DGV_Solde_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Solde.CellValueChanged

        If e.ColumnIndex = Col_Recup.Index And e.RowIndex <> -1 Then

            Dim idAction As Integer = sender.Rows(e.RowIndex).Cells(Col_idAction).Value

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

        For Each action As ClsAction In _lesActionsASolderCollab.Values
            If Not _ActionsChecked.Contains(action._idAction) Then
                _ActionsNonChecked.Add(action._idAction)
            End If
        Next

        Dim _f As New FrmAjoutEntretien
        _f._lesActionsASolder = _ActionsChecked
        _f._lesActionsARecuperer = _ActionsNonChecked
        _f.ShowDialog()
        Close()

    End Sub

End Class