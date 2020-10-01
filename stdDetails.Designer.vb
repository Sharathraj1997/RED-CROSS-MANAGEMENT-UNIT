<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stdDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stdDetails))
        Me.lblname = New System.Windows.Forms.Label()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.txtrno = New System.Windows.Forms.TextBox()
        Me.txtmob = New System.Windows.Forms.TextBox()
        Me.lblclass = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtaddr = New System.Windows.Forms.TextBox()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.dtdob = New System.Windows.Forms.DateTimePicker()
        Me.rdomale = New System.Windows.Forms.RadioButton()
        Me.rdofemale = New System.Windows.Forms.RadioButton()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.cbclass = New System.Windows.Forms.ComboBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cbyear = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(26, 61)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(83, 15)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Student Name"
        '
        'txtsname
        '
        Me.txtsname.Location = New System.Drawing.Point(171, 58)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(116, 22)
        Me.txtsname.TabIndex = 1
        '
        'txtrno
        '
        Me.txtrno.Location = New System.Drawing.Point(170, 14)
        Me.txtrno.Name = "txtrno"
        Me.txtrno.Size = New System.Drawing.Size(116, 22)
        Me.txtrno.TabIndex = 0
        '
        'txtmob
        '
        Me.txtmob.Location = New System.Drawing.Point(171, 318)
        Me.txtmob.Name = "txtmob"
        Me.txtmob.Size = New System.Drawing.Size(116, 22)
        Me.txtmob.TabIndex = 4
        '
        'lblclass
        '
        Me.lblclass.AutoSize = True
        Me.lblclass.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclass.Location = New System.Drawing.Point(26, 97)
        Me.lblclass.Name = "lblclass"
        Me.lblclass.Size = New System.Drawing.Size(38, 15)
        Me.lblclass.TabIndex = 5
        Me.lblclass.Text = "Class"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Roll Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mobile Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Address"
        '
        'txtaddr
        '
        Me.txtaddr.Location = New System.Drawing.Point(171, 269)
        Me.txtaddr.Multiline = True
        Me.txtaddr.Name = "txtaddr"
        Me.txtaddr.Size = New System.Drawing.Size(193, 43)
        Me.txtaddr.TabIndex = 9
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(26, 189)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(78, 15)
        Me.lbldate.TabIndex = 10
        Me.lbldate.Text = "Date of Birth"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.Location = New System.Drawing.Point(27, 232)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(47, 15)
        Me.lblgender.TabIndex = 11
        Me.lblgender.Text = "Gender"
        '
        'dtdob
        '
        Me.dtdob.Location = New System.Drawing.Point(171, 189)
        Me.dtdob.Name = "dtdob"
        Me.dtdob.Size = New System.Drawing.Size(233, 22)
        Me.dtdob.TabIndex = 12
        '
        'rdomale
        '
        Me.rdomale.AutoSize = True
        Me.rdomale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdomale.Location = New System.Drawing.Point(171, 230)
        Me.rdomale.Name = "rdomale"
        Me.rdomale.Size = New System.Drawing.Size(52, 19)
        Me.rdomale.TabIndex = 13
        Me.rdomale.TabStop = True
        Me.rdomale.Text = "Male"
        Me.rdomale.UseVisualStyleBackColor = True
        '
        'rdofemale
        '
        Me.rdofemale.AutoSize = True
        Me.rdofemale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdofemale.Location = New System.Drawing.Point(300, 232)
        Me.rdofemale.Name = "rdofemale"
        Me.rdofemale.Size = New System.Drawing.Size(64, 19)
        Me.rdofemale.TabIndex = 14
        Me.rdofemale.TabStop = True
        Me.rdofemale.Text = "Female"
        Me.rdofemale.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(85, 393)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(87, 27)
        Me.btnsave.TabIndex = 15
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(287, 393)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(87, 27)
        Me.btnreset.TabIndex = 16
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'cbclass
        '
        Me.cbclass.FormattingEnabled = True
        Me.cbclass.Location = New System.Drawing.Point(171, 95)
        Me.cbclass.Name = "cbclass"
        Me.cbclass.Size = New System.Drawing.Size(181, 23)
        Me.cbclass.TabIndex = 17
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(27, 144)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 15)
        Me.lblYear.TabIndex = 18
        Me.lblYear.Text = "Year"
        '
        'cbyear
        '
        Me.cbyear.FormattingEnabled = True
        Me.cbyear.Location = New System.Drawing.Point(173, 137)
        Me.cbyear.Name = "cbyear"
        Me.cbyear.Size = New System.Drawing.Size(180, 23)
        Me.cbyear.TabIndex = 19
        '
        'stdDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(432, 431)
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
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "stdDetails"
        Me.Text = "Student Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents txtrno As System.Windows.Forms.TextBox
    Friend WithEvents txtmob As System.Windows.Forms.TextBox
    Friend WithEvents lblclass As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtaddr As System.Windows.Forms.TextBox
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents dtdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdomale As System.Windows.Forms.RadioButton
    Friend WithEvents rdofemale As System.Windows.Forms.RadioButton
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents cbclass As System.Windows.Forms.ComboBox
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents cbyear As System.Windows.Forms.ComboBox

End Class
