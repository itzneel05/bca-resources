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
        Me.cmbBooks = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBookNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCopies = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDeleteNo = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbBooks
        '
        Me.cmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBooks.FormattingEnabled = True
        Me.cmbBooks.Location = New System.Drawing.Point(31, 41)
        Me.cmbBooks.Name = "cmbBooks"
        Me.cmbBooks.Size = New System.Drawing.Size(121, 33)
        Me.cmbBooks.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Book List :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Book Details :"
        '
        'txtBookNo
        '
        Me.txtBookNo.Location = New System.Drawing.Point(159, 124)
        Me.txtBookNo.Name = "txtBookNo"
        Me.txtBookNo.ReadOnly = True
        Me.txtBookNo.Size = New System.Drawing.Size(127, 30)
        Me.txtBookNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Book No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Author Name"
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(159, 160)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.ReadOnly = True
        Me.txtAuthor.Size = New System.Drawing.Size(127, 30)
        Me.txtAuthor.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Book Cost"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(159, 196)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.ReadOnly = True
        Me.txtCost.Size = New System.Drawing.Size(127, 30)
        Me.txtCost.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "No Of Copies"
        '
        'txtCopies
        '
        Me.txtCopies.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.txtCopies.Location = New System.Drawing.Point(159, 232)
        Me.txtCopies.Name = "txtCopies"
        Me.txtCopies.ReadOnly = True
        Me.txtCopies.Size = New System.Drawing.Size(127, 30)
        Me.txtCopies.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(182, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Book No"
        '
        'txtDeleteNo
        '
        Me.txtDeleteNo.Location = New System.Drawing.Point(275, 13)
        Me.txtDeleteNo.Name = "txtDeleteNo"
        Me.txtDeleteNo.Size = New System.Drawing.Size(127, 30)
        Me.txtDeleteNo.TabIndex = 11
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(231, 49)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(107, 34)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 307)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDeleteNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCopies)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBookNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbBooks)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbBooks As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBookNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCopies As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDeleteNo As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button

End Class
