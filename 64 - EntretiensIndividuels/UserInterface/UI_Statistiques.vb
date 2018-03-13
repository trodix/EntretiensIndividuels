Public Class UI_Statistiques

    Property _maClsSQLStat As New ClsSQLStatistique

    Private Sub UI_Statistiques_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim NbActTotal As Integer = _maClsSQLStat.NbActTotal

        Dim NbActTotalManager As Dictionary(Of String, Integer) = _maClsSQLStat.NbActTotalByManager
        Dim soldeByManager As Dictionary(Of String, Integer) = _maClsSQLStat.NbActSoldeByManager

        For Each item As KeyValuePair(Of String, Integer) In soldeByManager
            Dim value = Format(item.Value / NbActTotalManager(item.Key), "#0.00")
            Chart1.Series("ActionsSoldeManager").Points.AddXY(item.Key, item.Value * 100)
        Next

        Dim NbActTotalService As Dictionary(Of String, Integer) = _maClsSQLStat.NbActTotalByService
        Dim soldeByService As Dictionary(Of String, Integer) = _maClsSQLStat.NbActSoldeByService

        For Each item As KeyValuePair(Of String, Integer) In soldeByService
            Dim value = Format(item.Value / NbActTotalService(item.Key), "#0.00")
            Chart2.Series("ActionsSoldeService").Points.AddXY(item.Key, item.Value * 100)
        Next

    End Sub

End Class
