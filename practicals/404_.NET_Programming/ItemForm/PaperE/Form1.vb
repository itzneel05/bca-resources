Imports System.Data.SqlClient
Public Class Form1
    Dim connectionstring As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\home\documents\visual studio 2010\Projects\PaperE\PaperE\PaperE.mdf;Integrated Security=True;User Instance=True"
    Dim query As String
    Dim Filled As Boolean
    Sub Load_Data()
        Using con As New SqlConnection(connectionstring)
            con.Open()
            query = "Select * from ItemMst"
            Dim AD As New SqlDataAdapter(query, con)
            Dim DS As New DataSet()
            AD.Fill(DS, "Items")
            DataGridView1.DataSource = DS.Tables("Items")
        End Using
    End Sub
    Sub CheckBoxes()
        If (iNo.Text = "" Or iName.Text = "" Or iRate.Text = "") Then
            Filled = False
        Else
            Filled = True
        End If
    End Sub
    Private Sub newBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newBtn.Click
        iNo.Text = ""
        iName.Text = ""
        iRate.SelectedIndex = -1
    End Sub

    Private Sub saveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveBtn.Click
        Using con As New SqlConnection(connectionstring)
            con.Open()
            CheckBoxes()
            If (Filled) Then
                query = "Insert Into ItemMSt values(@iNo,@iName,@iRate);"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@iNo", iNo.Text)
                    cmd.Parameters.AddWithValue("@iName", iName.Text)
                    cmd.Parameters.AddWithValue("@iRate", iRate.Text)
                    cmd.ExecuteNonQuery()
                    Load_Data()
                    MessageBox.Show("Data Insert!!", "Insert Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End If
        End Using
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Data()
    End Sub

    Private Sub exitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub delBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delBtn.Click
        Using con As New SqlConnection(connectionstring)
            con.Open()
            CheckBoxes()
            If (iNo.Text <> "") Then
                Dim checkQuery As String = "Select count(*) from ItemMst where ItemNo = @iNo;"
                Using checkCmd As New SqlCommand(checkQuery, con)
                    checkCmd.Parameters.AddWithValue("@iNo", iNo.Text)
                    Dim recordExists As Integer = CInt(checkCmd.ExecuteScalar())
                    If (recordExists = 0) Then
                        MsgBox("No Record Found!")
                    Else
                        query = "Delete From ItemMSt Where ItemNo = @iNo;"
                        Using cmd As New SqlCommand(query, con)
                            cmd.Parameters.AddWithValue("@iNo", iNo.Text)
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Data Deleted!!", "Delete Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Load_Data()
                        End Using
                    End If
                End Using
            Else
                MsgBox("Please Fill Item No")
            End If
        End Using
    End Sub

    Private Sub searchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchBtn.Click
        If (iNo.Text <> "") Then
            Using con As New SqlConnection(connectionstring)
                con.Open()
                query = "Select * from ItemMst Where ItemNo = @iNo"
                Dim AD As New SqlDataAdapter(query, con)
                AD.SelectCommand.Parameters.AddWithValue("@iNo", iNo.Text)
                Dim DS As New DataSet()
                AD.Fill(DS, "Items")
                DataGridView1.DataSource = DS.Tables("Items")
            End Using
        Else
            MsgBox("Please Fill Item No")
        End If
        
    End Sub

    Private Sub refBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refBtn.Click
        Load_Data()
    End Sub
End Class
