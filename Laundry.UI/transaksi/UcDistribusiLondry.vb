Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class UcDistribusiLondry
    'Dim UiLib As New UIStyle
    Dim status As String
    Public headerid, index As Integer
    Public header As OrderHeader
    Public detail As OrderDetail
    Private distrSvr As IDistribusiService
    Private loadSvr As ILoadGudangService
    Dim dv As New DataView
    Dim dt As New DataTable
    Dim editQtyDistr As FormQtyDistribusi
    Dim listOfProduct As List(Of OrderDetail) = New List(Of OrderDetail)()
    Dim listGudang As List(Of Linen) = New List(Of Linen)()
    Dim listDistribusi As List(Of OrderDistribusi) = New List(Of OrderDistribusi)()
    Public Property _acl As SessionInfo.ACLUser
    
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UcDistribusiLondry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        

        If header.flag <> "" Then                           'proses
            status = "proses"

            LabelJudul.Text = "Proses Distribusi Linen"
            txtNoOrder.Text = header.orderNo
            txtNoOrder.Tag = header.headerId
            txtRuangan.Text = header.ruang
            txtSubRuang.Text = header.subRuang
            dtpTgl.Value = Today
            dtpJam.Text = TimeOfDay
            distrSvr = InProcFactory.CreateChannel(Of DistribusiService, IDistribusiService)()
            dt = distrSvr.getOrderDetail(header.headerId)
            dgvInputLinen.DataSource = dt
            dgvInputLinen.AllowUserToAddRows = False

            AddStyleToGrid(dgvInputLinen)
            FormatGrid()
            'Dim btn As New DataGridViewButtonColumn
            'dgvInputLinen.Columns.Add(btn)
            'btn.Text = "add jumlah"
            'btn.Width = 75
            'btn.UseColumnTextForButtonValue = True

        Else
            status = "history"
            LabelJudul.Text = "History Distribusi Linen"
            txtNoOrder.Text = header.orderNo
            txtRuangan.Text = header.ruang
            txtSubRuang.Text = header.subRuang
            Label_petugas1.Visible = False
            Label_petugas2.Visible = False
            Label_tanggal.Visible = False
            Label_jam.Visible = False
            txtPetugas.Visible = False
            dtpTgl.Visible = False
            dtpJam.Visible = False
            btnSimpan.Visible = False
            ToolStripEdit.Enabled = False
            btnBatal.Text = "Kembali"
            distrSvr = InProcFactory.CreateChannel(Of DistribusiService, IDistribusiService)()
            dt = distrSvr.tampilHistory(header.headerId)
            dgvInputLinen.DataSource = dt
            dgvInputLinen.AllowUserToAddRows = False
            AddStyleToGrid(dgvInputLinen)
            FormatGridHistory()
        End If

    End Sub

    Private Sub FormatGrid()
        dgvInputLinen.Columns("linenKode").HeaderText = "Kode Linen"
        dgvInputLinen.Columns("linenKode").Width = 100
        dgvInputLinen.Columns("linenNama").HeaderText = "Nama Linen"
        dgvInputLinen.Columns("linenNama").Width = 120
        dgvInputLinen.Columns("jmlLinen").HeaderText = "Jml Linen"
        dgvInputLinen.Columns("jmlLinen").Width = 100
        dgvInputLinen.Columns("jmlLinen").ReadOnly = True
        dgvInputLinen.Columns("jmlLinenTerdist").HeaderText = "Sudah Distribusi"
        dgvInputLinen.Columns("jmlLinenTerdist").Width = 120
        dgvInputLinen.Columns("jmlLinenTerdist").ReadOnly = True
        dgvInputLinen.Columns("jmlLinenBlmDist").HeaderText = "Belum Distribusi"
        dgvInputLinen.Columns("jmlLinenBlmDist").Width = 120
        dgvInputLinen.Columns("jmlLinenBlmDist").ReadOnly = True
        dgvInputLinen.Columns("detailId").HeaderText = "id detail"
        dgvInputLinen.Columns("detailId").Width = 100
        dgvInputLinen.Columns("detailid").Visible = False
        dgvInputLinen.Columns("akanDist").HeaderText = "Akan Distribusi"
        dgvInputLinen.Columns("akanDist").Width = 120
        dgvInputLinen.Columns("akanDist").ReadOnly = False
    End Sub

    Private Sub FormatGridHistory()
        dgvInputLinen.Columns("noOrder").HeaderText = "No Order"
        dgvInputLinen.Columns("noOrder").Width = 100
        dgvInputLinen.Columns("ruang").HeaderText = "Ruang"
        dgvInputLinen.Columns("ruang").Width = 100
        dgvInputLinen.Columns("subRuang").HeaderText = "Sub Ruang"
        dgvInputLinen.Columns("subRuang").Width = 130
        dgvInputLinen.Columns("linen").HeaderText = "Linen"
        dgvInputLinen.Columns("linen").Width = 100
        dgvInputLinen.Columns("indek").HeaderText = "Distribusi ke"
        dgvInputLinen.Columns("indek").Width = 100
        dgvInputLinen.Columns("jumlahDistri").HeaderText = "Jml Distribusi"
        dgvInputLinen.Columns("jumlahDistri").Width = 100
        dgvInputLinen.Columns("tanggal").HeaderText = "Tanggal"
        dgvInputLinen.Columns("tanggal").Width = 100
        dgvInputLinen.Columns("jam").HeaderText = "Jam"
        dgvInputLinen.Columns("jam").Width = 100
        dgvInputLinen.Columns("petugas").HeaderText = "Petugas"
        dgvInputLinen.Columns("petugas").Width = 150
    End Sub


    Public Sub AddStyleToGrid(ByVal dgv As DataGridView)

        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'dgv.ReadOnly = True
        'dgv.ReadOnly = False
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

    'Private Sub ToolStripEdit_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripEdit.Click
    '    If dgvInputLinen.SelectedRows.Count > 0 Then
    '        If (dgvInputLinen.SelectedCells(3).Value = dgvInputLinen.SelectedCells(2).Value) Then 'linen sudah didistribusikan semua
    '            MessageBox.Show("Linen sudah didistribusikan semua, Silahkan pilih data yang lain", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Else
    '            Dim formQtyDistr As New FormQtyDistribusi(dgvInputLinen.SelectedCells(0).Value,
    '                                                  dgvInputLinen.SelectedCells(1).Value,
    '                                                  dgvInputLinen.SelectedCells(2).Value,
    '                                                  dgvInputLinen.SelectedCells(3).Value,
    '                                                  dgvInputLinen.SelectedCells(4).Value,
    '                                                  dgvInputLinen.SelectedCells(5).Value)

    '            formQtyDistr.ShowDialog()
    '            Dim jmldistri As Integer
    '            jmldistri = formQtyDistr.jmldistr
    '            dgvInputLinen.SelectedCells(4).Value = jmldistri
    '        End If
    '    Else
    '        MessageBox.Show("Silahkan pilih data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Anda akan memproses order Binatu?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Dim jmlerror As Integer
            headerid = txtNoOrder.Tag
            For Each r As DataGridViewRow In dgvInputLinen.Rows
                Dim detailmdl As New OrderDetail
                Dim gudangmdl As New Linen
                Dim distribusimdl As New OrderDistribusi


                detailmdl.detailId = r.Cells("detailId").Value
                detailmdl.qtyDistribusi = r.Cells("akanDist").Value


                loadSvr = InProcFactory.CreateChannel(Of LoadGudangService, ILoadGudangService)()

                'Dim kode As String
                'kode = r.Cells(0).Value
                'jmldistr = r.Cells(5).Value
                jmlerror = loadSvr.cekStokLinenByKodeLinen_jmlLinen(r.Cells("detailId").Value, r.Cells("akanDist").Value)

                If jmlerror > 0 Then
                    MessageBox.Show("Stok gudang linen " & r.Cells("jmlLinen").Value & " tidak mencukupi untuk dikurangi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit For
                Else
                    gudangmdl.jns_linen_kode = r.Cells("detailId").Value
                    gudangmdl.jumlah_linen = r.Cells("akanDist").Value
                End If

                distribusimdl.tanggal = DateTime.Parse(dtpTgl.Value).ToString("yyyy/M/dd")
                distribusimdl.jam = dtpJam.Value.TimeOfDay
                distribusimdl.indexperheader = distrSvr.AmbilIndexPerHeaderId(headerid, r.Cells(0).Value)
                distribusimdl.headerId = headerid
                distribusimdl.linen = r.Cells("linenKode").Value
                distribusimdl.qtyDistribusi = r.Cells("akanDist").Value
                distribusimdl.petugas = txtPetugas.Text

                listOfProduct.Add(detailmdl)
                listGudang.Add(gudangmdl)
                listDistribusi.Add(distribusimdl)
            Next

            If jmlerror = 0 Then
                Me.distrSvr.EditOrder(listOfProduct) 'update jumlah yg didistribusikan pada tabel Laundry_order_detail
                Me.distrSvr.UpdateStokGudangUtama(listGudang) 'update stok gudang utama
                Me.distrSvr.AddHistoryDistribusi(listDistribusi) 'tambah ke tabel Laundry_order_distribusi

                Me.distrSvr.EditHeaderFlag(txtNoOrder.Tag)
                InProcFactory.CloseChannel(distrSvr)
                listOfProduct.Clear()
                listGudang.Clear()

                Dim uc As New ModDistribusiLaundryNew
                'kembali ke halaman awal dengan nilai tgl tersimpan
                uc.dtpTanggalMulai.Value = header.tglAwal
                uc.dtpTanggalSelesai.Value = header.tglAkhir

                UILibs.PageLink.goToPage(Me.Parent, uc, Me)

            Else
                'InProcFactory.CloseChannel(distrSvr)
                listOfProduct.Clear()
                listGudang.Clear()
                listDistribusi.Clear()
                'Dim uc As New ModDistribusiLaundry
                'UILibs.PageLink.goToPage(Me.Parent, uc, Me)
            End If

        End If
        'End If

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        'ClearData()
        'btnRuang.Focus()

        Dim uc As New ModDistribusiLaundryNew
        uc.dtpTanggalMulai.Value = header.tglAwal
        uc.dtpTanggalSelesai.Value = header.tglAkhir
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    'Private Sub dgvInputLinen_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInputLinen.CellContentClick
    '    If (dgvInputLinen.SelectedCells(3).Value = dgvInputLinen.SelectedCells(2).Value) Then 'linen sudah didistribusikan semua
    '        MessageBox.Show("Linen sudah didistribusikan semua, Silahkan pilih data yang lain", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Else
    '        Dim formQtyDistr As New FormQtyDistribusi(dgvInputLinen.SelectedCells(1).Value,
    '                                              dgvInputLinen.SelectedCells(2).Value,
    '                                              dgvInputLinen.SelectedCells(3).Value,
    '                                              dgvInputLinen.SelectedCells(4).Value,
    '                                              dgvInputLinen.SelectedCells(5).Value,
    '                                              dgvInputLinen.SelectedCells(6).Value)

    '        formQtyDistr.ShowDialog()
    '        Dim jmldistri As Integer
    '        jmldistri = formQtyDistr.jmldistr
    '        dgvInputLinen.SelectedCells(7).Value = jmldistri
    '    End If
    'End Sub
    Private Sub return_to_mod_distribusi()


    End Sub
End Class
