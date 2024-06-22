<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ChannelAText = New System.Windows.Forms.TextBox()
        Me.ChannelBText = New System.Windows.Forms.MaskedTextBox()
        Me.SetPointText = New System.Windows.Forms.MaskedTextBox()
        Me.RampText = New System.Windows.Forms.MaskedTextBox()
        Me.ComText = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PowerText = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SP_Button = New System.Windows.Forms.Button()
        Me.HR_Button = New System.Windows.Forms.Button()
        Me.RR_Button = New System.Windows.Forms.Button()
        Me.ComSend = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Graph_button = New System.Windows.Forms.Button()
        Me.reload = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBoxControlType = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ControlTypeButton = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PIDTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PIDButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ChannelAText
        '
        Me.ChannelAText.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChannelAText.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ChannelAText.Location = New System.Drawing.Point(139, 42)
        Me.ChannelAText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChannelAText.Name = "ChannelAText"
        Me.ChannelAText.Size = New System.Drawing.Size(137, 22)
        Me.ChannelAText.TabIndex = 0
        '
        'ChannelBText
        '
        Me.ChannelBText.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChannelBText.Location = New System.Drawing.Point(139, 74)
        Me.ChannelBText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChannelBText.Name = "ChannelBText"
        Me.ChannelBText.ReadOnly = True
        Me.ChannelBText.Size = New System.Drawing.Size(137, 22)
        Me.ChannelBText.TabIndex = 1
        '
        'SetPointText
        '
        Me.SetPointText.Location = New System.Drawing.Point(139, 200)
        Me.SetPointText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SetPointText.Name = "SetPointText"
        Me.SetPointText.Size = New System.Drawing.Size(137, 22)
        Me.SetPointText.TabIndex = 2
        '
        'RampText
        '
        Me.RampText.Location = New System.Drawing.Point(139, 360)
        Me.RampText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RampText.Name = "RampText"
        Me.RampText.Size = New System.Drawing.Size(137, 22)
        Me.RampText.TabIndex = 3
        '
        'ComText
        '
        Me.ComText.Location = New System.Drawing.Point(139, 498)
        Me.ComText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComText.Name = "ComText"
        Me.ComText.Size = New System.Drawing.Size(264, 22)
        Me.ComText.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(139, 250)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(137, 23)
        Me.ComboBox1.TabIndex = 5
        '
        'PowerText
        '
        Me.PowerText.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PowerText.Location = New System.Drawing.Point(139, 119)
        Me.PowerText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PowerText.Name = "PowerText"
        Me.PowerText.ReadOnly = True
        Me.PowerText.Size = New System.Drawing.Size(137, 22)
        Me.PowerText.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ChannelA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ChannelB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 125)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Power"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 205)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "SetPoint"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 255)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Heater Range"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 364)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Ramp Rate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 501)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "その他コマンド"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(281, 49)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "K"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(281, 78)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "K"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(281, 124)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "％"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(281, 365)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 15)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "K/min"
        '
        'SP_Button
        '
        Me.SP_Button.Location = New System.Drawing.Point(292, 198)
        Me.SP_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SP_Button.Name = "SP_Button"
        Me.SP_Button.Size = New System.Drawing.Size(59, 29)
        Me.SP_Button.TabIndex = 18
        Me.SP_Button.Text = "Set"
        Me.SP_Button.UseVisualStyleBackColor = True
        '
        'HR_Button
        '
        Me.HR_Button.Location = New System.Drawing.Point(292, 248)
        Me.HR_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HR_Button.Name = "HR_Button"
        Me.HR_Button.Size = New System.Drawing.Size(59, 29)
        Me.HR_Button.TabIndex = 19
        Me.HR_Button.Text = "Set"
        Me.HR_Button.UseVisualStyleBackColor = True
        '
        'RR_Button
        '
        Me.RR_Button.Location = New System.Drawing.Point(337, 358)
        Me.RR_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RR_Button.Name = "RR_Button"
        Me.RR_Button.Size = New System.Drawing.Size(59, 29)
        Me.RR_Button.TabIndex = 20
        Me.RR_Button.Text = "Set"
        Me.RR_Button.UseVisualStyleBackColor = True
        '
        'ComSend
        '
        Me.ComSend.Location = New System.Drawing.Point(411, 494)
        Me.ComSend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComSend.Name = "ComSend"
        Me.ComSend.Size = New System.Drawing.Size(59, 29)
        Me.ComSend.TabIndex = 21
        Me.ComSend.Text = "Send"
        Me.ComSend.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Graph_button
        '
        Me.Graph_button.Location = New System.Drawing.Point(353, 42)
        Me.Graph_button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Graph_button.Name = "Graph_button"
        Me.Graph_button.Size = New System.Drawing.Size(93, 41)
        Me.Graph_button.TabIndex = 22
        Me.Graph_button.Text = "グラフ"
        Me.Graph_button.UseVisualStyleBackColor = True
        '
        'reload
        '
        Me.reload.Location = New System.Drawing.Point(603, 492)
        Me.reload.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.reload.Name = "reload"
        Me.reload.Size = New System.Drawing.Size(87, 32)
        Me.reload.TabIndex = 23
        Me.reload.Text = "表示更新"
        Me.reload.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(356, 101)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(123, 19)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "温度データ保存"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBoxControlType
        '
        Me.ComboBoxControlType.FormattingEnabled = True
        Me.ComboBoxControlType.Location = New System.Drawing.Point(139, 304)
        Me.ComboBoxControlType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxControlType.Name = "ComboBoxControlType"
        Me.ComboBoxControlType.Size = New System.Drawing.Size(137, 23)
        Me.ComboBoxControlType.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 309)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 15)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Control Type"
        '
        'ControlTypeButton
        '
        Me.ControlTypeButton.Location = New System.Drawing.Point(292, 300)
        Me.ControlTypeButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ControlTypeButton.Name = "ControlTypeButton"
        Me.ControlTypeButton.Size = New System.Drawing.Size(59, 29)
        Me.ControlTypeButton.TabIndex = 27
        Me.ControlTypeButton.Text = "Set"
        Me.ControlTypeButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(96, 406)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(160, 15)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "PID　設定範囲 0～1000"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(86, 435)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 15)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "P,I,D"
        '
        'PIDTextBox
        '
        Me.PIDTextBox.HidePromptOnLeave = True
        Me.PIDTextBox.Location = New System.Drawing.Point(139, 431)
        Me.PIDTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PIDTextBox.Name = "PIDTextBox"
        Me.PIDTextBox.Size = New System.Drawing.Size(209, 22)
        Me.PIDTextBox.TabIndex = 32
        '
        'PIDButton
        '
        Me.PIDButton.Location = New System.Drawing.Point(356, 428)
        Me.PIDButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PIDButton.Name = "PIDButton"
        Me.PIDButton.Size = New System.Drawing.Size(59, 29)
        Me.PIDButton.TabIndex = 38
        Me.PIDButton.Text = "Set"
        Me.PIDButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 641)
        Me.Controls.Add(Me.PIDButton)
        Me.Controls.Add(Me.PIDTextBox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ControlTypeButton)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBoxControlType)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.reload)
        Me.Controls.Add(Me.Graph_button)
        Me.Controls.Add(Me.ComSend)
        Me.Controls.Add(Me.RR_Button)
        Me.Controls.Add(Me.HR_Button)
        Me.Controls.Add(Me.SP_Button)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PowerText)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ComText)
        Me.Controls.Add(Me.RampText)
        Me.Controls.Add(Me.SetPointText)
        Me.Controls.Add(Me.ChannelBText)
        Me.Controls.Add(Me.ChannelAText)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "TemperatureController"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChannelAText As TextBox
    Friend WithEvents ChannelBText As MaskedTextBox
    Friend WithEvents SetPointText As MaskedTextBox
    Friend WithEvents RampText As MaskedTextBox
    Friend WithEvents ComText As MaskedTextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PowerText As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents SP_Button As Button
    Friend WithEvents HR_Button As Button
    Friend WithEvents RR_Button As Button
    Friend WithEvents ComSend As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Graph_button As Button
    Friend WithEvents reload As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBoxControlType As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ControlTypeButton As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PIDTextBox As MaskedTextBox
    Friend WithEvents PIDButton As Button
End Class
