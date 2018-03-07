Imports System.Data.SqlClient
Imports EntretiensIndividuels

Public Class ClsSQLEntretiens

    'Property _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
    Property sqlConnexion As New SqlConnection("Server=SRV-BDD\SQLEXPRESS2008;Database=dbEntretiensIndividuels;Uid=sa;Pwd=+BTS08;")
    Property requete As SqlCommand
    Property adaptater As SqlDataAdapter
    'Property Dt As New DataTable
    Property _lesEntretiens As New Dictionary(Of Integer, ClsEntretien)

    Public Sub New()
        _lesEntretiens = readLesEntretiens()
        'MessageBox.Show(_lesEntretiens.Count)
    End Sub

    Public Function readLesEntretiens()
        Dim lesEntretiens As New Dictionary(Of Integer, ClsEntretien)
        Dim Fichier As Byte()
        Dim FichierNom As String
        Dim FichierExt As String
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EIEntretiens] order by DateEntretien",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    If Not IsDBNull(.OdbcReader("idEntretien")) And Not IsDBNull(.OdbcReader("DateEntretien")) And Not IsDBNull(.OdbcReader("DateEntretienSuivi")) And Not IsDBNull(.OdbcReader("idCollaborateur")) Then
                        If IsDBNull(.OdbcReader("DocumentScanne")) Then
                            Fichier = Nothing
                            FichierNom = Nothing
                            FichierExt = Nothing
                        Else
                            Fichier = .OdbcReader("DocumentScanne")
                            FichierNom = .OdbcReader("DocumentNom")
                            FichierExt = .OdbcReader("DocumentExtension")
                        End If
                        Dim DateEntretien As New Date(CDate(.OdbcReader("DateEntretien")).Year, CDate(.OdbcReader("DateEntretien")).Month, CDate(.OdbcReader("DateEntretien")).Day)
                            Dim DateEntretienSuivi As New Date(CDate(.OdbcReader("DateEntretienSuivi")).Year, CDate(.OdbcReader("DateEntretienSuivi")).Month, CDate(.OdbcReader("DateEntretienSuivi")).Day)
                        Dim unEntretien As New ClsEntretien(DateEntretien, DateEntretienSuivi, .OdbcReader("idCollaborateur"), .OdbcReader("idEntretien"), Fichier, FichierNom, FichierExt)
                        lesEntretiens.Add(.OdbcReader("idEntretien"), unEntretien)
                        End If
                End While
            End With
        End Using
        Return lesEntretiens
    End Function

    Public Function readUnEntretienById(idEntUpdate As Integer) As ClsEntretien
        Dim unEntretien As ClsEntretien = Nothing
        Dim Fichier As Byte()
        Dim FichierNom As String
        Dim FichierExt As String
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EIEntretiens] where idEntretien = " & idEntUpdate & " order by DateEntretien",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    If Not IsDBNull(.OdbcReader("idEntretien")) And Not IsDBNull(.OdbcReader("DateEntretien")) And Not IsDBNull(.OdbcReader("DateEntretienSuivi")) And Not IsDBNull(.OdbcReader("idCollaborateur")) Then
                        Dim DateEntretien As New Date(CDate(.OdbcReader("DateEntretien")).Year, CDate(.OdbcReader("DateEntretien")).Month, CDate(.OdbcReader("DateEntretien")).Day)
                        Dim DateEntretienSuivi As New Date(CDate(.OdbcReader("DateEntretienSuivi")).Year, CDate(.OdbcReader("DateEntretienSuivi")).Month, CDate(.OdbcReader("DateEntretienSuivi")).Day)
                        If IsDBNull(.OdbcReader("DocumentScanne")) Then
                            Fichier = Nothing
                            FichierNom = Nothing
                            FichierExt = Nothing
                        Else
                            Fichier = .OdbcReader("DocumentScanne")
                            FichierNom = .OdbcReader("DocumentNom")
                            FichierExt = .OdbcReader("DocumentExtension")
                        End If
                        unEntretien = New ClsEntretien(DateEntretien, DateEntretienSuivi, .OdbcReader("idCollaborateur"), .OdbcReader("idEntretien"), Fichier, FichierNom, FichierExt)
                    End If
                End While
            End With
        End Using
        Return unEntretien
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

        Try
            sqlConnexion.Open()
        Catch ex As Exception
            MsgBox("Impossible de se connecter à la base de données" & vbNewLine & ex.Message, MsgBoxStyle.Critical)
        End Try

        Dim req As String = "insert into [dbo].[EIEntretiens] (DateEntretien, DateEntretienSuivi, idCollaborateur, DocumentScanne, DocumentNom, DocumentExtension) values(
                '" & replaceSqlSpecialChars(ent._DateEntretien) & "', '" & replaceSqlSpecialChars(ent._DateEntretienSuivi) & "', " & replaceSqlSpecialChars(ent._idCollaborateur) &
                ", @Fichier, @Nom, @Extension)"

        requete = New SqlCommand(req, sqlConnexion)

        requete.Parameters.Add(New SqlParameter("@Fichier", SqlDbType.VarBinary)).Value = If(ent._Document Is Nothing, DBNull.Value, ent._Document)
        requete.Parameters.Add(New SqlParameter("@Nom", SqlDbType.Text)).Value = If(ent._nomDocument Is Nothing, DBNull.Value, ent._nomDocument)
        requete.Parameters.Add(New SqlParameter("@Extension", SqlDbType.NChar)).Value = If(ent._extensionDocument Is Nothing, DBNull.Value, ent._extensionDocument)
        requete.ExecuteNonQuery()
        sqlConnexion.Close()

    End Function

    Public Function updateEntretien(ent As ClsEntretien)

        Try
            sqlConnexion.Open()
        Catch ex As Exception
            MsgBox("Impossible de se connecter à la base de données" & vbNewLine & ex.Message, MsgBoxStyle.Critical)
        End Try

        Dim req As String = "update [dbo].[EIEntretiens] set DateEntretien = '" & ent._DateEntretien & "', " & "DateEntretienSuivi = '" & ent._DateEntretienSuivi & "', DocumentScanne = @Fichier, DocumentNom = @Nom, DocumentExtension = @Extension where idEntretien = " & ent._idEntretien

        requete = New SqlCommand(req, sqlConnexion)

        requete.Parameters.Add(New SqlParameter("@Fichier", SqlDbType.VarBinary)).Value = If(ent._Document Is Nothing, DBNull.Value, ent._Document)
        requete.Parameters.Add(New SqlParameter("@Nom", SqlDbType.Text)).Value = If(ent._nomDocument Is Nothing, DBNull.Value, ent._nomDocument)
        requete.Parameters.Add(New SqlParameter("@Extension", SqlDbType.NChar)).Value = If(ent._extensionDocument Is Nothing, DBNull.Value, ent._extensionDocument)
        requete.ExecuteNonQuery()
        sqlConnexion.Close()

    End Function

    Public Function DeleteEntretien(idEntretien As Integer)
        Dim req1 As String = "delete from [dbo].[EIEntretiens] where idEntretien = " & idEntretien
        Dim req2 As String = "delete from [dbo].[EIActions] where idEntretien = " & idEntretien
        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req1)
            _odbcConnection.OdbcNotSelectQuery(req2)
        End Using
    End Function

    Private Function replaceSqlSpecialChars(maChaine As String)
        Return maChaine.Replace("'", "''")
    End Function

End Class
