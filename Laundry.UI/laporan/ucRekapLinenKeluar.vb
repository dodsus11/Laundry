Imports Laundry.Service.service
Imports ClientLibs

Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms

Public Class ucRekapLinenKeluar
    Dim rpt As New cr_LaporanRekapLinenKelauar()
    Dim dtReport As DataTable

    Private LinenReportSvr As IReportLinenService

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click
        If Not rpt Is Nothing Then
            rpt.Close()
            rpt.Dispose()
            rpt = Nothing
        End If

        rpt = New cr_LaporanRekapLinenKelauar()
        Dim obj As New ArrayList

        Me.LinenReportSvr = InProcFactory.CreateChannel(Of ReportLinenService, IReportLinenService)()
        dtReport = Me.LinenReportSvr.getLinenKeluar(dtpTanggal.Text)

        For Each row As DataRow In dtReport.Rows
            obj.Add(New RekapLinenKeluar With {.Ruang = row.Item("ruang"),
                                               .NamaLinen = row.Item("linen"),
                                               .JumlahLinen = row.Item("jumlah"),
                                               .JumlahDistribusi = row.Item("jumlah_distribusi"),
                                               .TanggalOrder = row.Item("tanggal_order")})
        Next
        InProcFactory.CloseChannel(Me.LinenReportSvr)
        Me.rpt.SetDataSource(obj)

        crv.ReuseParameterValuesOnRefresh = False
        crv.ReportSource = Me.rpt

    End Sub

    Private Sub ucRekapLinen_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnExportExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportExcel.Click
        If Me.dtReport Is Nothing Then
            MsgBox("Data masih kosong !", MsgBoxStyle.Exclamation, "Pesan")
            Return
        End If

        DirectPrint.Export2Excel(Me.dtReport)
    End Sub
End Class
