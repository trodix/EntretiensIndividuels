Public Class FrmMonEquipe

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

        _lesCollaborateurs = _monCollaborateurSQL._lesCollaborateurs
        FillDGV_Noms()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FillDGV_Noms()

        For Each unCollaborateur As ClsCollaborateur In _lesCollaborateurs.Values
            DGV_Noms.Rows.Add(unCollaborateur._idCollaborateur, unCollaborateur._libelleCollaborateur)
        Next

    End Sub

    Private Sub FillDGV_Entretiens(idCollab As Integer)
        DGV_Dates.Rows.Clear()
        _lesEntretiensCollab.Clear()
        'DGV_Dates.Rows.Add(Nothing, idCollab, Nothing)

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
            ' Ajouter une action
            Btn_Header.Visible = False
        End If


        '    '_entClicked = _lesEntretiensCollab(idEntretien)
        '    _entClicked = _lesEntretiensCollab(DGV_Dates.SelectedRows.Item(0).Cells("Col_idEntretien").Value)
        '    BtnAjout.Text = "Ajouter une" & vbNewLine & "action"
        '    BtnAjout.Visible = True
        '    AddHandler BtnAjout.Click, AddressOf BtnAjout_Action_Click
        'End Sub

        'Private Sub BtnAjout_Collaborateur_Click(ByVal sender As Object, ByVal e As EventArgs)
        '    Dim _f As New FrmAjoutCollaborateur
        '    _f.Show()
        '    Close()
        'End Sub

        'Private Sub BtnAjout_Entretien_Click(ByVal sender As Object, ByVal e As EventArgs)
        '    Dim _f As New FrmAjoutEntretien
        '    If Not _collabClicked Is Nothing Then
        '        _f._leCollab = _collabClicked
        '    End If
        '    _f.Show()
        '    Close()
        'End Sub

        'Private Sub BtnAjout_Action_Click(ByVal sender As Object, ByVal e As EventArgs)
        '    Dim _f As New FrmAjoutAction
        '    If Not _collabClicked Is Nothing Then
        '        _f._entretien = _entClicked
        '    End If
        '    _f.Show()
        '    Close()

    End Sub

    '""""""""""""""""""""""""""""""""""""""""""""""""""

    Private Sub BtnModif_Collaborateur_Click(sender As Object, e As EventArgs)
        Dim _f As New FrmAjoutCollaborateur
        _f._askUpdate = True
        _f._idCollabUpdate = _collabIdClicked
        _f.Label_Titre.Text = "Modifier un collaborateur"
        _f.BtnValider.Text = "Modifier"
        _f.ShowDialog()
    End Sub

    Private Sub BtnModif_Entretien_Click(sender As Object, e As EventArgs)
        Dim _f As New FrmAjoutEntretien
        _f._askUpdate = True
        _f._idEntUpdate = _entIdClicked
        _f.Label_Titre.Text = "Modifier un entretien"
        _f.BtnValider.Text = "Modifier"
        _f.ShowDialog()
    End Sub

    Private Sub BtnModif_Action_Click(sender As Object, e As EventArgs)
        Dim _f As New FrmAjoutAction
        _f._askUpdate = True
        _f._idActionUpdate = _actionIdClicked
        _f.ShowDialog()
    End Sub

    '""""""""""""""""""""""""""""""""""""""""""""""""""

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs) Handles Btn_Entretiens.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMesEntretiens
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_AjoutCollab_Click(sender As Object, e As EventArgs) Handles Btn_AjoutCollab.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmAjoutCollaborateur
        _f.ShowDialog()
    End Sub

    Private Sub Btn_AjoutEntretien_Click(sender As Object, e As EventArgs) Handles Btn_AjoutEntretien.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmAjoutEntretien
        _f.ShowDialog()
    End Sub

    Private Sub Btn_AjoutAction_Click(sender As Object, e As EventArgs) Handles Btn_AjoutAction.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmAjoutAction
        _f.ShowDialog()
    End Sub

    Private Sub Btn_Accueil_Click(sender As Object, e As EventArgs) Handles Btn_Accueil.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMenu
        _f.Show()
        Close()
    End Sub

    'Private Sub Btn_Header_Click(sender As Object, e As EventArgs) Handles Btn_Header.Click
    '    Throw New NotImplementedException
    'End Sub
End Class