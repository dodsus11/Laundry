Public Class DlgMenuAdd

    Public Property subMnDao As dao.SubMenuDao
    Public processId As Integer = 0
    Public parentId As Integer = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        seTemp.btnSaveAndNew().Visible = False
        seTemp.btnSaveAndClose().Text = "Save"
        seTemp.btnSaveAndClose().TextAlign = Drawing.ContentAlignment.MiddleCenter

        AddHandler seTemp.btnSaveAndClose().Click, AddressOf btnSave_Click
        AddHandler seTemp.btnCancel.Click, AddressOf btnCancel_Click
    End Sub

    Private Sub DlgMenuAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        seTemp.setTitle("")
        seTemp.setWidthTitle(Me.Width / 2 - 10)
    End Sub

    Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("Anda Yakin ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Return

        'validasi
        If txtMenuName.Text.Trim = "" Then
            MsgBox("Nama Menu Kosong !", MsgBoxStyle.Exclamation, "Pesan")
            Return
        End If

        If txtIconName.Text.Trim = "" Then
            MsgBox("Icon Kosong !", MsgBoxStyle.Exclamation, "Pesan")
            Return
        End If


        Try
            Dim menu As New model.MenuProcess() With {.caption = txtMenuName.Text,
                                                      .icon = txtIconName.Text,
                                                      .parentId = Me.parentId,
                                                      .processId = Me.processId}
            Me.subMnDao.AddProcMenu(menu)

            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Pesan")

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        'Ofd.InitialDirectory = System.Environment.CurrentDirectory & "\images"

        'If Ofd.ShowDialog() = DialogResult.OK Then
        '    txtIconName.Text = UtilsLibs.MainMod.getFileName(Ofd.FileName)
        'End If

        Dim frmImg As New UILibs.FrmLookupImg()

        If frmImg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtIconName.Text = frmImg.imagePilihan
        End If

    End Sub
End Class