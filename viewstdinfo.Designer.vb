<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewstdinfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewstdinfo))
        Me.dgstud = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.cbclass = New System.Windows.Forms.ComboBox()
        Me.btnchangeyear = New System.Windows.Forms.Button()
        Me.cbyear = New System.Windows.Forms.ComboBox()
        CType(Me.dgstud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgstud
        '
        Me.dgstud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgstud.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgstud.Location = New System.Drawing.Point(14, 155)
        Me.dgstud.Name = "dgstud"
        Me.dgstud.Size = New System.Drawing.Size(942, 193)
        Me.dgstud.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Rno"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Class"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Year"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "DOB"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Gender"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Address"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Mobile"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Delete"
        Me.Column9.Name = "Column9"
        Me.Column9.Text = "DELETE"
        Me.Column9.UseColumnTextForLinkValue = True
        '
        'cbclass
        '
        Me.cbclass.FormattingEnabled = True
        Me.cbclass.Location = New System.Drawing.Point(153, 80)
        Me.cbclass.Name = "cbclass"
        Me.cbclass.Size = New System.Drawing.Size(151, 21)
        Me.cbclass.TabIndex = 1
        '
        'btnchangeyear
        '
        Me.btnchangeyear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchangeyear.Location = New System.Drawing.Point(644, 80)
        Me.btnchangeyear.Name = "btnchangeyear"
        Me.btnchangeyear.Size = New System.Drawing.Size(151, 25)
        Me.btnchangeyear.TabIndex = 2
        Me.btnchangeyear.Text = "ChangeTo-II- Year"
        Me.btnchangeyear.UseVisualStyleBackColor = True
        '
        'cbyear
        '
        Me.cbyear.FormattingEnabled = True
        Me.cbyear.Location = New System.Drawing.Point(396, 80)
        Me.cbyear.Name = "cbyear"
        Me.cbyear.Size = New System.Drawing.Size(151, 21)
        Me.cbyear.TabIndex = 3
        '
        'viewstdinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(974, 351)
        Me.Controls.Add(Me.cbyear)
        Me.Controls.Add(Me.btnchangeyear)
        Me.Controls.Add(Me.cbclass)
        Me.Controls.Add(Me.dgstud)
        Me.Name = "viewstdinfo"
        Me.Text = "View Student Details"
        CType(Me.dgstud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgstud As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents cbclass As System.Windows.Forms.ComboBox
    Friend WithEvents btnchangeyear As System.Windows.Forms.Button
    Friend WithEvents cbyear As System.Windows.Forms.ComboBox
End Class
