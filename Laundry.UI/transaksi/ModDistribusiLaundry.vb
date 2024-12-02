Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ModDistribusiLaundry

    Private distrSvr As IDistribusiService
    Dim dv As New DataView

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        AddHandler BrowseTemp.getTextBox.TextChanged, AddressOf txtFind_TextChanged        
        AddHandler BrowseTemp.getBtnNew.Click, AddressOf btnNew_Click
        AddHandler BrowseTemp.getBtnEdit.Click, AddressOf btnEdit_Click
    End Sub

    Private Sub ModInsertLinen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BrowseTemp.getTitle.Text = "Distribusi Laundry"
        Dim acl As SessionInfo.ACLUser = CType(Me.Tag, SessionInfo.ACLUser)        
        'BrowseTemp.getBtnEdit.Visible = False
        BrowseTemp.getBtnDelete.Visible = False
        BrowseTemp.getBtnNew.Text = "Proses"
        BrowseTemp.getBtnEdit.Text = "Histori"
        BrowseTemp.getBtnEdit.Enabled = acl.allowEdit        
        Me.generateTable()
    End Sub

    Private Sub generateTable()
        Dim tanggal As Date
        tanggal = Today
        'setup gridview supaya tidak dimainkan sembarangan
        BrowseTemp.getGridView.AllowAddNew = False
        BrowseTemp.getGridView.AllowDelete = False
        BrowseTemp.getGridView.AllowUpdate = False

        distrSvr = InProcFactory.CreateChannel(Of DistribusiService, IDistribusiService)()

        Dim headers() As String = {"No", "Id Order", "No Order", "Tgl Order", "Ruang", "Sub Ruang", "Status Order"}
        Dim lebar() As Integer = {30, 100, 100, 100, 100, 150, 150}

        dv.Table = distrSvr.getOrderHeader(Date.Now)
        BrowseTemp.getGridView.DataSource = dv
        BrowseTemp.getGridView().Splits(0).ExtendRightColumn = True
        UILibs.GridStyle.formatGrid(BrowseTemp.getGridView(), dv.Table, headers, lebar)

        InProcFactory.CloseChannel(distrSvr)

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("namaPegawai LIKE '%{0}%'", Me.BrowseTemp.getTextBox().Text)
        dv.RowFilter = str
    End Sub

    'proses distribusi
    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("idOrder").Text = "" Then
            MsgBox("Anda belum memilih data / Data masih kosong")
        Else
            If BrowseTemp.getGridView.Columns("statusOrder").Text = "Terdistribusi" Then
                MsgBox("Order sudah terdistribusi semua, pilih yang lain.")
            Else
                Dim uc As New UcDistribusiLondry
                Dim objHeaderOrder As New OrderHeader With {.headerId = BrowseTemp.getGridView.Columns("idOrder").Text,
                                                            .orderNo = BrowseTemp.getGridView.Columns("nomerOrder").Text,
                                                            .ruang = BrowseTemp.getGridView.Columns("ruang").Text,
                                                            .subRuang = BrowseTemp.getGridView.Columns("subRuang").Text,
                                                            .flag = 1}
                uc.header = objHeaderOrder

                UILibs.PageLink.goToPage(Me.Parent, uc, Me)
            End If
        End If
    End Sub

    'history distribusi
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("idOrder").Text = "" Then
            MsgBox("Anda belum memilih data / Data masih kosong")
        Else
            If BrowseTemp.getGridView.Columns("statusOrder").Text = "Belum didistribusikan" Then
                MsgBox("Order belum pernah didistribusikan, pilih yang lain.")
            Else
                Dim uc As New UcDistribusiLondry
                Dim objHeaderOrder As New OrderHeader With {.headerId = BrowseTemp.getGridView.Columns("idOrder").Text,
                                                            .orderNo = BrowseTemp.getGridView.Columns("nomerOrder").Text,
                                                            .ruang = BrowseTemp.getGridView.Columns("ruang").Text,
                                                            .subRuang = BrowseTemp.getGridView.Columns("subRuang").Text,
                                                            .flag = Nothing}
                uc.header = objHeaderOrder

                UILibs.PageLink.goToPage(Me.Parent, uc, Me)
            End If
        End If
    End Sub

    'Private Sub gv_click(ByVal sender As Object, ByVal e As MouseEventArgs)
    '    If e.Button = Windows.Forms.MouseButtons.Right Then
    '        BrowseTemp.getGridView().SetActiveCell(BrowseTemp.getGridView().RowContaining(e.Y), 0)
    '        Dim mnu As New ContextMenuStrip()
    '        Dim mnuItem1 As New ToolStripMenuItem("Edit", Nothing, AddressOf btnEdit_Click)
    '        Dim mnuItem2 As New ToolStripMenuItem("Delete", Nothing, AddressOf btnDelete_Click)

    '        If BrowseTemp.getBtnEdit.Enabled Then
    '            mnu.Items.AddRange(New ToolStripItem() {mnuItem1})
    '        End If
    '        If BrowseTemp.getBtnDelete.Enabled Then
    '            mnu.Items.AddRange(New ToolStripItem() {mnuItem2})
    '        End If

    '        Dim mypoint As Point = BrowseTemp.getGridView().PointToClient(Control.MousePosition)

    '        mnu.Show(BrowseTemp.getGridView(), mypoint.X, mypoint.Y)
    '    End If
    'End Sub

End Class
