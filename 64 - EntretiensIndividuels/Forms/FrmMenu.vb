Public Class FrmMenu

    Property _authUser As ClsUtilisateur = Nothing

    Private Sub FrmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If _authUser Is Nothing Then
            Close()
        Else

            If _authUser._StatutManager = 0 Then
                Btn_Equipe.Hide()
                Btn_AjoutCollab.Hide()
            Else
                Btn_Equipe.Show()
                Btn_AjoutCollab.Show()
            End If

        End If

        LoadPage(New UI_Accueil)

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub BtnAjoutEntretien_Click(sender As Button, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmAjoutEntretien
        _f._authUser = _authUser
        _f.Show()
    End Sub

    Private Sub Btn_Accueil_Click_1(sender As Button, e As EventArgs) Handles Btn_Accueil.Click
        LoadPage(New UI_Accueil)
        ActiveButton(sender)
    End Sub

    Private Sub Btn_Entretiens_Click_1(sender As Button, e As EventArgs) Handles Btn_Entretiens.Click
        LoadPage(New UI_MesEntretiens)
        ActiveButton(sender)
    End Sub

    Private Sub Btn_Equipe_Click_1(sender As Button, e As EventArgs) Handles Btn_Equipe.Click
        LoadPage(New UI_MonEquipe)
        ActiveButton(sender)
    End Sub

    Private Sub Btn_AjoutCollab_Click(sender As Button, e As EventArgs) Handles Btn_AjoutCollab.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmAjoutCollaborateur
        _f._authUser = _authUser
        _f.ShowDialog()
    End Sub

    Private Sub Btn_AjoutEntretien_Click(sender As Button, e As EventArgs) Handles Btn_AjoutEntretien.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmAjoutEntretien
        _f._authUser = _authUser
        _f.ShowDialog()
    End Sub

    Private Sub Btn_AjoutAction_Click(sender As Button, e As EventArgs) Handles Btn_AjoutAction.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmAjoutAction
        _f._authUser = _authUser
        _f.ShowDialog()
    End Sub

    Private Sub GestionAffichageMenu()
        If _authUser._StatutManager = 0 Then
            Btn_Equipe.Hide()
            Btn_AjoutCollab.Hide()
        ElseIf _authUser._StatutManager = 1 Then
            Btn_AjoutCollab.Show()
        ElseIf _authUser._StatutManager = 2 Then
            Btn_AjoutCollab.Show()
        End If
    End Sub

    Private Sub LoadPage(UserInterface)
        Panel_Main.Controls.Clear()
        Me.Cursor = Cursors.WaitCursor
        UserInterface._authUser = _authUser
        Panel_Main.Controls.Add(UserInterface)
        UserInterface.Dock = DockStyle.Fill
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ActiveButton(sender As Button)
        For Each c As Control In TLP_Menu.Controls
            If c.GetType = GetType(Button) Then
                Dim butt As Button = CType(c, Button)
                butt.BackColor = Color.FromArgb(21, 101, 192)
                sender.BackColor = Color.FromArgb(51, 131, 222)
            End If
        Next
    End Sub

End Class
