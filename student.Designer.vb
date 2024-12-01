<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(student))
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNAME = New System.Windows.Forms.TextBox()
        Me.txtSECTION = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.cb2 = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(265, 139)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(183, 31)
        Me.txtID.TabIndex = 0
        '
        'txtNAME
        '
        Me.txtNAME.BackColor = System.Drawing.Color.White
        Me.txtNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNAME.Location = New System.Drawing.Point(265, 221)
        Me.txtNAME.Name = "txtNAME"
        Me.txtNAME.Size = New System.Drawing.Size(183, 31)
        Me.txtNAME.TabIndex = 1
        '
        'txtSECTION
        '
        Me.txtSECTION.BackColor = System.Drawing.Color.White
        Me.txtSECTION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSECTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSECTION.Location = New System.Drawing.Point(265, 368)
        Me.txtSECTION.Name = "txtSECTION"
        Me.txtSECTION.Size = New System.Drawing.Size(183, 31)
        Me.txtSECTION.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(209, 501)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 56)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Insert"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(354, 503)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 54)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(33, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 38)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Add student"
        '
        'cb1
        '
        Me.cb1.BackColor = System.Drawing.Color.White
        Me.cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb1.FormattingEnabled = True
        Me.cb1.Items.AddRange(New Object() {"MAIN", "SF", "BATASAN"})
        Me.cb1.Location = New System.Drawing.Point(265, 440)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(121, 39)
        Me.cb1.TabIndex = 46
        '
        'cb2
        '
        Me.cb2.BackColor = System.Drawing.Color.White
        Me.cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb2.FormattingEnabled = True
        Me.cb2.Items.AddRange(New Object() {"BSA", "BSMA", "BSIT", "BCE", "BSEE", "BSE", "BSCS"})
        Me.cb2.Location = New System.Drawing.Point(265, 289)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(121, 39)
        Me.cb2.TabIndex = 47
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Gray
        Me.LinkLabel1.Location = New System.Drawing.Point(650, 569)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(47, 20)
        Me.LinkLabel1.TabIndex = 48
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Back"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(261, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Course"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 414)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Campus"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(261, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Section"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Name"
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.Location = New System.Drawing.Point(261, 105)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(98, 20)
        Me.lb1.TabIndex = 51
        Me.lb1.Text = "Student ID"
        '
        'student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(709, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSECTION)
        Me.Controls.Add(Me.txtNAME)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNAME As TextBox
    Friend WithEvents txtSECTION As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents cb2 As ComboBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lb1 As Label
End Class
