Public Class ClsSQLStatistique

    Property _lesServicesSQL As New ClsSQLService
    Property _lesServices As New Dictionary(Of Integer, ClsService)
    Property _lesCollabSQL As New ClsSQLCollaborateur
    Property _lesManagers As New Dictionary(Of Integer, ClsCollaborateur)

    Public Sub New()

        _lesServices = _lesServicesSQL.readLesServices
        _lesManagers = _lesCollabSQL.readLesManagers

    End Sub

    Public Function NbActTotal()
        Dim req As String = "select count(*) as NbActTotal from [dbo].[EIActions]"
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            s_FbMyReader.OdbcReader.Read()
            Return s_FbMyReader.OdbcReader("NbActTotal")
        End Using
    End Function

    Public Function NbActSolde()
        Dim req As String = "select count(*) as NbActSolde from [dbo].[EIActions] where DateSolde is not NULL"
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            s_FbMyReader.OdbcReader.Read()
            Return s_FbMyReader.OdbcReader("NbActSolde")
        End Using
    End Function

    Public Function NbActSoldeByManager()
        Dim rows As New Dictionary(Of String, Integer)
        ' pour chaque manager, afficher le libManager et le nombre d'actions soldées par collaborateur dans l'équipe de ce manager
        Dim req As String = "select 
            idManager,
            count(DateSolde) as NbActSoldeManager
            from [dbo].[EIActions]
            right join [dbo].[EICollaborateurs] 
            on [dbo].[EIActions].idCollaborateur = [dbo].[EICollaborateurs].idCollaborateur
            where idManager != 0
            group by idManager"
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read()
                    rows.Add(associerManager(.OdbcReader("idManager")), .OdbcReader("NbActSoldeManager"))
                End While
            End With
        End Using
        Return rows
    End Function

    Public Function NbActTotalByManager()
        Dim rows As New Dictionary(Of String, Integer)
        ' pour chaque manager, afficher le libManager et le nombre d'actions total par collaborateur dans l'équipe de ce manager
        Dim req As String = "select
            idManager,
            count(idActions) as NbActionTotal
            from [dbo].[EIActions]
            right join [dbo].[EICollaborateurs] 
            on [dbo].[EIActions].idCollaborateur = [dbo].[EICollaborateurs].idCollaborateur
            where idManager != 0
            group by idManager"
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read()
                    rows.Add(associerManager(.OdbcReader("idManager")), .OdbcReader("NbActionTotal"))
                End While
            End With
        End Using
        Return rows
    End Function

    Public Function NbActTotalByService()
        Dim rows As New Dictionary(Of String, Integer)
        ' pour chaque service, afficher le libService et le nombre d'actions total par collaborateur dans ce service
        Dim req As String = "select [dbo].[EIServices].idService, count(idActions) as NbActionTotal 
            from [dbo].[EIActions] 
            inner join [dbo].[EICollaborateurs] on [dbo].[EIActions].idCollaborateur = [dbo].[EICollaborateurs].idCollaborateur
            right join [dbo].[EIServices] on [dbo].[EIServices].idService = [dbo].[EICollaborateurs].idService
            group by [dbo].[EIServices].idService"
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read()
                    rows.Add(associerService(.OdbcReader("idService")), .OdbcReader("NbActionTotal"))
                End While
            End With
        End Using
        Return rows
    End Function

    Public Function NbActSoldeByService()
        Dim rows As New Dictionary(Of String, Integer)
        ' pour chaque service, afficher le libService et le nombre d'actions soldées par collaborateur dans ce service
        Dim req As String = "select [dbo].[EIServices].idService, count(DateSolde) as NbActSoldeService 
            from [dbo].[EIActions] 
            inner join [dbo].[EICollaborateurs] on [dbo].[EIActions].idCollaborateur = [dbo].[EICollaborateurs].idCollaborateur
            right join [dbo].[EIServices] on [dbo].[EIServices].idService = [dbo].[EICollaborateurs].idService
            group by [dbo].[EIServices].idService"
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read()
                    rows.Add(associerService(.OdbcReader("idService")), .OdbcReader("NbActSoldeService"))
                End While
            End With
        End Using
        Return rows
    End Function

    Public Function NbActSoldeByCollab(idCollaborateur As Integer)
        Dim req As String = "select count(*) as NbActSoldeCollab from [dbo].[EIActions] where DateSolde is not NULL and idCollaborateur = " & idCollaborateur
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            s_FbMyReader.OdbcReader.Read()
            Return s_FbMyReader.OdbcReader("NbActSoldeCollab")
        End Using
    End Function

    Public Function NbActByCollab(idCollaborateur As Integer)
        Dim req As String = "select count(*) as NbActCollab from [dbo].[EIActions] where idCollaborateur = " & idCollaborateur
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            s_FbMyReader.OdbcReader.Read()
            Return s_FbMyReader.OdbcReader("NbActCollab")
        End Using
    End Function

    Private Function associerService(unServiceId As Integer)

        For Each service As ClsService In _lesServices.Values
            If service._idService = unServiceId Then
                Return service._LibService
            End If
        Next

        Throw New KeyNotFoundException

    End Function

    Private Function associerManager(idCollaborateur As Integer)

        For Each manager As ClsCollaborateur In _lesManagers.Values
            'If idCollaborateur = 0 Then Return "Manager non défini"
            If manager._idCollaborateur = idCollaborateur Then
                Return manager._libelleCollaborateur
            End If
        Next

        Throw New KeyNotFoundException

    End Function

End Class
