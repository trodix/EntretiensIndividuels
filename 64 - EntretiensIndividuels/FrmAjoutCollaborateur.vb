﻿Public Class FrmAjoutCollaborateur

    Property _maClsSQLCollaborateur As New ClsSQLCollaborateur
    Property _maClsSQLService As New ClsSQLService
    Property _maClsSQLStatut As New ClsSQLStatut

    Property _askUpdate As Boolean = False
    Property _idCollabUpdate As Integer

    Private Sub FrmAjoutCollaborateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        chargerManager()

        For Each Service As ClsService In _maClsSQLService._lesServices.Values
            Dim leServiceId As Integer = Service._idService
            Dim leServiceLib As String = Service._LibService
            Cmb_Service.Items.Add(leServiceId & " - " & leServiceLib)
        Next

        For Each Statut As ClsStatut In _maClsSQLStatut._LesStatuts.Values
            Dim leStatutId As Integer = Statut._idStatut
            Dim leStatutLib As String = Statut._LibelleStatut
            Cmb_Statut.Items.Add(leStatutId & " - " & leStatutLib)
        Next

        If _askUpdate Then
            Dim sqlManager As ClsSQLCollaborateur = _maClsSQLCollaborateur
            Dim sqlService As New ClsSQLService
            Dim sqlStatut As New ClsSQLStatut

            Dim leCollabUpdate As ClsCollaborateur = _maClsSQLCollaborateur.readUnCollaborateurById(_idCollabUpdate)
            Dim leCollabUpdateManager As ClsCollaborateur = sqlManager.readManagerById(leCollabUpdate._idManager)
            Dim leCollabUpdateService As ClsService = sqlService.readServiceById(leCollabUpdate._idService)
            Dim leCollabUpdateStatut As ClsStatut = sqlStatut.readStatutById(leCollabUpdate._StatutManager)

            Tbx_LibColl.Text = leCollabUpdate._libelleCollaborateur
            ' remplir les cmbx
            Cmb_Manager.SelectedItem = leCollabUpdateManager._idCollaborateur & " - " & leCollabUpdateManager._libelleCollaborateur
            Cmb_Service.SelectedItem = leCollabUpdateService._idService & " - " & leCollabUpdateService._LibService
            Cmb_Statut.SelectedItem = leCollabUpdateStatut._idStatut & " - " & leCollabUpdateStatut._LibelleStatut
            'Cmb_Manager.SelectedItem = leCollabUpdate.
        End If

        Me.Cursor = Cursors.Default

    End Sub


    'Private Sub DGV_Collab_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Collab.CellMouseClick

    '    If e.RowIndex <> -1 Then
    '        If e.ColumnIndex = DGV_Collab.Columns("Col_Valider").Index Then
    '            Dim words() As String

    '            Dim currentRowIndex = e.RowIndex
    '            Dim currentLibelleCollab As String = DGV_Collab.Item(0, currentRowIndex).Value

    '            Dim currentManager As Integer = 0
    '            Dim currentService As Integer = 0
    '            Dim currentStatut As Integer = 0


    '            Try
    '                'Manager
    '                words = DGV_Collab.Item(1, currentRowIndex).Value.Split("-")
    '                currentManager = words(0)

    '            Catch ex As Exception
    '                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '            End Try

    '            'Service
    '            words = DGV_Collab.Item(2, currentRowIndex).Value.Split("-")
    '            currentService = words(0)

    '            'Statut
    '            words = DGV_Collab.Item(3, currentRowIndex).Value.Split("-")
    '            'MsgBox(words)
    '            currentStatut = words(0)

    '            Dim currentCollab As New ClsCollaborateur(currentLibelleCollab, currentManager, currentService, Nothing, currentStatut)

    '            Try
    '                _maClsSQLCollaborateur.InsertCollaborateur(currentCollab)
    '                chargerManager()
    '                DGV_Collab.RefreshEdit()
    '            Catch ex As Exception
    '                MsgBox(ex.Message, MsgBoxStyle.Critical)
    '            End Try

    '        End If
    '    End If

    'End Sub

    Private Sub chargerManager()

        Cmb_Manager.Items.Clear()

        'For Each Manager As ClsCollaborateur In _maClsSQLCollaborateur._lesManagers.Values
        For Each Manager As ClsCollaborateur In _maClsSQLCollaborateur.readLesManagers.Values
            Dim leManagerId As Integer = Manager._idCollaborateur
            Dim leManagerLib As String = Manager._libelleCollaborateur
            Cmb_Manager.Items.Add(leManagerId & " - " & leManagerLib)
        Next

    End Sub

    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click
        Dim words() As String

        Dim currentLibelleCollab As String = Tbx_LibColl.Text

        'Manager
        Dim currentManager As Integer
        Try
            words = Cmb_Manager.SelectedItem.Split("-")
            currentManager = words(0)
        Catch ex As Exception
            currentManager = 0
            MsgBox(ex.Message & " Aucun Manager sélectionné", MsgBoxStyle.Exclamation)
        End Try



        'Service
        Dim currentService As Integer
        words = Cmb_Service.SelectedItem.Split("-")
        currentService = words(0)

        'Statut
        Dim currentStatut As Integer
        words = Cmb_Statut.SelectedItem.Split("-")
        currentStatut = words(0)



        Try
            If Not _askUpdate Then
                Dim leCollab As New ClsCollaborateur(currentLibelleCollab, currentManager, currentService, Nothing, currentStatut)
                _maClsSQLCollaborateur.InsertCollaborateur(leCollab)
            Else
                Dim leCollab As New ClsCollaborateur(currentLibelleCollab, currentManager, currentService, _idCollabUpdate, currentStatut)
                _maClsSQLCollaborateur.UpdateCollaborateur(leCollab)
                Close()
            End If
            Tbx_LibColl.Text = ""
            chargerManager()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub




    Private Sub Btn_Accueil_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMenu
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_Equipe_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMonEquipe
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMesEntretiens
        _f.Show()
        Close()
    End Sub

End Class