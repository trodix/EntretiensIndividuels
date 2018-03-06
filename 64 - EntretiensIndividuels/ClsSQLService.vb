Public Class ClsSQLService

    Property _lesServices As Dictionary(Of Integer, ClsService) = readLesServices()

    Public Sub New()


    End Sub

    Private Function readLesServices()
        Dim lesServices As New Dictionary(Of Integer, ClsService)
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EIServices] order by cast(LibService as nvarchar)",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    Dim unService As New ClsService(.OdbcReader("LibService"), .OdbcReader("idService"))
                    lesServices.Add(unService._idService, unService)
                End While
            End With
        End Using
        Return lesServices
    End Function

    Public Function readServiceById(idService As Integer)
        Dim unService As ClsService = Nothing
        Dim req As String = "select * from [dbo].[EIServices] where idService = " & idService

        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    unService = New ClsService(.OdbcReader("LibService"), .OdbcReader("idService"))
                End While
            End With
        End Using
        Return unService
    End Function

End Class
