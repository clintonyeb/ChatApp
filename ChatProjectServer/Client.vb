Imports System.ComponentModel
Imports System.Net
Imports System.Net.Sockets
Imports System.Drawing.Imaging
Imports System.IO

'We first need a class to encapsulate our clients.
'This will specify the properties of each client created and the methods that can be performed 
'with them.
'This may grow As new functionalities are added.

Public Class Client
    Implements System.ComponentModel.INotifyPropertyChanged
    Public ReadOnly tcpClient As TcpClient
    Public ReadOnly id As String
    Public task As Task
    Public ReadOnly messReceived As New List(Of Byte)
    Dim sqlobj As DataBaseControl = New DataBaseControl
    Private _txtMess As String = String.Empty
    Public clientName As String = Nothing
    Public clientFullName As String = Nothing
    Public clientPass As String = Nothing
    Public clientEmail As String = Nothing
    Public profilePic As Image


    Public ReadOnly Property txtMess As String
        Get
            Return _txtMess
        End Get
    End Property

    'when new client is created, we will want to assign it our TcpClient instance
    'And then craft an id based on its unique ipAddress and portNo used for connection

    Public Sub New(client As TcpClient)
        tcpClient = client
        id = CType(tcpClient.Client.RemoteEndPoint, IPEndPoint).ToString
    End Sub

    'Next we will want to create a method to collect data sent by this client and check for
    'validity and completeness
    'then we can allow the server to process the data as per the clients specification 
    'That is, for each data received, when complete should have enough information for the server
    'to decide what to do with it


    Public Async Function DataReceived(buffer() As Byte, read As Integer, serverForm As Form1) As Task

        If read = 0 Then
            Exit Function
        End If
        messReceived.AddRange(buffer.Take(read))
        If XProtocol.XMessage.IsMessageComplete(messReceived) Then
            Dim message As XProtocol.XMessage = XProtocol.XMessage.FromByteArray(messReceived.ToArray)
            messReceived.Clear()

            Select Case message.Element.Name
                Case "textmessage"
                    _txtMess = message.Element.@text
                    Dim data As New XProtocol.XMessage(<textmessage text=<%= Me.clientName + " says: " + txtMess %>/>)
                    Await Form1.SendingToClients(data, Me)

                Case "requiredregister"
                    clientFullName = message.Element.@fullname
                    clientName = message.Element.@username
                    clientPass = message.Element.@password
                    clientEmail = message.Element.@email

                    Dim status As Boolean = DoRegisteration()
                    If status Then
                        Dim data As New XProtocol.XMessage(<requiredregister response=<%= "0" %>/>)
                        Await Form1.SendToSender(data, Me)

                        Dim status1 As Boolean = DoLogIn()
                        If status1 Then

                            Dim data55 As New XProtocol.XMessage(<login response=<%= "0" %>/>)
                            Await Form1.SendToSender(data55, Me)


                            For Each cl In Form1.dict
                                Dim data3 As New XProtocol.XMessage(<status option=<%= cl.Value.clientName + " is online" %>/>)
                                Await Form1.SendToSender(data3, Me)
                                Threading.Thread.Sleep(300)
                            Next cl
                            Form1.AddingToDictionary(Me.clientName, Me)
                            Dim data2 As New XProtocol.XMessage(<userjoin text=<%= Me.clientName + " is online" %>/>)
                            Await Form1.SendingToClients(data2, Me)
                            Form1.txtBoxNoti.Text = "finished"
                        Else
                            Dim data5 As New XProtocol.XMessage(<login response=<%= "-1" %>/>)
                            Await Form1.SendToSender(data5, Me)
                            'Form1.dict.Remove(Me.clientName)
                        End If
                    Else
                        Dim data As New XProtocol.XMessage(<requiredregister response=<%= "-6" %>/>)
                        Await Form1.SendToSender(data, Me)
                    End If

                'Performs login after registration


                Case "login"
                    Form1.txtBoxNoti.Text = "logging in"
                    clientName = message.Element.@username
                    clientPass = message.Element.@password
                    Dim status As Boolean = DoLogIn()
                    If status Then

                        Dim data As New XProtocol.XMessage(<login response=<%= "0" %>/>)
                        Await Form1.SendToSender(data, Me)


                        For Each cl In Form1.dict
                            Dim data3 As New XProtocol.XMessage(<status option=<%= cl.Value.clientName + " is online" %>/>)
                            Await Form1.SendToSender(data3, Me)
                            Threading.Thread.Sleep(500)
                        Next cl
                        Form1.AddingToDictionary(Me.clientName, Me)
                        Dim data2 As New XProtocol.XMessage(<userjoin text=<%= Me.clientName + " is online" %>/>)
                        Await Form1.SendingToClients(data2, Me)
                        Form1.txtBoxNoti.Text = "finished"
                    Else
                        Dim data As New XProtocol.XMessage(<login response=<%= "-1" %>/>)
                        Await Form1.SendToSender(data, Me)
                        'Form1.dict.Remove(Me.clientName)
                    End If

                Case "image"
                    Dim imgString As String = GetPictureString()
                    Dim imageData As New XProtocol.XMessage(<image picture=<%= imgString %>/>)
                    Await Form1.SendToSender(imageData, Me)

                Case "profileview"
                    clientName = message.Element.@user
                    Dim array() As Object = GetProfile(clientName)
                    Dim imgString As String = GetPictureString()
                    Dim data As New XProtocol.XMessage(<profileview username=<%= array(0) %>
                                                           fullname=<%= array(1) %> email=<%= array(2) %> age=<%= array(3) %> firstlogin=<%= array(4) %>
                                                           lastlogin=<%= array(5) %> picture=<%= imgString %>/>)
                    Await Form1.SendToSender(data, Me)

                Case "status"
                    Dim change As String = message.Element.@option
                    Form1.RemovingfromDictionary(Me.clientName)
                    Dim data As New XProtocol.XMessage(<status option=<%= Me.clientName + " is offline" %>/>)
                    Await Form1.SendingToClients(data, Me)

                Case "profilepicture"
                    Dim byt = ConvertStringToImage(message.Element.@picture)
                    'Dim imgTry As ImageTry = New ImageTry
                    'imgTry.PictureBox1.Image = byt
                    'imgTry.ShowDialog()
                    Dim status = DoProfilePic()
                    If status = True Then
                        Dim data As New XProtocol.XMessage(<profilepicture response=<%= 0 %>/>)
                        Await Form1.SendToSender(data, Me)
                    Else
                        Dim data As New XProtocol.XMessage(<profilepicture response=<%= -1 %>/>)
                        Await Form1.SendToSender(data, Me)
                    End If

                Case "privatemessage"
                    _txtMess = message.Element.@text
                    Dim list As New List(Of String)
                    list.Add(message.Element.@sender)
                    list.Add(message.Element.@receiver)
                    For Each li In list
                        For Each d In Form1.dict
                            If d.Key = li Then
                                Dim data As New XProtocol.XMessage(<privatemessage text=<%= message.Element.@sender + " says: " + txtMess %>/>)
                                Await Form1.SendToSender(data, d.Value)
                            End If

                        Next
                    Next
            End Select
        End If
    End Function
    Private Function GetPictureString() As String
        Dim query As String = "SELECT PICTURE FROM ClientDetails WHERE USERNAME = @USER"
        Dim img As Image = sqlobj.GetPicture(query, Me)
        Dim str As String = ConvertImageToString(img)
        Return str
    End Function

    Dim szResult As String
    Dim img As Image

    Private Function DoProfilePic() As Boolean
        Dim query As String = "UPDATE ClientDetails SET PICTURE = @PICTURE WHERE USERNAME = @USER"
        Return sqlobj.RunProfilePicture(query, Me)
    End Function
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

    Public Function ConvertStringToImage(ByVal imageEncodedString As String) As Image
        If String.IsNullOrEmpty(imageEncodedString) Then Return Nothing
        Dim buffer = HexToBytes(imageEncodedString)
        Dim mem As New MemoryStream(buffer.ToArray)
        mem.Position = 0
        img = Image.FromStream(mem)
        Me.profilePic = img
        Return img
    End Function

    Private Function GetProfile(ByVal name As String)
        Dim query As String = "SELECT USERNAME, FULLNAME, AGE, EMAIL, FIRSTLOGIN, LASTLOGIN FROM ClientDetails WHERE USERNAME = @USER"
        Dim array() As Object = sqlobj.RunGetProfile(query, name)
        Return array
    End Function

    Private Function DoLogIn() As Boolean
        Dim query As String = "SELECT COUNT (*) AS USERCOUNT FROM ClientDetails WHERE USERNAME = @USER
        AND PASSWORD = @PSWD"
        sqlobj.RunLogIn(query, Me)
        If sqlobj.ds.Tables(0).Rows(0).Item("USERCOUNT") = 1 Then
            Return True
        End If
        Return False
    End Function

    Private Function DoRegisteration() As Boolean
        Dim query As String = "INSERT INTO ClientDetails ([UserName], [FullName], [PassWord], [Email],[FirstLogin]) VALUES (@UserName, @FullName, @PassWord, @Email, @firstlogin)"
        Dim status As Boolean = sqlobj.RunRegistration(query, Me)
        Return status
    End Function

    'these are supposed to override basic functionalities for the clientclass
    'to enhance processing
    'don't worry, they were copied, you can also copy :)

    Public Overrides Function Equals(obj As Object) As Boolean
        If TypeOf obj Is Client Then Return id = DirectCast(obj, Client).id
        Return MyBase.Equals(obj)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return id.GetHashCode
    End Function

    Public Overrides Function ToString() As String
        Return id
    End Function

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
