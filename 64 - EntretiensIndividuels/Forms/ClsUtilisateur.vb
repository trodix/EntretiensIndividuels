Public Class ClsUtilisateur

    Property _StatutManager As Integer
    Property _idCollaborateur As Integer
    Property _LibCollaborateur
    Property _password As String
    Property _idManager As Integer
    Property _idService As Integer
    Property _Actif As Boolean = True

    Public Sub New(idCollaborateur As Integer, LibCollaborateur As String, password As String, idManager As Integer, idService As Integer, StatutManager As Integer, Actif As Boolean)
        _idCollaborateur = idCollaborateur
        _LibCollaborateur = LibCollaborateur
        _password = password
        _idManager = idManager
        _idService = idService
        _StatutManager = StatutManager
        _Actif = Actif
    End Sub

    Shared Function CryptPassword(password As String) As String

        Dim strToHash As String
        strToHash = password

        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult

    End Function

End Class
