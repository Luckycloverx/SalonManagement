<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Panel1 = New Panel()
        Label5 = New Label()
        CheckBox1 = New CheckBox()
        Panel3 = New Panel()
        password = New TextBox()
        Label4 = New Label()
        login = New Button()
        Label2 = New Label()
        Panel2 = New Panel()
        username = New TextBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientInactiveCaption
        Label1.Location = New Point(2, 1)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 15)
        Label1.TabIndex = 0
        Label1.Text = "SALON MANAGEMENT SYSTEM"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonFace
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(login)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(400, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(422, 559)
        Panel1.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Navy
        Label5.Location = New Point(13, 530)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 20)
        Label5.TabIndex = 8
        Label5.Text = "EXIT"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(50, 300)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(107, 19)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "show password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(password)
        Panel3.Controls.Add(Label4)
        Panel3.Cursor = Cursors.IBeam
        Panel3.Location = New Point(34, 233)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(319, 61)
        Panel3.TabIndex = 6
        ' 
        ' password
        ' 
        password.BorderStyle = BorderStyle.None
        password.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        password.Location = New Point(20, 27)
        password.Name = "password"
        password.PasswordChar = "*"c
        password.Size = New Size(279, 18)
        password.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.GrayText
        Label4.Location = New Point(15, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 12)
        Label4.TabIndex = 0
        Label4.Text = "PASSWORD"
        ' 
        ' login
        ' 
        login.BackColor = Color.Navy
        login.FlatAppearance.BorderColor = Color.DarkGray
        login.FlatStyle = FlatStyle.Flat
        login.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        login.ForeColor = SystemColors.Control
        login.Location = New Point(34, 352)
        login.Name = "login"
        login.Padding = New Padding(10)
        login.Size = New Size(319, 49)
        login.TabIndex = 2
        login.Text = "LOG IN"
        login.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(34, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(248, 30)
        Label2.TabIndex = 3
        Label2.Text = "LOGIN TO DASHBOARD"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(username)
        Panel2.Controls.Add(Label3)
        Panel2.Cursor = Cursors.IBeam
        Panel2.Location = New Point(34, 146)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(319, 61)
        Panel2.TabIndex = 5
        ' 
        ' username
        ' 
        username.BorderStyle = BorderStyle.None
        username.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        username.Location = New Point(20, 27)
        username.Name = "username"
        username.Size = New Size(279, 18)
        username.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.GrayText
        Label3.Location = New Point(15, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 12)
        Label3.TabIndex = 0
        Label3.Text = "USERNAME"
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(822, 559)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Salon Management System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()




    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents login As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents username As TextBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetButtonShape(login)
    End Sub
    Private Sub SetButtonShape(button As Button)
        Dim path As New Drawing2D.GraphicsPath()
        Dim rectangle As New Rectangle(0, 0, button.Width, button.Height)
        Dim radiusX As Integer = 40 ' Adjust the X radius for the desired roundness (horizontal radius)
        Dim radiusY As Integer = 20 ' Adjust the Y radius for the desired roundness (vertical radius)

        ' Add rounded corners to the GraphicsPath
        path.AddArc(rectangle.Left, rectangle.Top, radiusX, radiusY, 180, 90)
        path.AddArc(rectangle.Right - radiusX, rectangle.Top, radiusX, radiusY, 270, 90)
        path.AddArc(rectangle.Right - radiusX, rectangle.Bottom - radiusY, radiusX, radiusY, 0, 90)
        path.AddArc(rectangle.Left, rectangle.Bottom - radiusY, radiusX, radiusY, 90, 90)

        ' Create a region from the GraphicsPath and set it as the button's region
        button.Region = New Region(path)
    End Sub

    Friend WithEvents Panel2 As Panel

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Dim panel = DirectCast(sender, Panel)
        Dim pen As New Pen(Color.Blue, 2) ' Change color and width as needed
        Dim rect As New Rectangle(0, 0, panel.Width - 1, panel.Height - 1)
        e.Graphics.DrawRectangle(pen, rect)
    End Sub

    Friend WithEvents Label3 As Label

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        username.Focus()
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents password As TextBox
    Friend WithEvents Label4 As Label

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Dim panel = DirectCast(sender, Panel)
        Dim pen As New Pen(Color.Blue, 2) ' Change color and width as needed
        Dim rect As New Rectangle(0, 0, panel.Width - 1, panel.Height - 1)
        e.Graphics.DrawRectangle(pen, rect)
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        password.Focus()
    End Sub

    Friend WithEvents CheckBox1 As CheckBox

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            password.PasswordChar = ""
        Else
            password.PasswordChar = "*"
        End If
    End Sub

    Friend WithEvents Label5 As Label

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    'Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
    'Dim Adminwindows As New adminwindows()
    '   Adminwindows.Show()
    'Me'.Hide()
    'End Sub
End Class
