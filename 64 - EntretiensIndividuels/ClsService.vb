Public Class ClsService

    Property _idService
    Property _LibService

    Public Sub New(LibService As String, Optional idService As Integer = -1)
        _LibService = LibService
        _idService = idService
    End Sub
End Class
