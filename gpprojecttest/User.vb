Public Class User
    Public strUserID As String
    Public strUsername As String
    Public strFName As String
    Public strLName As String

    Public Sub New(strUserID As String, strUsername As String, strFName As String, strLName As String)
        'initialize
        Me.strUserID = strUserID
        Me.strUsername = strUsername
        Me.strFName = strFName
        Me.strLName = strLName
    End Sub

End Class
