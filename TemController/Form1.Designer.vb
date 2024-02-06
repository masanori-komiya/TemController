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
        Me.RampText.Location = New System.Drawing.Point(104, 269)
        Me.RampText.Name = "RampText"
        Me.RampText.Size = New System.Drawing.Size(104, 19)
        Me.RampText.TabIndex = 3
        '
        'ComText
        '
        Me.ComText.Location = New System.Drawing.Point(104, 311)
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
        Me.Label6.Location = New System.Drawing.Point(36, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 12)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Ramp Rate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 316)
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
        Me.Label11.Location = New System.Drawing.Point(211, 274)
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
        Me.RR_Button.Location = New System.Drawing.Point(253, 267)
        Me.RR_Button.Name = "RR_Button"
        Me.RR_Button.Size = New System.Drawing.Size(44, 23)
        Me.RR_Button.TabIndex = 20
        Me.RR_Button.Text = "Set"
        Me.RR_Button.UseVisualStyleBackColor = True
        '
        'ComSend
        '
        Me.ComSend.Location = New System.Drawing.Point(310, 310)
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
        Me.reload.Location = New System.Drawing.Point(390, 217)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 373)
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
End Class
