Public Class ClsSQLStatut

    Property _LesStatuts As Dictionary(Of Integer, ClsStatut) = readLesStatuts()

    Public Sub New()

    End Sub

    Private Function readLesStatuts()
        Dim lesStatuts As New Dictionary(Of Integer, ClsStatut)
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EIStatut]",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    Dim unStatut As New ClsStatut(.OdbcReader("idStatut"), .OdbcReader("LibelleStatut"))
                    lesStatuts.Add(unStatut._idStatut, unStatut)
                End While
            End With
        End Using
        Return lesStatuts
    End Function

    Public Function readStatutById(idStatut As Integer)
        Dim unStatut As ClsStatut = Nothing
        Dim req As String = "select * from [dbo].[EIStatut] where idStatut = " & idStatut

        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    unStatut = New ClsStatut(.OdbcReader("idStatut"), .OdbcReader("LibelleStatut"))
                End While
            End With
        End Using
        Return unStatut
    End Function

End Class
