Imports System.Data.OleDb
Public Class adding_employee
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter
    Dim comm As New OleDbCommand

    Public Sub ShowRegisterLabel()
        Label1.Visible = True 'register
    End Sub

    Public Sub HideRegisterLabel()
        Label1.Visible = False 'register
    End Sub

    Public Sub ShowUpdateLabel()
        lblupdate.Visible = True
    End Sub

    Public Sub HideUpdateLabel()
        lblupdate.Visible = False
    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs)
        Dim borderColor As Color = Color.Blue

        ' Define the border width
        Dim borderWidth As Integer = 2

        ' Draw the border
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        Dim pen As New Pen(borderColor, borderWidth)
        e.Graphics.DrawRectangle(pen, rect)
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        f_name.Focus()
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        l_name.Focus()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        m_name.Focus()
    End Sub



    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        txtaddress.Focus()
    End Sub

    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click
        p_number.Focus()
    End Sub

    Private Sub Panel8_Click(sender As Object, e As EventArgs) Handles Panel8.Click
        uname.Focus()
    End Sub

    Private Sub Panel9_Click(sender As Object, e As EventArgs) Handles Panel9.Click
        txtPassword.Focus()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        txtage.Focus()
    End Sub

    Private Sub age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtage.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "-" Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub


    Private Sub p_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles p_number.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim firstName As String = f_name.Text.Trim()
        Dim middleName As String = m_name.Text.Trim()
        Dim lastName As String = l_name.Text.Trim()
        Dim age As Integer
        Dim gender As String = cmbGender.SelectedItem.ToString()
        Dim address As String = txtaddress.Text.Trim()
        Dim phoneNumber As String = p_number.Text.Trim()
        Dim username As String = uname.Text.Trim()
        Dim password As String = txtPassword.Text

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to register?", "Confirm Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            If String.IsNullOrEmpty(firstName) Then
                MessageBox.Show("Please enter first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                f_name.Focus()
                Return ' Exit the method without proceeding further
            End If

            If String.IsNullOrEmpty(lastName) Then
                MessageBox.Show("Please enter last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                l_name.Focus()
                Return ' Exit the method without proceeding further
            End If

            If Not Integer.TryParse(txtage.Text, age) OrElse age <= 0 OrElse age > 120 Then
                MessageBox.Show("Please enter a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtage.Focus()
                Return ' Exit the method without proceeding further
            End If

            If String.IsNullOrEmpty(address) Then
                MessageBox.Show("Please enter address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtaddress.Focus()
                Return ' Exit the method without proceeding further
            End If

            If String.IsNullOrEmpty(phoneNumber) Then
                MessageBox.Show("Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_number.Focus()
                Return ' Exit the method without proceeding further
            End If

            If String.IsNullOrEmpty(username) Then
                MessageBox.Show("Please enter username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                uname.Focus()
                Return ' Exit the method without proceeding further
            End If

            If String.IsNullOrEmpty(password) Then
                MessageBox.Show("Please enter password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Focus()
                Return ' Exit the method without proceeding further
            End If

            ' Check if the username is already in use
            If IsUsernameTaken(username) Then
                MessageBox.Show("Username is already taken. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                uname.Focus()
                Return ' Exit the method without proceeding further
            End If

            ' Optional: Validate phone number format or length if needed



            Try
                Using connection As New OleDbConnection(mycon)
                    connection.Open()
                    Dim query As String = "INSERT INTO Employee_database ([First Name], [Middle Name], [Last Name], [Age], [Gender], [Address], [Phone Number], [Username], [Password]) VALUES (@FirstName, @MiddleName, @LastName, @Age, @Gender, @Address, @PhoneNumber, @Username, @Password)"
                    Using command As New OleDbCommand(query, connection)
                        command.Parameters.AddWithValue("@FirstName", firstName)
                        command.Parameters.AddWithValue("@MiddleName", middleName)
                        command.Parameters.AddWithValue("@LastName", lastName)
                        command.Parameters.AddWithValue("@Age", age)
                        command.Parameters.AddWithValue("@Gender", gender)
                        command.Parameters.AddWithValue("@Address", address)
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                        command.Parameters.AddWithValue("@Username", username)
                        command.Parameters.AddWithValue("@Password", password)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error adding info: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If

    End Sub

    Private Function IsUsernameTaken(username As String) As Boolean
        ' Check if the username already exists in the database
        Using connection As New OleDbConnection(mycon)
            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM Employee_database WHERE [Username] = @Username"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0 ' If count > 0, username is taken; otherwise, it's available
            End Using
        End Using
    End Function


    Private Sub adding_employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbGender.SelectedItem = "Male"
    End Sub

    Private Sub f_name_TextChanged(sender As Object, e As EventArgs) Handles f_name.TextChanged
        ' Check if the text box is not empty and if the first character is lowercase
        If Not String.IsNullOrEmpty(f_name.Text) AndAlso Char.IsLower(f_name.Text(0)) Then
            ' Capitalize the first letter
            f_name.Text = Char.ToUpper(f_name.Text(0)) + f_name.Text.Substring(1)
            ' Move the cursor to the end of the text box
            f_name.SelectionStart = f_name.Text.Length
        End If
    End Sub

    Private Sub l_name_TextChanged(sender As Object, e As EventArgs) Handles l_name.TextChanged
        ' Check if the text box is not empty and if the first character is lowercase
        If Not String.IsNullOrEmpty(l_name.Text) AndAlso Char.IsLower(l_name.Text(0)) Then
            ' Capitalize the first letter
            l_name.Text = Char.ToUpper(l_name.Text(0)) + l_name.Text.Substring(1)
            ' Move the cursor to the end of the text box
            l_name.SelectionStart = l_name.Text.Length
        End If
    End Sub

    Private Sub m_name_TextChanged(sender As Object, e As EventArgs) Handles m_name.TextChanged
        ' Check if the text box is not empty and if the first character is lowercase
        If Not String.IsNullOrEmpty(m_name.Text) AndAlso Char.IsLower(m_name.Text(0)) Then
            ' Capitalize the first letter
            m_name.Text = Char.ToUpper(m_name.Text(0)) + m_name.Text.Substring(1)
            ' Move the cursor to the end of the text box
            m_name.SelectionStart = m_name.Text.Length
        End If
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub

    Private validationPerformed As Boolean = False

    Private Sub p_number_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles p_number.Validating

        If Not validationPerformed Then
            ' Check if the entered text is numeric and exactly 11 digits
            If Not IsNumeric(p_number.Text) OrElse p_number.TextLength <> 11 Then
                ' Display an error message to the user
                MessageBox.Show("Phone number must be exactly 11 digits and contain only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Set focus back to the text box for the user to enter a valid phone number
                p_number.Focus()
                ' Cancel the validation
                e.Cancel = True
            End If

            ' Set the validation flag to true
            validationPerformed = True
        End If
    End Sub

    Private Sub p_number_TextChanged(sender As Object, e As EventArgs) Handles p_number.TextChanged
        Dim phoneNumber As String = p_number.Text.Trim()

        ' Check if the input consists of exactly 11 digits
        If phoneNumber.Length = 11 AndAlso phoneNumber.All(Function(c) Char.IsDigit(c)) Then
            ' Input is valid, set the text color to black
            p_number.ForeColor = Color.Black
        Else
            ' Input is invalid, set the text color to red
            p_number.ForeColor = Color.Red
        End If
    End Sub

End Class