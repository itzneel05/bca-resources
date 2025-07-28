Public Class Form1
    ' This event is triggered when the form loads
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Set the form title
        Me.Text = "Current Date and Time"

        ' Set the label text to current date and time
        DateTimeNow.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        ' Start the timer
        Timer_Update.Start()
    End Sub

    ' This event is triggered every second by the timer
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer_Update.Tick
        ' Update the label with current date and time
        DateTimeNow.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub
End Class