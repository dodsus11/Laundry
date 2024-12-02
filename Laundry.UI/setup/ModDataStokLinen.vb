Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Imports Laundry.UI.Utility

Public Class ModDataStokLinen
    Private linenSvr As ILinenService
    Dim dv As New DataView

    Private Sub ModLinenTransOutNew_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Loaddata()
    End Sub

    Private Sub Loaddata()
        Try
            linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
            Dim dt As New DataTable

            dt = linenSvr.DataStokLinenGudang()
            dv.Table = dt
            dgv.DataSource = dv

            Dim col As New List(Of GridColumnModel)
            col.Add(GH.AddModelGridColumn("Kode Linen", 90))
            col.Add(GH.AddModelGridColumn("Nama Linen", 200))
            col.Add(GH.AddModelGridColumn("Jumlah Linen", 100))
            col.Add(GH.AddModelGridColumn("Stok Gudang", 100))
            col.Add(GH.AddModelGridColumn("Linen Keluar", 100))
            GH.FormatGrid(dgv, dt, col, True, True, False, True)
            InProcFactory.CloseChannel(linenSvr)

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub tsTxtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsTxtSearch.TextChanged
        Dim str As String = CType(sender, ToolStripTextBox).Text
        dv.RowFilter = String.Format("nama_linen LIKE '%{0}%' or kode_linen LIKE '%{0}%' or jumlah_linen LIKE '%{0}%' or stok_gudang LIKE '%{0}%' or linen_keluar LIKE '%{0}%'", str)
    End Sub

    'Private Sub tsNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsNew.Click
    '    Dim uc As New UCLinenTransOut
    '    Dim objTransOut As New TransOut With {.idTransOut = Nothing, .tglTO = Nothing, .kategoriTO = "", .ketTO = "", .entryByTO = ""}
    '    uc.header = objTransOut
    '    UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    'End Sub

    'Private Sub tsDetail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsDetail.Click
    '    If dgv.SelectedRows.Count = 0 Then
    '        MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
    '        Exit Sub
    '    End If

    '    Dim uc As New UCLinenTransOut
    '    Dim objHeaderTransOut As New TransOut With {.idTransOut = dgv.SelectedRows(0).DataBoundItem(0),
    '                                             .tglTO = dgv.SelectedRows(0).DataBoundItem(1),
    '                                             .kategoriTO = dgv.SelectedRows(0).DataBoundItem(2),
    '                                             .ketTO = dgv.SelectedRows(0).DataBoundItem(3),
    '                                             .entryByTO = dgv.SelectedRows(0).DataBoundItem(4)
    '                                             }
    '    uc.header = objHeaderTransOut
    '    UILibs.PageLink.goToPage(Me.Parent, uc, Me)

    'End Sub

End Class
