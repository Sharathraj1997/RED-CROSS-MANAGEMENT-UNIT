<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class activities
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(activities))
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblplace = New System.Windows.Forms.Label()
        Me.btnaccept = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.dtpone = New System.Windows.Forms.DateTimePicker()
        Me.txtplace = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtact = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtgname = New System.Windows.Forms.TextBox()
        Me.txtpno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(29, 170)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(32, 15)
        Me.lbldate.TabIndex = 0
        Me.lbldate.Text = "Date"
        '
        'lblplace
        '
        Me.lblplace.AutoSize = True
        Me.lblplace.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblplace.Location = New System.Drawing.Point(29, 217)
        Me.lblplace.Name = "lblplace"
        Me.lblplace.Size = New System.Drawing.Size(37, 15)
        Me.lblplace.TabIndex = 2
        Me.lblplace.Text = "Place"
        '
        'btnaccept
        '
        Me.btnaccept.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaccept.Location = New System.Drawing.Point(43, 265)
        Me.btnaccept.Name = "btnaccept"
        Me.btnaccept.Size = New System.Drawing.Size(75, 23)
        Me.btnaccept.TabIndex = 3
        Me.btnaccept.Text = "ACCEPT"
        Me.btnaccept.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(181, 265)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 4
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'dtpone
        '
        Me.dtpone.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpone.Location = New System.Drawing.Point(140, 170)
        Me.dtpone.Name = "dtpone"
        Me.dtpone.Size = New System.Drawing.Size(200, 22)
        Me.dtpone.TabIndex = 5
        '
        'txtplace
        '
        Me.txtplace.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplace.Location = New System.Drawing.Point(143, 217)
        Me.txtplace.Multiline = True
        Me.txtplace.Name = "txtplace"
        Me.txtplace.Size = New System.Drawing.Size(278, 42)
        Me.txtplace.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Type of Activity"
        '
        'txtact
        '
        Me.txtact.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtact.Location = New System.Drawing.Point(139, 53)
        Me.txtact.Multiline = True
        Me.txtact.Name = "txtact"
        Me.txtact.Size = New System.Drawing.Size(280, 54)
        Me.txtact.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Guest Name"
        '
        'txtgname
        '
        Me.txtgname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgname.Location = New System.Drawing.Point(139, 119)
        Me.txtgname.Name = "txtgname"
        Me.txtgname.Size = New System.Drawing.Size(278, 22)
        Me.txtgname.TabIndex = 11
        '
        'txtpno
        '
        Me.txtpno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpno.Location = New System.Drawing.Point(139, 15)
        Me.txtpno.Name = "txtpno"
        Me.txtpno.Size = New System.Drawing.Size(281, 22)
        Me.txtpno.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Programme Number"
        '
        'activities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(433, 300)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpno)
        Me.Controls.Add(Me.txtgname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtact)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtplace)
        Me.Controls.Add(Me.dtpone)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnaccept)
        Me.Controls.Add(Me.lblplace)
        Me.Controls.Add(Me.lbldate)
        Me.DoubleBuffered = True
        Me.Name = "activities"
        Me.Text = "Academic Activities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblplace As System.Windows.Forms.Label
    Friend WithEvents btnaccept As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents dtpone As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtplace As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtact As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtgname As System.Windows.Forms.TextBox
    Friend WithEvents txtpno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
