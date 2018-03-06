Imports System.IO

Public Class FrmMonEquipe

    Property _authUser As ClsUtilisateur = Nothing

    Property _monCollaborateurSQL As New ClsSQLCollaborateur
    Property _lesCollaborateurs As New Dictionary(Of Integer, ClsCollaborateur)
    Property _lesEntretiensCollab As New Dictionary(Of Integer, ClsEntretien)
    Property _lesActionsEntCollab As New Dictionary(Of Integer, ClsAction)
    'Property _collabClicked As ClsCollaborateur
    'Property _entClicked As ClsEntretien
    Property _collabIdClicked As Integer
    Property _entIdClicked As Integer
    Property _actionIdClicked As Integer


    Private Sub FrmMonEquipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _authUser Is Nothing OrElse _authUser._StatutManager = 0 Then
            Close()
            Me.Cursor = Cursors.Default
        Else

            If _authUser._StatutManager = 1 Then
                _lesCollaborateurs = _monCollaborateurSQL.readLesCollaborateursByManager(_authUser._idCollaborateur)
                Btn_AjoutCollab.Hide()
            ElseIf _authUser._StatutManager = 2 Then
                _lesCollaborateurs = _monCollaborateurSQL.readLesCollaborateurs
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
                DGV_Dates.Rows.Add(unEntretienCollab._idEntretien, idCollab, unEntretienCollab._DateEntretien.ToShortDateString)
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
                DGV_Actions.Rows.Add(
                    uneActionEnt._idEntretien, uneActionEnt._idAction, uneActionEnt._DateCreation, uneActionEnt._Objectif, uneActionEnt._ActionField, uneActionEnt._RespAction,
                    uneActionEnt._Delai, uneActionEnt._SuiviCom, uneActionEnt._StatutPDCA, uneActionEnt._DateSolde
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
            Btn_Header.Text = "Modifier le collaborateur"
            Btn_Header.Visible = True
            _collabIdClicked = idCollab
            RemoveHandler Btn_Header.Click, AddressOf BtnModif_Collaborateur_Click
            RemoveHandler Btn_Header.Click, AddressOf BtnModif_Entretien_Click
            RemoveHandler Btn_Header.Click, AddressOf BtnModif_Action_Click
            AddHandler Btn_Header.Click, AddressOf BtnModif_Collaborateur_Click

            FillDGV_Entretiens(idCollab)
        Else
            ' Ajouter un collaborateur
            Btn_Header.Visible = False
        End If


        'BtnAjout.Text = "Ajouter un" & vbNewLine & "collaborateur"
        'BtnAjout.Visible = True
        'AddHandler BtnAjout.Click, AddressOf BtnAjout_Collaborateur_Click
    End Sub



    Private Sub DGV_Dates_CellMouseClick(sender As DataGridView, e As DataGridViewCellMouseEventArgs) Handles DGV_Dates.CellMouseClick
        DGV_Actions.Rows.Clear()
        Dim ligneCourante As Integer = e.RowIndex
        Dim idEntretien = sender.Rows(ligneCourante).Cells(0).Value
        If _lesEntretiensCollab.ContainsKey(idEntretien) Then
            ' afficher bouton modifier un entretien
            Btn_Header.Text = "Modifier l'entretien"
            Btn_Header.Visible = True
            _entIdClicked = idEntretien
            RemoveHandler Btn_Header.Click, AddressOf BtnModif_Collaborateur_Click
            RemoveHandler Btn_Header.Click, AddressOf BtnModif_Entretien_Click
            RemoveHandler Btn_Header.Click, AddressOf BtnModif_Action_Click
            AddHandler Btn_Header.Click, AddressOf BtnModif_Entretien_Click

            If Not _lesEntretiensCollab(idEntretien)._Document Is Nothing Then
                Btn_VoirFichier.Visible = True

            Else
                Btn_VoirFichier.Visible = False
            End If

            FillDGV_Actions(idEntretien)
        Else
            ' Ajouter un entretien
            Btn_Header.Visible = False
        End If

        '_collabClicked = _lesCollaborateurs(idCollab)
        'BtnAjout.Text = "Ajouter un" & vbNewLine & "entretien"
        'BtnAjout.Visible = True
        'AddHandler BtnAjout.Click, AddressOf BtnAjout_Entretien_Click
    End Sub



    Private Sub DGV_Actions_CellMouseClick(sender As DataGridView, e As DataGridViewCellMouseEventArgs) Handles DGV_Actions.CellMouseClick


        Btn_VoirFichier.Visible = False

        Dim ligneCourante As Integer = e.RowIndex
        Dim idEntretien = sender.Rows(ligneCourante).Cells("Col_idEnt").Value
        Dim idAction = sender.Rows(ligneCourante).Cells("Col_idActions").Value

        If _lesActionsEntCollab.ContainsKey(idAction) Then
            ' afficher bouton modifier une action
            Btn_Header.Text = "Modifier l'action"
            Btn_Header.Visible = True
            _actionIdClicked = idAction
            RemoveHandler Btn_Header.Click, AddressOf BtnModif_Collaborateur_Click
            RemoveHandler Btn_Header.Click, AddressOf BtnModif_Entretien_Click
            RemoveHandler Btn_Header.Click, AddressOf BtnModif_Action_Click
            AddHandler Btn_Header.Click, AddressOf BtnModif_Action_Click

        Else
            Btn_Header.Visible = False
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

    '""""""""""""""""""""""""""""""""""""""""""""""""""

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs) Handles Btn_Entretiens.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMesEntretiens
        _f._authUser = _authUser
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_AjoutCollab_Click(sender As Object, e As EventArgs) Handles Btn_AjoutCollab.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmAjoutCollaborateur
        _f._authUser = _authUser
        _f.ShowDialog()
    End Sub

    Private Sub Btn_AjoutEntretien_Click(sender As Object, e As EventArgs) Handles Btn_AjoutEntretien.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmAjoutEntretien
        _f._authUser = _authUser
        _f.ShowDialog()
    End Sub

    Private Sub Btn_AjoutAction_Click(sender As Object, e As EventArgs) Handles Btn_AjoutAction.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmAjoutAction
        _f._authUser = _authUser
        _f.ShowDialog()
    End Sub

    Private Sub Btn_Accueil_Click(sender As Object, e As EventArgs) Handles Btn_Accueil.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMenu
        _f._authUser = _authUser
        _f.Show()
        Close()
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

End Class