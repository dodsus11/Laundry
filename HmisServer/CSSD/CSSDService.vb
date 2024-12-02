Imports CSSD_SERVICE

Namespace Server
    Public Class CSSDService
        Public Shared Sub RunServiceCSSD()
            ServerLibs.InProcFactory.CreateChannel(Of service.CSSDSetupService, service.ICSSDSetupService)()
            ServerLibs.InProcFactory.CreateChannel(Of service.CSSDOrderService, service.ICSSDOrderService)()
        End Sub
    End Class
End Namespace


