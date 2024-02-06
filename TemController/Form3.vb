Imports System.Windows
Imports System.Windows.Forms.DataVisualization.Charting
Imports TemController.Form2
Public Class Form3
    Private _form2 As Form2
    Public Sub New(form2 As Form2)
        ' Store the reference to Form2
        _form2 = form2
        InitializeComponent()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaxText.Text = _form2.Max
        Me.MinText.Text = _form2.Min
    End Sub
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim max As Double
        Dim min As Double
        If Double.TryParse(Me.MaxText.Text, max) AndAlso Double.TryParse(Me.MinText.Text, min) Then
            If max > min Then
                ' Conversion successful, update Form2 properties
                _form2.Max = max
                _form2.Min = min
                _form2.UpdateGraphScale()
                Me.Close()
            Else
                MessageBox.Show("最大・最小が逆ダロ")
            End If
        Else
            ' Handle the case where conversion fails (invalid input)
            MessageBox.Show("Invalid input. Please enter valid numeric values for Max and Min.")
        End If
    End Sub
End Class