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
        Me.lblout = New System.Windows.Forms.Label()
        Me.lblsettings = New System.Windows.Forms.Label()
        Me.panel_dashboard = New System.Windows.Forms.Panel()
        Me.lblstocks = New System.Windows.Forms.Label()
        Me.lblcostumer = New System.Windows.Forms.Label()
        Me.dgvdashboard = New System.Windows.Forms.DataGridView()
        Me.txtEID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.panel_appoint = New System.Windows.Forms.Panel()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.cmbstatus = New System.Windows.Forms.ComboBox()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.cmbtime = New System.Windows.Forms.ComboBox()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lblsched = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtphonenumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnameofcostumer = New System.Windows.Forms.TextBox()
        Me.cmbstylist = New System.Windows.Forms.ComboBox()
        Me.lblstylist = New System.Windows.Forms.Label()
        Me.lblservice = New System.Windows.Forms.Label()
        Me.cmbservices = New System.Windows.Forms.ComboBox()
        Me.DTPappoint = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbout = New System.Windows.Forms.PictureBox()
        Me.Panelout.SuspendLayout()
        Me.panel_dashboard.SuspendLayout()
        CType(Me.dgvdashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_appoint.SuspendLayout()
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
        'dgvdashboard
        '
        Me.dgvdashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdashboard.Location = New System.Drawing.Point(17, 122)
        Me.dgvdashboard.Name = "dgvdashboard"
        Me.dgvdashboard.Size = New System.Drawing.Size(544, 247)
        Me.dgvdashboard.TabIndex = 0
        '
        'txtEID
        '
        Me.txtEID.BackColor = System.Drawing.SystemColors.Control
        Me.txtEID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEID.Location = New System.Drawing.Point(167, 0)
        Me.txtEID.Name = "txtEID"
        Me.txtEID.Size = New System.Drawing.Size(29, 18)
        Me.txtEID.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label12.Location = New System.Drawing.Point(94, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Employee ID"
        '
        'panel_appoint
        '
        Me.panel_appoint.Controls.Add(Me.lblExit)
        Me.panel_appoint.Controls.Add(Me.cmbstatus)
        Me.panel_appoint.Controls.Add(Me.lblstatus)
        Me.panel_appoint.Controls.Add(Me.cmbtime)
        Me.panel_appoint.Controls.Add(Me.lbltime)
        Me.panel_appoint.Controls.Add(Me.lblsched)
        Me.panel_appoint.Controls.Add(Me.Label5)
        Me.panel_appoint.Controls.Add(Me.txtphonenumber)
        Me.panel_appoint.Controls.Add(Me.Label4)
        Me.panel_appoint.Controls.Add(Me.Label2)
        Me.panel_appoint.Controls.Add(Me.txtnameofcostumer)
        Me.panel_appoint.Controls.Add(Me.cmbstylist)
        Me.panel_appoint.Controls.Add(Me.lblstylist)
        Me.panel_appoint.Controls.Add(Me.lblservice)
        Me.panel_appoint.Controls.Add(Me.cmbservices)
        Me.panel_appoint.Controls.Add(Me.DTPappoint)
        Me.panel_appoint.Controls.Add(Me.Label3)
        Me.panel_appoint.Location = New System.Drawing.Point(245, 1)
        Me.panel_appoint.Name = "panel_appoint"
        Me.panel_appoint.Size = New System.Drawing.Size(573, 569)
        Me.panel_appoint.TabIndex = 17
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.Color.Navy
        Me.lblExit.Location = New System.Drawing.Point(12, 414)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(34, 21)
        Me.lblExit.TabIndex = 33
        Me.lblExit.Text = "Exit"
        Me.lblExit.Visible = False
        '
        'cmbstatus
        '
        Me.cmbstatus.DisplayMember = "Confirm"
        Me.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"Confirm", "Cancel"})
        Me.cmbstatus.Location = New System.Drawing.Point(157, 383)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbstatus.TabIndex = 32
        Me.cmbstatus.ValueMember = "Confirm"
        Me.cmbstatus.Visible = False
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.Navy
        Me.lblstatus.Location = New System.Drawing.Point(76, 383)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(51, 21)
        Me.lblstatus.TabIndex = 31
        Me.lblstatus.Text = "Status"
        Me.lblstatus.Visible = False
        '
        'cmbtime
        '
        Me.cmbtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtime.FormattingEnabled = True
        Me.cmbtime.Items.AddRange(New Object() {"08:00 AM", "09:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "01:00 PM", "02:00 PM", "03:00 PM", "04:00 PM", "05:00 PM", "06:00 PM", "07:00 PM", "08:00 PM", "09:00 PM"})
        Me.cmbtime.Location = New System.Drawing.Point(157, 347)
        Me.cmbtime.Name = "cmbtime"
        Me.cmbtime.Size = New System.Drawing.Size(121, 21)
        Me.cmbtime.TabIndex = 30
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Navy
        Me.lbltime.Location = New System.Drawing.Point(76, 347)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(43, 21)
        Me.lbltime.TabIndex = 29
        Me.lbltime.Text = "Time"
        '
        'lblsched
        '
        Me.lblsched.AutoSize = True
        Me.lblsched.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsched.ForeColor = System.Drawing.Color.Navy
        Me.lblsched.Location = New System.Drawing.Point(318, 414)
        Me.lblsched.Name = "lblsched"
        Me.lblsched.Size = New System.Drawing.Size(71, 21)
        Me.lblsched.TabIndex = 24
        Me.lblsched.Text = "schedule"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(76, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 21)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Schedule"
        '
        'txtphonenumber
        '
        Me.txtphonenumber.Location = New System.Drawing.Point(156, 263)
        Me.txtphonenumber.Name = "txtphonenumber"
        Me.txtphonenumber.Size = New System.Drawing.Size(122, 20)
        Me.txtphonenumber.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(25, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 21)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Contact Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(11, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 21)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Name of Costumer"
        '
        'txtnameofcostumer
        '
        Me.txtnameofcostumer.Location = New System.Drawing.Point(156, 220)
        Me.txtnameofcostumer.Name = "txtnameofcostumer"
        Me.txtnameofcostumer.Size = New System.Drawing.Size(233, 20)
        Me.txtnameofcostumer.TabIndex = 19
        '
        'cmbstylist
        '
        Me.cmbstylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstylist.FormattingEnabled = True
        Me.cmbstylist.Location = New System.Drawing.Point(216, 155)
        Me.cmbstylist.Name = "cmbstylist"
        Me.cmbstylist.Size = New System.Drawing.Size(121, 21)
        Me.cmbstylist.TabIndex = 18
        '
        'lblstylist
        '
        Me.lblstylist.AutoSize = True
        Me.lblstylist.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstylist.ForeColor = System.Drawing.Color.Navy
        Me.lblstylist.Location = New System.Drawing.Point(247, 131)
        Me.lblstylist.Name = "lblstylist"
        Me.lblstylist.Size = New System.Drawing.Size(49, 21)
        Me.lblstylist.TabIndex = 17
        Me.lblstylist.Text = "Stylist"
        '
        'lblservice
        '
        Me.lblservice.AutoSize = True
        Me.lblservice.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblservice.ForeColor = System.Drawing.Color.Navy
        Me.lblservice.Location = New System.Drawing.Point(65, 131)
        Me.lblservice.Name = "lblservice"
        Me.lblservice.Size = New System.Drawing.Size(65, 21)
        Me.lblservice.TabIndex = 16
        Me.lblservice.Text = "Services"
        '
        'cmbservices
        '
        Me.cmbservices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbservices.FormattingEnabled = True
        Me.cmbservices.Location = New System.Drawing.Point(37, 155)
        Me.cmbservices.Name = "cmbservices"
        Me.cmbservices.Size = New System.Drawing.Size(121, 21)
        Me.cmbservices.TabIndex = 15
        '
        'DTPappoint
        '
        Me.DTPappoint.Location = New System.Drawing.Point(156, 311)
        Me.DTPappoint.MinDate = New Date(2024, 3, 19, 0, 0, 0, 0)
        Me.DTPappoint.Name = "DTPappoint"
        Me.DTPappoint.Size = New System.Drawing.Size(200, 20)
        Me.DTPappoint.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "costumer appointment"
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
        'formstaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 569)
        Me.Controls.Add(Me.txtEID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblsettings)
        Me.Controls.Add(Me.Panelout)
        Me.Controls.Add(Me.lblbilling)
        Me.Controls.Add(Me.lblappoint)
        Me.Controls.Add(Me.lbldashboard)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel_dashboard)
        Me.Controls.Add(Me.panel_appoint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formstaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formstaff"
        Me.Panelout.ResumeLayout(False)
        Me.Panelout.PerformLayout()
        Me.panel_dashboard.ResumeLayout(False)
        Me.panel_dashboard.PerformLayout()
        CType(Me.dgvdashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_appoint.ResumeLayout(False)
        Me.panel_appoint.PerformLayout()
        CType(Me.pbout, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtEID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents panel_appoint As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents DTPappoint As DateTimePicker
    Friend WithEvents lblservice As Label
    Friend WithEvents cmbservices As ComboBox
    Friend WithEvents cmbstylist As ComboBox
    Friend WithEvents lblstylist As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnameofcostumer As TextBox
    Friend WithEvents txtphonenumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblsched As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbtime As ComboBox
    Friend WithEvents lbltime As Label
    Friend WithEvents cmbstatus As ComboBox
    Friend WithEvents lblstatus As Label
    Friend WithEvents lblExit As Label
End Class
