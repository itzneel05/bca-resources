Imports System.Data.SqlClient
Public Class UpdateForm
    Dim connectionstring As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\home\documents\visual studio 2010\Projects\PaperB\PaperB\PaperB.mdf;Integrated Security=True;User Instance=True"
    Dim query As String
    Dim Filled As Boolean
    Sub CheckBoxes()
        If (bID.Text = "" Or subj.Text = "") Then
            Filled = False
        Else
            Filled = True
        End If
    End Sub
    Private Sub updBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updBtn.Click
        Using con As New SqlConnection(connectionstring)
            con.Open()
            CheckBoxes()
            If (Filled) Then
                Dim checkQuery As String = "Select count(*) from Book_Master where Book_ID = @bID;"
                Using checkCmd As New SqlCommand(checkQuery, con)
                    checkCmd.Parameters.AddWithValue("@bID", bID.Text)
                    Dim recordExists As Integer = CInt(checkCmd.ExecuteScalar())
                    If (recordExists = 0) Then
                        MsgBox("No Record Found!")
                    Else
                        query = "Update Book_Master Set Subject = @subj where Book_ID = @bID"
                        Using cmd As New SqlCommand(query, con)
                            cmd.Parameters.AddWithValue("@subj", subj.Text)
                            cmd.Parameters.AddWithValue("@bID", bID.Text)
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Data Updated!!", "Update Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End Using
                    End If
                End Using
            Else
                MsgBox("Please Fill All TextBoxes")
            End If
        End Using
    End Sub
End Class