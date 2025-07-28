Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    ' Connection string to the local SQL Server database
    Dim connectionstring As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Home\Desktop\Practical\GitHub_repo\.NET\StudentForm\Question9\StudentDB.mdf;Integrated Security=True;User Instance=True"

    ' Clears all TextBox controls recursively in the form
    Public Sub ClearAllTextBoxes(ByVal parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
            If ctrl.HasChildren Then
                ClearAllTextBoxes(ctrl)
            End If
        Next
    End Sub

    ' Loads data from Student table and binds it to multiple DataGridViews
    Private Sub RefreshDataGridView()
        Try
            Using con As New SqlConnection(connectionstring)
                Dim query As String = "SELECT * FROM Student"
                Using cmd As New SqlCommand(query, con)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet, "Student")
                    DataGridView1.DataSource = dataSet.Tables("Student")
                    DataGridView2.DataSource = dataSet.Tables("Student")
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    ' Inserts a new student record after validating input fields
    Private Sub Sumbit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sumbit.Click
        Dim allTextBoxesFilled As Boolean = True

        ' Check if all TextBoxes are filled
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                If String.IsNullOrWhiteSpace(CType(ctrl, TextBox).Text) Then
                    allTextBoxesFilled = False
                    Exit For
                End If
            End If
        Next

        If allTextBoxesFilled Then
            Dim stuNo As Integer
            Dim fee As Integer
            Dim dob As String = BirthD.Text

            ' Input validation
            If Not Integer.TryParse(txtNo.Text, stuNo) Then
                MsgBox("Please enter a valid Student Number.")
                Return
            End If
            If Not Integer.TryParse(txtCFee.Text, fee) Then
                MsgBox("Please enter a valid Fee amount.")
                Return
            End If

            ' Collect input
            Dim stuName As String = txtName.Text
            Dim city As String = txtCity.Text
            Dim course As String = txtCName.Text

            ' Insert into database
            Try
                Using con As New SqlConnection(connectionstring)
                    con.Open()
                    Dim query As String = "INSERT INTO Student VALUES (@No, @Name, @City, @Dob, @Fees, @Course)"
                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@No", stuNo)
                        cmd.Parameters.AddWithValue("@Name", stuName)
                        cmd.Parameters.AddWithValue("@City", city)
                        cmd.Parameters.AddWithValue("@Dob", dob)
                        cmd.Parameters.AddWithValue("@Fees", fee)
                        cmd.Parameters.AddWithValue("@Course", course)
                        cmd.ExecuteNonQuery()

                        MsgBox("Record Inserted")
                        RefreshDataGridView()
                        ClearAllTextBoxes(Me)
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        Else
            MsgBox("Please Fill Form!")
        End If
    End Sub

    ' Fills dataset on form load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StudentTableAdapter.Fill(Me.Question9DataSet.Student)
    End Sub

    ' Updates student's city by student number
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim stuNo As Integer
        If Not Integer.TryParse(upNo.Text, stuNo) Then
            MsgBox("Please enter a valid Student Number")
            Return
        End If

        Dim newCityName As String = newCity.Text
        If String.IsNullOrWhiteSpace(newCityName) Then
            MsgBox("Please enter a new City Name")
            Return
        End If

        Try
            Using con As New SqlConnection(connectionstring)
                con.Open()

                ' Check if record exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM Student WHERE stuNo = @No"
                Using checkCmd As New SqlCommand(checkQuery, con)
                    checkCmd.Parameters.AddWithValue("@No", stuNo)
                    Dim recordExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If recordExists > 0 Then
                        ' Perform update
                        Dim updateQuery As String = "UPDATE Student SET City = @City WHERE stuNo = @No"
                        Using updateCmd As New SqlCommand(updateQuery, con)
                            updateCmd.Parameters.AddWithValue("@City", newCityName)
                            updateCmd.Parameters.AddWithValue("@No", stuNo)
                            updateCmd.ExecuteNonQuery()
                        End Using
                        RefreshDataGridView()
                        MsgBox("Record updated successfully!")
                    Else
                        MsgBox("Student Number not found, record not updated.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    ' Deletes a student record by student number
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim stuNo As Integer
        If Not Integer.TryParse(delNo.Text, stuNo) Then
            MsgBox("Please enter a valid Student Number")
            Return
        End If

        Try
            Using con As New SqlConnection(connectionstring)
                con.Open()
                Dim deleteQuery As String = "DELETE FROM Student WHERE stuNo = @No"
                Using deleteCmd As New SqlCommand(deleteQuery, con)
                    deleteCmd.Parameters.AddWithValue("@No", stuNo)
                    Dim rowsAffected As Integer = deleteCmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Record deleted successfully!")
                        RefreshDataGridView()
                    Else
                        MsgBox("Student Number not found, record not deleted.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    ' Searches for a student by student number
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim stuNo As Integer
        If Not Integer.TryParse(noSearch.Text, stuNo) Then
            MsgBox("Please enter a valid Student Number")
            Return
        End If

        Try
            Using con As New SqlConnection(connectionstring)
                con.Open()
                Dim searchQuery As String = "SELECT * FROM Student WHERE stuNo = @No"
                Using searchCmd As New SqlCommand(searchQuery, con)
                    searchCmd.Parameters.AddWithValue("@No", stuNo)
                    Dim adapter As New SqlDataAdapter(searchCmd)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet, "Student")
                    DataGridView3.DataSource = dataSet.Tables("Student")
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    ' Conditional search by course name and fee range
    Private Sub btnConSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConSearch.Click
        Dim course As String = courseName.Text
        Dim lowerLimit As Integer
        Dim upperLimit As Integer

        ' Input validation
        If String.IsNullOrWhiteSpace(course) Then
            MsgBox("Please enter a Course Name")
            Return
        End If
        If Not Integer.TryParse(LowerL.Text, lowerLimit) Then
            MsgBox("Please enter a valid Lower Limit")
            Return
        End If
        If Not Integer.TryParse(UpperL.Text, upperLimit) Then
            MsgBox("Please enter a valid Upper Limit")
            Return
        End If

        ' Execute search query
        Try
            Using con As New SqlConnection(connectionstring)
                con.Open()
                Dim searchQuery As String = "SELECT * FROM Student WHERE Course = @Course AND Fees BETWEEN @LowerLimit AND @UpperLimit"
                Using searchCmd As New SqlCommand(searchQuery, con)
                    searchCmd.Parameters.AddWithValue("@Course", course)
                    searchCmd.Parameters.AddWithValue("@LowerLimit", lowerLimit)
                    searchCmd.Parameters.AddWithValue("@UpperLimit", upperLimit)
                    Dim adapter As New SqlDataAdapter(searchCmd)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet, "Student")
                    DataGridView4.DataSource = dataSet.Tables("Student")
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Class
