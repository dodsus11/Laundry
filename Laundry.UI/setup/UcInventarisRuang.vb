Imports Laundry.Service.service
Imports ClientLibs
Imports System.Windows.Forms
Imports System.Drawing
Imports Laundry.UI.Utility
Imports Laundry.Service.model
Public Class UcInventarisRuang
    Private invSvc As IInventarisService
    Dim dtUnit As DataTable
    Dim dv As New DataView
    Private header_inv As New OrderInventaris

    Private Sub LoadTree()

        Me.Cursor = Cursors.WaitCursor

        Try
            TreeView1.Nodes.Clear()
            Dim rootNode As TreeNode = CreateNode("ALL INSTALASI", 1, Color.FromArgb(22, 31, 111))
            TreeView1.Nodes.Add(rootNode)

            ' Populate all levels
            PopulateNodes(rootNode, dtUnit)

            ExpandAllNodes(rootNode)

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function CreateNode(ByVal text As String, ByVal tag As Object, ByVal color As Color) As TreeNode
        Dim node As New TreeNode()
        node.Text = text
        node.Tag = tag
        node.ForeColor = color
        Return node
    End Function

    Private Sub PopulateNodes(ByVal parentNode As TreeNode, ByVal dtUnit As DataTable)
        Dim dv As New DataView(dtUnit)      
        Dim dt As DataTable = dv.ToTable()

        For Each row As DataRow In dt.Rows
            Dim deptNode As TreeNode = CreateNode(row("nama_instalasi").ToString(), row("kode_inst").ToString(), Color.FromArgb(33, 64, 163))
            parentNode.Nodes.Add(deptNode)
        Next
    End Sub

    Private Sub UcInventarisRuang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.invSvc = InProcFactory.CreateChannel(Of InventarisService, IInventarisService)()
        
        dtUnit = Me.invSvc.InstLookUp
        InProcFactory.CloseChannel(Me.invSvc)
        LoadTree()
    End Sub
    Private Sub ExpandAllNodes(ByVal node As TreeNode)
        node.Expand()
        For Each childNode As TreeNode In node.Nodes
            ExpandAllNodes(childNode)
        Next
    End Sub


    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        tampil_data()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim uc As New UcAddInventarisRuangan
        Dim objHeaderInv As New OrderInventaris With {.ruang = "", .noInv = "", .jmlKM = Nothing, .jmlPAR = Nothing, .jmlTT = Nothing}
        uc.order = objHeaderInv
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

   
    Private Sub tampil_data()
        Dim selectedNode As TreeNode = TreeView1.SelectedNode
        Dim kodeInst As String

        If TreeView1.Nodes.Count > 0 Then
            Dim rootNode As TreeNode = TreeView1.Nodes(0)

            If rootNode.IsSelected = True Then
                kodeInst = "0"
            ElseIf selectedNode IsNot Nothing Then
                kodeInst = selectedNode.Tag.ToString()
            Else
                kodeInst = "0"

            End If

            ' Ambil dan tampilkan data
            LoadAndDisplayData(kodeInst)

            

        End If
    End Sub

    Private Sub LoadAndDisplayData(ByVal kodeInst As String)
        invSvc = InProcFactory.CreateChannel(Of InventarisService, IInventarisService)()
        Dim dt As DataTable = invSvc.LoadDatabyRuang(kodeInst)
        dv.Table = dt
        dgvInventaris.DataSource = dv

        Dim col As New List(Of GridColumnModel) From {
            GH.AddModelGridColumn("No Inventaris", 150),
            GH.AddModelGridColumn("Tgl Inventaris", 100),
            GH.AddModelGridColumn("Ruang", 100),
            GH.AddModelGridColumn("Jml TT Ruang", 100),
            GH.AddModelGridColumn("Jml PAR Ruang", 150),
            GH.AddModelGridColumn("Jml KM Ruang", 100),
            GH.AddModelGridColumn("Petugas Inventaris", 200),
            GH.AddModelGridColumn("Nama Instalasi", 0)}
        GH.FormatGrid(dgvInventaris, dt, col, True, True, False, True)


    End Sub

    
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgvInventaris.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If
        Dim uc As New UcAddInventarisRuangan
        Dim dataInv As New OrderInventaris With {.noInv = dgvInventaris.SelectedRows(0).DataBoundItem("inv_no"),
                                                 .Petugas = dgvInventaris.SelectedRows(0).DataBoundItem("inv_employee"),
                                                .tgl = dgvInventaris.SelectedRows(0).DataBoundItem("inv_date"),
                                                 .ruang = dgvInventaris.SelectedRows(0).DataBoundItem("ruang"),
                                                 .Inst = dgvInventaris.SelectedRows(0).DataBoundItem("nama_instalasi"),
                                                 .jmlTT = dgvInventaris.SelectedRows(0).DataBoundItem("qty_TT_ruang"),
                                                 .jmlPAR = dgvInventaris.SelectedRows(0).DataBoundItem("qty_PAR_ruang"),
                                                 .jmlKM = dgvInventaris.SelectedRows(0).DataBoundItem("qty_KM_ruang")}

        uc.order = dataInv
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

        Dim str As String = CType(sender, TextBox).Text
        dv.RowFilter = String.Format("inv_no LIKE '%{0}%' Or inv_date LIKE '%{0}%' Or ruang LIKE '%{0}%' Or inv_employee LIKE '%{0}%' Or nama_instalasi LIKE '%{0}%'", str)
       
    End Sub

    Private Sub btnDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If dgvInventaris.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If
        If MsgBox("Anda ingin menghapus data  " & dgvInventaris.SelectedRows(0).DataBoundItem(2) & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Dim tempData As String = dgvInventaris.SelectedRows(0).DataBoundItem(2)
            Try
                invSvc = InProcFactory.CreateChannel(Of InventarisService, IInventarisService)()
                header_inv.noInv = dgvInventaris.SelectedRows(0).DataBoundItem("inv_no")
                header_inv.createDate = DateTime.Now
                header_inv.Petugas = SessionInfo.fullName
                invSvc.Delete_inventori(header_inv)

                MsgBox("Data INV dengan no " & " " & header_inv.noInv & " berhasil dihapus")
                
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.LoadTree()
            Me.tampil_data()
            InProcFactory.CloseChannel(invSvc)
        End If
    End Sub
End Class
