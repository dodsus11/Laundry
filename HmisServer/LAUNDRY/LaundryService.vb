Imports ServerLibs
Imports Laundry.Service.service

Namespace server
    Public Class LaundryService
        Public Shared Sub RunService()

            ServerLibs.InProcFactory.CreateChannel(Of HRDSystem.service.PegawaiService, HRDSystem.service.IPegawaiService)()            
            'InProcFactory.CreateChannel(Of LinenService, ILinenService)()

            'Tambahan Service
            'start
            'service linen
            InProcFactory.CreateChannel(Of LinenService, ILinenService)()

            'service mesin
            InProcFactory.CreateChannel(Of MesinService, IMesinService)()

            'service pembersih
            InProcFactory.CreateChannel(Of PembersihService, IPembersihService)()

            'service order
            InProcFactory.CreateChannel(Of OrderService, IOrderService)()

            'service util mesin
            InProcFactory.CreateChannel(Of UtilmesinService, IUtilmesinService)()

            'service util mesin peras
            InProcFactory.CreateChannel(Of UtilmesinPerasService, IUtilmesinPerasService)()

            'service util mesin pengering
            InProcFactory.CreateChannel(Of UtilmesinPengeringService, IUtilmesinPengeringService)()

            'service util mesin setrika
            InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()

            'service load gudang
            InProcFactory.CreateChannel(Of LoadGudangService, ILoadGudangService)()

            'service distribusi linen
            InProcFactory.CreateChannel(Of DistribusiService, IDistribusiService)()

            'service Report linen
            InProcFactory.CreateChannel(Of ReportLinenService, IReportLinenService)()

            'service pegawai laundry
            InProcFactory.CreateChannel(Of PegawailaundryService, IPegawailaundryService)()

            'folio service
            ServerLibs.InProcFactory.CreateChannel(Of SirusFolioService.service.FolioService, 
                                                      SirusFolioService.service.IFolioService)()
            'endxx

            'InProcFactory.CreateChannel(Of BridgePerawatantoFolioSirusService, IBridgePerawatantoFolioSirusService)()

            ServerLibs.InProcFactory.CreateChannel(Of PharSaleService.service.BridgePharSalesService, PharSaleService.service.IBridgePharSalesService)()


            'Bridge Phar Inventory service
            ServerLibs.InProcFactory.CreateChannel(Of SirusFolioService.service.PharInventoryService, SirusFolioService.service.IPharInventoryService)()

            'Bridge Phar Mutasi service
            ServerLibs.InProcFactory.CreateChannel(Of SirusFolioService.service.PharMutasiService, SirusFolioService.service.IPharMutasiService)()


            'service inventaris laundry
            InProcFactory.CreateChannel(Of InventarisService, IInventarisService)()
        End Sub

    End Class
End Namespace

