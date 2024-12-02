Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
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

Public Class UCInputOrderLondry    
    Dim brtlinentotal As Decimal = 0
    Dim status As String
    Public headerId, idNow As Integer
    Public header As OrderHeader
    Public detail As OrderDetail
    Private orderSvr As IOrderService
    Dim dv As New DataView
    Dim dt As New DataTable
    Dim TambahLinen As FormTambahLinen
    Dim listOfProduct As List(Of OrderDetail) = New List(Of OrderDetail)()
    Dim listDeleteDetail As List(Of OrderDetail) = New List(Of OrderDetail)()
    Public Property _acl As SessionInfo.ACLUser

    'Public Property acl As SessionInfo.ACLUser
    '    Get
    '        If _acl Is Nothing Then
    '            Return CType(Me.Tag, SessionInfo.ACLUser)
    '        Else
    '            Return _acl
    '        End If
    '    End Get
    '    Set(ByVal value As SessionInfo.ACLUser)
    '        _acl = value
    '    End Set
    'End Property

    Public Sub New()        
        InitializeComponent()
        'AddHandler SaveEditTemp.btnSaveAndClose.Click, AddressOf saveClose
        'AddHandler SaveEditTemp.btnCancel.Click, AddressOf btnCancel_Click
        'AddHandler SaveEditTemp.btnSaveAndNew.Click, AddressOf btnSaveNew_Click
        'AddHandler SaveEditTemp.btnClear.Click, AddressOf btnClear_Click        
    End Sub

    Private Sub UCInputOrderLondry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load        
        dtpTgl.MaxDate = Today.AddYears(+10)
        dtpJam.MaxDate = Now.AddYears(+10)
        If header.headerId <> Nothing Then
            status = "edit"
            LabelJudul.Text = "Edit Order Binatu"
            txtNoOrder.Text = header.orderNo
            label_headerid.Text = header.headerId
            txtRuangan.Text = header.ruang
            txtSubRuang.Text = header.subRuang
            txtPetugas.Text = header.namaPegawai
            dtpTgl.Value = Date.ParseExact(header.tanggalstr, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            dtpJam.Value = Date.ParseExact(header.jamstr, "HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            txtPetugasLaundry.Text = ModSessi.fullName
            orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
            dt = orderSvr.getOrderDetail(header.headerId)
            dgvInputLinen.DataSource = dt
            dgvInputLinen.AllowUserToAddRows = False
            AddStyleToGrid(dgvInputLinen)
            FormatGrid()
            'menghitung berat total linen
            Dim i As Integer = dgvInputLinen.RowCount()
            For x As Integer = 0 To i - 1
                brtlinentotal = brtlinentotal + Convert.ToDecimal(dgvInputLinen.Rows(x).Cells(5).Value)
            Next
            txtBrtLinenTotal.Text = brtlinentotal
        Else
            status = "new"
            LabelJudul.Text = "Input Order Binatu"
            txtPetugasLaundry.Text = ModSessi.fullName
            dtpTgl.Value = Today
            dtpJam.Text = TimeOfDay
            AddStyleToGrid(dgvInputLinen)
            txtBrtLinenTotal.Text = brtlinentotal
        End If
        
    End Sub

    Private Sub FormatGrid()
        dgvInputLinen.Columns("linenId").HeaderText = "ID Linen"
        dgvInputLinen.Columns("linenId").Width = 0
        dgvInputLinen.Columns("linenId").Visible = False
        dgvInputLinen.Columns("linenNama").HeaderText = "Nama Linen"
        dgvInputLinen.Columns("linenNama").Width = 100
        dgvInputLinen.Columns("jmlLinenNon").HeaderText = "Jumlah Non Infeksius"
        dgvInputLinen.Columns("jmlLinenNon").Width = 200
        dgvInputLinen.Columns("jmlLinenInf").HeaderText = "Jumlah Infeksius"
        dgvInputLinen.Columns("jmlLinenInf").Width = 200
        dgvInputLinen.Columns("jmlTotal").HeaderText = "Jumlah Total"
        dgvInputLinen.Columns("jmlTotal").Width = 200
        dgvInputLinen.Columns("beratLinen").HeaderText = "Berat Linen"
        dgvInputLinen.Columns("beratLinen").Width = 200
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
        If txtRuangan.Text = "" Then
            MsgBox("Ruangan Masih Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf txtPetugas.Text = "" Then
            MsgBox("Petugas belum diisi", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf dgvInputLinen.RowCount = 0 Then
            MsgBox("Item Linen belum diisi", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        End If
        Return result
    End Function

    Private Sub ClearData()
        txtRuangan.Text = ""
        txtPetugas.Text = ""

        dgvInputLinen.DataSource = Nothing
        dt.Columns.Clear()
        dt.Rows.Clear()
    End Sub

    Private Sub addItem(ByVal row As Object())
        dgvInputLinen.DataSource.Rows.Add(row)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnRuang.Click
        Me.orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"kode_ruang", "Kode Ruang", 80},
                              {"nama_ruang", "Nama Ruang", 250},
                              {"nama_instalasi", "Nama Instalasi", 250}}

        frmLookUp.keyField = "kode_ruang"
        frmLookUp.fields = {"nama_ruang"}


        frmLookUp.dt = Me.orderSvr.roomLookUp()

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtRuangan.Text = frmLookUp.returnRow("nama_ruang").ToString
            txtRuangan.Tag = frmLookUp.returnRow("kode_ruang").ToString
            txtSubRuang.Text = frmLookUp.returnRow("nama_instalasi").ToString
        End If
        InProcFactory.CloseChannel(Me.orderSvr)
    End Sub

    Private Sub ToolStripAdd_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripAdd.Click
        TambahLinen = New FormTambahLinen()
        TambahLinen.ShowDialog(Me)
        If TambahLinen.namalinen <> "" Then
            If dgvInputLinen.RowCount = 0 Then
                If status = "new" Then
                    dt.Columns.Add("ID Linen", GetType(Integer))
                    dt.Columns.Add("Nama Linen", GetType(String))
                    dt.Columns.Add("Jumlah Non Infeksius", GetType(String))
                    dt.Columns.Add("Jumlah Infeksius", GetType(Integer))
                    dt.Columns.Add("Jumlah Total", GetType(Integer))
                    dt.Columns.Add("Berat Linen", GetType(Decimal))
                    dt.Rows.Add(TambahLinen.idlinen, TambahLinen.namalinen, TambahLinen.jmllinenNon, TambahLinen.jmllinenInf, (TambahLinen.jmllinenNon + TambahLinen.jmllinenInf), TambahLinen.beratlinen)
                    dgvInputLinen.DataSource = dt
                    dgvInputLinen.Columns(0).Width = 0
                    dgvInputLinen.Columns(0).Visible = False
                    dgvInputLinen.Columns(2).Width = 200
                    dgvInputLinen.Columns(3).Width = 200
                    txtBrtLinenTotal.Text = Convert.ToDecimal(txtBrtLinenTotal.Text) + Convert.ToDecimal(TambahLinen.beratlinen) 'menambah berat total linen
                Else
                    addItem(New Object() {TambahLinen.idlinen, TambahLinen.namalinen, TambahLinen.jmllinenNon, TambahLinen.jmllinenInf, (TambahLinen.jmllinenNon + TambahLinen.jmllinenInf), TambahLinen.beratlinen})
                    txtBrtLinenTotal.Text = Convert.ToDecimal(txtBrtLinenTotal.Text) + Convert.ToDecimal(TambahLinen.beratlinen) 'menambah berat total linen
                End If
            Else
                addItem(New Object() {TambahLinen.idlinen, TambahLinen.namalinen, TambahLinen.jmllinenNon, TambahLinen.jmllinenInf, (TambahLinen.jmllinenNon + TambahLinen.jmllinenInf), TambahLinen.beratlinen})
                txtBrtLinenTotal.Text = Convert.ToDecimal(txtBrtLinenTotal.Text) + Convert.ToDecimal(TambahLinen.beratlinen) 'menambah berat total linen
            End If
        End If

    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click        
        If Me.ValidateForm Then
            If MsgBox("Anda akan memproses order Binatu?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then

                If status = "edit" Then
                    Dim headermdl As New OrderHeader
                    Me.orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
                    headermdl.headerId = label_headerid.Text
                    headermdl.ruang = Me.orderSvr.AmbilIdRuang(txtRuangan.Text)
                    headermdl.subRuang = txtSubRuang.Text
                    headermdl.namaPegawai = txtPetugas.Text
                    headermdl.pegawaiLaundy = txtPetugasLaundry.Text
                    Me.orderSvr.EditHeader(headermdl)
                    headerId = label_headerid.Text

                    For Each r As DataGridViewRow In dgvInputLinen.Rows
                        If IsDBNull(r.Cells(6).Value) Then                  'kolom id detail null = inputan baru
                            Dim detailmdl As New OrderDetail
                            detailmdl.headerId = headerId
                            detailmdl.linen = r.Cells(0).Value
                            detailmdl.qtyNon = r.Cells(2).Value
                            detailmdl.qtyInf = r.Cells(3).Value
                            detailmdl.berat = r.Cells(5).Value
                            detailmdl.flag = "1"
                            listOfProduct.Add(detailmdl)

                        End If
                    Next
                    Me.orderSvr.AddOrder(listOfProduct)
                    Me.orderSvr.deleteOrderDetail(listDeleteDetail) 'delete detail order (flag =4)

                    'untuk cetak kitir
                    Dim kitir As New FormKitirOrder
                    Dim objOrderHeader As New OrderHeader With {.headerId = label_headerid.Text,
                                                                .orderNo = header.orderNo,
                                                                .ruang = txtRuangan.Text,
                                                                .subRuang = txtSubRuang.Text,
                                                                .namaPegawai = txtPetugas.Text,
                                                                .pegawaiLaundy = txtPetugasLaundry.Text,
                                                                .tanggalstr = Convert.ToString(dtpTgl.Text),
                                                                .jamstr = Convert.ToString(dtpJam.Text)}
                    kitir.header = objOrderHeader
                    kitir.ShowDialog(Me)
                Else
                    Dim headermdl As New OrderHeader
                    Me.orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
                    headermdl.orderNo = Me.orderSvr.AmbilNomerOrder()
                    headermdl.ruang = CInt(txtRuangan.Tag)
                    headermdl.subRuang = txtSubRuang.Text
                    headermdl.namaPegawai = txtPetugas.Text
                    headermdl.pegawaiLaundy = txtPetugasLaundry.Text
                    headermdl.tanggal = DateTime.Parse(dtpTgl.Value).ToString("yyyy/M/dd")
                    headermdl.jam = dtpJam.Value.TimeOfDay
                    headermdl.flag = "1"
                    Me.orderSvr.AddHeader(headermdl)
                    Me.orderSvr.IncrementNomerOrder()
                    headerId = Me.orderSvr.AmbilHeaderId()

                    For Each r As DataGridViewRow In dgvInputLinen.Rows
                        Dim detailmdl As New OrderDetail
                        detailmdl.headerId = headerId
                        detailmdl.linen = r.Cells(0).Value
                        detailmdl.qtyNon = r.Cells(2).Value
                        detailmdl.qtyInf = r.Cells(3).Value
                        detailmdl.berat = r.Cells(5).Value
                        detailmdl.flag = "1"
                        listOfProduct.Add(detailmdl)
                    Next
                    orderSvr.AddOrder(listOfProduct)

                    'untuk cetak kitir
                    Dim kitir As New FormKitirOrder
                    Dim objOrderHeader As New OrderHeader With {.headerId = headerId,
                                                                .orderNo = headermdl.orderNo,
                                                                .ruang = txtRuangan.Text,
                                                                .subRuang = txtSubRuang.Text,
                                                                .namaPegawai = txtPetugas.Text,
                                                                .pegawaiLaundy = txtPetugasLaundry.Text,
                                                                .tanggalstr = dtpTgl.Text,
                                                                .jamstr = dtpJam.Text}
                    kitir.header = objOrderHeader
                    kitir.ShowDialog(Me)
                End If

                InProcFactory.CloseChannel(orderSvr)
                listOfProduct.Clear()
                Dim uc As New ModInputOrderLaundryNew
                UILibs.PageLink.goToPage(Me.Parent, uc, Me)
            End If
        End If
    End Sub

    Private Sub ToolStripDelete_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripDelete.Click
        If dgvInputLinen.SelectedRows.Count > 0 Then
            If MsgBox("List order akan dihapus ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                If status = "edit" Then
                    If IsDBNull(dgvInputLinen.CurrentRow.Cells(4).Value) Then 'jika id detail kosong (list hasil dari add baru)
                        MsgBox("Data " & dgvInputLinen.SelectedCells(1).Value & " berhasil dihapus dari list")
                        txtBrtLinenTotal.Text = Convert.ToDecimal(txtBrtLinenTotal.Text) - Convert.ToDecimal(dgvInputLinen.CurrentRow.Cells(5).Value) 'mengurangi berat total linen
                        dgvInputLinen.Rows.RemoveAt(dgvInputLinen.CurrentRow.Index)
                    Else 'jika id detail tidak kosong (list hasil dari load data)
                        Dim orderdetail As New OrderDetail
                        'kolekting untuk hapus/cancel/update flag detail order
                        'orderdetail.detailId = dgvInputLinen.SelectedCells(4).Value
                        orderdetail.detailId = dgvInputLinen.SelectedCells(6).Value
                        orderdetail.flag = "4"
                        listDeleteDetail.Add(orderdetail)
                        MsgBox("Data " & dgvInputLinen.SelectedCells(1).Value & " berhasil dihapus")
                        txtBrtLinenTotal.Text = Convert.ToDecimal(txtBrtLinenTotal.Text) - Convert.ToDecimal(dgvInputLinen.CurrentRow.Cells(5).Value) 'mengurangi berat total linen
                        dgvInputLinen.Rows.RemoveAt(dgvInputLinen.CurrentRow.Index)
                    End If
                Else
                    MsgBox("Data " & dgvInputLinen.SelectedCells(1).Value & " berhasil dihapus")
                    txtBrtLinenTotal.Text = Convert.ToDecimal(txtBrtLinenTotal.Text) - Convert.ToDecimal(dgvInputLinen.CurrentRow.Cells(5).Value) 'mengurangi berat total linen
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
        Dim uc As New ModInputOrderLaundryNew
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

End Class
