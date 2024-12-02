Imports System.Reflection
Imports Ninject

Public Class Form1

    'Dim kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Dim logger As LoggingLibs.LogApp

    Public Sub New()

        'logger = kernel.Get(Of LoggingLibs.LogApp)()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        'logger.info("hello dale")
        'LoggingLibs.LogApp.info("hello abi")
        'MsgBox("logging")
        'LoggingLibs.LogApp.info("log4net berhasil dicoba")


        'logger = log4net.LogManager.GetLogger("testApp.LoggingExample")

        'log4net.Config.DOMConfigurator.Configure()

        'Dim frm As New PISModule.FrmPerson()
        'frm.Show()
        'Dim obj As Object = Nothing
        'Dim types() As Type = Assembly.LoadFrom("PISModule.dll"). _
        'GetTypes()

        'Dim type As Type = Assembly.LoadFrom("LoggingLibs.dll"). _
        '                 GetType("LoggingLibs.Form1")

        'obj = Activator.CreateInstance(type)
        'obj.show()

        'For Each tp As Type In types

        '    Try
        '        obj = Activator.CreateInstance(tp)
        '        If TypeOf obj Is Form Then
        '            MsgBox(tp.FullName)
        '        End If

        '        obj.show()

        '    Catch ex As Exception
        '    End Try

        'Next


    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim gmb As Bitmap = UtilsLibs.My.Resources.MyFolder.ResourceManager.GetObject("Apply")
        picBox.Image = gmb
        lv.View = View.Details

        lv.Columns.Add("ID", 100, HorizontalAlignment.Left)
        lv.Columns.Add("Nama", 100, HorizontalAlignment.Left)
        lv.Columns.Add("Alamat", 100, HorizontalAlignment.Left)


        Dim itm As ListViewItem

        itm = lv.Items.Add("A001")
        itm.SubItems.Add("dale")
        itm.SubItems.Add("semarang")

        itm = lv.Items.Add("A002")
        itm.SubItems.Add("fajar")
        itm.SubItems.Add("solo")

        itm = lv.Items.Add("A003")
        itm.SubItems.Add("anta")
        itm.SubItems.Add("magelang")



        lv.Items(1).Selected = True
        'lv.Items(1).Focused = True
        lv.Select()

    End Sub

    
    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        txtEncrypt.Text = CryptoUtil.EncryptTripleDES(txtPlain.Text)
    End Sub
End Class
