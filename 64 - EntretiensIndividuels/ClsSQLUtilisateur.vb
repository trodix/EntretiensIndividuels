Public Class ClsSQLUtilisateur

    Public Sub New()


    End Sub

    Public Function validUser(username As String, password As String)

        Dim currentUser = Nothing
        Dim requete As String = "select * from [dbo].[EICollaborateurs] where LibCollaborateur like '" & username & "' And MotDePasse like '" & password & "'"
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(requete, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    currentUser = New ClsUtilisateur(
                        .OdbcReader("idCollaborateur"), .OdbcReader("LibCollaborateur"), .OdbcReader("MotDePasse"), .OdbcReader("idManager"), .OdbcReader("idService"), .OdbcReader("StatutManager")
                        )
                End While
            End With
        End Using
        Return currentUser
    End Function

End Class
