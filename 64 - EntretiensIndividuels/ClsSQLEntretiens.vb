Imports System.Data.SqlClient

Public Class ClsSQLEntretiens

    Property sqlConnexion As New SqlConnection("Data Source=localhost; database=db_file; integrated security = true")
    Property requete As SqlCommand
    Property adaptater As SqlDataAdapter
    Property Dt As New DataTable
    Property _lesEntretiens As New Dictionary(Of Integer, ClsEntretien)

    Public Sub New()
        _lesEntretiens = readLesEntretiens()
        'MessageBox.Show(_lesEntretiens.Count)
    End Sub

    Public Function readLesEntretiens()
        Dim lesEntretiens As New Dictionary(Of Integer, ClsEntretien)
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EIEntretiens] order by DateEntretienSuivi",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    If Not IsDBNull(.OdbcReader("idEntretien")) And Not IsDBNull(.OdbcReader("DateEntretien")) And Not IsDBNull(.OdbcReader("DateEntretienSuivi")) And Not IsDBNull(.OdbcReader("idCollaborateur")) Then
                        Dim DateEntretien As New Date(CDate(.OdbcReader("DateEntretien")).Year, CDate(.OdbcReader("DateEntretien")).Month, CDate(.OdbcReader("DateEntretien")).Day)
                        Dim DateEntretienSuivi As New Date(CDate(.OdbcReader("DateEntretienSuivi")).Year, CDate(.OdbcReader("DateEntretienSuivi")).Month, CDate(.OdbcReader("DateEntretienSuivi")).Day)
                        Dim unEntretien As New ClsEntretien(DateEntretien, DateEntretienSuivi, .OdbcReader("idCollaborateur"), .OdbcReader("idEntretien"),)
                        lesEntretiens.Add(.OdbcReader("idEntretien"), unEntretien)
                    End If
                End While
            End With
        End Using
        Return lesEntretiens
    End Function

    Public Function readLesEntretiensCollab(idCollaborateur As Integer)

        Dim lesEntretiensCollab As New List(Of ClsEntretien)

        For Each entretien As ClsEntretien In _lesEntretiens.Values
            If entretien._idCollaborateur = idCollaborateur Then
                lesEntretiensCollab.Add(entretien)
            End If
        Next

        Return lesEntretiensCollab

    End Function

    Public Function InsertEntretien(ent As ClsEntretien)
        Dim req As String = "insert into [dbo].[EIEntretiens] (DateEntretien, DateEntretienSuivi, idCollaborateur, DocumentScanne, DocumentNom, DocumentExtension) values(
                '" & replaceSqlSpecialChars(ent._DateEntretien) & "', '" & replaceSqlSpecialChars(ent._DateEntretienSuivi) & "', " & replaceSqlSpecialChars(ent._idCollaborateur) &
                ", '" & Nothing & "')"
        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using

        '"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
        'requete = New SqlCommand("insert into tbl_files (Nom, Fichier, Extension) values (@Nom, @Fichier, @Extension)", sqlConnexion)
        'Try
        '    sqlConnexion.Open()
        'Catch ex As Exception
        '    MsgBox("Impossible de se connecter à la base de données" & vbNewLine & ex.Message, MsgBoxStyle.Critical)
        'End Try

        'requete.Parameters.Add(New SqlParameter("@Nom", SqlDbType.NVarChar, 50)).Value = ent._nomDocument
        'requete.Parameters.Add(New SqlParameter("@Extension", SqlDbType.NChar, 10)).Value = ent._extentionDocument

        'Dim fs As New FileStream(OpenFileDialog2.FileName, FileMode.Open, FileAccess.Read)
        'Dim br As New BinaryReader(fs)
        'Dim fichier() As Byte = br.ReadBytes(br.BaseStream.Length)
        'requete.Parameters.Add(New SqlParameter("@Fichier", SqlDbType.VarBinary)).Value = fichier
        'requete.ExecuteNonQuery()
        'sqlConnexion.Close()
        'MsgBox("Fichier ajouté à la base de données", MsgBoxStyle.Information, "Fichier ajouté !")

        '""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""

    End Function

    Public Function updateEntretien(ent As ClsEntretien)
        Dim req As String = "update [dbo].[EIEntretiens] set DateEntretien = '" & ent._DateEntretien & "', " & "DateEntretienSuivi = '" & ent._DateEntretienSuivi & "', DocumentScanne = '" & Nothing & "'"
        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using
    End Function


    Private Function replaceSqlSpecialChars(maChaine As String)
        Return maChaine.Replace("'", "''")
    End Function

End Class
