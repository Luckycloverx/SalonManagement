Imports System.Data.OleDb


Public Class adminwindows
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter
    Dim selectedEmployeeID As Integer = -1
    Dim selectedproductID As Integer = -1
    Private selectedstylistID As Integer = -1




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
            Form1.txtusername.Clear()
            Form1.txtpassword.Clear()
            Form1.txtusername.Focus()
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Form1.txtusername.Clear()
            Form1.txtpassword.Clear()
            Form1.txtusername.Focus()
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Form1.txtusername.Clear()
            Form1.txtpassword.Clear()
            Form1.txtusername.Focus()
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        lblfrontdesk.Font = New Font(lblfrontdesk.Font, FontStyle.Bold Or FontStyle.Underline)
        lblstylist.Font = New Font(lblstylist.Font.Name, lblstylist.Font.Size, FontStyle.Regular)
        lbldashboard.Font = New Font(lbldashboard.Font.Name, lbldashboard.Font.Size, FontStyle.Regular)
        add_employee.Visible = True
        lbladdstylist.Visible = False
        dgvstylist.Visible = False
        employeeView.Visible = True
        panel_dashboard.Visible = False
        Label3.Font = New Font(Label3.Font, FontStyle.Bold Or FontStyle.Underline)
        lblInventory.Font = New Font(lblInventory.Font.Name, lblInventory.Font.Size, FontStyle.Regular)
        Employee_management.Visible = True
        panel_Inventory.Visible = False
        Employee_management.BringToFront()
        panel_Inventory.SendToBack()
        DatagridShow()

    End Sub

    Private Sub lblInventory_Click(sender As Object, e As EventArgs) Handles lblInventory.Click
        lblInventory.Font = New Font(lblInventory.Font, FontStyle.Bold Or FontStyle.Underline)
        Label3.Font = New Font(Label3.Font.Name, Label3.Font.Size, FontStyle.Regular)
        lbldashboard.Font = New Font(lbldashboard.Font.Name, lbldashboard.Font.Size, FontStyle.Regular)
        panel_Inventory.Visible = True
        Employee_management.Visible = False
        panel_dashboard.Visible = False
        panel_Inventory.BringToFront()
        Employee_management.SendToBack()


        DatagridShow_in()
    End Sub

    Private Sub adminwindows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbldashboard.Font = New Font(lbldashboard.Font, FontStyle.Bold Or FontStyle.Underline)
        lblcostumer.Font = New Font(lblcostumer.Font, FontStyle.Bold Or FontStyle.Underline)
        lblInventory.Font = New Font(lblInventory.Font.Name, lblInventory.Font.Size, FontStyle.Regular)
        Label3.Font = New Font(Label3.Font.Name, Label3.Font.Size, FontStyle.Regular)
        lblhistory.Font = New Font(lblhistory.Font.Name, lblhistory.Font.Size, FontStyle.Regular)
        panel_dashboard.Visible = True
        panel_Inventory.Visible = False
        Employee_management.Visible = False
        LoadSchedules()
    End Sub

    Private Sub DatagridShow()
        da = New OleDbDataAdapter("Select * from Employee_database", conn)
        ds = New DataSet
        da.Fill(ds, "Employee_database")
        employeeView.DataSource = ds.Tables("Employee_database").DefaultView
    End Sub

    Private Sub DatagridShow_style()
        da = New OleDbDataAdapter("Select * from tblstylist", conn)
        ds = New DataSet
        da.Fill(ds, "tblstylist")
        dgvstylist.DataSource = ds.Tables("tblstylist").DefaultView
    End Sub

    Private Sub DatagridShow_in()
        da = New OleDbDataAdapter("Select * from tblInventory", conn)
        ds = New DataSet
        da.Fill(ds, "tblInventory")
        dgvinventory.DataSource = ds.Tables("tblInventory").DefaultView
    End Sub

    Private Sub Employee_management_Paint(sender As Object, e As PaintEventArgs) Handles Employee_management.Paint
        Dim panel = DirectCast(sender, Panel)
        Dim pen As New Pen(Color.Blue, 2) ' Change color and width as needed
        Dim rect As New Rectangle(0, 0, panel.Width - 1, panel.Height - 1)
        e.Graphics.DrawRectangle(pen, rect)
    End Sub
    Private Sub panel_Inventory_Paint(sender As Object, e As PaintEventArgs) Handles panel_Inventory.Paint
        Dim panel = DirectCast(sender, Panel)
        Dim pen As New Pen(Color.Blue, 2) ' Change color and width as needed
        Dim rect As New Rectangle(0, 0, panel.Width - 1, panel.Height - 1)
        e.Graphics.DrawRectangle(pen, rect)
    End Sub


    Private Sub editemployee_Paint(sender As Object, e As PaintEventArgs)
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
        form3.AdminFormReference = Me
        form3.HideUpdateLabel()
        form3.ShowRegisterLabel()
        form3.hideIDlabel()
        form3.hideremove()
        form3.ShowDialog()
    End Sub

    Public Class DataGridViewContainer
        Public Property Employees As DataGridView
        Public Property Inventory As DataGridView
        Public Property Stylist As DataGridView
    End Class

    Public ReadOnly Property MyDataGridView As DataGridViewContainer
        Get
            Dim container As New DataGridViewContainer()
            container.Employees = employeeView
            container.Inventory = dgvinventory
            container.Stylist = dgvstylist
            Return container
        End Get
    End Property




    Public Sub RefreshDataGridView()
        Try
            Dim da As New OleDbDataAdapter("Select * from Employee_database", conn)
            Dim ds As New DataSet
            da.Fill(ds, "Employee_database")
            employeeView.DataSource = ds.Tables("Employee_database").DefaultView
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub employeeView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles employeeView.CellClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If Not IsDBNull(employeeView.Rows(e.RowIndex).Cells(0).Value) AndAlso
               Not IsDBNull(employeeView.Rows(e.RowIndex).Cells(1).Value) AndAlso
               Not IsDBNull(employeeView.Rows(e.RowIndex).Cells(2).Value) AndAlso
               Not IsDBNull(employeeView.Rows(e.RowIndex).Cells(3).Value) AndAlso
               Not IsDBNull(employeeView.Rows(e.RowIndex).Cells(4).Value) AndAlso
               Not IsDBNull(employeeView.Rows(e.RowIndex).Cells(5).Value) AndAlso
               Not IsDBNull(employeeView.Rows(e.RowIndex).Cells(6).Value) AndAlso
               Not IsDBNull(employeeView.Rows(e.RowIndex).Cells(7).Value) AndAlso
               Not IsDBNull(employeeView.Rows(e.RowIndex).Cells(8).Value) AndAlso
               Not IsDBNull(employeeView.Rows(e.RowIndex).Cells(9).Value) Then

                ' Get the value from the clicked cell
                Dim employeeID As Integer = Convert.ToInt32(employeeView.Rows(e.RowIndex).Cells(0).Value)
                Dim firstName As String = employeeView.Rows(e.RowIndex).Cells(1).Value.ToString()
                Dim lastname As String = employeeView.Rows(e.RowIndex).Cells(3).Value.ToString()
                Dim middlename As String = employeeView.Rows(e.RowIndex).Cells(2).Value.ToString()
                Dim age As String = employeeView.Rows(e.RowIndex).Cells(4).Value.ToString()
                Dim gender As String = employeeView.Rows(e.RowIndex).Cells(5).Value.ToString()
                Dim address As String = employeeView.Rows(e.RowIndex).Cells(6).Value.ToString()
                Dim phonenumber As String = employeeView.Rows(e.RowIndex).Cells(7).Value.ToString()
                Dim username As String = employeeView.Rows(e.RowIndex).Cells(8).Value.ToString()
                Dim password As String = employeeView.Rows(e.RowIndex).Cells(9).Value.ToString()
                Dim form3 As New adding_employee()
                form3.AdminFormReference = Me
                form3.HideRegisterLabel()
                form3.ShowUpdateLabel()
                form3.ShowID()
                form3.showremove()
                selectedEmployeeID = employeeID

                ' Set in Form2 using the method
                form3.SetID(employeeID)
                form3.SetFirstName(firstName)
                form3.SetLastName(lastname)
                form3.SetMiddleName(middlename)
                form3.Setage(age)
                form3.Setgender(gender)
                form3.Setaddress(address)
                form3.setphonenumber(phonenumber)
                form3.setusername(username)
                form3.setpassword(password)
                form3.ShowDialog()
            Else
                ' Handle DBNull values if needed
            End If
        End If



    End Sub

    Private Sub lbladditem_Click(sender As Object, e As EventArgs) Handles lbladditem.Click
        Dim forminventory As New Forminventory()
        forminventory.cmbcategory.SelectedIndex = 0
        forminventory.HideEdit()
        forminventory.AdminFormReference = Me
        forminventory.DatagridShow()
        forminventory.ShowDialog()
    End Sub

    Private Sub dgvinventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvinventory.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If Not IsDBNull(dgvinventory.Rows(e.RowIndex).Cells(0).Value) AndAlso
       Not IsDBNull(dgvinventory.Rows(e.RowIndex).Cells(1).Value) AndAlso
       Not IsDBNull(dgvinventory.Rows(e.RowIndex).Cells(2).Value) AndAlso
       Not IsDBNull(dgvinventory.Rows(e.RowIndex).Cells(3).Value) AndAlso
       Not IsDBNull(dgvinventory.Rows(e.RowIndex).Cells(4).Value) Then

                Dim productID As Integer = Convert.ToInt32(dgvinventory.Rows(e.RowIndex).Cells(0).Value)
                Dim category As String = dgvinventory.Rows(e.RowIndex).Cells(1).Value.ToString()
                Dim product As String = dgvinventory.Rows(e.RowIndex).Cells(2).Value.ToString()
                Dim quantity As Integer = Convert.ToInt32(dgvinventory.Rows(e.RowIndex).Cells(3).Value)
                Dim cost As Double = Convert.ToDouble(dgvinventory.Rows(e.RowIndex).Cells(4).Value)

                Dim forminventory As New Forminventory()
                forminventory.ShowEdit()
                forminventory.AdminFormReference = Me
                selectedproductID = productID

                forminventory.Setcategory(category)
                forminventory.SetID(productID)
                forminventory.Setproduct(product)
                forminventory.Setquantity(quantity.ToString()) ' Convert to string if needed
                forminventory.Setcost(cost.ToString()) ' Convert to string if needed
                forminventory.ShowDialog()
            Else
                ' Handle DBNull values if needed

            End If
        End If
    End Sub


    Private Sub lblfrontdesk_Click(sender As Object, e As EventArgs) Handles lblfrontdesk.Click
        lblfrontdesk.Font = New Font(lblfrontdesk.Font, FontStyle.Bold Or FontStyle.Underline)
        lblstylist.Font = New Font(lblstylist.Font.Name, lblstylist.Font.Size, FontStyle.Regular)
        add_employee.Visible = True
        lbladdstylist.Visible = False
        dgvstylist.Visible = False
        employeeView.Visible = True
    End Sub

    Private Sub lblstylish_Click(sender As Object, e As EventArgs) Handles lblstylist.Click
        lblstylist.Font = New Font(lblstylist.Font, FontStyle.Bold Or FontStyle.Underline)
        lblfrontdesk.Font = New Font(lblfrontdesk.Font.Name, lblfrontdesk.Font.Size, FontStyle.Regular)
        add_employee.Visible = False
        lbladdstylist.Visible = True
        dgvstylist.Visible = True
        employeeView.Visible = False
        DatagridShow_style()

    End Sub

    Private Sub lbladdstylist_Click(sender As Object, e As EventArgs) Handles lbladdstylist.Click
        Dim formstyle As New Formstylist()
        formstyle.AdminFormReference = Me
        formstyle.ShowRegisterLabel()
        formstyle.ShowDialog()
    End Sub

    Private Sub dgvstylist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvstylist.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If Not IsDBNull(dgvstylist.Rows(e.RowIndex).Cells(0).Value) AndAlso
               Not IsDBNull(dgvstylist.Rows(e.RowIndex).Cells(1).Value) AndAlso
               Not IsDBNull(dgvstylist.Rows(e.RowIndex).Cells(2).Value) AndAlso
               Not IsDBNull(dgvstylist.Rows(e.RowIndex).Cells(3).Value) AndAlso
               Not IsDBNull(dgvstylist.Rows(e.RowIndex).Cells(4).Value) AndAlso
               Not IsDBNull(dgvstylist.Rows(e.RowIndex).Cells(5).Value) AndAlso
               Not IsDBNull(dgvstylist.Rows(e.RowIndex).Cells(6).Value) AndAlso
               Not IsDBNull(dgvstylist.Rows(e.RowIndex).Cells(7).Value) AndAlso
               Not IsDBNull(dgvstylist.Rows(e.RowIndex).Cells(8).Value) Then

                ' Get the value from the clicked cell
                Dim stylistID As Integer = Convert.ToInt32(dgvstylist.Rows(e.RowIndex).Cells(0).Value)
                Dim firstName As String = dgvstylist.Rows(e.RowIndex).Cells(1).Value.ToString()
                Dim lastname As String = dgvstylist.Rows(e.RowIndex).Cells(3).Value.ToString()
                Dim middlename As String = dgvstylist.Rows(e.RowIndex).Cells(2).Value.ToString()
                Dim age As String = dgvstylist.Rows(e.RowIndex).Cells(4).Value.ToString()
                Dim gender As String = dgvstylist.Rows(e.RowIndex).Cells(5).Value.ToString()
                Dim address As String = dgvstylist.Rows(e.RowIndex).Cells(6).Value.ToString()
                Dim phonenumber As String = dgvstylist.Rows(e.RowIndex).Cells(7).Value.ToString()
                Dim stylistname As String = dgvstylist.Rows(e.RowIndex).Cells(8).Value.ToString()
                Dim formstylist As New Formstylist()
                formstylist.AdminFormReference = Me
                formstylist.ShowupdateLabel()
                selectedstylistID = stylistID

                formstylist.SetstyleID(stylistID)
                formstylist.SetFirstName(firstName)
                formstylist.SetLastName(lastname)
                formstylist.SetMiddleName(middlename)
                formstylist.Setage(age)
                formstylist.Setgender(gender)
                formstylist.Setaddress(address)
                formstylist.setphonenumber(phonenumber)
                formstylist.setstylistname(stylistname)
                formstylist.ShowDialog()
            Else
                ' Handle DBNull values if needed
            End If
        End If

    End Sub

    Private Sub lbldashboard_Click(sender As Object, e As EventArgs) Handles lbldashboard.Click
        lbldashboard.Font = New Font(lbldashboard.Font, FontStyle.Bold Or FontStyle.Underline)
        lblcostumer.Font = New Font(lblcostumer.Font, FontStyle.Bold Or FontStyle.Underline)
        lblInventory.Font = New Font(lblInventory.Font.Name, lblInventory.Font.Size, FontStyle.Regular)
        Label3.Font = New Font(Label3.Font.Name, Label3.Font.Size, FontStyle.Regular)
        lblhistory.Font = New Font(lblhistory.Font.Name, lblhistory.Font.Size, FontStyle.Regular)
        panel_Inventory.Visible = False
        Employee_management.Visible = False
        panel_dashboard.Visible = True

        LoadSchedules()
    End Sub

    Private Sub HistoryIntoDataGridView()
        Try
            Using conn As New OleDbConnection(mycon)
                conn.Open()
                Dim query As String = "SELECT [Services], [Stylist], [Costumer Name], [Contact Number], Schedule, Time, Status FROM tblHistory"
                Using da As New OleDbDataAdapter(query, conn)
                    Dim ds As New DataSet
                    da.Fill(ds, "tblHistory")
                    dgvdashboard.DataSource = ds.Tables("tblHistory").DefaultView
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LoadSchedules()
        Try
            Using conn As New OleDbConnection(mycon)
                conn.Open()
                Dim query As String = "SELECT [Services], [Stylist], [Costumer Name], [Contact Number], Schedule, Time, Status FROM tblappointment ORDER BY [Schedule], [Time] ASC"

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

    Private Sub lblcostumer_Click(sender As Object, e As EventArgs) Handles lblcostumer.Click
        lblcostumer.Font = New Font(lblcostumer.Font, FontStyle.Bold Or FontStyle.Underline)
        lblhistory.Font = New Font(lblhistory.Font.Name, lblhistory.Font.Size, FontStyle.Regular)
        LoadSchedules()
    End Sub

    Private Sub lblhistory_Click(sender As Object, e As EventArgs) Handles lblhistory.Click
        lblhistory.Font = New Font(lblhistory.Font, FontStyle.Bold Or FontStyle.Underline)
        lblcostumer.Font = New Font(lblcostumer.Font.Name, lblcostumer.Font.Size, FontStyle.Regular)
        HistoryIntoDataGridView()
    End Sub

    Private Sub panel_dashboard_Paint(sender As Object, e As PaintEventArgs) Handles panel_dashboard.Paint
        Dim panel = DirectCast(sender, Panel)
        Dim pen As New Pen(Color.Blue, 2) ' Change color and width as needed
        Dim rect As New Rectangle(0, 0, panel.Width - 1, panel.Height - 1)
        e.Graphics.DrawRectangle(pen, rect)
    End Sub
End Class