#Region "ABOUT"
' / -----------------------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand only)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gnet.com/webboard
' /
' / Purpose: RibbonControlAdv Style with Syncfusion Community Free License.
' / Microsoft Visual Basic .Net 2010 + Service Pack 1
' /
' / This is open source code under @Copyleft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / -----------------------------------------------------------------------------------------------
#End Region

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class RibbonForm1

    ' / -----------------------------------------------------------------------------------------------
    ' / S T A R T ... H E R E
    Private Sub RibbonForm1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.RibbonControlAdv1.IsFormManager = True
        '// This form is MDI Form.
        Me.IsMdiContainer = True
        '// Change Properties @Run Time
        With Me.RibbonControlAdv1
            '/ You can test the toggle feature properties.
            '.AutoLayoutToolStrip = False
            .MenuButtonEnabled = False
            .MenuButtonVisible = False
            .QuickPanelVisible = False
            .ScaleMenuButtonImage = False
            .ShowContextMenu = True ' False
            .ShowLauncher = False
            .ShowMinimizeButton = True  ' False
            .ShowQuickItemsDropDownButton = False
            .ShowRibbonDisplayOptionButton = False ' True
        End With
        '// Get value ribbon style from Project Properties --> Setting.
        Select Case My.Settings.RibbonStyle
            Case 0
                Call Office2007ToolStripMenuItem_Click(sender, e)
            Case 1
                Call Office2010ToolStripMenuItem_Click(sender, e)
            Case 2
                Call Office2013ToolStripMenuItem_Click(sender, e)
            Case 3
                Call TouchToolStripMenuItem_Click(sender, e)
            Case 4
                Call Office2016ToolStripMenuItem_Click(sender, e)
        End Select
        '// StatusStrip
        ToolStripStatusLabel1.Text = "[Design and Code By: Thongkorn Tubtimkrob]"
        ToolStripStatusLabel2.Text = "Download Syncfusion Community License Free."
        ToolStripStatusLabel3.Text = ""
        '// Refresh every 1 Min. (1000 ms = 1 sec.)
        Timer1.Interval = 1000
        Timer1.Enabled = True
    End Sub

    '// Office 2007
    Private Sub Office2007ToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles Office2007ToolStripMenuItem.Click
        Me.RibbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2007
        Office12ColorTable.ApplyManagedColors(Me, Color.Red)
        Me.Office2007ToolStripMenuItem.Checked = True
        '// 
        Me.Office2010ToolStripMenuItem.Checked = False
        Me.Office2013ToolStripMenuItem.Checked = False
        Me.Office2016ToolStripMenuItem.Checked = False
        Me.TouchToolStripMenuItem.Checked = False
        '/ Save Setting RibbonStyle.
        My.Settings.RibbonStyle = 0
    End Sub

    ' / -----------------------------------------------------------------------------------------------
    '// Office 2010
    Private Sub Office2010ToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles Office2010ToolStripMenuItem.Click
        Me.RibbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2010
        Me.Office2010ToolStripMenuItem.Checked = True
        '// 
        Me.Office2007ToolStripMenuItem.Checked = False
        Me.Office2013ToolStripMenuItem.Checked = False
        Me.Office2016ToolStripMenuItem.Checked = False
        Me.TouchToolStripMenuItem.Checked = False
        My.Settings.RibbonStyle = 1
    End Sub

    ' / -----------------------------------------------------------------------------------------------
    '// Office 2013
    Private Sub Office2013ToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles Office2013ToolStripMenuItem.Click
        Me.RibbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2013
        Me.Office2013ToolStripMenuItem.Checked = True
        '// 
        Me.Office2007ToolStripMenuItem.Checked = False
        Me.Office2010ToolStripMenuItem.Checked = False
        Me.Office2016ToolStripMenuItem.Checked = False
        Me.TouchToolStripMenuItem.Checked = False
        My.Settings.RibbonStyle = 2
    End Sub

    ' / -----------------------------------------------------------------------------------------------
    '// Touch Tool
    Private Sub TouchToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles TouchToolStripMenuItem.Click
        Me.RibbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.TouchStyle
        Me.TouchToolStripMenuItem.Checked = True
        '// 
        Me.Office2007ToolStripMenuItem.Checked = False
        Me.Office2010ToolStripMenuItem.Checked = False
        Me.Office2013ToolStripMenuItem.Checked = False
        Me.Office2016ToolStripMenuItem.Checked = False
        My.Settings.RibbonStyle = 3
    End Sub

    ' / -----------------------------------------------------------------------------------------------
    '// Office 2016
    Private Sub Office2016ToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles Office2016ToolStripMenuItem.Click
        Me.RibbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016
        Me.Office2016ToolStripMenuItem.Checked = True
        '// 
        Me.Office2007ToolStripMenuItem.Checked = False
        Me.Office2010ToolStripMenuItem.Checked = False
        Me.Office2013ToolStripMenuItem.Checked = False
        Me.TouchToolStripMenuItem.Checked = False
        My.Settings.RibbonStyle = 4
    End Sub

    ' / -----------------------------------------------------------------------------------------------
    ' / Open sample form.
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        'MessageBox.Show("You Click me.")
        With frmChildSample
            .MdiParent = Me
            .TopMost = True
            .Show()
        End With
    End Sub

    Private Sub tsbExit_Click(sender As Object, e As System.EventArgs) Handles tsbExit.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Me.ToolStripStatusLabel3.Text = "Date-Time: " & Format(Now(), "dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripStatusLabel2.Click
        Process.Start("https://www.syncfusion.com/products/communitylicense")
    End Sub
End Class