Imports Ninject
Imports DbLibs

Public Class FrmCustomer

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private db As ClsDbase
    Private custDao As dao.CustomerDao

    Public Sub New()
        db = kernel.Get(Of ClsDbase)()
        custDao = kernel.Get(Of dao.CustomerDao)()

        custDao.db = db
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gv.DataSource = custDao.getCustomer()

          
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub pnImage_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnImage.Paint
        Dim bm As Bitmap = Bitmap.FromFile("images/Search.ico")
        Dim g As Graphics = pnImage.CreateGraphics()

        g.DrawImage(bm, New Rectangle(0, 0, 20, 20), New Rectangle(0, 0, bm.Width, bm.Height), GraphicsUnit.Pixel)

    End Sub
End Class