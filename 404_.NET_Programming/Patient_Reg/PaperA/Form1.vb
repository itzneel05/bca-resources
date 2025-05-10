Imports System.Data.SqlClient
Public Class Form1
    Dim conString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Home\Desktop\Practical\GitHub_repo\.NET\Patient_Reg\PaperA\PaperA.mdf;Integrated Security=True;User Instance=True"
    Dim query As String ' just string variable
    Dim BoxFilled As Boolean ' checking variable
    Sub CheckTextField() ' Check That All Text Fields Are Filled Or Not
        If (pNo.Text = "" Or pName.Text = "" Or dNo.Text = "" Or rNo.Text = "") Then ' Every Single TextBox MUST BE FILLED
            BoxFilled = False ' IF Not BoxFilled False
        Else
            BoxFilled = True ' Else Truee
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Data() ' Just Refersh
    End Sub
    Sub Load_Data() ' Referesh Data In Real Time
        Using con As New SqlConnection(conString)
            ' Connect Patient_Master And Doctor_Master Using Join Where Both Table Have Same Doctor_No [cuz we need Docto_name with Patient That why we use inner join]
            query = "SELECT p.Patient_no, p.Patient_name, d.Doctor_name, p.Admitted_date, p.Discharge_date, p.Room_no " & _
                    "FROM Patient_Master p " & _
                    "INNER JOIN Doctor_Master d ON p.Doctor_no = d.Doctor_no" ' p and d are Alias For Table Name
            ' ^ btw both table must be connected with Foriegn Key 
            Dim AD As New SqlDataAdapter(query, con) ' We Make Adapter Cuz We need bridge between Dataset And Record
            Dim DS As New DataSet() ' Blank Dataset
            AD.Fill(DS, "PatientDoctorDetails") ' We Fill Records In our Blank Dataset [Record That Are Caught in Select Query]
            DataGridView1.DataSource = DS.Tables("PatientDoctorDetails") ' Now Displaying At DataGridView
        End Using
    End Sub
    ' Insert Button Coding
    Private Sub insBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insBtn.Click
        CheckTextField()
        If (BoxFilled) Then ' IF ITS TRUE THEN BELOW THINGS [Checking Fields]
            Using con As New SqlConnection(conString) ' Created Connection Variable
                con.Open() ' Connection Open
                Dim ASelectedDate As Date = ADate.SelectionRange.Start ' It Select Whole Date + Time From Month Calcander [Admitted Date]
                Dim ADateOnly As Date = ASelectedDate.Date ' Select Only Date Now
                Dim DSelectedDate As Date = DDate.SelectionRange.Start ' Same With DischargeDate
                Dim DDateOnly As Date = DSelectedDate.Date
                query = "Insert Into Patient_Master Values(@pNo,@pName,@dNo,@ADate,@DDate,@rNo);" ' Insert Query
                Using cmd As New SqlCommand(query, con) ' Making Command Variable to Execute Query
                    cmd.Parameters.AddWithValue("@pNo", pNo.Text) ' Replacing Ailas With Actual Values
                    cmd.Parameters.AddWithValue("@pName", pName.Text) ' Same Here and Down too
                    cmd.Parameters.AddWithValue("@dNo", dNo.Text)
                    cmd.Parameters.AddWithValue("@ADate", ADateOnly)
                    cmd.Parameters.AddWithValue("@DDate", DDateOnly)
                    cmd.Parameters.AddWithValue("@rNo", rNo.Text)
                    cmd.ExecuteNonQuery() ' We Executed The Query YAYA
                    Load_Data() ' Referesh Data Real Time
                    MessageBox.Show("Record Insert!!", "Insert Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' ^ Just Simple GUI Message Box that shows Record is Inserted thats it
                End Using ' Command Variable Ended
            End Using ' Conncection Variable Ended
        Else ' IF ITS FALSE THEN BELOW THINGS [Checking Fields]
            MsgBox("Please Fill All Textbox") ' Simple MsgBox for Warning
        End If ' Ending Checking Field Condition
    End Sub
    ' Update Button Coding OMG[LONG AF]
    Private Sub updBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updBtn.Click
        Using con As New SqlConnection(conString) ' Here We GO Again Same Connection Variable
            con.Open() ' HOAHO Opened Connection
            If (pNo.Text = "" Or rNo.Text = "") Then ' We Updating Room No Just In Case Patient Need to tranfer to New Room
                ' ^ for update room no we need room no [HECK YEA] and patient no who to update
                MsgBox("Please Enter Patient No And Updated Room Number!") ' if either one field is empty then just simple msgbox
            Else ' if both field is filled then next part
                Dim checkQuery As String = "Select Count(*) From Patient_Master Where Patient_no = @pNo;"
                ' ^ now another query to check that inputted Patient no is in our record or no?
                Using checkCmd As New SqlCommand(checkQuery, con) ' so we make custom command variable to check that
                    checkCmd.Parameters.AddWithValue("@pNo", pNo.Text) ' replacing ailas with pNo
                    Dim recordExist As Integer = CInt(checkCmd.ExecuteScalar())
                    ' ^ this will check did something happend after we executed query, how many record did it effected?, simply converting that to Interger value
                    If (recordExist = 0) Then ' if we execute query and no record got effected means there's none record by that patient no
                        MsgBox("Please Enter Proper Patient_No!") ' simple warning msgbox
                    Else ' if record exists in record then we just update it
                        query = "Update Patient_Master Set Room_no = @rNo where Patient_no = @pNo;" ' update query
                        Using cmd As New SqlCommand(query, con) ' command variable
                            cmd.Parameters.AddWithValue("@pNo", pNo.Text) ' replacing ailas with values
                            cmd.Parameters.AddWithValue("@rNo", rNo.Text) ' same
                            cmd.ExecuteNonQuery() ' executing query
                            Load_Data() ' refershing data realtime
                            MessageBox.Show("Record Updated", "Update Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' ^ simple messgaebox that record updated!
                        End Using ' command variable ended
                    End If ' record exists condition ending

                End Using ' custom command variable that we use in check record existance
            End If ' field filled conditon ending
        End Using ' connection variable ending
    End Sub
    ' Delete Button Coding [im ded dude]
    Private Sub delBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delBtn.Click
        ' we just need patient no only to delete record so we just checking one textbox that filled or not
        Using con As New SqlConnection(conString) ' connection variable
            con.Open() ' connection open
            If (pNo.Text = "") Then ' checking that only one textbox is filled or not
                MsgBox("Dude Just Fill Patient no!!") ' warning msgbox
            Else ' if its filled then below things
                Dim checkQuery As String = "Select Count(*) From Patient_Master Where Patient_no = @pNo;" ' check record exist in record
                Using checkCmd As New SqlCommand(checkQuery, con) ' custom command variable to check record
                    checkCmd.Parameters.AddWithValue("@pNo", pNo.Text) ' replacing ailas with value
                    Dim RecordExist As Integer = CInt(checkCmd.ExecuteScalar()) ' converting effected record into int variable
                    If (RecordExist = 0) Then ' if no record exist
                        MsgBox("No Record Found!") ' warning msg
                    Else ' if exists
                        query = "Delete From Patient_master where Patient_no = @pNo;" ' simple delete query
                        Using cmd As New SqlCommand(query, con) ' command variable
                            cmd.Parameters.AddWithValue("@pNo", pNo.Text) ' replacing ailas with value
                            cmd.ExecuteNonQuery() ' executing query
                            Load_Data() ' refershing datagridview
                            MessageBox.Show("Record Deleted!", "Delete Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' ^ simple message box that record is deleted
                        End Using ' command variable ending
                    End If ' record exists if ending
                End Using ' custom command variable ended
            End If ' field checker if ending
        End Using ' connection ending
    End Sub
    ' HOHO Display Current Month Coding
    Sub Current_Month_Display() ' set current month records in datagridview
        Using con As New SqlConnection(conString) ' connection variable
            Dim CurrentMonth As Integer = Now.Month ' int variable that store current month
            query = "Select p.Patient_name, p.Admitted_Date, d.Doctor_name From Patient_Master p Inner Join Doctor_Master d on p.Doctor_no = d.Doctor_no where Month(Admitted_date) = @CurrentMonth;"
            ' ^ this query is long af cuz it select pname, admit date, doctor name with condition that only current month patient should be display
            Dim AD As New SqlDataAdapter(query, con) ' adapter variable
            AD.SelectCommand.Parameters.AddWithValue("@CurrentMonth", CurrentMonth) ' replacing ailas with value
            Dim DS As New DataSet ' new dataset
            AD.Fill(DS, "PatientDoctorDetailsCurrentMonth") ' fillind data to dataset
            DataGridView1.DataSource = DS.Tables("PatientDoctorDetailsCurrentMonth") ' setting record on datagrid view
        End Using
    End Sub
    ' Display button clicking
    Private Sub disBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disBtn.Click
        Current_Month_Display() ' just calling this on click button
    End Sub
    ' just refersh button to display whole data again after display button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Load_Data()
    End Sub
End Class
