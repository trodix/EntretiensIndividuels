Public Class FrmConnexion

    Property _maClsSQLUtilisateur As New ClsSQLUtilisateur()
    Property _authUser As ClsUtilisateur = Nothing

    Private Sub FrmConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tbx_Username.Text = "NOM Prénom"
        Tbx_Password.Text = "Mot de passe"
        Tbx_Password.UseSystemPasswordChar = False
    End Sub

    Private Sub Btn_Connexion_Click(sender As Object, e As EventArgs) Handles Btn_Connexion.Click

        Dim tbxUsername As String = Tbx_Username.Text
        Dim tbxPassword As String = Tbx_Password.Text

        _authUser = _maClsSQLUtilisateur.validUser(tbxUsername, tbxPassword)

        If _authUser IsNot Nothing Then
            If _authUser._password.Equals("Acta89+") Then
                Dim _f As New FrmNewPassword
                _f._authUser = _authUser
                _f.Show()
                Close()
            Else
                Dim fMenu As New FrmMenu
                fMenu._authUser = _authUser
                fMenu.Show()
                Close()
            End If

        Else
                Label_Error.Text = "Authentification incorrecte"
        End If

    End Sub

    Private Sub Tbx_Username_Enter(sender As Object, e As EventArgs) Handles Tbx_Username.Enter
        If Tbx_Username.Text = "NOM Prénom" Then
            Tbx_Username.Text = ""
        End If

    End Sub

    Private Sub Tbx_Username_Leave(sender As Object, e As EventArgs) Handles Tbx_Username.Leave
        If Tbx_Username.Text = "" Then
            Tbx_Username.Text = "NOM Prénom"
        End If

    End Sub


    Private Sub Tbx_Password_Enter(sender As Object, e As EventArgs) Handles Tbx_Password.Enter
        If Tbx_Password.Text = "Mot de passe" Then
            Tbx_Password.Text = ""
        End If
    End Sub

    Private Sub Tbx_Password_Leave(sender As Object, e As EventArgs) Handles Tbx_Password.Leave
        If Tbx_Password.Text = "" Then
            Tbx_Password.Text = "Mot de passe"
        End If
    End Sub

    Private Sub Tbx_Password_TextChanged(sender As Object, e As EventArgs) Handles Tbx_Password.TextChanged
        If Not Tbx_Password.Text = "Mot de passe" Then
            Tbx_Password.UseSystemPasswordChar = True
        Else
            Tbx_Password.UseSystemPasswordChar = False
        End If
    End Sub
End Class