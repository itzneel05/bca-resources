Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Get the selected date from the DateTimePicker control (named DTP)
        Dim selectedDate As DateTime = DTP.Value

        ' Extract the day, month, and year from the selected date
        Dim Day As Integer = selectedDate.Day
        Dim Month As Integer = selectedDate.Month
        Dim Year As Integer = selectedDate.Year

        ' Display the extracted day, month, and year in the corresponding TextBox controls
        DateText.Text = Day.ToString()
        MonthText.Text = Month.ToString()
        YearText.Text = Year.ToString()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Date Picker"
    End Sub
End Class
