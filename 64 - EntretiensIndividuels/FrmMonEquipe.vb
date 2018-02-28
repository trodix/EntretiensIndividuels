Public Class FrmMonEquipe

    Property _monCollaborateurSQL As New ClsSQLCollaborateur
    Property _lesCollaborateurs As New Dictionary(Of Integer, ClsCollaborateur)
    Property _lesEntretiensCollab As New Dictionary(Of Integer, ClsEntretien)
    Property _lesActionsEntCollab As New Dictionary(Of Integer, ClsAction)
    Property _collabClicked As ClsCollaborateur
    Property _entClicked As ClsEntretien


    Private Sub FrmMonEquipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _lesCollaborateurs = _monCollaborateurSQL._lesCollaborateurs
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
        'DGV_Dates.Rows.Add(Nothing, idCollab, Nothing)
        For Each unEnt As ClsEntretien In _lesCollaborateurs(idCollab)._lesEntretiensCollab
            _lesEntretiensCollab.Add(unEnt._idEntretien, unEnt)
        Next

        If _lesEntretiensCollab IsNot Nothing Then
            For Each unEntretienCollab As ClsEntretien In _lesEntretiensCollab.Values
                DGV_Dates.Rows.Add(unEntretienCollab._idEntretien, idCollab, unEntretienCollab._DateEntretienSuivi.ToShortDateString)
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
                    uneActionEnt._idAction, uneActionEnt._DateCreation, uneActionEnt._Descriptif, uneActionEnt._RespAction,
                    uneActionEnt._Delai, uneActionEnt._SuiviCom, uneActionEnt._StatutPDCA, uneActionEnt._DateSolde
                    )
            Next
        End If

    End Sub

    Private Sub DGV_Noms_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Noms.CellMouseClick
        DGV_Dates.Rows.Clear()
        Dim ligneCourante As Integer = e.RowIndex
        Dim idCollab = sender.Rows(ligneCourante).Cells(0).Value
        FillDGV_Entretiens(idCollab)
        'BtnAjout.Text = "Ajouter un" & vbNewLine & "collaborateur"
        'BtnAjout.Visible = True
        'AddHandler BtnAjout.Click, AddressOf BtnAjout_Collaborateur_Click
    End Sub

    Private Sub DGV_Dates_CellMouseClick(sender As DataGridView, e As DataGridViewCellMouseEventArgs) Handles DGV_Dates.CellMouseClick
        DGV_Actions.Rows.Clear()
        Dim ligneCourante As Integer = e.RowIndex
        Dim idEntretien = sender.Rows(ligneCourante).Cells(0).Value
        'Dim idCollab = sender.Rows(ligneCourante).Cells(1).Value
        FillDGV_Actions(idEntretien)
        '_collabClicked = _lesCollaborateurs(idCollab)
        'BtnAjout.Text = "Ajouter un" & vbNewLine & "entretien"
        'BtnAjout.Visible = True
        'AddHandler BtnAjout.Click, AddressOf BtnAjout_Entretien_Click
    End Sub

    'Private Sub DGV_Actions_CellMouseClick(sender As DataGridView, e As DataGridViewCellMouseEventArgs) Handles DGV_Actions.CellMouseClick
    '    Dim ligneCourante As Integer = e.RowIndex
    '    Dim idEntretien = sender.Rows(ligneCourante).Cells(0).Value
    '    Dim idAction = sender.Rows(ligneCourante).Cells(1).Value
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

    'End Sub

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs) Handles Btn_Entretiens.Click
        Dim _f As New FrmMesEntretiens
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_AjoutCollab_Click(sender As Object, e As EventArgs) Handles Btn_AjoutCollab.Click
        Dim _f As New FrmAjoutCollaborateur
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_AjoutEntretien_Click(sender As Object, e As EventArgs) Handles Btn_AjoutEntretien.Click
        Dim _f As New FrmAjoutEntretien
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_AjoutAction_Click(sender As Object, e As EventArgs) Handles Btn_AjoutAction.Click
        Dim _f As New FrmAjoutAction
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_Accueil_Click(sender As Object, e As EventArgs) Handles Btn_Accueil.Click
        Dim _f As New FrmMenu
        _f.Show()
        Close()
    End Sub
End Class