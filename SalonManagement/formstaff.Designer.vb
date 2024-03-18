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
        Me.lblappoint = New System.Windows.Forms.Label()
        Me.lblbilling = New System.Windows.Forms.Label()
        Me.Panelout = New System.Windows.Forms.Panel()
        Me.pbout = New System.Windows.Forms.PictureBox()
        Me.lblout = New System.Windows.Forms.Label()
        Me.lblsettings = New System.Windows.Forms.Label()
        Me.panel_dashboard = New System.Windows.Forms.Panel()
        Me.dgvdashboard = New System.Windows.Forms.DataGridView()
        Me.lblcostumer = New System.Windows.Forms.Label()
        Me.lblstocks = New System.Windows.Forms.Label()
        Me.Panelout.SuspendLayout()
        CType(Me.pbout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_dashboard.SuspendLayout()
        CType(Me.dgvdashboard, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lblappoint
        '
        Me.lblappoint.AutoSize = True
        Me.lblappoint.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblappoint.ForeColor = System.Drawing.Color.Navy
        Me.lblappoint.Location = New System.Drawing.Point(26, 144)
        Me.lblappoint.Name = "lblappoint"
        Me.lblappoint.Size = New System.Drawing.Size(100, 21)
        Me.lblappoint.TabIndex = 11
        Me.lblappoint.Text = "Appointment"
        '
        'lblbilling
        '
        Me.lblbilling.AutoSize = True
        Me.lblbilling.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbilling.ForeColor = System.Drawing.Color.Navy
        Me.lblbilling.Location = New System.Drawing.Point(26, 221)
        Me.lblbilling.Name = "lblbilling"
        Me.lblbilling.Size = New System.Drawing.Size(53, 21)
        Me.lblbilling.TabIndex = 12
        Me.lblbilling.Text = "Billing"
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
        'lblsettings
        '
        Me.lblsettings.AutoSize = True
        Me.lblsettings.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsettings.ForeColor = System.Drawing.Color.Navy
        Me.lblsettings.Location = New System.Drawing.Point(26, 300)
        Me.lblsettings.Name = "lblsettings"
        Me.lblsettings.Size = New System.Drawing.Size(65, 21)
        Me.lblsettings.TabIndex = 14
        Me.lblsettings.Text = "Settings"
        '
        'panel_dashboard
        '
        Me.panel_dashboard.Controls.Add(Me.lblstocks)
        Me.panel_dashboard.Controls.Add(Me.lblcostumer)
        Me.panel_dashboard.Controls.Add(Me.dgvdashboard)
        Me.panel_dashboard.Location = New System.Drawing.Point(244, 0)
        Me.panel_dashboard.Name = "panel_dashboard"
        Me.panel_dashboard.Size = New System.Drawing.Size(573, 569)
        Me.panel_dashboard.TabIndex = 15
        '
        'dgvdashboard
        '
        Me.dgvdashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdashboard.Location = New System.Drawing.Point(17, 122)
        Me.dgvdashboard.Name = "dgvdashboard"
        Me.dgvdashboard.Size = New System.Drawing.Size(544, 247)
        Me.dgvdashboard.TabIndex = 0
        '
        'lblcostumer
        '
        Me.lblcostumer.AutoSize = True
        Me.lblcostumer.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcostumer.ForeColor = System.Drawing.Color.Navy
        Me.lblcostumer.Location = New System.Drawing.Point(34, 52)
        Me.lblcostumer.Name = "lblcostumer"
        Me.lblcostumer.Size = New System.Drawing.Size(165, 21)
        Me.lblcostumer.TabIndex = 12
        Me.lblcostumer.Text = "costumer appointment"
        '
        'lblstocks
        '
        Me.lblstocks.AutoSize = True
        Me.lblstocks.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstocks.ForeColor = System.Drawing.Color.Navy
        Me.lblstocks.Location = New System.Drawing.Point(409, 52)
        Me.lblstocks.Name = "lblstocks"
        Me.lblstocks.Size = New System.Drawing.Size(110, 21)
        Me.lblstocks.TabIndex = 13
        Me.lblstocks.Text = "product stocks"
        '
        'formstaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 569)
        Me.Controls.Add(Me.panel_dashboard)
        Me.Controls.Add(Me.lblsettings)
        Me.Controls.Add(Me.Panelout)
        Me.Controls.Add(Me.lblbilling)
        Me.Controls.Add(Me.lblappoint)
        Me.Controls.Add(Me.lbldashboard)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formstaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formstaff"
        Me.Panelout.ResumeLayout(False)
        Me.Panelout.PerformLayout()
        CType(Me.pbout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_dashboard.ResumeLayout(False)
        Me.panel_dashboard.PerformLayout()
        CType(Me.dgvdashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbldashboard As Label
    Friend WithEvents lblappoint As Label
    Friend WithEvents lblbilling As Label
    Friend WithEvents Panelout As Panel
    Friend WithEvents pbout As PictureBox
    Friend WithEvents lblout As Label
    Friend WithEvents lblsettings As Label
    Friend WithEvents panel_dashboard As Panel
    Friend WithEvents lblstocks As Label
    Friend WithEvents lblcostumer As Label
    Friend WithEvents dgvdashboard As DataGridView
End Class
