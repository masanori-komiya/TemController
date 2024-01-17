Imports System.Windows.Forms.DataVisualization.Charting
Imports TemController.TemperatureDataPoint
Imports TemController.Form1
Public Class Form2
    Public Sub SetTemperatureData(dataList As List(Of TemperatureDataPoint))
        ' Form1からTemperatureDataPointのリストを受け取り、Chartに描画するメソッド

        ' Chartコントロールの初期化
        Chart1.Series.Clear()

        'データ系列の設定
        Chart1.Series.Add("ChannelA")
        Chart1.Series("ChannelA").ChartType = SeriesChartType.Line

        Chart1.Series.Add("ChannelB")
        Chart1.Series("ChannelB").ChartType = SeriesChartType.Line

        ' データを登録
        For Each dataPoint In dataList
            If dataPoint.TemperatureA <> Nothing Then
                Chart1.Series("ChannelA").Points.AddXY(dataPoint.Time, dataPoint.TemperatureA)
            End If

            If dataPoint.TemperatureB <> Nothing Then
                Chart1.Series("ChannelB").Points.AddXY(dataPoint.Time, dataPoint.TemperatureB)
            End If
        Next

        '目盛りの表記をHH:mmに変更
        Chart1.ChartAreas(0).AxisX.LabelStyle.Format = "HH:mm"
        Chart1.ChartAreas(0).AxisY.IsStartedFromZero = False
        Chart1.ChartAreas(0).RecalculateAxesScale()
    End Sub

    Private Sub UpdateGraphButton_Click(sender As Object, e As EventArgs) Handles UpdateGraphButton.Click
        Me.SetTemperatureData(TemController.Form1.TemperatureDataList)
    End Sub
End Class