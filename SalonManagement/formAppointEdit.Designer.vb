<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAppointEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbstylist = New System.Windows.Forms.ComboBox()
        Me.lblstylist = New System.Windows.Forms.Label()
        Me.lblservice = New System.Windows.Forms.Label()
        Me.cmbservices = New System.Windows.Forms.ComboBox()
        Me.txtphonenumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnameofcostumer = New System.Windows.Forms.TextBox()
        Me.cmbstatus = New System.Windows.Forms.ComboBox()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.cmbtime = New System.Windows.Forms.ComboBox()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPappoint = New System.Windows.Forms.DateTimePicker()
        Me.lbleditsched = New System.Windows.Forms.Label()
        Me.panel_pid = New System.Windows.Forms.Panel()
        Me.txtSID = New System.Windows.Forms.TextBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.panel_pid.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(14, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Close"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 21)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "costumer appointment"
        '
        'cmbstylist
        '
        Me.cmbstylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstylist.FormattingEnabled = True
        Me.cmbstylist.Location = New System.Drawing.Point(174, 68)
        Me.cmbstylist.Name = "cmbstylist"
        Me.cmbstylist.Size = New System.Drawing.Size(129, 21)
        Me.cmbstylist.TabIndex = 30
        '
        'lblstylist
        '
        Me.lblstylist.AutoSize = True
        Me.lblstylist.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstylist.ForeColor = System.Drawing.Color.Navy
        Me.lblstylist.Location = New System.Drawing.Point(222, 44)
        Me.lblstylist.Name = "lblstylist"
        Me.lblstylist.Size = New System.Drawing.Size(49, 21)
        Me.lblstylist.TabIndex = 29
        Me.lblstylist.Text = "Stylist"
        '
        'lblservice
        '
        Me.lblservice.AutoSize = True
        Me.lblservice.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblservice.ForeColor = System.Drawing.Color.Navy
        Me.lblservice.Location = New System.Drawing.Point(61, 44)
        Me.lblservice.Name = "lblservice"
        Me.lblservice.Size = New System.Drawing.Size(65, 21)
        Me.lblservice.TabIndex = 28
        Me.lblservice.Text = "Services"
        '
        'cmbservices
        '
        Me.cmbservices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbservices.FormattingEnabled = True
        Me.cmbservices.Location = New System.Drawing.Point(33, 68)
        Me.cmbservices.Name = "cmbservices"
        Me.cmbservices.Size = New System.Drawing.Size(121, 21)
        Me.cmbservices.TabIndex = 27
        '
        'txtphonenumber
        '
        Me.txtphonenumber.Location = New System.Drawing.Point(174, 148)
        Me.txtphonenumber.Name = "txtphonenumber"
        Me.txtphonenumber.Size = New System.Drawing.Size(129, 20)
        Me.txtphonenumber.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(43, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 21)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Contact Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(29, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 21)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Name of Costumer"
        '
        'txtnameofcostumer
        '
        Me.txtnameofcostumer.Location = New System.Drawing.Point(174, 105)
        Me.txtnameofcostumer.Name = "txtnameofcostumer"
        Me.txtnameofcostumer.Size = New System.Drawing.Size(129, 20)
        Me.txtnameofcostumer.TabIndex = 31
        '
        'cmbstatus
        '
        Me.cmbstatus.DisplayMember = "Confirm"
        Me.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"Confirm", "Cancel"})
        Me.cmbstatus.Location = New System.Drawing.Point(416, 141)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbstatus.TabIndex = 40
        Me.cmbstatus.ValueMember = "Confirm"
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.Navy
        Me.lblstatus.Location = New System.Drawing.Point(335, 141)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(51, 21)
        Me.lblstatus.TabIndex = 39
        Me.lblstatus.Text = "Status"
        '
        'cmbtime
        '
        Me.cmbtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtime.FormattingEnabled = True
        Me.cmbtime.Items.AddRange(New Object() {"08:00 am", "09:00 am", "10:00 am", "11:00 am", "12:00 am", "01:00 pm", "02:00 pm", "03:00 pm", "04:00 pm", "05:00 pm", "06:00 pm", "07:00 pm", "08:00 pm", "09:00 pm"})
        Me.cmbtime.Location = New System.Drawing.Point(416, 105)
        Me.cmbtime.Name = "cmbtime"
        Me.cmbtime.Size = New System.Drawing.Size(121, 21)
        Me.cmbtime.TabIndex = 38
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Navy
        Me.lbltime.Location = New System.Drawing.Point(335, 105)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(43, 21)
        Me.lbltime.TabIndex = 37
        Me.lbltime.Text = "Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(335, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Schedule"
        '
        'DTPappoint
        '
        Me.DTPappoint.Location = New System.Drawing.Point(415, 69)
        Me.DTPappoint.MinDate = New Date(2024, 3, 19, 0, 0, 0, 0)
        Me.DTPappoint.Name = "DTPappoint"
        Me.DTPappoint.Size = New System.Drawing.Size(200, 20)
        Me.DTPappoint.TabIndex = 35
        '
        'lbleditsched
        '
        Me.lbleditsched.AutoSize = True
        Me.lbleditsched.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleditsched.ForeColor = System.Drawing.Color.Navy
        Me.lbleditsched.Location = New System.Drawing.Point(513, 238)
        Me.lbleditsched.Name = "lbleditsched"
        Me.lbleditsched.Size = New System.Drawing.Size(102, 21)
        Me.lbleditsched.TabIndex = 41
        Me.lbleditsched.Text = "Edit Schedule"
        '
        'panel_pid
        '
        Me.panel_pid.BackColor = System.Drawing.Color.White
        Me.panel_pid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_pid.Controls.Add(Me.txtSID)
        Me.panel_pid.Controls.Add(Me.lblid)
        Me.panel_pid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.panel_pid.Location = New System.Drawing.Point(542, 9)
        Me.panel_pid.Name = "panel_pid"
        Me.panel_pid.Size = New System.Drawing.Size(73, 42)
        Me.panel_pid.TabIndex = 42
        '
        'txtSID
        '
        Me.txtSID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSID.Location = New System.Drawing.Point(4, 18)
        Me.txtSID.Name = "txtSID"
        Me.txtSID.ReadOnly = True
        Me.txtSID.Size = New System.Drawing.Size(64, 18)
        Me.txtSID.TabIndex = 8
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.BackColor = System.Drawing.Color.White
        Me.lblid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblid.Location = New System.Drawing.Point(4, 5)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(68, 13)
        Me.lblid.TabIndex = 0
        Me.lblid.Text = "Schedule ID"
        '
        'formAppointEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(645, 278)
        Me.Controls.Add(Me.panel_pid)
        Me.Controls.Add(Me.lbleditsched)
        Me.Controls.Add(Me.cmbstatus)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.cmbtime)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPappoint)
        Me.Controls.Add(Me.txtphonenumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnameofcostumer)
        Me.Controls.Add(Me.cmbstylist)
        Me.Controls.Add(Me.lblstylist)
        Me.Controls.Add(Me.lblservice)
        Me.Controls.Add(Me.cmbservices)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formAppointEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formAppointEdit"
        Me.panel_pid.ResumeLayout(False)
        Me.panel_pid.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbstylist As ComboBox
    Friend WithEvents lblstylist As Label
    Friend WithEvents lblservice As Label
    Friend WithEvents cmbservices As ComboBox
    Friend WithEvents txtphonenumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnameofcostumer As TextBox
    Friend WithEvents cmbstatus As ComboBox
    Friend WithEvents lblstatus As Label
    Friend WithEvents cmbtime As ComboBox
    Friend WithEvents lbltime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPappoint As DateTimePicker
    Friend WithEvents lbleditsched As Label
    Friend WithEvents panel_pid As Panel
    Friend WithEvents txtSID As TextBox
    Friend WithEvents lblid As Label
End Class
