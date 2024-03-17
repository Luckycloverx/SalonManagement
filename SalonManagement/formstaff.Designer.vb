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
        Me.Employee_management = New System.Windows.Forms.Panel()
        Me.editemployee = New System.Windows.Forms.Panel()
        Me.add_employee = New System.Windows.Forms.Label()
        Me.employeeView = New System.Windows.Forms.DataGridView()
        Me.employee_dashboard = New System.Windows.Forms.Label()
        Me.edit_employee = New System.Windows.Forms.Label()
        Me.Employee_management.SuspendLayout()
        Me.editemployee.SuspendLayout()
        CType(Me.employeeView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Employee_management
        '
        Me.Employee_management.Controls.Add(Me.editemployee)
        Me.Employee_management.Controls.Add(Me.employee_dashboard)
        Me.Employee_management.Controls.Add(Me.edit_employee)
        Me.Employee_management.Location = New System.Drawing.Point(115, 3)
        Me.Employee_management.Name = "Employee_management"
        Me.Employee_management.Size = New System.Drawing.Size(573, 569)
        Me.Employee_management.TabIndex = 7
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
        'formstaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 575)
        Me.Controls.Add(Me.Employee_management)
        Me.Name = "formstaff"
        Me.Text = "formstaff"
        Me.Employee_management.ResumeLayout(False)
        Me.Employee_management.PerformLayout()
        Me.editemployee.ResumeLayout(False)
        Me.editemployee.PerformLayout()
        CType(Me.employeeView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Employee_management As Panel
    Friend WithEvents editemployee As Panel
    Friend WithEvents add_employee As Label
    Friend WithEvents employeeView As DataGridView
    Friend WithEvents employee_dashboard As Label
    Friend WithEvents edit_employee As Label
End Class
