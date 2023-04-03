

Public NotInheritable Class SplashScreen

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        VersionCode.Text = System.String.Format(VersionCode.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
    End Sub

End Class
