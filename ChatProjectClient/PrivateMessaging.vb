Public Class PrivateMessaging
    Private Sub PrivateMessaging_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub MessageDisplay(txt As String)
        MsgListBox.AppendText(txt + Environment.NewLine)
        MsgListBox.ScrollToCaret()
    End Sub
    Private Sub sendBtn_Click(sender As Object, e As EventArgs) Handles sendBtn.Click
        Dim data As New XProtocol.XMessage(<privatemessage text=<%= txtBox.Text %> sender=<%= Form1.nameLabel.Text %> receiver=<%= Label1.Text %>/>)
        Form1.SendToServer(data, Form1.client)
        txtBox.Clear()
    End Sub
End Class