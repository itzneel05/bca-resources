' Import SQL client namespace for database operations
Imports System.Data.SqlClient

Public Class Form1
    ' Class-level DataTable (not used in the code)
    Private dataTable As DataTable

    ' Connection string to connect to the local SQL Server database
    Dim connectionString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Home\Desktop\Practical\GitHub_repo\.NET\EmpMasterForm\Question8\EmpDatabase.mdf;Integrated Security=True;User Instance=True"

    ' Recursive function to clear all TextBox controls in the form
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

    ' Handles the click event of the "Submit" button
    Private Sub Sumbit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sumbit.Click
        ' Check if all textboxes are filled
        Dim allTextBoxesFilled As Boolean = True
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim textBox As TextBox = CType(ctrl, TextBox)
                If String.IsNullOrWhiteSpace(textBox.Text) Then
                    allTextBoxesFilled = False
                    Exit For
                End If
            End If
        Next

        If allTextBoxesFilled Then
            ' Collect data from input controls
            Dim empid As Integer = txtId.Text
            Dim empname As String = txtName.Text
            Dim empaddress As String = txtAdd.Text
            Dim empsalary As Integer = txtSalary.Text
            Dim empphone As String = txtPhone.Text
            Dim empdept As String = txtDept.Text
            Dim empgender As String = If(MaleRadio.Checked, "Male", "Female")
            Dim joiningdate As String = JoinD.Text
            Dim birthdate As String = BirthD.Text
            Dim empemail As String = txtEmail.Text

            ' Try inserting record into the database
            Try
                Using con As New SqlConnection(connectionString)
                    con.Open()
                    Dim query As String = "Insert Into Emp Values(@ID,@Name,@Dept,@Mo,@Gender,@Address,@JoinD,@Sal,@BirthD,@Email)"
                    Using cmd As New SqlCommand(query, con)
                        ' Assign values to parameters
                        cmd.Parameters.AddWithValue("@ID", empid)
                        cmd.Parameters.AddWithValue("@Name", empname)
                        cmd.Parameters.AddWithValue("@Dept", empdept)
                        cmd.Parameters.AddWithValue("@Mo", empphone)
                        cmd.Parameters.AddWithValue("@Gender", empgender)
                        cmd.Parameters.AddWithValue("@Address", empaddress)
                        cmd.Parameters.AddWithValue("@JoinD", joiningdate)
                        cmd.Parameters.AddWithValue("@Sal", empsalary)
                        cmd.Parameters.AddWithValue("@BirthD", birthdate)
                        cmd.Parameters.AddWithValue("@Email", empemail)

                        ' Execute insert command
                        cmd.ExecuteNonQuery()
                        RefreshDataGridView()
                        MsgBox("Record Inserted")
                        ClearAllTextBoxes(Me)
                        RefreshDataGridView()
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error") ' Consider showing ex.Message for debugging
            End Try
        Else
            MsgBox("Please Fill Form!")
        End If
    End Sub

    ' Handles update operation
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim empid As Integer
        If Not Integer.TryParse(upID.Text, empid) Then
            MsgBox("Please enter a valid Employee ID")
            Return
        End If

        Dim empdept As String = newDept.Text
        Dim empaddress As String = newAdd.Text

        If String.IsNullOrWhiteSpace(empdept) OrElse String.IsNullOrWhiteSpace(empaddress) Then
            MsgBox("Please fill in all fields")
            Return
        End If

        ' Update query if record exists
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                ' Check if record exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM Emp WHERE EID = @ID"
                Using checkCmd As New SqlCommand(checkQuery, con)
                    checkCmd.Parameters.AddWithValue("@ID", empid)
                    Dim recordExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If recordExists > 0 Then
                        Dim updateQuery As String = "UPDATE Emp SET Dept = @Dept, Address = @Address WHERE EID = @ID"
                        Using updateCmd As New SqlCommand(updateQuery, con)
                            updateCmd.Parameters.AddWithValue("@Dept", empdept)
                            updateCmd.Parameters.AddWithValue("@Address", empaddress)
                            updateCmd.Parameters.AddWithValue("@ID", empid)
                            updateCmd.ExecuteNonQuery()
                        End Using
                        RefreshDataGridView()
                        MsgBox("Record updated successfully!")
                    Else
                        MsgBox("Employee ID not found, record not updated.")
                    End If
                End Using
            End Using
            ClearAllTextBoxes(Me)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    ' Load data into the dataset (used with designer-bound DataGridView)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EmpTableAdapter.Fill(Me.Question8DataSet.Emp)
    End Sub

    ' Handles deletion of employee record
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim empid As Integer
        If Not Integer.TryParse(delID.Text, empid) Then
            MsgBox("Please enter a valid Employee ID")
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim deleteQuery As String = "DELETE FROM Emp WHERE EID = @ID"
                Using deleteCmd As New SqlCommand(deleteQuery, con)
                    deleteCmd.Parameters.AddWithValue("@ID", empid)
                    Dim rowsAffected As Integer = deleteCmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Record deleted successfully!")
                        RefreshDataGridView()
                    Else
                        MsgBox("Employee ID not found, record not deleted.")
                    End If
                End Using
            End Using
            ClearAllTextBoxes(Me)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    ' Refresh all DataGridViews with updated data
    Private Sub RefreshDataGridView()
        ' Note: This uses a hardcoded old connection string; it should be updated to the shared `connectionString` variable
        Dim connectionstring As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\home\documents\visual studio 2010\Projects\Question8\Question8\Question8.mdf;Integrated Security=True;User Instance=True"
        Try
            Using con As New SqlConnection(connectionstring)
                Dim query As String = "SELECT * FROM Emp"
                Using cmd As New SqlCommand(query, con)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet, "Emp")
                    DataGridView1.DataSource = dataSet.Tables("Emp")
                    DataGridView2.DataSource = dataSet.Tables("Emp")
                    DataGridView3.DataSource = dataSet.Tables("Emp")
                    DataGridView4.DataSource = dataSet.Tables("Emp")
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    ' Search employee records by name
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim empName As String = nameSearch.Text

        If String.IsNullOrWhiteSpace(empName) Then
            MsgBox("Please enter an Employee Name to search")
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim searchQuery As String = "SELECT * FROM Emp WHERE EName LIKE @Name"
                Using searchCmd As New SqlCommand(searchQuery, con)
                    searchCmd.Parameters.AddWithValue("@Name", "%" & empName & "%")
                    Dim adapter As New SqlDataAdapter(searchCmd)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet, "Emp")
                    DataGridView3.DataSource = dataSet.Tables("Emp")
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Class
