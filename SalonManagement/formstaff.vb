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
End Class