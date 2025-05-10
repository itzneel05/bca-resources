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
        Me.Underline = New System.Windows.Forms.Button()
        Me.Italic = New System.Windows.Forms.Button()
        Me.Bold = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Underline
        '
        Me.Underline.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Underline.Location = New System.Drawing.Point(208, 27)
        Me.Underline.Name = "Underline"
        Me.Underline.Size = New System.Drawing.Size(93, 36)
        Me.Underline.TabIndex = 7
        Me.Underline.Text = "Underline"
        Me.Underline.UseVisualStyleBackColor = True
        '
        'Italic
        '
        Me.Italic.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Italic.Location = New System.Drawing.Point(120, 27)
        Me.Italic.Name = "Italic"
        Me.Italic.Size = New System.Drawing.Size(77, 36)
        Me.Italic.TabIndex = 6
        Me.Italic.Text = "Italic"
        Me.Italic.UseVisualStyleBackColor = True
        '
        'Bold
        '
        Me.Bold.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bold.Location = New System.Drawing.Point(32, 27)
        Me.Bold.Name = "Bold"
        Me.Bold.Size = New System.Drawing.Size(77, 36)
        Me.Bold.TabIndex = 5
        Me.Bold.Text = "Bold"
        Me.Bold.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(32, 69)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(269, 144)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 260)
        Me.Controls.Add(Me.Underline)
        Me.Controls.Add(Me.Italic)
        Me.Controls.Add(Me.Bold)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Underline As System.Windows.Forms.Button
    Friend WithEvents Italic As System.Windows.Forms.Button
    Friend WithEvents Bold As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox

End Class
