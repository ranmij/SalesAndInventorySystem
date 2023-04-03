<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
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
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.VersionCode = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.AutoSize = True
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.Location = New System.Drawing.Point(47, 108)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(402, 37)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "SALES AND INVENTORY SYSTEM"
        '
        'VersionCode
        '
        Me.VersionCode.AutoSize = True
        Me.VersionCode.BackColor = System.Drawing.Color.Transparent
        Me.VersionCode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionCode.Location = New System.Drawing.Point(451, 276)
        Me.VersionCode.Name = "VersionCode"
        Me.VersionCode.Size = New System.Drawing.Size(39, 13)
        Me.VersionCode.TabIndex = 1
        Me.VersionCode.Text = "v{0}.{1}"
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SalesAndInventorySystem.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(492, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.VersionCode)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents VersionCode As Label
End Class
