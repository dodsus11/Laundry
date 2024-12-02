Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ModLinenTransOut

    Private linenSvr As ILinenService
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
        BrowseTemp.getTitle.Text = "Persediaan : Linen Keluar"
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

        linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()

        Dim headers() As String = {"No Trans", "Tgl Transaksi", "Kategori", "Keterangan", "User"}
        Dim lebar() As Integer = {100, 200, 300, 300, 200}

        dv.Table = linenSvr.getItemKeluar()
        BrowseTemp.getGridView.DataSource = dv
        BrowseTemp.getGridView().Splits(0).ExtendRightColumn = True
        UILibs.GridStyle.formatGrid(BrowseTemp.getGridView(), dv.Table, headers, lebar)

        InProcFactory.CloseChannel(linenSvr)

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("entry_by LIKE '%{0}%'", Me.BrowseTemp.getTextBox().Text)
        dv.RowFilter = str
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New UCLinenTransOut
        Dim objTransOut As New TransOut With {.idTransOut = Nothing, .tglTO = Nothing, .kategoriTO = "", .ketTO = "", .entryByTO = ""}
        uc.header = objTransOut
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("trans_out_id").Text = "" Then
            MsgBox("Anda belum memilih data / Data masih kosong")
        Else
            Dim uc As New UCLinenTransOut
            Dim objHeaderTransOut As New TransOut With {.idTransOut = BrowseTemp.getGridView.Columns("trans_out_id").Text,
                                                     .tglTO = BrowseTemp.getGridView.Columns("trans_out_tgl").Text,
                                                     .kategoriTO = BrowseTemp.getGridView.Columns("kategori").Text,
                                                     .ketTO = BrowseTemp.getGridView.Columns("ket").Text,
                                                     .entryByTO = BrowseTemp.getGridView.Columns("entry_by").Text
                                                     }
            uc.header = objHeaderTransOut
            UILibs.PageLink.goToPage(Me.Parent, uc, Me)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("trans_out_id").Text = "" Then
            MsgBox("Anda belum memilih data")
        Else
            Dim FormCancel As New FormCancelTrans
            Dim objHeaderTransOut As New TransaksiDelete With {.idTransaksi = BrowseTemp.getGridView.Columns("trans_out_id").Text, .jenisTransaksi = 2}
            FormCancel.header = objHeaderTransOut
            FormCancel.ShowDialog(Me)
            Me.generateTable()
        End If
    End Sub

    Private Sub gv_click(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            BrowseTemp.getGridView().SetActiveCell(BrowseTemp.getGridView().RowContaining(e.Y), 0)
            Dim mnu As New ContextMenuStrip()
            Dim mnuItem1 As New ToolStripMenuItem("Edit", Nothing, AddressOf btnEdit_Click)
            'Dim mnuItem2 As New ToolStripMenuItem("Delete", Nothing, AddressOf btnDelete_Click)

            If BrowseTemp.getBtnEdit.Enabled Then
                mnu.Items.AddRange(New ToolStripItem() {mnuItem1})
            End If
            'If BrowseTemp.getBtnDelete.Enabled Then
            '    mnu.Items.AddRange(New ToolStripItem() {mnuItem2})
            'End If

            Dim mypoint As Point = BrowseTemp.getGridView().PointToClient(Control.MousePosition)

            mnu.Show(BrowseTemp.getGridView(), mypoint.X, mypoint.Y)
        End If
    End Sub


End Class
