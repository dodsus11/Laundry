Imports Ninject
Imports DbLibs
Imports System.ServiceModel

Namespace service
    <ServiceContract()>
    Public Interface IUtilmesinPerasService

        'service utilisasi mesin
        <OperationContract()>
        Function getUtilMesinPeras(tgl) As DataTable

        <OperationContract()>
        Sub insertUtilMesinPeras(ByVal go As model.Util_Mesin_Peras)

        <OperationContract()>
        Sub updateUtilMesinPeras(ByVal go As model.Util_Mesin_Peras)

        <OperationContract()>
        Sub deleteUtilMesinPeras(ByVal go As model.Util_Mesin_Peras)

        <OperationContract()>
        Function lookupPegawai() As DataTable

        <OperationContract()>
        Function isExistUtilmesinPeras(ByVal go As model.Util_Mesin_Peras) As Boolean
    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True,
                      ConcurrencyMode:=ConcurrencyMode.Multiple,
                      InstanceContextMode:=InstanceContextMode.PerCall, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class UtilmesinPerasService
        Implements IUtilmesinPerasService

        Public kernel As IKernel = KernelEngine.ClsKernel.createKernel()
        Public db As ClsDbase
        Public lDao As dao.UtilmesinperasDao

        Public Sub New()
            db = kernel.Get(Of ClsDbase)()

            lDao = kernel.Get(Of dao.UtilmesinperasDao)()
            lDao.db = db

        End Sub

        'service utilisasi mesin
        Public Function getUtilMesinPeras(ByVal tgl) As System.Data.DataTable Implements IUtilmesinPerasService.getUtilMesinPeras
            Try
                Return lDao.getUtilMesinPeras(tgl)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub insertUtilMesinPeras(ByVal go As model.Util_Mesin_Peras) Implements IUtilmesinPerasService.insertUtilMesinPeras
            Try
                lDao.insertUtilMesinPeras(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub updateUtilMesinPeras(ByVal go As model.Util_Mesin_Peras) Implements IUtilmesinPerasService.updateUtilMesinPeras
            Try
                lDao.updateUtilMesinPeras(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub deleteUtilMesinPeras(ByVal go As model.Util_Mesin_Peras) Implements IUtilmesinPerasService.deleteUtilMesinPeras
            Try
                lDao.deleteUtilMesinPeras(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function lookupPegawai() As System.Data.DataTable Implements IUtilmesinPerasService.lookupPegawai
            Try
                Return lDao.lookupPegawai()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function isExistUtilmesinPeras(ByVal go As model.Util_Mesin_Peras) As Boolean Implements IUtilmesinPerasService.isExistUtilmesinPeras
            Try
                If lDao.existUtilmesinPeras(go).Rows.Count > 0 Then
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
