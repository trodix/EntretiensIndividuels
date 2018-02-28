Public Class FrmAjoutCollaborateur

    Property _maClsSQLCollaborateur As New ClsSQLCollaborateur
    Property _maClsSQLService As New ClsSQLService
    Property _maClsSQLStatut As New ClsSQLStatut

    Private Sub FrmAjoutCollaborateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chargerManager()

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

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs) Handles Btn_Entretiens.Click
        Me.Cursor = Cursors.WaitCursor
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

                Dim currentManager As Integer = 0
                Dim currentService As Integer = 0
                Dim currentStatut As Integer = 0


                Try
                    'Manager
                    words = DGV_Collab.Item(1, currentRowIndex).Value.Split("-")
                    currentManager = words(0)

                    'Service
                    words = DGV_Collab.Item(2, currentRowIndex).Value.Split("-")
                    currentService = words(0)

                    'Statut
                    words = DGV_Collab.Item(3, currentRowIndex).Value.Split("-")
                    currentStatut = words(0)

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try

                Dim currentCollab As New ClsCollaborateur(currentLibelleCollab, currentManager, currentService, Nothing, currentStatut)

                Try
                    _maClsSQLCollaborateur.InsertCollaborateur(currentCollab)
                    chargerManager()
                    DGV_Collab.RefreshEdit()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try

            End If
        End If

    End Sub

    Private Sub Btn_Accueil_Click(sender As Object, e As EventArgs) Handles Btn_Accueil.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMenu
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_Equipe_Click(sender As Object, e As EventArgs) Handles Btn_Equipe.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMonEquipe
        _f.Show()
        Close()
    End Sub

    Private Sub chargerManager()

        Col_Manager.Items.Clear()

        'For Each Manager As ClsCollaborateur In _maClsSQLCollaborateur._lesManagers.Values
        For Each Manager As ClsCollaborateur In _maClsSQLCollaborateur.readLesManagers.Values
            Dim leManagerId As Integer = Manager._idCollaborateur
            Dim leManagerLib As String = Manager._libelleCollaborateur
            Col_Manager.Items.Add(leManagerId & " - " & leManagerLib)
        Next

    End Sub

    Private Sub DGV_Collab_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DGV_Collab.RowsAdded

    End Sub
End Class