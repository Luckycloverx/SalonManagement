Imports System.Data.OleDb
Imports System.Reflection.Emit

Public Class formstaff
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
        panel_dashboard.Visible = True
    End Sub

    Private Sub lblappoint_Click(sender As Object, e As EventArgs) Handles lblappoint.Click
        lblappoint.Font = New Font(lblappoint.Font, FontStyle.Bold Or FontStyle.Underline)
        lbldashboard.Font = New Font(lbldashboard.Font.Name, lbldashboard.Font.Size, FontStyle.Regular)
    End Sub

    Private Sub lblcostumer_Click(sender As Object, e As EventArgs) Handles lblcostumer.Click
        lblcostumer.Font = New Font(lblcostumer.Font, FontStyle.Bold Or FontStyle.Underline)
        lblstocks.Font = New Font(lblstocks.Font.Name, lblstocks.Font.Size, FontStyle.Regular)
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
    End Sub
End Class