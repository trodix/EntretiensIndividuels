Public Class ClsUtilisateur

    Property _StatutManager As Integer
    Property _idCollaborateur As Integer
    Property _LibCollaborateur
    Property _password As String
    Property _idManager As Integer
    Property _idService As Boolean

    Public Sub New(idCollaborateur As Integer, LibCollaborateur As String, password As String, idManager As Integer, idService As Integer, StatutManager As Integer)
        _idCollaborateur = idCollaborateur
        _LibCollaborateur = LibCollaborateur
        _password = password
        _idManager = idManager
        _idService = idService
        _StatutManager = StatutManager
    End Sub

End Class
