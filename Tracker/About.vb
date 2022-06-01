Public Class About



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not Button1.BackColor = Color.Red Then

            Button1.Text = "Fuck you, close it yourself you lazy prick."
            Button1.BackColor = Color.Red

        Else
            Button1.Hide()
        End If
    End Sub
End Class