Public Class FrmAjoutEntretien

    Property _maClsSQLCollab As New ClsSQLCollaborateur
    Property _maClsSQLEntretien As New ClsSQLEntretiens
    Property _selectedCollabId As Integer = -1

    Private Sub FrmAjoutEntretien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label_Titre.Text = "Créer des entretiens"



        'For i As Integer = 0 To DGV_Entretien.Rows.Count - 1
        '    DGV_Entretien.Rows(i).Cells("Col_idCollab").DefaultNewRowValue = _leCollab._idCollaborateur
        'Next

        For Each Collab As ClsCollaborateur In _maClsSQLCollab._lesCollaborateurs.Values
            Dim leCollabId As Integer = Collab._idCollaborateur
            Dim leCollabLibelle As String = Collab._libelleCollaborateur
            Cmb_Collaborateur.Items.Add(leCollabId & " - " & leCollabLibelle)
        Next

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs) Handles Btn_Entretiens.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMesEntretiens
        _f.Show()
        Close()
    End Sub

    Private Sub DGV_Entretien_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Entretien.CellMouseClick

        If e.RowIndex <> -1 Then
            If e.ColumnIndex = DGV_Entretien.Columns("Col_Valider").Index Then

                ' 0 Col_idEntretien
                ' 1 Col_DateEntretien
                ' 2 Col_DateEntSuivi
                ' 3 Col_idCollab
                ' 4 Col_Document

                Dim currentRowIndex = e.RowIndex

                Dim currentDateEntretien As Date = DGV_Entretien.Item(1, currentRowIndex).Value
                Dim currentDateEntSuivi As Date = DGV_Entretien.Item(2, currentRowIndex).Value

                Dim currentEntretien As New ClsEntretien(currentDateEntretien, currentDateEntSuivi, _selectedCollabId)


                If _selectedCollabId <> -1 Then
                    Try
                        _maClsSQLEntretien.InsertEntretien(currentEntretien)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End Try
                Else
                    MessageBox.Show("Entretien non ajouté, sélétionnez un collaborateur", "Ajout d'entretien", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If
        End If

    End Sub

    Private Sub Cmb_Collaborateur_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmb_Collaborateur.SelectedValueChanged
        _selectedCollabId = Cmb_Collaborateur.SelectedItem.Split("-")(0)
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
End Class
