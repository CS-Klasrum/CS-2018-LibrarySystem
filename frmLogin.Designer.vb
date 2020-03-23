<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.CheckBoxSP = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(194, 438)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(164, 472)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(166, 20)
        Me.TxtUsername.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(194, 494)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Btn_Login
        '
        Me.Btn_Login.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Login.FlatAppearance.BorderSize = 0
        Me.Btn_Login.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Login.ForeColor = System.Drawing.Color.Black
        Me.Btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Login.Location = New System.Drawing.Point(120, 615)
        Me.Btn_Login.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(100, 31)
        Me.Btn_Login.TabIndex = 3
        Me.Btn_Login.Text = "Login"
        Me.Btn_Login.UseVisualStyleBackColor = False
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(164, 529)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(166, 20)
        Me.TxtPassword.TabIndex = 1
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'Btn_Exit
        '
        Me.Btn_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.FlatAppearance.BorderSize = 0
        Me.Btn_Exit.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Exit.ForeColor = System.Drawing.Color.Black
        Me.Btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Exit.Location = New System.Drawing.Point(268, 615)
        Me.Btn_Exit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(100, 31)
        Me.Btn_Exit.TabIndex = 4
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = False
        '
        'CheckBoxSP
        '
        Me.CheckBoxSP.AutoSize = True
        Me.CheckBoxSP.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxSP.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSP.ForeColor = System.Drawing.Color.White
        Me.CheckBoxSP.Location = New System.Drawing.Point(164, 554)
        Me.CheckBoxSP.Name = "CheckBoxSP"
        Me.CheckBoxSP.Size = New System.Drawing.Size(126, 22)
        Me.CheckBoxSP.TabIndex = 2
        Me.CheckBoxSP.Text = "Show Password"
        Me.CheckBoxSP.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(162, 584)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(58, 17)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Register"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.Copy_of_Book_Club___Made_with_PosterMyWall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(512, 693)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CheckBoxSP)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_Login As System.Windows.Forms.Button
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Exit As System.Windows.Forms.Button
    Friend WithEvents CheckBoxSP As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
