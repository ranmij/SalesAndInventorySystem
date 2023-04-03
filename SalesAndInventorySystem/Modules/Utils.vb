Imports System.Text.RegularExpressions
Imports SalesAndInventorySystem.UserDataSetTableAdapters

Module Utils
    Public FIRST_FORM_PANE As Form = New RegisterFormPane
    Public SECOND_FORM_PANE As Form = New RegisterFormPaneSecond

    Public Function RandomAuthString() As String
        Return Nothing
    End Function

    Public Function IsValidUserName(username As String) As Boolean
        Dim tableAdapter As New usersTableAdapter
        Dim isNotExisting As Boolean = tableAdapter.ScalarQueryDuplicateUsername(username) <> 0
        Dim isValid As Boolean = Not Regex.IsMatch(username, "[^a-zA-Z0-9_]+")
        If isNotExisting AndAlso isValid Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function IsValidEmail(email As String) As Boolean
        If Regex.IsMatch(email, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
            Return True
        Else
            Return False
        End If
    End Function

End Module
