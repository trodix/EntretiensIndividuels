Public Class FrmMenu

    Property _authUser As ClsUtilisateur = Nothing

    Private Sub FrmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If _authUser Is Nothing Then
            Close()
        Else

            If _authUser._StatutManager = 0 Then
                Btn_Equipe.Hide()
            End If

        End If

        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
        For Each tab As TabPage In TabControl1.TabPages
            tab.Text = ""
        Next
    End Sub

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs) Handles Btn_Entretiens.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMesEntretiens
        _f._authUser = _authUser
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_Equipe_Click(sender As Object, e As EventArgs) Handles Btn_Equipe.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMonEquipe
        _f._authUser = _authUser
        _f.Show()
        Close()
    End Sub

    Private Sub BtnAjoutEntretien_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmAjoutEntretien
        _f._authUser = _authUser
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_Accueil_Click(sender As Object, e As EventArgs) Handles Btn_Accueil.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMenu
        _f._authUser = _authUser
        _f.Show()
        Close()
    End Sub

End Class
