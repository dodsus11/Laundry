Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class UcDetailDataLinenRusak

    Public transOutId As Integer
    Public header As TransOut
    Public detail As TransOutDetail
    Private persediaanSvr As ILinenService
    Private utilmesinsetrikaSvr As IUtilmesinSetrikaService
    Dim dv As New DataView
    Dim dt As New DataTable
    Dim dtLinenKeluar As New TransOut

    Private Sub UcDetailDataLinenRusak_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        persediaanSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
        Dim tgl As Date
        tgl = header.tgl
        dt = persediaanSvr.LoadDetailDataLinenRusakbyTanggal(tgl)
        dgvDtLinenRusak.DataSource = dt
        AddStyleToGrid(dgvDtLinenRusak)
        FormatGrid()
    End Sub

    Private Sub btnPetugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPetugas.Click
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
    Private Sub FormatGrid()
        dgvDtLinenRusak.Columns("No").HeaderText = "No"
        dgvDtLinenRusak.Columns("No").Width = 50
        dgvDtLinenRusak.Columns("No").ReadOnly = True
        dgvDtLinenRusak.Columns("utilisasi_mesin_setrika_id").HeaderText = "id utilisasi mesin cuci"
        dgvDtLinenRusak.Columns("utilisasi_mesin_setrika_id").Width = 100
        dgvDtLinenRusak.Columns("utilisasi_mesin_setrika_id").Visible = False
        dgvDtLinenRusak.Columns("tanggal").HeaderText = "Tanggal"
        dgvDtLinenRusak.Columns("tanggal").Width = 100
        dgvDtLinenRusak.Columns("tanggal").ReadOnly = True
        dgvDtLinenRusak.Columns("tanggal").Visible = False
        dgvDtLinenRusak.Columns("linen").HeaderText = "id linen"
        dgvDtLinenRusak.Columns("linen").Width = 100
        dgvDtLinenRusak.Columns("linen").Visible = False
        dgvDtLinenRusak.Columns("nama_linen").HeaderText = "Nama Linen"
        dgvDtLinenRusak.Columns("nama_linen").Width = 200
        dgvDtLinenRusak.Columns("nama_linen").ReadOnly = True
        dgvDtLinenRusak.Columns("jml_rusak").HeaderText = "Jml Rusak"
        dgvDtLinenRusak.Columns("jml_rusak").Width = 100
        dgvDtLinenRusak.Columns("jml_rusak").ReadOnly = True
        dgvDtLinenRusak.Columns("jml_jahit").HeaderText = "Di Jahit"
        dgvDtLinenRusak.Columns("jml_jahit").Width = 100
        dgvDtLinenRusak.Columns("jml_afkir").HeaderText = "Di Afkir"
        dgvDtLinenRusak.Columns("jml_afkir").Width = 100
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

    
    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        
        Try
            For Each r As DataGridViewRow In dgvDtLinenRusak.Rows
                'validasi jumlah
                If CInt(r.Cells("jml_jahit").Value) + CInt(r.Cells("jml_afkir").Value) > CInt(r.Cells("jml_rusak").Value) Then
                    MessageBox.Show("Jumlah jahit dan afkir melebihi jumlah rusak!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    Dim kategori As String = ""
                    Dim keterangan As String = ""
                    dtLinenKeluar.tglTO = Date.Now
                    dtLinenKeluar.kategoriTO = kategori
                    dtLinenKeluar.ketTO = keterangan
                    dtLinenKeluar.entryByTO = txtPetugas.Text.ToString
                    dtLinenKeluar.entryDateTO = DateTime.Now
                    dtLinenKeluar.entryJamTO = dtpJam.Value.TimeOfDay
                    dtLinenKeluar.kode_linen = r.Cells("linen").Value
                    dtLinenKeluar.jmlJahit = r.Cells("jml_jahit").Value
                    dtLinenKeluar.jmlAfkir = r.Cells("jml_afkir").Value
                    dtLinenKeluar.tgl = r.Cells("tanggal").Value
                    'proses insert di table 
                    persediaanSvr.insertLinenKeluar(dtLinenKeluar)
                End If
            Next

        Catch ex As Exception

        End Try
        MsgBox("Data Linen Berhasil Di Tambahkan ")

        Dim uc As New ModLinenKeluar
        Dim tglFr As Date = header.tgl_awal
        Dim tglTo As Date = header.tgl_akhir
        uc.DateTimePicker1.Value = tglFr
        uc.DateTimePicker2.Value = tglTo
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Dim uc As New ModLinenKeluar
        Dim tglFr As Date = header.tgl_awal
        Dim tglTo As Date = header.tgl_akhir
        uc.DateTimePicker1.Value = tglFr
        uc.DateTimePicker2.Value = tglTo
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    'validasi inputan data gridview harus berupa angka 
    Private Sub dgvDtLinenRusak_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvDtLinenRusak.CellValidating
        Dim column As DataGridViewColumn = dgvDtLinenRusak.Columns(e.ColumnIndex)
        ' Tentukan kolom mana yang ingin Anda validasi (misalnya hanya kolom tertentu yang hanya boleh angka)
        If column.Name = "jml_jahit" Or column.Name = "jml_afkir" Then
            ' Cek apakah input hanya berisi angka
            If Not IsNumeric(e.FormattedValue.ToString()) Then
                ' Jika bukan angka, batalkan perubahan dan tampilkan pesan kesalahan
                e.Cancel = True
                MessageBox.Show("Input harus berupa angka.")
            End If
        End If
    End Sub
End Class
