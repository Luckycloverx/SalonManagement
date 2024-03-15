Imports System.Data.OleDb


Public Class adminwindows
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter

    Private Sub adminwindows_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            ' Define your maximum size
            Dim maxWidth As Integer = 800 ' Set your desired maximum width
            Dim maxHeight As Integer = 600 ' Set your desired maximum height

            ' Adjust the form's size if it exceeds the maximum size
            If Me.Width > maxWidth Then
                Me.Width = maxWidth
            End If

            If Me.Height > maxHeight Then
                Me.Height = maxHeight
            End If
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Dim borderColor As Color = Color.DeepPink

        ' Define the border width
        Dim borderWidth As Integer = 2

        ' Draw the border
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        Dim pen As New Pen(borderColor, borderWidth)
        e.Graphics.DrawRectangle(pen, rect)
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.Font = New Font(Label3.Font, FontStyle.Bold Or FontStyle.Underline)
        Employee_management.Visible = True


    End Sub

    Private Sub adminwindows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Employee_management.Visible = False
        editemployee.Visible = False
    End Sub

    Private Sub DatagridShow()

        da = New OleDbDataAdapter("Select * from Employee_database", conn)
        ds = New DataSet
        da.Fill(ds, "Employee_database")
        employeeView.DataSource = ds.Tables("Employee_database").DefaultView



    End Sub

    Private Sub Employee_management_Paint(sender As Object, e As PaintEventArgs) Handles Employee_management.Paint
        Dim panel = DirectCast(sender, Panel)
        Dim pen As New Pen(Color.Blue, 2) ' Change color and width as needed
        Dim rect As New Rectangle(0, 0, panel.Width - 1, panel.Height - 1)
        e.Graphics.DrawRectangle(pen, rect)
    End Sub

    Private Sub edit_employee_Click(sender As Object, e As EventArgs) Handles edit_employee.Click
        edit_employee.Font = New Font(edit_employee.Font, FontStyle.Bold Or FontStyle.Underline)
        editemployee.Visible = True
        DatagridShow()
    End Sub

    Private Sub editemployee_Paint(sender As Object, e As PaintEventArgs) Handles editemployee.Paint
        Dim borderColor As Color = Color.Blue

        ' Define the border width
        Dim borderWidth As Integer = 2

        ' Draw the border
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        Dim pen As New Pen(borderColor, borderWidth)
        e.Graphics.DrawRectangle(pen, rect)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles add_employee.Click
        Dim form3 As New adding_employee()
        form3.HideUpdateLabel()
        form3.ShowRegisterLabel()
        form3.ShowDialog()
    End Sub

    Private Sub employeeView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles employeeView.CellClick
        Dim form3 As New adding_employee()
        form3.HideRegisterLabel()
        form3.ShowUpdateLabel()
        form3.ShowDialog()
    End Sub


End Class