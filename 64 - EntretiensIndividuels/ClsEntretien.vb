Imports System.IO

Public Class ClsEntretien

    Property _idEntretien As Integer
    Property _DateEntretien As New Date
    Property _DateEntretienSuivi As New Date
    Property _idCollaborateur As Integer
    Property _Document As File
    Property _maClsSQLAction As New ClsSQLAction
    Property _lesActionsEnt As New Dictionary(Of Integer, ClsAction)

    Public Sub New(DateEntretien As Date, DateEntretienSuivi As Date, idCollaborateur As Integer, Optional idEntretien As Integer = -1, Optional Document As File = Nothing)
        _idEntretien = idEntretien
        _DateEntretien = DateEntretien
        _DateEntretienSuivi = DateEntretienSuivi
        _idCollaborateur = idCollaborateur
        _Document = Document
        For Each action As ClsAction In _maClsSQLAction.readLesActionsEnt(idCollaborateur, idEntretien)
            '_lesActionsEnt = _maClsSQLAction.readLesActionsEnt(idCollaborateur, idEntretien)
            _lesActionsEnt.Add(action._idAction, action)
        Next
    End Sub

    Public Sub New()

    End Sub


End Class
