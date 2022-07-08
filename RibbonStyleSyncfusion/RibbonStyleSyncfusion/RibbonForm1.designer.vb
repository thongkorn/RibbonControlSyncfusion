<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RibbonForm1
    Inherits Syncfusion.Windows.Forms.Tools.RibbonForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RibbonForm1))
        Me.RibbonControlAdv1 = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv()
        Me.ToolStripTabItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripEx2 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolRibbonStyle = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Office2007ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Office2010ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Office2013ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TouchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Office2016ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripEx3 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTabItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripEx4 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.RibbonControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonControlAdv1.SuspendLayout()
        Me.ToolStripTabItem1.Panel.SuspendLayout()
        Me.ToolStripEx1.SuspendLayout()
        Me.ToolStripEx2.SuspendLayout()
        Me.ToolStripEx3.SuspendLayout()
        Me.ToolStripTabItem2.Panel.SuspendLayout()
        Me.ToolStripEx4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControlAdv1
        '
        Me.RibbonControlAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RibbonControlAdv1.Header.AddMainItem(ToolStripTabItem1)
        Me.RibbonControlAdv1.Header.AddMainItem(ToolStripTabItem2)
        Me.RibbonControlAdv1.Location = New System.Drawing.Point(1, 0)
        Me.RibbonControlAdv1.MenuButtonFont = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RibbonControlAdv1.MenuButtonText = ""
        Me.RibbonControlAdv1.MenuButtonWidth = 56
        Me.RibbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.RibbonControlAdv1.Name = "RibbonControlAdv1"
        Me.RibbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed
        '
        'RibbonControlAdv1.OfficeMenu
        '
        Me.RibbonControlAdv1.OfficeMenu.Name = "OfficeMenu"
        Me.RibbonControlAdv1.OfficeMenu.ShowItemToolTips = True
        Me.RibbonControlAdv1.OfficeMenu.Size = New System.Drawing.Size(12, 65)
        Me.RibbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RibbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None
        Me.RibbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016
        Me.RibbonControlAdv1.SelectedTab = Me.ToolStripTabItem1
        Me.RibbonControlAdv1.ShowRibbonDisplayOptionButton = True
        Me.RibbonControlAdv1.Size = New System.Drawing.Size(984, 161)
        Me.RibbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu"
        Me.RibbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:"
        Me.RibbonControlAdv1.TabIndex = 0
        Me.RibbonControlAdv1.Text = "RibbonControlAdv1"
        Me.RibbonControlAdv1.ThemeName = "Office2016"
        Me.RibbonControlAdv1.TitleColor = System.Drawing.Color.Black
        '
        'ToolStripTabItem1
        '
        Me.ToolStripTabItem1.Name = "ToolStripTabItem1"
        '
        'RibbonControlAdv1.RibbonPanel1
        '
        Me.ToolStripTabItem1.Panel.Controls.Add(Me.ToolStripEx1)
        Me.ToolStripTabItem1.Panel.Controls.Add(Me.ToolStripEx2)
        Me.ToolStripTabItem1.Panel.Controls.Add(Me.ToolStripEx3)
        Me.ToolStripTabItem1.Panel.Name = "RibbonPanel1"
        Me.ToolStripTabItem1.Panel.ScrollPosition = 0
        Me.ToolStripTabItem1.Panel.TabIndex = 2
        Me.ToolStripTabItem1.Panel.Text = "ToolStripTabItem1"
        Me.ToolStripTabItem1.Position = 0
        Me.ToolStripTabItem1.Size = New System.Drawing.Size(115, 30)
        Me.ToolStripTabItem1.Tag = "1"
        Me.ToolStripTabItem1.Text = "ToolStripTabItem1"
        '
        'ToolStripEx1
        '
        Me.ToolStripEx1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx1.Image = Nothing
        Me.ToolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStripEx1.Location = New System.Drawing.Point(0, 1)
        Me.ToolStripEx1.Name = "ToolStripEx1"
        Me.ToolStripEx1.Office12Mode = False
        Me.ToolStripEx1.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.ToolStripEx1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripEx1.Size = New System.Drawing.Size(223, 92)
        Me.ToolStripEx1.TabIndex = 6
        Me.ToolStripEx1.Text = "Group 1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(107, 73)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(107, 73)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripEx2
        '
        Me.ToolStripEx2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx2.Image = Nothing
        Me.ToolStripEx2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.toolRibbonStyle})
        Me.ToolStripEx2.Location = New System.Drawing.Point(225, 1)
        Me.ToolStripEx2.Name = "ToolStripEx2"
        Me.ToolStripEx2.Office12Mode = False
        Me.ToolStripEx2.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.ToolStripEx2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripEx2.Size = New System.Drawing.Size(321, 92)
        Me.ToolStripEx2.TabIndex = 7
        Me.ToolStripEx2.Text = "Group 2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(107, 73)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(107, 73)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 76)
        '
        'toolRibbonStyle
        '
        Me.toolRibbonStyle.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Office2007ToolStripMenuItem, Me.Office2010ToolStripMenuItem, Me.Office2013ToolStripMenuItem, Me.TouchToolStripMenuItem, Me.Office2016ToolStripMenuItem})
        Me.toolRibbonStyle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.toolRibbonStyle.Image = CType(resources.GetObject("toolRibbonStyle.Image"), System.Drawing.Image)
        Me.toolRibbonStyle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolRibbonStyle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolRibbonStyle.Name = "toolRibbonStyle"
        Me.toolRibbonStyle.Size = New System.Drawing.Size(92, 73)
        Me.toolRibbonStyle.Text = "Ribbon Style"
        Me.toolRibbonStyle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Office2007ToolStripMenuItem
        '
        Me.Office2007ToolStripMenuItem.Name = "Office2007ToolStripMenuItem"
        Me.Office2007ToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.Office2007ToolStripMenuItem.Text = "Office 2007"
        '
        'Office2010ToolStripMenuItem
        '
        Me.Office2010ToolStripMenuItem.Name = "Office2010ToolStripMenuItem"
        Me.Office2010ToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.Office2010ToolStripMenuItem.Text = "Office 2010"
        '
        'Office2013ToolStripMenuItem
        '
        Me.Office2013ToolStripMenuItem.Name = "Office2013ToolStripMenuItem"
        Me.Office2013ToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.Office2013ToolStripMenuItem.Text = "Office 2013"
        '
        'TouchToolStripMenuItem
        '
        Me.TouchToolStripMenuItem.Name = "TouchToolStripMenuItem"
        Me.TouchToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.TouchToolStripMenuItem.Text = "Touch Style"
        '
        'Office2016ToolStripMenuItem
        '
        Me.Office2016ToolStripMenuItem.Name = "Office2016ToolStripMenuItem"
        Me.Office2016ToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.Office2016ToolStripMenuItem.Text = "Office 2016"
        '
        'ToolStripEx3
        '
        Me.ToolStripEx3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx3.Image = Nothing
        Me.ToolStripEx3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit})
        Me.ToolStripEx3.Location = New System.Drawing.Point(548, 1)
        Me.ToolStripEx3.Name = "ToolStripEx3"
        Me.ToolStripEx3.Office12Mode = False
        Me.ToolStripEx3.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.ToolStripEx3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripEx3.Size = New System.Drawing.Size(94, 92)
        Me.ToolStripEx3.TabIndex = 8
        Me.ToolStripEx3.Text = "Group 3"
        '
        'tsbExit
        '
        Me.tsbExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tsbExit.Image = CType(resources.GetObject("tsbExit.Image"), System.Drawing.Image)
        Me.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(85, 73)
        Me.tsbExit.Text = "Exit Program"
        Me.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripTabItem2
        '
        Me.ToolStripTabItem2.Name = "ToolStripTabItem2"
        '
        'RibbonControlAdv1.RibbonPanel2
        '
        Me.ToolStripTabItem2.Panel.Controls.Add(Me.ToolStripEx4)
        Me.ToolStripTabItem2.Panel.Name = "RibbonPanel2"
        Me.ToolStripTabItem2.Panel.ScrollPosition = 0
        Me.ToolStripTabItem2.Panel.TabIndex = 3
        Me.ToolStripTabItem2.Panel.Text = "ToolStripTabItem2"
        Me.ToolStripTabItem2.Position = 1
        Me.ToolStripTabItem2.Size = New System.Drawing.Size(115, 30)
        Me.ToolStripTabItem2.Tag = "2"
        Me.ToolStripTabItem2.Text = "ToolStripTabItem2"
        '
        'ToolStripEx4
        '
        Me.ToolStripEx4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx4.Image = Nothing
        Me.ToolStripEx4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripButton6})
        Me.ToolStripEx4.Location = New System.Drawing.Point(0, 1)
        Me.ToolStripEx4.Name = "ToolStripEx4"
        Me.ToolStripEx4.Office12Mode = False
        Me.ToolStripEx4.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.ToolStripEx4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripEx4.Size = New System.Drawing.Size(223, 89)
        Me.ToolStripEx4.TabIndex = 2
        Me.ToolStripEx4.Text = "Group 4"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(107, 70)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(107, 70)
        Me.ToolStripButton6.Text = "ToolStripButton6"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(2, 637)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(978, 22)
        Me.StatusStrip1.TabIndex = 25
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.IsLink = True
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(725, 17)
        Me.ToolStripStatusLabel3.Spring = True
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RibbonForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 660)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RibbonControlAdv1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "RibbonForm1"
        Me.Padding = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.ShowApplicationIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RibbonControlAdv Style with Syncfusion Community Lincense Free"
        CType(Me.RibbonControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonControlAdv1.ResumeLayout(False)
        Me.RibbonControlAdv1.PerformLayout()
        Me.ToolStripTabItem1.Panel.ResumeLayout(False)
        Me.ToolStripTabItem1.Panel.PerformLayout()
        Me.ToolStripEx1.ResumeLayout(False)
        Me.ToolStripEx1.PerformLayout()
        Me.ToolStripEx2.ResumeLayout(False)
        Me.ToolStripEx2.PerformLayout()
        Me.ToolStripEx3.ResumeLayout(False)
        Me.ToolStripEx3.PerformLayout()
        Me.ToolStripTabItem2.Panel.ResumeLayout(False)
        Me.ToolStripTabItem2.Panel.PerformLayout()
        Me.ToolStripEx4.ResumeLayout(False)
        Me.ToolStripEx4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControlAdv1 As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
    Friend WithEvents ToolStripTabItem2 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Friend WithEvents ToolStripEx4 As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTabItem1 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Friend WithEvents ToolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripEx2 As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolRibbonStyle As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Office2007ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Office2010ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Office2013ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TouchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Office2016ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripEx3 As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
End Class
