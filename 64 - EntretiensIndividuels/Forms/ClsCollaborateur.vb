Public Class ClsCollaborateur

    Property _idCollaborateur As Integer
    Property _libelleCollaborateur As String
    Property _idManager As Integer
    Property _idService As Integer
    Property _StatutManager As Integer
    Property _password As String = ClsUtilisateur.CryptPassword("Acta89+")
    Property _Actif As Boolean = True
    Property _maClsEntretien As New ClsSQLEntretiens
    Property _lesEntretiensCollab As List(Of ClsEntretien)


    Public Sub New(libelleCollaborateur As String, idManager As Integer, idService As Integer, Actif As Boolean, Optional idCollaborateur As Integer = Nothing, Optional StatutManager As Integer = Nothing)
        _idCollaborateur = idCollaborateur
        _StatutManager = StatutManager
        _libelleCollaborateur = libelleCollaborateur
        _idManager = idManager
        _idService = idService
        _Actif = Actif
        _lesEntretiensCollab = readLesEntretiensCollab(_idCollaborateur)
    End Sub

    Public Function readLesEntretiensCollab(idCollab As Integer)
        Return _maClsEntretien.readLesEntretiensCollab(_idCollaborateur)
    End Function

End Class
