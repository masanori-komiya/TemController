Imports Microsoft.SqlServer
Imports System.Runtime.Remoting
Imports Ivi.Visa.Interop
Imports TemController.TemperatureDataPoint
Imports TemController.Form2

Public Class Form1
    Public TemperatureDataList As New List(Of TemperatureDataPoint)
    Private RM As New ResourceManager()
    Private CTC As New FormattedIO488()
    Private ChannelA As String
    Private ChannelB As String
    Private HeaterRange As String
    Private Ramp As String
    Private SetPoint As String
    Private Power As String
    Private Const TimerInterval As Integer = 2000
    Private strItem() As String = {"HI", "MID", "LOW"}
    Private s1, s2, s3 As String
    Private ReMSG As String
    Private Const MaxDataPoints As Integer = 21600
    Private count As Integer

    Private result As Double

    Private Sub LogError(errorMessage As String)
        MessageBox.Show($"Error: {errorMessage}")
    End Sub

    Private Sub ConnectToInstrument()
        Try
            Me.CTC.IO = Me.RM.Open("GPIB0::12::INSTR")

            Me.CTC.WriteString("INPUT? A")
            Me.ChannelA = Me.CTC.ReadString()

            Me.CTC.WriteString("INPUT? B")
            Me.ChannelB = Me.CTC.ReadString()

            Me.CTC.WriteString("LOOP 1:RANGE?")
            Me.HeaterRange = Me.CTC.ReadString()

            Me.CTC.WriteString("LOOP 1:RATE?")
            Me.Ramp = Me.CTC.ReadString()

            Me.CTC.WriteString("LOOP 1:SETPT?")
            Me.SetPoint = Me.CTC.ReadString()

            Me.CTC.WriteString("LOOP 1:OUTPWR?")
            Me.Power = Me.CTC.ReadString()

        Catch ex As Exception
            LogError($"Failed to connect to the instrument. {ex.Message}")
        End Try
    End Sub

    Private Sub Form1_Refresh()
        Me.ConnectToInstrument()
        Me.ChannelAText.Text = Me.ChannelA
        Me.ChannelBText.Text = Me.ChannelB
        Me.PowerText.Text = Me.Power
        Me.ComboBox1.Text = Me.HeaterRange
        Me.RampText.Text = Me.Ramp
        Me.SetPointText.Text = Me.SetPoint
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1.Items.AddRange(Me.strItem)
        Me.Form1_Refresh()
        Me.Timer1.Interval = TimerInterval
        Me.Timer1.Start()
    End Sub

    Private Sub SP_Button_Click(sender As Object, e As EventArgs) Handles SP_Button.Click
        Me.s1 = String.Concat("LOOP 1:SETPT ", Me.SetPointText.Text)
        Me.SendMSG(Me.s1)
    End Sub

    Private Sub HR_Button_Click(sender As Object, e As EventArgs) Handles HR_Button.Click
        Me.s2 = String.Concat("LOOP 1:RANGE ", Me.ComboBox1.SelectedItem.ToString)
        Me.SendMSG(Me.s2)
    End Sub

    Private Sub RR_Button_Click(sender As Object, e As EventArgs) Handles RR_Button.Click
        Me.s3 = String.Concat("LOOP 1:RATE ", Me.RampText.Text)
        Me.SendMSG(Me.s3)
    End Sub

    Private Sub SendMSG(msg)
        Try
            Me.CTC.WriteString(msg)
            MessageBox.Show("設定が完了しました。")
            Me.Form1_Refresh()
        Catch ex As Exception
            LogError($"Error while sending. {ex.Message}")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Me.CTC.WriteString("INPUT? A")
            Me.ChannelA = Me.CTC.ReadString()
            Me.CTC.WriteString("INPUT? B")
            Me.ChannelB = Me.CTC.ReadString()
            Me.CTC.WriteString("LOOP 1:OUTPWR?")
            Me.Power = Me.CTC.ReadString()
            Me.ChannelAText.Text = Me.ChannelA
            Me.ChannelBText.Text = Me.ChannelB
            Me.PowerText.Text = Me.Power

            ' Create a TemperatureDataPoint object with timestamp
            Dim dataPoint As New TemperatureDataPoint With {
                .Time = DateTime.Now
            }

            ' 値があればDoble型に変換し、datapointに保存
            Dim resultA As Double
            If Double.TryParse(Me.ChannelA, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, resultA) Then
                dataPoint.TemperatureA = resultA
            End If

            ' 値があればDoble型に変換し、datapointに保存
            Dim resultB As Double
            If Double.TryParse(Me.ChannelB, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, resultB) Then
                '最初は値が飛ぶため数点捨てる
                Me.count += 1
                If count > 3 Then
                    dataPoint.TemperatureB = resultB
                End If
            Else
                Me.count = 0
            End If

            'Time,TemperatureA, TemperatureBの値を持つdatapointを配列TemperatureDataListに0番から追加
            TemperatureDataList.Add(dataPoint)

            ' データポイントの数がMaxDataPointsを超えた場合は一番古いデータ(0番目)を削除
            If TemperatureDataList.Count > MaxDataPoints Then
                TemperatureDataList.RemoveAt(0)
            End If

        Catch ex As Exception
            Me.Timer1.Stop()
            LogError($"Error during timer tick. {ex.Message}")
        End Try
    End Sub

    Private Sub reload_Click(sender As Object, e As EventArgs) Handles reload.Click
        Me.Form1_Refresh()
    End Sub

    Private Sub ComSend_Click(sender As Object, e As EventArgs) Handles ComSend.Click
        If Me.ComText.Text.Contains("?") = True Then
            Try
                Me.CTC.WriteString(Me.ComText.Text)
                Me.ReMSG = Me.CTC.ReadString()
                MessageBox.Show(Me.ReMSG)
            Catch ex As Exception
                LogError($"Error during Sending. {ex.Message}")
            End Try
        Else
            Try
                Me.CTC.WriteString(Me.ComText.Text)
                MessageBox.Show("設定が完了しました。")
                Me.Form1_Refresh()
            Catch ex As Exception
                LogError($"Error during Sending. {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub OpenGraph_Button_Click(sender As Object, e As EventArgs) Handles Graph_button.Click
        ' Form2を開くボタンがクリックされたとき
        Dim form2 As New Form2()
        form2.SetTemperatureData(TemperatureDataList) ' TemperatureDataListをForm2に渡す
        form2.Show()
    End Sub

End Class

