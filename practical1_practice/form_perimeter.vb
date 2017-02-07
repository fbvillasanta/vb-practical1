Public Class form_perimeter
    Dim circlePeri As Decimal
    Dim circleDimension As Decimal
    Dim triPeri As Decimal
    Dim triSide1 As Decimal
    Dim triSide2 As Decimal
    Dim triSide3 As Decimal
    Dim squarePeri As Decimal
    Dim squareDimension As Decimal

    Private Sub form_perimeter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        circle_invalid.Text = ""
        circle_result.Text = ""
        tri_invalid.Text = ""
        tri_result.Text = ""
        square_invalid.Text = ""
        square_result.Text = ""
    End Sub

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
        circle_invalid.Text = ""
        circle_result.Text = ""
        If Not IsNumeric(circle_input.Text) Then
            circle_invalid.Text = "Invalid input!"
            circle_input.Clear()
        ElseIf CDec(circle_input.Text) <= 0 Then
            circle_invalid.Text = "Invalid input!"
            circle_input.Clear()
        ElseIf radio_radius.Checked Then
            circleDimension = circle_input.Text
            circlePeri = 2 * Math.PI * circleDimension
            circle_result.Text = "Circumference: " & circlePeri & " units"
        ElseIf radio_diameter.Checked Then
            circleDimension = circle_input.Text
            circlePeri = Math.PI * circleDimension
            circle_result.Text = "Circumference: " & circlePeri & " units"
        End If
    End Sub

    Private Sub tri_side1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tri_side1.KeyPress
        If tri_side1.Text.Length > 9 Then
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

    Private Sub tri_side2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tri_side2.KeyPress
        If tri_side2.Text.Length > 9 Then
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

    Private Sub tri_side3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tri_side3.KeyPress
        If tri_side3.Text.Length > 9 Then
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

    Private Sub tri_generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tri_generate.Click
        tri_invalid.Text = ""
        tri_result.Text = ""
        If Not IsNumeric(tri_side1.Text) Or Not IsNumeric(tri_side2.Text) Or Not IsNumeric(tri_side3.Text) Then
            tri_invalid.Text = "One or more inputs are invalid!"
        ElseIf CDec(tri_side1.Text) <= 0 Or CDec(tri_side2.Text) <= 0 Or CDec(tri_side3.Text) <= 0 Then
            tri_invalid.Text = "One or more inputs are invalid!"
        Else
            triSide1 = tri_side1.Text
            triSide2 = tri_side2.Text
            triSide3 = tri_side3.Text
            triPeri = triSide1 + triSide2 + triSide3
            tri_result.Text = "Perimeter: " & triPeri & " units"
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
            squarePeri = squareDimension * 4
            square_result.Text = "Perimeter: " & squarePeri & " units"
        End If
    End Sub
End Class