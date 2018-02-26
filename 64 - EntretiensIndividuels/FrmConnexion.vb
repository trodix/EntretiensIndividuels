Public Class FrmConnexion

    Property _maClsSQLUtilisateur As New ClsSQLUtilisateur()
    Property _currentUser = Nothing

    Private Sub FrmConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tbx_Username.Text = "Prénom et NOM"
        Tbx_Password.Text = "Mot de passe"
    End Sub

    Private Sub Btn_Connexion_Click(sender As Object, e As EventArgs) Handles Btn_Connexion.Click

        Dim tbxUsername As String = Tbx_Username.Text
        Dim tbxPassword As String = Tbx_Password.Text

        _currentUser = _maClsSQLUtilisateur.validUser(tbxUsername, tbxPassword)

        If _currentUser IsNot Nothing Then
            Dim fMenu As New FrmMenu
            fMenu.Show()
            Close()
        End If

    End Sub

    Private Sub Tbx_Username_Enter(sender As Object, e As EventArgs) Handles Tbx_Username.Enter
        If Tbx_Username.Text = "Prénom et NOM" Then
            Tbx_Username.Text = ""
        End If

    End Sub


    Private Sub Tbx_Password_Enter(sender As Object, e As EventArgs) Handles Tbx_Password.Enter
        If Tbx_Password.Text = "Mot de passe" Then
            Tbx_Password.Text = ""
        End If
        Tbx_Password.UseSystemPasswordChar = True
    End Sub

End Class