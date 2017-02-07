Public Class form_temperature
    Dim celcius As Decimal
    Dim fahrenheit As Decimal
    Dim kelvin As Decimal

    Private Sub form_temperature_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        input_invalid.Text = ""
        fahrenheit_input.ReadOnly = True
        kelvin_input.ReadOnly = True
    End Sub

    Private Sub radio_celcius_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radio_celcius.CheckedChanged
        fahrenheit_input.Text = ""
        kelvin_input.Text = ""
        celcius_input.ReadOnly = False
        fahrenheit_input.ReadOnly = True
        kelvin_input.ReadOnly = True
        input_invalid.Text = ""
    End Sub

    Private Sub radio_fahrenheit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radio_fahrenheit.CheckedChanged
        celcius_input.Text = ""
        kelvin_input.Text = ""
        celcius_input.ReadOnly = True
        fahrenheit_input.ReadOnly = False
        kelvin_input.ReadOnly = True
        input_invalid.Text = ""
    End Sub

    Private Sub radio_kelvin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radio_kelvin.CheckedChanged
        celcius_input.Text = ""
        fahrenheit_input.Text = ""
        celcius_input.ReadOnly = True
        fahrenheit_input.ReadOnly = True
        kelvin_input.ReadOnly = False
        input_invalid.Text = ""
    End Sub

    Private Sub convert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convert.Click
        input_invalid.Text = ""
        If radio_celcius.Checked Then
            If Not IsNumeric(celcius_input.Text) Then
                input_invalid.Text = "Invalid input!"
                celcius_input.Clear()
            Else
                celcius = celcius_input.Text
                fahrenheit = (celcius * 9 / 5) + 32
                kelvin = celcius + 273.15
                fahrenheit_input.Text = fahrenheit
                kelvin_input.Text = kelvin
            End If
        ElseIf radio_fahrenheit.Checked Then
            If Not IsNumeric(fahrenheit_input.Text) Then
                input_invalid.Text = "Invalid input!"
                fahrenheit_input.Clear()
            Else
                fahrenheit = fahrenheit_input.Text
                celcius = (fahrenheit - 32) * 5 / 9
                kelvin = celcius + 273.15
                celcius_input.Text = celcius
                kelvin_input.Text = kelvin
            End If
        ElseIf radio_kelvin.Checked Then
            If Not IsNumeric(kelvin_input.Text) Then
                input_invalid.Text = "Invalid input!"
                kelvin_input.Clear()
            Else
                kelvin = kelvin_input.Text
                celcius = kelvin - 273.15
                fahrenheit = (celcius * 9 / 5) + 32
                celcius_input.Text = celcius
                fahrenheit_input.Text = fahrenheit
            End If
        End If
    End Sub
End Class