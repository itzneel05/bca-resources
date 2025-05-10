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
        Me.insBtn = New System.Windows.Forms.Button()
        Me.delBtn = New System.Windows.Forms.Button()
        Me.updBtn = New System.Windows.Forms.Button()
        Me.seaBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.refBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'insBtn
        '
        Me.insBtn.Location = New System.Drawing.Point(29, 148)
        Me.insBtn.Name = "insBtn"
        Me.insBtn.Size = New System.Drawing.Size(100, 45)
        Me.insBtn.TabIndex = 1
        Me.insBtn.Text = "Insert"
        Me.insBtn.UseVisualStyleBackColor = True
        '
        'delBtn
        '
        Me.delBtn.Location = New System.Drawing.Point(29, 199)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.Size = New System.Drawing.Size(100, 45)
        Me.delBtn.TabIndex = 2
        Me.delBtn.Text = "Delete"
        Me.delBtn.UseVisualStyleBackColor = True
        '
        'updBtn
        '
        Me.updBtn.Location = New System.Drawing.Point(29, 250)
        Me.updBtn.Name = "updBtn"
        Me.updBtn.Size = New System.Drawing.Size(100, 45)
        Me.updBtn.TabIndex = 3
        Me.updBtn.Text = "Update"
        Me.updBtn.UseVisualStyleBackColor = True
        '
        'seaBtn
        '
        Me.seaBtn.Location = New System.Drawing.Point(29, 301)
        Me.seaBtn.Name = "seaBtn"
        Me.seaBtn.Size = New System.Drawing.Size(100, 45)
        Me.seaBtn.TabIndex = 4
        Me.seaBtn.Text = "Search"
        Me.seaBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 38)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Actions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(385, 51)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "MDI Form - Books"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(186, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 38)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Records :-"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(156, 148)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(692, 269)
        Me.DataGridView1.TabIndex = 0
        '
        'refBtn
        '
        Me.refBtn.Location = New System.Drawing.Point(29, 352)
        Me.refBtn.Name = "refBtn"
        Me.refBtn.Size = New System.Drawing.Size(100, 45)
        Me.refBtn.TabIndex = 8
        Me.refBtn.Text = "Refresh"
        Me.refBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 445)
        Me.Controls.Add(Me.refBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.seaBtn)
        Me.Controls.Add(Me.updBtn)
        Me.Controls.Add(Me.delBtn)
        Me.Controls.Add(Me.insBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents insBtn As System.Windows.Forms.Button
    Friend WithEvents delBtn As System.Windows.Forms.Button
    Friend WithEvents updBtn As System.Windows.Forms.Button
    Friend WithEvents seaBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents refBtn As System.Windows.Forms.Button

End Class
