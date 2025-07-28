<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboYear = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listCourse = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rMale = New System.Windows.Forms.RadioButton()
        Me.rFemale = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.checkBoxx = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Details :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(117, 66)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(165, 30)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'comboYear
        '
        Me.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboYear.FormattingEnabled = True
        Me.comboYear.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year"})
        Me.comboYear.Location = New System.Drawing.Point(117, 221)
        Me.comboYear.Name = "comboYear"
        Me.comboYear.Size = New System.Drawing.Size(148, 33)
        Me.comboYear.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Course"
        '
        'listCourse
        '
        Me.listCourse.FormattingEnabled = True
        Me.listCourse.ItemHeight = 25
        Me.listCourse.Items.AddRange(New Object() {"BCA", "BCOM", "BBA"})
        Me.listCourse.Location = New System.Drawing.Point(117, 119)
        Me.listCourse.Name = "listCourse"
        Me.listCourse.Size = New System.Drawing.Size(165, 79)
        Me.listCourse.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Year"
        '
        'rMale
        '
        Me.rMale.AutoSize = True
        Me.rMale.Location = New System.Drawing.Point(117, 275)
        Me.rMale.Name = "rMale"
        Me.rMale.Size = New System.Drawing.Size(76, 29)
        Me.rMale.TabIndex = 7
        Me.rMale.TabStop = True
        Me.rMale.Text = "Male"
        Me.rMale.UseVisualStyleBackColor = True
        '
        'rFemale
        '
        Me.rFemale.AutoSize = True
        Me.rFemale.Location = New System.Drawing.Point(199, 275)
        Me.rFemale.Name = "rFemale"
        Me.rFemale.Size = New System.Drawing.Size(98, 29)
        Me.rFemale.TabIndex = 8
        Me.rFemale.TabStop = True
        Me.rFemale.Text = "Female"
        Me.rFemale.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Check This"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 37)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'checkBoxx
        '
        Me.checkBoxx.AutoSize = True
        Me.checkBoxx.Location = New System.Drawing.Point(144, 333)
        Me.checkBoxx.Name = "checkBoxx"
        Me.checkBoxx.Size = New System.Drawing.Size(18, 17)
        Me.checkBoxx.TabIndex = 10
        Me.checkBoxx.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 437)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.checkBoxx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rFemale)
        Me.Controls.Add(Me.rMale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.listCourse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.comboYear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents listCourse As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rMale As System.Windows.Forms.RadioButton
    Friend WithEvents rFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents checkBoxx As System.Windows.Forms.CheckBox

End Class
