Imports System.Data.OleDb
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports SalonManagement.adminwindows

Public Class Forminventory

    Private adminFormRef As adminwindows

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
        Dim product As String = txtproduct.Text.Trim()
        Dim quantity As Integer
        Dim cost As Integer
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to register?", "Confirm Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If String.IsNullOrEmpty(product) Then
                MessageBox.Show("Please enter the product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtproduct.Focus()
                Return ' Exit the method without proceeding further
            End If

            If Not Integer.TryParse(txtquantity.Text, quantity) OrElse quantity <= 0 Then
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtquantity.Focus()
                Return ' Exit the method without proceeding further
            End If

            If Not Integer.TryParse(txtcost.Text, cost) OrElse cost < 0 Then
                MessageBox.Show("Please enter a valid cost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcost.Focus()
                Return ' Exit the method without proceeding further
            End If

            If IsproductTaken(product) Then
                MessageBox.Show("Username is already taken. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtproduct.Focus()
                Return ' Exit the method without proceeding further
            End If

            Try
                Using connection As New OleDbConnection(mycon)
                    connection.Open()
                    Dim query As String = "INSERT INTO tblInventory ([Product], [Quantity], [Cost]) VALUES (@product, @quantity, @cost)"
                    Using command As New OleDbCommand(query, connection)
                        command.Parameters.AddWithValue("@product", product)
                        command.Parameters.AddWithValue("@quantity", quantity)
                        command.Parameters.AddWithValue("@cost", cost)

                        command.ExecuteNonQuery()
                        MessageBox.Show("added successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DatagridShow()
                        Me.Close()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error adding info: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Class