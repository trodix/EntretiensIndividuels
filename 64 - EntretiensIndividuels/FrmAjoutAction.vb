Public Class FrmAjoutAction

    Property _maClsSQLCollab As New ClsSQLCollaborateur
    Property _maClsSQLEnt As New ClsSQLEntretiens

    Private Sub FrmAjoutAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each Collab As ClsCollaborateur In _maClsSQLCollab._lesCollaborateurs.Values
            Dim leCollabLibelle As String = Collab._libelleCollaborateur
            cmb_Coll.Items.Add(leCollabLibelle)
        Next

        For Each Ent As ClsEntretien In _maClsSQLEnt._lesEntretiens.Values
            Dim leEntDateSuivi As String = Ent._DateEntretienSuivi
            cmb_Ent.Items.Add(leEntDateSuivi)
        Next

    End Sub

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs) Handles Btn_Entretiens.Click
        Dim _f As New FrmMesEntretiens
        _f.Show()
        Close()
    End Sub

End Class