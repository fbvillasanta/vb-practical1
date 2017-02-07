<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_factor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.factor_input = New System.Windows.Forms.TextBox()
        Me.factor_generate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.factor_list = New System.Windows.Forms.ListBox()
        Me.factor_label_invalid = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number:"
        '
        'factor_input
        '
        Me.factor_input.Location = New System.Drawing.Point(93, 35)
        Me.factor_input.MaxLength = 4
        Me.factor_input.Name = "factor_input"
        Me.factor_input.Size = New System.Drawing.Size(174, 20)
        Me.factor_input.TabIndex = 1
        '
        'factor_generate
        '
        Me.factor_generate.Location = New System.Drawing.Point(75, 86)
        Me.factor_generate.Name = "factor_generate"
        Me.factor_generate.Size = New System.Drawing.Size(143, 29)
        Me.factor_generate.TabIndex = 2
        Me.factor_generate.Text = "Generate factors!"
        Me.factor_generate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Factors:"
        '
        'factor_list
        '
        Me.factor_list.FormattingEnabled = True
        Me.factor_list.Location = New System.Drawing.Point(42, 151)
        Me.factor_list.Name = "factor_list"
        Me.factor_list.Size = New System.Drawing.Size(207, 82)
        Me.factor_list.TabIndex = 4
        '
        'factor_label_invalid
        '
        Me.factor_label_invalid.AutoSize = True
        Me.factor_label_invalid.Location = New System.Drawing.Point(142, 58)
        Me.factor_label_invalid.Name = "factor_label_invalid"
        Me.factor_label_invalid.Size = New System.Drawing.Size(67, 13)
        Me.factor_label_invalid.TabIndex = 5
        Me.factor_label_invalid.Text = "Invalid input!"
        '
        'form_factor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.factor_label_invalid)
        Me.Controls.Add(Me.factor_list)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.factor_generate)
        Me.Controls.Add(Me.factor_input)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form_factor"
        Me.Text = "Factor of a Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents factor_input As System.Windows.Forms.TextBox
    Friend WithEvents factor_generate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents factor_list As System.Windows.Forms.ListBox
    Friend WithEvents factor_label_invalid As System.Windows.Forms.Label
End Class
