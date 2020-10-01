<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class marks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(marks))
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblheld = New System.Windows.Forms.Label()
        Me.lblattend = New System.Windows.Forms.Label()
        Me.lblmarks = New System.Windows.Forms.Label()
        Me.txtattend = New System.Windows.Forms.TextBox()
        Me.txtparticipation = New System.Windows.Forms.TextBox()
        Me.txtmarks = New System.Windows.Forms.TextBox()
        Me.btnaccept = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.lblclass = New System.Windows.Forms.Label()
        Me.lblyr = New System.Windows.Forms.Label()
        Me.lblothers = New System.Windows.Forms.Label()
        Me.txtothers = New System.Windows.Forms.TextBox()
        Me.lblregnum = New System.Windows.Forms.Label()
        Me.txtregnum = New System.Windows.Forms.TextBox()
        Me.btncal = New System.Windows.Forms.Button()
        Me.cbclass = New System.Windows.Forms.ComboBox()
        Me.cbyear = New System.Windows.Forms.ComboBox()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(25, 133)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(83, 15)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Student Name"
        '
        'lblheld
        '
        Me.lblheld.AutoSize = True
        Me.lblheld.Location = New System.Drawing.Point(25, 170)
        Me.lblheld.Name = "lblheld"
        Me.lblheld.Size = New System.Drawing.Size(108, 15)
        Me.lblheld.TabIndex = 1
        Me.lblheld.Text = "Attendance Marks"
        '
        'lblattend
        '
        Me.lblattend.AutoSize = True
        Me.lblattend.Location = New System.Drawing.Point(25, 207)
        Me.lblattend.Name = "lblattend"
        Me.lblattend.Size = New System.Drawing.Size(118, 15)
        Me.lblattend.TabIndex = 2
        Me.lblattend.Text = "Participation Marks"
        '
        'lblmarks
        '
        Me.lblmarks.AutoSize = True
        Me.lblmarks.Location = New System.Drawing.Point(25, 281)
        Me.lblmarks.Name = "lblmarks"
        Me.lblmarks.Size = New System.Drawing.Size(96, 15)
        Me.lblmarks.TabIndex = 3
        Me.lblmarks.Text = "Marks Obtained"
        '
        'txtattend
        '
        Me.txtattend.Location = New System.Drawing.Point(215, 167)
        Me.txtattend.Name = "txtattend"
        Me.txtattend.Size = New System.Drawing.Size(116, 22)
        Me.txtattend.TabIndex = 1
        '
        'txtparticipation
        '
        Me.txtparticipation.Location = New System.Drawing.Point(215, 206)
        Me.txtparticipation.Name = "txtparticipation"
        Me.txtparticipation.Size = New System.Drawing.Size(116, 22)
        Me.txtparticipation.TabIndex = 7
        '
        'txtmarks
        '
        Me.txtmarks.Location = New System.Drawing.Point(216, 274)
        Me.txtmarks.Name = "txtmarks"
        Me.txtmarks.Size = New System.Drawing.Size(116, 22)
        Me.txtmarks.TabIndex = 8
        '
        'btnaccept
        '
        Me.btnaccept.Location = New System.Drawing.Point(157, 322)
        Me.btnaccept.Name = "btnaccept"
        Me.btnaccept.Size = New System.Drawing.Size(87, 28)
        Me.btnaccept.TabIndex = 9
        Me.btnaccept.Text = "ACCEPT"
        Me.btnaccept.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(303, 320)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(94, 29)
        Me.btnclear.TabIndex = 10
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'lblclass
        '
        Me.lblclass.AutoSize = True
        Me.lblclass.Location = New System.Drawing.Point(25, 56)
        Me.lblclass.Name = "lblclass"
        Me.lblclass.Size = New System.Drawing.Size(38, 15)
        Me.lblclass.TabIndex = 12
        Me.lblclass.Text = "Class"
        '
        'lblyr
        '
        Me.lblyr.AutoSize = True
        Me.lblyr.Location = New System.Drawing.Point(25, 97)
        Me.lblyr.Name = "lblyr"
        Me.lblyr.Size = New System.Drawing.Size(32, 15)
        Me.lblyr.TabIndex = 14
        Me.lblyr.Text = "Year"
        '
        'lblothers
        '
        Me.lblothers.AutoSize = True
        Me.lblothers.Location = New System.Drawing.Point(25, 241)
        Me.lblothers.Name = "lblothers"
        Me.lblothers.Size = New System.Drawing.Size(46, 15)
        Me.lblothers.TabIndex = 21
        Me.lblothers.Text = "Others"
        '
        'txtothers
        '
        Me.txtothers.Location = New System.Drawing.Point(216, 241)
        Me.txtothers.Name = "txtothers"
        Me.txtothers.Size = New System.Drawing.Size(115, 22)
        Me.txtothers.TabIndex = 0
        '
        'lblregnum
        '
        Me.lblregnum.AutoSize = True
        Me.lblregnum.Location = New System.Drawing.Point(25, 25)
        Me.lblregnum.Name = "lblregnum"
        Me.lblregnum.Size = New System.Drawing.Size(77, 15)
        Me.lblregnum.TabIndex = 25
        Me.lblregnum.Text = "Roll Number"
        '
        'txtregnum
        '
        Me.txtregnum.Location = New System.Drawing.Point(217, 12)
        Me.txtregnum.Name = "txtregnum"
        Me.txtregnum.Size = New System.Drawing.Size(116, 22)
        Me.txtregnum.TabIndex = 0
        '
        'btncal
        '
        Me.btncal.Location = New System.Drawing.Point(9, 321)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(92, 29)
        Me.btncal.TabIndex = 29
        Me.btncal.Text = "CALCULATE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btncal.UseVisualStyleBackColor = True
        '
        'cbclass
        '
        Me.cbclass.FormattingEnabled = True
        Me.cbclass.Location = New System.Drawing.Point(217, 46)
        Me.cbclass.Name = "cbclass"
        Me.cbclass.Size = New System.Drawing.Size(115, 23)
        Me.cbclass.TabIndex = 30
        '
        'cbyear
        '
        Me.cbyear.FormattingEnabled = True
        Me.cbyear.Location = New System.Drawing.Point(217, 89)
        Me.cbyear.Name = "cbyear"
        Me.cbyear.Size = New System.Drawing.Size(115, 23)
        Me.cbyear.TabIndex = 31
        '
        'txtsname
        '
        Me.txtsname.Location = New System.Drawing.Point(215, 131)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(113, 22)
        Me.txtsname.TabIndex = 32
        '
        'marks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(425, 386)
        Me.Controls.Add(Me.txtsname)
        Me.Controls.Add(Me.cbyear)
        Me.Controls.Add(Me.cbclass)
        Me.Controls.Add(Me.btncal)
        Me.Controls.Add(Me.txtregnum)
        Me.Controls.Add(Me.lblregnum)
        Me.Controls.Add(Me.txtothers)
        Me.Controls.Add(Me.lblothers)
        Me.Controls.Add(Me.lblyr)
        Me.Controls.Add(Me.lblclass)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnaccept)
        Me.Controls.Add(Me.txtmarks)
        Me.Controls.Add(Me.txtparticipation)
        Me.Controls.Add(Me.txtattend)
        Me.Controls.Add(Me.lblmarks)
        Me.Controls.Add(Me.lblattend)
        Me.Controls.Add(Me.lblheld)
        Me.Controls.Add(Me.lblname)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "marks"
        Me.Text = "Marks Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblheld As System.Windows.Forms.Label
    Friend WithEvents lblattend As System.Windows.Forms.Label
    Friend WithEvents lblmarks As System.Windows.Forms.Label
    Friend WithEvents txtattend As System.Windows.Forms.TextBox
    Friend WithEvents txtparticipation As System.Windows.Forms.TextBox
    Friend WithEvents txtmarks As System.Windows.Forms.TextBox
    Friend WithEvents btnaccept As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents lblclass As System.Windows.Forms.Label
    Friend WithEvents lblyr As System.Windows.Forms.Label
    Friend WithEvents lblothers As System.Windows.Forms.Label
    Friend WithEvents txtothers As System.Windows.Forms.TextBox
    Friend WithEvents lblregnum As System.Windows.Forms.Label
    Friend WithEvents txtregnum As System.Windows.Forms.TextBox
    Friend WithEvents btncal As System.Windows.Forms.Button
    Friend WithEvents cbclass As System.Windows.Forms.ComboBox
    Friend WithEvents cbyear As System.Windows.Forms.ComboBox
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
End Class
