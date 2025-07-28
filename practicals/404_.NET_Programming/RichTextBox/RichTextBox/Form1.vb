Public Class Form1

    ' Event handler for the Bold button click
    Private Sub Bold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bold.Click
        ' Check if some text is selected in the RichTextBox
        If RichTextBox1.SelectionFont IsNot Nothing Then
            ' Get the current font of the selected text
            Dim currentFont As Font = RichTextBox1.SelectionFont
            ' Apply bold style to the selected text
            RichTextBox1.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold)
        End If
    End Sub

    ' Event handler for the Italic button click
    Private Sub Italic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Italic.Click
        ' Check if some text is selected in the RichTextBox
        If RichTextBox1.SelectionFont IsNot Nothing Then
            ' Get the current font of the selected text
            Dim currentFont As Font = RichTextBox1.SelectionFont
            ' Apply italic style to the selected text
            RichTextBox1.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Italic)
        End If
    End Sub

    ' Event handler for the Underline button click
    Private Sub Underline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Underline.Click
        ' Check if some text is selected in the RichTextBox
        If RichTextBox1.SelectionFont IsNot Nothing Then
            ' Get the current font of the selected text
            Dim currentFont As Font = RichTextBox1.SelectionFont
            ' Apply underline style to the selected text
            RichTextBox1.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Underline)
        End If
    End Sub

    ' Event handler for when the form loads
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form window
        Me.Text = "Rich Text Box"
    End Sub

End Class
