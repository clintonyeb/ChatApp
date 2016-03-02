<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrivateMessaging
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrivateMessaging))
        Me.MsgListBox = New System.Windows.Forms.RichTextBox()
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.sendBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MsgListBox
        '
        Me.MsgListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.MsgListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.MsgListBox, "MsgListBox")
        Me.MsgListBox.ForeColor = System.Drawing.SystemColors.Info
        Me.MsgListBox.Name = "MsgListBox"
        Me.MsgListBox.ReadOnly = True
        '
        'txtBox
        '
        Me.txtBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.txtBox, "txtBox")
        Me.txtBox.ForeColor = System.Drawing.SystemColors.Info
        Me.txtBox.Name = "txtBox"
        '
        'sendBtn
        '
        Me.sendBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sendBtn.ForeColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.sendBtn, "sendBtn")
        Me.sendBtn.Name = "sendBtn"
        Me.sendBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'PrivateMessaging
        '
        Me.AcceptButton = Me.sendBtn
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sendBtn)
        Me.Controls.Add(Me.txtBox)
        Me.Controls.Add(Me.MsgListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PrivateMessaging"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MsgListBox As RichTextBox
    Friend WithEvents txtBox As TextBox
    Friend WithEvents sendBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
