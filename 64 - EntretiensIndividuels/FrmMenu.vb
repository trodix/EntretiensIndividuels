Public Class FrmMenu


    Private Sub FrmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs) Handles Btn_Entretiens.Click
        Dim _f As New FrmMesEntretiens
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_Equipe_Click(sender As Object, e As EventArgs) Handles Btn_Equipe.Click
        Dim _f As New FrmMonEquipe
        _f.Show()
        Close()
    End Sub

    Private Sub BtnAjoutEntretien_Click(sender As Object, e As EventArgs)
        Dim _f As New FrmAjoutEntretien
        _f.Show()
        Close()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub Btn_Accueil_Click(sender As Object, e As EventArgs) Handles Btn_Accueil.Click
        Dim _f As New FrmMenu
        _f.Show()
        Close()
    End Sub

End Class
