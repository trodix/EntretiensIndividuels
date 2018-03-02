Public Class ClsAction

    Property _idAction As Integer
    Property _DateCreation As Date
    Property _Objectif As String
    Property _ActionField As String
    Property _RespAction As String
    Property _Delai As Date
    Property _SuiviCom As String
    Property _StatutPDCA As Char
    Property _idCollaborateur As Integer
    Property _idEntretien As Integer
    Property _DateSolde As Date

    Public Sub New(Objectif As String, ActionField As String, RespAction As String, Delai As Date, SuiviCom As String, StatutPDCA As Char, idCollaborateur As Integer, idEntretien As Integer, Optional DateSolde As Date = Nothing, Optional DateCreation As Date = Nothing, Optional idAction As Integer = -1)
        _idAction = idAction
        _DateCreation = DateCreation
        _Objectif = Objectif
        _ActionField = ActionField
        _RespAction = RespAction
        _Delai = Delai
        _SuiviCom = SuiviCom
        _StatutPDCA = StatutPDCA
        _idCollaborateur = idCollaborateur
        _idEntretien = idEntretien
        _DateSolde = DateSolde
        If DateCreation = New Date Then
            _DateCreation = Date.Today
        End If
    End Sub
End Class
