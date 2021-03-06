﻿Public Class FrmAjoutAction

    Property _authUser As ClsUtilisateur = Nothing

    Property _maClsSQLCollab As New ClsSQLCollaborateur
    Property _maClsSQLAction As New ClsSQLAction
    Property _maClsSQLEnt As New ClsSQLEntretiens(_maClsSQLAction)

    Property _entretien As ClsEntretien
    Property _selectedCollabId As Integer = -1
    Property _selectedEntId As Integer = -1

    Property _askUpdate As Boolean = False
    Property _idActionUpdate As Integer

    Private Sub FrmAjoutAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _authUser Is Nothing Then
            Close()
        End If

        If _authUser._StatutManager = 2 Then

            For Each Collab As ClsCollaborateur In _maClsSQLCollab._lesCollaborateurs.Values
                Cmb_Collaborateur.Items.Add(Collab._idCollaborateur & " - " & Collab._libelleCollaborateur)
            Next

        ElseIf _authUser._StatutManager = 1 Then

            For Each Collab As ClsCollaborateur In _maClsSQLCollab.readLesCollaborateursByManager(_authUser._idCollaborateur).Values
                Cmb_Collaborateur.Items.Add(Collab._idCollaborateur & " - " & Collab._libelleCollaborateur)
            Next

        ElseIf _authUser._StatutManager = 0 Then

            Dim collab As ClsCollaborateur = _maClsSQLCollab.readUnCollaborateurById(_authUser._idCollaborateur)
            Cmb_Collaborateur.Items.Add(collab._idCollaborateur & " - " & collab._libelleCollaborateur)
            Tbx_Action.Enabled = False
            Tbx_Objectif.Enabled = False
            Dtp_Delai.Enabled = False
            Dtp_DateSolde.Enabled = False
            Cmb_RespAction.Enabled = False

        End If


        For Each Collab As ClsCollaborateur In _maClsSQLCollab._lesCollaborateurs.Values
            Cmb_RespAction.Items.Add(Collab._idCollaborateur & " - " & Collab._libelleCollaborateur)
        Next

        Cmb_StatutPDCA.SelectedIndex = 0

        Dtp_DateSolde.MinDate = CDate("01/01/1900")
        Dtp_Delai.MinDate = CDate("01/01/1900")

        Dtp_Delai.Value = Dtp_Delai.MinDate
        Dtp_DateSolde.Value = Dtp_DateSolde.MinDate


        If _askUpdate Then

            Label_Titre.Text = "Modifier une action"
            BtnValider.Text = "Modifier"

            Dim laActionUpdate As ClsAction = _maClsSQLAction.readUneAction(_idActionUpdate)

            Dim laActionUpdateCollab As ClsCollaborateur = _maClsSQLCollab.readUnCollaborateurById(laActionUpdate._idCollaborateur)
            Dim laActionUpdateEnt As ClsEntretien = _maClsSQLEnt.readUnEntretienById(laActionUpdate._idEntretien)
            Dim laActionUpdateResp As ClsCollaborateur = _maClsSQLCollab.readUnCollaborateurById(laActionUpdate._RespAction)

            Cmb_Collaborateur.SelectedItem = laActionUpdateCollab._idCollaborateur & " - " & laActionUpdateCollab._libelleCollaborateur
            Cmb_Entretien.SelectedItem = laActionUpdateEnt._idEntretien & " - " & laActionUpdateEnt._DateEntretien
            Cmb_RespAction.SelectedItem = laActionUpdateResp._idCollaborateur & " - " & laActionUpdateResp._libelleCollaborateur

            Tbx_Objectif.Text = laActionUpdate._Objectif
            Tbx_Action.Text = laActionUpdate._ActionField
            If laActionUpdate._Delai.Date = CDate("01/01/0001") Then Dtp_Delai.Value = Dtp_Delai.MinDate Else Dtp_Delai.Value = laActionUpdate._Delai
            Tbx_SuiviCom.Text = laActionUpdate._SuiviCom
            Cmb_StatutPDCA.SelectedItem = laActionUpdate._StatutPDCA.ToString
            If laActionUpdate._DateSolde.Date = CDate("01/01/0001") Then Dtp_DateSolde.Value = Dtp_DateSolde.MinDate Else Dtp_DateSolde.Value = laActionUpdate._DateSolde
        End If

        Me.Cursor = Cursors.Default

    End Sub

    'Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs)
    '    Me.Cursor = Cursors.WaitCursor
    '    Dim _f As New FrmMesEntretiens
    '    _f._authUser = _authUser
    '    _f.Show()
    '    Close()
    'End Sub

    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click

        Dim currentObjectif As String = Tbx_Objectif.Text
        Dim currentActionField As String = Tbx_Action.Text
        Dim currentRespAction As Integer = Cmb_RespAction.SelectedItem.split(" - ")(0)
        Dim currentDelai As Date = Dtp_Delai.Value
        Dim currentSuiviCom As String = Tbx_SuiviCom.Text
        Dim currentStatutPDCA As Char = CChar(Cmb_StatutPDCA.SelectedItem)
        Dim currentDateSolde As Date = Dtp_DateSolde.Value

        If currentDelai.Date = Dtp_Delai.MinDate Then currentDelai = Nothing
        If currentDateSolde.Date = Dtp_Delai.MinDate Then currentDateSolde = Nothing

        If _selectedCollabId <> -1 And _selectedEntId <> -1 Then
            If _askUpdate Then
                Dim currentAction As New ClsAction(currentObjectif, currentActionField, currentRespAction, currentDelai, currentSuiviCom, currentStatutPDCA, _selectedCollabId, _selectedEntId, currentDateSolde, Nothing, _idActionUpdate)
                _maClsSQLAction.UpdateAction(currentAction)
                Close()
            Else
                Dim currentAction As New ClsAction(currentObjectif, currentActionField, currentRespAction, currentDelai, currentSuiviCom, currentStatutPDCA, _selectedCollabId, _selectedEntId, currentDateSolde)
                _maClsSQLAction.InsertAction(currentAction)
                Tbx_Objectif.Text = ""
                Tbx_Action.Text = ""
                Tbx_SuiviCom.Text = ""
            End If
        Else
            MessageBox.Show("Action non ajoutée, seletionnez un collaborateur et un entretien", "Ajout d'actions", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Cmb_Collaborateur_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmb_Collaborateur.SelectedValueChanged


        _selectedCollabId = Cmb_Collaborateur.SelectedItem.split("-")(0)
        Cmb_Entretien.Items.Clear()
        Cmb_Entretien.SelectedText = ""

        For Each Ent As ClsEntretien In _maClsSQLEnt._lesEntretiens.Values 'chercher les entretiens du collab selectionné
            If Ent._idCollaborateur = _selectedCollabId Then
                Cmb_Entretien.Items.Add(Ent._idEntretien & " - " & Ent._DateEntretien)
            End If
        Next

    End Sub

    Private Sub Cmb_Entretien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Entretien.SelectedIndexChanged
        _selectedEntId = Cmb_Entretien.SelectedItem.split("-")(0)
    End Sub

    'Private Sub Btn_Accueil_Click(sender As Object, e As EventArgs)
    '    Me.Cursor = Cursors.WaitCursor
    '    Dim _f As New FrmMenu
    '    _f._authUser = _authUser
    '    _f.Show()
    '    Close()
    'End Sub

    'Private Sub Btn_Equipe_Click(sender As Object, e As EventArgs)
    '    Me.Cursor = Cursors.WaitCursor
    '    Dim _f As New FrmMonEquipe
    '    _f._authUser = _authUser
    '    _f.Show()
    '    Close()
    'End Sub

    Private Sub Dtp_DropDown(sender As DateTimePicker, e As EventArgs) Handles Dtp_Delai.DropDown, Dtp_DateSolde.DropDown
        sender.Value = Date.Now
    End Sub
End Class