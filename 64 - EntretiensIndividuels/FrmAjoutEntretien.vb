Imports System.IO

Public Class FrmAjoutEntretien

    Property _maClsSQLCollab As New ClsSQLCollaborateur
    Property _maClsSQLEntretien As New ClsSQLEntretiens
    Property _selectedCollabId As Integer = -1
    Property _fileName As String
    Property _fileExtension As String
    Property _fichier As Byte()

    Property _askUpdate As Boolean = False
    Property _idEntUpdate As Integer

    Private Sub FrmAjoutEntretien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each Collab As ClsCollaborateur In _maClsSQLCollab._lesCollaborateurs.Values
            Dim leCollabId As Integer = Collab._idCollaborateur
            Dim leCollabLibelle As String = Collab._libelleCollaborateur
            Cmb_Collaborateur.Items.Add(leCollabId & " - " & leCollabLibelle)
        Next

        If _askUpdate Then
            Dim leEntUpdate As ClsEntretien = _maClsSQLEntretien.readUnEntretienById(_idEntUpdate)
            ' remplir les cmbx
        End If

        Me.Cursor = Cursors.Default

    End Sub


    Private Sub Cmb_Collaborateur_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmb_Collaborateur.SelectedValueChanged
        _selectedCollabId = Cmb_Collaborateur.SelectedItem.Split("-")(0)
    End Sub

    Private Sub Btn_Fichier_Click(sender As Object, e As EventArgs) Handles Btn_Fichier.Click
        'OpenFileDialog1.Filter = "All files (*.*) |*.*"
        'If OpenFileDialog1.ShowDialog = DialogResult.OK Then
        '    _fileName = OpenFileDialog1.FileName
        '    _fileExtension = Path.GetExtension(OpenFileDialog1.FileName)
        '    Dim fs As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
        '    Dim br As New BinaryReader(fs)
        '    _fichier = br.ReadBytes(br.BaseStream.Length)
        'End If
    End Sub

    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click

        Dim currentDateEntretien As Date = Convert.ToDateTime(Dtp_DateEntretien.Value)
        Dim currentDateEntSuivi As Date = Convert.ToDateTime(Dtp_DateEntretienSuivi.Value)
        Dim currentEntretien As New ClsEntretien(currentDateEntretien, currentDateEntSuivi, _selectedCollabId, Nothing, _fichier, _fileName, _fileExtension)

        If _selectedCollabId <> -1 Then
            Try
                _maClsSQLEntretien.InsertEntretien(currentEntretien)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
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
