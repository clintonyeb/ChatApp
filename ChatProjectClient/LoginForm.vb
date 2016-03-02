Imports System.Text.RegularExpressions
Public Class LoginForm
    Dim UserBool As Boolean = False
    Dim PassBool As Boolean = False
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Form1.Register()
    End Sub


    Private Sub UsernameTextBox_Leave(sender As Object, e As EventArgs) Handles UsernameTextBox.Leave
        If Not Regex.Match(UsernameTextBox.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Or UsernameTextBox.Text = Nothing Then
            nameErrorProvider.SetError(UsernameTextBox, "Invalid username")
        Else
            nameErrorProvider.Clear()
            UserBool = True
        End If

    End Sub

    Private Sub PasswordTextBox_Leave(sender As Object, e As EventArgs) Handles PasswordTextBox.Leave
        If PasswordTextBox.Text = Nothing Then
            nameErrorProvider.SetError(PasswordTextBox, "Cannot be left blank")
            PasswordTextBox.Text = Nothing
        Else
            nameErrorProvider.Clear()
            PassBool = True
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If PasswordTextBox.Text <> Nothing And UserBool Then
            OK.Visible = True
        Else
            OK.Visible = False
        End If

    End Sub

    Private Sub UsernameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        If UsernameTextBox.Text <> Nothing And PassBool Then
            OK.Visible = True
        Else
            OK.Visible = False
        End If
    End Sub
End Class
