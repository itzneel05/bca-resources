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
        Me.YearText = New System.Windows.Forms.TextBox()
        Me.MonthText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateText = New System.Windows.Forms.TextBox()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'YearText
        '
        Me.YearText.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearText.Location = New System.Drawing.Point(114, 137)
        Me.YearText.Name = "YearText"
        Me.YearText.Size = New System.Drawing.Size(154, 34)
        Me.YearText.TabIndex = 18
        '
        'MonthText
        '
        Me.MonthText.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthText.Location = New System.Drawing.Point(114, 98)
        Me.MonthText.Name = "MonthText"
        Me.MonthText.Size = New System.Drawing.Size(154, 34)
        Me.MonthText.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 29)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 29)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Month"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Date"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(35, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 38)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Show Date"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateText
        '
        Me.DateText.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateText.Location = New System.Drawing.Point(114, 59)
        Me.DateText.Name = "DateText"
        Me.DateText.Size = New System.Drawing.Size(154, 34)
        Me.DateText.TabIndex = 12
        '
        'DTP
        '
        Me.DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.Location = New System.Drawing.Point(21, 12)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(234, 34)
        Me.DTP.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 259)
        Me.Controls.Add(Me.YearText)
        Me.Controls.Add(Me.MonthText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateText)
        Me.Controls.Add(Me.DTP)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents YearText As System.Windows.Forms.TextBox
    Friend WithEvents MonthText As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateText As System.Windows.Forms.TextBox
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker

End Class
