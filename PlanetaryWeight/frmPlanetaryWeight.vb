' Program:      Planetary Weight
' Author:       Mark Bulmer
' Date:         February 26, 2022
' Purpose:      This application computes the weight of a person on Mars or Venus.

Option Strict On

Public Class frmPlanetaryWeight
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' The btnCalculate event handler calculates the converted weight.

        ' Declaration Section
        Dim decEarthWeight As Decimal
        Dim decWeightChoice As Decimal
        Dim decConvertedWeight As Decimal
        Dim decKilograms As Decimal
        Dim decVenusWeight As Decimal = 0.907D
        Dim decMarsWeight As Decimal = 0.377D
        Dim decKilogramsConverted As Decimal = 0.454D

        ' Did user enter a numeric value?
        If IsNumeric(txtFootage.Text) Then
            decEarthWeight = Convert.ToDecimal(txtFootage.Text)
            ' Is weight greater than zero
            If decEarthWeight > 0 Then
                ' Determine converted weight
                If radVenus.Checked Then
                    decWeightChoice = decVenusWeight
                    lblPlanetChoice.Text = "Venus is"
                ElseIf radMars.Checked Then
                    decWeightChoice = decMarsWeight
                    lblPlanetChoice.Text = "Mars is"
                End If
                ' Calculate and display the converted weight
                decConvertedWeight = decEarthWeight * decWeightChoice
                decKilograms = decConvertedWeight * decKilogramsConverted
                lblConvertedPounds.Text = decConvertedWeight.ToString("n1") & " lbs"
                lblConvertedKilograms.Text = "or " & decKilograms.ToString("n1") & " kgs"
            Else
                ' Display error message if user entered a negative value
                MsgBox("You entered " & decEarthWeight.ToString() & ". Enter a Positive Number", , "Input Error")
                txtFootage.Text = ""
                txtFootage.Focus()
            End If
        Else
            ' Display error message if user entered a nonnumeric value
            MsgBox("Please enter a valid number", , "Input Error")
            txtFootage.Text = ""
            txtFootage.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the Clear button. It 
        ' clears the current information in weight and planet labels.

        txtFootage.Clear()
        lblPlanetChoice.Text = ""
        lblConvertedPounds.Text = ""
        lblConvertedKilograms.Text = ""
        radVenus.Checked = True
        radMars.Checked = False
        txtFootage.Focus()
    End Sub

    Private Sub frmPlanetary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded at the start of the 
        ' program. It sets the focus to the square footage text box and
        ' clears the planet label.

        txtFootage.Focus()
        lblPlanetChoice.Text = ""
    End Sub

End Class
