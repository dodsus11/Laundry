Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ModMasterMesin

    Private mesinSvr As IMesinService
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
        BrowseTemp.getTitle.Text = "Setup Mesin Laundry"
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

        mesinSvr = InProcFactory.CreateChannel(Of MesinService, IMesinService)()

        Dim headers() As String = {"No", "Id Mesin", "Kode Mesin", "Nama Mesin", "Kapasitas (Kg/Lembar) ", "Maks Load/hari", "Jenis Mesin", "Status"}
        Dim lebar() As Integer = {50, 100, 100, 150, 160, 150, 150, 100}

        dv.Table = mesinSvr.getMasterMesin()
        BrowseTemp.getGridView.DataSource = dv
        BrowseTemp.getGridView().Splits(0).ExtendRightColumn = True
        UILibs.GridStyle.formatGrid(BrowseTemp.getGridView(), dv.Table, headers, lebar)

        InProcFactory.CloseChannel(mesinSvr)

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("nama_mesin LIKE '%{0}%'", Me.BrowseTemp.getTextBox().Text)
        dv.RowFilter = str
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New UcInsertMesin
        Dim objMesin As New Mesin With {.id_mesin = Nothing, .kode_mesin = "", .nama_mesin = "", .kapasitas_mesin = Nothing, .maxload_mesin = Nothing, .jenis_mesin = "", .flag_mesin = ""}
        uc.mesin = objMesin
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("id_mesin").Text = "" Then
            MsgBox("Anda belum memilih data / Data masih kosong")
        Else
            Dim uc As New UcInsertMesin
            Dim objMesin As New Mesin With {.id_mesin = BrowseTemp.getGridView.Columns("id_mesin").Text,
                                            .kode_mesin = BrowseTemp.getGridView.Columns("kode_mesin").Text,
                                            .nama_mesin = BrowseTemp.getGridView.Columns("nama_mesin").Text,
                                            .kapasitas_mesin = BrowseTemp.getGridView.Columns("kapasitas_mesin").Text,
                                            .maxload_mesin = BrowseTemp.getGridView.Columns("maxload_mesin").Text,
                                            .jenis_mesin = BrowseTemp.getGridView.Columns("jenis_mesin").Text,
                                            .flag_mesin = BrowseTemp.getGridView.Columns("status_mesin").Text}
            uc.mesin = objMesin            
            UILibs.PageLink.goToPage(Me.Parent, uc, Me)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("id_mesin").Text = "" Then
            MsgBox("Anda belum memilih data")
        Else
            If MsgBox("Anda ingin menghapus data " & BrowseTemp.getGridView.Columns("id_mesin").Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Dim tempData As String = BrowseTemp.getGridView.Columns("id_mesin").Text
                Try
                    mesinSvr = InProcFactory.CreateChannel(Of MesinService, IMesinService)()
                    mesinSvr.deleteMesin(New Mesin With {.id_mesin = BrowseTemp.getGridView.Columns("id_mesin").Text})

                    MsgBox("Data " & tempData & " berhasil dihapus")
                    Me.generateTable()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                InProcFactory.CloseChannel(mesinSvr)
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
