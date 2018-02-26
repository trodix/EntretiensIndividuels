Public Class ClsSQLService

    Property _lesServices As New Dictionary(Of Integer, ClsService)

    Public Sub New()


    End Sub

    Private Sub readLesServices()
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EIServices]",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    Dim unService As New ClsService(.OdbcReader("LibService"), .OdbcReader("idService"))
                    _lesServices.Add(unService._idService, unService)
                End While
            End With
        End Using
    End Sub

End Class
