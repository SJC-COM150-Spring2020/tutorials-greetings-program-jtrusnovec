Public Class greetings
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click

        'take value from name textbox and print in messagebox
        'MessageBox.Show(txtName.Text)

        'take value from name textbox and print to txtOut
        txtOut.Text = "Good Evening " & txtName.Text & ControlChars.CrLf
        txtOut.Text = txtOut.Text & " How are you?"

        'clear txtName value
        txtName.Clear()

    End Sub
End Class
