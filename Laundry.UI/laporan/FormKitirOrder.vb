Imports Laundry.Service.service
Imports Laundry.Service.model
Imports ClientLibs
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms

Public Class FormKitirOrder
    Dim rpt As New cr_KitirOrder()        
    Dim dtReportDetail As DataTable    
    Public header As OrderHeader
    Private LinenReportSvr As IReportLinenService

    Private Sub ucRekapLinen_Load(sender As Object, e As System.EventArgs) Handles Me.Load        
       
        If Not rpt Is Nothing Then
            rpt.Close()
            rpt.Dispose()
            rpt = Nothing
        End If

        rpt = New cr_KitirOrder()
        Dim objDetail As New ArrayList        

        Me.LinenReportSvr = InProcFactory.CreateChannel(Of ReportLinenService, IReportLinenService)()        
        dtReportDetail = Me.LinenReportSvr.getKitirOrderDetail(header.headerId)

        For Each row As DataRow In dtReportDetail.Rows
            objDetail.Add(New KitirDetail With {.Nomer = row.Item("nomer"),
                                                .Item = row.Item("item"),
                                                .JumlahNon = row.Item("jumlahNon"),
                                                .JumlahInf = row.Item("jumlahInf"),
                                                .JumlahTotal = row.Item("jmlTotal"),
                                                .BeratLinen = row.Item("beratLinen")})


        Next
        InProcFactory.CloseChannel(Me.LinenReportSvr)
        
        Me.rpt.SetDataSource(objDetail)

        Me.rpt.SetParameterValue("noOrder", header.orderNo)
        Me.rpt.SetParameterValue("ruang", header.ruang)
        If header.subRuang = Nothing Then
            Me.rpt.SetParameterValue("subRuang", "")
        Else
            Me.rpt.SetParameterValue("subRuang", header.subRuang)
        End If
        Me.rpt.SetParameterValue("pengantar", header.namaPegawai)
        Me.rpt.SetParameterValue("pegLaundry", header.pegawaiLaundy)
        Me.rpt.SetParameterValue("jamOrder", header.jamstr)
        Me.rpt.SetParameterValue("tglOrder", header.tanggalstr)



        crv.ReuseParameterValuesOnRefresh = False
        crv.ReportSource = Me.rpt

    End Sub

End Class
