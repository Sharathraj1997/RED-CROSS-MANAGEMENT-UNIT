<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewdnr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewdnr))
        Me.lblbg = New System.Windows.Forms.Label()
        Me.dgvdnr = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.cbbgrp = New System.Windows.Forms.ComboBox()
        CType(Me.dgvdnr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblbg
        '
        Me.lblbg.AutoSize = True
        Me.lblbg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbg.Location = New System.Drawing.Point(262, 55)
        Me.lblbg.Name = "lblbg"
        Me.lblbg.Size = New System.Drawing.Size(108, 15)
        Me.lblbg.TabIndex = 0
        Me.lblbg.Text = "Enter Blood Group"
        '
        'dgvdnr
        '
        Me.dgvdnr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdnr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Delete})
        Me.dgvdnr.Location = New System.Drawing.Point(18, 127)
        Me.dgvdnr.Name = "dgvdnr"
        Me.dgvdnr.Size = New System.Drawing.Size(1019, 207)
        Me.dgvdnr.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Rno"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Sname"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Class"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Blood Group"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Year"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "DOB"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Gen"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Addr"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Mob"
        Me.Column9.Name = "Column9"
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForLinkValue = True
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(571, 51)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(130, 23)
        Me.btnsearch.TabIndex = 3
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'cbbgrp
        '
        Me.cbbgrp.FormattingEnabled = True
        Me.cbbgrp.Location = New System.Drawing.Point(399, 49)
        Me.cbbgrp.Name = "cbbgrp"
        Me.cbbgrp.Size = New System.Drawing.Size(121, 21)
        Me.cbbgrp.TabIndex = 4
        '
        'viewdnr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1090, 371)
        Me.Controls.Add(Me.cbbgrp)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.dgvdnr)
        Me.Controls.Add(Me.lblbg)
        Me.Name = "viewdnr"
        Me.Text = "View Doner Details"
        CType(Me.dgvdnr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblbg As System.Windows.Forms.Label
    Friend WithEvents dgvdnr As System.Windows.Forms.DataGridView
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents cbbgrp As System.Windows.Forms.ComboBox
End Class
