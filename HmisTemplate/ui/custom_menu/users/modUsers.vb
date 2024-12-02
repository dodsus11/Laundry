Imports Ninject
Imports DbLibs
Imports UILibs

Public Class modUsers

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private db As ClsDbase
    Private userDao As dao.UserDao

    Dim dvTemp As New DataView()
    Dim tempId As Integer


    Public Sub New()
        db = kernel.Get(Of ClsDbase)()
        userDao = kernel.Get(Of dao.UserDao)()
        userDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler browseTemp.getBtnNew().Click, AddressOf btnNew_Click
        AddHandler browseTemp.getBtnEdit().Click, AddressOf btnEdit_Click
        AddHandler browseTemp.getBtnDelete().Click, AddressOf btnDeleteUser_Click
        AddHandler browseTemp.getTextBox().TextChanged, AddressOf txtFind_TextChanged

        'tambahan klik kanan
        AddHandler browseTemp.getGridView().MouseClick, AddressOf gv_CellMouseUp

        browseTemp.getGridView.AllowAddNew = False
        browseTemp.getGridView.AllowDelete = False
        browseTemp.getGridView.AllowUpdate = False
        'browseTemp.getGridView().AutoSizeColumnsMode = Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub modUsers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'browseTemp.setWidthTitle(Me.Parent.Width)
        browseTemp.getTitle().Text = "DAFTAR USER"

        dvTemp.Table = userDao.getUsers()
        browseTemp.getGridView().DataSource = dvTemp
        browseTemp.getGridView().Splits(0).ExtendRightColumn = True

        UILibs.GridStyle.formatGrid(browseTemp.getGridView(), dvTemp.Table, New String() {"ID", "Username", "Role", "Create Date", "Pegawai", "Lokasi Poli", "Nama Lengkap"}, New Integer() {0, 100, 100, 100, 200, 400, 200})

    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        UILibs.PageLink.goToPage(Me.Parent, New ucUserAdd(), Me)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        If browseTemp.getGridView().Columns("id").Value < 0 Then
            MsgBox("Silahkan Pilih dahulu !")
            Return
        End If

        Dim uc As New ucUserAdd() With {.userId = CInt(browseTemp.getGridView().Columns("id").Value)} '.CurrentRow.Cells(0).Value)}
        uc.seTemp.btnSaveAndNew.Visible = False

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("username LIKE '%{0}%'", Me.browseTemp.getTextBox().Text)
        dvTemp.RowFilter = str
    End Sub

    Private Sub btnDeleteUserInRole_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("Anda Yakin ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Return

        Dim tempIdUser As Integer
        Dim tempRole As String

        tempIdUser = CInt(browseTemp.getGridView().Columns("id").Value).ToString
        tempRole = (browseTemp.getGridView().Columns("role").Value).ToString

        If tempRole = "" Then
            MsgBox(String.Format("Maaf role yang dipilih sudah tidak ada!! {0} Silahkan pilih role yang lain..", vbNewLine, MsgBoxStyle.Information), _
                       MsgBoxStyle.Exclamation)
        Else

            db.beginTransaction()

            Try

                Dim retVal As Integer
                userDao.deleteUserInRole(tempIdUser, retVal)

                'cek retval
                If retVal = 0 Then
                    MsgBox(String.Format("Role {0} berhasil dihapus", tempRole, MsgBoxStyle.Information))

                    'reload trv
                    modUsers_Load(sender, e)

                ElseIf retVal = 1 Then
                    MsgBox(String.Format("Penghapusan GAGAL !!", MsgBoxStyle.Information), _
                           MsgBoxStyle.Exclamation)

                End If

                db.commitTrans()

            Catch ex As Exception
                db.rollBackTrans()
                MsgBox(ex.Message)
                Return
            End Try

        End If

        

    End Sub

    Private Sub btnDeleteUser_Click(ByVal sender As Object, ByVal e As EventArgs)

        If MsgBox("Anda Yakin ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Return

        Dim tempIdUser As Integer
        Dim tempNamaUser As String
        ' Dim tempRole As String

        tempIdUser = CInt(browseTemp.getGridView().Columns("id").Value).ToString
        tempNamaUser = (browseTemp.getGridView().Columns("username").Value).ToString
        'tempRole = (browseTemp.getGridView().Columns("role").Value)

        db.beginTransaction()

        Try
            Dim retVal As Integer
            userDao.deleteUser(tempIdUser, retVal)

            'cek retval
            If retVal = 0 Then
                MsgBox(String.Format("User {0} berhasil dihapus", tempNamaUser, MsgBoxStyle.Information))

                'reload trv
                modUsers_Load(sender, e)

            ElseIf retVal = 1 Then
                MsgBox(String.Format("Penghapusan GAGAL !! {0} User dan Role {1} masih berkaitan dengan UserInRole {2} Silahkan pilih delete role terlebih dahulu..", vbNewLine, tempNamaUser, vbNewLine, MsgBoxStyle.Information), _
                       MsgBoxStyle.Exclamation)

            End If

            db.commitTrans()

        Catch ex As Exception
            db.rollBackTrans()
            MsgBox(ex.Message)
            Return
        End Try

    End Sub

    Private Sub btnAssign_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim frmLook As New UILibs.FrmLookUp()
        frmLook.dt = userDao.getAllRoles()
        frmLook.lebar = New Integer() {100, 100}
        frmLook.headers = New String() {"ID", "Role Name"}
        frmLook.fields = {"role_name"}
        frmLook.visibleButton = False

        Try
            If frmLook.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'MsgBox("hasil:" & frmLook.results(1))
                userDao.assignRole(CInt(browseTemp.getGridView().Columns(0).Value), frmLook.results(0)) '.CurrentRow.Cells(0).Value), frmLook.results(0))
                MsgBox("Berhasil menambahkan role ''" & frmLook.results(1) & "'' pada user ''" & browseTemp.getGridView().Columns("Username").Value & "''", MsgBoxStyle.Information, "Pesan")  '.CurrentRow.Cells(1).Value & "''", MsgBoxStyle.Information, "Pesan")
                browseTemp.setWidthTitle(Me.Parent.Width)
                browseTemp.getTitle().Text = "List User"

                dvTemp.Table = userDao.getUsers()
                browseTemp.getGridView().DataSource = dvTemp

                UILibs.GridStyle.formatGrid(browseTemp.getGridView(), dvTemp.Table, New String() {"ID", "Username", "Role", "Create Date", "Pegawai"}, _
                                            New Integer() {0, 100, 100, 100, 200})
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub gv_CellMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            browseTemp.getGridView().SetActiveCell(browseTemp.getGridView().RowContaining(e.Y), 0)
            Dim mnu As New ContextMenuStrip()
            Dim mnuItem1 As New ToolStripMenuItem("Edit", Nothing, AddressOf btnEdit_Click)
            Dim mnuItem2 As New ToolStripMenuItem("Delete Role", Nothing, AddressOf btnDeleteUserInRole_Click)
            Dim mnuItem3 As New ToolStripMenuItem("Delete User", Nothing, AddressOf btnDeleteUser_Click)
            Dim mnuItem4 As New ToolStripMenuItem("Assign Role", Nothing, AddressOf btnAssign_Click)
            mnu.Items.AddRange(New ToolStripItem() {mnuItem1, mnuItem2, mnuItem3, mnuItem4})
            Dim mypoint As Point = browseTemp.getGridView().PointToClient(Control.MousePosition)
            mnu.Show(browseTemp.getGridView(), mypoint.X, mypoint.Y)
        End If
    End Sub
End Class
