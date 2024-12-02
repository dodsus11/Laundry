Imports DbLibs
Imports Ninject
Imports System.Reflection

Public Class UcControlAdd

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel
    Private db As ClsDbase
    Dim controlDao As dao.MenuControlDao
    Friend tempId As Integer = 0
    Friend tempCaption As String = ""
    Friend tempDll As String = ""
    Friend tempUcName As String = ""
    Friend tempIcon As String = ""
    Friend tempDescription As String = ""


    Public Sub New()

        db = kernel.Get(Of ClsDbase)()
        controlDao = kernel.Get(Of dao.MenuControlDao)()
        controlDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        seTemp.loadKontrol()
        seTemp.setTitle("Input Jenis Pegawai")

        'event
        AddHandler seTemp.btnSaveAndNew.Click, AddressOf btnSaveAndNew_Click
        AddHandler seTemp.btnSaveAndClose.Click, AddressOf btnSaveAndClose_Click
        AddHandler seTemp.btnClear.Click, AddressOf btnClear_Click
        AddHandler seTemp.btnCancel.Click, AddressOf btnCancel_Click

    End Sub

    Function validateForm() As String

        If txtCaption.Text.Trim = "" Then
            Return "Caption Kosong !"
        End If

        If txtDesc.Text.Trim = "" Then
            Return "Deksripsi Kosong !"
        End If

        If txtDll.Text.Trim = "" Then
            Return "DLL Kosong"
        End If

        If txtIcon.Text.Trim = "" Then
            Return "Icon Kosong"
        End If

        If txtUcName.Text.Trim = "" Then
            Return "User Control Kosong"
        End If

        If Me.tempId = 0 Then
            If controlDao.isExistControlMenu(txtCaption.Text.Trim) Then
                Return "Caption sudah ada"
            End If
        End If

        Return ""

    End Function

    Private Sub btnSaveAndNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim result As String = Me.validateForm()
        If result <> "" Then
            MsgBox(result, MsgBoxStyle.Exclamation, "Pesan")
            Return
        End If
        Me.updateDbControl(0)
    End Sub

    Private Sub btnSaveAndClose_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim result As String = Me.validateForm()
        If result <> "" Then
            MsgBox(result, MsgBoxStyle.Exclamation, "Pesan")
            Return
        End If
        Me.updateDbControl(1)
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        txtCaption.Text = ""
        txtDesc.Text = ""
        txtDll.Text = ""
        txtIcon.Text = ""
        txtUcName.Text = ""
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New ModControlList()
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub seTemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seTemp.Load
        If Me.tempCaption <> "" Then
            txtCaption.Text = Me.tempCaption
            txtDesc.Text = Me.tempDescription
            txtDll.Text = Me.tempDll
            txtIcon.Text = Me.tempIcon
            txtUcName.Text = Me.tempUcName
        End If

        txtCaption.Focus()
    End Sub

    Private Sub updateDbControl(ByVal flag As Integer)
        Try

            If Me.tempId = 0 Then
                'prosedur insert tabel jenis pegawai
                Dim control As New model.MenuControl With {.caption = txtCaption.Text, _
                                                           .dll_name = txtDll.Text, _
                                                           .uc_name = txtUcName.Text, _
                                                           .icon_name = txtIcon.Text, _
                                                           .description = txtDesc.Text}

                If MsgBox("Anda ingin menyimpan data ini?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    controlDao.insertControlMenu(control)

                    'Throw New Exception("Sukses")
                    'db.commitTrans()

                    'reset text field
                    txtCaption.Text = ""
                    txtDesc.Text = ""
                    txtDll.Text = ""
                    txtIcon.Text = ""
                    txtUcName.Text = ""

                    MsgBox("Data berhasil disimpan")

                    If flag = 1 Then
                        Dim uc As New ModControlList()
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    End If
                End If
            Else
                'update data
                Dim control As New model.MenuControl With {.id = Me.tempId, _
                                                           .caption = txtCaption.Text, _
                                                           .dll_name = txtDll.Text, _
                                                           .uc_name = txtUcName.Text, _
                                                           .icon_name = txtIcon.Text, _
                                                           .description = txtDesc.Text}

                If MsgBox("Anda ingin mengubah data ini?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    controlDao.updateControlMenu(control)

                    'Throw New Exception("Sukses")
                    'db.commitTrans()

                    'reset text field
                    txtCaption.Text = ""
                    txtDesc.Text = ""
                    txtDll.Text = ""
                    txtIcon.Text = ""
                    txtUcName.Text = ""

                    MsgBox("Data berhasil diubah")

                    If flag = 1 Then
                        Dim uc As New ModControlList()
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    End If
                End If
            End If

        Catch ex As Exception
            'db.rollBackTrans()
            MsgBox("Simpan data gagal, " & ex.Message)
        End Try
    End Sub

    Private Sub searchDll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofd As New OpenFileDialog
        ofd.InitialDirectory = System.Environment.CurrentDirectory '& "\images"

        If ofd.ShowDialog() = DialogResult.OK Then
            txtDll.Text = getFileName(ofd.FileName).Remove(getFileName(ofd.FileName).Length - 4)
        End If

    End Sub

    Function getFileName(ByVal path As String) As String
        Dim tmp() As String = Split(path, "\", , CompareMethod.Text)
        Return tmp(tmp.Length - 1)
    End Function

    Private Sub btnIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnUc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub


    Private Sub searchDll_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchDll.Click
        Dim ofd As New OpenFileDialog
        ofd.InitialDirectory = System.Environment.CurrentDirectory '& "\images"

        If ofd.ShowDialog() = DialogResult.OK Then
            txtDll.Text = getFileName(ofd.FileName).Remove(getFileName(ofd.FileName).Length - 4)
        End If
    End Sub

    Private Sub btnUc_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUc.Click
        If txtDll.Text.Equals("") Then
            MsgBox("Pilih DLL terlebih dahulu", MsgBoxStyle.Information, "Pesan")
            Return
        End If
        'buat datatable baru
        Dim tempData As New DataTable
        tempData.Columns.Add("Uc_Name", System.Type.GetType("System.String"))
        tempData.TableName = "Uc_Name"

        'load dll file
        Dim obj As Object = Nothing
        Dim types() As Type = Assembly.LoadFrom(txtDll.Text & ".dll").GetTypes()
        For Each tp As Type In types

            Try
                obj = Activator.CreateInstance(tp)
                If TypeOf obj Is UserControl Then
                    'MsgBox(tp.FullName)
                    Dim data As DataRow
                    data = tempData.NewRow()
                    data("Uc_Name") = tp.Name
                    tempData.Rows.Add(data)
                End If

            Catch ex As Exception
            End Try

        Next

        Dim frmLook As New UILibs.FrmLookUp()

        frmLook.dt = tempData
        frmLook.lebar = New Integer() {100}
        frmLook.headers = New String() {"Uc Name"}
        frmLook.fields = {"Uc_Name"}
        frmLook.visibleButton = False

        If frmLook.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'MsgBox("hasil:" & frmLook.results(0))

            txtUcName.Tag = frmLook.results(0)
            txtUcName.Text = frmLook.results(0).ToString()
        End If
    End Sub

    Private Sub btnIcon_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIcon.Click
        'Dim ofd As New OpenFileDialog
        'ofd.InitialDirectory = System.Environment.CurrentDirectory & "\images"

        'If ofd.ShowDialog() = DialogResult.OK Then
        '    txtIcon.Text = getFileName(ofd.FileName)
        'End If

        Dim frmImg As New UILibs.FrmLookupImg()

        If frmImg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtIcon.Text = frmImg.imagePilihan
        End If

    End Sub
End Class
