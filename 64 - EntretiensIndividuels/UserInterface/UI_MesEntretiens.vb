﻿Imports System.IO

Public Class UI_MesEntretiens

    Property _authUser As ClsUtilisateur = Nothing

    Property _monCollaborateurSQL As New ClsSQLCollaborateur

    Property _statististiquesSQL As New ClsSQLStatistique

    Property _lesCollaborateurs As New Dictionary(Of Integer, ClsCollaborateur)
    Property _lesEntretiensCollab As New Dictionary(Of Integer, ClsEntretien)
    Property _lesActionsEntCollab As New Dictionary(Of Integer, ClsAction)

    Property _entIdClicked As Integer
    Property _actionIdClicked As Integer

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Private Sub FrmMesEntretiens_Load(sender As Object, e As EventArgs) Handles Me.Load

        If _authUser Is Nothing Then
            End
        ElseIf _authUser._StatutManager = 0 Then
            _lesCollaborateurs = _monCollaborateurSQL._lesCollaborateurs
            FillDGV_Entretiens()
        End If

        Label7.Text = Format(_statististiquesSQL.NbActSolde / _statististiquesSQL.NbActTotal, "#0.00") * 100 & " %"

        Dim TotalActCollab = _statististiquesSQL.NbActByCollab(_authUser._idCollaborateur)
        If TotalActCollab = 0 Then
            Label8.Text = "0 %"
        Else
            Label8.Text = Format(_statististiquesSQL.NbActSoldeByCollab(_authUser._idCollaborateur) / TotalActCollab, "#0.00") * 100 & " %"
        End If


    End Sub


    Private Sub FillDGV_Entretiens()

        DGV_Dates.Rows.Clear()
        _lesEntretiensCollab.Clear()

        For Each unEnt As ClsEntretien In _lesCollaborateurs(_authUser._idCollaborateur)._lesEntretiensCollab
            _lesEntretiensCollab.Add(unEnt._idEntretien, unEnt)
        Next


        If _lesEntretiensCollab IsNot Nothing Then
            For Each unEntretienCollab As ClsEntretien In _lesEntretiensCollab.Values

                Dim dateEntretienSuivi As Date = unEntretienCollab._DateEntretien
                Dim dateEntretienSuiviText As String

                If dateEntretienSuivi.Date.Year < CDate("01/01/1999").Year Then
                    dateEntretienSuiviText = "Non défini"
                Else
                    dateEntretienSuiviText = dateEntretienSuivi.ToShortDateString
                End If

                DGV_Dates.Rows.Add(unEntretienCollab._idEntretien, _authUser._idCollaborateur, dateEntretienSuiviText)
            Next
        End If

    End Sub


    Private Sub FillDGV_Actions(idEntretien As Integer)

        DGV_Actions.Rows.Clear()

        If _lesEntretiensCollab.ContainsKey(idEntretien) Then
            _lesActionsEntCollab = _lesEntretiensCollab(idEntretien)._lesActionsEnt
        End If

        If _lesActionsEntCollab IsNot Nothing Then
            For Each uneActionEnt As ClsAction In _lesActionsEntCollab.Values
                DGV_Actions.Rows.Add(
                    uneActionEnt._idEntretien, uneActionEnt._idAction, uneActionEnt._DateCreation, uneActionEnt._Objectif, uneActionEnt._ActionField, uneActionEnt._LibRespAction,
                    uneActionEnt._Delai, uneActionEnt._SuiviCom, uneActionEnt._StatutPDCA, uneActionEnt._DateSolde
                    )
            Next
        End If

    End Sub


    Private Sub DGV_Dates_CellMouseClick(sender As DataGridView, e As DataGridViewCellMouseEventArgs) Handles DGV_Dates.CellMouseClick

        DGV_Actions.Rows.Clear()

        Dim ligneCourante As Integer = e.RowIndex
        Dim idEntretien = sender.Rows(ligneCourante).Cells(0).Value
        If _lesEntretiensCollab.ContainsKey(idEntretien) Then

            _entIdClicked = idEntretien

            If Not _lesEntretiensCollab(idEntretien)._Document Is Nothing Then
                Btn_VoirFichier.Visible = True

            Else
                Btn_VoirFichier.Visible = False
            End If

            FillDGV_Actions(idEntretien)

        End If

    End Sub



    Private Sub DGV_Actions_CellMouseClick(sender As DataGridView, e As DataGridViewCellMouseEventArgs) Handles DGV_Actions.CellMouseClick

        Btn_VoirFichier.Visible = False

        Dim ligneCourante As Integer = e.RowIndex
        Dim idEntretien = sender.Rows(ligneCourante).Cells("Col_idEnt").Value
        Dim idAction = sender.Rows(ligneCourante).Cells("Col_idActions").Value

        If _lesActionsEntCollab.ContainsKey(idAction) Then

            _actionIdClicked = idAction

        End If

    End Sub


    Private Sub Btn_VoirFichier_Click(sender As Object, e As EventArgs) Handles Btn_VoirFichier.Click

        Try

            Dim FileName As String = _lesEntretiensCollab(_entIdClicked)._nomDocument
            Dim FileExt As String = _lesEntretiensCollab(_entIdClicked)._extensionDocument
            Dim fileData() As Byte = CType(_lesEntretiensCollab(_entIdClicked)._Document, Byte())
            Dim fs As New FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(fileData, 0, fileData.Length)
            fs.Close()
            Process.Start(FileName)

        Catch ex As Exception

            MsgBox(ex.Message)
            Exit Sub

        End Try

    End Sub

    Private Sub Btn_StatDetails_Click(sender As Object, e As EventArgs) Handles Btn_StatDetails.Click

        Dim _f As New Form
        Dim ui As New UI_Statistiques
        _f.Controls.Add(ui)
        ui.Dock = DockStyle.Fill
        _f.WindowState = FormWindowState.Maximized
        _f.ShowDialog()

    End Sub
End Class
