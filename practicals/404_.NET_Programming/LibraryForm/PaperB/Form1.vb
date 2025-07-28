Imports System.Data.SqlClient
Public Class Form1
    Dim connectionstring As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\home\documents\visual studio 2010\Projects\PaperB\PaperB\PaperB.mdf;Integrated Security=True;User Instance=True"
    Dim query As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Data()
    End Sub
    Sub Load_Data()
        Using con As New SqlConnection(connectionstring)
            con.Open()
            query = "Select * from Book_Master"
            Dim AD As New SqlDataAdapter(query, con)
            Dim DS As New DataSet()
            AD.Fill(DS, "Books")
            DataGridView1.DataSource = DS.Tables("Books")
        End Using
    End Sub
    Private Sub insBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insBtn.Click
        Dim InsForm As Form = InsertForm
        InsForm.ShowDialog()
        Load_Data()
    End Sub

    Private Sub delBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delBtn.Click
        Dim DelForm As Form = DeleteForm
        DelForm.ShowDialog()
        Load_Data()
    End Sub

    Private Sub updBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updBtn.Click
        Dim UpdForm As Form = UpdateForm
        UpdForm.ShowDialog()
        Load_Data()
    End Sub

    Private Sub seaBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seaBtn.Click
        Using con As New SqlConnection(connectionstring)
            con.Open()
            query = "Select * from Book_Master where Price<500 "
            Dim AD As New SqlDataAdapter(query, con)
            Dim DS As New DataSet()
            AD.Fill(DS, "Bookss")
            DataGridView1.DataSource = DS.Tables("Bookss")
        End Using
    End Sub

    Private Sub refBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refBtn.Click
        Load_Data()
    End Sub
End Class
