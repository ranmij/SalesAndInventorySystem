<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterFormPane
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
        Me.RegisterFormPaneStyle = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.SignUpLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.FirstNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LastNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.EmailTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PhoneTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GenderComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.NextButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ActionBarPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ImageButton2 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.ToolTipHelper = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.ActionBarPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegisterFormPaneStyle
        '
        Me.RegisterFormPaneStyle.ContainerControl = Me
        Me.RegisterFormPaneStyle.DockIndicatorTransparencyValue = 0.6R
        Me.RegisterFormPaneStyle.DragForm = False
        Me.RegisterFormPaneStyle.ResizeForm = False
        Me.RegisterFormPaneStyle.TransparentWhileDrag = True
        '
        'SignUpLabel
        '
        Me.SignUpLabel.BackColor = System.Drawing.Color.Transparent
        Me.SignUpLabel.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUpLabel.Location = New System.Drawing.Point(49, 74)
        Me.SignUpLabel.Name = "SignUpLabel"
        Me.SignUpLabel.Size = New System.Drawing.Size(153, 23)
        Me.SignUpLabel.TabIndex = 0
        Me.SignUpLabel.Text = "Create a new account."
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstNameTextBox.DefaultText = ""
        Me.FirstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FirstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FirstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FirstNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(49, 114)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirstNameTextBox.PlaceholderText = "First Name"
        Me.FirstNameTextBox.SelectedText = ""
        Me.FirstNameTextBox.Size = New System.Drawing.Size(110, 36)
        Me.FirstNameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.FirstNameTextBox.TabIndex = 1
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastNameTextBox.DefaultText = ""
        Me.LastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LastNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LastNameTextBox.Location = New System.Drawing.Point(176, 114)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LastNameTextBox.PlaceholderText = "Last Name"
        Me.LastNameTextBox.SelectedText = ""
        Me.LastNameTextBox.Size = New System.Drawing.Size(110, 36)
        Me.LastNameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.LastNameTextBox.TabIndex = 2
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmailTextBox.DefaultText = ""
        Me.EmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.EmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.EmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.EmailTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.EmailTextBox.Location = New System.Drawing.Point(49, 170)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailTextBox.PlaceholderText = "Email"
        Me.EmailTextBox.SelectedText = ""
        Me.EmailTextBox.Size = New System.Drawing.Size(237, 36)
        Me.EmailTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.EmailTextBox.TabIndex = 3
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PhoneTextBox.DefaultText = ""
        Me.PhoneTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PhoneTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PhoneTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PhoneTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PhoneTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PhoneTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.PhoneTextBox.Location = New System.Drawing.Point(49, 218)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PhoneTextBox.PlaceholderText = "Phone"
        Me.PhoneTextBox.SelectedText = ""
        Me.PhoneTextBox.Size = New System.Drawing.Size(237, 36)
        Me.PhoneTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.PhoneTextBox.TabIndex = 4
        '
        'GenderComboBox
        '
        Me.GenderComboBox.BackColor = System.Drawing.Color.Transparent
        Me.GenderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GenderComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GenderComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GenderComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GenderComboBox.ItemHeight = 30
        Me.GenderComboBox.Items.AddRange(New Object() {"M", "F"})
        Me.GenderComboBox.Location = New System.Drawing.Point(49, 266)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(237, 36)
        Me.GenderComboBox.TabIndex = 5
        '
        'NextButton
        '
        Me.NextButton.AutoRoundedCorners = True
        Me.NextButton.BackColor = System.Drawing.Color.Transparent
        Me.NextButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.NextButton.BorderRadius = 17
        Me.NextButton.BorderThickness = 1
        Me.NextButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.NextButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.NextButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.NextButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.NextButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.NextButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NextButton.ForeColor = System.Drawing.Color.White
        Me.NextButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.NextButton.HoverState.FillColor = System.Drawing.Color.White
        Me.NextButton.HoverState.ForeColor = System.Drawing.Color.Black
        Me.NextButton.Location = New System.Drawing.Point(49, 314)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(237, 36)
        Me.NextButton.TabIndex = 6
        Me.NextButton.Text = "Next"
        Me.NextButton.UseTransparentBackground = True
        '
        'ActionBarPanel
        '
        Me.ActionBarPanel.Controls.Add(Me.Guna2ImageButton2)
        Me.ActionBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ActionBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.ActionBarPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ActionBarPanel.Name = "ActionBarPanel"
        Me.ActionBarPanel.Size = New System.Drawing.Size(335, 43)
        Me.ActionBarPanel.TabIndex = 8
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
        'ToolTipHelper
        '
        Me.ToolTipHelper.AllowLinksHandling = True
        Me.ToolTipHelper.AutoPopDelay = 500
        Me.ToolTipHelper.InitialDelay = 500
        Me.ToolTipHelper.IsBalloon = True
        Me.ToolTipHelper.MaximumSize = New System.Drawing.Size(0, 0)
        Me.ToolTipHelper.ReshowDelay = 100
        Me.ToolTipHelper.ShowAlways = True
        '
        'RegisterFormPane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SalesAndInventorySystem.My.Resources.Resources.register_bg
        Me.ClientSize = New System.Drawing.Size(335, 464)
        Me.Controls.Add(Me.ActionBarPanel)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.SignUpLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RegisterFormPane"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ActionBarPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegisterFormPaneStyle As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents FirstNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SignUpLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GenderComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents PhoneTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents EmailTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LastNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NextButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ActionBarPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ImageButton2 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents ToolTipHelper As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
