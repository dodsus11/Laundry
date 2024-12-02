Imports UILibs
Imports System.Windows.Forms
Imports Laundry.Service.model

Public Class FormSetupRuang
    Dim cls As ClsConn
    Public Property _acl As SessionInfo.ACLUser
    Public header As OrderHeader
    Dim status As String

    Private Sub btnInst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInst.Click
        Me.cls = New ClsConn
        Dim dt As New DataTable
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"kode_ruang", "Kode Instalasi", 80},
                              {"nama_instalasi", "Nama Instalasi", 250}}

        frmLookUp.keyField = "kode_ruang"
        frmLookUp.fields = {"nama_instalasi"}

        dt = Me.cls.Spd_Gen("LON_load_Inst", Nothing).Tables(0)
        frmLookUp.dt = dt

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtkodeIns.Tag = frmLookUp.returnRow("kode_ruang").ToString
            txtkodeIns.Text = frmLookUp.returnRow("kode_ruang").ToString
            txtNmInst.Text = frmLookUp.returnRow("nama_instalasi").ToString
        End If


    End Sub

    Private Sub btnRuang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRuang.Click
        Me.cls = New ClsConn
        Dim dt As New DataTable
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"kode_ruang", "Kode Ruang", 80},
                              {"nama_ruang", "Nama Ruang", 250},
                              {"nama_instalasi", "Nama Instalasi", 250}}

        frmLookUp.keyField = "kode_ruang"
        frmLookUp.fields = {"nama_ruang"}

        dt = Me.cls.Spd_Gen("LON_LOAD_RUANG", Nothing).Tables(0)
        frmLookUp.dt = dt

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtKdRuang.Tag = frmLookUp.returnRow("kode_ruang").ToString
            txtKdRuang.Text = frmLookUp.returnRow("kode_ruang").ToString
            txtNmRuang.Text = frmLookUp.returnRow("nama_ruang").ToString
        End If
    End Sub

    Private Sub FormSetupRuang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If rdInst.Checked = True Then
            txtKdRuang.Visible = False
            txtNmRuang.Visible = False
            btnRuang.Visible = False
            Label3.Visible = False
            Label4.Visible = False
        Else
            rdRuang.Checked = True
        End If
    End Sub

    
    Private Sub rdInst_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdInst.CheckedChanged
        txtKdRuang.Visible = False
        txtNmRuang.Visible = False
        btnRuang.Visible = False
        Label3.Visible = False
        Label4.Visible = False
    End Sub

    Private Sub rdRuang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdRuang.CheckedChanged
        txtKdRuang.Visible = True
        txtNmRuang.Visible = True
        btnRuang.Visible = True
        Label3.Visible = True
        Label4.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tgl As Date = Date.Now()
        Dim user As String = SessionInfo.un
        Dim type As String
        cls = New ClsConn
        'Call validasi()
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        'dt = cls.Spd_Gen("LON_CekKodeRuang", New Object() {txtKdRuang.Text.ToString}).Tables(0)

        'If dt.Rows.Count > 0 Then
        '    MsgBox("Kode Ruang Sudah Ada ")
        '    Exit Sub

        'End If

        'dt2 = cls.Spd_Gen("LON_CekKodeRuang", New Object() {txtkodeIns.Text.ToString}).Tables(0)

        'If dt2.Rows.Count > 0 Then
        '    MsgBox("Kode Instalasi Sudah Ada ")
        '    Exit Sub
        'End If
        
        If TextBox1.Text.ToString = "" Then


            Try
                type = "ruang"
                If rdRuang.Checked = True Then
                    dt = cls.Spd_Gen("LON_CekKodeRuang", New Object() {txtKdRuang.Text.ToString}).Tables(0)
                    If dt.Rows.Count > 0 Then
                        MsgBox("Kode Ruang Sudah Ada ")
                        Exit Sub

                    End If

                    cls.Spd_Gen("LON_insertRuang", New Object() {txtKdRuang.Text.ToString(), txtNmRuang.Text.ToString(), type, txtkodeIns.Text.ToString(), tgl, user})

                Else
                    type = "instalasi"
                    dt2 = cls.Spd_Gen("LON_CekKodeRuang", New Object() {txtkodeIns.Text.ToString}).Tables(0)

                    If dt2.Rows.Count > 0 Then
                        MsgBox("Kode Instalasi Sudah Ada ")
                        Exit Sub
                    End If

                    cls.Spd_Gen("LON_insertRuang", New Object() {txtkodeIns.Text.ToString(), txtNmInst.Text.ToString(), type, txtKdRuang.Text.ToString(), tgl, user})

                End If


            Catch ex As Exception

            End Try

            MessageBox.Show("Data Berhasil DiTambahkan")

        Else

            Try
                If rdRuang.Checked = True Then
                    cls.Spd_Gen("LON_updateRuang", New Object() {txtKdRuang.Text.ToString(), txtNmRuang.Text.ToString(), tgl, user})

                Else

                    cls.Spd_Gen("LON_updateRuang", New Object() {txtkodeIns.Text.ToString(), txtNmInst.Text.ToString(), tgl, user})

                End If

            Catch ex As Exception

            End Try
            MessageBox.Show("Data Berhasil Di Update")

        End If

        'menghapus isi text box 
        Call clear_text()


    End Sub
    Private Sub clear_text()
        txtKdRuang.Text = ""
        txtNmRuang.Text = ""
        txtkodeIns.Text = ""
        txtNmInst.Text = ""
        TextBox1.Text = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    'untuk menghindari inputan huruf
    Private Sub txtkodeIns_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkodeIns.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtKdRuang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKdRuang.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    
  
End Class