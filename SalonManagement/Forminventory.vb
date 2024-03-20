Imports System.Data.OleDb
Imports System.Net
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports SalonManagement.adminwindows

Public Class Forminventory

    Private adminFormRef As adminwindows

    Public Sub HideEdit()
        lbledit.Visible = False
        lblremove.Visible = False
        lblid.Visible = False
        txtPID.Visible = False
        panel_pid.Visible = False
    End Sub
    Public Sub ShowEdit()
        lbledit.Visible = True
        lblremove.Visible = True
        lbladd.Visible = False
        lblid.Visible = True
        txtPID.Visible = True
        panel_pid.Visible = True
        txtPID.ReadOnly = True
        txtPID.TabStop = False
    End Sub

    Public Sub SetID(ByVal prodID As String)
        txtPID.Text = prodID
    End Sub

    Public Sub Setproduct(ByVal product As String)
        txtproduct.Text = product
    End Sub

    Public Sub Setquantity(ByVal quantity As String)
        txtquantity.Text = quantity
    End Sub

    Public Sub Setcost(ByVal cost As String)
        txtcost.Text = cost
    End Sub

    Public Sub Setcategory(ByVal category As String)
        cmbcategory.SelectedItem = category
    End Sub




    Public WriteOnly Property AdminFormReference As adminwindows
        Set(value As adminwindows)
            adminFormRef = value
        End Set
    End Property

    Public Sub DatagridShow()
        Try
            If adminFormRef IsNot Nothing AndAlso adminFormRef.MyDataGridView IsNot Nothing Then
                ' Access the DataGridViewContainer and its DataGridViews
                Dim container As DataGridViewContainer = adminFormRef.MyDataGridView
                Dim inventoryGridView As DataGridView = container.Inventory

                Using conn As New OleDbConnection(mycon)
                    conn.Open()
                    Dim query As String = "SELECT * FROM tblInventory"
                    Using da As New OleDbDataAdapter(query, conn)
                        Dim ds As New DataSet
                        da.Fill(ds, "tblInventory")
                        ' Set the DataSource for the DataGridViews
                        inventoryGridView.DataSource = ds.Tables("tblInventory").DefaultView
                    End Using
                End Using
            Else
                MessageBox.Show("AdminFormRef or MyDataGridView is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub lblclose_Click(sender As Object, e As EventArgs) Handles lblclose.Click
        Me.Close()
    End Sub

    Private Sub Panel_product_Paint(sender As Object, e As PaintEventArgs) Handles Panel_product.Paint
        txtproduct.Focus()
    End Sub

    Private Sub Panel_quantity_Click(sender As Object, e As EventArgs) Handles Panel_quantity.Click
        txtquantity.Focus()
    End Sub

    Private Sub Panel_cost_Click(sender As Object, e As EventArgs) Handles Panel_cost.Click
        txtcost.Focus()
    End Sub

    Private Sub lbladd_Click(sender As Object, e As EventArgs) Handles lbladd.Click
        ' Get the input values and trim whitespace
        Dim Category As String = cmbcategory.SelectedItem.ToString()
        Dim product As String = txtproduct.Text.Trim()
        Dim quantityStr As String = txtquantity.Text.Trim()
        Dim costStr As String = txtcost.Text.Trim()

        ' Validate product name
        If String.IsNullOrEmpty(product) Then
            MessageBox.Show("Please enter the product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtproduct.Focus()
            Return ' Exit the method without proceeding further
        End If

        ' Validate quantity
        Dim quantity As Integer
        If Not Integer.TryParse(quantityStr, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Return ' Exit the method without proceeding further
        End If

        ' Validate cost
        Dim cost As Integer
        If Not Integer.TryParse(costStr, cost) OrElse cost < 0 Then
            MessageBox.Show("Please enter a valid cost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcost.Focus()
            Return ' Exit the method without proceeding further
        End If

        ' Check if product is already taken
        If IsproductTaken(product) Then
            MessageBox.Show("Product is already registered. Please choose a different product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtproduct.Focus()
            Return ' Exit the method without proceeding further
        End If

        ' Confirmation dialog before registering
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to register this product?", "Confirm Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using connection As New OleDbConnection(mycon)
                    connection.Open()
                    Dim query As String = "INSERT INTO tblInventory ([Category], ([Product], [Quantity], [Cost]) VALUES (@Category, @product, @quantity, @cost)"
                    Using command As New OleDbCommand(query, connection)
                        command.Parameters.AddWithValue("@category", Category)
                        command.Parameters.AddWithValue("@product", product)
                        command.Parameters.AddWithValue("@quantity", quantity)
                        command.Parameters.AddWithValue("@cost", cost)

                        command.ExecuteNonQuery()
                        MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Update the DataGridView to reflect the changes
                        DatagridShow()
                        Me.Close()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error adding product information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Function IsproductTaken(product As String) As Boolean
        ' Check if the username already exists in the database
        Using connection As New OleDbConnection(mycon)
            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM tblInventory WHERE [Product] = @Product"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Product", product)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub Forminventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If TypeOf Me.ParentForm Is adminwindows Then
            Dim adminForm As adminwindows = DirectCast(Me.ParentForm, adminwindows)
            AdminFormReference = adminForm
            DatagridShow()
        End If
    End Sub

    Private Sub lbledit_Click(sender As Object, e As EventArgs) Handles lbledit.Click
        Dim Category As String = cmbcategory.SelectedItem.ToString()
        Dim product As String = txtproduct.Text.Trim()
        Dim quantity As Integer
        Dim cost As Double
        Dim selectedID As String = txtPID.Text
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to edit?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Validate and convert quantity
            If Not Integer.TryParse(txtquantity.Text.Trim(), quantity) OrElse quantity <= 0 Then
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtquantity.Focus()
                Return ' Exit the method without proceeding further
            End If

            ' Validate and convert cost
            If Not Double.TryParse(txtcost.Text.Trim(), cost) OrElse cost < 0 Then
                MessageBox.Show("Please enter a valid cost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcost.Focus()
                Return ' Exit the method without proceeding further
            End If

            ' Validation code for product name can be added here if needed

            Try
                Using connection As New OleDbConnection(mycon)
                    connection.Open()
                    Dim query As String = "Update tblInventory SET [Category] = @Category, [Product] = @product, [Quantity] = @quantity, [Cost] = @cost WHERE [ID] = @ID"

                    Using command As New OleDbCommand(query, connection)
                        command.Parameters.AddWithValue("@Category", Category)
                        command.Parameters.AddWithValue("@product", product)
                        command.Parameters.AddWithValue("@quantity", quantity)
                        command.Parameters.AddWithValue("@Cost", cost)
                        command.Parameters.AddWithValue("@ID", selectedID)

                        command.ExecuteNonQuery()
                        MessageBox.Show("Updated successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Call DatagridShow() after updating the inventory data
                        DatagridShow()

                        Me.Close()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating info: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub txtquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "-" Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub txtcost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcost.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "-" Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub lblremove_Click(sender As Object, e As EventArgs) Handles lblremove.Click
        Dim selectedproductID As String = txtPID.Text
        If selectedproductID <> -1 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this Product?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM tblInventory WHERE [ID] = @productID"
                    Using command As New OleDbCommand(query, conn)
                        command.Parameters.AddWithValue("@productID", selectedproductID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("product removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Optionally, you can inform the parent form about the deletion

                        DatagridShow()

                        Me.Close() ' Close the form after successful removal
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error removing product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try
            End If
        Else
            MessageBox.Show("Please select an product to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class