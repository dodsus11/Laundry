Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Imports Laundry.UI.Utility

Public Class ModLinenTransInNew
    Private linenSvr As ILinenService
    Dim dv As New DataView

    Private Sub ModLinenTransInNew_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Loaddata()
    End Sub

    Private Sub Loaddata()
        Try
            linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
            Dim dt As New DataTable

            dt = linenSvr.getItemMasuk()
            dv.Table = dt
            dgv.DataSource = dv

            Dim col As New List(Of GridColumnModel)
            col.Add(GH.AddModelGridColumn("No Transaksi", 90))
            col.Add(GH.AddModelGridColumn("Tgl Transaksi", 100))
            col.Add(GH.AddModelGridColumn("Keterangan", 300))
            col.Add(GH.AddModelGridColumn("Operator", 200))
            GH.FormatGrid(dgv, dt, col, True, True, False, True)
            InProcFactory.CloseChannel(linenSvr)

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub tsTxtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsTxtSearch.TextChanged
        Dim str As String = CType(sender, ToolStripTextBox).Text
        dv.RowFilter = String.Format("ket LIKE '%{0}%' or entry_by LIKE '%{0}%'or trans_in_tgl LIKE '%{0}%' or trans_in_id LIKE '%{0}%' ", str)
    End Sub

    Private Sub tsNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsNew.Click
        Dim uc As New UCLinenTransIn
        Dim objTransIn As New TransIn With {.idTransIn = Nothing, .tglTI = Nothing, .ketTI = "", .entryByTI = ""}
        uc.header = objTransIn
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub tsDetail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsDetail.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim uc As New UCLinenTransIn
        Dim objHeaderTransIn As New TransIn With {.idTransIn = dgv.SelectedRows(0).DataBoundItem("trans_in_id"),
                                                 .tglTI = dgv.SelectedRows(0).DataBoundItem("trans_in_tgl"),
                                                 .ketTI = dgv.SelectedRows(0).DataBoundItem("ket"),
                                                 .entryByTI = dgv.SelectedRows(0).DataBoundItem("entry_by")
                                                 }
        uc.header = objHeaderTransIn
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)

    End Sub

End Class
