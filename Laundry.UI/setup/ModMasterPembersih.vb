Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ModMasterPembersih

    Private pembersihSvr As IPembersihService
    Dim dv As New DataView

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        AddHandler BrowseTemp.getTextBox.TextChanged, AddressOf txtFind_TextChanged
        AddHandler BrowseTemp.getBtnNew.Click, AddressOf btnNew_Click
        AddHandler BrowseTemp.getBtnEdit.Click, AddressOf btnEdit_Click
        AddHandler BrowseTemp.getBtnDelete.Click, AddressOf btnDelete_Click
        AddHandler BrowseTemp.getGridView.MouseClick, AddressOf gv_click
    End Sub

    Private Sub ModInsertLinen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BrowseTemp.getTitle.Text = "Setup Bahan Pembersih"
        Dim acl As SessionInfo.ACLUser = CType(Me.Tag, SessionInfo.ACLUser)
        BrowseTemp.getBtnNew.Enabled = acl.allowSave
        BrowseTemp.getBtnEdit.Enabled = acl.allowEdit
        BrowseTemp.getBtnDelete.Enabled = acl.allowDelete
        Me.generateTable()
    End Sub

    Private Sub generateTable()

        'setup gridview supaya tidak dimainkan sembarangan
        BrowseTemp.getGridView.AllowAddNew = False
        BrowseTemp.getGridView.AllowDelete = False
        BrowseTemp.getGridView.AllowUpdate = False

        pembersihSvr = InProcFactory.CreateChannel(Of PembersihService, IPembersihService)()

        Dim headers() As String = {"No", "Id", "Kode", "Nama Pembersih", "Penggunaan utk infeksius (cc/kg)", "Penggunaan utk noninfeksius (cc/kg)"}
        Dim lebar() As Integer = {50, 50, 150, 200, 300, 300}

        dv.Table = pembersihSvr.getMasterPembersih()
        BrowseTemp.getGridView.DataSource = dv
        BrowseTemp.getGridView().Splits(0).ExtendRightColumn = True
        UILibs.GridStyle.formatGrid(BrowseTemp.getGridView(), dv.Table, headers, lebar)

        InProcFactory.CloseChannel(pembersihSvr)

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("nama_bahan_pembersih LIKE '%{0}%'", Me.BrowseTemp.getTextBox().Text)
        dv.RowFilter = str
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New UcInsertPembersih
        Dim objPembersih As New Pembersih With {.kode_bahan_pembersih = "", .nama_bahan_pembersih = "", .vol = Nothing, .linen_infeksius = Nothing, .linen_noninfeksius = Nothing, .flag_bahan_pembersih = Nothing}
        uc.pembersih = objPembersih
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("idPembersih").Text = "" Then
            MsgBox("Anda belum memilih data / Data masih kosong")
        Else
            Dim uc As New UcInsertPembersih
            Dim vol1() As String = Split(BrowseTemp.getGridView.Columns("utkInfeksius").Text, "/")
            Dim vol2() As String = Split(BrowseTemp.getGridView.Columns("utkNoninfeksius").Text, "/")
            Dim objPembersih As New Pembersih With {.id_bahan_pembersih = BrowseTemp.getGridView.Columns("idPembersih").Text,
                                                    .kode_bahan_pembersih = BrowseTemp.getGridView.Columns("kode_bahan_pembersih").Text,
                                                    .nama_bahan_pembersih = BrowseTemp.getGridView.Columns("nama_bahan_pembersih").Text,
                                                    .vol = vol1(0),
                                                    .linen_infeksius_str = vol1(1),
                                                    .linen_noninfeksius_str = vol2(1)
                                            }
            uc.pembersih = objPembersih

            UILibs.PageLink.goToPage(Me.Parent, uc, Me)
        End If        
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("idPembersih").Text = "" Then
            MsgBox("Anda belum memilih data")
        Else
            If MsgBox("Anda ingin menghapus data " & BrowseTemp.getGridView.Columns("kode_bahan_pembersih").Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Dim tempData As String = BrowseTemp.getGridView.Columns("kode_bahan_pembersih").Text
                Try
                    pembersihSvr = InProcFactory.CreateChannel(Of PembersihService, IPembersihService)()
                    pembersihSvr.deletePembersih(New Pembersih With {.id_bahan_pembersih = BrowseTemp.getGridView.Columns("idPembersih").Text})

                    MsgBox("Data " & tempData & " berhasil dihapus")
                    Me.generateTable()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                InProcFactory.CloseChannel(pembersihSvr)
            End If
        End If
    End Sub

    Private Sub gv_click(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            BrowseTemp.getGridView().SetActiveCell(BrowseTemp.getGridView().RowContaining(e.Y), 0)
            Dim mnu As New ContextMenuStrip()
            Dim mnuItem1 As New ToolStripMenuItem("Edit", Nothing, AddressOf btnEdit_Click)
            Dim mnuItem2 As New ToolStripMenuItem("Delete", Nothing, AddressOf btnDelete_Click)

            If BrowseTemp.getBtnEdit.Enabled Then
                mnu.Items.AddRange(New ToolStripItem() {mnuItem1})
            End If
            If BrowseTemp.getBtnDelete.Enabled Then
                mnu.Items.AddRange(New ToolStripItem() {mnuItem2})
            End If

            Dim mypoint As Point = BrowseTemp.getGridView().PointToClient(Control.MousePosition)

            mnu.Show(BrowseTemp.getGridView(), mypoint.X, mypoint.Y)
        End If
    End Sub


End Class
