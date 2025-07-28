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
        Me.components = New System.ComponentModel.Container()
        Me.pNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rNo = New System.Windows.Forms.TextBox()
        Me.ADate = New System.Windows.Forms.MonthCalendar()
        Me.DDate = New System.Windows.Forms.MonthCalendar()
        Me.dNo = New System.Windows.Forms.ComboBox()
        Me.insBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.updBtn = New System.Windows.Forms.Button()
        Me.delBtn = New System.Windows.Forms.Button()
        Me.disBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PaperADataSet = New PaperA.PaperADataSet()
        Me.PaperADataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Patient_MasterTableAdapter = New PaperA.PaperADataSetTableAdapters.Patient_MasterTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PaperADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaperADataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pNo
        '
        Me.pNo.Location = New System.Drawing.Point(212, 113)
        Me.pNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pNo.Name = "pNo"
        Me.pNo.Size = New System.Drawing.Size(167, 30)
        Me.pNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patient No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 165)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Patient Name"
        '
        'pName
        '
        Me.pName.Location = New System.Drawing.Point(212, 160)
        Me.pName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pName.Name = "pName"
        Me.pName.Size = New System.Drawing.Size(167, 30)
        Me.pName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 211)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Doctor No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 323)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Admitted Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 323)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Discharge Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 262)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Room No"
        '
        'rNo
        '
        Me.rNo.Location = New System.Drawing.Point(212, 257)
        Me.rNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rNo.Name = "rNo"
        Me.rNo.Size = New System.Drawing.Size(167, 30)
        Me.rNo.TabIndex = 10
        '
        'ADate
        '
        Me.ADate.Location = New System.Drawing.Point(22, 357)
        Me.ADate.Name = "ADate"
        Me.ADate.TabIndex = 12
        '
        'DDate
        '
        Me.DDate.Location = New System.Drawing.Point(302, 357)
        Me.DDate.Name = "DDate"
        Me.DDate.TabIndex = 13
        '
        'dNo
        '
        Me.dNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dNo.FormattingEnabled = True
        Me.dNo.Items.AddRange(New Object() {"101", "102", "103", "104"})
        Me.dNo.Location = New System.Drawing.Point(212, 211)
        Me.dNo.Name = "dNo"
        Me.dNo.Size = New System.Drawing.Size(167, 33)
        Me.dNo.TabIndex = 14
        '
        'insBtn
        '
        Me.insBtn.Location = New System.Drawing.Point(30, 588)
        Me.insBtn.Name = "insBtn"
        Me.insBtn.Size = New System.Drawing.Size(139, 43)
        Me.insBtn.TabIndex = 15
        Me.insBtn.Text = "Insert"
        Me.insBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 31)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(373, 44)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Patient Registration"
        '
        'updBtn
        '
        Me.updBtn.Location = New System.Drawing.Point(175, 588)
        Me.updBtn.Name = "updBtn"
        Me.updBtn.Size = New System.Drawing.Size(139, 43)
        Me.updBtn.TabIndex = 18
        Me.updBtn.Text = "Update"
        Me.updBtn.UseVisualStyleBackColor = True
        '
        'delBtn
        '
        Me.delBtn.Location = New System.Drawing.Point(320, 588)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.Size = New System.Drawing.Size(139, 43)
        Me.delBtn.TabIndex = 19
        Me.delBtn.Text = "Delete"
        Me.delBtn.UseVisualStyleBackColor = True
        '
        'disBtn
        '
        Me.disBtn.Location = New System.Drawing.Point(302, 637)
        Me.disBtn.Name = "disBtn"
        Me.disBtn.Size = New System.Drawing.Size(139, 43)
        Me.disBtn.TabIndex = 20
        Me.disBtn.Text = "Display"
        Me.disBtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 646)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(267, 25)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Show Current Month Patients"
        '
        'PaperADataSet
        '
        Me.PaperADataSet.DataSetName = "PaperADataSet"
        Me.PaperADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaperADataSetBindingSource
        '
        Me.PaperADataSetBindingSource.DataSource = Me.PaperADataSet
        Me.PaperADataSetBindingSource.Position = 0
        '
        'PatientMasterBindingSource
        '
        Me.PatientMasterBindingSource.DataMember = "Patient_Master"
        Me.PatientMasterBindingSource.DataSource = Me.PaperADataSetBindingSource
        '
        'Patient_MasterTableAdapter
        '
        Me.Patient_MasterTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(576, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(573, 668)
        Me.DataGridView1.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(447, 637)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 43)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Refersh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 711)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.disBtn)
        Me.Controls.Add(Me.delBtn)
        Me.Controls.Add(Me.updBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.insBtn)
        Me.Controls.Add(Me.dNo)
        Me.Controls.Add(Me.DDate)
        Me.Controls.Add(Me.ADate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pNo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PaperADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaperADataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rNo As System.Windows.Forms.TextBox
    Friend WithEvents ADate As System.Windows.Forms.MonthCalendar
    Friend WithEvents DDate As System.Windows.Forms.MonthCalendar
    Friend WithEvents dNo As System.Windows.Forms.ComboBox
    Friend WithEvents insBtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents updBtn As System.Windows.Forms.Button
    Friend WithEvents delBtn As System.Windows.Forms.Button
    Friend WithEvents disBtn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PaperADataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaperADataSet As PaperA.PaperADataSet
    Friend WithEvents PatientMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Patient_MasterTableAdapter As PaperA.PaperADataSetTableAdapters.Patient_MasterTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
