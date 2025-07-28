' Question:
' Develop a Vb.Net form to use input box and do arithmetic operations.

Public Class Form1
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        ' Set the form title
        Me.Text = "Arithmetic Operations"
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        ' Declare variables for numbers and result
        Dim num1 As Double
        Dim num2 As Double
        Dim result As Double

        ' InputBox to get the first number
        Dim input1 As String = InputBox("Enter the first number:", "Input First Number")

        ' InputBox to get the second number
        Dim input2 As String = InputBox("Enter the second number:", "Input Second Number")

        ' Perform arithmetic operations
        Dim operations As String = "Choose an operation:" & Environment.NewLine &
                                    "1. Addition" & Environment.NewLine &
                                    "2. Subtraction" & Environment.NewLine &
                                    "3. Multiplication" & Environment.NewLine &
                                    "4. Division"

        ' InputBox to select operation
        Dim operation As String = InputBox(operations, "Select Operation")

        ' Perform the selected operation
        Select Case operation
            Case "1"
                result = num1 + num2
                MessageBox.Show("The result of addition is: " & result, "Result")
            Case "2"
                result = num1 - num2
                MessageBox.Show("The result of subtraction is: " & result, "Result")
            Case "3"
                result = num1 * num2
                MessageBox.Show("The result of multiplication is: " & result, "Result")
            Case "4"
                If num2 = 0 Then
                    MessageBox.Show("Division by zero is not allowed.", "Error")
                Else
                    result = num1 / num2
                    MessageBox.Show("The result of division is: " & result, "Result")
                End If
            Case Else
                MessageBox.Show("Invalid operation selected. Please choose between 1 and 4.", "Error")
        End Select
    End Sub
End Class
