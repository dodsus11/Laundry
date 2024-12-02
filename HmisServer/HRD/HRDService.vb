Namespace server

    Public Class HRDService

        Public Shared Sub RunService()
            ServerLibs.InProcFactory.CreateChannel(Of HRDSystem.service.PegawaiService, HRDSystem.service.IPegawaiService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsJenisCutiService, HRD.Service.SERVICE.IHRDMsJenisCutiService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsJenisPegawaiService, HRD.Service.SERVICE.IHRDMsJenisPegawaiService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsAgamaService, HRD.Service.SERVICE.IHRDMsAgamaService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsJenisSKService, HRD.Service.SERVICE.IHRDMsJenisSKService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsGolonganService, HRD.Service.SERVICE.IHRDMsGolonganService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsSkillService, HRD.Service.SERVICE.IHRDMsSkillService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsHariLiburService, HRD.Service.SERVICE.IHRDMsHariLiburService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsSpesialisasiPekerjaanService, HRD.Service.SERVICE.IHRDMsSpesialisasiPekerjaanService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsStatusPernikahanService, HRD.Service.SERVICE.IHRDMsStatusPernikahanService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDPenghargaanService, HRD.Service.SERVICE.IHRDPenghargaanService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsJenisStatusKerjaService, HRD.Service.SERVICE.IHRDMsJenisStatusKerjaService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsJenisPotonganGajiService, HRD.Service.SERVICE.IHRDMsJenisPotonganGajiService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsJenisPekerjaanService, HRD.Service.SERVICE.IHRDMsJenisPekerjaanService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsStatusPegawaiService, HRD.Service.SERVICE.IHRDMsStatusPegawaiService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsPelatihanService, HRD.Service.SERVICE.IHRDMsPelatihanService)() '
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDDiklatService, HRD.Service.SERVICE.IHRDDiklatService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsBesarTunjanganCutiService, HRD.Service.SERVICE.IHRDMsBesarTunjanganCutiService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsPendidikanService, HRD.Service.SERVICE.IHRDMsPendidikanService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsJurusanPendidikanService, HRD.Service.SERVICE.IHRDMsJurusanPendidikanService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsProfesiService, HRD.Service.SERVICE.IHRDMsProfesiService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsSubProfesiService, HRD.Service.SERVICE.IHRDMsSubProfesiService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsKelPerawatanService, HRD.Service.SERVICE.IHRDMsKelPerawatanService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsIjasahPendidikanService, HRD.Service.SERVICE.IHRDMsIjasahPendidikanService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsGajiPokokService, HRD.Service.SERVICE.IHRDMsGajiPokokService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDMsBsrTunjanganKeluargaService, HRD.Service.SERVICE.IHRDMsBsrTunjanganKeluargaService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDDataPegawaiService, HRD.Service.SERVICE.IHRDDataPegawaiService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDSpesialisasiDokterService, HRD.Service.SERVICE.IHRDSpesialisasiDokterService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDSIPDokterService, HRD.Service.SERVICE.IHRDSIPDokterService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDSertifikatService, HRD.Service.SERVICE.IHRDSertifikatService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDAnggotaKeluargaService, HRD.Service.SERVICE.IHRDAnggotaKeluargaService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDJabatanDanBagianService, HRD.Service.SERVICE.IHRDJabatanDanBagianService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDShareService, HRD.Service.SERVICE.IHRDShareService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDPesertaDidikService, HRD.Service.SERVICE.IHRDPesertaDidikService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDHukumanDisiplinService, HRD.Service.SERVICE.IHRDHukumanDisiplinService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDPresensiService, HRD.Service.SERVICE.IHRDPresensiService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDSMSService, HRD.Service.SERVICE.IHRDSMSService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDReportsService, HRD.Service.SERVICE.IHRDReportsService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDBerkasService, HRD.Service.SERVICE.IHRDBerkasService)()
            ServerLibs.InProcFactory.CreateChannel(Of HRD.Service.SERVICE.HRDNotifikasiService, HRD.Service.SERVICE.IHRDNotifikasiService)()
        End Sub

    End Class

End Namespace

