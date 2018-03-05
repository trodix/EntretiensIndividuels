﻿Public Class ClsSQLCollaborateur

    'Property _lesCollaborateurs As Dictionary(Of Integer, ClsCollaborateur) = readLesCollaborateurs()
    'Property _lesManagers As Dictionary(Of Integer, ClsCollaborateur) = readLesManagers()

    Public Sub New()
        readLesCollaborateurs()
    End Sub

    Public Function readLesCollaborateurs() As Dictionary(Of Integer, ClsCollaborateur)
        Dim lesCollaborateurs As New Dictionary(Of Integer, ClsCollaborateur)
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EICollaborateurs] order by cast(LibCollaborateur as nvarchar)",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    Dim unCollaborateur As New ClsCollaborateur(.OdbcReader("LibCollaborateur"), .OdbcReader("idManager"), .OdbcReader("idService"), .OdbcReader("idCollaborateur"))
                    lesCollaborateurs.Add(.OdbcReader("idCollaborateur"), unCollaborateur)
                End While
            End With
        End Using
        Return lesCollaborateurs
    End Function

    Public Function readLesCollaborateursByManager(idManager As Integer) As Dictionary(Of Integer, ClsCollaborateur)
        Dim lesCollaborateurs As New Dictionary(Of Integer, ClsCollaborateur)
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EICollaborateurs] where idManager = " & idManager & " order by cast(LibCollaborateur as nvarchar)",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    Dim unCollaborateur As New ClsCollaborateur(.OdbcReader("LibCollaborateur"), .OdbcReader("idManager"), .OdbcReader("idService"), .OdbcReader("idCollaborateur"))
                    lesCollaborateurs.Add(.OdbcReader("idCollaborateur"), unCollaborateur)
                End While
            End With
        End Using
        Return lesCollaborateurs
    End Function

    Public Function readLesManagers() As Dictionary(Of Integer, ClsCollaborateur)
        Dim lesManagers As New Dictionary(Of Integer, ClsCollaborateur)
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EICollaborateurs] where StatutManager >= 1 order by cast(LibCollaborateur as nvarchar)",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    Dim unManager As New ClsCollaborateur(.OdbcReader("LibCollaborateur"), .OdbcReader("idManager"), .OdbcReader("idService"), .OdbcReader("idCollaborateur"))
                    lesManagers.Add(.OdbcReader("idCollaborateur"), unManager)
                End While
            End With
        End Using
        Return lesManagers
    End Function

    'Public Function readUnCollaborateur(idCollaborateur As Integer)
    '    Return _lesCollaborateurs.Item(idCollaborateur)
    'End Function

    Public Function readUnCollaborateurById(idCollaborateur As Integer) As ClsCollaborateur
        Dim unCollaborateur As ClsCollaborateur = Nothing
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EICollaborateurs] where idCollaborateur = " & idCollaborateur,
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    unCollaborateur = New ClsCollaborateur(.OdbcReader("LibCollaborateur"), .OdbcReader("idManager"), .OdbcReader("idService"), .OdbcReader("idCollaborateur"), .OdbcReader("StatutManager"))
                End While
            End With
        End Using
        Return unCollaborateur
    End Function

    Public Function InsertCollaborateur(col As ClsCollaborateur)
        Dim req As String = "insert into [dbo].[EICollaborateurs] (LibCollaborateur, MotDePasse, idManager, idService, StatutManager) values(
                '" & replaceSqlSpecialChars(col._libelleCollaborateur) & "', '" & replaceSqlSpecialChars(col._password) & "', '" &
                replaceSqlSpecialChars(col._idManager) & "', '" & replaceSqlSpecialChars(col._idService) & "', '" & replaceSqlSpecialChars(col._StatutManager) & "')"
        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using
    End Function


    Private Function replaceSqlSpecialChars(maChaine As String)
        Return maChaine.Replace("'", "''")
    End Function

    Public Sub UpdateCollaborateur(leCollab As ClsCollaborateur)
        Dim req As String = "update [dbo].[EICollaborateurs] set LibCollaborateur = '" & replaceSqlSpecialChars(leCollab._libelleCollaborateur) & "', idManager = " &
            replaceSqlSpecialChars(leCollab._idManager) & ", idService = " & replaceSqlSpecialChars(leCollab._idService) & ", StatutManager = " & replaceSqlSpecialChars(leCollab._StatutManager) & "where idCollaborateur = " & leCollab._idCollaborateur

        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using
    End Sub

    Public Function readManagerById(idManager As Integer) As ClsCollaborateur
        Dim unManager As ClsCollaborateur = Nothing
        Dim req As String = "select * from [dbo].[EICollaborateurs] where idCollaborateur = " & idManager

        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    unManager = New ClsCollaborateur(.OdbcReader("LibCollaborateur"), .OdbcReader("idManager"), .OdbcReader("idService"), .OdbcReader("idCollaborateur"))
                End While
            End With
        End Using
        Return unManager
    End Function

    Public Function readUnCollaborateurByEnt(idEnt As Integer) As ClsCollaborateur
        Dim unCollab As ClsCollaborateur = Nothing
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EICollaborateurs]  
                inner join [dbo].[EIEntretiens] 
                on [dbo].[EIEntretiens].IdCollaborateur = [dbo].[EICollaborateurs].IdCollaborateur
                where idEntretien = " & idEnt,
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    unCollab = New ClsCollaborateur(.OdbcReader("LibCollaborateur"), .OdbcReader("idManager"), .OdbcReader("idService"), .OdbcReader("idCollaborateur"))
                End While
            End With
        End Using
        Return unCollab
    End Function
End Class
