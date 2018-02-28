Public Class FrmMenu


    Private Sub FrmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs) Handles Btn_Entretiens.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMesEntretiens
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_Equipe_Click(sender As Object, e As EventArgs) Handles Btn_Equipe.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMonEquipe

        _f.Show()
        Close()
    End Sub

    Private Sub BtnAjoutEntretien_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmAjoutEntretien
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_Accueil_Click(sender As Object, e As EventArgs) Handles Btn_Accueil.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMenu
        _f.Show()
        Close()
    End Sub

End Class
