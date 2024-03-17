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
        Me.panel_Inventory = New System.Windows.Forms.Panel()
        Me.editemployee = New System.Windows.Forms.Panel()
        Me.lbladditem = New System.Windows.Forms.Label()
        Me.employeeView = New System.Windows.Forms.DataGridView()
        Me.panel_Inventory.SuspendLayout()
        Me.editemployee.SuspendLayout()
        CType(Me.employeeView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_Inventory
        '
        Me.panel_Inventory.Controls.Add(Me.editemployee)
        Me.panel_Inventory.Location = New System.Drawing.Point(191, 3)
        Me.panel_Inventory.Name = "panel_Inventory"
        Me.panel_Inventory.Size = New System.Drawing.Size(573, 569)
        Me.panel_Inventory.TabIndex = 7
        '
        'editemployee
        '
        Me.editemployee.Controls.Add(Me.lbladditem)
        Me.editemployee.Controls.Add(Me.employeeView)
        Me.editemployee.Location = New System.Drawing.Point(3, 110)
        Me.editemployee.Name = "editemployee"
        Me.editemployee.Size = New System.Drawing.Size(567, 449)
        Me.editemployee.TabIndex = 11
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
        'employeeView
        '
        Me.employeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeeView.Location = New System.Drawing.Point(14, 28)
        Me.employeeView.Name = "employeeView"
        Me.employeeView.Size = New System.Drawing.Size(544, 247)
        Me.employeeView.TabIndex = 0
        '
        'formstaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 575)
        Me.Controls.Add(Me.panel_Inventory)
        Me.Name = "formstaff"
        Me.Text = "formstaff"
        Me.panel_Inventory.ResumeLayout(False)
        Me.editemployee.ResumeLayout(False)
        Me.editemployee.PerformLayout()
        CType(Me.employeeView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_Inventory As Panel
    Friend WithEvents editemployee As Panel
    Friend WithEvents lbladditem As Label
    Friend WithEvents employeeView As DataGridView
End Class
