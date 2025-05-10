Public Class Form1
    ' Declare variables to store the first number, second number, and the operator
    Dim num1 As Double
    Dim num2 As Double
    Dim Ope As String

    ' Event handler for Button 7 click
    ' Appends the number "7" to the text in the input box
    Private Sub btnSeven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeven.Click
        txtInput.Text &= CType(sender, Button).Text
    End Sub

    ' Event handler for Button 8 click
    ' Appends the number "8" to the text in the input box
    Private Sub btnEight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEight.Click
        txtInput.Text &= CType(sender, Button).Text
    End Sub

    ' Event handler for Button 9 click
    ' Appends the number "9" to the text in the input box
    Private Sub btnNine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNine.Click
        txtInput.Text &= CType(sender, Button).Text
    End Sub

    ' Event handler for Button 4 click
    ' Appends the number "4" to the text in the input box
    Private Sub btnFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFour.Click
        txtInput.Text &= CType(sender, Button).Text
    End Sub

    ' Event handler for Button 5 click
    ' Appends the number "5" to the text in the input box
    Private Sub btnFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFive.Click
        txtInput.Text &= CType(sender, Button).Text
    End Sub

    ' Event handler for Button 6 click
    ' Appends the number "6" to the text in the input box
    Private Sub btnSix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSix.Click
        txtInput.Text &= CType(sender, Button).Text
    End Sub

    ' Event handler for Button 1 click
    ' Appends the number "1" to the text in the input box
    Private Sub btnOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOne.Click
        txtInput.Text &= CType(sender, Button).Text
    End Sub

    ' Event handler for Button 2 click
    ' Appends the number "2" to the text in the input box
    Private Sub btnTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwo.Click
        txtInput.Text &= CType(sender, Button).Text
    End Sub

    ' Event handler for Button 3 click
    ' Appends the number "3" to the text in the input box
    Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click
        txtInput.Text &= CType(sender, Button).Text
    End Sub

    ' Event handler for Clear Button click
    ' Clears the input box and resets the first number
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtInput.Clear()
        num1 = 0
    End Sub

    ' Event handler for Button 0 click
    ' Appends the number "0" to the text in the input box
    Private Sub btnZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZero.Click
        txtInput.Text &= CType(sender, Button).Text
    End Sub

    ' Event handler for Equal Button click
    ' Performs the calculation based on the selected operator and displays the result
    Private Sub btnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click
        ' Get the second number from the input box
        num2 = Convert.ToDouble(txtInput.Text)

        ' Perform the operation based on the selected operator
        Select Case Ope
            Case "+"
                txtInput.Text = (num1 + num2).ToString
            Case "-"
                txtInput.Text = (num1 - num2).ToString
            Case "*"
                txtInput.Text = (num1 * num2).ToString
            Case "/"
                ' Check for division by zero
                If num2 <> 0 Then
                    txtInput.Text = (num1 / num2).ToString
                Else
                    txtInput.Text = "Error"
                End If
        End Select
    End Sub

    ' Event handler for Minus Button click
    ' Stores the first number and sets the operator to "-"
    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        num1 = Convert.ToDouble(txtInput.Text)
        Ope = "-"
        txtInput.Clear()
    End Sub

    ' Event handler for Plus Button click
    ' Stores the first number and sets the operator to "+"
    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        num1 = Convert.ToDouble(txtInput.Text)
        Ope = "+"
        txtInput.Clear()
    End Sub

    ' Event handler for Divide Button click
    ' Stores the first number and sets the operator to "/"
    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        num1 = Convert.ToDouble(txtInput.Text)
        Ope = "/"
        txtInput.Clear()
    End Sub

    ' Event handler for Multiply Button click
    ' Stores the first number and sets the operator to "*"
    Private Sub btnMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulti.Click
        num1 = Convert.ToDouble(txtInput.Text)
        Ope = "*"
        txtInput.Clear()
    End Sub

    ' Event handler for Form Load
    ' Sets the title of the form
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Calculator"
    End Sub
End Class