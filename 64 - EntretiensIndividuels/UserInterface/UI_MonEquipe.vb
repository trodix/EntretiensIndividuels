Imports System.IO

Public Class UI_MonEquipe

    Property _authUser As ClsUtilisateur = Nothing

    Property _monCollaborateurSQL As New ClsSQLCollaborateur
    Property _actionsSQL As New ClsSQLAction
    Property _EntretienSQL As New ClsSQLEntretiens(_actionsSQL)

    Property _lesCollaborateurs As New Dictionary(Of Integer, ClsCollaborateur)
    Property _lesEntretiensCollab As New Dictionary(Of Integer, ClsEntretien)
    Property _lesActionsEntCollab As New Dictionary(Of Integer, ClsAction)
    'Property _collabClicked As ClsCollaborateur
    'Property _entClicked As ClsEntretien
    Property _collabIdClicked As Integer
    Property _entIdClicked As Integer
    Property _actionIdClicked As Integer


    Private Sub FrmMonEquipe_Load(sender As Object, e As EventArgs) Handles Me.Load

        If _authUser Is Nothing OrElse _authUser._StatutManager = 0 Then
            End
        Else

            If _authUser._StatutManager = 1 Then
                _lesCollaborateurs = _monCollaborateurSQL.readLesCollaborateursByManager(_authUser._idCollaborateur)
            ElseIf _authUser._StatutManager = 2 Then
                _lesCollaborateurs = _monCollaborateurSQL._lesCollaborateurs
            End If

        End If


        FillDGV_Noms()

    End Sub

    Private Sub FillDGV_Noms()

        For Each unCollaborateur As ClsCollaborateur In _lesCollaborateurs.Values
            DGV_Noms.Rows.Add(unCollaborateur._idCollaborateur, unCollaborateur._libelleCollaborateur)
        Next

    End Sub

    Private Sub FillDGV_Entretiens(idCollab As Integer)
        DGV_Dates.Rows.Clear()
        _lesEntretiensCollab.Clear()

        For Each unEnt As ClsEntretien In _lesCollaborateurs(idCollab)._lesEntretiensCollab
            _lesEntretiensCollab.Add(unEnt._idEntretien, unEnt)
        Next


        If _lesEntretiensCollab IsNot Nothing Then
            For Each unEntretienCollab As ClsEntretien In _lesEntretiensCollab.Values
                Dim dateEntSuivi As Date = unEntretienCollab._DateEntretienSuivi
                Dim dateEntSuiviText As String

                If dateEntSuivi.Date.Year < CDate("01/01/1999").Year Then
                    dateEntSuiviText = "Non défini"
                Else
                    dateEntSuiviText = dateEntSuivi.ToShortDateString
                End If
                DGV_Dates.Rows.Add(unEntretienCollab._idEntretien, idCollab, unEntretienCollab._DateEntretien, dateEntSuiviText)
            Next
        End If


    End Sub

    Private Sub FillDGV_Actions(idEntretien As Integer)

        DGV_Actions.Rows.Clear()
        '_lesActionsEntCollab.Clear()
        If _lesEntretiensCollab.ContainsKey(idEntretien) Then
            _lesActionsEntCollab = _lesEntretiensCollab(idEntretien)._lesActionsEnt
        End If

        If _lesActionsEntCollab IsNot Nothing Then
            For Each uneActionEnt As ClsAction In _lesActionsEntCollab.Values

                Dim delai As Date = uneActionEnt._Delai
                Dim delaiText As String

                If delai.Date.Year < CDate("01/01/1999").Year Then
                    delaiText = "Non défini"
                Else
                    delaiText = delai.ToShortDateString
                End If

                Dim dateSolde As Date = uneActionEnt._DateSolde
                Dim dateSoldeText As String

                If dateSolde.Date.Year < CDate("01/01/1999").Year Then
                    dateSoldeText = "Non défini"
                Else
                    dateSoldeText = dateSolde.ToShortDateString
                End If

                DGV_Actions.Rows.Add(
                    uneActionEnt._idEntretien, uneActionEnt._idAction, uneActionEnt._DateCreation, uneActionEnt._Objectif, uneActionEnt._ActionField, uneActionEnt._LibRespAction,
                    delaiText, uneActionEnt._SuiviCom, uneActionEnt._StatutPDCA, dateSoldeText
                    )
            Next
        End If

    End Sub

    Private Sub DGV_Noms_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Noms.CellMouseClick

        Btn_VoirFichier.Visible = False

        DGV_Dates.Rows.Clear()
        DGV_Actions.Rows.Clear()

        Dim ligneCourante As Integer = e.RowIndex
        Dim idCollab = sender.Rows(ligneCourante).Cells(0).Value

        If _lesCollaborateurs.ContainsKey(idCollab) Then

            ' afficher bouton modifier un collaborateur
            Btn_Modif.Text = "Modifier le collaborateur"
            Btn_Modif.Visible = True
            _collabIdClicked = idCollab
            RemoveHandler Btn_Modif.Click, AddressOf BtnModif_Collaborateur_Click
            RemoveHandler Btn_Modif.Click, AddressOf BtnModif_Entretien_Click
            RemoveHandler Btn_Modif.Click, AddressOf BtnModif_Action_Click
            AddHandler Btn_Modif.Click, AddressOf BtnModif_Collaborateur_Click

            ' afficher button supprimer un collaborateur
            Btn_Supprimer.Text = "Supprimer le collaborateur"
            Btn_Supprimer.Visible = True
            RemoveHandler Btn_Supprimer.Click, AddressOf Btn_SupprimerCollaborateur_Click
            RemoveHandler Btn_Supprimer.Click, AddressOf Btn_SupprimerEntretien_Click
            RemoveHandler Btn_Supprimer.Click, AddressOf Btn_SupprimerAction_Click
            AddHandler Btn_Supprimer.Click, AddressOf Btn_SupprimerCollaborateur_Click

            FillDGV_Entretiens(idCollab)
        Else
            Btn_Modif.Visible = False
            Btn_Supprimer.Visible = False
        End If

    End Sub



    Private Sub DGV_Dates_CellMouseClick(sender As DataGridView, e As DataGridViewCellMouseEventArgs) Handles DGV_Dates.CellMouseClick
        DGV_Actions.Rows.Clear()
        Dim ligneCourante As Integer = e.RowIndex
        Dim idEntretien = sender.Rows(ligneCourante).Cells(0).Value
        If _lesEntretiensCollab.ContainsKey(idEntretien) Then
            ' afficher bouton modifier un entretien
            Btn_Modif.Text = "Modifier l'entretien"
            Btn_Modif.Visible = True
            _entIdClicked = idEntretien
            RemoveHandler Btn_Modif.Click, AddressOf BtnModif_Collaborateur_Click
            RemoveHandler Btn_Modif.Click, AddressOf BtnModif_Entretien_Click
            RemoveHandler Btn_Modif.Click, AddressOf BtnModif_Action_Click
            AddHandler Btn_Modif.Click, AddressOf BtnModif_Entretien_Click

            If Not _lesEntretiensCollab(idEntretien)._Document Is Nothing Then
                Btn_VoirFichier.Visible = True

            Else
                Btn_VoirFichier.Visible = False
            End If

            ' afficher button supprimer un entretien
            Btn_Supprimer.Text = "Supprimer l'entretien"
            Btn_Supprimer.Visible = True
            RemoveHandler Btn_Supprimer.Click, AddressOf Btn_SupprimerCollaborateur_Click
            RemoveHandler Btn_Supprimer.Click, AddressOf Btn_SupprimerEntretien_Click
            RemoveHandler Btn_Supprimer.Click, AddressOf Btn_SupprimerAction_Click
            AddHandler Btn_Supprimer.Click, AddressOf Btn_SupprimerEntretien_Click

            FillDGV_Actions(idEntretien)
        Else
            Btn_Modif.Visible = False
            Btn_Supprimer.Visible = False
        End If

    End Sub



    Private Sub DGV_Actions_CellMouseClick(sender As DataGridView, e As DataGridViewCellMouseEventArgs) Handles DGV_Actions.CellMouseClick


        Btn_VoirFichier.Visible = False

        Dim ligneCourante As Integer = e.RowIndex
        Dim idEntretien = sender.Rows(ligneCourante).Cells("Col_idEnt").Value
        Dim idAction = sender.Rows(ligneCourante).Cells("Col_idActions").Value

        If _lesActionsEntCollab.ContainsKey(idAction) Then

            ' afficher bouton modifier une action
            Btn_Modif.Text = "Modifier l'action"
            Btn_Modif.Visible = True
            _actionIdClicked = idAction
            RemoveHandler Btn_Modif.Click, AddressOf BtnModif_Collaborateur_Click
            RemoveHandler Btn_Modif.Click, AddressOf BtnModif_Entretien_Click
            RemoveHandler Btn_Modif.Click, AddressOf BtnModif_Action_Click
            AddHandler Btn_Modif.Click, AddressOf BtnModif_Action_Click

            ' afficher button supprimer une action
            Btn_Supprimer.Text = "Supprimer l'action"
            Btn_Supprimer.Visible = True
            RemoveHandler Btn_Supprimer.Click, AddressOf Btn_SupprimerCollaborateur_Click
            RemoveHandler Btn_Supprimer.Click, AddressOf Btn_SupprimerEntretien_Click
            RemoveHandler Btn_Supprimer.Click, AddressOf Btn_SupprimerAction_Click
            AddHandler Btn_Supprimer.Click, AddressOf Btn_SupprimerAction_Click
        Else
            Btn_Modif.Visible = False
            Btn_Supprimer.Visible = False
        End If

    End Sub

    '""""""""""""""""""""""""""""""""""""""""""""""""""

    Private Sub BtnModif_Collaborateur_Click(sender As Object, e As EventArgs)
        Dim _f As New FrmAjoutCollaborateur
        _f._authUser = _authUser
        _f._askUpdate = True
        _f._idCollabUpdate = _collabIdClicked
        _f.Label_Titre.Text = "Modifier un collaborateur"
        _f.BtnValider.Text = "Modifier"
        _f.ShowDialog()
    End Sub

    Private Sub BtnModif_Entretien_Click(sender As Object, e As EventArgs)
        Dim _f As New FrmAjoutEntretien
        _f._authUser = _authUser
        _f._askUpdate = True
        _f._idEntUpdate = _entIdClicked
        _f.Label_Titre.Text = "Modifier un entretien"
        _f.BtnValider.Text = "Modifier"
        _f.ShowDialog()
    End Sub

    Private Sub BtnModif_Action_Click(sender As Object, e As EventArgs)
        Dim _f As New FrmAjoutAction
        _f._authUser = _authUser
        _f._askUpdate = True
        _f._idActionUpdate = _actionIdClicked
        _f.ShowDialog()
    End Sub


    Private Sub Btn_VoirFichier_Click(sender As Object, e As EventArgs) Handles Btn_VoirFichier.Click

        Try

            Dim FileName As String = _lesEntretiensCollab(_entIdClicked)._nomDocument
            Dim FileExt As String = _lesEntretiensCollab(_entIdClicked)._extensionDocument
            Dim fileData() As Byte = CType(_lesEntretiensCollab(_entIdClicked)._Document, Byte())
            Dim fs As New FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(fileData, 0, fileData.Length)
            fs.Close()
            Process.Start(FileName)

        Catch ex As Exception

            MsgBox(ex.Message)
            Exit Sub

        End Try

    End Sub

    Private Sub Btn_SupprimerAction_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult = MsgBox("Voulez-vous supprimer l'action sélectionnée ?", MsgBoxStyle.YesNo, MsgBoxStyle.Exclamation)
        If res = MsgBoxResult.Yes Then
            _actionsSQL.DeleteAction(_actionIdClicked)
        End If
    End Sub

    Private Sub Btn_SupprimerEntretien_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult = MsgBox("Voulez-vous supprimer l'entretien sélectionné et les actions associées ?", MsgBoxStyle.YesNo, MsgBoxStyle.Exclamation)
        If res = MsgBoxResult.Yes Then
            _EntretienSQL.DeleteEntretien(_entIdClicked)
        End If
    End Sub

    Private Sub Btn_SupprimerCollaborateur_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult = MsgBox("Voulez-vous supprimer le collaborateur sélectionné, les entretiens associés ainsi que leurs actions ?", MsgBoxStyle.YesNo, MsgBoxStyle.Exclamation)
        If res = MsgBoxResult.Yes Then
            _monCollaborateurSQL.DeleteCollaborateur(_collabIdClicked)
        End If
    End Sub

End Class
