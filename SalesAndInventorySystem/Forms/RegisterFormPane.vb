Public Class RegisterFormPane
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Me.Hide()
        RegisterFormPaneSecond.TopLevel = False
        RegisterFormPaneSecond.Size = RegisterForm.Size
        RegisterFormPaneSecond.Location = New System.Drawing.Point(0, 0)
        RegisterFormPaneSecond.WindowState = FormWindowState.Normal
        RegisterFormPaneSecond.Visible = True
        RegisterForm.MainPanel.Controls.Add(RegisterFormPaneSecond)
    End Sub
End Class