Imports System.Data.OleDb
Imports System.Globalization
Imports System.Reflection.Emit
Imports System.Runtime.Remoting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports SalonManagement.adminwindows

Public Class formstaff
    Dim selectedscheduleID As Integer = -1

    Private Sub Panelout_Click(sender As Object, e As EventArgs) Handles Panelout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Form1.txtusername.Clear()
            Form1.txtpassword.Clear()
            Form1.txtusername.Focus()
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Clearappoint()
        ' Clear all form fields
        txtnameofcostumer.Clear()
        txtphonenumber.Clear()
        DTPappoint.MinDate = DateTime.Today
        cmbstatus.SelectedIndex = 0
        cmbtime.SelectedIndex = 0
        cmbservices.SelectedIndex = 0
        cmbstylist.SelectedIndex = 0


        ' Set focus back to the first field
        txtnameofcostumer.Focus()
    End Sub


    Private Sub Panelout_Paint(sender As Object, e As PaintEventArgs) Handles Panelout.Paint
        Dim borderColor As Color = Color.DeepPink

        ' Define the border width
        Dim borderWidth As Integer = 2

        ' Draw the border
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        Dim pen As New Pen(borderColor, borderWidth)
        e.Graphics.DrawRectangle(pen, rect)
    End Sub

    Private Sub lblout_Click(sender As Object, e As EventArgs) Handles lblout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Form1.txtusername.Clear()
            Form1.txtpassword.Clear()
            Form1.txtusername.Focus()
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub pbout_Click(sender As Object, e As EventArgs) Handles pbout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Form1.txtusername.Clear()
            Form1.txtpassword.Clear()
            Form1.txtusername.Focus()
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub lbldashboard_Click(sender As Object, e As EventArgs) Handles lbldashboard.Click
        lbldashboard.Font = New Font(lbldashboard.Font, FontStyle.Bold Or FontStyle.Underline)
        lblappoint.Font = New Font(lblappoint.Font.Name, lblappoint.Font.Size, FontStyle.Regular)
        panel_appoint.Visible = False
        panel_dashboard.Visible = True
        LoadSchedules()
    End Sub

    Private Sub lblappoint_Click(sender As Object, e As EventArgs) Handles lblappoint.Click
        lblappoint.Font = New Font(lblappoint.Font, FontStyle.Bold Or FontStyle.Underline)
        lbldashboard.Font = New Font(lbldashboard.Font.Name, lbldashboard.Font.Size, FontStyle.Regular)
        panel_dashboard.Visible = False
        panel_appoint.Visible = True
        cmbstatus.SelectedIndex = 0
        cmbtime.SelectedIndex = 0
        cmbservices.SelectedIndex = 0
        cmbstylist.SelectedIndex = 0
    End Sub

    Private Sub lblcostumer_Click(sender As Object, e As EventArgs) Handles lblcostumer.Click
        lblcostumer.Font = New Font(lblcostumer.Font, FontStyle.Bold Or FontStyle.Underline)
        lblstocks.Font = New Font(lblstocks.Font.Name, lblstocks.Font.Size, FontStyle.Regular)
        LoadSchedules()
    End Sub

    Private Sub lblstocks_Click(sender As Object, e As EventArgs) Handles lblstocks.Click
        lblstocks.Font = New Font(lblstocks.Font, FontStyle.Bold Or FontStyle.Underline)
        lblcostumer.Font = New Font(lblcostumer.Font.Name, lblstocks.Font.Size, FontStyle.Regular)
        InventoryIntoDataGridView()
    End Sub

    Private Sub InventoryIntoDataGridView()
        Try
            Using conn As New OleDbConnection(mycon)
                conn.Open()
                Dim query As String = "SELECT * FROM tblInventory"
                Using da As New OleDbDataAdapter(query, conn)
                    Dim ds As New DataSet
                    da.Fill(ds, "tblInventory")
                    dgvdashboard.DataSource = ds.Tables("tblInventory").DefaultView
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub formstaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_dashboard.Visible = False
        DTPappoint.MinDate = DateTime.Today
        DTPappoint.MaxDate = DateTime.Now.AddYears(1)
        lbldashboard.Font = New Font(lbldashboard.Font, FontStyle.Bold Or FontStyle.Underline)
        lblappoint.Font = New Font(lblappoint.Font.Name, lblappoint.Font.Size, FontStyle.Regular)
        panel_appoint.Visible = False
        panel_dashboard.Visible = True
        LoadSchedules()


        Try
            Using conn As New OleDbConnection(mycon)
                conn.Open()
                Dim query As String = "SELECT [Services] FROM tblservice"
                Using cmd As New OleDbCommand(query, conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cmbservices.Items.Add(reader("Services").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        Try
            Using conn As New OleDbConnection(mycon)
                conn.Open()
                Dim query As String = "SELECT [Stylist Name] FROM tblstylist"
                Using cmd As New OleDbCommand(query, conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Add each Stylist Name to the ComboBox
                            cmbstylist.Items.Add(reader("Stylist Name").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub panel_appoint_Paint(sender As Object, e As PaintEventArgs) Handles panel_appoint.Paint
        Dim panel = DirectCast(sender, Panel)
        Dim pen As New Pen(Color.Blue, 2) ' Change color and width as needed
        Dim rect As New Rectangle(0, 0, panel.Width - 1, panel.Height - 1)
        e.Graphics.DrawRectangle(pen, rect)
    End Sub

    Private Sub panel_dashboard_Paint(sender As Object, e As PaintEventArgs) Handles panel_dashboard.Paint
        Dim panel = DirectCast(sender, Panel)
        Dim pen As New Pen(Color.Blue, 2) ' Change color and width as needed
        Dim rect As New Rectangle(0, 0, panel.Width - 1, panel.Height - 1)
        e.Graphics.DrawRectangle(pen, rect)
    End Sub



    Private Sub lblsched_Click(sender As Object, e As EventArgs) Handles lblsched.Click
        ' Get the selected service, stylist, and other details
        Dim services As String = If(cmbservices.SelectedItem IsNot Nothing, cmbservices.SelectedItem.ToString(), "")
        Dim stylist As String = If(cmbstylist.SelectedItem IsNot Nothing, cmbstylist.SelectedItem.ToString(), "")
        Dim CName As String = txtnameofcostumer.Text.Trim()
        Dim PhoneNumber As String = txtphonenumber.Text.Trim()
        Dim selectedDate As DateTime = DTPappoint.Value
        Dim scheduleTime As String = If(cmbtime.SelectedItem IsNot Nothing, cmbtime.SelectedItem.ToString(), "")
        Dim Status As String = If(cmbstatus.SelectedItem IsNot Nothing, cmbstatus.SelectedItem.ToString(), "")

        If Not String.IsNullOrEmpty(scheduleTime) Then
            ' Parse the time string to a DateTime object (assumes 12-hour format with AM/PM)
            Dim parsedTime As DateTime
            If DateTime.TryParseExact(scheduleTime, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, parsedTime) Then
                ' Convert the parsed time back to a formatted string for sorting
                scheduleTime = parsedTime.ToString("HH:mm tt", CultureInfo.InvariantCulture)
            Else
                MessageBox.Show("Invalid time format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        ' Validate input data before confirming the schedule
        If String.IsNullOrEmpty(services) Then
            MessageBox.Show("Please select a service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(stylist) Then
            MessageBox.Show("Please select a stylist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(CName) Then
            MessageBox.Show("Please enter the Customer name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnameofcostumer.Focus()
            Return
        End If

        If String.IsNullOrEmpty(PhoneNumber) Then
            MessageBox.Show("Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtphonenumber.Focus()
            Return ' Exit the method without proceeding further
        End If

        ' Check for schedule conflicts
        If IsScheduleConflict(stylist, selectedDate, scheduleTime, Status) Then
            MessageBox.Show($"Checking conflict for Stylist: {stylist}, Schedule Date: {selectedDate.ToString("yyyy-MM-dd")}, Schedule Time: {scheduleTime}, Status: {Status}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return ' Exit the method without saving
        End If

        Try
            Using conn As New OleDbConnection(mycon)
                conn.Open()
                Dim query As String = "INSERT INTO tblappointment ([Services], [Stylist], [Costumer Name], [Contact Number], [Schedule], [Time], [Status]) " &
                              "VALUES (@service, @stylist, @customerName, @phoneNumber, @scheduleDate, @scheduleTime, @status)"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@service", services)
                    cmd.Parameters.AddWithValue("@stylist", stylist)
                    cmd.Parameters.AddWithValue("@customerName", CName)
                    cmd.Parameters.AddWithValue("@phoneNumber", PhoneNumber)
                    cmd.Parameters.AddWithValue("@scheduleDate", selectedDate.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@scheduleTime", scheduleTime)
                    cmd.Parameters.AddWithValue("@status", Status)

                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show("Schedule confirmed and saved to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvdashboard.DataSource = Nothing
            LoadSchedules()
            Clearappoint()
        Catch ex As Exception
            MessageBox.Show("Error saving schedule to database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function IsScheduleConflict(stylist As String, scheduleDate As DateTime, scheduleTime As String, status As String) As Boolean
        Try
            Using conn As New OleDbConnection(mycon)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM tblappointment WHERE [Stylist] = @Stylist AND [Schedule] = @scheduleDate AND [Time] = @scheduleTime AND [Status] = @status"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Stylist", stylist)
                    cmd.Parameters.AddWithValue("@scheduleDate", scheduleDate.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@scheduleTime", scheduleTime)
                    cmd.Parameters.AddWithValue("@status", status)

                    ' Debugging info - Display the parameters being used for comparison


                    Dim conflictCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' Return true if there is a conflict, false otherwise
                    Return conflictCount > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking schedule conflicts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True ' Consider it as a conflict to prevent insertion due to an error
        End Try
    End Function



    Private Sub LoadSchedules()
        Try
            Using conn As New OleDbConnection(mycon)
                conn.Open()
                Dim query As String = "SELECT * FROM tblappointment ORDER BY [Schedule], [Time] ASC"

                Using adapter As New OleDbDataAdapter(query, conn)
                    Dim scheduleTable As New DataTable()
                    adapter.Fill(scheduleTable)

                    ' Bind the schedule data to the DataGridView
                    dgvdashboard.DataSource = scheduleTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading schedules: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtphonenumber_TextChanged(sender As Object, e As EventArgs) Handles txtphonenumber.TextChanged
        Dim phoneNumber As String = txtphonenumber.Text.Trim()

        ' Check if the input consists of exactly 11 digits
        If phoneNumber.Length = 11 AndAlso phoneNumber.All(Function(c) Char.IsDigit(c)) Then
            ' Input is valid, set the text color to black
            txtphonenumber.ForeColor = Color.Black
        Else
            ' Input is invalid, set the text color to red
            txtphonenumber.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtphonenumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphonenumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "-" Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub dgvdashboard_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdashboard.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If Not IsDBNull(dgvdashboard.Rows(e.RowIndex).Cells(0).Value) Then
                Dim SID As Integer = Convert.ToInt32(dgvdashboard.Rows(e.RowIndex).Cells(0).Value)

                Dim services As String = If(Not IsDBNull(dgvdashboard.Rows(e.RowIndex).Cells(1).Value), dgvdashboard.Rows(e.RowIndex).Cells(1).Value.ToString(), "")
                Dim stylist As String = If(Not IsDBNull(dgvdashboard.Rows(e.RowIndex).Cells(2).Value), dgvdashboard.Rows(e.RowIndex).Cells(2).Value.ToString(), "")
                Dim Cname As String = If(Not IsDBNull(dgvdashboard.Rows(e.RowIndex).Cells(3).Value), dgvdashboard.Rows(e.RowIndex).Cells(3).Value.ToString(), "")
                Dim Cnum As String = If(Not IsDBNull(dgvdashboard.Rows(e.RowIndex).Cells(4).Value), dgvdashboard.Rows(e.RowIndex).Cells(4).Value.ToString(), "")
                Dim SDate As String = If(Not IsDBNull(dgvdashboard.Rows(e.RowIndex).Cells(5).Value), dgvdashboard.Rows(e.RowIndex).Cells(5).Value.ToString(), "")
                Dim STime As String = If(Not IsDBNull(dgvdashboard.Rows(e.RowIndex).Cells(6).Value), dgvdashboard.Rows(e.RowIndex).Cells(6).Value.ToString(), "")
                Dim SStatus As String = If(Not IsDBNull(dgvdashboard.Rows(e.RowIndex).Cells(7).Value), dgvdashboard.Rows(e.RowIndex).Cells(7).Value.ToString(), "")

                Dim formappoint As New formAppointEdit()
                formappoint.AdminFormReference = Me
                selectedscheduleID = SID

                formappoint.SetSID(SID)
                formappoint.SetServices(services)
                formappoint.SetStylist(stylist)
                formappoint.SetCname(Cname)
                formappoint.SetCnum(Cnum)
                formappoint.SetSDate(DTPappoint.Value.ToString("yyyy-MM-dd"))
                formappoint.SetSTime(STime)
                formappoint.SetSStatus(SStatus)
                formappoint.ShowDialog()
            Else
                ' Value is DBNull, do nothing
            End If
        End If

    End Sub

    Public Sub RefreshDashboard()
        Try
            ' Clear existing data in the DataGridView
            dgvdashboard.DataSource = Nothing
            dgvdashboard.Rows.Clear()

            ' Populate the DataGridView with updated data
            Dim query As String = "SELECT * FROM tblappointment" ' Replace YourTableName with the actual table name
            Using conn As New OleDbConnection(mycon)
                conn.Open()
                Using cmd As New OleDbCommand(query, conn)
                    Using adapter As New OleDbDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvdashboard.DataSource = table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error refreshing dashboard: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class