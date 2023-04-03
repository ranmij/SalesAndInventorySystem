Option Strict On
Imports BCrypt.Net.BCrypt
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SalesAndInventorySystem.UserDataSetTableAdapters

Module UserModule
    <TestClass()>
    Public Class UserModel
        Public user_id As Integer
        Public first_name As String
        Public last_name As String
        Public gender As String
        Public phone As String
        Public email As String
        Public username As String
        Public password As String
        <TestMethod>
        Public Function hello() As Boolean
            Return True
        End Function
    End Class

    <TestMethod()>
    Public Function IsAuthVerified(auth_code As String) As Boolean
        Debug.Assert(1 < 0)
        ' TODO Implement Sign In
        Return False
    End Function

    <TestMethod()>
    Public Function ChangePassword(new_password As String, user_id As String) As Boolean
        ' TODO Implement Sign In
        Return False
    End Function

    <TestMethod()>
    Public Function ForgotPassword() As Boolean
        ' TODO Implement Sign In
        Return True
    End Function

    <TestMethod()>
    Public Function Login(username As String, password As String) As Boolean
        ' TODO Implement Sign In
        Return False
    End Function

    <TestMethod()>
    Public Function SignIn(userData As UserModel) As Boolean
        Dim tableAdapter As New usersTableAdapter()
        With userData
            Dim hashedPassword As String = HashPassword(.password)
            Console.WriteLine(Len(hashedPassword))

            ' Check if there's an existing admin in the system.
            If tableAdapter.ScalarQueryUsers() = 0 Then
                If tableAdapter.InsertQueryAdmin(1, .first_name, .last_name, .gender, .phone, .email, .username, hashedPassword) <> 0 Then
                    Dim user_id As Integer = tableAdapter.GetDataByUsername(.username).Item(0).id
                    My.Settings.UserID = user_id
                    My.Settings.Save()
                    'MsgBox("Inserted") Maybe use other things
                    Return True
                Else
                    ' TODO Implement the on error sign up
                    MsgBox("Failed!")
                End If
            Else
                If tableAdapter.InsertQueryUser(.first_name, .last_name, .gender, .phone, .email, .username, hashedPassword) <> 0 Then
                    Dim user_id As Integer = tableAdapter.GetDataByUsername(.username).Item(0).id
                    My.Settings.UserID = user_id
                    My.Settings.Save()
                    MsgBox("Inserted")
                    Return True
                Else
                    ' TODO Implement the on error sign up
                    MsgBox("Failed!")
                End If
            End If

        End With
        Return False
    End Function

End Module
