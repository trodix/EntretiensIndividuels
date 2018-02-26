Public Class ClsAction

    Property _idAction As Integer
    Property _DateCreation As Date
    Property _Descriptif As String
    Property _RespAction As String
    Property _Delai As Date
    Property _SuiviCom As String
    Property _StatutPDCA As Char
    Property _idCollaborateur As Integer
    Property _idEntretien As Integer
    Property _DateSolde As Date

    Public Sub New(idAction As Integer, DateCreation As Date, Descriptif As String, RespAction As String, Delai As Date, SuiviCom As String, StatutPDCA As Char, idCollaborateur As Integer, idEntretien As Integer, DateSolde As Date)
        _idAction = idAction
        _DateCreation = DateCreation
        _Descriptif = Descriptif
        _RespAction = RespAction
        _Delai = Delai
        _SuiviCom = SuiviCom
        _StatutPDCA = StatutPDCA
        _idCollaborateur = idCollaborateur
        _idEntretien = idEntretien
        _DateSolde = DateSolde
    End Sub
End Class
