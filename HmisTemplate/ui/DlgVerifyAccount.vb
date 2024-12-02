Imports Ninject
Imports DbLibs

Public Class DlgVerifyAccount

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Dim db As ClsDbase
    Dim unSrv As dao.UserDao

    Dim dtUser As DataTable
    Dim dvUser As New DataView()

    Public Sub New()
        db = kernel.Get(Of ClsDbase)()

        Me.unSrv = kernel.Get(Of dao.UserDao)()
        Me.unSrv.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub DlgVerifyAccount_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.dvUser.Table = Me.unSrv.SirusUserList()
        gv.DataSource = Me.dvUser

    End Sub

    Private Sub txtFilter_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFilter.TextChanged

        Dim filter As String = String.Format("user_name LIKE '%{0}%'", txtFilter.Text.Trim)
        Me.dvUser.RowFilter = filter

    End Sub

End Class