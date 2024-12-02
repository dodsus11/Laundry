Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Public Class UcAddDetailDataPerolehanLinen
    Public transOutId As Integer
    Public header As TransOut
    Public detail As TransOutDetail
    Private persediaanSvr As ILinenService
    Private utilmesinsetrikaSvr As IUtilmesinSetrikaService
    Dim dv As New DataView
    Dim dt As New DataTable
    Dim dtLinenKeluar As New TransOut
    Dim TambahLinen As FormAddDataLinen
    Public linen As New PerolehanLinen
    Public Property _acl As SessionInfo.ACLUser
    Private Sub tsNew2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNew2.Click
        linen.kodeLinen = dgvDtPerolehanLinen.SelectedRows(0).DataBoundItem("linen")
        linen.namaLinen = dgvDtPerolehanLinen.SelectedRows(0).DataBoundItem("nama_linen")
        linen.entry_by = txtPetugas.Text
        TambahLinen = New FormAddDataLinen With {.namaLinen = linen.namaLinen, .kodelinen = linen.kodeLinen, .petugas = linen.entry_by}
        TambahLinen.ShowDialog(Me)

    End Sub


    Private Sub UcAddDetailDataPerolehanLinen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        persediaanSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
        Dim user As String = header.entryByTO
        Dim tgl As Date
        txtPetugas.Text = user
        txtPetugas.ReadOnly = True
        tgl = header.tgl
        dt = persediaanSvr.LoadDetailDataLinenRusakbyTanggal(tgl)
        dgvDtPerolehanLinen.DataSource = dt
        AddStyleToGrid(dgvDtPerolehanLinen)
        FormatGrid()
    End Sub

    Private Sub Load_perolehan_Linen()
        Dim kodeLinen As String
        kodeLinen = dgvDtPerolehanLinen.SelectedRows(0).DataBoundItem("linen")
        persediaanSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
        dt = persediaanSvr.LoadDataPerolehanLinen(kodeLinen)
        dgvDtPerolehanLinen.DataSource = dt
        AddStyleToGrid(dgvDtPerolehanLinen)
        FormatGrid2()

    End Sub
    Public Sub AddStyleToGrid(ByVal dgv As DataGridView)

        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
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

    Private Sub FormatGrid()
        dgvDtPerolehanLinen.Columns("No").HeaderText = "No"
        dgvDtPerolehanLinen.Columns("No").Width = 50
        dgvDtPerolehanLinen.Columns("No").ReadOnly = True
        dgvDtPerolehanLinen.Columns("utilisasi_mesin_setrika_id").HeaderText = "id utilisasi mesin cuci"
        dgvDtPerolehanLinen.Columns("utilisasi_mesin_setrika_id").Width = 100
        dgvDtPerolehanLinen.Columns("utilisasi_mesin_setrika_id").Visible = False
        dgvDtPerolehanLinen.Columns("tanggal").HeaderText = "Tanggal"
        dgvDtPerolehanLinen.Columns("tanggal").Width = 100
        dgvDtPerolehanLinen.Columns("tanggal").ReadOnly = True
        dgvDtPerolehanLinen.Columns("tanggal").Visible = False
        dgvDtPerolehanLinen.Columns("linen").HeaderText = "id linen"
        dgvDtPerolehanLinen.Columns("linen").Width = 100
        dgvDtPerolehanLinen.Columns("linen").Visible = False
        dgvDtPerolehanLinen.Columns("nama_linen").HeaderText = "Nama Linen"
        dgvDtPerolehanLinen.Columns("nama_linen").Width = 200
        dgvDtPerolehanLinen.Columns("nama_linen").ReadOnly = True
        dgvDtPerolehanLinen.Columns("jml_rusak").HeaderText = "Jml Rusak"
        dgvDtPerolehanLinen.Columns("jml_rusak").Width = 100
        dgvDtPerolehanLinen.Columns("jml_rusak").ReadOnly = True
        dgvDtPerolehanLinen.Columns("jml_jahit").HeaderText = "Di Jahit"
        dgvDtPerolehanLinen.Columns("jml_jahit").Width = 100
        dgvDtPerolehanLinen.Columns("jml_afkir").HeaderText = "Di Afkir"
        dgvDtPerolehanLinen.Columns("jml_afkir").Width = 100
    End Sub

    Private Sub FormatGrid2()
        dgvDtPerolehanLinen.Columns("No").HeaderText = "No"
        dgvDtPerolehanLinen.Columns("No").Width = 50
        dgvDtPerolehanLinen.Columns("No").ReadOnly = True
        dgvDtPerolehanLinen.Columns("nama_linen_rusak").HeaderText = "Nama Linen Rusak"
        dgvDtPerolehanLinen.Columns("nama_linen_rusak").Width = 200
        dgvDtPerolehanLinen.Columns("nama_linen_rusak").Visible = True
        dgvDtPerolehanLinen.Columns("thn_perolehan").HeaderText = "Tahun Perolehan"
        dgvDtPerolehanLinen.Columns("thn_perolehan").Width = 150
        dgvDtPerolehanLinen.Columns("thn_perolehan").ReadOnly = True
        dgvDtPerolehanLinen.Columns("jml_linen").HeaderText = "Jumlah Linen"
        dgvDtPerolehanLinen.Columns("jml_linen").Width = 150
        dgvDtPerolehanLinen.Columns("jml_linen").ReadOnly = True
        dgvDtPerolehanLinen.Columns("keterangan").HeaderText = "Keterangan"
        dgvDtPerolehanLinen.Columns("keterangan").Width = 200
        dgvDtPerolehanLinen.Columns("keterangan").ReadOnly = True

    End Sub

    Private Sub dgvDtPerolehanLinen_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDtPerolehanLinen.CellDoubleClick
        Load_perolehan_Linen()
        ToolStrip2.Visible = False
        Label3.Visible = True

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Dim uc As New ModLinenKeluar
        Dim tglFr As Date = header.tgl_awal
        Dim tglTo As Date = header.tgl_akhir
        uc.DateTimePicker1.Value = tglFr
        uc.DateTimePicker2.Value = tglTo
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub
End Class

