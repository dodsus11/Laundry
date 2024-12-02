Imports Ninject


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

    Public Sub New()
        db = kernel.Get(Of DbLibs.ClsDbase)()
        userDao = kernel.Get(Of dao.UserDao)()

        userDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler BrowseTemp.getTextBox().TextChanged, AddressOf txtFind_TextChanged
        AddHandler BrowseTemp.getBtnNew().Click, AddressOf btnNew_Click
        AddHandler BrowseTemp.getGridView().Click, AddressOf gvDouble_Click
        AddHandler BrowseTemp.getBtnEdit().Click, AddressOf btnEdit_Click
        AddHandler BrowseTemp.getBtnDelete().Click, AddressOf btnDelete_Click
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New UcRolesAdd()
        uc.tempId = 0
        uc.tempRole = ""
        uc.tempDesc = ""
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub gvDouble_Click(ByVal sender As Object, ByVal e As EventArgs)
        tempId = Integer.Parse(BrowseTemp.getGridView().CurrentRow.Cells("id").Value.ToString())
        tempRole = BrowseTemp.getGridView().CurrentRow.Cells("role_name").Value.ToString()
        tempDesc = BrowseTemp.getGridView().CurrentRow.Cells("description").Value.ToString()
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
                BrowseTemp.getGridView().DataSource = dt
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
        BrowseTemp.getGridView().AllowUserToAddRows = False
        BrowseTemp.getGridView().AllowUserToDeleteRows = False
        BrowseTemp.getGridView().ReadOnly = True
    End Sub

    Private Sub generateRole()
        dtRoles = userDao.getAllRolesAndDesc()

        dvTemp.Table = dtRoles
        BrowseTemp.getGridView().DataSource = dvTemp
        UILibs.GridStyle.formatGrid(BrowseTemp.getGridView(), dtRoles, headers, lebar)
        BrowseTemp.getGridView().Columns("description").Visible = False
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("role_name LIKE '%{0}%'", Me.BrowseTemp.getTextBox().Text)
        dvTemp.RowFilter = str
    End Sub

End Class
