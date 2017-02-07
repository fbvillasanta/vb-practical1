<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_area
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_circle = New System.Windows.Forms.TabPage()
        Me.radio_diameter = New System.Windows.Forms.RadioButton()
        Me.radio_radius = New System.Windows.Forms.RadioButton()
        Me.circle_result = New System.Windows.Forms.Label()
        Me.circle_generate = New System.Windows.Forms.Button()
        Me.circle_invalid = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.circle_input = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_triangle = New System.Windows.Forms.TabPage()
        Me.tri_result = New System.Windows.Forms.Label()
        Me.tri_generate = New System.Windows.Forms.Button()
        Me.tri_invalid = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tri_height = New System.Windows.Forms.TextBox()
        Me.tri_base = New System.Windows.Forms.TextBox()
        Me.height_label = New System.Windows.Forms.Label()
        Me.base_label = New System.Windows.Forms.Label()
        Me.tab_square = New System.Windows.Forms.TabPage()
        Me.square_result = New System.Windows.Forms.Label()
        Me.square_generate = New System.Windows.Forms.Button()
        Me.square_invalid = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.square_input = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tab_circle.SuspendLayout()
        Me.tab_triangle.SuspendLayout()
        Me.tab_square.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_circle)
        Me.TabControl1.Controls.Add(Me.tab_triangle)
        Me.TabControl1.Controls.Add(Me.tab_square)
        Me.TabControl1.Location = New System.Drawing.Point(7, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(274, 241)
        Me.TabControl1.TabIndex = 0
        '
        'tab_circle
        '
        Me.tab_circle.Controls.Add(Me.radio_diameter)
        Me.tab_circle.Controls.Add(Me.radio_radius)
        Me.tab_circle.Controls.Add(Me.circle_result)
        Me.tab_circle.Controls.Add(Me.circle_generate)
        Me.tab_circle.Controls.Add(Me.circle_invalid)
        Me.tab_circle.Controls.Add(Me.Label2)
        Me.tab_circle.Controls.Add(Me.circle_input)
        Me.tab_circle.Controls.Add(Me.Label1)
        Me.tab_circle.Location = New System.Drawing.Point(4, 22)
        Me.tab_circle.Name = "tab_circle"
        Me.tab_circle.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_circle.Size = New System.Drawing.Size(266, 215)
        Me.tab_circle.TabIndex = 0
        Me.tab_circle.Text = "Circle"
        Me.tab_circle.UseVisualStyleBackColor = True
        '
        'radio_diameter
        '
        Me.radio_diameter.AutoSize = True
        Me.radio_diameter.Location = New System.Drawing.Point(139, 21)
        Me.radio_diameter.Name = "radio_diameter"
        Me.radio_diameter.Size = New System.Drawing.Size(67, 17)
        Me.radio_diameter.TabIndex = 7
        Me.radio_diameter.Text = "Diameter"
        Me.radio_diameter.UseVisualStyleBackColor = True
        '
        'radio_radius
        '
        Me.radio_radius.AutoSize = True
        Me.radio_radius.Checked = True
        Me.radio_radius.Location = New System.Drawing.Point(65, 21)
        Me.radio_radius.Name = "radio_radius"
        Me.radio_radius.Size = New System.Drawing.Size(58, 17)
        Me.radio_radius.TabIndex = 6
        Me.radio_radius.TabStop = True
        Me.radio_radius.Text = "Radius"
        Me.radio_radius.UseVisualStyleBackColor = True
        '
        'circle_result
        '
        Me.circle_result.AutoSize = True
        Me.circle_result.Location = New System.Drawing.Point(14, 175)
        Me.circle_result.Name = "circle_result"
        Me.circle_result.Size = New System.Drawing.Size(101, 13)
        Me.circle_result.TabIndex = 5
        Me.circle_result.Text = "The circle's area is: "
        '
        'circle_generate
        '
        Me.circle_generate.Location = New System.Drawing.Point(81, 114)
        Me.circle_generate.Name = "circle_generate"
        Me.circle_generate.Size = New System.Drawing.Size(122, 34)
        Me.circle_generate.TabIndex = 4
        Me.circle_generate.Text = "Generate area!"
        Me.circle_generate.UseVisualStyleBackColor = True
        '
        'circle_invalid
        '
        Me.circle_invalid.AutoSize = True
        Me.circle_invalid.Location = New System.Drawing.Point(107, 79)
        Me.circle_invalid.Name = "circle_invalid"
        Me.circle_invalid.Size = New System.Drawing.Size(67, 13)
        Me.circle_invalid.TabIndex = 3
        Me.circle_invalid.Text = "Invalid input!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "units"
        '
        'circle_input
        '
        Me.circle_input.Location = New System.Drawing.Point(82, 56)
        Me.circle_input.Name = "circle_input"
        Me.circle_input.Size = New System.Drawing.Size(121, 20)
        Me.circle_input.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dimension: "
        '
        'tab_triangle
        '
        Me.tab_triangle.Controls.Add(Me.tri_result)
        Me.tab_triangle.Controls.Add(Me.tri_generate)
        Me.tab_triangle.Controls.Add(Me.tri_invalid)
        Me.tab_triangle.Controls.Add(Me.Label6)
        Me.tab_triangle.Controls.Add(Me.Label5)
        Me.tab_triangle.Controls.Add(Me.tri_height)
        Me.tab_triangle.Controls.Add(Me.tri_base)
        Me.tab_triangle.Controls.Add(Me.height_label)
        Me.tab_triangle.Controls.Add(Me.base_label)
        Me.tab_triangle.Location = New System.Drawing.Point(4, 22)
        Me.tab_triangle.Name = "tab_triangle"
        Me.tab_triangle.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_triangle.Size = New System.Drawing.Size(266, 215)
        Me.tab_triangle.TabIndex = 1
        Me.tab_triangle.Text = "Triangle"
        Me.tab_triangle.UseVisualStyleBackColor = True
        '
        'tri_result
        '
        Me.tri_result.AutoSize = True
        Me.tri_result.Location = New System.Drawing.Point(40, 176)
        Me.tri_result.Name = "tri_result"
        Me.tri_result.Size = New System.Drawing.Size(39, 13)
        Me.tri_result.TabIndex = 8
        Me.tri_result.Text = "Label8"
        '
        'tri_generate
        '
        Me.tri_generate.Location = New System.Drawing.Point(68, 109)
        Me.tri_generate.Name = "tri_generate"
        Me.tri_generate.Size = New System.Drawing.Size(124, 42)
        Me.tri_generate.TabIndex = 7
        Me.tri_generate.Text = "Generate area!"
        Me.tri_generate.UseVisualStyleBackColor = True
        '
        'tri_invalid
        '
        Me.tri_invalid.AutoSize = True
        Me.tri_invalid.Location = New System.Drawing.Point(53, 89)
        Me.tri_invalid.Name = "tri_invalid"
        Me.tri_invalid.Size = New System.Drawing.Size(148, 13)
        Me.tri_invalid.TabIndex = 6
        Me.tri_invalid.Text = "One or both inputs are invalid!"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(203, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "units"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "units"
        '
        'tri_height
        '
        Me.tri_height.Location = New System.Drawing.Point(71, 52)
        Me.tri_height.Name = "tri_height"
        Me.tri_height.Size = New System.Drawing.Size(114, 20)
        Me.tri_height.TabIndex = 3
        '
        'tri_base
        '
        Me.tri_base.Location = New System.Drawing.Point(71, 19)
        Me.tri_base.Name = "tri_base"
        Me.tri_base.Size = New System.Drawing.Size(114, 20)
        Me.tri_base.TabIndex = 2
        '
        'height_label
        '
        Me.height_label.AutoSize = True
        Me.height_label.Location = New System.Drawing.Point(16, 56)
        Me.height_label.Name = "height_label"
        Me.height_label.Size = New System.Drawing.Size(38, 13)
        Me.height_label.TabIndex = 1
        Me.height_label.Text = "Height"
        '
        'base_label
        '
        Me.base_label.AutoSize = True
        Me.base_label.Location = New System.Drawing.Point(16, 23)
        Me.base_label.Name = "base_label"
        Me.base_label.Size = New System.Drawing.Size(31, 13)
        Me.base_label.TabIndex = 0
        Me.base_label.Text = "Base"
        '
        'tab_square
        '
        Me.tab_square.Controls.Add(Me.square_result)
        Me.tab_square.Controls.Add(Me.square_generate)
        Me.tab_square.Controls.Add(Me.square_invalid)
        Me.tab_square.Controls.Add(Me.Label7)
        Me.tab_square.Controls.Add(Me.square_input)
        Me.tab_square.Controls.Add(Me.Label9)
        Me.tab_square.Location = New System.Drawing.Point(4, 22)
        Me.tab_square.Name = "tab_square"
        Me.tab_square.Size = New System.Drawing.Size(266, 215)
        Me.tab_square.TabIndex = 2
        Me.tab_square.Text = "Square"
        Me.tab_square.UseVisualStyleBackColor = True
        '
        'square_result
        '
        Me.square_result.AutoSize = True
        Me.square_result.Location = New System.Drawing.Point(47, 176)
        Me.square_result.Name = "square_result"
        Me.square_result.Size = New System.Drawing.Size(39, 13)
        Me.square_result.TabIndex = 17
        Me.square_result.Text = "Label8"
        '
        'square_generate
        '
        Me.square_generate.Location = New System.Drawing.Point(70, 99)
        Me.square_generate.Name = "square_generate"
        Me.square_generate.Size = New System.Drawing.Size(124, 51)
        Me.square_generate.TabIndex = 16
        Me.square_generate.Text = "Generate area!"
        Me.square_generate.UseVisualStyleBackColor = True
        '
        'square_invalid
        '
        Me.square_invalid.AutoSize = True
        Me.square_invalid.Location = New System.Drawing.Point(104, 69)
        Me.square_invalid.Name = "square_invalid"
        Me.square_invalid.Size = New System.Drawing.Size(67, 13)
        Me.square_invalid.TabIndex = 15
        Me.square_invalid.Text = "Invalid input!"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(212, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "units"
        '
        'square_input
        '
        Me.square_input.Location = New System.Drawing.Point(80, 34)
        Me.square_input.Name = "square_input"
        Me.square_input.Size = New System.Drawing.Size(114, 20)
        Me.square_input.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Dimension"
        '
        'form_area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "form_area"
        Me.Text = "Area"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_circle.ResumeLayout(False)
        Me.tab_circle.PerformLayout()
        Me.tab_triangle.ResumeLayout(False)
        Me.tab_triangle.PerformLayout()
        Me.tab_square.ResumeLayout(False)
        Me.tab_square.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_circle As System.Windows.Forms.TabPage
    Friend WithEvents tab_triangle As System.Windows.Forms.TabPage
    Friend WithEvents circle_generate As System.Windows.Forms.Button
    Friend WithEvents circle_invalid As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents circle_input As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tab_square As System.Windows.Forms.TabPage
    Friend WithEvents radio_diameter As System.Windows.Forms.RadioButton
    Friend WithEvents radio_radius As System.Windows.Forms.RadioButton
    Friend WithEvents circle_result As System.Windows.Forms.Label
    Friend WithEvents tri_result As System.Windows.Forms.Label
    Friend WithEvents tri_generate As System.Windows.Forms.Button
    Friend WithEvents tri_invalid As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tri_height As System.Windows.Forms.TextBox
    Friend WithEvents tri_base As System.Windows.Forms.TextBox
    Friend WithEvents height_label As System.Windows.Forms.Label
    Friend WithEvents base_label As System.Windows.Forms.Label
    Friend WithEvents square_result As System.Windows.Forms.Label
    Friend WithEvents square_generate As System.Windows.Forms.Button
    Friend WithEvents square_invalid As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents square_input As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
