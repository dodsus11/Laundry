Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class UCLinenTransIn
    'Dim UiLib As New UIStyle
    Dim status As String    
    Public transInId As Integer
    Public header As TransIn
    Public detail As TransInDetail
    Private persediaanSvr As ILinenService
    Private loadSvr As ILoadGudangService
    Private utilmesinsetrikaSvr As IUtilmesinSetrikaService
    Dim dv As New DataView
    Dim dt As New DataTable
    Dim TambahLinen As FormPersediaanLinen
    Dim listOfProduct As List(Of TransInDetail) = New List(Of TransInDetail)()
    Dim listMasterLinen As List(Of Linen) = New List(Of Linen)()
    Dim listEditCancel As List(Of TransInDetail) = New List(Of TransInDetail)()
    Dim listPenguranganJmlLinen As List(Of Linen) = New List(Of Linen)()
    Dim listFlagDetail As List(Of TransInDetail) = New List(Of TransInDetail)()
    Public Property _acl As SessionInfo.ACLUser

    Public Sub New()
        InitializeComponent()
        'AddHandler SaveEditTemp.btnSaveAndClose.Click, AddressOf saveClose
        'AddHandler SaveEditTemp.btnCancel.Click, AddressOf btnCancel_Click
        'AddHandler SaveEditTemp.btnSaveAndNew.Click, AddressOf btnSaveNew_Click
        'AddHandler SaveEditTemp.btnClear.Click, AddressOf btnClear_Click        
    End Sub

    Private Sub UCLinenTransIn_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load        
        If header.idTransIn <> Nothing Then
            status = "edit"
            LabelJudul.Text = "Persediaan : Linen Masuk (Detail)"
            label_headerid.Text = header.idTransIn
            dtpTgl.Text = header.tglTI
            txtKeterangan.Text = header.ketTI
            txtPetugas.Text = header.entryByTI
            'dtpJam.Text = header.entryJamTI.ToString
            persediaanSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
            dt = persediaanSvr.getItemMasukDetail(header.idTransIn)
            dgvTransIn.DataSource = dt
            dgvTransIn.AllowUserToAddRows = False
            ToolStrip1.Visible = True
            btnSimpan.Visible = True
            btnBatal.Text = "Exit"
            AddStyleToGrid(dgvTransIn)
            FormatGrid()

            'kolekting data linen awal 
            For Each r As DataGridViewRow In dgvTransIn.Rows
                Dim detailTransInmdl As New TransInDetail
                Dim masterlinenmdl As New Linen

                detailTransInmdl.idTransInDetail = r.Cells("detailId").Value
                masterlinenmdl.jns_linen_kode = r.Cells("kodeLinen").Value
                'masterlinenmdl.jumlah_linen = r.Cells("jumlahLinen").Value
                masterlinenmdl.jumlah_linen_persediaan_masuk = 0
                masterlinenmdl.jumlah_linen_persediaan_keluar = r.Cells("jumlahLinen").Value
                listFlagDetail.Add(detailTransInmdl)
                listPenguranganJmlLinen.Add(masterlinenmdl)

            Next


        Else
            status = "new"
            LabelJudul.Text = "Persediaan : Linen Masuk (Input Baru)"
            dtpTgl.Value = Today
            dtpJam.Text = TimeOfDay
            AddStyleToGrid(dgvTransIn)
        End If

    End Sub

    Private Sub FormatGrid()
        dgvTransIn.Columns("kodeLInen").HeaderText = "Kode Linen"
        dgvTransIn.Columns("kodeLInen").Width = 100
        dgvTransIn.Columns("namaLinen").HeaderText = "Nama Linen"
        dgvTransIn.Columns("namaLinen").Width = 200
        dgvTransIn.Columns("jumlahLinen").HeaderText = "Qty"
        dgvTransIn.Columns("jumlahLinen").Width = 100
        dgvTransIn.Columns("detailId").HeaderText = "id detail"
        dgvTransIn.Columns("detailId").Width = 100
        dgvTransIn.Columns("detailid").Visible = False
    End Sub


    Public Sub AddStyleToGrid(ByVal dgv As DataGridView)

        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ReadOnly = False
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
        ElseIf txtKeterangan.Text = "" Then
            MsgBox("Keterangan belum diisi", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf dgvTransIn.RowCount = 0 Then
            MsgBox("Item Linen belum diisi", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        End If
        Return result
    End Function

    Private Sub ClearData()
        txtPetugas.Text = ""
        txtKeterangan.Text = ""

        dgvTransIn.DataSource = Nothing
        dt.Columns.Clear()
        dt.Rows.Clear()
    End Sub

    Private Sub addItem(ByVal row As Object())
        dgvTransIn.DataSource.Rows.Add(row)
    End Sub

    Private Sub ToolStripAdd_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripAdd.Click
        TambahLinen = New FormPersediaanLinen()
        TambahLinen.ShowDialog(Me)
        Dim idx As Integer = -1        

        For Each row As DataGridViewRow In dgvTransIn.Rows
            If row.Cells(2).Value.ToString() = TambahLinen.namalinen Then
                idx = row.Index                                             'untuk mengecek apakah produk sudah ada/belum
                Exit For
            End If
        Next
        If TambahLinen.namalinen <> "" Then
            If idx = -1 Then
                If dgvTransIn.RowCount = 0 Then
                    If status = "new" Then
                        dt.Columns.Add("Kode Linen", GetType(String))
                        dt.Columns.Add("Nama Linen", GetType(String))
                        dt.Columns.Add("Qty", GetType(Integer))
                        dt.Rows.Add(TambahLinen.kodeLinen, TambahLinen.namalinen, TambahLinen.jmllinen)
                        dgvTransIn.DataSource = dt
                        dgvTransIn.Columns(2).Width = 100
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
            If MsgBox("Anda akan memproses update persediaan linen?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                'header = New OrderHeader

                If status = "edit" Then
                    Dim headerTransInmdl As New TransIn
                    Me.persediaanSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
                    headerTransInmdl.idTransIn = label_headerid.Text
                    headerTransInmdl.tglTI = DateTime.Parse(dtpTgl.Value).ToString("yyyy/M/dd")
                    headerTransInmdl.ketTI = txtKeterangan.Text
                    headerTransInmdl.entryByTI = txtPetugas.Text
                    headerTransInmdl.entryJamTI = dtpJam.Value.TimeOfDay
                    Me.persediaanSvr.editTransIn(headerTransInmdl)
                    transInId = label_headerid.Text

                    For Each r As DataGridViewRow In dgvTransIn.Rows
                        'If IsDBNull(r.Cells("detailId").Value) Then
                        Dim detailTransInmdl As New TransInDetail
                        Dim masterlinenmdl As New Linen
                        detailTransInmdl.idTransIn = transInId
                        detailTransInmdl.kode_jenis_linen = r.Cells("kodeLinen").Value
                        detailTransInmdl.qty = r.Cells("jumlahLinen").Value
                        listOfProduct.Add(detailTransInmdl)
                        masterlinenmdl.jns_linen_kode = r.Cells("kodeLinen").Value
                        'masterlinenmdl.jumlah_linen = r.Cells("jumlahLinen").Value
                        masterlinenmdl.jumlah_linen_persediaan_masuk = r.Cells("jumlahLinen").Value
                        masterlinenmdl.jumlah_linen_persediaan_keluar = 0
                        listMasterLinen.Add(masterlinenmdl)
                        'End If
                    Next
                    'hapus item lama 

                    persediaanSvr.insertTransInDetail(listOfProduct) 'insert item baru

                    '=======
                    'persediaanSvr.updateJumlahStokLinenIN("kredit", listMasterLinen) 'untuk menambahkan jumlah stok gudang
                    persediaanSvr.UpdateJumlahStokPersediaanLinen(listMasterLinen) 'update item di tabel utama
                    'persediaanSvr.updateJumlahStokLinenIN("debit", listPenguranganJmlLinen) 'untuk mengurangi jumlah stok gudang akibat pembatalan list
                    persediaanSvr.UpdateJumlahStokPersediaanLinen(listPenguranganJmlLinen)
                    persediaanSvr.editCancelTransInDetail(listFlagDetail)
                Else
                    Dim headerTransInmdl As New TransIn
                    Me.persediaanSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
                    headerTransInmdl.tglTI = DateTime.Parse(dtpTgl.Value).ToString("yyyy/M/dd")
                    headerTransInmdl.ketTI = txtKeterangan.Text
                    headerTransInmdl.entryByTI = txtPetugas.Text
                    headerTransInmdl.entryJamTI = dtpJam.Value.TimeOfDay
                    Me.persediaanSvr.insertTransIn(headerTransInmdl)
                    transInId = Me.persediaanSvr.AmbilTransInId()

                    For Each r As DataGridViewRow In dgvTransIn.Rows
                        Dim detailTransInmdl As New TransInDetail
                        Dim masterlinenmdl As New Linen
                        detailTransInmdl.idTransIn = transInId
                        detailTransInmdl.kode_jenis_linen = r.Cells("Kode Linen").Value
                        detailTransInmdl.qty = r.Cells("Qty").Value
                        listOfProduct.Add(detailTransInmdl)
                        masterlinenmdl.jns_linen_kode = r.Cells("Kode Linen").Value
                        masterlinenmdl.jumlah_linen = r.Cells("Qty").Value
                        masterlinenmdl.jumlah_linen_persediaan_masuk = r.Cells("Qty").Value
                        masterlinenmdl.jumlah_linen_persediaan_keluar = 0
                        listMasterLinen.Add(masterlinenmdl)
                    Next
                    persediaanSvr.insertTransInDetail(listOfProduct)
                    'persediaanSvr.updateJumlahStokLinenIN("kredit", listMasterLinen)
                    persediaanSvr.UpdateJumlahStokPersediaanLinen(listMasterLinen)
                End If
                InProcFactory.CloseChannel(persediaanSvr)
                listOfProduct.Clear()
                listMasterLinen.Clear()
                listPenguranganJmlLinen.Clear()
                listEditCancel.Clear()
                Dim uc As New ModLinenTransInNew
                UILibs.PageLink.goToPage(Me.Parent, uc, Me)
            End If
        End If
    End Sub

    Private Sub ToolStripDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dgvTransIn.SelectedRows.Count > 0 Then
            If MsgBox("List akan dihapus ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                If status = "edit" Then
                    If IsDBNull(dgvTransIn.CurrentRow.Cells(3).Value) Then 'jika id detail kosong (list hasil dari add baru)
                        MsgBox("Data " & dgvTransIn.SelectedCells(1).Value & " berhasil dihapus dari list")
                        dgvTransIn.Rows.RemoveAt(dgvTransIn.CurrentRow.Index)
                    Else 'jika id detail tidak kosong (list hasil dari load data)
                        'memeriksa apakah stok linen gudang mencukupi atau tidak
                        loadSvr = InProcFactory.CreateChannel(Of LoadGudangService, ILoadGudangService)()
                        Dim jmlerror As Integer
                        jmlerror = loadSvr.cekStokLinenByKodeLinen_jmlLinen(dgvTransIn.SelectedCells(0).Value, dgvTransIn.SelectedCells(2).Value)
                        If jmlerror > 0 Then
                            MessageBox.Show("Stok gudang linen tidak mencukupi untuk dikurangi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Dim cancelby As New TransInDetail
                            Dim masterlinenmdl As New Linen

                            'kolekting untuk edit cancel transin detail
                            cancelby.idTransInDetail = dgvTransIn.SelectedCells(3).Value
                            listEditCancel.Add(cancelby)

                            'kolekting untuk pengurangan stok gudang dari hasil pembatalan
                            masterlinenmdl.jns_linen_kode = dgvTransIn.SelectedCells(0).Value
                            'masterlinenmdl.jumlah_linen = dgvTransIn.SelectedCells(2).Value
                            masterlinenmdl.jumlah_linen_persediaan_masuk = 0
                            masterlinenmdl.jumlah_linen_persediaan_keluar = dgvTransIn.SelectedCells(2).Value
                            listPenguranganJmlLinen.Add(masterlinenmdl)

                            MsgBox("Data " & dgvTransIn.SelectedCells(1).Value & " berhasil dihapus dari list")
                            dgvTransIn.Rows.RemoveAt(dgvTransIn.CurrentRow.Index)
                        End If
                    End If
                Else
                    MsgBox("Data " & dgvTransIn.SelectedCells(1).Value & " berhasil dihapus dari list")
                    dgvTransIn.Rows.RemoveAt(dgvTransIn.CurrentRow.Index)
                    If dgvTransIn.RowCount = 0 Then
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
        Dim uc As New ModLinenTransInNew
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    'Lookup petugas
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

    Private Sub ToolStripEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripEdit.Click
        Dim editrow As Integer

        If dgvTransIn.SelectedRows.Count > 0 Then
            TambahLinen = New FormPersediaanLinen
            TambahLinen.Label1.Text = "UPDATE ITEM"
            TambahLinen.txtKodeLinen.Text = dgvTransIn.SelectedRows(0).DataBoundItem(0).ToString
            TambahLinen.txtNamaLinen.Text = dgvTransIn.SelectedRows(0).DataBoundItem(1).ToString
            TambahLinen.txtQtyLinen.Text = dgvTransIn.SelectedRows(0).DataBoundItem(2).ToString


            TambahLinen.ShowDialog(Me)

            dgvTransIn.DataSource = dt

            editrow = dgvTransIn.CurrentCell.RowIndex()

            Dim drw As DataRow = DirectCast(dgvTransIn.Rows(editrow).DataBoundItem, DataRowView).Row

            drw("kodelinen") = TambahLinen.kodeLinen
            drw("namalinen") = TambahLinen.namalinen
            drw("jumlahLinen") = TambahLinen.jmllinen


        Else
            MessageBox.Show("Silahkan pilih data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub ToolStripDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDelete.Click
        If dgvTransIn.SelectedRows.Count > 0 Then
            If MsgBox("List akan dihapus ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                If status = "edit" Then
                    If IsDBNull(dgvTransIn.CurrentRow.Cells(3).Value) Then 'jika id detail kosong (list hasil dari add baru)
                        MsgBox("Data " & dgvTransIn.SelectedCells(1).Value & " berhasil dihapus dari list")
                        dgvTransIn.Rows.RemoveAt(dgvTransIn.CurrentRow.Index)
                    Else 'jika id detail tidak kosong (list hasil dari load data)
                        'memeriksa apakah stok linen gudang mencukupi atau tidak
                        loadSvr = InProcFactory.CreateChannel(Of LoadGudangService, ILoadGudangService)()
                        Dim jmlerror As Integer
                        jmlerror = loadSvr.cekStokLinenByKodeLinen_jmlLinen(dgvTransIn.SelectedCells(0).Value, dgvTransIn.SelectedCells(2).Value)
                        If jmlerror > 0 Then
                            MessageBox.Show("Stok gudang linen tidak mencukupi untuk dikurangi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Dim cancelby As New TransInDetail
                            Dim masterlinenmdl As New Linen

                            'kolekting untuk edit cancel transin detail
                            cancelby.idTransInDetail = dgvTransIn.SelectedCells(3).Value
                            listEditCancel.Add(cancelby)

                            'kolekting untuk pengurangan stok gudang dari hasil pembatalan
                            masterlinenmdl.jns_linen_kode = dgvTransIn.SelectedCells(0).Value
                            'masterlinenmdl.jumlah_linen = dgvTransIn.SelectedCells(2).Value
                            masterlinenmdl.jumlah_linen_persediaan_masuk = 0
                            masterlinenmdl.jumlah_linen_persediaan_keluar = dgvTransIn.SelectedCells(2).Value
                            listPenguranganJmlLinen.Add(masterlinenmdl)

                            MsgBox("Data " & dgvTransIn.SelectedCells(1).Value & " berhasil dihapus dari list")
                            dgvTransIn.Rows.RemoveAt(dgvTransIn.CurrentRow.Index)
                        End If
                    End If
                Else
                    MsgBox("Data " & dgvTransIn.SelectedCells(1).Value & " berhasil dihapus dari list")
                    dgvTransIn.Rows.RemoveAt(dgvTransIn.CurrentRow.Index)
                    If dgvTransIn.RowCount = 0 Then
                        dt.Columns.Clear()
                    End If
                End If
            End If
        Else
            MessageBox.Show("Silahkan pilih data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
