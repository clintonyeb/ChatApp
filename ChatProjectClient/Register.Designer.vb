<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class RegForm
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmailTxtBox = New System.Windows.Forms.TextBox()
        Me.fullnameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ConPasswordTxtBox = New System.Windows.Forms.TextBox()
        Me.errrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.UsernameLabel.Location = New System.Drawing.Point(15, 63)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.PasswordLabel.Location = New System.Drawing.Point(12, 121)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UsernameTextBox.Location = New System.Drawing.Point(18, 98)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.UsernameTextBox.TabIndex = 2
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PasswordTextBox.Location = New System.Drawing.Point(15, 156)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'OK
        '
        Me.OK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OK.ForeColor = System.Drawing.SystemColors.Control
        Me.OK.Location = New System.Drawing.Point(12, 317)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 6
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.ForeColor = System.Drawing.SystemColors.Control
        Me.Cancel.Location = New System.Drawing.Point(138, 317)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "&Cancel"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(12, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "&Email"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(15, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "&Full name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmailTxtBox
        '
        Me.EmailTxtBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailTxtBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EmailTxtBox.Location = New System.Drawing.Point(15, 263)
        Me.EmailTxtBox.Name = "EmailTxtBox"
        Me.EmailTxtBox.Size = New System.Drawing.Size(220, 20)
        Me.EmailTxtBox.TabIndex = 5
        '
        'fullnameTxtBox
        '
        Me.fullnameTxtBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullnameTxtBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fullnameTxtBox.Location = New System.Drawing.Point(18, 40)
        Me.fullnameTxtBox.Name = "fullnameTxtBox"
        Me.fullnameTxtBox.Size = New System.Drawing.Size(220, 20)
        Me.fullnameTxtBox.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(12, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "&Confirm Password"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConPasswordTxtBox
        '
        Me.ConPasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConPasswordTxtBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ConPasswordTxtBox.Location = New System.Drawing.Point(15, 214)
        Me.ConPasswordTxtBox.Name = "ConPasswordTxtBox"
        Me.ConPasswordTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConPasswordTxtBox.Size = New System.Drawing.Size(220, 20)
        Me.ConPasswordTxtBox.TabIndex = 4
        '
        'errrorProvider
        '
        Me.errrorProvider.ContainerControl = Me
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'RegForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(270, 398)
        Me.Controls.Add(Me.ConPasswordTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fullnameTxtBox)
        Me.Controls.Add(Me.EmailTxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegForm"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registration"
        CType(Me.errrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EmailTxtBox As TextBox
    Friend WithEvents fullnameTxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ConPasswordTxtBox As TextBox
    Friend WithEvents errrorProvider As ErrorProvider
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
