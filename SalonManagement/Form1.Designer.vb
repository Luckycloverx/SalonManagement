Imports System.Data.OleDb
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.login = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Location = New System.Drawing.Point(2, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SALON MANAGEMENT SYSTEM"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.login)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(400, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 559)
        Me.Panel1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(13, 530)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "EXIT"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(50, 300)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(99, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "show password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtpassword)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Panel3.Location = New System.Drawing.Point(34, 233)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(319, 61)
        Me.Panel3.TabIndex = 6
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(20, 27)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(279, 18)
        Me.txtpassword.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(15, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "PASSWORD"
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.Navy
        Me.login.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.SystemColors.Control
        Me.login.Location = New System.Drawing.Point(34, 352)
        Me.login.Name = "login"
        Me.login.Padding = New System.Windows.Forms.Padding(10)
        Me.login.Size = New System.Drawing.Size(319, 49)
        Me.login.TabIndex = 2
        Me.login.Text = "LOG IN"
        Me.login.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(34, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "LOGIN TO DASHBOARD"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtusername)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Panel2.Location = New System.Drawing.Point(34, 146)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(319, 61)
        Me.Panel2.TabIndex = 5
        '
        'txtusername
        '
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(20, 27)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(279, 18)
        Me.txtusername.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(15, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "USERNAME"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(822, 559)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salon Management System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents login As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusername As TextBox

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
        txtusername.Focus()
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label4 As Label

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Dim panel = DirectCast(sender, Panel)
        Dim pen As New Pen(Color.Blue, 2) ' Change color and width as needed
        Dim rect As New Rectangle(0, 0, panel.Width - 1, panel.Height - 1)
        e.Graphics.DrawRectangle(pen, rect)
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        txtpassword.Focus()
    End Sub

    Friend WithEvents CheckBox1 As CheckBox

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Friend WithEvents Label5 As Label

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim username As String = txtusername.Text.Trim()
        Dim password As String = txtpassword.Text.Trim()

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim isAdmin As Boolean = False

            ' Query the admin database to check if the user is an admin
            Dim adminQuery As String = "SELECT COUNT(*) FROM admin WHERE Username = @Username AND Password = @Password"
            Using adminConn As New OleDbConnection(mycon),
              adminCommand As New OleDbCommand(adminQuery, adminConn)

                adminCommand.Parameters.AddWithValue("@Username", username)
                adminCommand.Parameters.AddWithValue("@Password", password)

                adminConn.Open()
                Dim adminCount As Integer = Convert.ToInt32(adminCommand.ExecuteScalar())
                If adminCount > 0 Then
                    isAdmin = True
                End If
            End Using

            If isAdmin Then
                ' Proceed to admin form
                Dim adminForm As New adminwindows()
                adminForm.Show()
                Me.Hide()
            Else
                ' Query the staff database to check if the user is a staff member
                Dim staffQuery As String = "SELECT COUNT(*) FROM Employee_database WHERE Username = @Username AND Password = @Password"
                Using staffConn As New OleDbConnection(mycon),
                  staffCommand As New OleDbCommand(staffQuery, staffConn)

                    staffCommand.Parameters.AddWithValue("@Username", username)
                    staffCommand.Parameters.AddWithValue("@Password", password)

                    staffConn.Open()
                    Dim staffCount As Integer = Convert.ToInt32(staffCommand.ExecuteScalar())
                    If staffCount > 0 Then
                        ' Proceed to staff form
                        Dim staffForm As New formstaff()
                        staffForm.Show()
                        Me.Hide()
                    Else
                        ' Invalid credentials
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class
