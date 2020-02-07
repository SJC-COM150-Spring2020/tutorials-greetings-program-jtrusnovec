Public Class greetings
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click

        'print Greetings to listbox
        lstOut.Items.Add("Good Evening " & txtName.Text)
        lstOut.Items.Add("How are you?")




    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear txtName value
        txtName.Clear()
        lstOut.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'when user exits the program
        Beep()
        Application.Exit()
    End Sub
End Class
