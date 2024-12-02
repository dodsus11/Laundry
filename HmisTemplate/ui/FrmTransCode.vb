Imports Ninject
Imports DbLibs

Public Class FrmTransCode

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Dim dv As New DataView()
    Dim tcDao As dao.TransCodeDao
    Dim db As ClsDbase

    Dim fidArray(,) As Object = {{model.TCode.MENU_CAPTION, "Menu", 350},
                                 {model.TCode.TRANS_CODE, "T-Code", 150}}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        db = kernel.Get(Of ClsDbase)()

        Me.tcDao = kernel.Get(Of dao.TransCodeDao)()
        Me.tcDao.db = db

    End Sub

    Private Sub FrmTransCode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gv.RowHeight = 18
        Me.dv.Table = Me.tcDao.TransCodeActiveList()
        gv.DataSource = Me.dv
        UILibs.GridStyle.C1formatGrid(gv, Me.dv.Table, Me.fidArray)

    End Sub

    Private Sub FrmTransCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged

        Me.dv.RowFilter = String.Format("{0} LIKE '%{2}%' OR {1} LIKE '%{2}%'",
                                        model.TCode.MENU_CAPTION,
                                        model.TCode.TRANS_CODE,
                                        txtFilter.Text.Trim().Replace("'", ""))
    End Sub

End Class