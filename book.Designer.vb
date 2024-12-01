<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class book
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(book))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.bkNAME = New System.Windows.Forms.TextBox()
        Me.bkID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bkPUBYEAR = New System.Windows.Forms.TextBox()
        Me.bkPRICE = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bkPUBLISHER = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(269, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Title"
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.Location = New System.Drawing.Point(269, 91)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(76, 20)
        Me.lb1.TabIndex = 16
        Me.lb1.Text = "Book ID"
        '
        'bkNAME
        '
        Me.bkNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bkNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkNAME.Location = New System.Drawing.Point(273, 194)
        Me.bkNAME.Name = "bkNAME"
        Me.bkNAME.Size = New System.Drawing.Size(183, 31)
        Me.bkNAME.TabIndex = 12
        '
        'bkID
        '
        Me.bkID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bkID.Enabled = False
        Me.bkID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkID.Location = New System.Drawing.Point(273, 128)
        Me.bkID.Name = "bkID"
        Me.bkID.Size = New System.Drawing.Size(183, 31)
        Me.bkID.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(222, 499)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 53)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Insert"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 389)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Published Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(269, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Price"
        '
        'bkPUBYEAR
        '
        Me.bkPUBYEAR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bkPUBYEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkPUBYEAR.Location = New System.Drawing.Point(273, 427)
        Me.bkPUBYEAR.Name = "bkPUBYEAR"
        Me.bkPUBYEAR.Size = New System.Drawing.Size(183, 31)
        Me.bkPUBYEAR.TabIndex = 24
        '
        'bkPRICE
        '
        Me.bkPRICE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bkPRICE.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkPRICE.Location = New System.Drawing.Point(273, 348)
        Me.bkPRICE.Name = "bkPRICE"
        Me.bkPRICE.Size = New System.Drawing.Size(183, 31)
        Me.bkPRICE.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(406, 499)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 53)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(269, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Author"
        '
        'bkPUBLISHER
        '
        Me.bkPUBLISHER.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bkPUBLISHER.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkPUBLISHER.Location = New System.Drawing.Point(273, 274)
        Me.bkPUBLISHER.Name = "bkPUBLISHER"
        Me.bkPUBLISHER.Size = New System.Drawing.Size(183, 31)
        Me.bkPUBLISHER.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(35, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 39)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Add book"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Gray
        Me.LinkLabel1.Location = New System.Drawing.Point(650, 569)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(47, 20)
        Me.LinkLabel1.TabIndex = 47
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Back"
        '
        'book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(709, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bkPUBLISHER)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bkPUBYEAR)
        Me.Controls.Add(Me.bkPRICE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.bkNAME)
        Me.Controls.Add(Me.bkID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "book"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents lb1 As Label
    Friend WithEvents bkNAME As TextBox
    Friend WithEvents bkID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bkPUBYEAR As TextBox
    Friend WithEvents bkPRICE As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents bkPUBLISHER As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
