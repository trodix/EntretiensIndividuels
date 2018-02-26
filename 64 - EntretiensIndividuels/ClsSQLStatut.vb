Public Class ClsSQLStatut

    Property _LesStatuts As New Dictionary(Of Integer, ClsStatut)

    Public Sub New()

    End Sub

    Private Sub readLesStatuts()
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EIStatut]",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    Dim unStatut As New ClsStatut(.OdbcReader("idStatut"), .OdbcReader("LibelleStatut"))
                    _LesStatuts.Add(unStatut._idStatut, unStatut._LibelleStatut)
                End While
            End With
        End Using
    End Sub

End Class
