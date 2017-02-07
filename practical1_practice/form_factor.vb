Public Class form_factor
    Dim number As Integer = 0
    Private Sub factor_input_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles factor_input.KeyPress
        If factor_input.Text.Length > 9 Then
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

    Private Sub factor_generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles factor_generate.Click
        factor_list.Items.Clear()
        If Not IsNumeric(factor_input.Text) Then
            factor_label_invalid.Text = "Invalid input!"
        ElseIf factor_input.Text.Contains(".") Then
            'factor_label_invalid.Text = factor_input.Text.IndexOf(".") & " " & factor_input.Text.Length
            'For i = factor_input.Text.IndexOf(".") + 1 To factor_input.Text.Length - 1
            '   If GetChar(factor_input.Text, i) <> "0" Then
            '       factor_label_invalid.Text = i
            '  End If
            'Next
            factor_label_invalid.Text = "Invalid input!"
        ElseIf CInt(factor_input.Text) = 0 Then
            factor_label_invalid.Text = "Invalid input!"
        Else
            factor_label_invalid.Text = ""
            number = factor_input.Text
            For i = 1 To number
                If number Mod i = 0 Then
                    factor_list.Items.Add(i & " , " & -i)
                End If
            Next
        End If
    End Sub

    Private Sub form_factor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        factor_list.Items.Clear()
        factor_label_invalid.Text = ""
    End Sub
End Class