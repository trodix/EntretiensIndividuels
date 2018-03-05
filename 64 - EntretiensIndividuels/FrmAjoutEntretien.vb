Imports System.IO

Public Class FrmAjoutEntretien

    Property _maClsSQLCollab As New ClsSQLCollaborateur
    Property _maClsSQLEntretien As New ClsSQLEntretiens
    Property _selectedCollabId As Integer = -1
    Property _fileName As String
    Property _fileExtension As String
    Property _fichier As Byte() = Nothing

    Property _askUpdate As Boolean = False
    Property _idEntUpdate As Integer

    Private Sub FrmAjoutEntretien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each Collab As ClsCollaborateur In _maClsSQLCollab._lesCollaborateurs.Values
            Dim leCollabId As Integer = Collab._idCollaborateur
            Dim leCollabLibelle As String = Collab._libelleCollaborateur
            Cmb_Collaborateur.Items.Add(leCollabId & " - " & leCollabLibelle)
        Next

        Dtp_DateEntretienSuivi.Value = CDate("01/01/1900")

        'If _askUpdate Then
        '    Dim sqlManager As ClsSQLCollaborateur = _maClsSQLCollaborateur
        '    Dim sqlService As New ClsSQLService
        '    Dim sqlStatut As New ClsSQLStatut

        '    Dim leCollabUpdate As ClsCollaborateur = _maClsSQLCollaborateur.readUnCollaborateur(_idCollabUpdate)
        '    Dim leCollabUpdateManager As ClsCollaborateur = sqlManager.readManagerById(leCollabUpdate._idManager)
        '    Dim leCollabUpdateService As ClsService = sqlService.readServiceById(leCollabUpdate._idService)
        '    Dim leCollabUpdateStatut As ClsStatut = sqlStatut.readStatutById(leCollabUpdate._StatutManager)

        '    Tbx_LibColl.Text = leCollabUpdate._libelleCollaborateur
        '    ' remplir les cmbx
        '    Cmb_Manager.SelectedItem = leCollabUpdateManager._idCollaborateur & " - " & leCollabUpdateManager._libelleCollaborateur
        '    Cmb_Service.SelectedItem = leCollabUpdateService._idService & " - " & leCollabUpdateService._LibService
        '    Cmb_Statut.SelectedItem = leCollabUpdateStatut._idStatut & " - " & leCollabUpdateStatut._LibelleStatut
        '    'Cmb_Manager.SelectedItem = leCollabUpdate.
        'End If

        If _askUpdate Then
            Dim sqlEntretien As ClsSQLEntretiens = _maClsSQLEntretien
            Dim sqlCollab As New ClsSQLCollaborateur


            Dim leEntUpdate As ClsEntretien = sqlEntretien.readUnEntretienById(_idEntUpdate)
            Dim leEntUpdateCollab As ClsCollaborateur = sqlCollab.readUnCollaborateurByEnt(_idEntUpdate)

            ' remplir les cmbx
            Cmb_Collaborateur.SelectedItem = leEntUpdateCollab._idCollaborateur & " - " & leEntUpdateCollab._libelleCollaborateur
            Dtp_DateEntretien.Value = leEntUpdate._DateEntretien
            Dtp_DateEntretienSuivi.Value = leEntUpdate._DateEntretienSuivi

            _fichier = leEntUpdate._Document
            _fileName = leEntUpdate._nomDocument
            _fileExtension = leEntUpdate._extensionDocument

        End If

        Me.Cursor = Cursors.Default

    End Sub


    Private Sub Cmb_Collaborateur_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmb_Collaborateur.SelectedValueChanged
        _selectedCollabId = Cmb_Collaborateur.SelectedItem.Split("-")(0)
    End Sub

    Private Sub Btn_Fichier_Click(sender As Object, e As EventArgs) Handles Btn_Fichier.Click
        OpenFileDialog1.Filter = "All files (*.*) |*.*"
        OpenFileDialog1.Multiselect = False

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            _fileName = Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)
            _fileExtension = Path.GetExtension(OpenFileDialog1.FileName)
            Dim fs As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
            Dim br As New BinaryReader(fs)
            _fichier = br.ReadBytes(br.BaseStream.Length)
        End If
    End Sub

    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click

        Dim currentDateEntretien As Date = Convert.ToDateTime(Dtp_DateEntretien.Value)
        Dim currentDateEntSuivi As Date = Convert.ToDateTime(Dtp_DateEntretienSuivi.Value)


        If _selectedCollabId <> -1 Then
            If _askUpdate Then
                Dim currentEntretien As New ClsEntretien(currentDateEntretien, currentDateEntSuivi, _selectedCollabId, _idEntUpdate, _fichier, _fileName, _fileExtension)
                _maClsSQLEntretien.updateEntretien(currentEntretien)
                Close()
            Else
                Dim currentEntretien As New ClsEntretien(currentDateEntretien, currentDateEntSuivi, _selectedCollabId, Nothing, _fichier, _fileName, _fileExtension)
                _maClsSQLEntretien.InsertEntretien(currentEntretien)
                Close()
            End If
        Else
            MessageBox.Show("Entretien non ajouté, sélétionnez un collaborateur", "Ajout d'entretien", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Btn_Accueil_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMenu
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_Equipe_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMonEquipe
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Dim _f As New FrmMesEntretiens
        _f.Show()
        Close()
    End Sub

    'Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '    requete = New SqlCommand("insert into tbl_files (Nom, Fichier, Extension) values (@Nom, @Fichier, @Extension)", sqlConnexion)
    '    Try
    '        sqlConnexion.Open()
    '    Catch ex As Exception
    '        MsgBox("Impossible de se connecter à la base de données" & vbNewLine & ex.Message, MsgBoxStyle.Critical)
    '        Close()
    '    End Try

    '    requete.Parameters.Add(New SqlParameter("@Nom", SqlDbType.NVarChar, 50)).Value = tbxNom.Text
    '    requete.Parameters.Add(New SqlParameter("@Extension", SqlDbType.NChar, 10)).Value = Path.GetExtension(OpenFileDialog2.FileName)

    '    Dim fs As New FileStream(OpenFileDialog2.FileName, FileMode.Open, FileAccess.Read)
    '    Dim br As New BinaryReader(fs)
    '    Dim fichier() As Byte = br.ReadBytes(br.BaseStream.Length)
    '    requete.Parameters.Add(New SqlParameter("@Fichier", SqlDbType.VarBinary)).Value = fichier
    '    requete.ExecuteNonQuery()
    '    sqlConnexion.Close()
    '    MsgBox("Fichier ajouté à la base de données", MsgBoxStyle.Information, "Fichier ajouté !")
    'End Sub

End Class
