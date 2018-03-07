Public Class FrmNewPassword

    Property _maClsSQLUtilisateur As New ClsSQLUtilisateur()
    Property _authUser As ClsUtilisateur = Nothing

    Private Sub FrmConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _authUser Is Nothing Then
            Dim _f As New FrmConnexion
            _f.Show()
            Close()
        End If

        Tbx_Password1.Text = "Mot de passe"
        Tbx_Password2.Text = "Confirmer mot de passe"
    End Sub

    Private Sub Btn_Valider_Click(sender As Object, e As EventArgs) Handles Btn_Valider.Click

        Dim tbxPassword1 As String = ClsUtilisateur.CryptPassword(Tbx_Password1.Text)
        Dim tbxPassword2 As String = ClsUtilisateur.CryptPassword(Tbx_Password2.Text)

        If Not tbxPassword1.Equals(tbxPassword2) Then
            Label_Error.Text = "Les deux champs sont differents"
        ElseIf tbxPassword1.Length < 5 Then
            Label_Error.Text = "Le mot de passe doit faire au moins 5 caracteres"
        Else
            _maClsSQLUtilisateur.UpdatePassword(_authUser._idCollaborateur, tbxPassword1)
            Dim fMenu As New FrmMenu
            fMenu._authUser = _authUser
            fMenu.Show()
            Close()
        End If

    End Sub


    Private Sub Tbx_Password1_Enter(sender As Object, e As EventArgs) Handles Tbx_Password1.Enter
        If Tbx_Password1.Text = "Mot de passe" Then
            Tbx_Password1.Text = ""
        End If
    End Sub

    Private Sub Tbx_Password1_Leave(sender As Object, e As EventArgs) Handles Tbx_Password1.Leave
        If Tbx_Password1.Text = "" Then
            Tbx_Password1.Text = "Mot de passe"
        End If
    End Sub

    Private Sub Tbx_Password1_TextChanged(sender As Object, e As EventArgs) Handles Tbx_Password1.TextChanged
        If Not Tbx_Password1.Text = "Mot de passe" Then
            Tbx_Password1.UseSystemPasswordChar = True
        Else
            Tbx_Password1.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Tbx_Password2_Enter(sender As Object, e As EventArgs) Handles Tbx_Password2.Enter
        If Tbx_Password2.Text = "Confirmer mot de passe" Then
            Tbx_Password2.Text = ""
        End If
    End Sub

    Private Sub Tbx_Password2_Leave(sender As Object, e As EventArgs) Handles Tbx_Password2.Leave
        If Tbx_Password2.Text = "" Then
            Tbx_Password2.Text = "Confirmer mot de passe"
        End If
    End Sub

    Private Sub Tbx_Password2_TextChanged(sender As Object, e As EventArgs) Handles Tbx_Password2.TextChanged
        If Not Tbx_Password2.Text = "Confirmer mot de passe" Then
            Tbx_Password2.UseSystemPasswordChar = True
        Else
            Tbx_Password2.UseSystemPasswordChar = False
        End If
    End Sub

End Class