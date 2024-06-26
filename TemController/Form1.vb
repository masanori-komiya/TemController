﻿Imports Microsoft.SqlServer
Imports System.Runtime.Remoting
Imports Ivi.Visa.Interop
Imports TemController.TemperatureDataPoint
Imports TemController.Form2
Imports System.IO
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting

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
    Private P, I, D As String
    Private Const TimerInterval As Integer = 2000
    Private strItem() As String = {"HI", "MID", "LOW"}
    Private ControlTypeItem() As String = {"OFF", "PID", "Manual", "PIDTable", "RAMPP"}
    Private ControlType As String
    Private s1, s2, s3, s4, s5, s6, s7 As String
    Private ReMSG As String
    Private Const MaxDataPoints As Integer = 43200
    Private count As Integer
    Private Const DataPath As String = "./温度データ"
    Private filename As String
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

            Me.CTC.WriteString("LOOP 1:TYPE?")
            Me.ControlType = Me.CTC.ReadString()

            Me.CTC.WriteString("LOOP 1:RATE?")
            Me.Ramp = Me.CTC.ReadString()

            Me.CTC.WriteString("LOOP 1:SETPT?")
            Me.SetPoint = Me.CTC.ReadString()

            Me.CTC.WriteString("LOOP 1:OUTPWR?")
            Me.Power = Me.CTC.ReadString()

            Me.CTC.WriteString("LOOP 1:PGAIN?")
            Me.P = Me.CTC.ReadString()

            Me.CTC.WriteString("LOOP 1:IGAIN?")
            Me.I = Me.CTC.ReadString()

            Me.CTC.WriteString("LOOP 1:DGAIN?")
            Me.D = Me.CTC.ReadString()
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
        If Me.ControlType = "TABLE" Then
            Me.ComboBoxControlType.Text = "PIDTable"
        ElseIf Me.ControlType = "MAN" Then
            Me.ComboBoxControlType.Text = "Manual"
        Else
            Me.ComboBoxControlType.Text = Me.ControlType
        End If
        Me.RampText.Text = Me.Ramp
        Me.SetPointText.Text = Me.SetPoint
        Me.PTextBox.Text = Me.P
        Me.ITextBox.Text = Me.I
        Me.DTextBox.Text = Me.D
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1.Items.AddRange(Me.strItem)
        Me.ComboBoxControlType.Items.AddRange(Me.ControlTypeItem)
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
    Private Sub ControlTypeButton_Click(sender As Object, e As EventArgs) Handles ControlTypeButton.Click
        If Me.ComboBoxControlType.SelectedItem = "PIDTable" Then
            Me.s4 = "LOOP 1:TYPE TABLE"
        ElseIf Me.ComboBoxControlType.SelectedItem = "Manual" Then
            Me.s4 = "LOOP 1:TYPE MAN"
        Else
            Me.s4 = String.Concat("LOOP 1:TYPE ", Me.ComboBoxControlType.SelectedItem.ToString)
        End If
        Me.SendMSG(Me.s4)
    End Sub


    Private Sub PButton_Click(sender As Object, e As EventArgs) Handles PButton.Click
        Me.s5 = String.Concat("LOOP 1:PGAIN ", Me.PTextBox.Text)
        Me.SendMSG(Me.s5)
    End Sub

    Private Sub IButton_Click(sender As Object, e As EventArgs) Handles IButton.Click
        Me.s6 = String.Concat("LOOP 1:IGAIN ", Me.ITextBox.Text)
        Me.SendMSG(Me.s6)
    End Sub


    Private Sub DButton_Click(sender As Object, e As EventArgs) Handles DButton.Click
        Me.s7 = String.Concat("LOOP 1:DGAIN ", Me.DTextBox.Text)
        Me.SendMSG(Me.s7)
    End Sub


    Private Sub SendMSG(msg)
        Try
            Me.CTC.WriteString(msg)
            MessageBox.Show($"設定を送信しました。{vbCrLf} {msg}")
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

            If CheckBox1.Checked Then
                Me.SaveDataPointToCSV(dataPoint)
            End If

        Catch ex As Exception
            Me.Timer1.Stop()
            LogError($"Error during timer tick. {ex.Message}")
        End Try
    End Sub

    Private Sub reload_Click(sender As Object, e As EventArgs) Handles reload.Click
        Me.Form1_Refresh()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Dim StartTime As DateTime = DateTime.Now
            Me.filename = Path.Combine(DataPath, $"{StartTime.ToString("yyyyMMddHHmmss")}.csv")
            'StreamWrite(False)でファイルを作成または上書き
            Try
                Using sw As New StreamWriter(Me.filename, False, System.Text.Encoding.UTF8)
                    sw.WriteLine("Time,TemperatureA,TemperatureB")
                End Using
            Catch ex As Exception
                LogError($"Error while creating the CSV file. {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub SaveDataPointToCSV(dataPoint As TemperatureDataPoint)
        Try
            ' StreamWireter(True)で既存のファイルに追加
            Using sw As New StreamWriter(Me.filename, True, System.Text.Encoding.UTF8)
                sw.WriteLine($"{dataPoint.Time},{dataPoint.TemperatureA},{dataPoint.TemperatureB}")
            End Using

        Catch ex As Exception
            LogError($"Error while saving data point to CSV. {ex.Message}")
            CheckBox1.Checked = False
            Exit Sub
        End Try

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
                MessageBox.Show("設定を送信しました。")
                Me.Form1_Refresh()
            Catch ex As Exception
                LogError($"Error during Sending. {ex.Message}")
            End Try
        End If
    End Sub

    Private Async Sub OpenGraph_Button_Click(sender As Object, e As EventArgs) Handles Graph_button.Click
        ' Form2を開くボタンがクリックされたとき
        If Me.TemperatureDataList.Count > 1 Then
            Dim form2 As New Form2()
            form2.SetTemperatureData(Me.TemperatureDataList) ' TemperatureDataListをForm2に渡す
            form2.Show()
        Else
            'データが無い時はグラフを表示せずに待機
            DirectCast(sender, Button).Enabled = False
            Dim i As Integer = 0
            While Me.TemperatureDataList.Count < 2 And i <= 6
                Await Task.Run(
                    Sub()
                        System.Threading.Thread.Sleep(1000)
                    End Sub
                    )
                i = i + 1
            End While

            If i >= 6 Then
                MessageBox.Show("データがありません")
            Else
                Dim form2 As New Form2()
                form2.SetTemperatureData(Me.TemperatureDataList) ' TemperatureDataListをForm2に渡す
                form2.Show()
            End If
            DirectCast(sender, Button).Enabled = True
        End If
    End Sub

End Class

