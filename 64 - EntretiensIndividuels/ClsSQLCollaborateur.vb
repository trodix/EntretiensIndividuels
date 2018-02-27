Public Class ClsSQLCollaborateur

    Property _lesCollaborateurs As Dictionary(Of Integer, ClsCollaborateur) = readLesCollaborateurs()
    Property _lesManagers As Dictionary(Of Integer, ClsCollaborateur) = readLesManagers()

    Public Sub New()
        readLesCollaborateurs()
    End Sub

    Private Function readLesCollaborateurs()
        Dim lesCollaborateurs As New Dictionary(Of Integer, ClsCollaborateur)
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EICollaborateurs]",
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

    Private Function readLesManagers()
        Dim lesManagers As New Dictionary(Of Integer, ClsCollaborateur)
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EICollaborateurs] where StatutManager >= 1",
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

    Public Function readUnCollaborateur(idCollaborateur As Integer)
        Return _lesCollaborateurs.Item(idCollaborateur)
    End Function

    Public Function InsertCollaborateur(col As ClsCollaborateur)
        Dim req As String = "insert into [dbo].[EICollaborateurs] (LibCollaborateur, MotDePasse, idManager, idService, StatutManager) values(
                '" & col._libelleCollaborateur & "', '" & col._password & "', '" & col._idManager & "', '" & col._idService & "', '" & col._StatutManager & "')"
        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using
    End Function

End Class
