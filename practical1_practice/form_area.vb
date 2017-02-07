Public Class form_area
    Dim circleArea As Decimal
    Dim circleDimension As Decimal
    Dim triArea As Decimal
    Dim triBase As Decimal
    Dim triHeight As Decimal
    Dim squareDimension As Decimal
    Dim squareArea As Decimal

    Private Sub circle_input_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles circle_input.KeyPress
        If circle_input.Text.Length > 9 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 47 Then
                e.Handled = True
            End If
        End If
        'Disables Alphabetic Letters And Special Characters In TextBox
    End Sub

    Private Sub circle_generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles circle_generate.Click
        circle_result.Text = ""
        circle_invalid.Text = ""
        If Not IsNumeric(circle_input.Text) Then
            circle_invalid.Text = "Invalid input!"
            circle_input.Clear()
        ElseIf CDec(circle_input.Text) <= 0 Then
            circle_invalid.Text = "Invalid input!"
            circle_input.Clear()
        ElseIf radio_radius.Checked Then
            circleDimension = circle_input.Text
            circleArea = (circleDimension ^ 2) * Math.PI
            circle_result.Text = "Area: " & circleArea & " sq. units"
        ElseIf radio_diameter.Checked Then
            circleDimension = circle_input.Text
            circleArea = ((circleDimension / 2) ^ 2) * Math.PI
            circle_result.Text = "Area: " & circleArea & " sq. units"
        End If
    End Sub

    Private Sub form_area_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        circle_invalid.Text = ""
        circle_result.Text = ""
        tri_invalid.Text = ""
        tri_result.Text = ""
        square_invalid.Text = ""
        square_result.Text = ""
    End Sub

    Private Sub tri_base_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tri_base.KeyPress
        If tri_base.Text.Length > 9 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 47 Then
                e.Handled = True
            End If
        End If
        'Disables Alphabetic Letters And Special Characters In TextBox
    End Sub

    Private Sub tri_height_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tri_height.KeyPress
        If tri_height.Text.Length > 9 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 47 Then
                e.Handled = True
            End If
        End If
        'Disables Alphabetic Letters And Special Characters In TextBox
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tri_generate.Click
        tri_invalid.Text = ""
        tri_result.Text = ""
        If Not IsNumeric(tri_base.Text) Or Not IsNumeric(tri_height.Text) Then
            tri_invalid.Text = "One or both inputs are invalid!"
        ElseIf CDec(tri_base.Text) = 0 Or CDec(tri_height.Text) = 0 Then
            tri_invalid.Text = "One or both inputs are invalid!"
        Else
            triBase = tri_base.Text
            triHeight = tri_height.Text
            triArea = triBase * triHeight / 2
            tri_result.Text = "Area: " & triArea & " square unit/s"
        End If
    End Sub

    Private Sub square_input_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles square_input.KeyPress
        If square_input.Text.Length > 9 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 47 Then
                e.Handled = True
            End If
        End If
        'Disables Alphabetic Letters And Special Characters In TextBox
    End Sub

    Private Sub square_generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles square_generate.Click
        square_invalid.Text = ""
        square_result.Text = ""
        If Not IsNumeric(square_input.Text) Then
            square_invalid.Text = "Invalid input!"
            square_input.Clear()
        ElseIf CDec(square_input.Text) <= 0 Then
            square_invalid.Text = "Invalid input!"
            square_input.Clear()
        Else
            squareDimension = square_input.Text
            squareArea = squareDimension ^ 2
            square_result.Text = "Area: " & squareArea & " sq. unit/s"
        End If
    End Sub
End Class