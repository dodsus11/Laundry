Imports PISService

Namespace server

    Public Class PISService

        Public Shared Sub RunService()
            ServerLibs.InProcFactory.CreateChannel(Of HRDSystem.service.PegawaiService, HRDSystem.service.IPegawaiService)()

            ServerLibs.InProcFactory.CreateChannel(Of service.PisPatientService, service.IPisPatientService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisPatientNewService, service.IPisPatientService)()

            ServerLibs.InProcFactory.CreateChannel(Of service.PisGeoBoundaryService, service.IPisGeoBoundaryService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisPolyService, service.IPisPolyService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisPartyService, service.IPisPartyService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisDokterService, service.IPisDokterService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisPatientRegisterService, service.IPisPatientRegisterService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisTarifService, service.IPisTarifService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisAdmitIRJAService, service.IPisAdmitIRJAService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisDiagnosaService, service.IPisDiagnosaService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisAdmitIRNAService, service.IPisAdmitIRNAService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisAdmisiIRDAService, service.IPisAdmisiIRDAService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisPaymentService, service.IPisPaymentService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisBillingService, service.IPisBillingService)()

            ServerLibs.InProcFactory.CreateChannel(Of service.PisBerkasMRService, service.IPisBerkasMRService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisOneDaySurgeryService, service.IPisOneDaySurgeryService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisOMLabRadService, service.IPisOMLabRadService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisBedInfoService, service.IPisBedInfoService)()

            ServerLibs.InProcFactory.CreateChannel(Of service.PisKodefiksasiService, service.IPisKodefiksasiService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisOMPenunjangIRJAService, service.IPisOMPenunjangIRJAService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisSJPService, service.IPisSJPService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisSecurityService, service.IPisSecurityService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisBillingResepService, service.IPisBillingResepService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisBillingVerifService, service.IPisBillingVerifService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisAktPostingService, service.IPisAktPostingService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisRehabMedikService, service.IPisRehabMedikService)()


            'Service Bridge SIRUS
            ServerLibs.InProcFactory.CreateChannel(Of SirusPatientService.service.PatientMaster, 
                                                      SirusPatientService.service.IPatientMaster)()

            'folio service
            ServerLibs.InProcFactory.CreateChannel(Of SirusFolioService.service.FolioService, 
                                                      SirusFolioService.service.IFolioService)()

            'billing transfer
            ServerLibs.InProcFactory.CreateChannel(Of SirusFolioService.service.PisBillTransferService, 
                                                      SirusFolioService.service.IPisBillTransferService)()


            ServerLibs.InProcFactory.CreateChannel(Of SirusFolioService.service.PharSalesTestService, 
                                                      SirusFolioService.service.IPharSalesTestService)()

            'reporting services
            ServerLibs.InProcFactory.CreateChannel(Of HMISReportService.service.PisIRJAService, 
                                                      HMISReportService.service.IPisIRJAService)()
            'bridge ASKES
            ServerLibs.InProcFactory.CreateChannel(Of BridgeAskesService.service.SJPAskesService, 
                                                      BridgeAskesService.service.ISJPAskesService)()

            'bridge LIS
            ServerLibs.InProcFactory.CreateChannel(Of BridgeLIS.service.OrderLabService, 
                                                      BridgeLIS.service.IOrderLabService)()

            'service antrian radioterapi
            ServerLibs.InProcFactory.CreateChannel(Of service.PisAntrianRadioTerapiService, service.IPisAntrianRadioTerapiService)()

            'service dashboard TT
            ServerLibs.InProcFactory.CreateChannel(Of service.PISDashboardBedService, service.IPISDashboardBedService)()

        End Sub

        Public Shared Sub RunServiceIRNA()

            ServerLibs.InProcFactory.CreateChannel(Of PatInService.service.PatInAdmitIRNAService, 
                                                      PatInService.service.IPatInAdmitIRNAService)()

            ServerLibs.InProcFactory.CreateChannel(Of PatInService.service.PatInChargeService, 
                                                      PatInService.service.IPatInChargeService)()

            ServerLibs.InProcFactory.CreateChannel(Of SirusFolioService.service.FolioIRNAService, 
                                                      SirusFolioService.service.IFolioIRNAService)()

            ServerLibs.InProcFactory.CreateChannel(Of PatInService.service.PatInChargeClassService, 
                                                      PatInService.service.IPatInChargeClassService)()

            ServerLibs.InProcFactory.CreateChannel(Of PatInService.service.PatInBedTransService, 
                                                      PatInService.service.IPatInBedTransService)()

            ServerLibs.InProcFactory.CreateChannel(Of PatInService.service.PatInBillingService, 
                                                      PatInService.service.IPatInBillingService)()

            ServerLibs.InProcFactory.CreateChannel(Of PatInService.service.PatInPaymentService, 
                                                      PatInService.service.IPatInPaymentService)()

            ServerLibs.InProcFactory.CreateChannel(Of PatInService.service.PatInCashierService, 
                                                      PatInService.service.IPatInCashierService)()

            ServerLibs.InProcFactory.CreateChannel(Of PatInService.service.PatInClaimService, 
                                                      PatInService.service.IPatInClaimService)()

            ServerLibs.InProcFactory.CreateChannel(Of PatInService.service.PatInOrderLabRadService, 
                                                      PatInService.service.IPatInOrderLabRadService)()

            ServerLibs.InProcFactory.CreateChannel(Of PatInService.service.PatInFoodService, 
                                                      PatInService.service.IPatInFoodService)()

            ServerLibs.InProcFactory.CreateChannel(Of PatInService.service.PatInPiutangService, 
                                                      PatInService.service.IPatInPiutangService)()

        End Sub

        Public Shared Sub RunServiceOT()
            ServerLibs.InProcFactory.CreateChannel(Of OTSvr.Service.OperatorType, OTSvr.Service.IOperatorType)()
            ServerLibs.InProcFactory.CreateChannel(Of OTSvr.Service.Theaters, OTSvr.Service.ITheaters)()
            ServerLibs.InProcFactory.CreateChannel(Of OTSvr.Service.PatientService, OTSvr.Service.IPatientService)()
            ServerLibs.InProcFactory.CreateChannel(Of OTSvr.Service.EmployeeService, OTSvr.Service.IEmployeeService)()
            ServerLibs.InProcFactory.CreateChannel(Of OTSvr.Service.ScheduledOperationsService, OTSvr.Service.IScheduledOperationsService)()
            ServerLibs.InProcFactory.CreateChannel(Of OTSvr.Service.DiagnosaOperasiService, OTSvr.Service.IDiagnosaOperasiService)()
            ServerLibs.InProcFactory.CreateChannel(Of OTSvr.Service.TindakanOperasiService, OTSvr.Service.ITindakanOperasiService)()
            ServerLibs.InProcFactory.CreateChannel(Of OTSvr.Service.RoomService, OTSvr.Service.IRoomService)()
            ServerLibs.InProcFactory.CreateChannel(Of OTSvr.Service.Operator, OTSvr.Service.IOperator)()
            ServerLibs.InProcFactory.CreateChannel(Of OTSvr.Service.SettingParametersService, OTSvr.Service.ISettingParametersService)()
            ServerLibs.InProcFactory.CreateChannel(Of OTSvr.Service.DokterService, OTSvr.Service.IDokterService)()
            ServerLibs.InProcFactory.CreateChannel(Of OTSvr.Service.Perawat, OTSvr.Service.IPerawat)()
            ServerLibs.InProcFactory.CreateChannel(Of OTSvr.Service.AsistenOperator, OTSvr.Service.IAsistenOperator)()

            'info bed
            ServerLibs.InProcFactory.CreateChannel(Of DashBoardService.Service.InfoJumlahBedService, DashBoardService.Service.IInfoJumlahBedService)()
            ServerLibs.InProcFactory.CreateChannel(Of DashBoardService.Service.IKIService, DashBoardService.Service.IIKIService)()
            ServerLibs.InProcFactory.CreateChannel(Of DashBoardService.Service.IKTService, DashBoardService.Service.IIKTService)()

            'PE- Service
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.barang, PESVR.Service.IBarang)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.satuan, PESVR.Service.ISatuan)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.bagian, PESVR.Service.IBagian)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.produk, PESVR.Service.IProduk)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.InputUsulan, PESVR.Service.IInputUsulan)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.vendor, PESVR.Service.IVendor)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.InputReview, PESVR.Service.IInputReview)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.PEPPK, PESVR.Service.IPEPPK)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.PEKodeMAK, PESVR.Service.IPEKodeMAK)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.PEKodeRUP, PESVR.Service.IPEKodeRUP)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.PEPengadaan, PESVR.Service.IPEPengadaan)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.PEPenyedia, PESVR.Service.IPenyedia)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.PEMetodePengadaan, PESVR.Service.IPEMetodePengadaan)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.PESumberDana, PESVR.Service.IPESumberDana)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.PEJenisKontrak, PESVR.Service.IPEJenisKontrak)()
            ServerLibs.InProcFactory.CreateChannel(Of PESVR.Service.PEPenjab, PESVR.Service.IPEPenjab)()


        End Sub

    End Class

End Namespace

