Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Imports SessionInfo

Public Class UCHistoryTransaksi        
    Public header As OrderHeader    
    Private orderSvr As IOrderService    
    Dim dt As New DataTable            
    Public Property _acl As SessionInfo.ACLUser

    Public Sub New()
        InitializeComponent()
        'AddHandler SaveEditTemp.btnSaveAndClose.Click, AddressOf saveClose
        'AddHandler SaveEditTemp.btnCancel.Click, AddressOf btnCancel_Click
        'AddHandler SaveEditTemp.btnSaveAndNew.Click, AddressOf btnSaveNew_Click
        'AddHandler SaveEditTemp.btnClear.Click, AddressOf btnClear_Click        
    End Sub

    Private Sub UCHistoryTransaksi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load      
        dtpTgl.MaxDate = Today.AddYears(+10)
        dtpJam.MaxDate = Now.AddYears(+10)
        LabelJudul.Text = "Detail History Order/Transaksi"
        label_headerid.Text = header.headerId
        txtRuangan.Text = header.ruang
        txtPetugas.Text = header.namaPegawai
        'dtpTgl.Text = header.tanggal
        'dtpJam.Text = header.jam.ToString
        dtpTgl.Value = Date.ParseExact(header.tanggalstr, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        dtpJam.Value = Date.ParseExact(header.jamstr, "HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        txtPetugasLaundry.Text = ModSessi.fullName
        orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
        dt = orderSvr.getOrderDetail(header.headerId)
        dgvInputLinen.DataSource = dt
        dgvInputLinen.AllowUserToAddRows = False
        AddStyleToGrid(dgvInputLinen)
        FormatGrid()        
    End Sub

    Private Sub FormatGrid()
        dgvInputLinen.Columns("linenId").HeaderText = "ID Linen"
        dgvInputLinen.Columns("linenId").Width = 100
        dgvInputLinen.Columns("linenNama").HeaderText = "Nama Linen"
        dgvInputLinen.Columns("linenNama").Width = 100
        dgvInputLinen.Columns("jmlLinenNon").HeaderText = "Qty NonInfeksius"
        dgvInputLinen.Columns("jmlLinenNon").Width = 130
        dgvInputLinen.Columns("jmlLinenInf").HeaderText = "Qty Infeksius"
        dgvInputLinen.Columns("jmlLinenInf").Width = 100
        dgvInputLinen.Columns("detailId").HeaderText = "id detail"
        dgvInputLinen.Columns("detailId").Width = 100
        dgvInputLinen.Columns("detailid").Visible = False
    End Sub


    Public Sub AddStyleToGrid(ByVal dgv As DataGridView)

        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ReadOnly = True
        dgv.MultiSelect = False

        dgv.AllowUserToResizeRows = False
        dgv.AllowUserToAddRows = False
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgv.ColumnHeadersHeight = 25

        With (dgv.ColumnHeadersDefaultCellStyle)
            .BackColor = Color.DimGray
            .ForeColor = Color.White
            .Font = New Font(dgv.Font, FontStyle.Bold)
        End With
        dgv.GridColor = Color.DarkGray
        dgv.DefaultCellStyle.SelectionBackColor = Color.Silver
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black

    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Dim uc As New ModHistoryTransaksi
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

End Class
