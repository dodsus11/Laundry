Imports DoctorFingerprintService
Imports ServerLibs
Namespace server
    Public Class DoctorFingerprintService


        Public Shared Sub RunService()
            ServerLibs.InProcFactory.CreateChannel(Of service.DoctorFingerprintService, service.IDoctorFingerprintService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.PisAbsensiVisite, service.IPisAbsensiVisite)()
            ServerLibs.InProcFactory.CreateChannel(Of service.HRD_AbsensiPegawaiService, service.IHRD_AbsensiPegawaiService)()
        End Sub

    End Class
End Namespace