<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formstaff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbldashboard = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panelout = New System.Windows.Forms.Panel()
        Me.pbout = New System.Windows.Forms.PictureBox()
        Me.lblout = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panelout.SuspendLayout()
        CType(Me.pbout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Salon Management "
        '
        'lbldashboard
        '
        Me.lbldashboard.AutoSize = True
        Me.lbldashboard.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldashboard.ForeColor = System.Drawing.Color.Navy
        Me.lbldashboard.Location = New System.Drawing.Point(26, 71)
        Me.lbldashboard.Name = "lbldashboard"
        Me.lbldashboard.Size = New System.Drawing.Size(85, 21)
        Me.lbldashboard.TabIndex = 9
        Me.lbldashboard.Text = "DashBoard"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(26, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Appointment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(26, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Billing"
        '
        'Panelout
        '
        Me.Panelout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelout.Controls.Add(Me.pbout)
        Me.Panelout.Controls.Add(Me.lblout)
        Me.Panelout.Location = New System.Drawing.Point(30, 513)
        Me.Panelout.Name = "Panelout"
        Me.Panelout.Size = New System.Drawing.Size(112, 35)
        Me.Panelout.TabIndex = 13
        '
        'pbout
        '
        Me.pbout.Image = Global.SalonManagement.My.Resources.Resources.sign_out
        Me.pbout.Location = New System.Drawing.Point(4, 2)
        Me.pbout.Name = "pbout"
        Me.pbout.Size = New System.Drawing.Size(27, 30)
        Me.pbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbout.TabIndex = 0
        Me.pbout.TabStop = False
        '
        'lblout
        '
        Me.lblout.AutoSize = True
        Me.lblout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblout.ForeColor = System.Drawing.Color.DeepPink
        Me.lblout.Location = New System.Drawing.Point(31, 5)
        Me.lblout.Name = "lblout"
        Me.lblout.Size = New System.Drawing.Size(74, 21)
        Me.lblout.TabIndex = 9
        Me.lblout.Text = "Sign out"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(26, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Settings"
        '
        'formstaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 569)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panelout)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbldashboard)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formstaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formstaff"
        Me.Panelout.ResumeLayout(False)
        Me.Panelout.PerformLayout()
        CType(Me.pbout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbldashboard As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panelout As Panel
    Friend WithEvents pbout As PictureBox
    Friend WithEvents lblout As Label
    Friend WithEvents Label2 As Label
End Class
