Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ModMasterPembersih2

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
        BrowseTemp.getTitle.Text = "Setup Dosis Bahan Pembersih"
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

        Dim headers() As String = {"No", "Id", "Jenis Cucian", "Berat Cucian (kg)", "Alkali (ml)", "Detergent (ml)", "Oxyblech (ml)", "Softener (ml)", "Penetral (ml)"}
        Dim lebar() As Integer = {50, 0, 150, 125, 125, 125, 125, 125, 125}

        dv.Table = pembersihSvr.getMasterDosisPembersih()
        BrowseTemp.getGridView.DataSource = dv
        BrowseTemp.getGridView().Splits(0).ExtendRightColumn = True
        UILibs.GridStyle.formatGrid(BrowseTemp.getGridView(), dv.Table, headers, lebar)

        InProcFactory.CloseChannel(pembersihSvr)

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("jenis_cucian LIKE '%{0}%'", Me.BrowseTemp.getTextBox().Text)
        dv.RowFilter = str
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New UcInsertPembersih2
        Dim objPembersih As New DosisPembersih With {.id = Nothing,
                                                     .jenis_ident_kotoran = "",
                                                     .berat_linen = Nothing,
                                                     .jml_alkaline = Nothing,
                                                     .jml_detergent = Nothing,
                                                     .jml_oxybleach = Nothing,
                                                     .jml_softener = Nothing,
                                                     .jml_penetral = Nothing}
        uc.pembersih = objPembersih
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("id").Text = "" Then
            MsgBox("Anda belum memilih data / Data masih kosong")
        Else
            Dim uc As New UcInsertPembersih2
            'Dim vol1() As String = Split(BrowseTemp.getGridView.Columns("utkInfeksius").Text, "/")
            'Dim vol2() As String = Split(BrowseTemp.getGridView.Columns("utkNoninfeksius").Text, "/")
            Dim objPembersih As New DosisPembersih With {.id = BrowseTemp.getGridView.Columns("id").Text,
                                                         .jenis_ident_kotoran = BrowseTemp.getGridView.Columns("jenis_cucian").Text,
                                                         .berat_linen = BrowseTemp.getGridView.Columns("berat_cucian").Text,
                                                         .jml_alkaline  = BrowseTemp.getGridView.Columns("alkaline").Text,
                                                         .jml_detergent  = BrowseTemp.getGridView.Columns("detergent").Text,
                                                         .jml_oxybleach  = BrowseTemp.getGridView.Columns("oxybleach").Text,
                                                         .jml_softener  = BrowseTemp.getGridView.Columns("softener").Text,
                                                         .jml_penetral  = BrowseTemp.getGridView.Columns("penetral").Text}
            uc.pembersih = objPembersih

            UILibs.PageLink.goToPage(Me.Parent, uc, Me)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("id").Text = "" Then
            MsgBox("Anda belum memilih data")
        Else
            If MsgBox("Anda ingin nonaktif data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then                
                Try
                    pembersihSvr = InProcFactory.CreateChannel(Of PembersihService, IPembersihService)()
                    pembersihSvr.nonaktifDosisPembersih(New DosisPembersih With {.id = BrowseTemp.getGridView.Columns("id").Text})

                    MsgBox("Data berhasil dinonaktifkan")
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
