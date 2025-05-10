Imports System.Data.SqlClient
Public Class InsertForm
    Dim connectionstring As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\home\documents\visual studio 2010\Projects\PaperB\PaperB\PaperB.mdf;Integrated Security=True;User Instance=True"
    Dim query As String
    Dim Filled As Boolean
    
    Sub CheckBoxes()
        If (bID.Text = "" Or bName.Text = "" Or lang.Text = "" Or price.Text = "" Or subj.Text = "") Then
            Filled = False
        Else
            Filled = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using con As New SqlConnection(connectionstring)
            con.Open()
            CheckBoxes()
            If (Filled) Then
                query = "Insert Into Book_Master values(@bID,@bName,@lang,@price,@subj);"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@bID", bID.Text)
                    cmd.Parameters.AddWithValue("@bName", bName.Text)
                    cmd.Parameters.AddWithValue("@lang", lang.Text)
                    cmd.Parameters.AddWithValue("@price", price.Text)
                    cmd.Parameters.AddWithValue("@subj", subj.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data Insert!!", "Insert Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End Using
            End If
        End Using
    End Sub
End Class