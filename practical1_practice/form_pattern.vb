Public Class form_pattern
    Dim n As Integer
    Dim counter As Integer
    Dim pattern As Integer
    Dim out As String = ""

    Private Sub generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generate.Click
        n = input.Text
        out = ""
        Randomize()
        pattern = Int(Rnd() * 10) + 1

        Select Case pattern
            Case 1
                output.AppendText(Environment.NewLine)
                output.AppendText("Pattern 1" & Environment.NewLine)
                For r = 1 To n
                    For c = 1 To n
                        out += "*"
                    Next
                    output.AppendText(out & Environment.NewLine)
                    out = ""
                Next
            Case 2
                output.AppendText(Environment.NewLine)
                output.AppendText("Pattern 2" & Environment.NewLine)
                For r = 1 To n
                    For c = 1 To n
                        If r <> c Then
                            out += "*"
                        Else
                            out += "-"
                        End If
                    Next
                    output.AppendText(out & Environment.NewLine)
                    out = ""
                Next
            Case 3
                output.AppendText(Environment.NewLine)
                output.AppendText("Pattern 3" & Environment.NewLine)
                For r = n To 1 Step -1
                    For c = 1 To n
                        If c <> r Then
                            out += "*"
                        Else
                            out += "-"
                        End If
                    Next
                    output.AppendText(out & Environment.NewLine)
                    out = ""
                Next
            Case 4
                output.AppendText(Environment.NewLine)
                output.AppendText("Pattern 4" & Environment.NewLine)
                For r = 1 To n
                    For c = 1 To n
                        If c Mod 2 = 1 Then
                            out += "*"
                        Else
                            out += "-"
                        End If
                    Next
                    output.AppendText(out & Environment.NewLine)
                    out = ""
                Next
            Case 5
                output.AppendText(Environment.NewLine)
                output.AppendText("Pattern 5" & Environment.NewLine)
                For r = 1 To n
                    For c = 1 To n
                        If r Mod 2 = 1 Then
                            out += "*"
                        Else
                            out += "-"
                        End If
                    Next
                    output.AppendText(out & Environment.NewLine)
                    out = ""
                Next
            Case 6
                output.AppendText(Environment.NewLine)
                output.AppendText("Pattern 6" & Environment.NewLine)
                For r = 1 To n
                    For c = 1 To n
                        If r Mod 2 = 1 Then
                            If c Mod 2 = 1 Then
                                out += "*"
                            Else
                                out += "-"
                            End If
                        Else
                            If c Mod 2 = 0 Then
                                out += "*"
                            Else
                                out += "-"
                            End If
                        End If
                    Next
                    output.AppendText(out & Environment.NewLine)
                    out = ""
                Next
            Case 7
                output.AppendText(Environment.NewLine)
                output.AppendText("Pattern 7" & Environment.NewLine)
                For r = 1 To n
                    For c = 1 To n
                        If r = 1 Or r = n Or c = 1 Or c = n Then
                            out += "*"
                        Else
                            out += "-"
                        End If
                    Next
                    output.AppendText(out & Environment.NewLine)
                    out = ""
                Next
            Case 8
                output.AppendText(Environment.NewLine)
                output.AppendText("Pattern 8" & Environment.NewLine)
                For r = 1 To n
                    For c = 1 To n
                        If c <= r Then
                            out = out & r
                        Else
                            out += "*"
                        End If
                    Next
                    output.AppendText(out & Environment.NewLine)
                    out = ""
                Next
            Case 9
                output.AppendText(Environment.NewLine)
                output.AppendText("Pattern 9" & Environment.NewLine)
                counter = n
                For r = n To 1 Step -1
                    For c = 1 To n
                        If c <= counter Then
                            out = out & counter
                        Else
                            out += "*"
                        End If
                    Next
                    output.AppendText(out & Environment.NewLine)
                    out = ""
                    counter -= 1
                Next
            Case 10
                output.AppendText(Environment.NewLine)
                output.AppendText("Pattern 10" & Environment.NewLine)
                counter = n
                For r = 1 To n
                    For c = 1 To n
                        If c = r Or c = counter Then
                            out += "*"
                        Else
                            out += "-"
                        End If
                    Next
                    output.AppendText(out & Environment.NewLine)
                    out = ""
                    counter -= 1
                Next
        End Select
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        output.Clear()
    End Sub
End Class