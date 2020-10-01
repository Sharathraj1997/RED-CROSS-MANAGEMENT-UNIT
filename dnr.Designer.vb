<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dnr
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
        Me.cbyear = New System.Windows.Forms.ComboBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cbclass = New System.Windows.Forms.ComboBox()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.rdofemale = New System.Windows.Forms.RadioButton()
        Me.rdomale = New System.Windows.Forms.RadioButton()
        Me.dtdob = New System.Windows.Forms.DateTimePicker()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.txtaddr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblclass = New System.Windows.Forms.Label()
        Me.txtmob = New System.Windows.Forms.TextBox()
        Me.txtrno = New System.Windows.Forms.TextBox()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbyear
        '
        Me.cbyear.FormattingEnabled = True
        Me.cbyear.Location = New System.Drawing.Point(148, 120)
        Me.cbyear.Name = "cbyear"
        Me.cbyear.Size = New System.Drawing.Size(155, 21)
        Me.cbyear.TabIndex = 38
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(23, 126)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 15)
        Me.lblYear.TabIndex = 37
        Me.lblYear.Text = "Year"
        '
        'cbclass
        '
        Me.cbclass.FormattingEnabled = True
        Me.cbclass.Location = New System.Drawing.Point(147, 83)
        Me.cbclass.Name = "cbclass"
        Me.cbclass.Size = New System.Drawing.Size(156, 21)
        Me.cbclass.TabIndex = 36
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(246, 342)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 35
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(73, 342)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 34
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'rdofemale
        '
        Me.rdofemale.AutoSize = True
        Me.rdofemale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdofemale.Location = New System.Drawing.Point(257, 202)
        Me.rdofemale.Name = "rdofemale"
        Me.rdofemale.Size = New System.Drawing.Size(64, 19)
        Me.rdofemale.TabIndex = 33
        Me.rdofemale.TabStop = True
        Me.rdofemale.Text = "Female"
        Me.rdofemale.UseVisualStyleBackColor = True
        '
        'rdomale
        '
        Me.rdomale.AutoSize = True
        Me.rdomale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdomale.Location = New System.Drawing.Point(147, 200)
        Me.rdomale.Name = "rdomale"
        Me.rdomale.Size = New System.Drawing.Size(52, 19)
        Me.rdomale.TabIndex = 32
        Me.rdomale.TabStop = True
        Me.rdomale.Text = "Male"
        Me.rdomale.UseVisualStyleBackColor = True
        '
        'dtdob
        '
        Me.dtdob.Location = New System.Drawing.Point(147, 165)
        Me.dtdob.Name = "dtdob"
        Me.dtdob.Size = New System.Drawing.Size(200, 20)
        Me.dtdob.TabIndex = 31
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.Location = New System.Drawing.Point(23, 202)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(47, 15)
        Me.lblgender.TabIndex = 30
        Me.lblgender.Text = "Gender"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(22, 165)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(78, 15)
        Me.lbldate.TabIndex = 29
        Me.lbldate.Text = "Date of Birth"
        '
        'txtaddr
        '
        Me.txtaddr.Location = New System.Drawing.Point(147, 234)
        Me.txtaddr.Name = "txtaddr"
        Me.txtaddr.Size = New System.Drawing.Size(100, 20)
        Me.txtaddr.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Mobile Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Roll Number"
        '
        'lblclass
        '
        Me.lblclass.AutoSize = True
        Me.lblclass.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclass.Location = New System.Drawing.Point(22, 85)
        Me.lblclass.Name = "lblclass"
        Me.lblclass.Size = New System.Drawing.Size(38, 15)
        Me.lblclass.TabIndex = 24
        Me.lblclass.Text = "Class"
        '
        'txtmob
        '
        Me.txtmob.Location = New System.Drawing.Point(147, 277)
        Me.txtmob.Name = "txtmob"
        Me.txtmob.Size = New System.Drawing.Size(100, 20)
        Me.txtmob.TabIndex = 23
        '
        'txtrno
        '
        Me.txtrno.Location = New System.Drawing.Point(146, 13)
        Me.txtrno.Name = "txtrno"
        Me.txtrno.Size = New System.Drawing.Size(100, 20)
        Me.txtrno.TabIndex = 20
        '
        'txtsname
        '
        Me.txtsname.Location = New System.Drawing.Point(147, 51)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(100, 20)
        Me.txtsname.TabIndex = 22
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(22, 54)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(83, 15)
        Me.lblname.TabIndex = 21
        Me.lblname.Text = "Student Name"
        '
        'dnr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 378)
        Me.Controls.Add(Me.cbyear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.cbclass)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.rdofemale)
        Me.Controls.Add(Me.rdomale)
        Me.Controls.Add(Me.dtdob)
        Me.Controls.Add(Me.lblgender)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.txtaddr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblclass)
        Me.Controls.Add(Me.txtmob)
        Me.Controls.Add(Me.txtrno)
        Me.Controls.Add(Me.txtsname)
        Me.Controls.Add(Me.lblname)
        Me.Name = "dnr"
        Me.Text = "Doner Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbyear As System.Windows.Forms.ComboBox
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents cbclass As System.Windows.Forms.ComboBox
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents rdofemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdomale As System.Windows.Forms.RadioButton
    Friend WithEvents dtdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents txtaddr As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblclass As System.Windows.Forms.Label
    Friend WithEvents txtmob As System.Windows.Forms.TextBox
    Friend WithEvents txtrno As System.Windows.Forms.TextBox
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents lblname As System.Windows.Forms.Label
End Class
