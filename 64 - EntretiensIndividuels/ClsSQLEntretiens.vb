Public Class ClsSQLEntretiens

    Property _lesEntretiens As New Dictionary(Of Integer, ClsEntretien)

    Public Sub New()
        _lesEntretiens = readLesEntretiens()
        'MessageBox.Show(_lesEntretiens.Count)
    End Sub

    Public Function readLesEntretiens()
        Dim lesEntretiens As New Dictionary(Of Integer, ClsEntretien)
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EIEntretiens]",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    If Not IsDBNull(.OdbcReader("idEntretien")) And Not IsDBNull(.OdbcReader("DateEntretien")) And Not IsDBNull(.OdbcReader("DateEntretienSuivi")) And Not IsDBNull(.OdbcReader("idCollaborateur")) Then
                        Dim DateEntretien As New Date(CDate(.OdbcReader("DateEntretien")).Year, CDate(.OdbcReader("DateEntretien")).Month, CDate(.OdbcReader("DateEntretien")).Day)
                        Dim DateEntretienSuivi As New Date(CDate(.OdbcReader("DateEntretienSuivi")).Year, CDate(.OdbcReader("DateEntretienSuivi")).Month, CDate(.OdbcReader("DateEntretienSuivi")).Day)
                        Dim unEntretien As New ClsEntretien(DateEntretien, DateEntretienSuivi, .OdbcReader("idCollaborateur"), .OdbcReader("idEntretien"),)
                        lesEntretiens.Add(.OdbcReader("idEntretien"), unEntretien)
                    End If
                End While
            End With
        End Using
        Return lesEntretiens
    End Function

    Public Function readLesEntretiensCollab(idCollaborateur As Integer)

        Dim lesEntretiensCollab As New List(Of ClsEntretien)

        For Each entretien As ClsEntretien In _lesEntretiens.Values
            If entretien._idCollaborateur = idCollaborateur Then
                lesEntretiensCollab.Add(entretien)
            End If
        Next

        Return lesEntretiensCollab

    End Function

    Public Function InsertEntretien(ent As ClsEntretien)
        Dim req As String = "insert into [dbo].[EIEntretiens] (DateEntretien, DateEntretienSuivi, idCollaborateur, DocumentScanne) values(
                '" & ent._DateEntretien & "', '" & ent._DateEntretienSuivi & "', " & ent._idCollaborateur & ", '" & Nothing & "')"
        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using
    End Function

    Public Function updateEntretien(ent As ClsEntretien)
        Dim req As String = "update [dbo].[EIEntretiens] set DateEntretien = '" & ent._DateEntretien & "', " & "DateEntretienSuivi = '" & ent._DateEntretienSuivi & "', DocumentScanne = '" & Nothing & "'"
        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using
    End Function

End Class
