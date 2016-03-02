Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.ComponentModel

Public Class Form1
    Private portNo As Integer = 51001
    Public clients As AllClients
    Private listener As TcpListener
    Private tokenSource As New CancellationTokenSource
    Private clientsTaskList As New List(Of Task)
    Private Shared aTimer As Timers.Timer
    Private Delegate Sub notifyInvoker(txt As String)
    Dim updating As New notifyInvoker(AddressOf UpDateTxtbox)
    Dim dataToClients As String = Nothing
    Public dict As New Hashtable

    Public Sub AddingToDictionary(keys, values)
        dict.Add(keys, values)
    End Sub
    Public Sub RemovingfromDictionary(keys)
        dict.Remove(keys)
    End Sub
    Private Sub UpDateTxtbox(txt As String)
        txtBoxNoti.Text = txt
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clientBindSource.DataSource = clients
        onlineMembersBox.DataSource = clientBindSource
        dict.Clear()
    End Sub

    Private Async Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start" Then
            tokenSource = New CancellationTokenSource
            listener = New TcpListener(IPAddress.Any, portNo)
            listener.Start()
            btnStart.Text = "Stop"
            txtBoxNoti.Text = "Server Started"
            While True
                Try
                    Dim clientSocket As TcpClient = Await listener.AcceptTcpClientAsync
                    txtBoxNoti.Text = "New Connection"
                    Dim client As New Client(clientSocket)
                    'dict.Add(client.id, client)
                    labelOnlineMemFig.Text = labelOnlineMemFig.Text + 1
                    clientBindSource.Add(client)
                    client.task = performClientOperations(client, tokenSource.Token)
                    clientsTaskList.Add(client.task)
                Catch odex As ObjectDisposedException
                    'listener stopped
                    Exit While
                End Try
            End While
            Try
                For i As Integer = clients.Count - 1 To 0 Step -1
                    clients(i).tcpClient.Close()
                Next
                Await Task.WhenAll(clientsTaskList)
                tokenSource.Dispose()
                btnStart.Text = "Start"
            Catch ex As Exception

            End Try
        Else
            tokenSource.Cancel()
            listener.Stop()
            btnStart.Text = "Start"
            txtBoxNoti.Text = "Server Closed"
        End If
    End Sub

    Public Async Function SendingToClients(ByVal data As XProtocol.XMessage, client As Client) As Task
        For Each d In dict
            Dim cl As Client = d.Value
            Dim stream As NetworkStream = cl.tcpClient.GetStream
            Dim buffer() As Byte = data.ToByteArray
            Await stream.WriteAsync(buffer, 0, buffer.Length)
        Next

    End Function

    Public Async Function SendToSender(ByVal data As XProtocol.XMessage, client As Client) As Task
        Dim stream As NetworkStream = client.tcpClient.GetStream
        Dim buffer() As Byte = data.ToByteArray
        Await stream.WriteAsync(buffer, 0, buffer.Length)
    End Function

    Public Async Function FromSenderToReceiver(ByVal data As XProtocol.XMessage, client As Client, receiver As Client) As Task
        Dim stream As NetworkStream = receiver.tcpClient.GetStream
        Dim buffer() As Byte = data.ToByteArray
        Await stream.WriteAsync(buffer, 0, buffer.Length)
    End Function

    Private Async Function performClientOperations(client As Client, canceltoken As CancellationToken) As Task
        Try
            'begin reading from the client's data stream
            Using stream As NetworkStream = client.tcpClient.GetStream
                Dim buffer(client.tcpClient.ReceiveBufferSize - 1) As Byte
                Dim read As Integer = 1
                While read > 0
                    read = Await stream.ReadAsync(buffer, 0, buffer.Length, canceltoken)
                    Await client.DataReceived(buffer, read, Me)
                End While
                'client closed his connection

            End Using
        Catch ocex As OperationCanceledException
        Catch odex As ObjectDisposedException
            'server disconnected client while reading
        Catch ioex As IOException
            'client connection stopped whiles reading
        Finally
            labelOnlineMemFig.Text = labelOnlineMemFig.Text - 1
            client.tcpClient.Close()
            RemovingfromDictionary(client.clientName)
            Dim data As New XProtocol.XMessage(<status option=<%= client.clientName + " is offline" %>/>)
            SendingToClients(data, client)
            clientBindSource.Remove(client)
            'remove the client's task from the list of running tasks
            clientsTaskList.Remove(client.task)
        End Try
    End Function

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        dict.Clear()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub
End Class
