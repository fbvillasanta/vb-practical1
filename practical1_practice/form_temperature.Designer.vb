<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_temperature
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.radio_celcius = New System.Windows.Forms.RadioButton()
        Me.radio_fahrenheit = New System.Windows.Forms.RadioButton()
        Me.radio_kelvin = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.celcius_input = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fahrenheit_input = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.kelvin_input = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.input_invalid = New System.Windows.Forms.Label()
        Me.convert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'radio_celcius
        '
        Me.radio_celcius.AutoSize = True
        Me.radio_celcius.Checked = True
        Me.radio_celcius.Location = New System.Drawing.Point(26, 34)
        Me.radio_celcius.Name = "radio_celcius"
        Me.radio_celcius.Size = New System.Drawing.Size(59, 17)
        Me.radio_celcius.TabIndex = 0
        Me.radio_celcius.TabStop = True
        Me.radio_celcius.Text = "Celcius"
        Me.radio_celcius.UseVisualStyleBackColor = True
        '
        'radio_fahrenheit
        '
        Me.radio_fahrenheit.AutoSize = True
        Me.radio_fahrenheit.Location = New System.Drawing.Point(112, 34)
        Me.radio_fahrenheit.Name = "radio_fahrenheit"
        Me.radio_fahrenheit.Size = New System.Drawing.Size(75, 17)
        Me.radio_fahrenheit.TabIndex = 1
        Me.radio_fahrenheit.Text = "Fahrenheit"
        Me.radio_fahrenheit.UseVisualStyleBackColor = True
        '
        'radio_kelvin
        '
        Me.radio_kelvin.AutoSize = True
        Me.radio_kelvin.Location = New System.Drawing.Point(208, 34)
        Me.radio_kelvin.Name = "radio_kelvin"
        Me.radio_kelvin.Size = New System.Drawing.Size(54, 17)
        Me.radio_kelvin.TabIndex = 2
        Me.radio_kelvin.Text = "Kelvin"
        Me.radio_kelvin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Celcius"
        '
        'celcius_input
        '
        Me.celcius_input.Location = New System.Drawing.Point(91, 89)
        Me.celcius_input.Name = "celcius_input"
        Me.celcius_input.Size = New System.Drawing.Size(126, 20)
        Me.celcius_input.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "C"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "F"
        '
        'fahrenheit_input
        '
        Me.fahrenheit_input.Location = New System.Drawing.Point(91, 115)
        Me.fahrenheit_input.Name = "fahrenheit_input"
        Me.fahrenheit_input.Size = New System.Drawing.Size(126, 20)
        Me.fahrenheit_input.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fahrenheit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "K"
        '
        'kelvin_input
        '
        Me.kelvin_input.Location = New System.Drawing.Point(91, 141)
        Me.kelvin_input.Name = "kelvin_input"
        Me.kelvin_input.Size = New System.Drawing.Size(126, 20)
        Me.kelvin_input.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Kelvin"
        '
        'input_invalid
        '
        Me.input_invalid.AutoSize = True
        Me.input_invalid.Location = New System.Drawing.Point(109, 173)
        Me.input_invalid.Name = "input_invalid"
        Me.input_invalid.Size = New System.Drawing.Size(67, 13)
        Me.input_invalid.TabIndex = 12
        Me.input_invalid.Text = "Invalid input!"
        '
        'convert
        '
        Me.convert.Location = New System.Drawing.Point(69, 198)
        Me.convert.Name = "convert"
        Me.convert.Size = New System.Drawing.Size(148, 35)
        Me.convert.TabIndex = 13
        Me.convert.Text = "Convert!"
        Me.convert.UseVisualStyleBackColor = True
        '
        'form_temperature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.convert)
        Me.Controls.Add(Me.input_invalid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.kelvin_input)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fahrenheit_input)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.celcius_input)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radio_kelvin)
        Me.Controls.Add(Me.radio_fahrenheit)
        Me.Controls.Add(Me.radio_celcius)
        Me.Name = "form_temperature"
        Me.Text = "Temperature Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radio_celcius As System.Windows.Forms.RadioButton
    Friend WithEvents radio_fahrenheit As System.Windows.Forms.RadioButton
    Friend WithEvents radio_kelvin As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents celcius_input As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fahrenheit_input As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents kelvin_input As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents input_invalid As System.Windows.Forms.Label
    Friend WithEvents convert As System.Windows.Forms.Button
End Class
