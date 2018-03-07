Public Class FrmMenu

    Property _authUser As ClsUtilisateur = Nothing

    Private Sub FrmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        PanelSlide.Width = ExtendedSlidePanelWidth
        timer1.Interval = 10

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

#Region "SlideMenu"

    Private WithEvents timer1 As New Timer
    Private ExtendedSlidePanelWidth As Integer = 250
    Private MinSlidePanelWidth As Integer = 70
    Private isSmall As Boolean = Nothing

    Private Sub Btn_SlideMenu_Click(sender As Object, e As EventArgs) Handles Btn_SlideMenu.Click

        timer1.Enabled = True
        timer1.Start()
        If PanelSlide.Width = ExtendedSlidePanelWidth Then
            isSmall = False
        ElseIf PanelSlide.Width = MinSlidePanelWidth Then
            isSmall = True
        End If

    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick

        If (isSmall = False) Then
            For Each control As Control In TLP_Menu.Controls
                If Not control.Name.Equals(Btn_SlideMenu.Name) Then
                    control.Hide()
                End If
            Next
            PanelSlide.Width -= 180

        ElseIf (isSmall = True) Then

            For Each control As Control In TLP_Menu.Controls
                If Not control.Name.Equals(Btn_SlideMenu.Name) Then
                    control.Show()
                End If
            Next
            PanelSlide.Width += 180
        End If


        If PanelSlide.Width = MinSlidePanelWidth Or PanelSlide.Width = ExtendedSlidePanelWidth Then
            timer1.Stop()
            isSmall = Nothing
        End If

    End Sub

#End Region

End Class
