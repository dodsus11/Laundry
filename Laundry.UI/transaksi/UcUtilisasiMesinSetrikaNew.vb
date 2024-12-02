Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model
Imports System.Windows.Forms
Imports System.Drawing

Public Class UcUtilisasiMesinSetrikaNew
    Public utilmesinsetrika As Util_Mesin_Setrika
    Public mesin As Mesin
    Private utilmesinsetrikaSvr As IUtilmesinSetrikaService
    Private loadSvr As ILoadGudangService
    Private mesinSvr As IMesinService
    Private linenSvr As ILinenService
    Public jmlbersih As Integer
    Public jmlrusak As Integer
    Public jmlreject As Integer
    Public jmltot As Integer
    Dim TambahLinen As FormTambahLinenSetrika
    Dim object_edit As FormTambahLinenSetrika

    Dim dt As New DataTable
    Dim status As String
    'Public header As Util_Mesin_Setrika
    Public headerId As Integer
    Dim listOfProduct As List(Of Util_Mesin_Setrika) = New List(Of Util_Mesin_Setrika)()
    Dim listGudang As List(Of Linen) = New List(Of Linen)()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        'AddHandler SaveEditTemp.btnSaveAndClose.Click, AddressOf saveClose
        'AddHandler SaveEditTemp.btnCancel.Click, AddressOf btnCancel_Click
        'AddHandler SaveEditTemp.btnSaveAndNew.Click, AddressOf btnSaveNew_Click
        'AddHandler SaveEditTemp.btnClear.Click, AddressOf btnClear_Click
    End Sub

    Private Sub UcUtilisasiMesinSetrikaa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtpTgl.MaxDate = Today.AddYears(+10)
        If utilmesinsetrika.utilisasi_mesin_setrika_id <> Nothing Then
            status = "view"
            LabelJudul.Text = "Lihat Utilisasi Mesin Setrika"
            label_headerid.Text = utilmesinsetrika.utilisasi_mesin_setrika_id
            txtMesin.Text = utilmesinsetrika.nama_mesin
            txtMesin.Tag = utilmesinsetrika.kode_mesin
            txtPemakaian.Text = utilmesinsetrika.load_ke
            dtpTgl.Text = utilmesinsetrika.tanggal
            txtOperator.Text = utilmesinsetrika.operator_mesin
            txtOperator.Tag = utilmesinsetrika.operator_id
            utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
            dt = utilmesinsetrikaSvr.getUtilMesinSetrikaDetail(utilmesinsetrika.utilisasi_mesin_setrika_id)
            dgvInputLinen.DataSource = dt
            dgvInputLinen.AllowUserToAddRows = True
            btnSimpan.Visible = True
            'btnBatal.Text = "Kembali"
            ToolStrip1.Visible = True
            InProcFactory.CloseChannel(utilmesinsetrikaSvr)
            AddStyleToGrid(dgvInputLinen)
            FormatGrid()
        Else
            status = "new"
            LabelJudul.Text = "Tambah Utilisasi Mesin Setrika"
            dtpTgl.Value = Today
            'ToolStripEdit.Visible = False
            utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
            ''untuk nilai load
            'If utilmesinsetrikaSvr.cariTglSekarang(dtpTgl.Value) Then
            '    txtPemakaian.Text = utilmesinsetrikaSvr.ambilLoad(dtpTgl.Value) + 1
            'Else
            '    txtPemakaian.Text = 1
            'End If
            InProcFactory.CloseChannel(utilmesinsetrikaSvr)
            AddStyleToGrid(dgvInputLinen)
        End If

    End Sub

    Private Sub FormatGrid()
        dgvInputLinen.Columns("kodelinen").HeaderText = "Kode Linen"
        dgvInputLinen.Columns("kodelinen").Width = 0
        dgvInputLinen.Columns("kodelinen").Visible = False
        dgvInputLinen.Columns("namalinen").HeaderText = "Nama Linen"
        dgvInputLinen.Columns("namalinen").Width = 100
        dgvInputLinen.Columns("jmlbersih").HeaderText = "Jumlah Bersih"
        dgvInputLinen.Columns("jmlbersih").Width = 200
        dgvInputLinen.Columns("jmlrusak").HeaderText = "Jumlah Rusak"
        dgvInputLinen.Columns("jmlrusak").Width = 200
        dgvInputLinen.Columns("jmlreject").HeaderText = "Jumlah Reject"
        dgvInputLinen.Columns("jmlreject").Width = 200
        dgvInputLinen.Columns("jmltotal").HeaderText = "Jumlah Total"
        dgvInputLinen.Columns("jmltotal").Width = 200
        dgvInputLinen.Columns("detailid").HeaderText = "id detail"
        dgvInputLinen.Columns("detailid").Width = 100
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
        If txtMesin.Text = "" Then
            MsgBox("Mesin Masih Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf txtOperator.Text = "" Then
            MsgBox("Operator belum diisi", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf dgvInputLinen.RowCount = 0 Then
            MsgBox("Item Linen belum diisi", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        End If
        Return result
    End Function

    Private Sub ClearData()
        txtMesin.Text = ""
        txtOperator.Text = ""

        dgvInputLinen.DataSource = Nothing
        dt.Columns.Clear()
        dt.Rows.Clear()
    End Sub

    Private Sub addItem(ByVal row As Object())
        dgvInputLinen.DataSource.Rows.Add(row)

    End Sub

   

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnMesin.Click
        Me.utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"nomer", "No", 50},
                              {"kode_mesin", "Kode Mesin", 100},
                              {"nama_mesin", "Nama Mesin", 200},
                              {"kapasitas_mesin", "Kapasitas (lembar)", 150},
                              {"maxload_mesin", "Maks Load/hari", 150},
                              {"jenis_mesin", "Jenis Mesin", 150}}

        frmLookUp.keyField = "kode_mesin"
        frmLookUp.fields = {"nama_mesin", "kapasitas_mesin", "maxload_mesin", "jenis_mesin"}
        frmLookUp.dt = Me.utilmesinsetrikaSvr.getMesinSetrika(New Mesin With {.jenis_mesin = "4"})

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtMesin.Text = frmLookUp.returnRow("nama_mesin").ToString
            txtMesin.Tag = frmLookUp.returnRow("kode_mesin").ToString
            txtMesin.TabIndex = frmLookUp.returnRow("kapasitas_mesin")
        End If

        'untuk nilai load
        If utilmesinsetrikaSvr.cariTglSekarang(dtpTgl.Value, txtMesin.Tag) Then
            txtPemakaian.Text = utilmesinsetrikaSvr.ambilLoad(dtpTgl.Value, txtMesin.Tag) + 1
        Else
            txtPemakaian.Text = 1
        End If
        InProcFactory.CloseChannel(Me.utilmesinsetrikaSvr)
    End Sub

    Private Sub ToolStripAdd_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripAdd.Click
        TambahLinen = New FormTambahLinenSetrika()
        TambahLinen.ShowDialog(Me)
        If TambahLinen.namalinen <> "" Then
            If dgvInputLinen.RowCount = 0 Then
                If status = "new" Then
                    dt.Columns.Add("Kode Linen", GetType(String))
                    dt.Columns.Add("Nama Linen", GetType(String))
                    dt.Columns.Add("Jumlah Bersih", GetType(String))
                    dt.Columns.Add("Jumlah Rusak", GetType(Integer))
                    dt.Columns.Add("Jumlah Reject", GetType(Integer))
                    dt.Columns.Add("Jumlah Total", GetType(Integer))
                    dt.Rows.Add(TambahLinen.kodelinen, TambahLinen.namalinen, TambahLinen.jmllinenbersih, TambahLinen.jmllinenrusak, TambahLinen.jmllinenreject, (TambahLinen.jmllinenbersih + TambahLinen.jmllinenrusak + TambahLinen.jmllinenreject))
                    dgvInputLinen.DataSource = dt
                    'dgvInputLinen.Columns(0).Width = 0
                    'dgvInputLinen.Columns(2).Width = 200
                    'dgvInputLinen.Columns(3).Width = 200
                Else
                    addItem(New Object() {TambahLinen.kodelinen, TambahLinen.namalinen, TambahLinen.jmllinenbersih, TambahLinen.jmllinenrusak, TambahLinen.jmllinenreject, (TambahLinen.jmllinenbersih + TambahLinen.jmllinenrusak + TambahLinen.jmllinenreject)})
                End If
            Else
                addItem(New Object() {TambahLinen.kodelinen, TambahLinen.namalinen, TambahLinen.jmllinenbersih, TambahLinen.jmllinenrusak, TambahLinen.jmllinenreject, (TambahLinen.jmllinenbersih + TambahLinen.jmllinenrusak + TambahLinen.jmllinenreject)})
            End If
        End If

    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If Me.ValidateForm Then
            If MsgBox("Anda akan memproses utilisasi mesin setrika..." & vbCrLf & "Pastikan entrian benar!", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                If status = "view" Then
                    '=====VIEW TIDAK ADA STATUS SIMPAN====
                    utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
                    headerId = label_headerid.Text

                    'update util mesin setrika header
                    utilmesinsetrikaSvr.updateUtilMesinSetrikaHeader(New Util_Mesin_Setrika With {.utilisasi_mesin_setrika_id = headerId,
                                                                                            .tanggal = DateTime.Parse(dtpTgl.Value).ToString("yyyy/M/dd"),
                                                                                            .nama_mesin = txtMesin.Tag,
                                                                                            .load_ke = txtPemakaian.Text,
                                                                                            .operator_mesin = txtOperator.Tag})


                    'delete detail util setrika
                    utilmesinsetrikaSvr.deleteDetailUtilMesinSetrika(New Util_Mesin_Setrika With {.utilisasi_mesin_setrika_id = headerId})

                    'insert data util setrika yang baru
                    For Each r As DataGridViewRow In dgvInputLinen.Rows
                        Dim detailmdl As New Util_Mesin_Setrika
                        detailmdl.utilisasi_mesin_setrika_id = headerId
                        detailmdl.linen = r.Cells(0).Value
                        detailmdl.jumlah_linen_bersih = r.Cells(2).Value
                        detailmdl.jumlah_linen_rusak = r.Cells(3).Value
                        detailmdl.jumlah_linen_reject = r.Cells(4).Value
                        listOfProduct.Add(detailmdl)
                    Next
                    utilmesinsetrikaSvr.AddDetailUtilSetrika(listOfProduct)
                    '==============================================================
                    '==============================================================
                ElseIf status = "new" Then
                    utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
                    loadSvr = InProcFactory.CreateChannel(Of LoadGudangService, ILoadGudangService)()
                    utilmesinsetrikaSvr.insertUtilMesinSetrikaHeader(New Util_Mesin_Setrika With {.tanggal = DateTime.Parse(dtpTgl.Value).ToString("yyyy/M/dd"),
                                                                                            .nama_mesin = txtMesin.Tag,
                                                                                            .load_ke = txtPemakaian.Text,
                                                                                            .operator_mesin = txtOperator.Tag})
                    headerId = utilmesinsetrikaSvr.AmbilIdUtilSetrika()

                    For Each r As DataGridViewRow In dgvInputLinen.Rows
                        Dim detailmdl As New Util_Mesin_Setrika
                        Dim gudangmdl As New Linen
                        detailmdl.utilisasi_mesin_setrika_id = headerId
                        detailmdl.linen = r.Cells(0).Value
                        detailmdl.jumlah_linen_bersih = r.Cells(2).Value
                        detailmdl.jumlah_linen_rusak = r.Cells(3).Value
                        detailmdl.jumlah_linen_reject = r.Cells(4).Value
                        gudangmdl.jns_linen_kode = r.Cells(0).Value
                        gudangmdl.jumlah_linen = r.Cells(2).Value
                        listOfProduct.Add(detailmdl)
                        listGudang.Add(gudangmdl)
                    Next
                    utilmesinsetrikaSvr.AddDetailUtilSetrika(listOfProduct)
                    loadSvr.AddStokGudangUtama(listGudang)
                End If
                InProcFactory.CloseChannel(utilmesinsetrikaSvr)
                listOfProduct.Clear()
                listGudang.Clear()
                Dim uc As New ModUtilisasiMesinSetrikaNew
                UILibs.PageLink.goToPage(Me.Parent, uc, Me)
            End If
        End If
    End Sub

    Private Sub ToolStripDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dgvInputLinen.SelectedRows.Count > 0 Then
            If MsgBox("List order akan dihapus ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                MsgBox("Data " & dgvInputLinen.SelectedCells(1).Value & " berhasil dihapus")
                dgvInputLinen.Rows.RemoveAt(dgvInputLinen.CurrentRow.Index)
                If status = "new" Then
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
        Dim uc As New ModUtilisasiMesinSetrikaNew
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnOperator_Click(sender As System.Object, e As System.EventArgs) Handles btnOperator.Click
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
            txtOperator.Text = frmLookUp.returnRow("nama_pegawai").ToString
            txtOperator.Tag = frmLookUp.returnRow("id_pegawai").ToString
        End If

        InProcFactory.CloseChannel(Me.utilmesinsetrikaSvr)
    End Sub

    Private Sub ToolStripEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripEdit.Click
        Dim editrow As Integer

        If dgvInputLinen.SelectedRows.Count > 0 Then
            TambahLinen = New FormTambahLinenSetrika
            TambahLinen.Label1.Text = "UPDATE ITEM"
            TambahLinen.txtNamaLinen.Text = dgvInputLinen.SelectedRows(0).DataBoundItem(1).ToString
            TambahLinen.txtLinenBersih.Text = dgvInputLinen.SelectedRows(0).DataBoundItem(2).ToString
            TambahLinen.txtLinenRusak.Text = dgvInputLinen.SelectedRows(0).DataBoundItem(3).ToString
            TambahLinen.txtLinenReject.Text = dgvInputLinen.SelectedRows(0).DataBoundItem(4).ToString

            TambahLinen.ShowDialog(Me)

            dgvInputLinen.DataSource = dt

            editrow = dgvInputLinen.CurrentCell.RowIndex()

            Dim drw As DataRow = DirectCast(dgvInputLinen.Rows(editrow).DataBoundItem, DataRowView).Row
            If status = "new" Then
                
                drw("Jumlah Bersih") = TambahLinen.jmllinenbersih
                drw("Jumlah Rusak") = TambahLinen.jmllinenrusak
                drw("Jumlah Reject") = TambahLinen.jmllinenreject
                drw("Jumlah Total") = TambahLinen.jmllinenbersih + TambahLinen.jmllinenrusak + TambahLinen.jmllinenreject
            Else

                drw("jmlbersih") = TambahLinen.jmllinenbersih
                drw("jmlrusak") = TambahLinen.jmllinenrusak
                drw("jmlreject") = TambahLinen.jmllinenreject
                drw("jmltotal") = TambahLinen.jmllinenbersih + TambahLinen.jmllinenrusak + TambahLinen.jmllinenreject
            End If

        Else
            MessageBox.Show("Silahkan pilih data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    

    Private Sub ToolStripDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDelete.Click
        If dgvInputLinen.SelectedRows.Count > 0 Then
            If MsgBox("List order akan dihapus ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                MsgBox("Data " & dgvInputLinen.SelectedCells(1).Value & " berhasil dihapus")
                dgvInputLinen.Rows.RemoveAt(dgvInputLinen.CurrentRow.Index)
                If status = "new" Then
                    If dgvInputLinen.RowCount = 0 Then
                        dt.Columns.Clear()
                    End If
                End If
            End If
        Else
            MessageBox.Show("Silahkan pilih data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
