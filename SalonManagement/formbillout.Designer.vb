<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formbillout
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblprint = New System.Windows.Forms.Button()
        Me.lblcancel = New System.Windows.Forms.Label()
        Me.lblservice = New System.Windows.Forms.Label()
        Me.lbladd = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txttotalcost = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbpwd = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtchange = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbservices = New System.Windows.Forms.ComboBox()
        Me.txtpayment = New System.Windows.Forms.TextBox()
        Me.txtHID = New System.Windows.Forms.TextBox()
        Me.txtSID = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(345, 215)
        Me.DataGridView1.TabIndex = 0
        '
        'lblprint
        '
        Me.lblprint.Location = New System.Drawing.Point(281, 392)
        Me.lblprint.Name = "lblprint"
        Me.lblprint.Size = New System.Drawing.Size(76, 40)
        Me.lblprint.TabIndex = 1
        Me.lblprint.Text = "Print"
        Me.lblprint.UseVisualStyleBackColor = True
        '
        'lblcancel
        '
        Me.lblcancel.AutoSize = True
        Me.lblcancel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcancel.ForeColor = System.Drawing.Color.Navy
        Me.lblcancel.Location = New System.Drawing.Point(8, 412)
        Me.lblcancel.Name = "lblcancel"
        Me.lblcancel.Size = New System.Drawing.Size(54, 20)
        Me.lblcancel.TabIndex = 21
        Me.lblcancel.Text = "Cancel"
        '
        'lblservice
        '
        Me.lblservice.AutoSize = True
        Me.lblservice.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblservice.ForeColor = System.Drawing.Color.Navy
        Me.lblservice.Location = New System.Drawing.Point(12, 230)
        Me.lblservice.Name = "lblservice"
        Me.lblservice.Size = New System.Drawing.Size(63, 21)
        Me.lblservice.TabIndex = 23
        Me.lblservice.Text = "Product"
        '
        'lbladd
        '
        Me.lbladd.AutoSize = True
        Me.lbladd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd.ForeColor = System.Drawing.Color.Navy
        Me.lbladd.Location = New System.Drawing.Point(20, 279)
        Me.lbladd.Name = "lbladd"
        Me.lbladd.Size = New System.Drawing.Size(42, 20)
        Me.lbladd.TabIndex = 24
        Me.lbladd.Text = "ADD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(132, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 21)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Cost"
        '
        'txtcost
        '
        Me.txtcost.Enabled = False
        Me.txtcost.Location = New System.Drawing.Point(136, 255)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.ReadOnly = True
        Me.txtcost.Size = New System.Drawing.Size(89, 20)
        Me.txtcost.TabIndex = 48
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Navy
        Me.lbltotal.Location = New System.Drawing.Point(272, 230)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(77, 21)
        Me.lbltotal.TabIndex = 51
        Me.lbltotal.Text = "Total Cost"
        '
        'txttotalcost
        '
        Me.txttotalcost.Enabled = False
        Me.txttotalcost.Location = New System.Drawing.Point(268, 254)
        Me.txttotalcost.Name = "txttotalcost"
        Me.txttotalcost.ReadOnly = True
        Me.txttotalcost.Size = New System.Drawing.Size(89, 20)
        Me.txttotalcost.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(12, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 21)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "PWD/Senior 5% :"
        '
        'cmbpwd
        '
        Me.cmbpwd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpwd.FormattingEnabled = True
        Me.cmbpwd.Items.AddRange(New Object() {"NO", "YES"})
        Me.cmbpwd.Location = New System.Drawing.Point(148, 311)
        Me.cmbpwd.Name = "cmbpwd"
        Me.cmbpwd.Size = New System.Drawing.Size(77, 21)
        Me.cmbpwd.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(272, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 21)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Payment"
        '
        'txtchange
        '
        Me.txtchange.Enabled = False
        Me.txtchange.Location = New System.Drawing.Point(268, 349)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.ReadOnly = True
        Me.txtchange.Size = New System.Drawing.Size(89, 20)
        Me.txtchange.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(272, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 21)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Change"
        '
        'cmbservices
        '
        Me.cmbservices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbservices.FormattingEnabled = True
        Me.cmbservices.Location = New System.Drawing.Point(9, 253)
        Me.cmbservices.Name = "cmbservices"
        Me.cmbservices.Size = New System.Drawing.Size(121, 21)
        Me.cmbservices.TabIndex = 60
        '
        'txtpayment
        '
        Me.txtpayment.Location = New System.Drawing.Point(268, 302)
        Me.txtpayment.Name = "txtpayment"
        Me.txtpayment.Size = New System.Drawing.Size(89, 20)
        Me.txtpayment.TabIndex = 61
        '
        'txtHID
        '
        Me.txtHID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHID.Enabled = False
        Me.txtHID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHID.Location = New System.Drawing.Point(293, 438)
        Me.txtHID.Name = "txtHID"
        Me.txtHID.ReadOnly = True
        Me.txtHID.Size = New System.Drawing.Size(64, 18)
        Me.txtHID.TabIndex = 62
        Me.txtHID.Visible = False
        '
        'txtSID
        '
        Me.txtSID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSID.Enabled = False
        Me.txtSID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSID.Location = New System.Drawing.Point(223, 438)
        Me.txtSID.Name = "txtSID"
        Me.txtSID.ReadOnly = True
        Me.txtSID.Size = New System.Drawing.Size(64, 18)
        Me.txtSID.TabIndex = 63
        Me.txtSID.Visible = False
        '
        'formbillout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(367, 457)
        Me.Controls.Add(Me.txtSID)
        Me.Controls.Add(Me.txtHID)
        Me.Controls.Add(Me.txtpayment)
        Me.Controls.Add(Me.cmbservices)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtchange)
        Me.Controls.Add(Me.cmbpwd)
        Me.Controls.Add(Me.txttotalcost)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtcost)
        Me.Controls.Add(Me.lbladd)
        Me.Controls.Add(Me.lblservice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblcancel)
        Me.Controls.Add(Me.lblprint)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formbillout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formbillout"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblprint As Button
    Friend WithEvents lblcancel As Label
    Friend WithEvents lblservice As Label
    Friend WithEvents lbladd As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcost As TextBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents txttotalcost As TextBox
    Friend WithEvents Label9 As Label
    Public WithEvents cmbpwd As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtchange As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbservices As ComboBox
    Friend WithEvents txtpayment As TextBox
    Friend WithEvents txtHID As TextBox
    Friend WithEvents txtSID As TextBox
End Class
