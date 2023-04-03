Option Strict On
Public Class RegisterForm
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RegisterFormPane.TopLevel = False
        RegisterFormPane.Size = Me.Size
        RegisterFormPane.Location = New System.Drawing.Point(0, 0)
        RegisterFormPane.WindowState = FormWindowState.Normal
        RegisterFormPane.Visible = True
        MainPanel.Controls.Add(RegisterFormPane)
    End Sub

End Class