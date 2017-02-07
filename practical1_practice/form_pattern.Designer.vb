<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_pattern
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
        Me.input = New System.Windows.Forms.NumericUpDown()
        Me.output = New System.Windows.Forms.TextBox()
        Me.generate = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        CType(Me.input, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dimension"
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(90, 14)
        Me.input.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.input.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(59, 20)
        Me.input.TabIndex = 1
        Me.input.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'output
        '
        Me.output.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output.Location = New System.Drawing.Point(26, 49)
        Me.output.Multiline = True
        Me.output.Name = "output"
        Me.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.output.Size = New System.Drawing.Size(233, 177)
        Me.output.TabIndex = 2
        '
        'generate
        '
        Me.generate.Location = New System.Drawing.Point(174, 12)
        Me.generate.Name = "generate"
        Me.generate.Size = New System.Drawing.Size(97, 21)
        Me.generate.TabIndex = 3
        Me.generate.Text = "Generate!"
        Me.generate.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(90, 232)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(97, 21)
        Me.clear.TabIndex = 4
        Me.clear.Text = "Clear!"
        Me.clear.UseVisualStyleBackColor = True
        '
        'form_pattern
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.generate)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form_pattern"
        Me.Text = "Simple Pattern"
        CType(Me.input, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents input As System.Windows.Forms.NumericUpDown
    Friend WithEvents output As System.Windows.Forms.TextBox
    Friend WithEvents generate As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
End Class
