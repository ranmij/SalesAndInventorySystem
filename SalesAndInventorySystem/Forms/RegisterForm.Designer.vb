<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
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
        Me.RegisterFormStyle = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.SuspendLayout()
        '
        'RegisterFormStyle
        '
        Me.RegisterFormStyle.BorderRadius = 5
        Me.RegisterFormStyle.ContainerControl = Me
        Me.RegisterFormStyle.DockIndicatorTransparencyValue = 0.6R
        Me.RegisterFormStyle.TransparentWhileDrag = True
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(335, 464)
        Me.MainPanel.TabIndex = 0
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(335, 464)
        Me.Controls.Add(Me.MainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RegisterFormStyle As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
End Class
