Public Class ClsSQLCollaborateur

    Property _lesCollaborateurs As New Dictionary(Of Integer, ClsCollaborateur)
    Property _lesManagers As New Dictionary(Of Integer, ClsCollaborateur)

    Public Sub New()
        readLesCollaborateurs()
    End Sub

    Private Sub readLesCollaborateurs()
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EICollaborateurs]",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    Dim unCollaborateur As New ClsCollaborateur(.OdbcReader("LibCollaborateur"), .OdbcReader("idManager"), .OdbcReader("idService"), .OdbcReader("idCollaborateur"))
                    _lesCollaborateurs.Add(.OdbcReader("idCollaborateur"), unCollaborateur)
                End While
            End With
        End Using
    End Sub

    Private Sub readLesManagers()
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EICollaborateurs] where StatutManager >= 1",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    Dim unManager As New ClsCollaborateur(.OdbcReader("LibCollaborateur"), .OdbcReader("idManager"), .OdbcReader("idService"), .OdbcReader("idCollaborateur"))
                    _lesManagers.Add(.OdbcReader("idCollaborateur"), unManager)
                End While
            End With
        End Using
    End Sub

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
