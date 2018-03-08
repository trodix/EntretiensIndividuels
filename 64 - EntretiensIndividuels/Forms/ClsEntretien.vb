Imports System.IO

Public Class ClsEntretien

    Property _idEntretien As Integer
    Property _DateEntretien As New Date
    Property _DateEntretienSuivi As New Date
    Property _idCollaborateur As Integer
    Property _Document As Byte()
    Property _nomDocument As String
    Property _extensionDocument As String
    Property _maClsSQLAction As New ClsSQLAction
    Property _lesActionsEnt As New Dictionary(Of Integer, ClsAction)

    Public Sub New(DateEntretien As Date, DateEntretienSuivi As Date, idCollaborateur As Integer, Optional idEntretien As Integer = -1,
                   Optional Document As Byte() = Nothing, Optional nomDocument As String = Nothing, Optional extensionDocument As String = Nothing)
        _idEntretien = idEntretien
        _DateEntretien = DateEntretien
        _DateEntretienSuivi = DateEntretienSuivi
        _idCollaborateur = idCollaborateur
        _Document = Document
        _nomDocument = nomDocument
        _extensionDocument = extensionDocument
        'For Each action As ClsAction In _maClsSQLAction.readLesActionsEnt(idCollaborateur, idEntretien)
        '    '_lesActionsEnt = _maClsSQLAction.readLesActionsEnt(idCollaborateur, idEntretien)
        '    
        'Next
    End Sub

    Public Sub New()

    End Sub

    Public Sub associerActions(actions As ClsSQLAction)

        Dim _Result = From _Row In actions._lesActions
                      Where (_Row.Value._idEntretien = Me._idEntretien)

        For Each r In _Result
            _lesActionsEnt.Add(r.Value._idAction, r.Value)
        Next


    End Sub


End Class
