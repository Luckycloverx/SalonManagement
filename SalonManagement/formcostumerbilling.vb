Imports System.Data.OleDb
Imports SalonManagement.adminwindows
Imports System.Windows.Forms
Imports SalonManagement.formbillout

Public Class formcostumerbilling

    Private adminFormRef As formstaff
    Private dgvInOtherForm As DataGridView


    Private Sub formcostumerbilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Public WriteOnly Property AdminFormReference As formstaff
        Set(value As formstaff)
            adminFormRef = value
        End Set
    End Property

    Public Sub SetSID(ByVal SID As String)
        txtSID.Text = SID
    End Sub

    Public Sub Setservices(ByVal services As String)
        txtservice.Text = services
    End Sub

    Public Sub Setstylist(ByVal stylist As String)
        txtstylist.Text = stylist
    End Sub

    Public Sub SetCName(ByVal CName As String)
        txtname.Text = CName
    End Sub

    Public Sub SetCost(ByVal Cost As String)
        txtservicecost.Text = Cost
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub

    'important
    Public Sub New(dataGridView As DataGridView)
        InitializeComponent()
        dgvInOtherForm = dataGridView
    End Sub



    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim services As String = txtservice.Text.Trim()
        Dim costStr As String = txtservicecost.Text.Trim()
        Dim appointmentID As String = txtSID.Text.Trim()

        If Not String.IsNullOrEmpty(services) AndAlso Not String.IsNullOrEmpty(costStr) AndAlso Not String.IsNullOrEmpty(appointmentID) Then
            Try
                Using connection As New OleDbConnection(mycon)
                    ' Open the connection
                    connection.Open()

                    ' Insert data into tblbilling
                    Dim billingQuery As String = "INSERT INTO tblbilling ([Services/Item],[Price]) VALUES (@services, @cost)"
                    Using billingCommand As New OleDbCommand(billingQuery, connection)
                        billingCommand.Parameters.AddWithValue("@services", services)
                        billingCommand.Parameters.AddWithValue("@cost", costStr)
                        billingCommand.ExecuteNonQuery()
                    End Using

                    ' Move data from tblAppointment to tblHistory using appointment ID
                    Dim historyInsertQuery As String = "INSERT INTO tblHistory (Services, Stylist, [Costumer Name], [Contact Number], Schedule, [Time], Status) " &
                                                       "SELECT Services, Stylist, [Costumer Name], [Contact Number], Schedule, [Time], 'Done' FROM tblAppointment WHERE ID = @appointmentID"
                    Using historyInsertCommand As New OleDbCommand(historyInsertQuery, connection)
                        historyInsertCommand.Parameters.AddWithValue("@appointmentID", appointmentID)
                        historyInsertCommand.ExecuteNonQuery()
                    End Using

                    ' Get the AppointmentID from tblHistory
                    Dim getAppointmentIDQuery As String = "SELECT MAX(ID) FROM tblHistory"
                    Using getAppointmentIDCommand As New OleDbCommand(getAppointmentIDQuery, connection)
                        Dim appointmentIDResult As Object = getAppointmentIDCommand.ExecuteScalar()
                        If appointmentIDResult IsNot Nothing AndAlso Not IsDBNull(appointmentIDResult) Then
                            Dim appointmentIDFromHistory As String = appointmentIDResult.ToString()



                            ' Reload the billing data in formbillout DataGridView
                            Dim billingForm As New formbillout()
                            billingForm.LoadBillingData()

                            ' Set the AppointmentID in txtHID of Formbillout
                            billingForm.txtHID.Text = appointmentIDFromHistory
                            billingForm.txtSID.Text = appointmentID

                            ' Show the billing form
                            billingForm.ShowDialog()

                            Me.Close()
                        Else
                            MessageBox.Show("Failed to get AppointmentID from tblHistory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                ' Display an error message if there's any issue with the database operation
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Inform the user to enter services, cost, and appointment ID before proceeding
            MessageBox.Show("Please enter services, cost, and appointment ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub












End Class