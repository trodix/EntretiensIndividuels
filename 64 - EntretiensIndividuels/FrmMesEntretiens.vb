﻿Public Class FrmMesEntretiens

    Property _authUser As ClsUtilisateur = Nothing


    Private Sub FrmMesEntretiens_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _authUser Is Nothing Then
            Close()
        ElseIf _authUser._StatutManager = 0 Then
            Btn_Equipe.Hide()
        End If

    End Sub

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
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMonEquipe
        _f._authUser = _authUser
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_Accueil_Click(sender As Object, e As EventArgs) Handles Btn_Accueil.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMenu
        _f._authUser = _authUser
        _f.Show()
        Close()
    End Sub


End Class