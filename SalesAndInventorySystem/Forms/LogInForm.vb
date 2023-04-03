Option Strict On

Public Class LogInForm

    Private Sub LogInForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub Texbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress, PasswordTextBox.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) AndAlso sender.Equals(UsernameTextBox) Then
            PasswordTextBox.Focus()
        ElseIf e.KeyChar = Convert.ToChar(Keys.Enter) AndAlso sender.Equals(PasswordTextBox) Then
            'LogIn(UsernameTextBox.Text, PasswordTextBox.Text)
            Me.Hide()
            RegisterForm.Show()
        End If
    End Sub

    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        Me.Hide()
        RegisterForm.Show()
        'LogIn(UsernameTextBox.Text, PasswordTextBox.Text)
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class