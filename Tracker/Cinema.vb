Public Class Cinema

    Public Sub open()
        Me.Height = My.Computer.Screen.Bounds.Size.Height
        Me.Width = My.Computer.Screen.Bounds.Size.Width
        RichTextBox1.Size = Me.Size
        RichTextBox1.Text = Index.txtNoteBox.Text
        Label2.Text = System.DateTime.Now.ToLongTimeString
        Me.Show()

    End Sub

    Private Sub RichTextBox1_Click(sender As Object, e As EventArgs) Handles RichTextBox1.DoubleClick
        Index.txtNoteBox.Text = RichTextBox1.Text
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = System.DateTime.Now.ToLongTimeString
    End Sub
End Class