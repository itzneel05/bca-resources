' Import required namespace for SQL Server access
Imports System.Data.SqlClient

Public Class Form1
    ' Connection string to connect to the local SQL Server database
    Dim connectionString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Home\Desktop\Practical\GitHub_repo\.NET\BookManagement\BookManagement\BookDatabase.mdf;Integrated Security=True;User Instance=True"

    ' Method to load book names and numbers into ComboBox when the form loads
    Private Sub LoadBooks()
        Dim con As New SqlConnection(connectionString)
        Try
            con.Open()
            ' Select BookNo and Name to populate ComboBox
            Dim cmd As New SqlCommand("SELECT BookNo, Name FROM Book", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(reader)

            ' Bind ComboBox to the DataTable
            cmbBooks.DataSource = dt
            cmbBooks.DisplayMember = "Name"     ' Display book name
            cmbBooks.ValueMember = "BookNo"     ' Internally use BookNo

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading books: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Event that triggers when the form loads
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadBooks() ' Load books into ComboBox
        Me.Text = "Book Details"
    End Sub

    ' Event that triggers when a new book is selected in ComboBox
    Private Sub cmbBooks_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBooks.SelectedIndexChanged
        Dim con As New SqlConnection(connectionString)

        ' Safety check to prevent errors
        If cmbBooks.SelectedValue Is Nothing Then Exit Sub
        If TypeOf cmbBooks.SelectedValue Is System.Data.DataRowView Then Exit Sub

        Try
            con.Open()
            ' Fetch details of the selected book using BookNo
            Dim cmd As New SqlCommand("SELECT * FROM Book WHERE BookNo = @BookNo", con)
            cmd.Parameters.AddWithValue("@BookNo", cmbBooks.SelectedValue)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Populate text fields with book details
            If reader.Read() Then
                txtBookNo.Text = reader("BookNo").ToString()
                txtAuthor.Text = reader("AuthorName").ToString()
                txtCost.Text = reader("Cost").ToString()
                txtCopies.Text = reader("NoOfCopies").ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading details: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Event that triggers when "Delete" button is clicked
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim con As New SqlConnection(connectionString)

        ' Validate input
        If txtDeleteNo.Text.Trim() = "" Then
            MessageBox.Show("Enter BookNo to delete.")
            Exit Sub
        End If

        Try
            con.Open()
            ' Delete book record with given BookNo
            Dim cmd As New SqlCommand("DELETE FROM Book WHERE BookNo = @BookNo", con)
            cmd.Parameters.AddWithValue("@BookNo", txtDeleteNo.Text.Trim())

            Dim rowsAffected = cmd.ExecuteNonQuery()

            ' Notify user about the result
            If rowsAffected > 0 Then
                MessageBox.Show("Book deleted successfully.")
                LoadBooks()      ' Refresh ComboBox
                ClearDetails()   ' Clear text fields
            Else
                MessageBox.Show("No book found with the given BookNo.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting book: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Method to clear all text fields
    Private Sub ClearDetails()
        txtBookNo.Clear()
        txtAuthor.Clear()
        txtCost.Clear()
        txtCopies.Clear()
        txtDeleteNo.Clear()
    End Sub
End Class
