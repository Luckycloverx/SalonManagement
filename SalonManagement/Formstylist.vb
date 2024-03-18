Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports SalonManagement.adminwindows

Public Class Formstylist

    Private adminFormRef As adminwindows
    Private selectedstylistID As Integer = -1

    Public Sub SetstyleID(ByVal stylistID As String)
        txtSID.Text = stylistID
    End Sub

    Public Sub SetFirstName(ByVal firstname As String)
        txtfname.Text = firstname
    End Sub

    Public Sub SetLastName(ByVal lastName As String)
        txtlname.Text = lastName
    End Sub

    Public Sub SetMiddleName(ByVal middleName As String)
        txtmname.Text = middleName
    End Sub

    Public Sub Setage(ByVal age As String)
        txtage.Text = age
    End Sub

    Public Sub Setgender(ByVal gender As String)
        cmbGender.SelectedItem = gender
    End Sub

    Public Sub Setaddress(ByVal address As String)
        txtaddress.Text = address
    End Sub

    Public Sub setphonenumber(ByVal phonenumber As String)
        txtpnum.Text = phonenumber
    End Sub

    Public Sub setstylistname(ByVal stylistname As String)
        txtstylishname.Text = stylistname
    End Sub






    Public Sub DatagridShow()
        Try
            If adminFormRef IsNot Nothing AndAlso adminFormRef.MyDataGridView IsNot Nothing Then
                ' Access the DataGridViewContainer and its DataGridViews
                Dim container As DataGridViewContainer = adminFormRef.MyDataGridView
                Dim stylistGridView As DataGridView = container.Stylist

                Using conn As New OleDbConnection(mycon)
                    conn.Open()
                    Dim query As String = "SELECT * FROM tblstylist"
                    Using da As New OleDbDataAdapter(query, conn)
                        Dim ds As New DataSet
                        da.Fill(ds, "tblstylist")

                        ' Set the DataSource for the DataGridViews
                        stylistGridView.DataSource = ds.Tables("tblstylist").DefaultView
                    End Using
                End Using
            Else
                MessageBox.Show("AdminFormRef or MyDataGridView is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public WriteOnly Property AdminFormReference As adminwindows
        Set(value As adminwindows)
            adminFormRef = value
        End Set
    End Property

    Public Sub ShowRegisterLabel()
        lblregister.Visible = True
        lblupdate.Visible = False
        lblremove.Visible = False
        txtSID.Visible = False
        lblsid.Visible = False
        panelsid.Visible = False
    End Sub

    Public Sub ShowupdateLabel()
        lblregister.Visible = False
        lblupdate.Visible = True
        lblremove.Visible = True
        txtSID.Visible = True
        lblsid.Visible = True
        panelsid.Visible = True
    End Sub



    Private Sub ClearForm()
        ' Clear all form fields
        txtfname.Clear()
        txtmname.Clear()
        txtlname.Clear()
        txtage.Clear()
        txtaddress.Clear()
        txtpnum.Clear()
        txtstylishname.Clear()

        ' Set focus back to the first field
        txtfname.Focus()
    End Sub

    Private Sub lblregister_Click(sender As Object, e As EventArgs) Handles lblregister.Click
        Dim firstName As String = txtfname.Text.Trim()
        Dim middleName As String = txtmname.Text.Trim()
        Dim lastName As String = txtlname.Text.Trim()
        Dim age As Integer
        Dim gender As String = cmbGender.SelectedItem.ToString()
        Dim address As String = txtaddress.Text.Trim()
        Dim phoneNumber As String = txtpnum.Text.Trim()
        Dim stylistname As String = txtstylishname.Text.Trim()

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to register?", "Confirm Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            If String.IsNullOrEmpty(firstName) Then
                MessageBox.Show("Please enter first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtfname.Focus()
                Return ' Exit the method without proceeding further
            End If

            If String.IsNullOrEmpty(lastName) Then
                MessageBox.Show("Please enter last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtlname.Focus()
                Return ' Exit the method without proceeding further
            End If

            If Not Integer.TryParse(txtage.Text, age) OrElse age < 0 OrElse age > 120 Then
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
                txtpnum.Focus()
                Return ' Exit the method without proceeding further
            End If

            If String.IsNullOrEmpty(stylistname) Then
                MessageBox.Show("Please enter stylist name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtstylishname.Focus()
                Return ' Exit the method without proceeding further
            End If

            ' Check if the username is already in use
            If IsstylistTaken(stylistname) Then
                MessageBox.Show("Username is already taken. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtstylishname.Focus()
                Return ' Exit the method without proceeding further
            End If

            Try
                Using connection As New OleDbConnection(mycon)
                    connection.Open()
                    Dim query As String = "INSERT INTO tblstylist ([First Name], [Middle Name], [Last Name], [Age], [Gender], [Address], [Phone Number], [Stylist Name]) VALUES (@FirstName, @MiddleName, @LastName, @Age, @Gender, @Address, @PhoneNumber, @Stylistname)"
                    Using command As New OleDbCommand(query, connection)
                        command.Parameters.AddWithValue("@FirstName", firstName)
                        command.Parameters.AddWithValue("@MiddleName", middleName)
                        command.Parameters.AddWithValue("@LastName", lastName)
                        command.Parameters.AddWithValue("@Age", age)
                        command.Parameters.AddWithValue("@Gender", gender)
                        command.Parameters.AddWithValue("@Address", address)
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                        command.Parameters.AddWithValue("@Stylistname", stylistname)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DatagridShow()
                        Me.Close()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error adding info: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If
    End Sub

    Private Function IsstylistTaken(stylistname As String) As Boolean
        ' Check if the username already exists in the database
        Using connection As New OleDbConnection(mycon)
            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM tblstylist WHERE [Stylist Name] = @stylistname"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@stylistname", stylistname)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0 ' If count > 0, username is taken; otherwise, it's available
            End Using
        End Using
    End Function

    Private Sub txtage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtage.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "-" Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub txtpnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpnum.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "-" Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub txtpnum_TextChanged(sender As Object, e As EventArgs) Handles txtpnum.TextChanged
        Dim phoneNumber As String = txtpnum.Text.Trim()

        ' Check if the input consists of exactly 11 digits
        If phoneNumber.Length = 11 AndAlso phoneNumber.All(Function(c) Char.IsDigit(c)) Then
            ' Input is valid, set the text color to black
            txtpnum.ForeColor = Color.Black
        Else
            ' Input is invalid, set the text color to red
            txtpnum.ForeColor = Color.Red
        End If
    End Sub

    Private Sub lblclear_Click(sender As Object, e As EventArgs) Handles lblclear.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ClearForm()
        End If
    End Sub

    Private Sub Formstylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbGender.SelectedItem = "Male"
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub

    Private Sub lblupdate_Click(sender As Object, e As EventArgs) Handles lblupdate.Click
        Dim firstName As String = txtfname.Text.Trim()
        Dim middleName As String = txtmname.Text.Trim()
        Dim lastName As String = txtlname.Text.Trim()
        Dim age As Integer
        Dim gender As String = cmbGender.SelectedItem.ToString()
        Dim address As String = txtaddress.Text.Trim()
        Dim phoneNumber As String = txtpnum.Text.Trim()
        Dim stylistname As String = txtstylishname.Text.Trim()
        Dim selectedstylistID As String = txtSID.Text

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Update?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            If String.IsNullOrEmpty(firstName) Then
                MessageBox.Show("Please enter first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtfname.Focus()
                Return ' Exit the method without proceeding further
            End If

            If String.IsNullOrEmpty(lastName) Then
                MessageBox.Show("Please enter last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtlname.Focus()
                Return ' Exit the method without proceeding further
            End If

            If Not Integer.TryParse(txtage.Text, age) OrElse age < 0 OrElse age > 120 Then
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
                txtpnum.Focus()
                Return ' Exit the method without proceeding further
            End If

            If String.IsNullOrEmpty(stylistname) Then
                MessageBox.Show("Please enter username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtstylishname.Focus()
                Return ' Exit the method without proceeding further
            End If

            Try
                Using connection As New OleDbConnection(mycon)
                    connection.Open()
                    Dim query As String = "Update tblstylist SET [First Name] = @FirstName, [Middle Name] = @MiddleName, [Last Name] = @LastName, [Age] = @Age, [Gender] = @Gender, [Address] = @Address, [Phone Number] = @PhoneNumber, [Stylist Name] = @Stylistname WHERE [ID] = @StylistID"

                    Using command As New OleDbCommand(query, connection)
                        command.Parameters.AddWithValue("@FirstName", firstName)
                        command.Parameters.AddWithValue("@MiddleName", middleName)
                        command.Parameters.AddWithValue("@LastName", lastName)
                        command.Parameters.AddWithValue("@Age", age)
                        command.Parameters.AddWithValue("@Gender", gender)
                        command.Parameters.AddWithValue("@Address", address)
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                        command.Parameters.AddWithValue("@Stylistname", stylistname)
                        command.Parameters.AddWithValue("@StylistID", selectedstylistID)

                        command.ExecuteNonQuery()
                        MessageBox.Show("Stylist information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DatagridShow()
                        Me.Close()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating employee information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try






        End If



    End Sub

    Private Sub txtfname_TextChanged(sender As Object, e As EventArgs) Handles txtfname.TextChanged
        ' Check if the text box is not empty and if the first character is lowercase
        If Not String.IsNullOrEmpty(txtfname.Text) AndAlso Char.IsLower(txtfname.Text(0)) Then
            ' Capitalize the first letter
            txtfname.Text = Char.ToUpper(txtfname.Text(0)) + txtfname.Text.Substring(1)
            ' Move the cursor to the end of the text box
            txtfname.SelectionStart = txtfname.Text.Length
        End If
    End Sub

    Private Sub txtlname_TextChanged(sender As Object, e As EventArgs) Handles txtlname.TextChanged
        ' Check if the text box is not empty and if the first character is lowercase
        If Not String.IsNullOrEmpty(txtlname.Text) AndAlso Char.IsLower(txtlname.Text(0)) Then
            ' Capitalize the first letter
            txtlname.Text = Char.ToUpper(txtlname.Text(0)) + txtlname.Text.Substring(1)
            ' Move the cursor to the end of the text box
            txtlname.SelectionStart = txtlname.Text.Length
        End If
    End Sub

    Private Sub txtmname_TextChanged(sender As Object, e As EventArgs) Handles txtmname.TextChanged
        ' Check if the text box is not empty and if the first character is lowercase
        If Not String.IsNullOrEmpty(txtmname.Text) AndAlso Char.IsLower(txtmname.Text(0)) Then
            ' Capitalize the first letter
            txtmname.Text = Char.ToUpper(txtmname.Text(0)) + txtmname.Text.Substring(1)
            ' Move the cursor to the end of the text box
            txtmname.SelectionStart = txtmname.Text.Length
        End If
    End Sub

    Private Sub lblremove_Click(sender As Object, e As EventArgs) Handles lblremove.Click
        Dim selectedStylistID As String = txtSID.Text
        If selectedStylistID <> -1 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this Stylist?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM tblstylist WHERE [ID] = @StylistID"
                    Using command As New OleDbCommand(query, conn)
                        command.Parameters.AddWithValue("@StylistID", selectedStylistID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Stylist removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Optionally, you can inform the parent form about the deletion

                        DatagridShow()

                        Me.Close() ' Close the form after successful removal
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error removing employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try
            End If
        Else
            MessageBox.Show("Please select an employee to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class