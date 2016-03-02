<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.onlineMembersBox = New System.Windows.Forms.ListBox()
        Me.activeGroups = New System.Windows.Forms.ListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtBoxNoti = New System.Windows.Forms.TextBox()
        Me.labNoti = New System.Windows.Forms.Label()
        Me.labelOnlineMem = New System.Windows.Forms.Label()
        Me.labelOnlineMemFig = New System.Windows.Forms.Label()
        Me.labelFailedConn = New System.Windows.Forms.Label()
        Me.labelFailedConnFig = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.labelActGroups = New System.Windows.Forms.Label()
        Me.labelActGroupsFig = New System.Windows.Forms.Label()
        Me.clientBindSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.clientBindSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(34, 18)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'onlineMembersBox
        '
        Me.onlineMembersBox.FormattingEnabled = True
        Me.onlineMembersBox.Location = New System.Drawing.Point(16, 75)
        Me.onlineMembersBox.Name = "onlineMembersBox"
        Me.onlineMembersBox.Size = New System.Drawing.Size(144, 290)
        Me.onlineMembersBox.TabIndex = 1
        '
        'activeGroups
        '
        Me.activeGroups.FormattingEnabled = True
        Me.activeGroups.Location = New System.Drawing.Point(178, 75)
        Me.activeGroups.Name = "activeGroups"
        Me.activeGroups.Size = New System.Drawing.Size(162, 290)
        Me.activeGroups.TabIndex = 2
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(225, 18)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtBoxNoti
        '
        Me.txtBoxNoti.Location = New System.Drawing.Point(358, 124)
        Me.txtBoxNoti.Name = "txtBoxNoti"
        Me.txtBoxNoti.Size = New System.Drawing.Size(204, 20)
        Me.txtBoxNoti.TabIndex = 5
        Me.txtBoxNoti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labNoti
        '
        Me.labNoti.AutoSize = True
        Me.labNoti.Location = New System.Drawing.Point(365, 90)
        Me.labNoti.Name = "labNoti"
        Me.labNoti.Size = New System.Drawing.Size(68, 13)
        Me.labNoti.TabIndex = 6
        Me.labNoti.Text = "Notifications:"
        '
        'labelOnlineMem
        '
        Me.labelOnlineMem.AutoSize = True
        Me.labelOnlineMem.Location = New System.Drawing.Point(360, 176)
        Me.labelOnlineMem.Name = "labelOnlineMem"
        Me.labelOnlineMem.Size = New System.Drawing.Size(118, 13)
        Me.labelOnlineMem.TabIndex = 7
        Me.labelOnlineMem.Text = "No. of Online Members:"
        '
        'labelOnlineMemFig
        '
        Me.labelOnlineMemFig.AutoSize = True
        Me.labelOnlineMemFig.Location = New System.Drawing.Point(489, 176)
        Me.labelOnlineMemFig.Name = "labelOnlineMemFig"
        Me.labelOnlineMemFig.Size = New System.Drawing.Size(13, 13)
        Me.labelOnlineMemFig.TabIndex = 8
        Me.labelOnlineMemFig.Text = "0"
        '
        'labelFailedConn
        '
        Me.labelFailedConn.AutoSize = True
        Me.labelFailedConn.Location = New System.Drawing.Point(360, 238)
        Me.labelFailedConn.Name = "labelFailedConn"
        Me.labelFailedConn.Size = New System.Drawing.Size(100, 13)
        Me.labelFailedConn.TabIndex = 11
        Me.labelFailedConn.Text = "Failed Connections:"
        '
        'labelFailedConnFig
        '
        Me.labelFailedConnFig.AutoSize = True
        Me.labelFailedConnFig.Location = New System.Drawing.Point(489, 238)
        Me.labelFailedConnFig.Name = "labelFailedConnFig"
        Me.labelFailedConnFig.Size = New System.Drawing.Size(13, 13)
        Me.labelFailedConnFig.TabIndex = 12
        Me.labelFailedConnFig.Text = "0"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(125, 18)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'labelActGroups
        '
        Me.labelActGroups.AutoSize = True
        Me.labelActGroups.Location = New System.Drawing.Point(360, 209)
        Me.labelActGroups.Name = "labelActGroups"
        Me.labelActGroups.Size = New System.Drawing.Size(109, 13)
        Me.labelActGroups.TabIndex = 15
        Me.labelActGroups.Text = "No. of Active Groups:"
        '
        'labelActGroupsFig
        '
        Me.labelActGroupsFig.AutoSize = True
        Me.labelActGroupsFig.Location = New System.Drawing.Point(489, 209)
        Me.labelActGroupsFig.Name = "labelActGroupsFig"
        Me.labelActGroupsFig.Size = New System.Drawing.Size(13, 13)
        Me.labelActGroupsFig.TabIndex = 16
        Me.labelActGroupsFig.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(595, 407)
        Me.Controls.Add(Me.labelActGroupsFig)
        Me.Controls.Add(Me.labelActGroups)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.labelFailedConnFig)
        Me.Controls.Add(Me.labelFailedConn)
        Me.Controls.Add(Me.labelOnlineMemFig)
        Me.Controls.Add(Me.labelOnlineMem)
        Me.Controls.Add(Me.labNoti)
        Me.Controls.Add(Me.txtBoxNoti)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.activeGroups)
        Me.Controls.Add(Me.onlineMembersBox)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Chat Server"
        CType(Me.clientBindSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents onlineMembersBox As ListBox
    Friend WithEvents activeGroups As ListBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtBoxNoti As TextBox
    Friend WithEvents labNoti As Label
    Friend WithEvents labelOnlineMem As Label
    Friend WithEvents labelOnlineMemFig As Label
    Friend WithEvents labelFailedConn As Label
    Friend WithEvents labelFailedConnFig As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents labelActGroups As Label
    Friend WithEvents labelActGroupsFig As Label
    Friend WithEvents clientBindSource As BindingSource
End Class
