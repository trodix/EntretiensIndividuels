﻿Public Class FrmMesEntretiens

    Public Sub genererDGV()
        Dim DataGridView1 = New DataGridView
        DataGridView1.AllowUserToAddRows = False
        'TLP_Main.SetRow(DataGridView1, 2)
        DataGridView1.Dock = DockStyle.Fill
    End Sub

    Private Sub DGV_Actions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DGV_Dates_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Dates.CellContentClick

    End Sub

    Private Sub Btn_Equipe_Click(sender As Object, e As EventArgs) Handles Btn_Equipe.Click
        Dim _f As New FrmMonEquipe
        _f.Show()
        Close()
    End Sub
End Class