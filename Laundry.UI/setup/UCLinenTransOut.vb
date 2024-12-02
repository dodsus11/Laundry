Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class UCLinenTransOut
    'Dim UiLib As New UIStyle
    Dim status As String
    Public transOutId As Integer
    Public header As TransOut
    Public detail As TransOutDetail
    Private persediaanSvr As ILinenService
    Private utilmesinsetrikaSvr As IUtilmesinSetrikaService
    Dim dv As New DataView
    Dim dt As New DataTable
    Dim TambahLinen As FormPersediaanLinen
    Dim listOfProductIsi As List(Of TransOutDetail) = New List(Of TransOutDetail)()
    Dim listOfProduct As List(Of TransOutDetail) = New List(Of TransOutDetail)()
    Dim listMasterLinen As List(Of Linen) = New List(Of Linen)()
    Dim listEditCancel As List(Of TransOutDetail) = New List(Of TransOutDetail)()
    Dim listPenambahanJmlLinen As List(Of Linen) = New List(Of Linen)()
    Public Property _acl As SessionInfo.ACLUser

    Public Sub New()
        InitializeComponent()
        'AddHandler SaveEditTemp.btnSaveAndClose.Click, AddressOf saveClose
        'AddHandler SaveEditTemp.btnCancel.Click, AddressOf btnCancel_Click
        'AddHandler SaveEditTemp.btnSaveAndNew.Click, AddressOf btnSaveNew_Click
        'AddHandler SaveEditTemp.btnClear.Click, AddressOf btnClear_Click        
    End Sub

    Private Property transInId As Integer

    Private Sub UCLinenTransIn_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If header.idTransOut <> Nothing Then
            status = "edit"
            LabelJudul.Text = "Persediaan : Linen Keluar (Detail)"
            label_headerid.Text = header.idTransOut
            txtPetugas.Text = header.entryByTO
            If header.kategoriTO = "Rusak" Then
                rbRusak.Checked = True
            Else
                rbHilang.Checked = True
            End If
            txtKeterangan.Text = header.ketTO
            dtpTgl.Text = header.tglTO
            'dtpJam.Text = header.entryJamTO.ToString
            persediaanSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
            dt = persediaanSvr.getItemKeluarDetail(header.idTransOut)
            dgvTransOut.DataSource = dt
            dgvTransOut.AllowUserToAddRows = False
            ToolStrip1.Visible = False
            btnSimpan.Visible = False
            btnBatal.Text = "Exit"
            AddStyleToGrid(dgvTransOut)
            FormatGrid()
        Else
            status = "new"
            LabelJudul.Text = "Persediaan : Linen Keluar (Input Baru)"
            dtpTgl.Value = Today
            dtpJam.Text = TimeOfDay
            AddStyleToGrid(dgvTransOut)
        End If

    End Sub

    Private Sub FormatGrid()
        dgvTransOut.Columns("kodeLInen").HeaderText = "Kode Linen"
        dgvTransOut.Columns("kodeLInen").Width = 100
        dgvTransOut.Columns("namaLinen").HeaderText = "Nama Linen"
        dgvTransOut.Columns("namaLinen").Width = 200
        dgvTransOut.Columns("jumlahLinen").HeaderText = "Qty"
        dgvTransOut.Columns("jumlahLinen").Width = 100
        dgvTransOut.Columns("detailId").HeaderText = "id detail"
        dgvTransOut.Columns("detailId").Width = 100
        dgvTransOut.Columns("detailid").Visible = False
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
            MsgBox("Petugas Masih Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf rbRusak.Checked = False And rbHilang.Checked = False Then
            MsgBox("Kategori Belum Dipilih", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf txtKeterangan.Text = "" Then
            MsgBox("Keterangan belum diisi", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf dgvTransOut.RowCount = 0 Then
            MsgBox("Item Linen belum diisi", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        End If
        Return result
    End Function

    Private Sub ClearData()
        txtPetugas.Text = ""
        txtKeterangan.Text = ""

        dgvTransOut.DataSource = Nothing
        dt.Columns.Clear()
        dt.Rows.Clear()
    End Sub

    Private Sub addItem(ByVal row As Object())
        dgvTransOut.DataSource.Rows.Add(row)
    End Sub

    Private Sub ToolStripAdd_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripAdd.Click
        TambahLinen = New FormPersediaanLinen()
        TambahLinen.ShowDialog(Me)
        Dim idx As Integer = -1

        For Each row As DataGridViewRow In dgvTransOut.Rows
            If row.Cells(2).Value.ToString() = TambahLinen.namalinen Then
                idx = row.Index                                                 'untuk mengecek apakah produk sudah ada/belum
                Exit For
            End If
        Next
        If TambahLinen.namalinen <> "" Then
            If idx = -1 Then
                If dgvTransOut.RowCount = 0 Then
                    If status = "new" Then
                        dt.Columns.Add("Kode Linen", GetType(String))
                        dt.Columns.Add("Nama Linen", GetType(String))
                        dt.Columns.Add("Qty", GetType(Integer))
                        dt.Rows.Add(TambahLinen.kodeLinen, TambahLinen.namalinen, TambahLinen.jmllinen)
                        dgvTransOut.DataSource = dt
                        dgvTransOut.Columns(2).Width = 100
                    Else
                        addItem(New Object() {TambahLinen.kodeLinen, TambahLinen.namalinen, TambahLinen.jmllinen})
                    End If
                    
                Else
                    addItem(New Object() {TambahLinen.kodeLinen, TambahLinen.namalinen, TambahLinen.jmllinen})
                End If
                idx = -1
            Else
                MessageBox.Show("Product already exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If Me.ValidateForm Then
            If MsgBox("Anda akan memproses update persediaan linen keluar?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then                

                If status = "edit" Then
                    Dim headerTransOutMdl As New TransOut
                    Me.persediaanSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
                    headerTransOutMdl.idTransOut = label_headerid.Text
                    headerTransOutMdl.tglTO = DateTime.Parse(dtpTgl.Value).ToString("yyyy/M/dd")
                    If rbRusak.Checked = True Then
                        headerTransOutMdl.kategoriTO = "Rusak"
                    ElseIf rbHilang.Checked = True Then
                        headerTransOutMdl.kategoriTO = "Hilang"
                    End If
                    headerTransOutMdl.ketTO = txtKeterangan.Text
                    headerTransOutMdl.entryByTO = txtPetugas.Text
                    headerTransOutMdl.entryJamTO = dtpJam.Value.TimeOfDay
                    Me.persediaanSvr.editTransOut(headerTransOutMdl)
                    transOutId = label_headerid.Text

                    For Each r As DataGridViewRow In dgvTransOut.Rows
                        If IsDBNull(r.Cells(3).Value) Then
                            Dim detailTransOutMdl As New TransOutDetail
                            Dim masterlinenmdl As New Linen
                            detailTransOutMdl.idTransOut = transOutId
                            detailTransOutMdl.kode_jenis_linen = r.Cells(0).Value
                            detailTransOutMdl.qty = r.Cells(2).Value
                            listOfProduct.Add(detailTransOutMdl)
                            masterlinenmdl.jns_linen_kode = r.Cells(0).Value
                            'masterlinenmdl.jumlah_linen = r.Cells(2).Value
                            masterlinenmdl.jumlah_linen_persediaan_masuk = 0
                            masterlinenmdl.jumlah_linen_persediaan_keluar = r.Cells(2).Value
                            listMasterLinen.Add(masterlinenmdl)
                        End If
                    Next
                    persediaanSvr.insertTransOutDetail(listOfProduct)
                    'persediaanSvr.updateJumlahStokLinenOUT("debit", listMasterLinen) 'untuk mengurangi jumlah stok gudang
                    persediaanSvr.UpdateJumlahStokPersediaanLinen(listMasterLinen)
                    'persediaanSvr.updateJumlahStokLinenOUT("kredit", listPenambahanJmlLinen) 'untuk menambahkan jumlah stok gudang akibat pembatalan list
                    persediaanSvr.UpdateJumlahStokPersediaanLinen(listPenambahanJmlLinen)
                    persediaanSvr.editCancelTransOutDetail(listEditCancel)

                    InProcFactory.CloseChannel(persediaanSvr)
                    listOfProduct.Clear()
                    listMasterLinen.Clear()
                    listPenambahanJmlLinen.Clear()
                    listEditCancel.Clear()
                    Dim uc As New ModLinenTransOutNew
                    UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                Else
                    Me.persediaanSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()

                    Dim jmlerror As Integer
                    For Each isi As DataGridViewRow In dgvTransOut.Rows   'untuk mengecek apakah stok gudang (tabel gudang) bisa dikurangi
                        Dim isimodel As New TransOutDetail
                        isimodel.kode_jenis_linen = isi.Cells(0).Value
                        isimodel.qty = isi.Cells(2).Value
                        listOfProductIsi.Add(isimodel)
                    Next
                    jmlerror = persediaanSvr.cekStokLinenByKodeLinen_jmlLinen(listOfProductIsi)
                    If jmlerror > 0 Then
                        MessageBox.Show("Stok gudang linen tidak mencukupi untuk dikurangi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        listOfProductIsi.Clear()
                    Else
                        Dim headerTransOutMdl As New TransOut
                        headerTransOutMdl.tglTO = DateTime.Parse(dtpTgl.Value).ToString("yyyy/M/dd")
                        If rbRusak.Checked = True Then
                            headerTransOutMdl.kategoriTO = "Rusak"
                        ElseIf rbHilang.Checked = True Then
                            headerTransOutMdl.kategoriTO = "Hilang"
                        End If
                        headerTransOutMdl.ketTO = txtKeterangan.Text
                        headerTransOutMdl.entryByTO = txtPetugas.Text
                        headerTransOutMdl.entryJamTO = dtpJam.Value.TimeOfDay
                        Me.persediaanSvr.insertTransOut(headerTransOutMdl)
                        transOutId = Me.persediaanSvr.AmbilTransOutId()

                        For Each r As DataGridViewRow In dgvTransOut.Rows
                            Dim detailTransOutMdl As New TransOutDetail
                            Dim masterlinenmdl As New Linen
                            detailTransOutMdl.idTransOut = transOutId
                            detailTransOutMdl.kode_jenis_linen = r.Cells(0).Value
                            detailTransOutMdl.qty = r.Cells(2).Value
                            listOfProduct.Add(detailTransOutMdl)

                            masterlinenmdl.jns_linen_kode = r.Cells(0).Value
                            'masterlinenmdl.jumlah_linen = r.Cells(2).Value
                            masterlinenmdl.jumlah_linen_persediaan_masuk = 0
                            masterlinenmdl.jumlah_linen_persediaan_keluar = r.Cells(2).Value
                            listMasterLinen.Add(masterlinenmdl)
                        Next
                        persediaanSvr.insertTransOutDetail(listOfProduct)
                        'persediaanSvr.updateJumlahStokLinenOUT("debit", listMasterLinen)
                        persediaanSvr.UpdateJumlahStokPersediaanLinen(listMasterLinen)

                        InProcFactory.CloseChannel(persediaanSvr)
                        listOfProduct.Clear()
                        listMasterLinen.Clear()
                        listPenambahanJmlLinen.Clear()
                        listEditCancel.Clear()
                        Dim uc As New ModLinenTransOutNew
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    End If
                End If
                
            End If
        End If
    End Sub

    Private Sub ToolStripDelete_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripDelete.Click
        If dgvTransOut.SelectedRows.Count > 0 Then
            If MsgBox("List order akan dihapus ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then                
                If status = "edit" Then
                    If IsDBNull(dgvTransOut.CurrentRow.Cells(3).Value) Then
                        MsgBox("Data " & dgvTransOut.SelectedCells(1).Value & " berhasil dihapus dari list")
                        dgvTransOut.Rows.RemoveAt(dgvTransOut.CurrentRow.Index)
                    Else
                        Dim cancelby As New TransOutDetail
                        Dim masterlinenmdl As New Linen

                        'kolekting untuk edit cancel transout detail
                        cancelby.idTransOutDetail = dgvTransOut.SelectedCells(3).Value
                        listEditCancel.Add(cancelby)

                        'kolekting untuk penambahan stok gudang dari hasil pembatalan
                        masterlinenmdl.jns_linen_kode = dgvTransOut.SelectedCells(0).Value
                        'masterlinenmdl.jumlah_linen = dgvTransOut.SelectedCells(2).Value
                        masterlinenmdl.jumlah_linen_persediaan_masuk = dgvTransOut.SelectedCells(2).Value
                        masterlinenmdl.jumlah_linen_persediaan_keluar = 0
                        listPenambahanJmlLinen.Add(masterlinenmdl)

                        MsgBox("Data " & dgvTransOut.SelectedCells(1).Value & " berhasil dihapus dari list")
                        dgvTransOut.Rows.RemoveAt(dgvTransOut.CurrentRow.Index)
                    End If
                Else
                    MsgBox("Data " & dgvTransOut.SelectedCells(1).Value & " berhasil dihapus dari list")
                    dgvTransOut.Rows.RemoveAt(dgvTransOut.CurrentRow.Index)
                    If dgvTransOut.RowCount = 0 Then
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
        Dim uc As New ModLinenTransOutNew
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    'lookup petugas
    Private Sub btnPetugas_Click(sender As System.Object, e As System.EventArgs) Handles btnPetugas.Click
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
