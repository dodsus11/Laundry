Imports ServerLibs
Imports Pharmacy.Service.service

Namespace server
    Public Class PharmacyService
        Public Shared Sub RunService()

            ServerLibs.InProcFactory.CreateChannel(Of HRDSystem.service.PegawaiService, HRDSystem.service.IPegawaiService)()
            InProcFactory.CreateChannel(Of PharComputersService, IPharComputerService)()
            InProcFactory.CreateChannel(Of PharDosageService, IPharDosageService)()
            InProcFactory.CreateChannel(Of PharFormulariumService, IPharFormulariumService)()
            InProcFactory.CreateChannel(Of PharOutletService, IPharOutletService)()
            InProcFactory.CreateChannel(Of PharPenjualanResepService, IPharPenjualanResepService)()
            InProcFactory.CreateChannel(Of PharWorkOrderResepService, IPharWorkOrderResepService)()
            InProcFactory.CreateChannel(Of PharPenyerahanResepService, IPharPenyerahanResepService)()
            InProcFactory.CreateChannel(Of PharPersonSevice, IPharPersonService)()
            InProcFactory.CreateChannel(Of PharResepService, IPharResepService)()
            InProcFactory.CreateChannel(Of PharResepDigitalService, IPharResepDigitalService)()
            InProcFactory.CreateChannel(Of PharStatistikService, IPharStatistikService)()

            'Tambahan Service
            'start
            InProcFactory.CreateChannel(Of PharSetupObatService, IPharSetupObatService)()
            InProcFactory.CreateChannel(Of PharReportService, IPharReportService)()
            'folio service
            ServerLibs.InProcFactory.CreateChannel(Of SirusFolioService.service.FolioService, 
                                                      SirusFolioService.service.IFolioService)()
            'endxx

            InProcFactory.CreateChannel(Of BridgePerawatantoFolioSirusService, IBridgePerawatantoFolioSirusService)()

            ServerLibs.InProcFactory.CreateChannel(Of PharSaleService.service.BridgePharSalesService, PharSaleService.service.IBridgePharSalesService)()


            'Bridge Phar Inventory service
            ServerLibs.InProcFactory.CreateChannel(Of SirusFolioService.service.PharInventoryService, SirusFolioService.service.IPharInventoryService)()

            'Bridge Phar Mutasi service
            ServerLibs.InProcFactory.CreateChannel(Of SirusFolioService.service.PharMutasiService, SirusFolioService.service.IPharMutasiService)()


        End Sub

    End Class
End Namespace

