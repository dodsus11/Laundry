Imports Ninject
Imports UILibs


Public Class ModControlList

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private controlDao As dao.MenuControlDao
    Private db As DbLibs.ClsDbase

    Dim dtControl As New DataTable()
    Dim dvTemp As New DataView()
    Dim tempId As Integer = 0
    Dim tempCaption As String = ""
    Dim tempDll As String = ""
    Dim tempUcName As String = ""
    Dim tempIcon As String = ""
    Dim tempDescription As String = ""

    Public Sub New()
        db = kernel.Get(Of DbLibs.ClsDbase)()
        controlDao = kernel.Get(Of dao.MenuControlDao)()

        controlDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler BrowseTemp.getTextBox().TextChanged, AddressOf txtFind_TextChanged
        AddHandler BrowseTemp.getBtnNew().Click, AddressOf btnNew_Click
        AddHandler BrowseTemp.getGridView().Click, AddressOf gv_Click
        AddHandler BrowseTemp.getBtnEdit().Click, AddressOf btnEdit_Click
        AddHandler BrowseTemp.getBtnDelete().Click, AddressOf btnDelete_Click

        AddHandler BrowseTemp.getGridView().MouseUp, AddressOf gvRight_Click

    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New UcControlAdd()
        uc.tempId = 0
        uc.tempCaption = ""
        uc.tempDll = ""
        uc.tempUcName = ""
        uc.tempIcon = ""
        uc.tempDescription = ""
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub gv_Click(ByVal sender As Object, ByVal e As MouseEventArgs)

        BrowseTemp.getGridView().SetActiveCell(BrowseTemp.getGridView().RowContaining(e.Y), 0)

        tempId = Integer.Parse(BrowseTemp.getGridView().Columns("id").Value)      'CurrentRow.Cells("id").Value.ToString())
        tempCaption = BrowseTemp.getGridView().Columns("caption").Text    'CurrentRow.Cells("role_name").Value.ToString()
        tempDll = BrowseTemp.getGridView().Columns("dll_name").Text  'CurrentRow.Cells("description").Value.ToString()
        tempUcName = BrowseTemp.getGridView().Columns("uc_name").Text      'CurrentRow.Cells("id").Value.ToString())
        tempIcon = BrowseTemp.getGridView().Columns("icon_name").Text    'CurrentRow.Cells("role_name").Value.ToString()
        tempDescription = BrowseTemp.getGridView().Columns("description").Text  'CurrentRow.Cells("description").Value.ToString()
    End Sub

    Private Sub gvRight_Click(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then

            BrowseTemp.getGridView().SetActiveCell(BrowseTemp.getGridView().RowContaining(e.Y), 0)

            tempId = Integer.Parse(BrowseTemp.getGridView().Columns("id").Value)      'CurrentRow.Cells("id").Value.ToString())
            tempCaption = BrowseTemp.getGridView().Columns("caption").Text    'CurrentRow.Cells("role_name").Value.ToString()
            tempDll = BrowseTemp.getGridView().Columns("dll_name").Text  'CurrentRow.Cells("description").Value.ToString()
            tempUcName = BrowseTemp.getGridView().Columns("uc_name").Text       'CurrentRow.Cells("id").Value.ToString())
            tempIcon = BrowseTemp.getGridView().Columns("icon_name").Text    'CurrentRow.Cells("role_name").Value.ToString()
            tempDescription = BrowseTemp.getGridView().Columns("description").Text  'CurrentRow.Cells("description").Value.ToString()
            'BrowseTemp.getGridView().SelectedRows.Clear()

            Dim mnu As New ContextMenuStrip()
            Dim mnuItem1 As New ToolStripMenuItem("Edit", Nothing, AddressOf btnEdit_Click)
            Dim mnuItem2 As New ToolStripMenuItem("Delete", Nothing, AddressOf btnDelete_Click)
            mnu.Items.AddRange(New ToolStripItem() {mnuItem1, mnuItem2})

            Dim mypoint As Point = BrowseTemp.getGridView().PointToClient(Control.MousePosition)

            mnu.Show(BrowseTemp.getGridView(), mypoint.X, mypoint.Y)

        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)

        If tempId = 0 Then
            MsgBox("Anda belum memilih data")
            Return
        End If
        Dim uc As New UcControlAdd()
        uc.tempId = Me.tempId
        uc.tempCaption = Me.tempCaption
        uc.tempDll = Me.tempDll
        uc.tempUcName = Me.tempUcName
        uc.tempIcon = Me.tempIcon
        uc.tempDescription = Me.tempDescription

        Me.makeEmptyVariable()

        uc.seTemp.btnSaveAndNew.Visible = False
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)

    End Sub

    Private Sub makeEmptyVariable()
        Me.tempId = 0
        Me.tempCaption = ""
        Me.tempDll = ""
        Me.tempIcon = ""
        Me.tempUcName = ""
        Me.tempDescription = ""
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If tempId = 0 Then
            MsgBox("Anda belum memilih data")
            Return
        End If

        If MsgBox("Anda ingin menghapus data " & tempCaption & "?", MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            If controlDao.isUsedControlMenu(tempId) Then
                MsgBox("Caption " & tempCaption & " tidak bisa dihapus, karena masih digunakan pada proses lain", MsgBoxStyle.Exclamation, "Peringatan")
                Return
            End If
            Try
                'Dim control As New model.MenuControl With {.id = tempId}
                controlDao.deleteControlMenu(tempId)
                tempId = 0

                'Me.generateRole()
                'Dim dt As DataTable = controlDao.getAllControlMenu()
                'BrowseTemp.getGridView().DataSource = dt

                UcRoles_Load(sender, e)
                MsgBox("Hapus data berhasil")
            Catch ex As Exception
                MsgBox("Hapus data gagal, " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub UcRoles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BrowseTemp.getTitle.Text = "Daftar Kontrol"
        makeTableRole()
        generateRole()
    End Sub

    Sub makeTableRole()
        BrowseTemp.getGridView().AllowAddNew = False
        BrowseTemp.getGridView().AllowDelete = False
        BrowseTemp.getGridView().AllowUpdate = False
        'BrowseTemp.getGridView().Size = Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        BrowseTemp.getGridView().Splits(0).ExtendRightColumn = True
    End Sub

    Private Sub generateRole()
        dtControl = controlDao.getAllControlMenu()

        Dim headers() As String = {"ID", "Caption", "DLL Name", "User Control Name", "Icon", "Description"}
        Dim lebar() As Integer = {50, 150, 150, 150, 150, 150}
        dvTemp.Table = dtControl
        BrowseTemp.getGridView().DataSource = dvTemp
        '        BrowseTemp.getGridView().DataMember = dtControl
        'BrowseTemp.getGridView().SetDataBinding(dvTemp, "")
        'BrowseTemp.getGridView.SetDataBinding(dvTemp, "mn_MenuControl")
        UILibs.GridStyle.formatGrid(BrowseTemp.getGridView(), dtControl, headers, lebar)
        BrowseTemp.getGridView.Splits(0).DisplayColumns("Description").Visible = False
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("caption LIKE '%{0}%'", Me.BrowseTemp.getTextBox().Text)
        dvTemp.RowFilter = str
    End Sub

End Class
