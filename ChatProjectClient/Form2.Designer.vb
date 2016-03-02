<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MsgListBox = New System.Windows.Forms.RichTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FriendsProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToBackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.onlineMembers = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.logInLabel = New System.Windows.Forms.Button()
        Me.reglabel = New System.Windows.Forms.Button()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.sendBtn = New System.Windows.Forms.Button()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MsgListBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(471, 465)
        Me.SplitContainer1.SplitterDistance = 246
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 27)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Panel1Collapsed = True
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SplitContainer5.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer5.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer5.Size = New System.Drawing.Size(246, 23)
        Me.SplitContainer5.SplitterDistance = 82
        Me.SplitContainer5.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(72, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Logged in As:"
        '
        'MsgListBox
        '
        Me.MsgListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MsgListBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MsgListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.MsgListBox.Location = New System.Drawing.Point(0, 50)
        Me.MsgListBox.Name = "MsgListBox"
        Me.MsgListBox.ReadOnly = True
        Me.MsgListBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.MsgListBox.Size = New System.Drawing.Size(246, 415)
        Me.MsgListBox.TabIndex = 1
        Me.MsgListBox.Text = ""
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.MenuStrip1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(246, 27)
        Me.Panel4.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(246, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.AddToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem1, Me.FriendsProfileToolStripMenuItem, Me.MinimizeToolStripMenuItem, Me.MinimizeToBackgroundToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ProfileToolStripMenuItem1
        '
        Me.ProfileToolStripMenuItem1.Name = "ProfileToolStripMenuItem1"
        Me.ProfileToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.ProfileToolStripMenuItem1.Text = "Profile"
        '
        'FriendsProfileToolStripMenuItem
        '
        Me.FriendsProfileToolStripMenuItem.Name = "FriendsProfileToolStripMenuItem"
        Me.FriendsProfileToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.FriendsProfileToolStripMenuItem.Text = "Friends Profile"
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.MinimizeToolStripMenuItem.Text = "Minimize"
        '
        'MinimizeToBackgroundToolStripMenuItem
        '
        Me.MinimizeToBackgroundToolStripMenuItem.Name = "MinimizeToBackgroundToolStripMenuItem"
        Me.MinimizeToBackgroundToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.MinimizeToBackgroundToolStripMenuItem.Text = "Minimize to Background"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.onlineMembers)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 198)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(221, 267)
        Me.Panel3.TabIndex = 2
        '
        'onlineMembers
        '
        Me.onlineMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.onlineMembers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.onlineMembers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.onlineMembers.FormattingEnabled = True
        Me.onlineMembers.Location = New System.Drawing.Point(0, 0)
        Me.onlineMembers.Name = "onlineMembers"
        Me.onlineMembers.Size = New System.Drawing.Size(221, 267)
        Me.onlineMembers.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(221, 171)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Edit Profile Picture"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(221, 27)
        Me.Panel1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.White
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.logInLabel)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.reglabel)
        Me.SplitContainer2.Size = New System.Drawing.Size(221, 27)
        Me.SplitContainer2.SplitterDistance = 103
        Me.SplitContainer2.TabIndex = 0
        '
        'logInLabel
        '
        Me.logInLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.logInLabel.Location = New System.Drawing.Point(0, 0)
        Me.logInLabel.Name = "logInLabel"
        Me.logInLabel.Size = New System.Drawing.Size(103, 27)
        Me.logInLabel.TabIndex = 0
        Me.logInLabel.Text = "Login"
        Me.logInLabel.UseVisualStyleBackColor = True
        '
        'reglabel
        '
        Me.reglabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reglabel.Location = New System.Drawing.Point(0, 0)
        Me.reglabel.Name = "reglabel"
        Me.reglabel.Size = New System.Drawing.Size(114, 27)
        Me.reglabel.TabIndex = 0
        Me.reglabel.Text = "Register"
        Me.reglabel.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 465)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TextBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.sendBtn)
        Me.SplitContainer3.Size = New System.Drawing.Size(471, 40)
        Me.SplitContainer3.SplitterDistance = 378
        Me.SplitContainer3.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(378, 40)
        Me.TextBox1.TabIndex = 0
        '
        'sendBtn
        '
        Me.sendBtn.BackgroundImage = CType(resources.GetObject("sendBtn.BackgroundImage"), System.Drawing.Image)
        Me.sendBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.sendBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sendBtn.Location = New System.Drawing.Point(0, 0)
        Me.sendBtn.Name = "sendBtn"
        Me.sendBtn.Size = New System.Drawing.Size(89, 40)
        Me.sendBtn.TabIndex = 0
        Me.sendBtn.Text = "SEND"
        Me.sendBtn.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 505)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Panel1Collapsed = True
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.ProgressBar1)
        Me.SplitContainer4.Size = New System.Drawing.Size(471, 21)
        Me.SplitContainer4.SplitterDistance = 25
        Me.SplitContainer4.TabIndex = 2
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(471, 21)
        Me.ProgressBar1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipTitle = "New Notification"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Ton Chat"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem1.Text = "Show"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Exit"
        '
        'Form2
        '
        Me.AcceptButton = Me.sendBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(471, 526)
        Me.Controls.Add(Me.SplitContainer4)
        Me.Controls.Add(Me.SplitContainer3)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(950, 170)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "TonChat"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.Panel2.PerformLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsgListBox As RichTextBox
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FriendsProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizeToBackgroundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents onlineMembers As ListBox
    Friend WithEvents logInLabel As Button
    Friend WithEvents reglabel As Button
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents sendBtn As Button
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents SplitContainer5 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
End Class
