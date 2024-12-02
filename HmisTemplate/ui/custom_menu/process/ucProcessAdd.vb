Imports Ninject
Imports DbLibs

Public Class ucProcessAdd

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private db As ClsDbase
    Private procDao As dao.ProcessDao
    Private menuDao As dao.MenuDao

    Public myNode As MyNode

    Public trv As TreeView
    Friend tempIdProses As Integer
    Friend statusCommand As String

    Public Sub New()
        db = kernel.Get(Of ClsDbase)()
        procDao = kernel.Get(Of dao.ProcessDao)()
        menuDao = kernel.Get(Of dao.MenuDao)()
        procDao.db = db
        menuDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'AddHandler seTemp.btnSaveAndNew().Click, AddressOf btnSaveNew_Click
        AddHandler seTemp.btnSaveAndClose().Click, AddressOf btnSaveClose_Click
        AddHandler seTemp.btnClear().Click, AddressOf btnClear_Click
        AddHandler seTemp.btnCancel().Click, AddressOf btnCancel_Click

        seTemp.btnSaveAndNew().Visible = False
        seTemp.btnSaveAndClose().Text = "Save"

    End Sub

    Private Sub ucProcessAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'If statusCommand = "Delete Proses" Then
        '    MsgBox("delete")
        'Else
        seTemp.setLeftTitle(10)
        seTemp.setTitle("Add Process >> " & myNode.caption)
        'End If

        If txtImage.Text <> "" Then

            PicIcon.Image = UILibs.MyResources.GetBitmap(txtImage.Text) 'Image.FromFile("images/" & txtImage.Text)

        End If

    End Sub

    Private Sub btnBrowseIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseIcon.Click
        'Ofd.InitialDirectory = System.Environment.CurrentDirectory & "\images"

        'If Ofd.ShowDialog() = DialogResult.OK Then
        '    txtImage.Text = getFileName(Ofd.FileName)
        '    PicIcon.Image = Image.FromFile("images/" & txtImage.Text)
        'End If

        Dim frmImg As New UILibs.FrmLookupImg()

        If frmImg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtImage.Text = frmImg.imagePilihan
            PicIcon.Image = UILibs.MyResources.GetBitmap(frmImg.imagePilihan)
        End If

    End Sub

    Function getFileName(ByVal path As String) As String
        Dim tmp() As String = Split(path, "\", , CompareMethod.Text)
        Return tmp(tmp.Length - 1)
    End Function

    Private Sub btnSaveNew_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub btnSaveClose_Click(ByVal sender As Object, ByVal e As EventArgs)

        If tempIdProses = 0 Then 'untuk menambah
            If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

            Try

                'validasi
                If txtProcessName.Text.Trim = "" Then
                    MsgBox("Nama Process Kosong !", MsgBoxStyle.Exclamation, "Pesan")
                    Return
                End If

                If txtImage.Text.Trim = "" Then
                    MsgBox("Nama File Icon Kosong !", MsgBoxStyle.Exclamation, "Pesan")
                    Return
                End If


                Dim proc As New model.Process()
                proc.procName = txtProcessName.Text
                proc.iconName = txtImage.Text
                proc.moduleId = myNode.id

                Me.procDao.saveProcess(proc)

                MsgBox("Data Berhasil disimpan", MsgBoxStyle.Information, "Pesan")

                txtProcessName.Clear()
                txtImage.Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else 'untuk mengedit 
            If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

            Try

                'validasi
                If txtProcessName.Text.Trim = "" Then
                    MsgBox("Nama Process Kosong !", MsgBoxStyle.Exclamation, "Pesan")
                    Return
                End If

                If txtImage.Text.Trim = "" Then
                    MsgBox("Nama File Icon Kosong !", MsgBoxStyle.Exclamation, "Pesan")
                    Return
                End If


                Dim proc As New model.Process()
                proc.procName = txtProcessName.Text
                proc.iconName = txtImage.Text
                'proc.moduleId = myNode.id
                proc.tempIdProse = tempIdProses

                Me.procDao.editProcess(proc)

                MsgBox("Data Berhasil Diedit", MsgBoxStyle.Information, "Pesan")

                txtProcessName.Clear()
                txtImage.Clear()



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.loadModule()
        End If
        
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        txtProcessName.Clear()
        txtImage.Clear()
        PicIcon.Image = Nothing
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New ucMenuConfig()
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub


    Private Sub loadModule()
        trv.Nodes.Clear()

        Try
            Dim dtMod As DataTable = Me.menuDao.getModuleSys()

            For Each row As DataRow In dtMod.Rows
                Dim node As New TreeNode()
                'node.NodeFont = New Font("Verdana", 8, FontStyle.Bold)
                node.Text = row("module_name").ToString()
                node.Tag = New MyNode() With {.id = row("id"),
                                              .level = 1,
                                              .caption = row("module_name")}

                'add process node to each module
                Me.addProcessToModule(node)

                trv.Nodes.Add(node)
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub addProcessToModule(ByVal Parent As TreeNode)
        Try
            Dim id As Integer = CType(Parent.Tag, MyNode).id

            Dim dtMod As DataTable = Me.procDao.getProcessByModID(id)

            For Each row As DataRow In dtMod.Rows
                Dim node As New TreeNode()
                'node.NodeFont = New Font("Verdana", 7, FontStyle.Regular)
                node.Text = row("process_name").ToString()
                node.Tag = New MyNode() With {.id = row("id"),
                                              .level = 2,
                                              .iconName = row("icon_name").ToString(),
                                              .caption = row("process_name")}

                Parent.Nodes.Add(node)

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


End Class
