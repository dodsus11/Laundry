Imports Ninject


Public Class UcRoles

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

    Public Sub New()
        db = kernel.Get(Of DbLibs.ClsDbase)()
        userDao = kernel.Get(Of dao.UserDao)()

        userDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler FindCtr.getTxtFind().TextChanged, AddressOf txtFind_TextChanged
        AddHandler seTemp.getBtnNew().Click, AddressOf btnNew_Click
        AddHandler gv.Click, AddressOf gvDouble_Click
        AddHandler seTemp.getBtnEdit().Click, AddressOf btnEdit_Click
        AddHandler seTemp.getBtnDelete().Click, AddressOf btnDelete_Click
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New UcRolesAdd()
        uc.tempId = 0
        uc.tempRole = ""
        uc.tempDesc = ""
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub gvDouble_Click(ByVal sender As Object, ByVal e As EventArgs)
        tempId = Integer.Parse(gv.CurrentRow.Cells("id").Value.ToString())
        tempRole = gv.CurrentRow.Cells("role_name").Value.ToString()
        tempDesc = gv.CurrentRow.Cells("description").Value.ToString()
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
                Dim dt As DataTable = userDao.getAllRolesAndDesc()
                gv.DataSource = dt
                MsgBox("Hapus data berhasil")
            Catch ex As Exception
                MsgBox("Hapus data gagal, " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub UcRoles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        makeTableRole()
        generateRole()
    End Sub

    Sub makeTableRole()
        'dtRoles.Columns.Add("Id", GetType(System.Int32))
        'dtRoles.Columns.Add("Nama Role", GetType(System.String))
        'dtRoles.Columns.Add("Deskripsi Role", GetType(System.String))

        'Me.gv.DataSource = dtRoles
        gv.AllowUserToAddRows = False
        gv.AllowUserToDeleteRows = False
        gv.ReadOnly = True
    End Sub

    Private Sub generateRole()
        dtRoles = userDao.getAllRolesAndDesc()

        dvTemp.Table = dtRoles
        gv.DataSource = dvTemp
        UILibs.GridStyle.formatGrid(gv, dtRoles, headers, lebar)
        gv.Columns("description").Visible = False
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("role_name LIKE '%{0}%'", Me.FindCtr.getTxtFind.Text)
        dvTemp.RowFilter = str
    End Sub



    'Sub getChildById(ByVal parent As Integer, ByVal dt As DataTable)

    '    Dim rows() As DataRow = dt.Select("[Parent] = " & parent)

    '    For Each row As DataRow In rows
    '        dtRoles.Rows.Add(New Object() {row("id"), _
    '                                       makeSpace(row("level_role")) & row("role_name"), _
    '                                       row("level_role")})

    '        getChildById(row("id"), dt)
    '    Next

    'End Sub

    'Function makeSpace(ByVal a As Integer)
    '    Dim str As String = ""
    '    For i = 1 To a
    '        str += "    "
    '    Next

    '    Return str
    'End Function

    'Private Sub loadLview()
    '    lv.View = View.Details

    '    lv.Columns.Add("ID", 100, HorizontalAlignment.Left)
    '    lv.Columns.Add("Nama", 100, HorizontalAlignment.Left)
    '    lv.Columns.Add("Alamat", 100, HorizontalAlignment.Left)


    '    Dim itm As ListViewItem

    '    itm = lv.Items.Add("A001")
    '    itm.SubItems.Add("dale")
    '    itm.SubItems.Add("semarang")

    '    itm = lv.Items.Add("A002")
    '    itm.SubItems.Add("fajar")
    '    itm.SubItems.Add("solo")

    '    itm = lv.Items.Add("A003")
    '    itm.SubItems.Add("anta")
    '    itm.SubItems.Add("magelang")



    '    lv.Items(1).Selected = True
    '    'lv.Items(0).Focused = True
    '    lv.Select()

    'End Sub

End Class
