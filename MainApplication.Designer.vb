<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainApplication
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn_quit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn_modules = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn_users = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn_login = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.mn_modules})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(676, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mn_login, Me.mn_logout, Me.ToolStripMenuItem1, Me.mn_quit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mn_quit
        '
        Me.mn_quit.Name = "mn_quit"
        Me.mn_quit.Size = New System.Drawing.Size(152, 22)
        Me.mn_quit.Text = "&Quit"
        '
        'mn_modules
        '
        Me.mn_modules.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mn_users})
        Me.mn_modules.Name = "mn_modules"
        Me.mn_modules.Size = New System.Drawing.Size(65, 20)
        Me.mn_modules.Text = "&Modules"
        '
        'mn_users
        '
        Me.mn_users.Name = "mn_users"
        Me.mn_users.Size = New System.Drawing.Size(102, 22)
        Me.mn_users.Text = "&Users"
        '
        'mn_login
        '
        Me.mn_login.Name = "mn_login"
        Me.mn_login.Size = New System.Drawing.Size(152, 22)
        Me.mn_login.Text = "Login"
        '
        'mn_logout
        '
        Me.mn_logout.Name = "mn_logout"
        Me.mn_logout.Size = New System.Drawing.Size(152, 22)
        Me.mn_logout.Text = "Logout"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'MainApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SampleAdo.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(676, 326)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainApplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sample DB "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn_quit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn_modules As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn_users As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn_login As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn_logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator

End Class
