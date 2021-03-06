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
            "select * from [dbo].[EIActions] 
            inner join [dbo].[EICollaborateurs] on [dbo].[EICollaborateurs].idCollaborateur = [dbo].[EIActions].RespAction
            order by DateCreation",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    Dim idActions As Integer = -1
                    Dim dc As New Date
                    Dim obj As String = ""
                    Dim actField As String = ""
                    Dim resrAct As String = ""
                    Dim LibresrAct As String = ""
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
                    If Not IsDBNull(.OdbcReader("LibCollaborateur")) Then LibresrAct = .OdbcReader("LibCollaborateur")
                    If Not IsDBNull(.OdbcReader("Delai")) Then delai = .OdbcReader("Delai")
                    If Not IsDBNull(.OdbcReader("SuiviCom")) Then suiviCom = .OdbcReader("SuiviCom")
                    If Not IsDBNull(.OdbcReader("StatutPDCA")) Then statutPDCA = .OdbcReader("StatutPDCA")
                    If Not IsDBNull(.OdbcReader("idCollaborateur")) Then idCollab = .OdbcReader("idCollaborateur")
                    If Not IsDBNull(.OdbcReader("idEntretien")) Then idEnt = .OdbcReader("idEntretien")
                    If Not IsDBNull(.OdbcReader("DateSolde")) Then ds = .OdbcReader("DateSolde")

                    Dim uneAction As New ClsAction(obj, actField, resrAct, LibresrAct, delai, suiviCom, statutPDCA, idCollab, idEnt, ds, dc, idActions)
                    lesActions.Add(idActions, uneAction)
                    'lesActions.Add(uneAction)
                End While
            End With
        End Using
        Return lesActions
    End Function

    Public Function readLesActionsNonSoldeCollab(idCollab As Integer)
        Dim lesActions As New Dictionary(Of Integer, ClsAction)
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(
            "select * from [dbo].[EIActions] where (DateSolde is null) and (idCollaborateur = " & idCollab & ") order by DateCreation",
            ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    Dim ds As New Date
                    If Not IsDBNull(.OdbcReader("DateSolde")) Then ds = .OdbcReader("DateSolde")
                    Dim uneAction As New ClsAction(
                        .OdbcReader("Objectif"), .OdbcReader("ActionField"), .OdbcReader("RespAction"),
                        .OdbcReader("Delai"), .OdbcReader("SuiviCom"), .OdbcReader("StatutPDCA"), .OdbcReader("idCollaborateur"), .OdbcReader("idEntretien"),
                        ds, .OdbcReader("DateCreation"), .OdbcReader("idActions")
                        )
                    lesActions.Add(uneAction._idAction, uneAction)
                End While
            End With
        End Using
        Return lesActions
    End Function

    Public Function readUneAction(idAction As Integer)
        Return _lesActions.Item(idAction)
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

    Public Function DeleteAction(idAction As Integer)
        Dim req As String = "delete from [dbo].[EIActions] where idActions = " & idAction
        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using
    End Function

    Public Function UpdateSolde(idAction As Integer)

        Dim req1 As String = "update [dbo].[EIActions] set DateSolde = '" & Date.Now & "' where idActions = " & idAction

        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)

            _odbcConnection.OdbcNotSelectQuery(req1)

        End Using

    End Function

    Public Function RecupAction(idNouveauEntretien As Integer, idAction As Integer)

        Dim req1 As String = "select * from [dbo].[EIActions] where idActions = " & idAction

        Dim temp_dc As Date
        Dim temp_ob As String
        Dim temp_af As String
        Dim temp_ra As String
        Dim temp_delai As Date
        Dim temp_sc As String
        Dim temp_pdca As String
        Dim temp_idColl As Integer = -1


        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(req1, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)

            With _odbcConnection
                While .OdbcReader.Read
                    temp_dc = .OdbcReader("DateCreation")
                    temp_ob = .OdbcReader("Objectif")
                    temp_af = .OdbcReader("ActionField")
                    temp_ra = .OdbcReader("RespAction")
                    temp_delai = .OdbcReader("Delai")
                    temp_sc = .OdbcReader("SuiviCom")
                    temp_pdca = .OdbcReader("StatutPDCA")
                    temp_idColl = .OdbcReader("idCollaborateur")
                End While
            End With
        End Using

        If temp_idColl <> -1 Then
            Dim req2 As String = "insert into [dbo].[EIActions] (DateCreation, Objectif, ActionField, RespAction, Delai, SuiviCom, StatutPDCA, idCollaborateur, idEntretien) values('" & temp_dc & "', " & "'" & temp_ob & "', " & "'" & temp_af & "', " & "'" & temp_ra & "', " & "'" & temp_delai & "', " & "'" & temp_sc & "', " & "'" & temp_pdca & "', " & "" & temp_idColl & ", " & idNouveauEntretien & ")"

            Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)

                _odbcConnection.OdbcNotSelectQuery(req2)

            End Using

        End If

    End Function


    Private Function replaceSqlSpecialChars(maChaine As String)
        Return maChaine.Replace("'", "''")
    End Function

End Class
