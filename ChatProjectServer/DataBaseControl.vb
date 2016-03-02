Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class DataBaseControl
    Private connect As New SqlConnection With {.ConnectionString =
    "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\holys\OneDrive\Documents\Visual Studio 2015\Projects\ChatProjectDataBaseFile\ChatProjectDataBaseFile\ChatDataBase.mdf;Integrated Security=True;Connect Timeout=30"}
    Private command As SqlCommand
    Private client As Client
    Public adapter As SqlDataAdapter
    Public ds As DataSet

    Public Function HasConnection() As Boolean
        Try
            connect.Open()

            connect.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Public Function ConvertImage(ByVal myImage As Image) As Byte()
    '    Dim mstream As New MemoryStream
    '    myImage.Save(mstream, ImageFormat.Jpeg)
    '    Return mstream.ToArray
    'End Function

    Dim buffer As Byte()
    Public Function ConvertImag(ByVal value As Image) As Byte()
        If value Is Nothing Then Return Nothing
        Using ms As New MemoryStream
            value.Save(ms, ImageFormat.Jpeg)
            ms.Flush()
            ms.Position = 0
            buffer = ms.GetBuffer
            Return buffer
        End Using
        Return buffer
    End Function

    'Public Function ConvImage(ByVal imag As Image) As Byte()
    '    Dim ms As New MemoryStream()
    '    imag.Save(ms, imag.RawFormat)
    '    Dim data As Byte() = ms.GetBuffer()
    '    Return data
    'End Function
    Public Function RunProfilePicture(query As String, client As Client) As Boolean
        Try
            connect.Open()
            command = New SqlCommand(query, connect)

            Dim data As Byte() = ConvertImag(client.profilePic)
            command.Parameters.AddWithValue("@PICTURE", data)
            command.Parameters.AddWithValue("@USER", client.clientName)
            Dim Affected As Integer = command.ExecuteNonQuery()
            connect.Close()
            Return Affected > 0
        Catch ex As Exception
            If connect.State = ConnectionState.Open Then
                connect.Close()
            End If
            Return False
        End Try
    End Function
    Public Sub RunLogIn(query As String, client As Client)
        Try
            connect.Open()
            command = New SqlCommand(query, connect)
            command.Parameters.AddWithValue("@USER", client.clientName)
            command.Parameters.AddWithValue("@PSWD", client.clientPass)
            adapter = New SqlDataAdapter(command)
            ds = New DataSet
            adapter.Fill(ds)
            connect.Close()
        Catch ex As Exception
            If connect.State = ConnectionState.Open Then
                connect.Close()
            End If
        End Try
    End Sub

    Dim imagehere As Image
    Public Function GetPicture(query As String, client As Client) As Image
        Try
            connect.Open()
            command = New SqlCommand(query, connect)
            command.Parameters.AddWithValue("@USER", client.clientName)
            Dim imageData As Byte() = DirectCast(command.ExecuteScalar(), Byte())
            If imageData IsNot Nothing Then
                Dim ms As New MemoryStream(imageData, 0, imageData.Length)
                ms.Write(imageData, 0, imageData.Length)
                imagehere = Image.FromStream(ms, True)
            End If
            connect.Close()
            Return imagehere
        Catch ex As Exception
            If connect.State = ConnectionState.Open Then
                connect.Close()
            End If
            Return Nothing
        End Try
    End Function
    Public Function RunGetProfile(query As String, name As String) As Object()
        Try
            connect.Open()
            command = New SqlCommand(query, connect)
            command.Parameters.AddWithValue("@USER", name)
            Dim items As SqlDataReader = command.ExecuteReader()
            Dim array(6) As Object
            While items.Read
                array(0) = items("Username")
                array(1) = items("Fullname")
                array(2) = items("Email")
                array(3) = items("Age")
                array(4) = items("FirstLogin")
                array(5) = items("LastLogin")
            End While
            connect.Close()
            Return array
        Catch ex As Exception
            If connect.State = ConnectionState.Open Then
                connect.Close()
            End If
            Return Nothing
        End Try
    End Function
    Public Function RunRegistration(query As String, client As Client) As Boolean
        Try
            connect.Open()
            command = New SqlCommand(query, connect)
            command.Parameters.AddWithValue("@UserName", client.clientName)
            command.Parameters.AddWithValue("@FullName", client.clientFullName)
            command.Parameters.AddWithValue("@PassWord", client.clientPass)
            command.Parameters.AddWithValue("@Email", client.clientEmail)
            command.Parameters.AddWithValue("@FirstLogin", DateTime.Now)
            Dim Affected As Integer = command.ExecuteNonQuery()
            connect.Close()
            Return Affected > 0
        Catch ex As Exception
            MsgBox(ex.ToString)
            If connect.State = ConnectionState.Open Then
                connect.Close()
            End If
        End Try
        Return False
    End Function

End Class
