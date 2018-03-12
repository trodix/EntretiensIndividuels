Public Class ClsSQLStatistique

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

    Public Function NbActSoldeByManager() ' a corriger
        Dim rows As New Dictionary(Of String, Integer)
        Dim req As String = "select cast(LibCollaborateur as nvarchar) as LibCollaborateur, count(DateSolde) as NbActSoldeManager from [dbo].[EIActions] 
            right join [dbo].[EICollaborateurs] 
            on [dbo].[EIActions].idCollaborateur = [dbo].[EICollaborateurs].idCollaborateur
            where (DateSolde is null) and ([dbo].[EICollaborateurs].StatutManager > 0)
            group by cast(LibCollaborateur as nvarchar)"
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read()
                    rows.Add(.OdbcReader("LibCollaborateur"), .OdbcReader("NbActSoldeManager"))
                End While
            End With
        End Using
        Return rows
    End Function

    Public Function NbActSoldeByService() ' a corriger
        Dim rows As New Dictionary(Of String, Integer)
        Dim req As String = "select cast(LibService as nvarchar), count(DateSolde) as NbActSoldeService from [dbo].[EIActions] 
            inner join [dbo].[EICollaborateurs] on [dbo].[EIActions].idCollaborateur = [dbo].[EICollaborateurs].idCollaborateur
            inner join [dbo].[EIServices] on [dbo].[EIServices].idService = [dbo].[EICollaborateurs].idService
            where (DateSolde is null) and ([dbo].[EICollaborateurs].StatutManager > 0)
            group by cast(LibService as nvarchar)"
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read()
                    rows.Add(.OdbcReader("LibService"), .OdbcReader("NbActSoldeService"))
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

End Class
