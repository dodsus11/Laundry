Imports BloodBank
Imports BloodBank.Service.service

Namespace server
    Public Class bloodservice
        Public Shared Sub RunServiceBloodBank()
            ServerLibs.InProcFactory.CreateChannel(Of bloodbankservice, ibloodbankservice)()
        End Sub


    End Class
End Namespace