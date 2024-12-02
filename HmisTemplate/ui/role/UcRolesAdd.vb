Imports DbLibs
Imports Ninject

Public Class UcRolesAdd

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel
    Private db As ClsDbase
    Dim userDao As dao.UserDao
    Friend tempId As Integer
    Friend tempRole, tempDesc As String


    Public Sub New()

        db = kernel.Get(Of ClsDbase)()
        userDao = kernel.Get(Of dao.UserDao)()
        userDao.db = db

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

        If txtRole.Text.Trim = "" Then
            Return "Role Kosong !"
        End If

        If txtDesc.Text.Trim = "" Then
            Return "Deksripsi Kosong !"
        End If

        If Me.tempId = 0 Then
            If userDao.isExistRole(txtRole.Text.Trim) Then
                Return "Role sudah ada !"
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
        Me.updateDbRole(0)
    End Sub

    Private Sub btnSaveAndClose_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim result As String = Me.validateForm()
        If result <> "" Then
            MsgBox(result, MsgBoxStyle.Exclamation, "Pesan")
            Return
        End If
        Me.updateDbRole(1)
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        txtRole.Text = ""
        txtDesc.Text = ""
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New modRoles()
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub seTemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seTemp.Load
        If Me.tempRole <> "" Then
            txtRole.Text = Me.tempRole
            txtDesc.Text = Me.tempDesc
        End If

        txtRole.Focus()
    End Sub

    Private Sub updateDbRole(ByVal flag As Integer)
        Try

            If Me.tempId = 0 Then
                'prosedur insert tabel jenis pegawai
                Dim role As New model.Role With {.role_name = txtRole.Text, .desc = txtDesc.Text}
                If MsgBox("Anda ingin menyimpan data ini?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    userDao.insertRole(role)

                    'Throw New Exception("Sukses")
                    'db.commitTrans()

                    'reset text field
                    txtRole.Text = ""
                    txtDesc.Text = ""

                    MsgBox("Data berhasil disimpan")

                    If flag = 1 Then
                        Dim uc As New UcRoles()
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    End If
                End If
            Else
                'update data
                Dim role As New model.Role With {.id = Me.tempId, .role_name = txtRole.Text, .desc = txtDesc.Text}
                If MsgBox("Anda ingin mengubah data ini?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    userDao.updateRole(role)

                    'Throw New Exception("Sukses")
                    'db.commitTrans()

                    'reset text field
                    txtRole.Text = ""
                    txtDesc.Text = ""
                    Me.tempId = 0

                    MsgBox("Data berhasil diubah")

                    If flag = 1 Then
                        Dim uc As New UcRoles()
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    End If
                End If
            End If

        Catch ex As Exception
            'db.rollBackTrans()
            MsgBox("Simpan data gagal, " & ex.Message)
        End Try
    End Sub
End Class
