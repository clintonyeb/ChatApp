<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientInformation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clientInformation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fullname = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.Label()
        Me.dob = New System.Windows.Forms.Label()
        Me.firstjoin = New System.Windows.Forms.Label()
        Me.lastlogin = New System.Windows.Forms.Label()
        Me.PrivChat = New System.Windows.Forms.Button()
        Me.pokeBtn = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date of Birth:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "First Join:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(143, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Last LogIn:"
        '
        'fullname
        '
        Me.fullname.AutoSize = True
        Me.fullname.Location = New System.Drawing.Point(214, 35)
        Me.fullname.Name = "fullname"
        Me.fullname.Size = New System.Drawing.Size(39, 13)
        Me.fullname.TabIndex = 6
        Me.fullname.Text = "Label7"
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Location = New System.Drawing.Point(214, 77)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(39, 13)
        Me.username.TabIndex = 7
        Me.username.Text = "Label8"
        '
        'dob
        '
        Me.dob.AutoSize = True
        Me.dob.Location = New System.Drawing.Point(214, 152)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(39, 13)
        Me.dob.TabIndex = 8
        Me.dob.Text = "Label9"
        '
        'firstjoin
        '
        Me.firstjoin.AutoSize = True
        Me.firstjoin.Location = New System.Drawing.Point(214, 196)
        Me.firstjoin.Name = "firstjoin"
        Me.firstjoin.Size = New System.Drawing.Size(45, 13)
        Me.firstjoin.TabIndex = 9
        Me.firstjoin.Text = "Label10"
        '
        'lastlogin
        '
        Me.lastlogin.AutoSize = True
        Me.lastlogin.Location = New System.Drawing.Point(214, 236)
        Me.lastlogin.Name = "lastlogin"
        Me.lastlogin.Size = New System.Drawing.Size(45, 13)
        Me.lastlogin.TabIndex = 10
        Me.lastlogin.Text = "Label11"
        '
        'PrivChat
        '
        Me.PrivChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrivChat.Location = New System.Drawing.Point(20, 262)
        Me.PrivChat.Name = "PrivChat"
        Me.PrivChat.Size = New System.Drawing.Size(75, 23)
        Me.PrivChat.TabIndex = 11
        Me.PrivChat.Text = "Private Chat"
        Me.PrivChat.UseVisualStyleBackColor = False
        '
        'pokeBtn
        '
        Me.pokeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pokeBtn.Location = New System.Drawing.Point(20, 314)
        Me.pokeBtn.Name = "pokeBtn"
        Me.pokeBtn.Size = New System.Drawing.Size(75, 23)
        Me.pokeBtn.TabIndex = 12
        Me.pokeBtn.Text = "Poke"
        Me.pokeBtn.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Green
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.ForeColor = System.Drawing.SystemColors.Control
        Me.Cancel.Location = New System.Drawing.Point(196, 281)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 13
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Status"
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Location = New System.Drawing.Point(17, 179)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(67, 13)
        Me.status.TabIndex = 16
        Me.status.Text = "Statushere..."
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(140, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1, 300)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "|"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(143, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Email"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Location = New System.Drawing.Point(214, 115)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(31, 13)
        Me.email.TabIndex = 19
        Me.email.Text = "email"
        '
        'clientInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(362, 366)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.pokeBtn)
        Me.Controls.Add(Me.PrivChat)
        Me.Controls.Add(Me.lastlogin)
        Me.Controls.Add(Me.firstjoin)
        Me.Controls.Add(Me.dob)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.fullname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.Info
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "clientInformation"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents fullname As Label
    Friend WithEvents username As Label
    Friend WithEvents dob As Label
    Friend WithEvents firstjoin As Label
    Friend WithEvents lastlogin As Label
    Friend WithEvents PrivChat As Button
    Friend WithEvents pokeBtn As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents status As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents email As Label
End Class
