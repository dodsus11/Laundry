Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing


Public Class UcSetupRuang

    Dim dvRuang As New DataView()
    Dim cls As ClsConn

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim setup As New FormSetupRuang

        setup.Show()

    End Sub

    Private Sub load()

        Me.cls = New ClsConn
        Dim dt As New DataTable
        If Cbruang.SelectedItem.ToString = "Ruang" Then
            dt = Me.cls.Spd_Gen("LON_LOAD_RUANG", Nothing).Tables(0)

            Me.dvRuang.Table = dt
            Me.dgvruang.DataSource = Me.dvRuang
            
            With dgvruang
                .RowHeadersVisible = False
                .Columns("kode_ruang").HeaderCell.Value = "KODE"
                .Columns("kode_ruang").Width = 80
                .Columns("nama_ruang").HeaderCell.Value = "NAMA RUANG"
                .Columns("nama_ruang").Width = 350
                .Columns("nama_instalasi").HeaderCell.Value = "NAMA INSTALASI"
                .Columns("nama_instalasi").Width = 400
                .Columns("id").Visible = False

            End With

        Else
            dt = Me.cls.Spd_Gen("LON_load_Inst", Nothing).Tables(0)
            Me.dvRuang.Table = dt
            Me.dgvruang.DataSource = Me.dvRuang
            
            With dgvruang
                .RowHeadersVisible = False
                .Columns("kode_ruang").HeaderCell.Value = "KODE"
                .Columns("kode_ruang").Width = 80
                .Columns("nama_instalasi").HeaderCell.Value = "NAMA INSTALASI"
                .Columns("nama_instalasi").Width = 400
                .Columns("id").Visible = False

                
            End With
        End If
    End Sub

    
    Private Sub UcSetupRuang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cbruang.SelectedIndex = 1
        AddStyleToGrid(dgvruang)
        load()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        load()
    End Sub

    Public Sub AddStyleToGrid(ByVal dgv As DataGridView)

        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ReadOnly = True
        dgv.MultiSelect = False
        dgv.AllowUserToResizeRows = True
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

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click

        If dgvruang.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If
        If MsgBox("Anda ingin menghapus data ruang dengan kode = " & dgvruang.SelectedRows(0).DataBoundItem("kode_ruang") & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then

            Try
                Dim cancel_date As Date = Date.Now()

                Dim user As String = SessionInfo.un

                cls.Spd_Gen("LON_nonaktifRuang", New Object() {dgvruang.SelectedRows(0).DataBoundItem("kode_ruang"), user, cancel_date})

                MsgBox("Data ruang dengan kode = " & dgvruang.SelectedRows(0).DataBoundItem("kode_ruang") & " berhasil dihapus")

                Me.load()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgvruang.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim frm As New FormSetupRuang
        If Cbruang.SelectedItem.ToString = "Ruang" Then
            frm.txtKdRuang.Text = dgvruang.SelectedRows(0).Cells("kode_ruang").Value.ToString
            frm.txtKdRuang.ReadOnly = True
            frm.txtNmRuang.Text = dgvruang.SelectedRows(0).Cells("nama_ruang").Value.ToString
            frm.txtNmInst.Text = dgvruang.SelectedRows(0).Cells("nama_instalasi").Value.ToString
            frm.txtNmInst.ReadOnly = True
            frm.TextBox1.Text = dgvruang.SelectedRows(0).Cells("id").Value.ToString
            frm.txtkodeIns.Visible = False
            frm.btnInst.Visible = False
            frm.Label1.Visible = False
            frm.rdInst.Visible = False
            frm.rdRuang.Visible = False
            frm.Label6.Visible = False
            frm.Show()


        Else

            frm.txtkodeIns.Text = dgvruang.SelectedRows(0).Cells("kode_ruang").Value.ToString
            frm.txtkodeIns.ReadOnly = True
            frm.txtNmInst.Text = dgvruang.SelectedRows(0).Cells("nama_instalasi").Value.ToString
            frm.TextBox1.Text = dgvruang.SelectedRows(0).Cells("id").Value.ToString
            frm.rdInst.Checked = True
            frm.rdRuang.Visible = False
            frm.txtKdRuang.Visible = False
            frm.txtNmRuang.Visible = False
            frm.btnRuang.Visible = False
            frm.Show()

        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim str As String = CType(sender, TextBox).Text
        If Cbruang.SelectedItem.ToString = "Ruang" Then
            dvRuang.RowFilter = String.Format("kode_ruang LIKE '%{0}%' or nama_ruang LIKE '%{0}%' or nama_instalasi LIKE '%{0}%'", str)
        Else
            dvRuang.RowFilter = String.Format("kode_ruang LIKE '%{0}%' or nama_instalasi LIKE '%{0}%'", str)
        End If
    End Sub
End Class
