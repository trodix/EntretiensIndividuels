Imports System.IO

Public Class FrmAjoutEntretien

    Property _authUser As ClsUtilisateur = Nothing

    Property _maClsSQLCollab As New ClsSQLCollaborateur
    Property _maClsSQLAction As New ClsSQLAction
    Property _maClsSQLEntretien As New ClsSQLEntretiens(_maClsSQLAction)

    Property _selectedCollabId As Integer = -1
    Property _fileName As String
    Property _fileExtension As String
    Property _fichier As Byte() = Nothing

    Property _askUpdate As Boolean = False
    Property _idEntUpdate As Integer

    Property _lesActionsASolder As List(Of Integer) = Nothing
    Property _lesActionsARecuperer As List(Of Integer) = Nothing

    Property _lesActionsAGererCollab As New Dictionary(Of Integer, ClsAction)

    Property _ActionsChecked As List(Of Integer)
    Property _ActionsNonChecked As List(Of Integer)

    Private Sub FrmAjoutEntretien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Show()

        If _authUser Is Nothing Then
            Close()
        End If

        If _authUser._StatutManager = 2 Then

            For Each Collab As ClsCollaborateur In _maClsSQLCollab._lesCollaborateurs.Values
                Dim leCollabId As Integer = Collab._idCollaborateur
                Dim leCollabLibelle As String = Collab._libelleCollaborateur
                Cmb_Collaborateur.Items.Add(leCollabId & " - " & leCollabLibelle)
            Next

        ElseIf _authUser._StatutManager = 1 Then

            For Each Collab As ClsCollaborateur In _maClsSQLCollab.readLesCollaborateursByManager(_authUser._idCollaborateur).Values
                Dim leCollabId As Integer = Collab._idCollaborateur
                Dim leCollabLibelle As String = Collab._libelleCollaborateur
                Cmb_Collaborateur.Items.Add(leCollabId & " - " & leCollabLibelle)
            Next

        ElseIf _authUser._StatutManager = 0 Then

            Dim Collab As ClsCollaborateur = _maClsSQLCollab.readUnCollaborateurById(_authUser._idCollaborateur)
            Dim leCollabId As Integer = Collab._idCollaborateur
            Dim leCollabLibelle As String = Collab._libelleCollaborateur
            Cmb_Collaborateur.Items.Add(leCollabId & " - " & leCollabLibelle)

        End If


        Dtp_DateEntretienSuivi.Value = CDate("01/01/1900")

        If _askUpdate Then
            Dim sqlEntretien As ClsSQLEntretiens = _maClsSQLEntretien
            Dim sqlCollab As New ClsSQLCollaborateur


            Dim leEntUpdate As ClsEntretien = sqlEntretien.readUnEntretienById(_idEntUpdate)
            Dim leEntUpdateCollab As ClsCollaborateur = sqlCollab.readUnCollaborateurByEnt(_idEntUpdate)

            ' remplir les cmbx
            Cmb_Collaborateur.SelectedItem = leEntUpdateCollab._idCollaborateur & " - " & leEntUpdateCollab._libelleCollaborateur
            Dtp_DateEntretien.Value = leEntUpdate._DateEntretien
            Dtp_DateEntretienSuivi.Value = leEntUpdate._DateEntretienSuivi


            If Not leEntUpdate._Document Is Nothing Then

                Btn_Fichier.Text = "Remplacer fichier"

                _fichier = leEntUpdate._Document
                _fileName = leEntUpdate._nomDocument
                _fileExtension = leEntUpdate._extensionDocument

            End If
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

                _lesActionsAGererCollab = _maClsSQLAction.readLesActionsNonSoldeCollab(_selectedCollabId) ''''''''''''''

                If _lesActionsAGererCollab.Count > 0 Then

                    Dim _f As New FrmSolde
                    _f._authUser = _authUser
                    _f._fEnt = Me
                    _f._lesActionsAGererCollab = _lesActionsAGererCollab
                    Me.Visible = False
                    _f.ShowDialog()

                    Dim currentEntretien As New ClsEntretien(currentDateEntretien, currentDateEntSuivi, _selectedCollabId, Nothing, _fichier, _fileName, _fileExtension)
                    Dim lastEntId As Integer = _maClsSQLEntretien.InsertEntretien(currentEntretien)

                    For Each idAction As Integer In _lesActionsASolder
                        _maClsSQLAction.UpdateSolde(idAction)
                    Next

                    For Each idAction As Integer In _lesActionsARecuperer
                        _maClsSQLAction.RecupAction(lastEntId, idAction)
                    Next

                    Me.Visible = True

                Else
                    Dim currentEntretien As New ClsEntretien(currentDateEntretien, currentDateEntSuivi, _selectedCollabId, Nothing, _fichier, _fileName, _fileExtension)
                    Dim lastEntId As Integer = _maClsSQLEntretien.InsertEntretien(currentEntretien)

                    Close()
                End If


            End If
        Else
            MessageBox.Show("Entretien non ajouté, sélétionnez un collaborateur", "Ajout d'entretien", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Dtp_DateEntretienSuivi_DropDown(sender As Object, e As EventArgs) Handles Dtp_DateEntretienSuivi.DropDown
        Dtp_DateEntretienSuivi.Value = Date.Now
    End Sub

End Class
