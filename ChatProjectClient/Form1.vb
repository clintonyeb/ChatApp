Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports System.Drawing.Imaging

Public Class Form1
    Dim portNo As Integer = 51001
    Public client As TcpClient = New TcpClient
    Private received As New List(Of Byte)
    Dim response As String
    Dim authen As Boolean = False
    Dim userName As String
    Dim publicImg As Image

    Private Sub MemDisplay(txt As String)

        My.Computer.Audio.Play(My.Resources.ClientResources.NewMember, AudioPlayMode.Background)
        onlineMembers.Items.Add(txt)
        onlineMembers.TopIndex = onlineMembers.Items.Count - 1
    End Sub

    Private Sub MessageDisplay(txt As String)
        My.Computer.Audio.Play(My.Resources.ClientResources.NewMessage, AudioPlayMode.Background)
        MsgDataGridView.Rows.Add(txt)
        MsgDataGridView.FirstDisplayedScrollingRowIndex = MsgDataGridView.Rows.Count - 1
    End Sub
    Private Async Function Connect() As Task

        toolStrip("Connecting...", 40)
        If client.Connected = False Then

            Try
                toolStrip("Server Unavailable")
                Await client.ConnectAsync(GetLocalIP, portNo) '192.168.1.40 '
                toolStrip("Connected!", 70)
                toolStrip("Connected!", 100)
                logInBtn.Enabled = True
                regBtn.Enabled = True
                My.Computer.Audio.Play(My.Resources.ClientResources.LogIn, AudioPlayMode.Background)
                If client.Connected Then
                    'get the client's data stream
                    Dim stream As NetworkStream = client.GetStream
                    'while the client is connected, continue to wait for and read data
                    While client.Connected
                        Dim buffer(client.ReceiveBufferSize - 1) As Byte
                        Dim read As Integer = Await stream.ReadAsync(buffer, 0, buffer.Length)
                        If read > 0 Then
                            received.AddRange(buffer.Take(read))
                            If XProtocol.XMessage.IsMessageComplete(received) Then
                                Dim message As XProtocol.XMessage = XProtocol.XMessage.FromByteArray(received.ToArray)
                                received.Clear()
                                Select Case message.Element.Name

                                    Case "textmessage"
                                        MessageDisplay(message.Element.@text)
                                        toolStrip("New Message")
                                        SetBalloonTip("New Message", message.Element.@text)

                                    Case "requiredregister"
                                        toolStrip("Verifying", 60)
                                        response = message.Element.@response
                                        If response = "0" Then
                                            toolStrip("registration success", 100)
                                        Else
                                            toolStrip("failed!", 100)
                                            My.Computer.Audio.Play(My.Resources.ClientResources._Error, AudioPlayMode.Background)
                                        End If

                                    Case "login"
                                        toolStrip("verifying", 50)
                                        response = message.Element.@response
                                        If response = "0" Then
                                            authen = True

                                            toolStrip("Success", 60)
                                            logInBtn.Visible = False
                                            picBtn.Enabled = True
                                            regBtn.Visible = False
                                            sendBtn.Enabled = True
                                            nameLabel.Text = userName
                                            txtBox.Focus()
                                            toolStrip("Success", 80)
                                            Dim data As New XProtocol.XMessage(<image/>)
                                            SendToServer(data, client)
                                        Else
                                            toolStrip("Failed", 80)
                                            My.Computer.Audio.Play(My.Resources.ClientResources._Error, AudioPlayMode.Background)
                                            toolStrip("Invalid credentials", 100)
                                            MsgBox("Failed: Invalid Credentials")
                                        End If

                                    Case "image"
                                        Dim img As Image = ConvertStringToImage(message.Element.@picture)
                                        If img IsNot Nothing Then
                                            profilePicBox.Image = img
                                            toolStrip("Welcome!", 100)

                                        End If

                                    Case "userjoin"
                                        MemDisplay(message.Element.@text)
                                        toolStrip("New Member")


                                    Case "profileview"
                                        toolStrip("Getting user Details", 40)
                                        Dim profileform As ClientInfo = New ClientInfo
                                        profileform.fullname.Text = message.Element.@fullname
                                        profileform.username.Text = message.Element.@username
                                        profileform.email.Text = message.Element.@email
                                        profileform.dob.Text = message.Element.@age
                                        profileform.joined.Text = message.Element.@firstlogin
                                        profileform.last.Text = message.Element.@lastlogin
                                        Dim img As Image = ConvertStringToImage(message.Element.@picture)
                                        toolStrip("Getting user Details", 60)
                                        If img IsNot Nothing Then
                                            profileform.PictureBox1.Image = img
                                        End If
                                        toolStrip("Getting user Details", 80)
                                        profileform.ShowDialog()
                                        toolStrip("Getting user Details", 100)

                                    Case "status"
                                        MemDisplay(message.Element.@option)

                                    Case "profilepicture"
                                        toolStrip("Verifing", 70)
                                        Dim mess As String = message.Element.@response
                                        If mess = "0" Then
                                            toolStrip("Success", 80)
                                            profilePicBox.Image = publicImg
                                            toolStrip("Success", 100)
                                        Else
                                            toolStrip("Failed", 100)
                                            My.Computer.Audio.Play(My.Resources.ClientResources._Error, AudioPlayMode.Background)
                                        End If

                                    Case "privatemessage"
                                        If PrivateMessaging.Visible = False Then
                                            Dim pm As PrivateMessaging = New PrivateMessaging
                                            pm.MessageDisplay(message.Element.@text)
                                        End If
                                End Select
                            End If
                        Else
                            'server terminated connection
                            toolStrip("server unavailable")
                            Exit While
                        End If
                    End While
                End If
            Catch odex As ObjectDisposedException
                'client terminated connection
                'activeBox.Text = "client unavailable"
            Catch ex As Exception
                client.Close()
            End Try
        End If
    End Function

    'helper method for getting local IPv4 address
    Private Function GetLocalIP() As IPAddress
        For Each adapter In NetworkInformation.NetworkInterface.GetAllNetworkInterfaces
            If adapter.OperationalStatus = NetworkInformation.OperationalStatus.Up AndAlso
                adapter.Supports(NetworkInformation.NetworkInterfaceComponent.IPv4) AndAlso
                adapter.NetworkInterfaceType <> NetworkInformation.NetworkInterfaceType.Loopback Then
                Dim props As NetworkInformation.IPInterfaceProperties = adapter.GetIPProperties
                For Each address In props.UnicastAddresses
                    If address.Address.AddressFamily = AddressFamily.InterNetwork Then Return address.Address
                Next
            End If
        Next
        Return IPAddress.None
    End Function

    Private Sub toolStrip(ByVal mess As String, val As Integer)
        Timer2.Stop()
        ToolStripProgressBar1.ForeColor = Color.Green
        ToolStripStatusLabel1.Text = mess
        ToolStripProgressBar1.Value = val
        Timer2.Start()
    End Sub

    Private Sub toolStrip(ByVal mess As String)
        Timer2.Stop()
        ToolStripProgressBar1.ForeColor = Color.Green
        ToolStripStatusLabel1.Text = mess
        ToolStripProgressBar1.Value = ToolStripProgressBar1.Value
        If mess = "Server Unavailable" Then
            Exit Sub
        End If
        Timer2.Start()
    End Sub

    Private Sub toolStrip(ByVal mess As String, ByVal col As String)
        Timer2.Stop()
        ToolStripProgressBar1.ForeColor = Color.Red
        ToolStripStatusLabel1.Text = mess
        ToolStripProgressBar1.Value = 100
        Timer2.Start()
    End Sub

    Dim szResult As String
    Dim img As Image
    Private Function BytesToHex(data As IEnumerable(Of Byte)) As String
        Dim result As New System.Text.StringBuilder
        For Each b In data
            result.Append(b.ToString("X2"))
        Next
        Return result.ToString
    End Function

    Private Function HexToBytes(hexString As String) As IEnumerable(Of Byte)
        Dim result As New List(Of Byte)
        For i As Integer = 0 To hexString.Length - 1 Step 2
            result.Add(Convert.ToByte(hexString.Substring(i, 2), 16))
        Next
        Return result.AsEnumerable
    End Function
    Public Function ConvertImageToString(ByVal value As Image) As String
        If value Is Nothing Then Return ""
        Dim ms As New MemoryStream
        value.Save(ms, ImageFormat.Jpeg)
        ms.Flush()
        ms.Position = 0
        Dim buffer = ms.ToArray
        szResult = BytesToHex(buffer)
        Return szResult
    End Function

    Dim imge As Image
    Public Function ConvertStringToImage(ByVal imageEncodedString As String) As Image
        If String.IsNullOrEmpty(imageEncodedString) Then Return Nothing
        Dim buffer = HexToBytes(imageEncodedString)
        Dim mem As New MemoryStream(buffer.ToArray)
        mem.Position = 0
        img = Image.FromStream(mem)
        imge = img
        Return imge
    End Function

    Public Async Sub SendToServer(ByVal data As XProtocol.XMessage, client As TcpClient)
        Try
            Dim stream As NetworkStream = client.GetStream
            Dim buffer() As Byte = data.ToByteArray
            Await stream.WriteAsync(buffer, 0, buffer.Length)
        Catch ioex As System.IO.IOException
            'server terminated connection
            toolStrip("Server Unavailable")
        Catch odex As ObjectDisposedException
            'client terminated connection
            toolStrip("Exited")
        Catch ex As Exception
            'unknown error occured
            toolStrip("Unknown Error occured")
        End Try
    End Sub

    Public Sub Register()
        Dim regfrm As RegForm = New RegForm()
        If regfrm.ShowDialog = DialogResult.OK Then
            Dim data As New XProtocol.XMessage(<requiredregister fullname=<%= regfrm.fullnameTxtBox.Text %> username=<%= regfrm.UsernameTextBox.Text %>
                                                   password=<%= regfrm.PasswordTextBox.Text %> email=<%= regfrm.EmailTxtBox.Text %>/>)
            ToolStripStatusLabel1.Text = "Sending Details"
            ToolStripProgressBar1.Value = 20
            SendToServer(data, client)
            ToolStripStatusLabel1.Text = "Sent"
            ToolStripProgressBar1.Value = 40
        End If
    End Sub

    Public Sub LogIn()
        Dim log As LoginForm = New LoginForm()
        If log.ShowDialog = DialogResult.OK Then
            userName = log.UsernameTextBox.Text
            Dim data As New XProtocol.XMessage(<login username=<%= log.UsernameTextBox.Text %> password=<%= log.PasswordTextBox.Text %>/>)
            toolStrip("Sending Detaisl", 20)
            SendToServer(data, client)
            toolStrip("Sent", 40)
        End If
    End Sub

    Private Sub SetBalloonTip(title As String, text As String)
        If Me.Visible = False Then
            NotifyIcon1.BalloonTipTitle = title
            NotifyIcon1.BalloonTipText = text
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(30000)
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolStripStatusLabel2.Text = DateTime.Now()
        sendBtn.Enabled = False
        NotifyIcon1.ContextMenuStrip = ContextMenuStrip1
        OpenToolStripMenuItem.Text = "&Hide"
        MsgDataGridView.ColumnCount = 1
        MsgDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        MsgDataGridView.Columns(0).Name = "Messages"
    End Sub


    Private Async Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        toolStrip("Connecting...", 10)
        Await Connect()
    End Sub

    Private m_CloseOk As Boolean = False
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Not m_CloseOk Then
            e.Cancel = True
            Me.Hide()
            OpenToolStripMenuItem.Text = "&Show"
            NotifyIcon1.Visible = True
            SetBalloonTip("Notification", "TonChat is running in the background")
        Else
            toolStrip("Exiting app")
            My.Computer.Audio.Play(My.Resources.ClientResources.LogIn, AudioPlayMode.WaitToComplete)
        End If
    End Sub

    Private Sub NotifyIcon_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        If Me.Visible Then
            ' We're visible. Hide.
            Me.Hide()
            OpenToolStripMenuItem.Text = "&Show"
        Else
            Me.Show()
            OpenToolStripMenuItem.Text = "&Hide"
        End If
    End Sub


    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If Me.Visible Then
            Me.Hide()
            OpenToolStripMenuItem.Text = "&Show"
        Else
            Me.Show()
            OpenToolStripMenuItem.Text = "&Hide"
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        m_CloseOk = True
        Me.Close()
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        Me.Show()
        NotifyIcon1.Visible = True
        OpenToolStripMenuItem.Text = "&Hide"
    End Sub

    Private Sub sendBtn_Click(sender As Object, e As EventArgs) Handles sendBtn.Click
        If client IsNot Nothing And client.Connected And txtBox.Text <> Nothing And txtBox.Text <> "Type a Message..." Then
            Dim data As New XProtocol.XMessage(<textmessage text=<%= txtBox.Text %>/>)
            toolStrip("Sending message", 40)
            SendToServer(data, client)
            toolStrip("Sent!", 100)
            txtBox.Clear()
        End If
    End Sub

    Private Sub reglabel_Click(sender As Object, e As EventArgs) Handles regBtn.Click
        Register()
    End Sub

    Private Sub logInLabel_Click(sender As Object, e As EventArgs) Handles logInBtn.Click
        If logInBtn.Text = "Login" Then
            LogIn()
        Else
            toolStrip("Logging out", 20)
            Dim data As New XProtocol.XMessage(<status option=<%= "offline" %>/>)
            toolStrip("Logging out", 40)
            SendToServer(data, client)
            toolStrip("Logging out", 60)
            logInBtn.Text = "Login"
            sendBtn.Enabled = False
            onlineMembers.Items.Clear()
            toolStrip("Offline")
        End If
    End Sub

    Private Sub onlineMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles onlineMembers.SelectedIndexChanged
        Try

            Dim currentString As String = onlineMembers.SelectedItem.ToString
            toolStrip("Getting user Details", 10)
            Dim userNameArray() As String = currentString.Split(" ")
            Dim userName As String = userNameArray(0)
            toolStrip("Getting user Details", 20)
            Dim data As New XProtocol.XMessage(<profileview user=<%= userName %>/>)
            SendToServer(data, client)
            toolStrip("Getting user Details", 30)
            onlineMembers.SelectedItem = Nothing
        Catch ex As Exception
            'no item selected
        End Try
    End Sub

    Private Sub picBtn_Click(sender As Object, e As EventArgs) Handles picBtn.Click
        Try
            OpenFileDialog1.Filter = "Image Files|*.gif;*.jpg;*.png;*.bmp"
            OpenFileDialog1.ShowDialog()
            Dim crop As Dialog1 = New Dialog1
            crop.PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            If crop.ShowDialog = DialogResult.OK Then
                toolStrip("Sending to server", 20)
                Dim imgString As String = ConvertImageToString(crop.PictureBox1.Image)
                Dim data As New XProtocol.XMessage(<profilepicture picture=<%= imgString %>/>)
                toolStrip("Sending to server", 40)
                SendToServer(data, client)
                toolStrip("Sent", 60)
                publicImg = crop.PictureBox1.Image
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBox_Click(sender As Object, e As EventArgs) Handles txtBox.Click
        If txtBox.Text = "Type a Message..." Then
            txtBox.Clear()
            AcceptButton = sendBtn
        End If
    End Sub


    Private Sub txtBox_LostFocus(sender As Object, e As EventArgs) Handles txtBox.LostFocus
        If txtBox.Text = "" Then
            txtBox.Text = "Type a Message..."
            AcceptButton = Nothing
        End If
    End Sub

    Private Sub onlineMembers_Enter(sender As Object, e As EventArgs) Handles onlineMembers.Enter
        ToolTip1.SetToolTip(onlineMembers, "click to see user details")
    End Sub

    Private Sub onlineMembers_MouseHover(sender As Object, e As EventArgs) Handles onlineMembers.MouseHover
        ToolTip1.SetToolTip(onlineMembers, "click to see user details")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles profilePicBox.Click
        Dim viewPic As ImageVeiw = New ImageVeiw
        viewPic.PictureBox1.Image = profilePicBox.Image
        viewPic.ShowDialog()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles profilePicBox.MouseEnter
        ToolTip1.SetToolTip(profilePicBox, "click to view profile picture")
    End Sub

    Private Sub PictureBox1_Enter(sender As Object, e As EventArgs) Handles profilePicBox.Enter
        ToolTip1.SetToolTip(profilePicBox, "click to view profile picture")
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles profilePicBox.MouseHover
        ToolTip1.SetToolTip(profilePicBox, "click to view profile picture")
    End Sub

    Private Sub onlineMembers_MouseEnter(sender As Object, e As EventArgs) Handles onlineMembers.MouseEnter
        ToolTip1.SetToolTip(onlineMembers, "click to see user details")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ToolStripStatusLabel2.Text = DateTime.Now()
    End Sub

    Private Sub txtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBox.KeyPress
        toolStrip("Typing...")
        If txtBox.Text = "Type a Message..." Then
            txtBox.Clear()
            AcceptButton = sendBtn
        End If
    End Sub

    Private Sub txtBox_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBox.KeyUp
        toolStrip("")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        toolStrip("waiting for you")
    End Sub
End Class
