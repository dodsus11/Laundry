Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Imports SessionInfo
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.Data.SqlClient
Imports Laundry.Service.service
Imports Laundry.Service.model
Imports ClientLibs
Imports Laundry.UI.Utility

Public Class UcAddInventarisRuangan
    Dim status As String
    Dim dv As New DataView
    Dim dt As New DataTable
    Dim TambahInv As FormTambahInv
    Private InnventarisSvr As IInventarisService
    Private InvSvc As IInventarisService
    Public Property _acl As SessionInfo.ACLUser
    Public order As OrderInventaris
    Dim HapusDtInv As New OrderInventaris
    Dim data As New OrderInventaris
    Dim listOfProductInf As List(Of OrderInventaris) = New List(Of OrderInventaris)()
    Dim listOfProductInfDel As List(Of OrderInventaris) = New List(Of OrderInventaris)()


    Public Sub New()
        InitializeComponent()

    End Sub


    Private Sub UcAddInventarisRuangan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If order.noInv <> Nothing Then
            status = "edit"
            LbJudul.Text = "Edit Inventarisasi Ruangan "
            txtInstalasi.Text = order.Inst
            txtRuang.Text = order.ruang
            txtJmlTT.Text = order.jmlTT.ToString
            txtJmlPAR.Text = order.jmlPAR.ToString
            txtJmlKM.Text = order.jmlKM.ToString
            txtPetugas.Text = ModSessi.fullName
            dtptanggal.Value = Date.Now()
            LbInventaris.Visible = True
            Label1.Visible = True
            Label1.Text = order.noInv
            '==========================================
            'menampilkan isi item dari data inventaris
            Dim noInv As String = order.noInv
            LoadAndDisplayData(noInv)

            AddStyleToGrid(dgvInventaris)
        Else
            status = "new"
            LbJudul.Text = "Setup Inventarisasi Ruangan "
            LbInventaris.Visible = False
            Label1.Visible = False
            txtPetugas.Text = ModSessi.fullName
            dtptanggal.Value = Today
            AddStyleToGrid(dgvInventaris)
        End If

    End Sub
    Private Sub LoadAndDisplayData(ByVal noInv As String)

        InvSvc = InProcFactory.CreateChannel(Of InventarisService, IInventarisService)()
        Dim dt As DataTable = InvSvc.LoadDetailINV(noInv)
        'dv.Table = dt
        dgvInventaris.DataSource = dt
        Dim col As New List(Of GridColumnModel) From {
                GH.AddModelGridColumn("ID", 0),
                GH.AddModelGridColumn("No INV", 0),
                GH.AddModelGridColumn("ID Linen", 0),
                GH.AddModelGridColumn("Nama Linen", 100),
                GH.AddModelGridColumn("Jml Disimpan", 100),
                GH.AddModelGridColumn("Jml Dipakai", 100),
                GH.AddModelGridColumn("Jml Dicucikan", 150),
                GH.AddModelGridColumn("Jml Kotor", 100),
                GH.AddModelGridColumn("Total Linen", 200)}

        GH.FormatGrid(dgvInventaris, dt, col, True, True, False, True)


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
        If txtRuang.Text = "" Then
            MsgBox("Ruangan Masih Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf txtPetugas.Text = "" Then
            MsgBox("Petugas belum diisi", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf dgvInventaris.RowCount = 0 Then
            MsgBox("Item Linen belum diisi", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        End If
        Return result
    End Function
    Private Sub ClearData()
        txtRuang.Text = ""
        txtPetugas.Text = ""

        dgvInventaris.DataSource = Nothing
        dt.Columns.Clear()
        dt.Rows.Clear()
    End Sub
    Private Sub addItem(ByVal row As Object())
        dgvInventaris.DataSource.Rows.Add(row)
    End Sub

    Private Sub btnRuang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRuang.Click
        Me.InnventarisSvr = InProcFactory.CreateChannel(Of InventarisService, IInventarisService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"kode_ruang", "Kode Ruang", 80},
                              {"nama_ruang", "Nama Ruang", 250},
                              {"nama_instalasi", "Nama Instalasi", 250}}
        '{"kode_Inst", "Kode Instalasi", 250}}

        frmLookUp.keyField = "kode_ruang"
        frmLookUp.fields = {"nama_ruang"}


        frmLookUp.dt = Me.InnventarisSvr.roomLookUp

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtRuang.Text = frmLookUp.returnRow("nama_ruang").ToString
            txtRuang.Tag = frmLookUp.returnRow("kode_ruang").ToString
            txtInstalasi.Text = frmLookUp.returnRow("nama_instalasi").ToString
            txtInstalasi.Tag = frmLookUp.returnRow("kode_Inst").ToString
        End If
        InProcFactory.CloseChannel(Me.InnventarisSvr)
    End Sub
    Private Sub ToolStripAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripAdd.Click
        TambahInv = New FormTambahInv With {.no_inv = order.noInv}
        TambahInv.ShowDialog(Me)
        If TambahInv.namalinen <> "" Then
            If dgvInventaris.RowCount = 0 Then
                If status = "new" Then
                    dt.Columns.Add("Id", GetType(Integer))
                    dt.Columns.Add("No INV", GetType(String))
                    dt.Columns.Add("ID Linen", GetType(Integer))
                    dt.Columns.Add("Nama Linen", GetType(String))
                    dt.Columns.Add("Jml Disimpan", GetType(Integer))
                    dt.Columns.Add("Jml Dipakai", GetType(Integer))
                    dt.Columns.Add("Jml Dicucikan", GetType(Integer))
                    dt.Columns.Add("Jml Kotor", GetType(Integer))
                    dt.Columns.Add("Total Linen", GetType(Integer))
                    dt.Rows.Add(TambahInv.id, TambahInv.no_inv, TambahInv.idlinen, TambahInv.namalinen, TambahInv.jmldisimpan,
                                TambahInv.jmldipakai, TambahInv.jmldicuci, TambahInv.jmlkotor, TambahInv.totallinen)

                    dgvInventaris.DataSource = dt
                    dgvInventaris.Columns(0).Width = 0
                    dgvInventaris.Columns(0).Visible = False
                    dgvInventaris.Columns(1).Width = 0
                    dgvInventaris.Columns(1).Visible = False
                    dgvInventaris.Columns(2).Width = 0
                    dgvInventaris.Columns(2).Visible = False
                    dgvInventaris.Columns(3).Width = 150
                    dgvInventaris.Columns(4).Width = 150
                    dgvInventaris.Columns(5).Width = 150
                    dgvInventaris.Columns(6).Width = 150
                    dgvInventaris.Columns(7).Width = 150
                    dgvInventaris.Columns(8).Width = 150

                Else
                    addItem(New Object() {TambahInv.id, TambahInv.no_inv, TambahInv.idlinen, TambahInv.namalinen, TambahInv.jmldisimpan,
                     TambahInv.jmldipakai, TambahInv.jmldicuci, TambahInv.jmlkotor, TambahInv.totallinen})

                    
                End If

            Else
                
                addItem(New Object() {TambahInv.id, TambahInv.no_inv, TambahInv.idlinen, TambahInv.namalinen, TambahInv.jmldisimpan,
                               TambahInv.jmldipakai, TambahInv.jmldicuci, TambahInv.jmlkotor,
                               TambahInv.totallinen})
            End If
        End If

    End Sub
    Private Sub ToolStripDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDelete.Click
        If dgvInventaris.SelectedRows.Count > 0 Then
            If MsgBox("List order akan dihapus ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                If status = "edit" Then
                    If (dgvInventaris.CurrentRow.Cells(0).Value) = 0 Then 'jika  kosong (list hasil dari add baru)
                        MsgBox("Data " & dgvInventaris.SelectedCells(3).Value & " berhasil dihapus dari list")

                        dgvInventaris.Rows.RemoveAt(dgvInventaris.CurrentRow.Index)
                    Else 'jika id detail tidak kosong (list hasil dari load data)

                        ''kolekting untuk hapus/cancel/update flag detail order
                        HapusDtInv.createDate = dtptanggal.Value
                        HapusDtInv.Petugas = SessionInfo.fullName
                        HapusDtInv.id = dgvInventaris.SelectedCells(0).Value
                        listOfProductInfDel.Add(HapusDtInv)
                        MsgBox("Data " & dgvInventaris.SelectedCells(3).Value & " berhasil dihapus")
                        dgvInventaris.Rows.RemoveAt(dgvInventaris.CurrentRow.Index)
                    End If
                Else
                    MsgBox("Data " & dgvInventaris.SelectedCells(3).Value & " berhasil dihapus")
                    dgvInventaris.Rows.RemoveAt(dgvInventaris.CurrentRow.Index)
                    If dgvInventaris.RowCount = 0 Then
                        dt.Columns.Clear()
                    End If
                End If
            End If
        Else
            MessageBox.Show("Silahkan pilih data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            If status = "edit" Then
                For Each r As DataGridViewRow In dgvInventaris.Rows
                    If (r.Cells(0).Value) = 0 Then   'kolom id null = inputan baru
                        data.noInv = order.noInv
                        data.tgl = dtptanggal.Value
                        data.ruang = Me.InvSvc.AmbilIdRuang(txtRuang.Text)
                        data.Inst = Me.InvSvc.AmbilIdInstalasi(txtInstalasi.Text)
                        data.jmlTT = CInt(txtJmlTT.Text)
                        data.jmlPAR = CInt(txtJmlPAR.Text)
                        data.jmlKM = CInt(txtJmlKM.Text)
                        data.Petugas = txtPetugas.Text.ToString
                        data.idlinen = r.Cells(2).Value
                        data.jmldisimpan = r.Cells(4).Value
                        data.jmldipakai = r.Cells(5).Value
                        data.jmldicucikan = r.Cells(6).Value
                        data.jmlkotor = r.Cells(7).Value
                        data.totalLinen = r.Cells(8).Value
                        data.createDate = order.tgl
                        data.createBy = txtPetugas.Text.ToString
                        listOfProductInf.Add(data)
                    End If
                   
                Next
                'insert data ke table 
                Me.InvSvc.InsertDataInventaris(listOfProductInf)
                'proses kolekting data utk remove data 

                'nonaktifkan data
                Me.InvSvc.NonAktif_data(listOfProductInfDel)
                MsgBox("Data Inventaris Berhasil Di Rubah ")

            Else
                'collecting data proses baru
                For Each r As DataGridViewRow In dgvInventaris.Rows
                    Dim data As New OrderInventaris
                    Me.InvSvc = InProcFactory.CreateChannel(Of InventarisService, IInventarisService)()

                    'format no inventaris 
                    Dim noInv As String = Me.InvSvc.AmbilNomerOrder()
                    Dim formattedNoINV As String = formatNoInventaris(noInv)

                    data.noInv = formattedNoINV
                    data.tgl = dtptanggal.Value
                    data.ruang = txtRuang.Tag
                    data.Inst = txtInstalasi.Tag
                    data.jmlTT = CInt(txtJmlTT.Text)
                    data.jmlPAR = CInt(txtJmlPAR.Text)
                    data.jmlKM = CInt(txtJmlKM.Text)
                    data.Petugas = txtPetugas.Text.ToString
                    data.idlinen = CInt(r.Cells("ID Linen").Value)
                    data.jmldisimpan = CInt(r.Cells("Jml Disimpan").Value)
                    data.jmldipakai = CInt(r.Cells("Jml Dipakai").Value)
                    data.jmldicucikan = CInt(r.Cells("Jml Dicucikan").Value)
                    data.jmlkotor = CInt(r.Cells("Jml Kotor").Value)
                    data.totalLinen = CInt(r.Cells("Total Linen").Value)
                    data.createDate = DateTime.Today
                    data.createBy = txtPetugas.Text.ToString
                    listOfProductInf.Add(data)
                Next
                'insert data ke table
                Me.InvSvc.InsertDataInventaris(listOfProductInf)
                'increment no inventaris di table 
                Me.InvSvc.IncrementNomerInventaris()
                MsgBox("Data Inventaris Berhasil Di Tambahkan ")
            End If
            InProcFactory.CloseChannel(InvSvc)
        Catch ex As Exception
        End Try
        Dim uc As New UcInventarisRuang
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub
    Private Function formatNoInventaris(ByVal invoice As String) As String
        ' Memisahkan prefix dan angka
        Dim prefix As String = invoice.Substring(0, 3) ' Mengambil 'INV'
        Dim numberPart As Integer = Integer.Parse(invoice.Substring(3)) ' Mengambil '1'
        ' Mengformat angka dengan 4 digit
        Dim formattedNumber As String = numberPart.ToString("D4") ' Mengformat menjadi 0001
        ' Menggabungkan prefix dan angka yang diformat
        Return prefix & formattedNumber
    End Function
    'validasi hanya menerima inputan angka
    '======================================
    Private Sub txtJmlTT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlTT.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtJmlPAR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlPAR.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtJmlKM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlKM.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    '======================================


    Private Sub btnBatal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Dim uc As New UcInventarisRuang
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub
End Class
