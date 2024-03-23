Imports System.Data.OleDb
Imports SalonManagement.adminwindows
Imports System.Drawing.Printing

Public Class formbillout
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer


    Private Sub formbillout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBillingData()
        LoadProductsIntoComboBox()
        CalculateTotalCost()
        cmbpwd.SelectedIndex = 0
        PD.DefaultPageSettings.Landscape = True
    End Sub

    Public Sub LoadBillingData()
        Try
            Using connection As New OleDbConnection(mycon)
                connection.Open()
                Dim query As String = "SELECT [Services/Item], [Price] FROM tblbilling"
                Using da As New OleDbDataAdapter(query, connection)
                    Dim ds As New DataSet
                    da.Fill(ds, "tblbilling")
                    DataGridView1.DataSource = ds.Tables("tblbilling")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading billing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateInventoryQuantity(productName As String, quantityToAdd As Integer)
        Try
            Using connection As New OleDbConnection(mycon)
                connection.Open()

                ' Update the Quantity in tblInventory by adding quantityToAdd to the existing quantity
                Dim updateQuery As String = "UPDATE tblInventory SET [Quantity] = [Quantity] + @quantityToAdd WHERE [Product] = @productName"
                Using updateCommand As New OleDbCommand(updateQuery, connection)
                    updateCommand.Parameters.AddWithValue("@quantityToAdd", quantityToAdd)
                    updateCommand.Parameters.AddWithValue("@productName", productName)
                    updateCommand.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Display an error message if there's any issue with the database operation
            MessageBox.Show("Error updating inventory quantity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub LoadProductsIntoComboBox()
        Try
            Using connection As New OleDbConnection(mycon)
                connection.Open()
                Dim query As String = "SELECT [Product], [Quantity] FROM tblInventory WHERE [Quantity] > 0"
                Console.WriteLine("SQL Query: " & query) ' Debugging output

                Using cmd As New OleDbCommand(query, connection)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        cmbservices.Items.Clear() ' Clear existing items first
                        Dim recordCount As Integer = 0 ' Counter for debugging

                        While reader.Read()
                            Dim productName As String = reader("Product").ToString()
                            Dim productQuantity As Integer = Convert.ToInt32(reader("Quantity"))
                            cmbservices.Items.Add(productName)

                            ' For debugging purposes
                            Console.WriteLine("Product Name: " & productName & ", Quantity: " & productQuantity)
                            recordCount += 1
                        End While

                        ' Debugging output for record count
                        Console.WriteLine("Total Records Retrieved: " & recordCount)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub










    Private Sub CalculateTotalCost()
        Dim totalCost As Decimal = 0

        ' Iterate through DataGridView1 to sum up the Price values
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("Price").Value IsNot Nothing Then
                Dim price As Decimal = 0
                If Decimal.TryParse(row.Cells("Price").Value.ToString(), price) Then
                    totalCost += price
                Else
                    ' Handle invalid price format (optional)
                    MessageBox.Show("Invalid price format in row " & row.Index + 1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Next

        ' Check if the discount option is selected (e.g., cmbpwd.SelectedItem = "Yes")
        If cmbpwd.SelectedItem IsNot Nothing AndAlso cmbpwd.SelectedItem.ToString() = "YES" Then
            ' Apply a 5% discount
            totalCost *= 0.95 ' 5% discount (100% - 5%)
        End If

        ' Update txttotalcost with the calculated total cost
        txttotalcost.Text = totalCost.ToString("0.00") ' Format to display two decimal places
        CalculateChange()
    End Sub

    Private Sub lblcancel_Click(sender As Object, e As EventArgs) Handles lblcancel.Click
        Dim appointmentIDToDelete As String = txtHID.Text.Trim()
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to close?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                ' Check if the cell value is not Nothing and not DBNull
                If row.Cells("Services/Item").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("Services/Item").Value) Then
                    Dim productName As String = row.Cells("Services/Item").Value.ToString()
                    UpdateInventoryQuantity(productName, 1)
                End If
            Next
            If Not String.IsNullOrEmpty(appointmentIDToDelete) Then
                Try
                    Using connection As New OleDbConnection(mycon)
                        ' Open the connection
                        connection.Open()

                        ' Delete the entry from tblHistory using the AppointmentID
                        Dim deleteQuery As String = "DELETE FROM tblHistory WHERE ID = @appointmentID"
                        Using deleteCommand As New OleDbCommand(deleteQuery, connection)
                            deleteCommand.Parameters.AddWithValue("@appointmentID", appointmentIDToDelete)
                            Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()

                            If rowsAffected > 0 Then



                            Else

                            End If
                        End Using
                    End Using

                    ' Call the method to increment quantity in tblInventory for each product in DataGridView1

                Catch ex As Exception
                    ' Display an error message if there's any issue with the database operation
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                ' Inform the user that AppointmentID is required

            End If
            ' Call the method to delete all records from tblbilling
            DeleteAllRecordsFromBillingTable()
            ' Close the form
            Me.Close()
        End If
    End Sub



    Private Sub DeleteAllRecordsFromBillingTable()
        Try
            Using connection As New OleDbConnection(mycon)
                ' Open the connection
                connection.Open()

                ' SQL query to delete all records from tblbilling
                Dim query As String = "DELETE FROM tblbilling"

                Using command As New OleDbCommand(query, connection)
                    ' Execute the query
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Inform the user that records have been successfully deleted

        Catch ex As Exception
            ' Display an error message if there's any issue with the database operation
            MessageBox.Show("Error deleting records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetProductCost(productName As String)
        Try
            Using connection As New OleDbConnection(mycon)
                connection.Open()
                Dim query As String = "SELECT [Cost] FROM tblInventory WHERE [Product] = @productName"
                Using cmd As New OleDbCommand(query, connection)
                    cmd.Parameters.AddWithValue("@productName", productName)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        txtcost.Text = result.ToString() ' Set the product cost in txtcost TextBox
                    Else
                        txtcost.Text = "0" ' Set a default value if the product cost is not found
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving product cost: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbservices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbservices.SelectedIndexChanged
        If cmbservices.SelectedItem IsNot Nothing Then
            ' Get the selected product
            Dim selectedProduct As String = cmbservices.SelectedItem.ToString()

            ' Set the cost of the selected product in txtcost TextBox
            SetProductCost(selectedProduct)
        End If
    End Sub

    Private Sub lbladd_Click(sender As Object, e As EventArgs) Handles lbladd.Click
        If cmbservices.SelectedItem IsNot Nothing Then
            Dim selectedService As String = cmbservices.SelectedItem.ToString()
            Dim costStr As String = txtcost.Text.Trim()

            If Not String.IsNullOrEmpty(selectedService) AndAlso Not String.IsNullOrEmpty(costStr) Then
                Try
                    Using connection As New OleDbConnection(mycon)
                        ' Open the connection
                        connection.Open()

                        ' SQL query to insert data into tblbilling
                        Dim query As String = "INSERT INTO tblbilling ([Services/Item], [Price]) VALUES (@service, @cost)"
                        Using command As New OleDbCommand(query, connection)
                            command.Parameters.AddWithValue("@service", selectedService)
                            command.Parameters.AddWithValue("@cost", costStr)

                            command.ExecuteNonQuery()

                            ' Inform the user that data has been successfully inserted
                            MessageBox.Show("Data inserted into tblbilling.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Update the inventory quantity
                            UpdateInventoryQuantity(selectedService, -1)
                            LoadProductsIntoComboBox()

                            ' Clear the ComboBox and TextBox after insertion
                            cmbservices.SelectedIndex = 0
                            txtcost.Clear()

                            ' Reload the billing data in formbillout DataGridView
                            LoadBillingData()
                            CalculateTotalCost()
                            CalculateChange()
                        End Using
                    End Using
                Catch ex As Exception
                    ' Display an error message if there's any issue with the database operation
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Please enter a valid service and cost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a service from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub cmbpwd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpwd.SelectedIndexChanged
        CalculateTotalCost()
    End Sub

    Private Sub txtpayment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpayment.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "-" Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub CalculateChange()
        If Not String.IsNullOrEmpty(txttotalcost.Text) AndAlso Not String.IsNullOrEmpty(txtpayment.Text) Then
            Dim totalCost As Decimal = Decimal.Parse(txttotalcost.Text)
            Dim paymentAmount As Decimal = Decimal.Parse(txtpayment.Text)

            ' Calculate change amount
            Dim changeAmount As Decimal = paymentAmount - totalCost

            ' Display change amount in txtchange TextBox
            txtchange.Text = changeAmount.ToString("0.00")
        End If
    End Sub

    Private Sub txtpayment_TextChanged(sender As Object, e As EventArgs) Handles txtpayment.TextChanged
        CalculateChange()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500) ' Set paper size to a custom size
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        ' Define fonts with adjusted sizes for compact printing
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)

        ' Define brush for drawing
        Dim brush As New SolidBrush(Color.Black)

        ' Define padding for compact layout
        Dim padding As Integer = 5 ' Adjusted padding for compact printing

        ' Calculate center margin dynamically
        Dim centerMargin As Integer = e.MarginBounds.Left + (e.MarginBounds.Width \ 2)

        'font alignment
        Dim right As New StringFormat
        Dim Left As New StringFormat
        Dim center As New StringFormat

        ' Draw title with adjusted font size and centered horizontally
        Dim titleText As String = "Salon Management ni Jayvee"
        Dim titleSize As SizeF = e.Graphics.MeasureString(titleText, f10b)
        Dim titleX As Integer = centerMargin - CInt(titleSize.Width / 2)
        Dim titleY As Integer = 20 ' Adjust as needed for vertical position
        e.Graphics.DrawString(titleText, f10b, brush, titleX, titleY)

        ' Draw date and time with adjusted font size and centered horizontally
        Dim dateTimeText As String = "Date: " & DateTime.Now.ToShortDateString() & " Time: " & DateTime.Now.ToShortTimeString()
        Dim dateTimeSize As SizeF = e.Graphics.MeasureString(dateTimeText, f8)
        Dim dateTimeX As Integer = centerMargin - CInt(dateTimeSize.Width / 2)
        Dim dateTimeY As Integer = titleY + CInt(titleSize.Height) + padding
        e.Graphics.DrawString(dateTimeText, f8, brush, dateTimeX, dateTimeY)

        ' Draw line separator
        Dim line As String = New String("-", 100) ' Adjust the number of dashes as needed
        e.Graphics.DrawString(line, f8, brush, 0, dateTimeY + 20)

        ' Draw "Price" and "Services/Item" labels with adjusted font size and specific positions
        Dim priceText As String = "Price"
        Dim servicesText As String = "Services/Item"
        Dim priceSize As SizeF = e.Graphics.MeasureString(priceText, f8)
        Dim servicesSize As SizeF = e.Graphics.MeasureString(servicesText, f8)
        Dim priceX As Integer = 180 ' Adjust X position for Price label
        Dim servicesX As Integer = 30 ' Adjust X position for Services/Item label
        Dim labelsY As Integer = dateTimeY + 40 ' Adjust Y position for both labels
        e.Graphics.DrawString(priceText, f8, Brushes.Black, priceX, labelsY, right)
        e.Graphics.DrawString(servicesText, f8, Brushes.Black, servicesX, labelsY, Left)

        ' Draw rows from DataGridView with adjusted font size and spacing, aligned with labels
        Dim dataStartX As Integer = servicesX ' Start X position for data rows aligned with Services/Item label
        Dim dataY As Integer = labelsY + CInt(f8.Height) + padding ' Adjust the starting Y position for data rows
        For row As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim startX As Integer = dataStartX ' Reset start X position for each row
            For col As Integer = 0 To DataGridView1.Columns.Count - 1
                Dim cellValue As String = If(DataGridView1.Rows(row).Cells(col).Value IsNot Nothing, DataGridView1.Rows(row).Cells(col).Value.ToString(), "")
                e.Graphics.DrawString(cellValue, f8, brush, startX, dataY)
                startX += 150 ' Adjust as needed based on column width
            Next
            dataY += CInt(f8.Height) + padding ' Adjust padding between rows
        Next

        ' Draw line separator
        e.Graphics.DrawString(line, f8, brush, 0, dataY)

        ' Draw total cost and payment details with adjusted font size and spacing, centered horizontally
        Dim totalCostText As String = "Total Cost: ₱" & txttotalcost.Text
        Dim paymentText As String = "Payment: ₱" & txtpayment.Text
        Dim changeText As String = "Change: ₱" & txtchange.Text

        dataY += CInt(f8.Height) + padding ' Adjust padding before totals
        e.Graphics.DrawString(totalCostText, f10b, brush, centerMargin - (e.Graphics.MeasureString(totalCostText, f10b).Width / 2), dataY)
        dataY += CInt(f10b.Height) + padding
        e.Graphics.DrawString(paymentText, f10b, brush, centerMargin - (e.Graphics.MeasureString(paymentText, f10b).Width / 2), dataY)
        dataY += CInt(f10b.Height) + padding
        e.Graphics.DrawString(changeText, f10b, brush, centerMargin - (e.Graphics.MeasureString(changeText, f10b).Width / 2), dataY)
    End Sub












    Sub changelongpaper()
        Dim rowcount As Integer = DataGridView1.Rows.Count
        longpaper = rowcount * 15 + 240 ' Additional space for headers and total cost/payment details

        ' Set the height of the print document based on the calculated longpaper value
        PD.DefaultPageSettings.PaperSize = New PaperSize("Custom", 250, longpaper)
    End Sub



    Private Sub lblprint_Click(sender As Object, e As EventArgs) Handles lblprint.Click
        If String.IsNullOrEmpty(txtpayment.Text) Then
            MessageBox.Show("Please enter the payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Decimal.TryParse(txtchange.Text, Nothing) AndAlso Decimal.Parse(txtchange.Text) < 0 Then
            MessageBox.Show("Change amount cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Ask for confirmation before proceeding
            Dim confirmResult As DialogResult = MessageBox.Show("Proceed to printing?", "Confirm Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmResult = DialogResult.Yes Then
                If Not String.IsNullOrEmpty(txtSID.Text) Then
                    Dim appointmentID As Integer = Convert.ToInt32(txtSID.Text)

                    Try
                        Using connection As New OleDbConnection(mycon)
                            connection.Open()

                            ' Delete record from tblAppointment based on appointmentID
                            Dim deleteQuery As String = "DELETE FROM tblAppointment WHERE ID = @appointmentID"
                            Using deleteCommand As New OleDbCommand(deleteQuery, connection)
                                deleteCommand.Parameters.AddWithValue("@appointmentID", appointmentID)
                                deleteCommand.ExecuteNonQuery()
                            End Using

                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else

                End If
                ' Proceed with printing
                changelongpaper()
                PPD.Document = PD
                PPD.ShowDialog()
            End If
        End If
    End Sub


End Class
