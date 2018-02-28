Public Class FrmAjoutCollaborateur

    Property _maClsSQLCollaborateur As New ClsSQLCollaborateur
    Property _maClsSQLService As New ClsSQLService
    Property _maClsSQLStatut As New ClsSQLStatut

    Private Sub FrmAjoutCollaborateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each Manager As ClsCollaborateur In _maClsSQLCollaborateur._lesManagers.Values
            Dim leManagerId As Integer = Manager._idCollaborateur
            Dim leManagerLib As String = Manager._libelleCollaborateur
            Col_Manager.Items.Add(leManagerId & " - " & leManagerLib)
        Next

        For Each Service As ClsService In _maClsSQLService._lesServices.Values
            Dim leServiceId As Integer = Service._idService
            Dim leServiceLib As String = Service._LibService
            Col_Service.Items.Add(leServiceId & " - " & leServiceLib)
        Next

        For Each Statut As ClsStatut In _maClsSQLStatut._LesStatuts.Values
            Dim leStatutId As Integer = Statut._idStatut
            Dim leStatutLib As String = Statut._LibelleStatut
            Col_Statut.Items.Add(leStatutId & " - " & leStatutLib)
        Next

    End Sub

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs) Handles Btn_Entretiens.Click
        Dim _f As New FrmMesEntretiens
        _f.Show()
        Close()
    End Sub

    Private Sub DGV_Collab_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Collab.CellMouseClick

        If e.RowIndex <> -1 Then
            If e.ColumnIndex = DGV_Collab.Columns("Col_Valider").Index Then
                Dim words() As String

                Dim currentRowIndex = e.RowIndex
                Dim currentLibelleCollab As String = DGV_Collab.Item(0, currentRowIndex).Value

                'Manager
                words = DGV_Collab.Item(1, currentRowIndex).Value.Split("-")
                Dim currentManager As Integer = words(0)

                'Service
                words = DGV_Collab.Item(2, currentRowIndex).Value.Split("-")
                Dim currentService As Integer = words(0)

                'Statut
                words = DGV_Collab.Item(3, currentRowIndex).Value.Split("-")
                Dim currentStatut As Integer = words(0)

                Dim currentCollab As New ClsCollaborateur(currentLibelleCollab, currentManager, currentService, Nothing, currentStatut)
                _maClsSQLCollaborateur.InsertCollaborateur(currentCollab)
            End If
        End If

    End Sub
End Class