<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formcostumerbilling
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
        Me.btnprint = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtservicecost = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtservice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panel_pid = New System.Windows.Forms.Panel()
        Me.txtSID = New System.Windows.Forms.TextBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstylist = New System.Windows.Forms.TextBox()
        Me.panel_pid.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(214, 311)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(122, 37)
        Me.btnprint.TabIndex = 49
        Me.btnprint.Text = "Proceed"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(74, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 21)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Service Cost"
        '
        'txtservicecost
        '
        Me.txtservicecost.Enabled = False
        Me.txtservicecost.Location = New System.Drawing.Point(176, 190)
        Me.txtservicecost.Name = "txtservicecost"
        Me.txtservicecost.ReadOnly = True
        Me.txtservicecost.Size = New System.Drawing.Size(129, 20)
        Me.txtservicecost.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(109, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 21)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Service"
        '
        'txtservice
        '
        Me.txtservice.Enabled = False
        Me.txtservice.Location = New System.Drawing.Point(176, 154)
        Me.txtservice.Name = "txtservice"
        Me.txtservice.ReadOnly = True
        Me.txtservice.Size = New System.Drawing.Size(129, 20)
        Me.txtservice.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(31, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 21)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Name of Costumer"
        '
        'txtname
        '
        Me.txtname.Enabled = False
        Me.txtname.Location = New System.Drawing.Point(176, 81)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(129, 20)
        Me.txtname.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(12, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Close"
        '
        'panel_pid
        '
        Me.panel_pid.BackColor = System.Drawing.Color.White
        Me.panel_pid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_pid.Controls.Add(Me.txtSID)
        Me.panel_pid.Controls.Add(Me.lblid)
        Me.panel_pid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.panel_pid.Location = New System.Drawing.Point(4, 3)
        Me.panel_pid.Name = "panel_pid"
        Me.panel_pid.Size = New System.Drawing.Size(73, 42)
        Me.panel_pid.TabIndex = 52
        '
        'txtSID
        '
        Me.txtSID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSID.Enabled = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(109, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 21)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "stylist"
        '
        'txtstylist
        '
        Me.txtstylist.Enabled = False
        Me.txtstylist.Location = New System.Drawing.Point(176, 119)
        Me.txtstylist.Name = "txtstylist"
        Me.txtstylist.ReadOnly = True
        Me.txtstylist.Size = New System.Drawing.Size(129, 20)
        Me.txtstylist.TabIndex = 53
        '
        'formcostumerbilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(348, 360)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtstylist)
        Me.Controls.Add(Me.panel_pid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtservicecost)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtservice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formcostumerbilling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formcostumerbilling"
        Me.panel_pid.ResumeLayout(False)
        Me.panel_pid.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnprint As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtservicecost As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtservice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents panel_pid As Panel
    Friend WithEvents txtSID As TextBox
    Friend WithEvents lblid As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtstylist As TextBox
End Class
