Imports System.Windows.Forms.DataVisualization.Charting
Imports TemController.TemperatureDataPoint
Imports TemController.Form1
Imports TemController.Form3
Imports System.IO
Public Class Form2
    '手動かオードかを区別するためのフラッグ、初期はオート
    Private Flag As Integer = 0
    Public Max As Double
    Public Min As Double
    Private LastTime As DateTime


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Chartのフォーマットを設定
        Chart1.ChartAreas(0).AxisX.Title = "時間 [hh:mm]"
        Chart1.ChartAreas(0).AxisY.Title = "温度 [K]"
        '目盛りの表記をHH:mmに変更
        Chart1.ChartAreas(0).AxisX.LabelStyle.Format = "HH:mm"
        Chart1.ChartAreas(0).AxisY.IsStartedFromZero = False
        'ラジオボタンにチェックを入れる。
        RadioButton3.Checked = True
    End Sub

    Public Sub SetTemperatureData(dataList As List(Of TemperatureDataPoint))
        ' Form1からTemperatureDataPointのリストを受け取り、Chartに描画するメソッド
        ' Chartdデータの初期化
        Chart1.Series.Clear()
        'データ系列の設定
        Chart1.Series.Add("ChannelA")
        Chart1.Series("ChannelA").ChartType = SeriesChartType.Line

        Chart1.Series.Add("ChannelB")
        Chart1.Series("ChannelB").ChartType = SeriesChartType.Line

        ' データを登録
        For i As Integer = 0 To dataList.Count - 1
            Dim dataPoint = dataList(i)
            If dataPoint.TemperatureA <> Nothing Then
                Chart1.Series("ChannelA").Points.AddXY(dataPoint.Time, dataPoint.TemperatureA)
            End If

            If dataPoint.TemperatureB <> Nothing Then
                Chart1.Series("ChannelB").Points.AddXY(dataPoint.Time, dataPoint.TemperatureB)
            Else
                'データがないところでは折れ線を表示しない。
                Chart1.Series("ChannelB").Points.AddXY(dataPoint.Time, 0)
                Chart1.Series("ChannelB").Points(i).IsEmpty = True
            End If
        Next

        Me.LastTime = dataList.Last().Time
        UpdateGraphScale()
    End Sub

    Private Sub UpdateGraphButton_Click(sender As Object, e As EventArgs) Handles UpdateGraphButton.Click
        '新しいTemController.Form1.TemperatureDataListデータでグラフを描画
        Me.SetTemperatureData(TemController.Form1.TemperatureDataList)
    End Sub

    Public Sub UpdateGraphScale()
        '縦軸目盛り範囲設定
        If Me.Flag = 0 Then
            Chart1.ChartAreas(0).AxisY.Minimum = Double.NaN
            Chart1.ChartAreas(0).AxisY.Maximum = Double.NaN
            Chart1.ChartAreas(0).RecalculateAxesScale()
            Me.Max = Chart1.ChartAreas(0).AxisY.Maximum
            Me.Min = Chart1.ChartAreas(0).AxisY.Minimum
        Else
            Chart1.ChartAreas(0).AxisY.Maximum = Me.Max
            Chart1.ChartAreas(0).AxisY.Minimum = Me.Min
        End If
        '横軸目盛り範囲設定
        If RadioButton1.Checked Then
            Dim twoHoursAgo As DateTime = Me.LastTime.AddHours(-2)
            Chart1.ChartAreas(0).AxisX.Minimum = twoHoursAgo.ToOADate()
        ElseIf RadioButton2.Checked Then
            Dim sixHoursAgo As DateTime = Me.LastTime.AddHours(-6)
            Chart1.ChartAreas(0).AxisX.Minimum = sixHoursAgo.ToOADate()
        Else
            Chart1.ChartAreas(0).AxisX.Minimum = Double.NaN
            Chart1.ChartAreas(0).AxisX.Maximum = Double.NaN
        End If
    End Sub


    Private Sub ManualButton_Click(sender As Object, e As EventArgs) Handles ManualButton.Click
        Me.Flag = 1
        Dim form3 As New Form3(Me)
        form3.Show()
    End Sub

    Private Sub AutoButton_Click(sender As Object, e As EventArgs) Handles AutoButton.Click
        Me.Flag = 0
        Me.UpdateGraphScale()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim twoHoursAgo As DateTime = Me.LastTime.AddHours(-2)
        Chart1.ChartAreas(0).AxisX.Minimum = twoHoursAgo.ToOADate()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim sixHoursAgo As DateTime = Me.LastTime.AddHours(-6)
        Chart1.ChartAreas(0).AxisX.Minimum = sixHoursAgo.ToOADate()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Chart1.ChartAreas(0).AxisX.Minimum = Double.NaN
        Chart1.ChartAreas(0).AxisX.Maximum = Double.NaN
    End Sub

End Class
