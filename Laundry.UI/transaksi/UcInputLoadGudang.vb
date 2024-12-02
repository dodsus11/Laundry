Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class UcInputLoadGudang
    'Dim UiLib As New UIStyle
    Dim status As String
    Public headerId, idNow As Integer
    Public jumlahitemhapus As Integer = 0
    Public header As LoadGudangHeader
    Public detail As LoadGudangDetail
    Private loadSvr As ILoadGudangService
    Private utilmesinsetrikaSvr As IUtilmesinSetrikaService
    Dim dv As New DataView
    Dim dt As New DataTable
    Dim TambahLoadGudang As FormTambahLoadGudang
    Dim listOfProduct As List(Of LoadGudangDetail) = New List(Of LoadGudangDetail)()
    Dim listGudang As List(Of Linen) = New List(Of Linen)()
    Dim listGudangDetail As List(Of LoadGudangDetail) = New List(Of LoadGudangDetail)()
    Dim listGudangUtama As List(Of Linen) = New List(Of Linen)()
    Public Property _acl As SessionInfo.ACLUser

    Public Sub New()
        InitializeComponent()             
    End Sub

    Private Sub UcInputLoadGudang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load        
        dtpTgl.MaxDate = Today.AddYears(+10)
        dtpJam.MaxDate = Now.AddYears(+10)
        If header.idHeaderLoadGudang <> Nothing Then
            status = "edit"
            LabelJudul.Text = "Load Gudang : Edit"
            label_headerid.Text = header.idHeaderLoadGudang
            txtPetugas.Text = header.namaPetugas
            'dtpTgl.Text = header.tanggal
            'dtpJam.Text = header.jam.ToString
            dtpTgl.Value = Date.ParseExact(header.tanggalstr, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            dtpJam.Value = Date.ParseExact(header.jamstr, "HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            loadSvr = InProcFactory.CreateChannel(Of LoadGudangService, ILoadGudangService)()
            dt = loadSvr.getLoadgudangDetail(header.idHeaderLoadGudang)
            dgvInputLinen.DataSource = dt
            dgvInputLinen.AllowUserToAddRows = False
            AddStyleToGrid(dgvInputLinen)
            FormatGrid()
        Else
            status = "new"
            LabelJudul.Text = "Load Gudang : Input"
            dtpTgl.Value = Today
            dtpJam.Text = TimeOfDay
            AddStyleToGrid(dgvInputLinen)
        End If

    End Sub

    Private Sub FormatGrid()
        dgvInputLinen.Columns("linenKode").HeaderText = "Kode Linen"
        dgvInputLinen.Columns("linenKode").Width = 100
        dgvInputLinen.Columns("linenNama").HeaderText = "Nama Linen"
        dgvInputLinen.Columns("linenNama").Width = 100        
        dgvInputLinen.Columns("materialLinen").HeaderText = "Material"
        dgvInputLinen.Columns("materialLinen").Width = 100
        dgvInputLinen.Columns("jmlLinen").HeaderText = "Qty"
        dgvInputLinen.Columns("jmlLinen").Width = 100
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

    Private Function ValidateForm() As Boolean
        Dim result As Boolean = True
        If txtPetugas.Text = "" Then
            MsgBox("Petugas belum diisi", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf dgvInputLinen.RowCount = 0 Then
            MsgBox("Item Linen belum diisi", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        End If
        Return result
    End Function

    Private Sub ClearData()        
        txtPetugas.Text = ""
        dgvInputLinen.DataSource = Nothing
        dt.Columns.Clear()
        dt.Rows.Clear()
    End Sub

    Private Sub addItem(ByVal row As Object())
        dgvInputLinen.DataSource.Rows.Add(row)
    End Sub

    Private Sub ToolStripAdd_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripAdd.Click
        TambahLoadGudang = New FormTambahLoadGudang()
        TambahLoadGudang.ShowDialog(Me)
        Dim idx As Integer = -1

        For Each row As DataGridViewRow In dgvInputLinen.Rows
            If row.Cells(1).Value.ToString() = TambahLoadGudang.namalinen Then
                idx = row.Index
                Exit For
            End If
        Next
        If TambahLoadGudang.namalinen <> "" Then
            If idx = -1 Then
                If dgvInputLinen.RowCount = 0 Then
                    If status = "new" Then
                        dt.Columns.Add("Kode Linen", GetType(String))
                        dt.Columns.Add("Nama Linen", GetType(String))
                        dt.Columns.Add("Material", GetType(String))
                        dt.Columns.Add("Qty", GetType(Integer))
                        dt.Rows.Add(TambahLoadGudang.kodelinen, TambahLoadGudang.namalinen, TambahLoadGudang.materiallinen, TambahLoadGudang.jmllinen)
                        dgvInputLinen.DataSource = dt
                        dgvInputLinen.Columns(2).Width = 100
                    Else
                        addItem(New Object() {TambahLoadGudang.kodelinen, TambahLoadGudang.namalinen, TambahLoadGudang.materiallinen, TambahLoadGudang.jmllinen})
                    End If                    
                Else
                    addItem(New Object() {TambahLoadGudang.kodelinen, TambahLoadGudang.namalinen, TambahLoadGudang.materiallinen, TambahLoadGudang.jmllinen})
                End If
                idx = -1
            Else
                MessageBox.Show("Product already exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If Me.ValidateForm Then
            If MsgBox("Anda akan memproses load gudang?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then                
                If status = "edit" Then
                    Dim headerloadmdl As New LoadGudangHeader
                    headerId = label_headerid.Text
                    Me.loadSvr = InProcFactory.CreateChannel(Of LoadGudangService, ILoadGudangService)()
                    headerloadmdl.idHeaderLoadGudang = label_headerid.Text                    
                    headerloadmdl.namaPetugas = txtPetugas.Text

                    For Each r As DataGridViewRow In dgvInputLinen.Rows
                        If IsDBNull(r.Cells(4).Value) Then
                            Dim matrllinen As String
                            If r.Cells(2).Value = "Putih" Then
                                matrllinen = "1"
                            Else
                                matrllinen = "0"
                            End If
                            Dim detailloadmdl As New LoadGudangDetail
                            Dim gudangmdl As New Linen
                            detailloadmdl.idHeader = headerId
                            detailloadmdl.linenKode = r.Cells(0).Value
                            detailloadmdl.material = matrllinen
                            detailloadmdl.qty = r.Cells(3).Value
                            detailloadmdl.flag = "1"
                            gudangmdl.jns_linen_kode = r.Cells(0).Value
                            gudangmdl.jns_linen_nama = r.Cells(1).Value
                            gudangmdl.jumlah_linen = r.Cells(3).Value
                            listOfProduct.Add(detailloadmdl)
                            listGudang.Add(gudangmdl)
                        End If
                    Next
                    headerloadmdl.jmlJenisLinen = listOfProduct.Count
                    Me.loadSvr.EditLoadgudangHeader(headerloadmdl)
                    Me.loadSvr.AddItemLoadgudang(listOfProduct)
                    Me.loadSvr.AddStokGudangUtama(listGudang)

                    'kolekting dari hapus item
                    Me.loadSvr.deleteLoadgudangDetail(listGudangDetail)
                    Me.loadSvr.EditStokGudangUtama(listGudangUtama)
                    Me.loadSvr.EditLoadgudangHeaderJmlJnsLinen(headerId, jumlahitemhapus)

                Else
                    Dim headerloadmdl As New LoadGudangHeader
                    Me.loadSvr = InProcFactory.CreateChannel(Of LoadGudangService, ILoadGudangService)()                    
                    'headerId = (Me.loadSvr.AmbilHeaderId()) + 1
                    headerloadmdl.namaPetugas = txtPetugas.Text
                    headerloadmdl.tanggal = DateTime.Parse(dtpTgl.Value).ToString("yyyy/M/dd")
                    headerloadmdl.jam = dtpJam.Value.TimeOfDay
                    headerloadmdl.flag = "1" 'flag 1 artinya aktif
                    Me.loadSvr.AddLoadgudangHeader(headerloadmdl)

                    For Each r As DataGridViewRow In dgvInputLinen.Rows
                        Dim matrllinen As String
                        If r.Cells(2).Value = "Putih" Then
                            matrllinen = "1"
                        Else
                            matrllinen = "0"
                        End If
                        Dim detailloadmdl As New LoadGudangDetail
                        Dim gudangmdl As New Linen
                        detailloadmdl.idHeader = Me.loadSvr.AmbilHeaderId()
                        detailloadmdl.linenKode = r.Cells(0).Value
                        detailloadmdl.material = matrllinen
                        detailloadmdl.qty = r.Cells(3).Value
                        detailloadmdl.flag = "1"
                        gudangmdl.jns_linen_kode = r.Cells(0).Value
                        'gudangmdl.jns_linen_nama = r.Cells(1).Value
                        gudangmdl.jumlah_linen = r.Cells(3).Value
                        listOfProduct.Add(detailloadmdl)
                        listGudang.Add(gudangmdl)
                    Next
                    headerloadmdl.jmlJenisLinen = listOfProduct.Count
                    Me.loadSvr.AddItemLoadgudang(listOfProduct)
                    Me.loadSvr.AddStokGudangUtama(listGudang)
                End If

                InProcFactory.CloseChannel(loadSvr)
                listOfProduct.Clear()
                listGudang.Clear()
                listGudangDetail.Clear()
                listGudangUtama.Clear()               
                Dim uc As New ModInputLoadGudangNew
                UILibs.PageLink.goToPage(Me.Parent, uc, Me)
            End If
        End If
    End Sub

    Private Sub ToolStripDelete_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripDelete.Click
        If dgvInputLinen.SelectedRows.Count > 0 Then
            If MsgBox("List order akan dihapus ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                If status = "edit" Then
                    If IsDBNull(dgvInputLinen.CurrentRow.Cells(4).Value) Then 'jika id detail kosong (list hasil dari add baru)
                        MsgBox("Data " & dgvInputLinen.SelectedCells(1).Value & " berhasil dihapus")
                        dgvInputLinen.Rows.RemoveAt(dgvInputLinen.CurrentRow.Index)
                    Else 'jika id detail tidak kosong (list hasil dari load data)
                        'memeriksa apakah stok linen master/gudang mencukupi atau tidak
                        loadSvr = InProcFactory.CreateChannel(Of LoadGudangService, ILoadGudangService)()
                        Dim jmlerror As Integer
                        jmlerror = loadSvr.cekStokLinenByKodeLinen_jmlLinen(dgvInputLinen.SelectedCells(0).Value, dgvInputLinen.SelectedCells(3).Value)
                        If jmlerror > 0 Then
                            MessageBox.Show("Stok gudang linen tidak mencukupi untuk dikurangi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Dim delgudangdet As New LoadGudangDetail
                            Dim stokgudangutama As New Linen

                            'kolekting untuk edit flag load gudang detail
                            delgudangdet.idDetailLoadGudang = dgvInputLinen.SelectedCells(4).Value
                            delgudangdet.flag = "0"
                            listGudangDetail.Add(delgudangdet)

                            'kolekting untuk update jumlah gudang utama
                            stokgudangutama.jns_linen_kode = dgvInputLinen.SelectedCells(0).Value
                            stokgudangutama.jumlah_linen = dgvInputLinen.SelectedCells(3).Value
                            listGudangUtama.Add(stokgudangutama)

                            'kolekting untuk mengurangi jumlah jenis linen di luad gudang header
                            jumlahitemhapus = jumlahitemhapus + 1

                            MsgBox("Data " & dgvInputLinen.SelectedCells(1).Value & " berhasil dihapus")
                            dgvInputLinen.Rows.RemoveAt(dgvInputLinen.CurrentRow.Index)
                        End If
                    End If
                Else
                    MsgBox("Data " & dgvInputLinen.SelectedCells(1).Value & " berhasil dihapus")
                    dgvInputLinen.Rows.RemoveAt(dgvInputLinen.CurrentRow.Index)
                    If dgvInputLinen.RowCount = 0 Then
                        dt.Columns.Clear()
                    End If
                End If                
            End If
        Else
            MessageBox.Show("Silahkan pilih data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnBatal_Click(sender As System.Object, e As System.EventArgs) Handles btnBatal.Click
        'ClearData()
        'btnRuang.Focus()
        Dim uc As New ModInputLoadGudangNew
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    'Lookup Pegawai
    Private Sub btnPegawai_Click(sender As System.Object, e As System.EventArgs) Handles btnPegawai.Click
        Me.utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"nomer", "No", 40},
                              {"id_pegawai", "ID Pegawai", 80},
                              {"nama_pegawai", "Nama", 100},
                              {"nip_pegawai", "Nip", 200},
                              {"bagian", "Bagian", 200},
                              {"status_pegawai", "Status", 100}}

        frmLookUp.keyField = "id_pegawai"
        frmLookUp.fields = {"nama_pegawai", "nip_pegawai", "bagian", "status_pegawai"}

        frmLookUp.dt = Me.utilmesinsetrikaSvr.lookupPegawai()

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtPetugas.Text = frmLookUp.returnRow("nama_pegawai").ToString
            txtPetugas.Tag = frmLookUp.returnRow("id_pegawai").ToString
        End If
        InProcFactory.CloseChannel(Me.utilmesinsetrikaSvr)
    End Sub
End Class
