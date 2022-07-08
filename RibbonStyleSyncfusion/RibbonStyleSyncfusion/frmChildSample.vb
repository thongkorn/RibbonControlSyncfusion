#Region "ABOUT"
' / -----------------------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand only)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gnet.com/webboard
' /
' / Microsoft Visual Basic .Net 2010 + Service Pack 1
' / Syncfusion Community Free License.
' /
' / This is open source code under @Copyleft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / -----------------------------------------------------------------------------------------------
#End Region

Imports System.Data
Imports Syncfusion.Windows.Forms

Public Class frmChildSample

    Private Sub frmChildSample_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
    End Sub

    ' / -----------------------------------------------------------------------------------------------
    Private Sub frmChildSample_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.ControlBox = False
        '//
        Call SetupGridView(dgvData)
        dgvData.DataSource = GetDataTable()
    End Sub

    ' / -----------------------------------------------------------------------------------------------
    ' / Initialized DataGridView at Run Time.
    Private Sub SetupGridView(ByRef DGV As DataGridView)
        With DGV
            .RowHeadersVisible = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            '// Data rows
            .Font = New Font("Tahoma", 10)
            .RowTemplate.MinimumHeight = 27
            .RowTemplate.Height = 27
            '// Column Header
            .ColumnHeadersHeight = 30
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            '// Autosize Column
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '// Even-Odd Color
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            .DefaultCellStyle.SelectionForeColor = Color.White
            '// Header
            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.Navy
                .ForeColor = Color.White
                .Font = New Font(DGV.Font, FontStyle.Bold)
            End With
        End With
    End Sub

    ' / -----------------------------------------------------------------------------------------------
    ' / SAMPLE DATA with DataTable.
    Function GetDataTable() As Data.DataTable
        Dim dt As New Data.DataTable
        ' / เพิ่มหลัก (Columns) หรือฟิลด์ จำนวน 6 หลัก
        With dt
            .Columns.Add("EmployeePK", GetType(Integer))
            .Columns.Add("EmployeeID", GetType(String))
            .Columns.Add("EmployeeName", GetType(String))
            .Columns.Add("Position", GetType(String))
            .Columns.Add("Department", GetType(String))
            .Columns.Add("HireDate", GetType(Date))
        End With
        ' / เพิ่มรายการข้อมูล (Record) เรียงตามลำดับฟิลด์
        With dt
            .Rows.Add("1", "EMP00001", "นายทองก้อน ทับทิมกรอบ", "Managing Director", "Management", "01/01/2560")
            .Rows.Add("2", "EMP00002", "นายบุญห่อ พ่อรวย", "ช่างซ่อมบำรุง", "Technical", "01/06/2561")
            .Rows.Add("3", "EMP00003", "นางสาวฮานามิ อาริกาโตะ", "เลขา", "Management", "25/02/2563")
            .Rows.Add("4", "EMP00004", "นางบัวผัน ฝันเฟื่อง", "หัวหน้าบัญชี", "บัญชี", "11/11/2562")
            .Rows.Add("5", "EMP00005", "หนูมาลี มีลูกแมวเหมียว", "ธุรการ", "ธุรการ", "13/04/2560")
        End With
        '// Hidden Column 0 of DataTable
        dt.Columns(0).ColumnMapping = MappingType.Hidden
        Return dt
    End Function

    Private Sub itemAdd_Click(sender As System.Object, e As System.EventArgs) Handles itemAdd.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        MessageBoxAdv.MessageFont = New Font("Tahoma", 12, FontStyle.Regular)
        MessageBoxAdv.Show("You Click me for Add New Data.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub itemExit_Click(sender As System.Object, e As System.EventArgs) Handles itemExit.Click
        Me.Close()
    End Sub

    Private Sub itemEdit_Click(sender As System.Object, e As System.EventArgs) Handles itemEdit.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016
        MessageBoxAdv.MessageFont = New Font("Tahoma", 12, FontStyle.Regular)
        MessageBoxAdv.Show("You Click me for Edit Data.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub itemDelete_Click(sender As System.Object, e As System.EventArgs) Handles itemDelete.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010
        MessageBoxAdv.MessageFont = New Font("Tahoma", 12, FontStyle.Regular)
        MessageBoxAdv.Show("You Click me for Delete Data.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class