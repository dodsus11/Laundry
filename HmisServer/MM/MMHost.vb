Namespace server

    Public Class MMHost

        Public Shared Sub RunService()
            ServerLibs.InProcFactory.CreateChannel(Of HRDSystem.service.PegawaiService, HRDSystem.service.IPegawaiService)()
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.BarangService, MMService.service.IBarangService)()

            'Datftarin project nya di HMIS server
            'ServerLibs.InProcFactory.CreateChannel(Of latihanService.service.latihanBarangService, latihanService.service.ILatihanBarangService)()

            'for Master Setup Vendor
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_SetupVendorService, MMService.service.ISetupVendor)()

            'for Master Setup Item 
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_SetupItemService, MMService.service.ISetupItem)()

            'for Master Setup Manufacturer 
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_SetupManufacturerService, MMService.service.ISetupManufacturer)()

            'for Master Setup Satuan/UOM 
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_SetupSatuanService, MMService.service.ISetupSatuanService)()

            'for Master Setup Satuan/UOM 
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_SetupGudangService, MMService.service.ISetupGudang)()

            'for Master Setup Item Type
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_SetupItemTypeService, MMService.service.ISetupItemType)()

            'for Master Setup Item Group
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_SetupItemGroupService, MMService.service.ISetupItemGroup)()

            'for Master Setup Vendor Detil
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_SetupVendorDetilService, MMService.service.ISetupVendorDetil)()

            'for Master Setup ItemDanGudang
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_SetupItemDanGudangService, MMService.service.ISetupItemDanGudang)()

            'for Master Setup Item Conversion
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_SetupItemConversionService, MMService.service.ISetupConversion)()

            'for Master Setup Informasi Barang/ Item
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_SetupInformasiBaranOrItemService, MMService.service.ISetupInfomasiBaranOrItem)()

            'for Log Conversion
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_LogConversionService, MMService.service.ILogConversion)()

            '=====================transaksi========================='

            'for Transaksi Permintaan Mutasi
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_Tr_PermintaanService, MMService.service.Itr_Permintaan)()

            'for Transaksi Permintaan Mutasi Approvement
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_Tr_PermintaanApprovementService, MMService.service.ITrPermintaanApprovement)()

            'for Transaksi Permintaan Internal
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_Tr_PermintaanInternalService, MMService.service.Itr_PermintaanInternal)()

            'for Transaksi Permintaan Internal Approvement
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_Tr_PermintaanInternalApprovementService, MMService.service.ITrPermintaanInternalApprovement)()

            'for Transaksi Item Transfer
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_Tr_ItemTransferService, MMService.service.Itr_ItemTransfer)()

            'for Transaksi Usulan Pengadaan
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_Tr_UsulanPengadaanService, MMService.service.Itr_UsulanPengadaan)()

            'for Transaksi Penerimaan
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_Tr_PenerimaanService, MMService.service.Itr_Penerimaan)()




            '================REPORT================'
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_ReportService, MMService.service.IReportService)()

            'for SIMAK Persediaan
            ServerLibs.InProcFactory.CreateChannel(Of MMService.service.MM_SIMAKService, MMService.service.ISIMAKService)()

        End Sub

    End Class

End Namespace


