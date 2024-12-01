<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class issue
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.bkID = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.DTPI = New System.Windows.Forms.DateTimePicker()
        Me.DTPR = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(25, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 38)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Issue Book"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(277, 390)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Return Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(277, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Issue Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(277, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Book ID"
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.Location = New System.Drawing.Point(277, 147)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(98, 20)
        Me.lb1.TabIndex = 37
        Me.lb1.Text = "Student ID"
        '
        'bkID
        '
        Me.bkID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkID.Location = New System.Drawing.Point(281, 256)
        Me.bkID.Name = "bkID"
        Me.bkID.Size = New System.Drawing.Size(183, 38)
        Me.bkID.TabIndex = 33
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(281, 182)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(183, 38)
        Me.txtID.TabIndex = 32
        '
        'DTPI
        '
        Me.DTPI.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPI.Location = New System.Drawing.Point(281, 347)
        Me.DTPI.Name = "DTPI"
        Me.DTPI.Size = New System.Drawing.Size(183, 22)
        Me.DTPI.TabIndex = 45
        '
        'DTPR
        '
        Me.DTPR.Location = New System.Drawing.Point(281, 422)
        Me.DTPR.Name = "DTPR"
        Me.DTPR.Size = New System.Drawing.Size(183, 22)
        Me.DTPR.TabIndex = 46
        Me.DTPR.Value = New Date(2023, 11, 27, 20, 28, 15, 0)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(236, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 43)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "INSERT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(387, 488)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 43)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'issue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(709, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DTPR)
        Me.Controls.Add(Me.DTPI)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.bkID)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "issue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lb1 As Label
    Friend WithEvents bkID As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents DTPI As DateTimePicker
    Friend WithEvents DTPR As DateTimePicker
End Class
