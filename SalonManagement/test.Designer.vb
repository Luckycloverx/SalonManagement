<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class test
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
        Me.panel_dashboard = New System.Windows.Forms.Panel()
        Me.lblstocks = New System.Windows.Forms.Label()
        Me.lblcostumer = New System.Windows.Forms.Label()
        Me.panel_dashboard.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_dashboard
        '
        Me.panel_dashboard.Controls.Add(Me.lblstocks)
        Me.panel_dashboard.Controls.Add(Me.lblcostumer)
        Me.panel_dashboard.Location = New System.Drawing.Point(114, 7)
        Me.panel_dashboard.Name = "panel_dashboard"
        Me.panel_dashboard.Size = New System.Drawing.Size(573, 569)
        Me.panel_dashboard.TabIndex = 16
        '
        'lblstocks
        '
        Me.lblstocks.AutoSize = True
        Me.lblstocks.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstocks.ForeColor = System.Drawing.Color.Navy
        Me.lblstocks.Location = New System.Drawing.Point(63, 143)
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
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 599)
        Me.Controls.Add(Me.panel_dashboard)
        Me.Name = "test"
        Me.Text = "test"
        Me.panel_dashboard.ResumeLayout(False)
        Me.panel_dashboard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_dashboard As Panel
    Friend WithEvents lblstocks As Label
    Friend WithEvents lblcostumer As Label
End Class
