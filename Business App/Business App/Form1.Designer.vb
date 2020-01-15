<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Login))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.RightGradientPanel = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.username = New Bunifu.Framework.BunifuCustomTextbox()
        Me.checkmark = New System.Windows.Forms.PictureBox()
        Me.passwordphoto = New System.Windows.Forms.PictureBox()
        Me.usernamephoto = New System.Windows.Forms.PictureBox()
        Me.USERLOGIN_Label = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.password = New Bunifu.Framework.BunifuCustomTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RightGradientPanel.SuspendLayout()
        CType(Me.checkmark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passwordphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usernamephoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me
        '
        'RightGradientPanel
        '
        Me.RightGradientPanel.BackColor = System.Drawing.Color.Transparent
        Me.RightGradientPanel.BackgroundImage = CType(resources.GetObject("RightGradientPanel.BackgroundImage"), System.Drawing.Image)
        Me.RightGradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RightGradientPanel.Controls.Add(Me.Panel1)
        Me.RightGradientPanel.Controls.Add(Me.password)
        Me.RightGradientPanel.Controls.Add(Me.username)
        Me.RightGradientPanel.Controls.Add(Me.checkmark)
        Me.RightGradientPanel.Controls.Add(Me.passwordphoto)
        Me.RightGradientPanel.Controls.Add(Me.usernamephoto)
        Me.RightGradientPanel.Controls.Add(Me.USERLOGIN_Label)
        Me.RightGradientPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightGradientPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.RightGradientPanel.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.RightGradientPanel.GradientTopLeft = System.Drawing.Color.White
        Me.RightGradientPanel.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.RightGradientPanel.Location = New System.Drawing.Point(658, 0)
        Me.RightGradientPanel.Name = "RightGradientPanel"
        Me.RightGradientPanel.Quality = 10
        Me.RightGradientPanel.Size = New System.Drawing.Size(406, 598)
        Me.RightGradientPanel.TabIndex = 9
        '
        'username
        '
        Me.username.BorderColor = System.Drawing.Color.SeaGreen
        Me.username.Font = New System.Drawing.Font("Roboto Th", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(105, 259)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(204, 28)
        Me.username.TabIndex = 4
        '
        'checkmark
        '
        Me.checkmark.BackColor = System.Drawing.Color.Transparent
        Me.checkmark.BackgroundImage = Global.Business_App.My.Resources.Resources.icons8_checkmark_64
        Me.checkmark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.checkmark.Location = New System.Drawing.Point(318, 264)
        Me.checkmark.Name = "checkmark"
        Me.checkmark.Size = New System.Drawing.Size(73, 62)
        Me.checkmark.TabIndex = 3
        Me.checkmark.TabStop = False
        '
        'passwordphoto
        '
        Me.passwordphoto.BackColor = System.Drawing.Color.Transparent
        Me.passwordphoto.BackgroundImage = Global.Business_App.My.Resources.Resources.icons8_password_24
        Me.passwordphoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.passwordphoto.InitialImage = Nothing
        Me.passwordphoto.Location = New System.Drawing.Point(25, 302)
        Me.passwordphoto.Name = "passwordphoto"
        Me.passwordphoto.Size = New System.Drawing.Size(74, 50)
        Me.passwordphoto.TabIndex = 2
        Me.passwordphoto.TabStop = False
        '
        'usernamephoto
        '
        Me.usernamephoto.BackColor = System.Drawing.Color.Transparent
        Me.usernamephoto.BackgroundImage = Global.Business_App.My.Resources.Resources.icons8_user_30__1_
        Me.usernamephoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.usernamephoto.InitialImage = Nothing
        Me.usernamephoto.Location = New System.Drawing.Point(25, 246)
        Me.usernamephoto.Name = "usernamephoto"
        Me.usernamephoto.Size = New System.Drawing.Size(74, 50)
        Me.usernamephoto.TabIndex = 2
        Me.usernamephoto.TabStop = False
        '
        'USERLOGIN_Label
        '
        Me.USERLOGIN_Label.AutoSize = True
        Me.USERLOGIN_Label.BackColor = System.Drawing.Color.Transparent
        Me.USERLOGIN_Label.Font = New System.Drawing.Font("Roboto Th", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USERLOGIN_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.USERLOGIN_Label.Location = New System.Drawing.Point(119, 202)
        Me.USERLOGIN_Label.Name = "USERLOGIN_Label"
        Me.USERLOGIN_Label.Size = New System.Drawing.Size(173, 34)
        Me.USERLOGIN_Label.TabIndex = 0
        Me.USERLOGIN_Label.Text = "USER LOGIN"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Business_App.My.Resources.Resources.Pewter_Engineers
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(2, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(657, 600)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'password
        '
        Me.password.BorderColor = System.Drawing.Color.SeaGreen
        Me.password.Font = New System.Drawing.Font("Roboto Th", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(105, 313)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(204, 28)
        Me.password.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 42)
        Me.Panel1.TabIndex = 6
        '
        'Main_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 598)
        Me.Controls.Add(Me.RightGradientPanel)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main_Login"
        Me.Text = "Form1"
        Me.RightGradientPanel.ResumeLayout(False)
        Me.RightGradientPanel.PerformLayout()
        CType(Me.checkmark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passwordphoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usernamephoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RightGradientPanel As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents USERLOGIN_Label As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents usernamephoto As PictureBox
    Friend WithEvents passwordphoto As PictureBox
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents checkmark As PictureBox
    Friend WithEvents username As Bunifu.Framework.BunifuCustomTextbox
    Friend WithEvents password As Bunifu.Framework.BunifuCustomTextbox
    Friend WithEvents Panel1 As Panel
End Class
