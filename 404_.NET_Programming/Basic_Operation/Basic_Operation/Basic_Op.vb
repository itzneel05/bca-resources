' Question : 
' Display value from Text box, combo box, list box, radio buttons and checkbox on button click event in Message box.

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim course As String = String.Join(", ", listCourse.SelectedItems.Cast(Of String)())
        Dim gender As String
        Dim checkThis As String
        If (rMale.Checked) Then
            gender = "Male"
        ElseIf (rFemale.Checked) Then
            gender = "Female"
        End If
        If (checkBoxx.Checked) Then
            checkThis = "Checked"
        Else
            checkThis = "Unchecked"
        End If


        MessageBox.Show("Name = " & txtName.Text & Environment.NewLine &
                        "Course = " & course & Environment.NewLine &
                        "Year = " & comboYear.SelectedItem.ToString() & Environment.NewLine &
                        "Gender = " & gender & Environment.NewLine &
                        "Status = " & checkThis , "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
