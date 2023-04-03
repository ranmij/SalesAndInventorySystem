<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterFormPaneSecond
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
        Me.components = New System.ComponentModel.Container()
        Me.RegisterFormPaneSecondStyle = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.ActionBarPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ImageButton2 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.UsernameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SignUpButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ActionBarPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegisterFormPaneSecondStyle
        '
        Me.RegisterFormPaneSecondStyle.AnimateWindow = True
        Me.RegisterFormPaneSecondStyle.ContainerControl = Me
        Me.RegisterFormPaneSecondStyle.DockIndicatorTransparencyValue = 0.6R
        Me.RegisterFormPaneSecondStyle.DragForm = False
        Me.RegisterFormPaneSecondStyle.ResizeForm = False
        Me.RegisterFormPaneSecondStyle.TransparentWhileDrag = True
        '
        'ActionBarPanel
        '
        Me.ActionBarPanel.Controls.Add(Me.Guna2ImageButton2)
        Me.ActionBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ActionBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.ActionBarPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ActionBarPanel.Name = "ActionBarPanel"
        Me.ActionBarPanel.Size = New System.Drawing.Size(335, 43)
        Me.ActionBarPanel.TabIndex = 9
        '
        'Guna2ImageButton2
        '
        Me.Guna2ImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton2.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ImageButton2.HoverState.Image = Global.SalesAndInventorySystem.My.Resources.Resources.close_p
        Me.Guna2ImageButton2.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.Guna2ImageButton2.Image = Global.SalesAndInventorySystem.My.Resources.Resources.close_p
        Me.Guna2ImageButton2.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton2.ImageRotate = 0!
        Me.Guna2ImageButton2.ImageSize = New System.Drawing.Size(16, 16)
        Me.Guna2ImageButton2.Location = New System.Drawing.Point(291, 0)
        Me.Guna2ImageButton2.Name = "Guna2ImageButton2"
        Me.Guna2ImageButton2.PressedState.Image = Global.SalesAndInventorySystem.My.Resources.Resources.close_p
        Me.Guna2ImageButton2.PressedState.ImageSize = New System.Drawing.Size(16, 16)
        Me.Guna2ImageButton2.Size = New System.Drawing.Size(44, 43)
        Me.Guna2ImageButton2.TabIndex = 9
        Me.Guna2ImageButton2.UseTransparentBackground = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.AutoRoundedCorners = True
        Me.UsernameTextBox.BorderRadius = 17
        Me.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTextBox.DefaultText = ""
        Me.UsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.UsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UsernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.UsernameTextBox.IconLeft = Global.SalesAndInventorySystem.My.Resources.Resources.user_textbox_ic
        Me.UsernameTextBox.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.UsernameTextBox.IconLeftSize = New System.Drawing.Size(16, 16)
        Me.UsernameTextBox.Location = New System.Drawing.Point(58, 160)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTextBox.PlaceholderText = "Username"
        Me.UsernameTextBox.SelectedText = ""
        Me.UsernameTextBox.Size = New System.Drawing.Size(219, 36)
        Me.UsernameTextBox.TabIndex = 10
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.AutoRoundedCorners = True
        Me.PasswordTextBox.BorderRadius = 17
        Me.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTextBox.DefaultText = ""
        Me.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.PasswordTextBox.IconLeft = Global.SalesAndInventorySystem.My.Resources.Resources.padlock
        Me.PasswordTextBox.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.PasswordTextBox.IconLeftSize = New System.Drawing.Size(16, 16)
        Me.PasswordTextBox.IconRight = Global.SalesAndInventorySystem.My.Resources.Resources.view_textbox_ic
        Me.PasswordTextBox.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.PasswordTextBox.IconRightSize = New System.Drawing.Size(16, 16)
        Me.PasswordTextBox.Location = New System.Drawing.Point(58, 214)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PasswordTextBox.PlaceholderText = "Password"
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.Size = New System.Drawing.Size(219, 36)
        Me.PasswordTextBox.TabIndex = 11
        '
        'SignUpButton
        '
        Me.SignUpButton.AutoRoundedCorners = True
        Me.SignUpButton.BorderRadius = 17
        Me.SignUpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SignUpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SignUpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SignUpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SignUpButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SignUpButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SignUpButton.ForeColor = System.Drawing.Color.White
        Me.SignUpButton.Location = New System.Drawing.Point(58, 268)
        Me.SignUpButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SignUpButton.Name = "SignUpButton"
        Me.SignUpButton.Size = New System.Drawing.Size(219, 36)
        Me.SignUpButton.TabIndex = 12
        Me.SignUpButton.Text = "SIGN UP"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(58, 66)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(141, 62)
        Me.Guna2HtmlLabel1.TabIndex = 13
        Me.Guna2HtmlLabel1.Text = "Start your <br>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "journey with us!"
        '
        'RegisterFormPaneSecond
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SalesAndInventorySystem.My.Resources.Resources.register_bg
        Me.ClientSize = New System.Drawing.Size(335, 464)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.SignUpButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.ActionBarPanel)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterFormPaneSecond"
        Me.Text = "RegisterFormPaneSecond1"
        Me.ActionBarPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegisterFormPaneSecondStyle As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents ActionBarPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ImageButton2 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents UsernameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents SignUpButton As Guna.UI2.WinForms.Guna2Button
End Class
