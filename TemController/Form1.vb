Imports Microsoft.SqlServer
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
    Private PID As String
    Private Const TimerInterval As Integer = 2000
    Private strItem() As String = {"Off", "Low", "Med", "High"}
    Private ControlTypeItem() As String = {"PID", "RAMP", "ZONE", "MANUAL"}
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

            Me.CTC.WriteString("KRDG? A")
            Me.ChannelA = Me.CTC.ReadString()
            Me.CTC.WriteString("KRDG? B")
            Me.ChannelB = Me.CTC.ReadString()

            Me.CTC.WriteString("RANGE? 1")
            Me.HeaterRange = Me.CTC.ReadString()

            Me.CTC.WriteString("OUTMODE? 1")
            Me.ControlType = Me.CTC.ReadString()

            Me.CTC.WriteString("RAMP? 1")
            Me.Ramp = Me.CTC.ReadString()

            Me.CTC.WriteString("SETP?")
            Me.SetPoint = Me.CTC.ReadString()

            Me.CTC.WriteString("HTR? 1")
            Me.Power = Me.CTC.ReadString()

            Me.CTC.WriteString("PID? 1")
            Me.PID = Me.CTC.ReadString()

        Catch ex As Exception
            LogError($"Failed to connect to the instrument. {ex.Message}")
        End Try
    End Sub
    Private Function GetHeaterRangeValue(selectedText As String) As Integer
        Select Case selectedText
            Case "Off"
                Return 0
            Case "Low"
                Return 1
            Case "Med"
                Return 2
            Case "High"
                Return 3
            Case Else
                ' 予期しない値の場合はデフォルトで0を返す
                Return 0
        End Select
    End Function

    ' 数値を"Off", "Low", "Med", "High"に変換する関数
    Private Function GetHeaterRangeText(rangeValue As Integer) As String
        Select Case rangeValue
            Case 0
                Return "Off"
            Case 1
                Return "Low"
            Case 2
                Return "Med"
            Case 3
                Return "High"
            Case Else
                ' 予期しない値の場合は空文字列を返す
                Return String.Empty
        End Select
    End Function

    Private Sub Form1_Refresh()
        Me.ConnectToInstrument()
        Me.ChannelAText.Text = Me.ChannelA
        Me.ChannelBText.Text = Me.ChannelB
        Me.PowerText.Text = Me.Power

        ' HeaterRangeの数値を対応するテキストに変換して表示
        Dim heaterRangeValue As Integer
        If Integer.TryParse(Me.HeaterRange.Trim(), heaterRangeValue) Then
            Me.ComboBox1.Text = GetHeaterRangeText(heaterRangeValue)
        End If

        Me.ControlTypeText.Text = Me.ControlType

        ' Rampの値に応じてボタンのテキストと色を更新
        If Me.Ramp.Trim().StartsWith("1") Then
            Me.RampONOFF.Text = "ON"
            Me.RampONOFF.BackColor = Color.LightGreen
        Else
            Me.RampONOFF.Text = "OFF"
            Me.RampONOFF.BackColor = SystemColors.Control
        End If
        ' Me.Rampの先頭2文字を除いた文字列をMe.RampText.Textに代入する
        If Me.Ramp.Length > 2 Then
            Me.RampText.Text = Me.Ramp.Substring(2).Trim()
        Else
            ' Me.Rampの長さが2以下の場合、空の文字列を代入
            Me.RampText.Text = String.Empty
        End If

        Me.SetPointText.Text = Me.SetPoint
        Me.PIDTextBox.Text = Me.PID
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1.Items.AddRange(Me.strItem)
        Me.Form1_Refresh()
        Me.Timer1.Interval = TimerInterval
        Me.Timer1.Start()
    End Sub

    Private Sub SP_Button_Click(sender As Object, e As EventArgs) Handles SP_Button.Click
        Me.s1 = String.Concat("SETP 1,", Me.SetPointText.Text, "\n")
        Me.SendMSG(Me.s1)
    End Sub

    Private Sub HR_Button_Click(sender As Object, e As EventArgs) Handles HR_Button.Click
        Dim selectedRange As String = Me.ComboBox1.SelectedItem.ToString()
        Dim rangeValue As Integer = GetHeaterRangeValue(selectedRange)
        Me.s2 = String.Concat("RANGE 1,", rangeValue, "\n")
        Me.SendMSG(Me.s2)
    End Sub

    Private Sub RR_Button_Click(sender As Object, e As EventArgs) Handles RR_Button.Click
        If Me.Ramp.Trim().StartsWith("1") Then
            Me.s3 = String.Concat("RAMP 1,1,", Me.RampText.Text, "\n")
            Me.SendMSG(Me.s3)
        Else
            Me.s3 = String.Concat("RAMP 1,0,", Me.RampText.Text, "\n")
            Me.SendMSG(Me.s3)
        End If
    End Sub

    Private Sub ControlTypeButton_Click(sender As Object, e As EventArgs) Handles ControlTypeButton.Click
        Me.s4 = String.Concat("OUTMODE 1,", Me.ControlTypeText.Text, "\n")
        Me.SendMSG(Me.s4)
    End Sub


    Private Sub PIDButton_Click(sender As Object, e As EventArgs) Handles PIDButton.Click
        Me.s5 = String.Concat("PID 1,", Me.PIDTextBox.Text, "\n")
        Me.SendMSG(Me.s5)
    End Sub

    Private Sub ONOFFButton_Click(sender As Object, e As EventArgs) Handles RampONOFF.Click
        '一文字目が0または1でon/off切り替え
        If Me.Ramp.Trim().StartsWith("0") Then
            Me.s3 = String.Concat("RAMP 1,1,", Me.RampText.Text, "\n")
            Me.SendMSG(Me.s3)
        Else
            Me.s3 = String.Concat("RAMP 1,0,", Me.RampText.Text, "\n")
            Me.SendMSG(Me.s3)
        End If
    End Sub



    Private Sub SendMSG(msg)
        '送信した後リフレッシュ
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
            Me.CTC.WriteString("KRDG? A")
            Me.ChannelA = Me.CTC.ReadString()
            Me.CTC.WriteString("KRDG? B")
            Me.ChannelB = Me.CTC.ReadString()
            Me.CTC.WriteString("HTR? 1")
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

    Private Sub Reload_Click(sender As Object, e As EventArgs) Handles reload.Click
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

