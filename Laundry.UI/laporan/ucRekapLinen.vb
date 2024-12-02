Imports Laundry.Service.service
Imports ClientLibs

Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms

Public Class ucRekapLinen
    Dim rpt As New cr_LaporanRekapLinenBersih()
    Dim dtReport As DataTable

    Private LinenReportSvr As IReportLinenService

    'Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs)
    '    If Not rpt Is Nothing Then
    '        rpt.Close()
    '        rpt.Dispose()
    '        rpt = Nothing
    '    End If

    '    rpt = New cr_LaporanRekapLinen()
    '    Dim obj As New ArrayList

    '    Me.LinenReportSvr = InProcFactory.CreateChannel(Of ReportLinenService, IReportLinenService)()
    '    dtReport = Me.LinenReportSvr.getLinenBersih()

    '    For Each row As DataRow In dtReport.Rows
    '        obj.Add(New RekapLinen With {.LinenID = row.Item("linenId"),
    '                                     .LinenNama = row.Item("linenNama"),
    '                                     .JumlahLinen = row.Item("jumlah")})


    '    Next
    '    InProcFactory.CloseChannel(Me.LinenReportSvr)
    '    Me.rpt.SetDataSource(obj)

    '    crv.ReuseParameterValuesOnRefresh = False
    '    crv.ReportSource = Me.rpt

    '    'Me.Cursor = Cursors.Default
    'End Sub

    Private Sub ucRekapLinen_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not rpt Is Nothing Then
            rpt.Close()
            rpt.Dispose()
            rpt = Nothing
        End If

        rpt = New cr_LaporanRekapLinenBersih()
        Dim obj As New ArrayList

        Me.LinenReportSvr = InProcFactory.CreateChannel(Of ReportLinenService, IReportLinenService)()
        dtReport = Me.LinenReportSvr.getLinenBersih()

        For Each row As DataRow In dtReport.Rows
            obj.Add(New RekapLinen With {.LinenKode = row.Item("kodeLinen"),
                                         .LinenNama = row.Item("namaLinen"),
                                         .JumlahLinen = row.Item("jumlahLinen")
                                        })
            '.JumlahLinen = IIf(String.IsNullOrEmpty(row.Item("jumlahLinen")), 0, row.Item("jumlahLinen"))

        Next
        InProcFactory.CloseChannel(Me.LinenReportSvr)
        Me.rpt.SetDataSource(obj)

        crv.ReuseParameterValuesOnRefresh = False
        crv.ReportSource = Me.rpt

    End Sub

    Private Sub btnExportExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportExcel.Click
        If Me.dtReport Is Nothing Then
            MsgBox("Data masih kosong !", MsgBoxStyle.Exclamation, "Pesan")
            Return
        End If

        DirectPrint.Export2Excel(Me.dtReport)
    End Sub
End Class
