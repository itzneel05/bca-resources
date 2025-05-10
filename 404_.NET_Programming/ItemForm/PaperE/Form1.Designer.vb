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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.iName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.iNo = New System.Windows.Forms.TextBox()
        Me.iRate = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.newBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.delBtn = New System.Windows.Forms.Button()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.refBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(248, 44)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Master Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Item Name"
        '
        'iName
        '
        Me.iName.Location = New System.Drawing.Point(148, 136)
        Me.iName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.iName.Name = "iName"
        Me.iName.Size = New System.Drawing.Size(167, 30)
        Me.iName.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Item No"
        '
        'iNo
        '
        Me.iNo.Location = New System.Drawing.Point(148, 89)
        Me.iNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.iNo.Name = "iNo"
        Me.iNo.Size = New System.Drawing.Size(167, 30)
        Me.iNo.TabIndex = 17
        '
        'iRate
        '
        Me.iRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.iRate.FormattingEnabled = True
        Me.iRate.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.iRate.Location = New System.Drawing.Point(148, 187)
        Me.iRate.Name = "iRate"
        Me.iRate.Size = New System.Drawing.Size(167, 33)
        Me.iRate.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 190)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Rate"
        '
        'newBtn
        '
        Me.newBtn.Location = New System.Drawing.Point(31, 244)
        Me.newBtn.Name = "newBtn"
        Me.newBtn.Size = New System.Drawing.Size(87, 43)
        Me.newBtn.TabIndex = 24
        Me.newBtn.Text = "New"
        Me.newBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(124, 244)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(87, 43)
        Me.saveBtn.TabIndex = 26
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'delBtn
        '
        Me.delBtn.Location = New System.Drawing.Point(217, 244)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.Size = New System.Drawing.Size(87, 43)
        Me.delBtn.TabIndex = 27
        Me.delBtn.Text = "Del"
        Me.delBtn.UseVisualStyleBackColor = True
        '
        'searchBtn
        '
        Me.searchBtn.Location = New System.Drawing.Point(336, 85)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(87, 43)
        Me.searchBtn.TabIndex = 28
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(310, 244)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(87, 43)
        Me.exitBtn.TabIndex = 29
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 309)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(420, 358)
        Me.DataGridView1.TabIndex = 30
        '
        'refBtn
        '
        Me.refBtn.Location = New System.Drawing.Point(336, 134)
        Me.refBtn.Name = "refBtn"
        Me.refBtn.Size = New System.Drawing.Size(87, 43)
        Me.refBtn.TabIndex = 31
        Me.refBtn.Text = "Reload"
        Me.refBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 679)
        Me.Controls.Add(Me.refBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.delBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.newBtn)
        Me.Controls.Add(Me.iRate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.iName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.iNo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents iName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents iNo As System.Windows.Forms.TextBox
    Friend WithEvents iRate As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents newBtn As System.Windows.Forms.Button
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents delBtn As System.Windows.Forms.Button
    Friend WithEvents searchBtn As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents refBtn As System.Windows.Forms.Button

End Class
