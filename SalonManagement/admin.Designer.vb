<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminwindows
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbldashboard = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Employee_management = New System.Windows.Forms.Panel()
        Me.editemployee = New System.Windows.Forms.Panel()
        Me.add_employee = New System.Windows.Forms.Label()
        Me.employeeView = New System.Windows.Forms.DataGridView()
        Me.employee_dashboard = New System.Windows.Forms.Label()
        Me.edit_employee = New System.Windows.Forms.Label()
        Me.panel_Inventory = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbladditem = New System.Windows.Forms.Label()
        Me.dgvinventory = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Employee_management.SuspendLayout()
        Me.editemployee.SuspendLayout()
        CType(Me.employeeView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Inventory.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvinventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(71, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ADMIN"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbldashboard)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblInventory)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 569)
        Me.Panel1.TabIndex = 5
        '
        'lbldashboard
        '
        Me.lbldashboard.AutoSize = True
        Me.lbldashboard.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldashboard.ForeColor = System.Drawing.Color.Navy
        Me.lbldashboard.Location = New System.Drawing.Point(20, 90)
        Me.lbldashboard.Name = "lbldashboard"
        Me.lbldashboard.Size = New System.Drawing.Size(85, 21)
        Me.lbldashboard.TabIndex = 10
        Me.lbldashboard.Text = "Dashboard"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(17, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Settings"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(15, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Employee management"
        '
        'lblInventory
        '
        Me.lblInventory.AutoSize = True
        Me.lblInventory.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventory.ForeColor = System.Drawing.Color.Navy
        Me.lblInventory.Location = New System.Drawing.Point(19, 145)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(74, 21)
        Me.lblInventory.TabIndex = 7
        Me.lblInventory.Text = "Inventory"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(10, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(176, 43)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SalonManagement.My.Resources.Resources.gunting
        Me.PictureBox1.Location = New System.Drawing.Point(14, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(24, 524)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(112, 35)
        Me.Panel3.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SalonManagement.My.Resources.Resources.sign_out
        Me.PictureBox2.Location = New System.Drawing.Point(4, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepPink
        Me.Label4.Location = New System.Drawing.Point(36, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Sign out"
        '
        'Employee_management
        '
        Me.Employee_management.Controls.Add(Me.editemployee)
        Me.Employee_management.Controls.Add(Me.employee_dashboard)
        Me.Employee_management.Controls.Add(Me.edit_employee)
        Me.Employee_management.Location = New System.Drawing.Point(244, 0)
        Me.Employee_management.Name = "Employee_management"
        Me.Employee_management.Size = New System.Drawing.Size(573, 569)
        Me.Employee_management.TabIndex = 6
        '
        'editemployee
        '
        Me.editemployee.Controls.Add(Me.add_employee)
        Me.editemployee.Controls.Add(Me.employeeView)
        Me.editemployee.Location = New System.Drawing.Point(3, 110)
        Me.editemployee.Name = "editemployee"
        Me.editemployee.Size = New System.Drawing.Size(567, 449)
        Me.editemployee.TabIndex = 11
        '
        'add_employee
        '
        Me.add_employee.AutoSize = True
        Me.add_employee.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_employee.ForeColor = System.Drawing.Color.Navy
        Me.add_employee.Location = New System.Drawing.Point(379, 296)
        Me.add_employee.Name = "add_employee"
        Me.add_employee.Size = New System.Drawing.Size(179, 21)
        Me.add_employee.TabIndex = 11
        Me.add_employee.Text = "add front desk employee"
        '
        'employeeView
        '
        Me.employeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeeView.Location = New System.Drawing.Point(14, 28)
        Me.employeeView.Name = "employeeView"
        Me.employeeView.Size = New System.Drawing.Size(544, 247)
        Me.employeeView.TabIndex = 0
        '
        'employee_dashboard
        '
        Me.employee_dashboard.AutoSize = True
        Me.employee_dashboard.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employee_dashboard.ForeColor = System.Drawing.Color.Navy
        Me.employee_dashboard.Location = New System.Drawing.Point(13, 51)
        Me.employee_dashboard.Name = "employee_dashboard"
        Me.employee_dashboard.Size = New System.Drawing.Size(153, 21)
        Me.employee_dashboard.TabIndex = 10
        Me.employee_dashboard.Text = "Employee dashboard"
        '
        'edit_employee
        '
        Me.edit_employee.AutoSize = True
        Me.edit_employee.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_employee.ForeColor = System.Drawing.Color.Navy
        Me.edit_employee.Location = New System.Drawing.Point(418, 51)
        Me.edit_employee.Name = "edit_employee"
        Me.edit_employee.Size = New System.Drawing.Size(106, 21)
        Me.edit_employee.TabIndex = 9
        Me.edit_employee.Text = "Edit Employee"
        '
        'panel_Inventory
        '
        Me.panel_Inventory.Controls.Add(Me.Panel4)
        Me.panel_Inventory.Location = New System.Drawing.Point(244, 0)
        Me.panel_Inventory.Name = "panel_Inventory"
        Me.panel_Inventory.Size = New System.Drawing.Size(573, 569)
        Me.panel_Inventory.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbladditem)
        Me.Panel4.Controls.Add(Me.dgvinventory)
        Me.Panel4.Location = New System.Drawing.Point(3, 110)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(567, 449)
        Me.Panel4.TabIndex = 11
        '
        'lbladditem
        '
        Me.lbladditem.AutoSize = True
        Me.lbladditem.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladditem.ForeColor = System.Drawing.Color.Navy
        Me.lbladditem.Location = New System.Drawing.Point(380, 296)
        Me.lbladditem.Name = "lbladditem"
        Me.lbladditem.Size = New System.Drawing.Size(125, 21)
        Me.lbladditem.TabIndex = 11
        Me.lbladditem.Text = "add new product"
        '
        'dgvinventory
        '
        Me.dgvinventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinventory.Location = New System.Drawing.Point(14, 28)
        Me.dgvinventory.Name = "dgvinventory"
        Me.dgvinventory.Size = New System.Drawing.Size(544, 247)
        Me.dgvinventory.TabIndex = 0
        '
        'adminwindows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 569)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panel_Inventory)
        Me.Controls.Add(Me.Employee_management)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminwindows"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Employee_management.ResumeLayout(False)
        Me.Employee_management.PerformLayout()
        Me.editemployee.ResumeLayout(False)
        Me.editemployee.PerformLayout()
        CType(Me.employeeView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Inventory.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvinventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblInventory As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Employee_management As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents edit_employee As Label
    Friend WithEvents editemployee As Panel
    Friend WithEvents employeeView As DataGridView
    Friend WithEvents add_employee As Label
    Friend WithEvents employee_dashboard As Label
    Friend WithEvents lbldashboard As Label
    Friend WithEvents panel_Inventory As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbladditem As Label
    Friend WithEvents dgvinventory As DataGridView
End Class
