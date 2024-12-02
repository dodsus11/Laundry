Imports Ninject
Imports UILibs


Public Class modRoles

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private userDao As dao.UserDao
    Private db As DbLibs.ClsDbase

    Dim dtRoles As New DataTable()
    Dim dvTemp As New DataView()
    Dim tempId As Integer = 0
    Dim tempRole As String = ""
    Dim tempDesc As String = ""

    Dim headers() As String = {"ID", "Nama Role", "Deskripsi Role"}
    Dim lebar() As Integer = {50, 150, 150}

    Dim gvd As DataGridView

    Public Sub New()
        db = kernel.Get(Of DbLibs.ClsDbase)()
        userDao = kernel.Get(Of dao.UserDao)()

        userDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler BrowseTemp.getTextBox().TextChanged, AddressOf txtFind_TextChanged
        AddHandler BrowseTemp.getBtnNew().Click, AddressOf btnNew_Click
        AddHandler BrowseTemp.getGridView().MouseUp, AddressOf gvDouble_Click

        AddHandler BrowseTemp.getBtnEdit().Click, AddressOf btnEdit_Click
        AddHandler BrowseTemp.getBtnDelete().Click, AddressOf btnDelete_Click

        'AddHandler gvd.MouseUp, AddressOf gv_CellMouseUp

    End Sub

    Private Sub UcRoles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        BrowseTemp.getTitle.Text = "DAFTAR ROLE"

        makeTableRole()
        generateRole()
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New UcRolesAdd()
        uc.tempId = 0
        uc.tempRole = ""
        uc.tempDesc = ""
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub gvDouble_Click(ByVal sender As Object, ByVal e As MouseEventArgs)
        tempId = Integer.Parse(BrowseTemp.getGridView().Columns("id").Value)      'CurrentRow.Cells("id").Value.ToString())
        tempRole = BrowseTemp.getGridView().Columns("role_name").Text    'CurrentRow.Cells("role_name").Value.ToString()
        tempDesc = BrowseTemp.getGridView().Columns("description").Text  'CurrentRow.Cells("description").Value.ToString()
        'BrowseTemp.getGridView().SelectedRows.Add(BrowseTemp.getGridView().RowContaining(e.Y))
        If e.Button = Windows.Forms.MouseButtons.Right Then

            BrowseTemp.getGridView().SetActiveCell(BrowseTemp.getGridView().RowContaining(e.Y), 0)
            tempId = Integer.Parse(BrowseTemp.getGridView().Columns("id").Value)      'CurrentRow.Cells("id").Value.ToString())
            tempRole = BrowseTemp.getGridView().Columns("role_name").Text    'CurrentRow.Cells("role_name").Value.ToString()
            tempDesc = BrowseTemp.getGridView().Columns("description").Text  'CurrentRow.Cells("description").Value.ToString()
            BrowseTemp.getGridView().SelectedRows.Clear()

            Dim mnu As New ContextMenuStrip()
            Dim mnuItem1 As New ToolStripMenuItem("Edit", Nothing, AddressOf mnuEdit_Click)
            Dim mnuItem2 As New ToolStripMenuItem("Delete", Nothing, AddressOf mnuDelete_Click)
            Dim mnuItem3 As New ToolStripMenuItem("Assign Process", Nothing, AddressOf mnuAssignProcess_Click)
            mnu.Items.AddRange(New ToolStripItem() {mnuItem1, mnuItem2, mnuItem3})

            Dim mypoint As Point = BrowseTemp.getGridView().PointToClient(Control.MousePosition)

            mnu.Show(BrowseTemp.getGridView(), mypoint.X, mypoint.Y)

        End If

    End Sub

    Private Sub gvMouse_Down(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then

            BrowseTemp.getGridView().RowContaining(e.X)
            BrowseTemp.getGridView().ColContaining(e.Y)

            BrowseTemp.getGridView().SelectedRows.Add(BrowseTemp.getGridView().RowContaining(e.Y))

            Dim mnu As New ContextMenuStrip()
            Dim mnuItem1 As New ToolStripMenuItem("Edit", Nothing, AddressOf mnuEdit_Click)
            Dim mnuItem2 As New ToolStripMenuItem("Delete", Nothing, AddressOf mnuDelete_Click)
            Dim mnuItem3 As New ToolStripMenuItem("Assign Process", Nothing, AddressOf mnuAssignProcess_Click)
            mnu.Items.AddRange(New ToolStripItem() {mnuItem1, mnuItem2, mnuItem3})

            Dim mypoint As Point = BrowseTemp.getGridView().PointToClient(Control.MousePosition)

            mnu.Show(BrowseTemp.getGridView(), mypoint.X, mypoint.Y)

        End If
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        btnEdit_Click(sender, e)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        btnDelete_Click(sender, e)
    End Sub

    Private Sub mnuAssignProcess_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim role As New model.Role() With {.id = Me.tempId,
                                           .role_name = Me.tempRole}

        Dim uc As New modAssignProcToRole() With {.roleData = role}

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)

        If tempId = 0 Then
            MsgBox("Anda belum memilih data")
            Return
        End If
        Dim uc As New UcRolesAdd()
        uc.tempId = Me.tempId
        uc.tempRole = Me.tempRole
        uc.tempDesc = Me.tempDesc

        uc.seTemp.btnSaveAndNew.Visible = False
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)

        Me.tempId = 0
        Me.tempRole = ""
        uc.tempDesc = ""
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If tempId = 0 Then
            MsgBox("Anda belum memilih data")
            Return
        End If

        If MsgBox("Anda ingin menghapus data " & tempRole & "?", MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            Try
                Dim role As New model.Role With {.id = tempId}
                userDao.deleteRole(role)
                tempId = 0
                'Dim dt As DataTable = userDao.getAllRolesAndDesc()
                'BrowseTemp.getGridView().DataSource = dt
                MsgBox("Hapus data berhasil")
                UcRoles_Load(sender, e)
            Catch ex As Exception
                MsgBox("Hapus data gagal, " & ex.Message)
            End Try

        End If
    End Sub

    Sub makeTableRole()
        BrowseTemp.getGridView().AllowAddNew = False
        BrowseTemp.getGridView().AllowDelete = False
        BrowseTemp.getGridView().AllowUpdate = True
        BrowseTemp.getGridView().Splits(0).ExtendRightColumn = True
    End Sub

    Private Sub generateRole()
        dtRoles = userDao.getAllRolesAndDesc()

        dvTemp.Table = dtRoles
        BrowseTemp.getGridView().DataSource = dvTemp
        UILibs.GridStyle.formatGrid(BrowseTemp.getGridView(), dtRoles, headers, lebar)

        BrowseTemp.getGridView().Splits(0).DisplayColumns("description").Visible = False
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("role_name LIKE '%{0}%'", Me.BrowseTemp.getTextBox().Text)
        dvTemp.RowFilter = str
    End Sub

End Class
