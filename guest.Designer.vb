<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class guest
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
        Me.lblgname = New System.Windows.Forms.Label()
        Me.lbltopic = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.txtgname = New System.Windows.Forms.TextBox()
        Me.txttopic = New System.Windows.Forms.TextBox()
        Me.dtdob = New System.Windows.Forms.DateTimePicker()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblgname
        '
        Me.lblgname.AutoSize = True
        Me.lblgname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgname.Location = New System.Drawing.Point(26, 23)
        Me.lblgname.Name = "lblgname"
        Me.lblgname.Size = New System.Drawing.Size(73, 15)
        Me.lblgname.TabIndex = 0
        Me.lblgname.Text = "Guest Name"
        '
        'lbltopic
        '
        Me.lbltopic.AutoSize = True
        Me.lbltopic.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltopic.Location = New System.Drawing.Point(26, 64)
        Me.lbltopic.Name = "lbltopic"
        Me.lbltopic.Size = New System.Drawing.Size(36, 15)
        Me.lbltopic.TabIndex = 1
        Me.lbltopic.Text = "Topic"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(26, 105)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(32, 15)
        Me.lbldate.TabIndex = 2
        Me.lbldate.Text = "Date"
        '
        'txtgname
        '
        Me.txtgname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgname.Location = New System.Drawing.Point(107, 18)
        Me.txtgname.Name = "txtgname"
        Me.txtgname.Size = New System.Drawing.Size(206, 22)
        Me.txtgname.TabIndex = 3
        '
        'txttopic
        '
        Me.txttopic.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttopic.Location = New System.Drawing.Point(107, 58)
        Me.txttopic.Name = "txttopic"
        Me.txttopic.Size = New System.Drawing.Size(206, 22)
        Me.txttopic.TabIndex = 4
        '
        'dtdob
        '
        Me.dtdob.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtdob.Location = New System.Drawing.Point(106, 98)
        Me.dtdob.Name = "dtdob"
        Me.dtdob.Size = New System.Drawing.Size(207, 22)
        Me.dtdob.TabIndex = 5
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(29, 145)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 22)
        Me.btnsave.TabIndex = 6
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(210, 145)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 22)
        Me.btnreset.TabIndex = 7
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(29, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 149)
        Me.DataGridView1.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Guest Name"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Topic"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "DOB"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Delete"
        Me.Column4.Name = "Column4"
        '
        'guest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 357)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.dtdob)
        Me.Controls.Add(Me.txttopic)
        Me.Controls.Add(Me.txtgname)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lbltopic)
        Me.Controls.Add(Me.lblgname)
        Me.Name = "guest"
        Me.Text = "Resource Person visit Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblgname As System.Windows.Forms.Label
    Friend WithEvents lbltopic As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents txtgname As System.Windows.Forms.TextBox
    Friend WithEvents txttopic As System.Windows.Forms.TextBox
    Friend WithEvents dtdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
