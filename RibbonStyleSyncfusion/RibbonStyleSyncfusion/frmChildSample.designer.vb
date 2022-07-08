<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChildSample
    Inherits System.Windows.Forms.Form
    '//Inherits Syncfusion.Windows.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChildSample))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.itemAdd = New System.Windows.Forms.ToolStripButton()
        Me.itemEdit = New System.Windows.Forms.ToolStripButton()
        Me.itemDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.itemExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemAdd, Me.itemEdit, Me.itemDelete, Me.ToolStripSeparator1, Me.itemExit, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1075, 69)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'itemAdd
        '
        Me.itemAdd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.itemAdd.Image = CType(resources.GetObject("itemAdd.Image"), System.Drawing.Image)
        Me.itemAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.itemAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.itemAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.itemAdd.Name = "itemAdd"
        Me.itemAdd.Size = New System.Drawing.Size(62, 66)
        Me.itemAdd.Text = "Add Data"
        Me.itemAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'itemEdit
        '
        Me.itemEdit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.itemEdit.Image = CType(resources.GetObject("itemEdit.Image"), System.Drawing.Image)
        Me.itemEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.itemEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.itemEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.itemEdit.Name = "itemEdit"
        Me.itemEdit.Size = New System.Drawing.Size(61, 66)
        Me.itemEdit.Text = "Edit Data"
        Me.itemEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'itemDelete
        '
        Me.itemDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.itemDelete.Image = CType(resources.GetObject("itemDelete.Image"), System.Drawing.Image)
        Me.itemDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.itemDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.itemDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.itemDelete.Name = "itemDelete"
        Me.itemDelete.Size = New System.Drawing.Size(76, 66)
        Me.itemDelete.Text = "Delete Data"
        Me.itemDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 69)
        '
        'itemExit
        '
        Me.itemExit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.itemExit.Image = CType(resources.GetObject("itemExit.Image"), System.Drawing.Image)
        Me.itemExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.itemExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.itemExit.Name = "itemExit"
        Me.itemExit.Size = New System.Drawing.Size(52, 66)
        Me.itemExit.Text = "Close"
        Me.itemExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 69)
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData.Location = New System.Drawing.Point(0, 69)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(1075, 590)
        Me.dgvData.TabIndex = 4
        '
        'frmChildSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 659)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmChildSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Child Sample"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents itemAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents itemEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents itemDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents itemExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
End Class
