﻿Imports System.Data.OleDb
Public Class formAppointEdit
    Private adminFormRef As formstaff

    Public Sub SetSID(ByVal SID As String)
        txtSID.Text = SID
    End Sub
    Public Sub SetServices(ByVal services As String)
        cmbservices.Items.Clear()

        Try
            Using conn As New OleDbConnection(mycon)
                conn.Open()
                Dim queryServices As String = "SELECT DISTINCT [Services] FROM tblservice"
                Using cmdServices As New OleDbCommand(queryServices, conn)
                    Using readerServices As OleDbDataReader = cmdServices.ExecuteReader()
                        While readerServices.Read()
                            cmbservices.Items.Add(readerServices("Services").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Select the specified service if it exists
        If cmbservices.Items.Contains(services) Then
            cmbservices.SelectedItem = services
        End If
    End Sub
    Public Sub SetStylist(ByVal stylist As String)
        cmbstylist.Items.Clear()

        Try
            Using conn As New OleDbConnection(mycon)
                conn.Open()
                Dim queryStylists As String = "SELECT DISTINCT [Stylist Name] FROM tblstylist"
                Using cmdStylists As New OleDbCommand(queryStylists, conn)
                    Using readerStylists As OleDbDataReader = cmdStylists.ExecuteReader()
                        While readerStylists.Read()
                            cmbstylist.Items.Add(readerStylists("Stylist Name").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Select the specified stylist if it exists
        If cmbstylist.Items.Contains(stylist) Then
            cmbstylist.SelectedItem = stylist
        End If
    End Sub
    Public Sub SetCname(ByVal Cname As String)
        txtnameofcostumer.Text = Cname
    End Sub
    Public Sub SetCnum(ByVal Cnum As String)
        txtphonenumber.Text = Cnum
    End Sub
    Public Sub SetSDate(ByVal SDate As String)
        Dim parsedDate As DateTime
        If DateTime.TryParse(SDate, parsedDate) Then
            DTPappoint.Value = parsedDate
        Else
            ' Handle the case where the date string is not in a valid format
            MessageBox.Show("Invalid date format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub SetSTime(ByVal STime As String)
        If cmbtime.Items.Contains(STime) Then
            cmbtime.SelectedItem = STime
        Else
            ' Handle the case where the provided time is not found in the ComboBox
            MessageBox.Show("Time not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub SetSStatus(ByVal SStatus As String)
        If cmbstatus.Items.Contains(SStatus) Then
            cmbstatus.SelectedItem = SStatus
        Else
            ' Handle the case where the provided status is not found in the ComboBox
            MessageBox.Show("Status not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public WriteOnly Property AdminFormReference As formstaff
        Set(value As formstaff)
            adminFormRef = value
        End Set
    End Property

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub

    Public Sub SaveChanges()
        Try
            Using conn As New OleDbConnection(mycon)
                conn.Open()

                ' Check if the appointment already exists with the same stylist, schedule date, and schedule time
                Dim existingAppointmentQuery As String = "SELECT COUNT(*) FROM tblappointment WHERE [Stylist] = @Stylist AND [Schedule] = @ScheduledDate AND [Time] = @ScheduledTime AND ID <> @SID"
                Using cmdExisting As New OleDbCommand(existingAppointmentQuery, conn)
                    cmdExisting.Parameters.AddWithValue("@Stylist", cmbstylist.SelectedItem.ToString())
                    cmdExisting.Parameters.AddWithValue("@ScheduledDate", DTPappoint.Value.ToString("yyyy-MM-dd"))
                    cmdExisting.Parameters.AddWithValue("@ScheduledTime", cmbtime.SelectedItem.ToString())
                    cmdExisting.Parameters.AddWithValue("@SID", txtSID.Text)
                    Dim appointmentCount As Integer = Convert.ToInt32(cmdExisting.ExecuteScalar())

                    If appointmentCount > 0 Then
                        MessageBox.Show("Appointment with the same stylist, schedule date, and schedule time already exists.", "Duplicate Appointment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return ' Exit the method without saving changes
                    End If
                End Using

                ' Continue updating the appointment if it's not a duplicate
                Dim query As String = "UPDATE tblappointment SET [Services] = @Services, [Stylist] = @Stylist, [Costumer Name] = @CostumerName, [Contact Number] = @CostumerNumber, [Schedule] = @ScheduledDate, [Time] = @ScheduledTime, [Status] = @Status WHERE ID = @SID"

                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Services", cmbservices.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Stylist", cmbstylist.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@CostumerName", txtnameofcostumer.Text)
                    cmd.Parameters.AddWithValue("@CostumerNumber", txtphonenumber.Text)
                    cmd.Parameters.AddWithValue("@ScheduledDate", DTPappoint.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@ScheduledTime", cmbtime.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Status", cmbstatus.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@SID", txtSID.Text)

                    cmd.ExecuteNonQuery()
                End Using


                MessageBox.Show("Schedule updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MoveToCancelledDatabase(conn As OleDbConnection)
        Try
            Dim insertQuery As String = "INSERT INTO tblHistory ([Services], [Stylist], [Costumer Name], [Contact Number], [Schedule], [Time], [Status]) VALUES (@Services, @Stylist, @CostumerName, @CostumerNumber, @ScheduledDate, @ScheduledTime, @Status)"

            Using cmd As New OleDbCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@Services", cmbservices.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Stylist", cmbstylist.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@CostumerName", txtnameofcostumer.Text)
                cmd.Parameters.AddWithValue("@CostumerNumber", txtphonenumber.Text)
                cmd.Parameters.AddWithValue("@ScheduledDate", DTPappoint.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@ScheduledTime", cmbtime.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Status", cmbstatus.SelectedItem.ToString())

                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error moving to cancelled database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub formAppointEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTPappoint.MinDate = DateTime.Today
        DTPappoint.MaxDate = DateTime.Now.AddYears(1)
        LoadScheduleTimes()
    End Sub

    Private Sub lbleditsched_Click(sender As Object, e As EventArgs) Handles lbleditsched.Click
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to edit this schedule?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            SaveChanges()
            Dim formstaff As formstaff = Application.OpenForms("formstaff")
            If formstaff IsNot Nothing Then
                formstaff.RefreshDashboard()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub LoadScheduleTimes()
        ' Clear existing items in the ComboBox
        cmbtime.Items.Clear()

        ' Get the selected date from the DateTimePicker
        Dim selectedDate As DateTime = DTPappoint.Value

        ' Get the current date and time
        Dim currentTime As DateTime = DateTime.Now

        ' Set the minimum schedule time based on the current time and selected date
        Dim minScheduleTime As DateTime
        If selectedDate.Date = currentTime.Date Then
            ' If the selected date is today, start from the current hour
            minScheduleTime = New DateTime(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, 0, 0)
        Else
            ' If the selected date is not today, start from 8:00 AM
            minScheduleTime = New DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, 8, 0, 0)
        End If

        ' Set the maximum schedule time (up to 9:00 PM)
        Dim maxScheduleTime As DateTime = New DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, 21, 0, 0)

        ' Populate the ComboBox with schedule times starting from the minimum time up to the maximum time
        While minScheduleTime <= maxScheduleTime
            cmbtime.Items.Add(minScheduleTime.ToString("hh:mm tt"))
            minScheduleTime = minScheduleTime.AddHours(1) ' Increment by 1 hour
        End While

        ' Check if the ComboBox has items before setting SelectedIndex
        If cmbtime.Items.Count > 0 Then
            cmbtime.SelectedIndex = 0 ' Set the default selected schedule time
        End If
    End Sub

    Private Sub DTPappoint_ValueChanged(sender As Object, e As EventArgs) Handles DTPappoint.ValueChanged
        LoadScheduleTimes()
    End Sub
End Class