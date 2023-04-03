<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogInForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInForm))
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogInButton = New Guna.UI2.WinForms.Guna2Button()
        Me.PasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UsernameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TopLoginPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.ActionBarPanel = New System.Windows.Forms.Panel()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.TopLoginLabel = New System.Windows.Forms.Label()
        Me.TopLoginPicture = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LogInFormStyle = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.MainPanel.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.TopLoginPanel.SuspendLayout()
        Me.ActionBarPanel.SuspendLayout()
        CType(Me.TopLoginPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackgroundImage = CType(resources.GetObject("MainPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainPanel.Controls.Add(Me.BottomPanel)
        Me.MainPanel.Controls.Add(Me.TopLoginPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(335, 464)
        Me.MainPanel.TabIndex = 0
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.Transparent
        Me.BottomPanel.Controls.Add(Me.Guna2HtmlLabel1)
        Me.BottomPanel.Controls.Add(Me.Label2)
        Me.BottomPanel.Controls.Add(Me.Guna2ImageButton1)
        Me.BottomPanel.Controls.Add(Me.Label1)
        Me.BottomPanel.Controls.Add(Me.Panel2)
        Me.BottomPanel.Controls.Add(Me.Panel1)
        Me.BottomPanel.Controls.Add(Me.LogInButton)
        Me.BottomPanel.Controls.Add(Me.PasswordTextBox)
        Me.BottomPanel.Controls.Add(Me.UsernameTextBox)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomPanel.Location = New System.Drawing.Point(0, 149)
        Me.BottomPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(335, 315)
        Me.BottomPanel.TabIndex = 4
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(58, 124)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(83, 15)
        Me.Guna2HtmlLabel1.TabIndex = 9
        Me.Guna2HtmlLabel1.Text = "Forgot password?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 256)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Create Account"
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.HoverState.Image = Global.SalesAndInventorySystem.My.Resources.Resources.facebook
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna2ImageButton1.Image = Global.SalesAndInventorySystem.My.Resources.Resources.facebook
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(148, 214)
        Me.Guna2ImageButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.Image = Global.SalesAndInventorySystem.My.Resources.Resources.facebook
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(34, 34)
        Me.Guna2ImageButton1.TabIndex = 7
        Me.Guna2ImageButton1.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 195)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "or"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(177, 202)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 1)
        Me.Panel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(58, 202)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 1)
        Me.Panel1.TabIndex = 3
        '
        'LogInButton
        '
        Me.LogInButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LogInButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LogInButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LogInButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LogInButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LogInButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInButton.ForeColor = System.Drawing.Color.White
        Me.LogInButton.Location = New System.Drawing.Point(58, 146)
        Me.LogInButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LogInButton.Name = "LogInButton"
        Me.LogInButton.Size = New System.Drawing.Size(219, 36)
        Me.LogInButton.TabIndex = 2
        Me.LogInButton.Text = "LOGIN"
        '
        'PasswordTextBox
        '
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
        Me.PasswordTextBox.IconRight = Global.SalesAndInventorySystem.My.Resources.Resources.hide_textbox_ic
        Me.PasswordTextBox.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.PasswordTextBox.IconRightSize = New System.Drawing.Size(16, 16)
        Me.PasswordTextBox.Location = New System.Drawing.Point(58, 83)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PasswordTextBox.PlaceholderText = "Password"
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.Size = New System.Drawing.Size(219, 36)
        Me.PasswordTextBox.TabIndex = 1
        '
        'UsernameTextBox
        '
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
        Me.UsernameTextBox.Location = New System.Drawing.Point(58, 37)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTextBox.PlaceholderText = "Username"
        Me.UsernameTextBox.SelectedText = ""
        Me.UsernameTextBox.Size = New System.Drawing.Size(219, 36)
        Me.UsernameTextBox.TabIndex = 0
        '
        'TopLoginPanel
        '
        Me.TopLoginPanel.BackColor = System.Drawing.Color.Transparent
        Me.TopLoginPanel.Controls.Add(Me.ActionBarPanel)
        Me.TopLoginPanel.Controls.Add(Me.TopLoginLabel)
        Me.TopLoginPanel.Controls.Add(Me.TopLoginPicture)
        Me.TopLoginPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopLoginPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopLoginPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.TopLoginPanel.Name = "TopLoginPanel"
        Me.TopLoginPanel.Size = New System.Drawing.Size(335, 149)
        Me.TopLoginPanel.TabIndex = 2
        '
        'ActionBarPanel
        '
        Me.ActionBarPanel.Controls.Add(Me.CloseButton)
        Me.ActionBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ActionBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.ActionBarPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ActionBarPanel.Name = "ActionBarPanel"
        Me.ActionBarPanel.Size = New System.Drawing.Size(335, 34)
        Me.ActionBarPanel.TabIndex = 3
        '
        'CloseButton
        '
        Me.CloseButton.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseButton.HoverState.Image = Global.SalesAndInventorySystem.My.Resources.Resources.close
        Me.CloseButton.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.CloseButton.Image = Global.SalesAndInventorySystem.My.Resources.Resources.close
        Me.CloseButton.ImageOffset = New System.Drawing.Point(0, 0)
        Me.CloseButton.ImageRotate = 0!
        Me.CloseButton.ImageSize = New System.Drawing.Size(16, 16)
        Me.CloseButton.Location = New System.Drawing.Point(296, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.PressedState.Image = Global.SalesAndInventorySystem.My.Resources.Resources.close
        Me.CloseButton.PressedState.ImageSize = New System.Drawing.Size(16, 16)
        Me.CloseButton.Size = New System.Drawing.Size(39, 34)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.UseTransparentBackground = True
        '
        'TopLoginLabel
        '
        Me.TopLoginLabel.AutoSize = True
        Me.TopLoginLabel.BackColor = System.Drawing.Color.Transparent
        Me.TopLoginLabel.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopLoginLabel.ForeColor = System.Drawing.Color.White
        Me.TopLoginLabel.Location = New System.Drawing.Point(42, 44)
        Me.TopLoginLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.TopLoginLabel.Name = "TopLoginLabel"
        Me.TopLoginLabel.Size = New System.Drawing.Size(158, 60)
        Me.TopLoginLabel.TabIndex = 0
        Me.TopLoginLabel.Text = "Already Have an" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Account?"
        '
        'TopLoginPicture
        '
        Me.TopLoginPicture.BackColor = System.Drawing.Color.Transparent
        Me.TopLoginPicture.FillColor = System.Drawing.Color.Transparent
        Me.TopLoginPicture.Image = CType(resources.GetObject("TopLoginPicture.Image"), System.Drawing.Image)
        Me.TopLoginPicture.ImageRotate = 0!
        Me.TopLoginPicture.Location = New System.Drawing.Point(241, 51)
        Me.TopLoginPicture.Margin = New System.Windows.Forms.Padding(0)
        Me.TopLoginPicture.Name = "TopLoginPicture"
        Me.TopLoginPicture.Size = New System.Drawing.Size(52, 47)
        Me.TopLoginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TopLoginPicture.TabIndex = 1
        Me.TopLoginPicture.TabStop = False
        '
        'LogInFormStyle
        '
        Me.LogInFormStyle.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER
        Me.LogInFormStyle.BorderRadius = 5
        Me.LogInFormStyle.ContainerControl = Me
        Me.LogInFormStyle.DockIndicatorTransparencyValue = 0.6R
        Me.LogInFormStyle.ResizeForm = False
        Me.LogInFormStyle.TransparentWhileDrag = True
        '
        'LogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 464)
        Me.Controls.Add(Me.MainPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LogInForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MainPanel.ResumeLayout(False)
        Me.BottomPanel.ResumeLayout(False)
        Me.BottomPanel.PerformLayout()
        Me.TopLoginPanel.ResumeLayout(False)
        Me.TopLoginPanel.PerformLayout()
        Me.ActionBarPanel.ResumeLayout(False)
        CType(Me.TopLoginPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents TopLoginLabel As Label
    Friend WithEvents TopLoginPicture As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TopLoginPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents LogInButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UsernameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LogInFormStyle As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label2 As Label
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents ActionBarPanel As Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
