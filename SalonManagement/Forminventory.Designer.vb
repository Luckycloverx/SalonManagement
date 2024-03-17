<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Forminventory
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
        Me.Panel_product = New System.Windows.Forms.Panel()
        Me.txtproduct = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_quantity = New System.Windows.Forms.Panel()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_cost = New System.Windows.Forms.Panel()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbladd = New System.Windows.Forms.Label()
        Me.lblclose = New System.Windows.Forms.Label()
        Me.lbledit = New System.Windows.Forms.Label()
        Me.lblremove = New System.Windows.Forms.Label()
        Me.panel_pid = New System.Windows.Forms.Panel()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Panel_product.SuspendLayout()
        Me.Panel_quantity.SuspendLayout()
        Me.Panel_cost.SuspendLayout()
        Me.panel_pid.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_product
        '
        Me.Panel_product.BackColor = System.Drawing.Color.White
        Me.Panel_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_product.Controls.Add(Me.txtproduct)
        Me.Panel_product.Controls.Add(Me.Label3)
        Me.Panel_product.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Panel_product.Location = New System.Drawing.Point(57, 46)
        Me.Panel_product.Name = "Panel_product"
        Me.Panel_product.Size = New System.Drawing.Size(225, 61)
        Me.Panel_product.TabIndex = 12
        '
        'txtproduct
        '
        Me.txtproduct.AcceptsTab = True
        Me.txtproduct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtproduct.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproduct.Location = New System.Drawing.Point(20, 27)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Size = New System.Drawing.Size(185, 18)
        Me.txtproduct.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(15, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Product"
        '
        'Panel_quantity
        '
        Me.Panel_quantity.BackColor = System.Drawing.Color.White
        Me.Panel_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_quantity.Controls.Add(Me.txtquantity)
        Me.Panel_quantity.Controls.Add(Me.Label1)
        Me.Panel_quantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Panel_quantity.Location = New System.Drawing.Point(57, 127)
        Me.Panel_quantity.Name = "Panel_quantity"
        Me.Panel_quantity.Size = New System.Drawing.Size(225, 61)
        Me.Panel_quantity.TabIndex = 12
        '
        'txtquantity
        '
        Me.txtquantity.AcceptsTab = True
        Me.txtquantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtquantity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(20, 27)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(185, 18)
        Me.txtquantity.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(15, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quantity"
        '
        'Panel_cost
        '
        Me.Panel_cost.BackColor = System.Drawing.Color.White
        Me.Panel_cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_cost.Controls.Add(Me.txtcost)
        Me.Panel_cost.Controls.Add(Me.Label2)
        Me.Panel_cost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Panel_cost.Location = New System.Drawing.Point(57, 207)
        Me.Panel_cost.Name = "Panel_cost"
        Me.Panel_cost.Size = New System.Drawing.Size(225, 61)
        Me.Panel_cost.TabIndex = 13
        '
        'txtcost
        '
        Me.txtcost.AcceptsTab = True
        Me.txtcost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcost.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcost.Location = New System.Drawing.Point(20, 27)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(185, 18)
        Me.txtcost.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(15, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cost"
        '
        'lbladd
        '
        Me.lbladd.AutoSize = True
        Me.lbladd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd.ForeColor = System.Drawing.Color.Navy
        Me.lbladd.Location = New System.Drawing.Point(238, 294)
        Me.lbladd.Name = "lbladd"
        Me.lbladd.Size = New System.Drawing.Size(83, 20)
        Me.lbladd.TabIndex = 18
        Me.lbladd.Text = "New Entry"
        '
        'lblclose
        '
        Me.lblclose.AutoSize = True
        Me.lblclose.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclose.ForeColor = System.Drawing.Color.Navy
        Me.lblclose.Location = New System.Drawing.Point(14, 294)
        Me.lblclose.Name = "lblclose"
        Me.lblclose.Size = New System.Drawing.Size(44, 20)
        Me.lblclose.TabIndex = 20
        Me.lblclose.Text = "close"
        '
        'lbledit
        '
        Me.lbledit.AutoSize = True
        Me.lbledit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbledit.ForeColor = System.Drawing.Color.Navy
        Me.lbledit.Location = New System.Drawing.Point(249, 294)
        Me.lbledit.Name = "lbledit"
        Me.lbledit.Size = New System.Drawing.Size(36, 20)
        Me.lbledit.TabIndex = 19
        Me.lbledit.Text = "Edit"
        '
        'lblremove
        '
        Me.lblremove.AutoSize = True
        Me.lblremove.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremove.ForeColor = System.Drawing.Color.Navy
        Me.lblremove.Location = New System.Drawing.Point(228, 320)
        Me.lblremove.Name = "lblremove"
        Me.lblremove.Size = New System.Drawing.Size(66, 20)
        Me.lblremove.TabIndex = 21
        Me.lblremove.Text = "Remove"
        '
        'panel_pid
        '
        Me.panel_pid.BackColor = System.Drawing.Color.White
        Me.panel_pid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_pid.Controls.Add(Me.txtPID)
        Me.panel_pid.Controls.Add(Me.lblid)
        Me.panel_pid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.panel_pid.Location = New System.Drawing.Point(7, 3)
        Me.panel_pid.Name = "panel_pid"
        Me.panel_pid.Size = New System.Drawing.Size(67, 42)
        Me.panel_pid.TabIndex = 22
        '
        'txtPID
        '
        Me.txtPID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPID.Location = New System.Drawing.Point(4, 18)
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(58, 18)
        Me.txtPID.TabIndex = 8
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.BackColor = System.Drawing.Color.White
        Me.lblid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblid.Location = New System.Drawing.Point(4, 5)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(61, 13)
        Me.lblid.TabIndex = 0
        Me.lblid.Text = "Product ID"
        '
        'Forminventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(339, 359)
        Me.Controls.Add(Me.panel_pid)
        Me.Controls.Add(Me.lblremove)
        Me.Controls.Add(Me.lblclose)
        Me.Controls.Add(Me.lbledit)
        Me.Controls.Add(Me.lbladd)
        Me.Controls.Add(Me.Panel_cost)
        Me.Controls.Add(Me.Panel_quantity)
        Me.Controls.Add(Me.Panel_product)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Forminventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forminventory"
        Me.Panel_product.ResumeLayout(False)
        Me.Panel_product.PerformLayout()
        Me.Panel_quantity.ResumeLayout(False)
        Me.Panel_quantity.PerformLayout()
        Me.Panel_cost.ResumeLayout(False)
        Me.Panel_cost.PerformLayout()
        Me.panel_pid.ResumeLayout(False)
        Me.panel_pid.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_product As Panel
    Friend WithEvents txtproduct As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel_quantity As Panel
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_cost As Panel
    Friend WithEvents txtcost As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbladd As Label
    Friend WithEvents lblclose As Label
    Friend WithEvents lbledit As Label
    Friend WithEvents lblremove As Label
    Friend WithEvents panel_pid As Panel
    Friend WithEvents txtPID As TextBox
    Friend WithEvents lblid As Label
End Class
