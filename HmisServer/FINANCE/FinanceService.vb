Imports Finance.Service.service

Namespace server

    Public Class FinanceService

        Public Shared Sub RunService()
            ServerLibs.InProcFactory.CreateChannel(Of HRDSystem.service.PegawaiService, HRDSystem.service.IPegawaiService)()
            ServerLibs.InProcFactory.CreateChannel(Of FinanceCoaService, IFinanceCoaService)()
            ServerLibs.InProcFactory.CreateChannel(Of KonstantaService, IKonstantaService)()
            ServerLibs.InProcFactory.CreateChannel(Of FinancePenggajianPegawaiService, IFinancePenggajianPegawaiService)()
            ServerLibs.InProcFactory.CreateChannel(Of FinanceJurnalService, IFinanceJurnalService)()
            ServerLibs.InProcFactory.CreateChannel(Of FinanceReportService, IFinanceReportService)()
        End Sub

    End Class

End Namespace

