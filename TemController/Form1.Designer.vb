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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ITextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PButton = New System.Windows.Forms.Button()
        Me.IButton = New System.Windows.Forms.Button()
        Me.DButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ChannelAText
        '
        Me.ChannelAText.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChannelAText.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ChannelAText.Location = New System.Drawing.Point(104, 34)
        Me.ChannelAText.Name = "ChannelAText"
        Me.ChannelAText.Size = New System.Drawing.Size(104, 19)
        Me.ChannelAText.TabIndex = 0
        '
        'ChannelBText
        '
        Me.ChannelBText.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChannelBText.Location = New System.Drawing.Point(104, 59)
        Me.ChannelBText.Name = "ChannelBText"
        Me.ChannelBText.ReadOnly = True
        Me.ChannelBText.Size = New System.Drawing.Size(104, 19)
        Me.ChannelBText.TabIndex = 1
        '
        'SetPointText
        '
        Me.SetPointText.Location = New System.Drawing.Point(104, 160)
        Me.SetPointText.Name = "SetPointText"
        Me.SetPointText.Size = New System.Drawing.Size(104, 19)
        Me.SetPointText.TabIndex = 2
        '
        'RampText
        '
        Me.RampText.Location = New System.Drawing.Point(104, 288)
        Me.RampText.Name = "RampText"
        Me.RampText.Size = New System.Drawing.Size(104, 19)
        Me.RampText.TabIndex = 3
        '
        'ComText
        '
        Me.ComText.Location = New System.Drawing.Point(104, 457)
        Me.ComText.Name = "ComText"
        Me.ComText.Size = New System.Drawing.Size(199, 19)
        Me.ComText.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(104, 200)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 20)
        Me.ComboBox1.TabIndex = 5
        '
        'PowerText
        '
        Me.PowerText.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PowerText.Location = New System.Drawing.Point(104, 95)
        Me.PowerText.Name = "PowerText"
        Me.PowerText.ReadOnly = True
        Me.PowerText.Size = New System.Drawing.Size(104, 19)
        Me.PowerText.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ChannelA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ChannelB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 12)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Power"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 12)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "SetPoint"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 12)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Heater Range"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 12)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Ramp Rate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 461)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 12)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "その他コマンド"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(211, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 12)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "K"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(211, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 12)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "K"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(211, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 12)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "％"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(211, 292)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 12)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "K/min"
        '
        'SP_Button
        '
        Me.SP_Button.Location = New System.Drawing.Point(219, 158)
        Me.SP_Button.Name = "SP_Button"
        Me.SP_Button.Size = New System.Drawing.Size(44, 23)
        Me.SP_Button.TabIndex = 18
        Me.SP_Button.Text = "Set"
        Me.SP_Button.UseVisualStyleBackColor = True
        '
        'HR_Button
        '
        Me.HR_Button.Location = New System.Drawing.Point(219, 198)
        Me.HR_Button.Name = "HR_Button"
        Me.HR_Button.Size = New System.Drawing.Size(44, 23)
        Me.HR_Button.TabIndex = 19
        Me.HR_Button.Text = "Set"
        Me.HR_Button.UseVisualStyleBackColor = True
        '
        'RR_Button
        '
        Me.RR_Button.Location = New System.Drawing.Point(253, 286)
        Me.RR_Button.Name = "RR_Button"
        Me.RR_Button.Size = New System.Drawing.Size(44, 23)
        Me.RR_Button.TabIndex = 20
        Me.RR_Button.Text = "Set"
        Me.RR_Button.UseVisualStyleBackColor = True
        '
        'ComSend
        '
        Me.ComSend.Location = New System.Drawing.Point(309, 455)
        Me.ComSend.Name = "ComSend"
        Me.ComSend.Size = New System.Drawing.Size(44, 23)
        Me.ComSend.TabIndex = 21
        Me.ComSend.Text = "Send"
        Me.ComSend.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Graph_button
        '
        Me.Graph_button.Location = New System.Drawing.Point(265, 34)
        Me.Graph_button.Name = "Graph_button"
        Me.Graph_button.Size = New System.Drawing.Size(70, 33)
        Me.Graph_button.TabIndex = 22
        Me.Graph_button.Text = "グラフ"
        Me.Graph_button.UseVisualStyleBackColor = True
        '
        'reload
        '
        Me.reload.Location = New System.Drawing.Point(452, 394)
        Me.reload.Name = "reload"
        Me.reload.Size = New System.Drawing.Size(65, 26)
        Me.reload.TabIndex = 23
        Me.reload.Text = "表示更新"
        Me.reload.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(267, 81)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 16)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "温度データ保存"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBoxControlType
        '
        Me.ComboBoxControlType.FormattingEnabled = True
        Me.ComboBoxControlType.Location = New System.Drawing.Point(104, 243)
        Me.ComboBoxControlType.Name = "ComboBoxControlType"
        Me.ComboBoxControlType.Size = New System.Drawing.Size(104, 20)
        Me.ComboBoxControlType.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 247)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 12)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Control Type"
        '
        'ControlTypeButton
        '
        Me.ControlTypeButton.Location = New System.Drawing.Point(219, 240)
        Me.ControlTypeButton.Name = "ControlTypeButton"
        Me.ControlTypeButton.Size = New System.Drawing.Size(44, 23)
        Me.ControlTypeButton.TabIndex = 27
        Me.ControlTypeButton.Text = "Set"
        Me.ControlTypeButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(72, 325)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 12)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "PID"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(60, 348)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 12)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "PGain"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(64, 374)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 12)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "IGain"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(59, 400)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 12)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "DGain"
        '
        'PTextBox
        '
        Me.PTextBox.HidePromptOnLeave = True
        Me.PTextBox.Location = New System.Drawing.Point(104, 345)
        Me.PTextBox.Name = "PTextBox"
        Me.PTextBox.Size = New System.Drawing.Size(104, 19)
        Me.PTextBox.TabIndex = 32
        '
        'ITextBox
        '
        Me.ITextBox.Location = New System.Drawing.Point(104, 370)
        Me.ITextBox.Name = "ITextBox"
        Me.ITextBox.Size = New System.Drawing.Size(104, 19)
        Me.ITextBox.TabIndex = 34
        '
        'DTextBox
        '
        Me.DTextBox.Location = New System.Drawing.Point(104, 396)
        Me.DTextBox.Name = "DTextBox"
        Me.DTextBox.Size = New System.Drawing.Size(104, 19)
        Me.DTextBox.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(213, 374)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 12)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "sec"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(213, 400)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(23, 12)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "sec"
        '
        'PButton
        '
        Me.PButton.Location = New System.Drawing.Point(219, 343)
        Me.PButton.Name = "PButton"
        Me.PButton.Size = New System.Drawing.Size(44, 23)
        Me.PButton.TabIndex = 38
        Me.PButton.Text = "Set"
        Me.PButton.UseVisualStyleBackColor = True
        '
        'IButton
        '
        Me.IButton.Location = New System.Drawing.Point(247, 369)
        Me.IButton.Name = "IButton"
        Me.IButton.Size = New System.Drawing.Size(44, 23)
        Me.IButton.TabIndex = 39
        Me.IButton.Text = "Set"
        Me.IButton.UseVisualStyleBackColor = True
        '
        'DButton
        '
        Me.DButton.Location = New System.Drawing.Point(247, 396)
        Me.DButton.Name = "DButton"
        Me.DButton.Size = New System.Drawing.Size(44, 23)
        Me.DButton.TabIndex = 40
        Me.DButton.Text = "Set"
        Me.DButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 513)
        Me.Controls.Add(Me.DButton)
        Me.Controls.Add(Me.IButton)
        Me.Controls.Add(Me.PButton)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DTextBox)
        Me.Controls.Add(Me.ITextBox)
        Me.Controls.Add(Me.PTextBox)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
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
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PTextBox As MaskedTextBox
    Friend WithEvents ITextBox As MaskedTextBox
    Friend WithEvents DTextBox As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PButton As Button
    Friend WithEvents IButton As Button
    Friend WithEvents DButton As Button
End Class
