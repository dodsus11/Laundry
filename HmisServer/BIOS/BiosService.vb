Imports BIOS_SERVICE

Namespace server
    Public Class BiosService
        Public Shared Sub RunServiceBIOS()
            ServerLibs.InProcFactory.CreateChannel(Of BIOS_SERVICE.Services.BIOSService, BIOS_SERVICE.Services.IBIOSService)()

            ServerLibs.InProcFactory.CreateChannel(Of BIOS_SERVICE.Services.IKUService, BIOS_SERVICE.Services.IIKUService)()
        End Sub

        
    End Class
End Namespace

