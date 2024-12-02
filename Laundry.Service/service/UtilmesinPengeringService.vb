Imports Ninject
Imports DbLibs
Imports System.ServiceModel

Namespace service
    <ServiceContract()>
    Public Interface IUtilmesinPengeringService

        'service utilisasi mesin
        <OperationContract()>
        Function getUtilMesinPengering(tgl) As DataTable

        <OperationContract()>
        Sub insertUtilMesinPengering(ByVal go As model.Util_Mesin_Pengering)

        <OperationContract()>
        Sub updateUtilMesinPengering(ByVal go As model.Util_Mesin_Pengering)

        <OperationContract()>
        Sub deleteUtilMesinPengering(ByVal go As model.Util_Mesin_Pengering)

        <OperationContract()>
        Function lookupPegawai() As DataTable

        <OperationContract()>
        Function isExistUtilmesinPengering(ByVal go As model.Util_Mesin_Pengering) As Boolean
    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True,
                      ConcurrencyMode:=ConcurrencyMode.Multiple,
                      InstanceContextMode:=InstanceContextMode.PerCall, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class UtilmesinPengeringService
        Implements IUtilmesinPengeringService

        Public kernel As IKernel = KernelEngine.ClsKernel.createKernel()
        Public db As ClsDbase
        Public lDao As dao.UtilmesinpengeringDao

        Public Sub New()
            db = kernel.Get(Of ClsDbase)()

            lDao = kernel.Get(Of dao.UtilmesinpengeringDao)()
            lDao.db = db

        End Sub

        'service utilisasi mesin
        Public Function getUtilMesinPengering(ByVal tgl) As System.Data.DataTable Implements IUtilmesinPengeringService.getUtilMesinPengering
            Try
                Return lDao.getUtilMesinPengering(tgl)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub insertUtilMesinPengering(ByVal go As model.Util_Mesin_Pengering) Implements IUtilmesinPengeringService.insertUtilMesinPengering
            Try
                lDao.insertUtilMesinPengering(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub updateUtilMesinPengering(ByVal go As model.Util_Mesin_Pengering) Implements IUtilmesinPengeringService.updateUtilMesinPengering
            Try
                lDao.updateUtilMesinPengering(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub deleteUtilMesinPengering(ByVal go As model.Util_Mesin_Pengering) Implements IUtilmesinPengeringService.deleteUtilMesinPengering
            Try
                lDao.deleteUtilMesinPengering(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function lookupPegawai() As System.Data.DataTable Implements IUtilmesinPengeringService.lookupPegawai
            Try
                Return lDao.lookupPegawai()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function isExistUtilmesinPengering(ByVal go As model.Util_Mesin_Pengering) As Boolean Implements IUtilmesinPengeringService.isExistUtilmesinPengering
            Try
                If lDao.existUtilmesinPengering(go).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
    End Class
End Namespace
