﻿Public Class ClsSQLAction

    Property _lesActions As New Dictionary(Of Integer, ClsAction)
    'Property _lesActions As New List(Of ClsAction)

    Public Sub New()

        _lesActions = readLesActions()

    End Sub

    Private Function readLesActions()
        Dim lesActions As New Dictionary(Of Integer, ClsAction)
        'Dim lesActions As New List(Of ClsAction)
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EIActions] order by DateCreation",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    Dim idActions As Integer = -1
                    Dim dc As New Date
                    Dim obj As String = ""
                    Dim actField As String = ""
                    Dim resrAct As String = ""
                    Dim delai As New Date
                    Dim suiviCom As String = ""
                    Dim statutPDCA As Char = ""
                    Dim idCollab As Integer = -1
                    Dim idEnt As Integer = -1
                    Dim ds As New Date
                    If Not IsDBNull(.OdbcReader("idActions")) Then idActions = .OdbcReader("idActions")
                    If Not IsDBNull(.OdbcReader("DateCreation")) Then dc = .OdbcReader("DateCreation")
                    If Not IsDBNull(.OdbcReader("Objectif")) Then obj = .OdbcReader("Objectif")
                    If Not IsDBNull(.OdbcReader("ActionField")) Then actField = .OdbcReader("ActionField")
                    If Not IsDBNull(.OdbcReader("RespAction")) Then resrAct = .OdbcReader("RespAction")
                    If Not IsDBNull(.OdbcReader("Delai")) Then delai = .OdbcReader("Delai")
                    If Not IsDBNull(.OdbcReader("SuiviCom")) Then suiviCom = .OdbcReader("SuiviCom")
                    If Not IsDBNull(.OdbcReader("StatutPDCA")) Then statutPDCA = .OdbcReader("StatutPDCA")
                    If Not IsDBNull(.OdbcReader("idCollaborateur")) Then idCollab = .OdbcReader("idCollaborateur")
                    If Not IsDBNull(.OdbcReader("idEntretien")) Then idEnt = .OdbcReader("idEntretien")
                    If Not IsDBNull(.OdbcReader("DateSolde")) Then ds = .OdbcReader("DateSolde")

                    Dim uneAction As New ClsAction(obj, actField, resrAct, delai, suiviCom, statutPDCA, idCollab, idEnt, ds, dc, idActions)
                    lesActions.Add(idActions, uneAction)
                    'lesActions.Add(uneAction)
                End While
            End With
        End Using
        Return lesActions
    End Function

    Public Function readUneAction(idAction As Integer)
        Return _lesActions.Item(idAction) 'bug ici
    End Function

    Public Function readLesActionsEnt(idCollaborateur As Integer, idEntretien As Integer)

        Dim lesActionsEnt As New List(Of ClsAction)

        For Each action As ClsAction In _lesActions.Values
            If action._idCollaborateur = idCollaborateur And action._idEntretien = idEntretien Then
                lesActionsEnt.Add(action)
            End If
        Next

        Return lesActionsEnt

    End Function

    Public Function InsertAction(act As ClsAction)
        'act._DateCreation = Date.Today
        Dim req As String = "insert into [dbo].[EIActions] (DateCreation, Objectif, ActionField, RespAction, Delai, SuiviCom, StatutPDCA, idCollaborateur, idEntretien) values(
                '" & replaceSqlSpecialChars(act._DateCreation) & "', '" & replaceSqlSpecialChars(act._Objectif) & "', '" & replaceSqlSpecialChars(act._ActionField) & "', '" & replaceSqlSpecialChars(act._RespAction) & "', '" & replaceSqlSpecialChars(act._Delai) & "', '" & replaceSqlSpecialChars(act._SuiviCom) & "', '" & replaceSqlSpecialChars(act._StatutPDCA) & "', '" &
                replaceSqlSpecialChars(act._idCollaborateur) & "', '" & replaceSqlSpecialChars(act._idEntretien) & "')"
        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using
    End Function

    Public Function UpdateAction(act As ClsAction)
        Dim req As String = "update [dbo].[EIActions] set Objectif = '" & replaceSqlSpecialChars(act._Objectif) & "', ActionField = '" & replaceSqlSpecialChars(act._ActionField) & "', RespAction = " & act._RespAction & ", Delai = '" & replaceSqlSpecialChars(act._Delai) & "', SuiviCom = '" &
                replaceSqlSpecialChars(act._SuiviCom) & "', StatutPDCA = '" & replaceSqlSpecialChars(act._StatutPDCA) & "' where idActions = " & act._idAction
        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using
    End Function


    Private Function replaceSqlSpecialChars(maChaine As String)
        Return maChaine.Replace("'", "''")
    End Function

End Class