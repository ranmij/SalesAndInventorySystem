Option Strict On
Public Class RegisterFormPaneSecond

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        SignIn(New UserModel With {
            .first_name = RegisterFormPane.FirstNameTextBox.Text,
            .last_name = RegisterFormPane.LastNameTextBox.Text,
            .gender = RegisterFormPane.GenderComboBox.Text,
            .phone = RegisterFormPane.PhoneTextBox.Text,
            .email = RegisterFormPane.EmailTextBox.Text,
            .username = UsernameTextBox.Text,
            .password = PasswordTextBox.Text
        })
    End Sub
End Class