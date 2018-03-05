Public Class FrmConnexion

    Property _maClsSQLUtilisateur As New ClsSQLUtilisateur()
    Property _authUser As ClsUtilisateur = Nothing

    Private Sub FrmConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tbx_Username.Text = "NOM Prénom"
        Tbx_Password.Text = "Mot de passe"
    End Sub

    Private Sub Btn_Connexion_Click(sender As Object, e As EventArgs) Handles Btn_Connexion.Click

        Dim tbxUsername As String = Tbx_Username.Text
        Dim tbxPassword As String = Tbx_Password.Text

        _authUser = _maClsSQLUtilisateur.validUser(tbxUsername, tbxPassword)

        If _authUser IsNot Nothing Then
            If _authUser._password.Equals("Acta89+") Then
                Dim _f As New FrmNewPassword
                _f.show()
                _f._authUser = _authUser
                Close()
            End If
            Dim fMenu As New FrmMenu
            fMenu._authUser = _authUser
                fMenu.Show()
                Close()
            Else
                Label_Error.Text = "Authentification incorrecte"
        End If

    End Sub

    Private Sub Tbx_Username_Enter(sender As Object, e As EventArgs) Handles Tbx_Username.Enter
        If Tbx_Username.Text = "NOM Prénom" Then
            Tbx_Username.Text = ""
        End If

    End Sub


    Private Sub Tbx_Password_Enter(sender As Object, e As EventArgs) Handles Tbx_Password.Enter
        'If Tbx_Password.Text = "NOM Prénom" Then
        Tbx_Password.Text = ""
        'End If
        Tbx_Password.UseSystemPasswordChar = True
    End Sub

End Class