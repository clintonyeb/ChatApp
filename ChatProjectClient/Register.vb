Imports System.Text.RegularExpressions
Imports System.Net.Mail
Public Class RegForm
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub RegForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = OK
        Me.CancelButton = Cancel
    End Sub


    'Private Sub fullnameTxtBox_Leave(sender As Object, e As EventArgs) Handles fullnameTxtBox.Leave
    '    If Not Regex.Match(fullnameTxtBox.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Or fullnameTxtBox.Text = Nothing Then
    '        errrorProvider.SetError(fullnameTxtBox, "Invalid Username")
    '    Else
    '        errrorProvider.Clear()
    '    End If
    'End Sub

    Private Sub UsernameTextBox_Leave(sender As Object, e As EventArgs) Handles UsernameTextBox.Leave
        If Not Regex.Match(UsernameTextBox.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Or UsernameTextBox.Text = Nothing Then
            errrorProvider.SetError(UsernameTextBox, "Invalid username")

        Else
            errrorProvider.Clear()
        End If
    End Sub

    Private Sub PasswordTextBox_Leave(sender As Object, e As EventArgs) Handles PasswordTextBox.Leave
        If PasswordTextBox.Text = Nothing Then
            errrorProvider.SetError(PasswordTextBox, "Cannot be left blank")
            PasswordTextBox.Text = Nothing
        Else
            errrorProvider.Clear()
        End If
    End Sub

    Private Sub ConPasswordTxtBox_Leave(sender As Object, e As EventArgs) Handles ConPasswordTxtBox.Leave
        If ConPasswordTxtBox.Text <> PasswordTextBox.Text Then
            errrorProvider.SetError(ConPasswordTxtBox, "Passwords do not match")
            ConPasswordTxtBox.Text = Nothing
        Else
            errrorProvider.Clear()
        End If
    End Sub

    Private Sub EmailTxtBox_Leave(sender As Object, e As EventArgs) Handles EmailTxtBox.Leave
        Try
            Dim txtAddress = New MailAddress(EmailTxtBox.Text)
            errrorProvider.Clear()
        Catch ex As Exception
            errrorProvider.SetError(EmailTxtBox, "Enter valid email")
        End Try

    End Sub
End Class
