Imports Ninject
Imports DbLibs
Imports System.ServiceModel

Namespace service
    <ServiceContract()>
    Public Interface IMesinService

        'service master mesin
        <OperationContract()>
        Function getMasterMesin() As DataTable

        <OperationContract()>
        Function getMesinByJenis(ByVal item As model.Mesin) As DataTable

        <OperationContract()>
        Sub insertMesin(ByVal go As model.Mesin)

        <OperationContract()>
        Sub updateMesin(ByVal go As model.Mesin)

        <OperationContract()>
        Sub deleteMesin(ByVal go As model.Mesin)

        <OperationContract()>
        Function isExistMesin(ByVal go As model.Mesin) As Boolean

    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True,
                      ConcurrencyMode:=ConcurrencyMode.Multiple,
                      InstanceContextMode:=InstanceContextMode.PerCall, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class MesinService
        Implements IMesinService

        Public kernel As IKernel = KernelEngine.ClsKernel.createKernel()
        Public db As ClsDbase
        Public lDao As dao.MesinDao

        Public Sub New()
            db = kernel.Get(Of ClsDbase)()

            lDao = kernel.Get(Of dao.MesinDao)()
            lDao.db = db

        End Sub

        'service master mesin
        Public Function getMasterMesin() As System.Data.DataTable Implements IMesinService.getMasterMesin
            Try
                Return lDao.getMasterMesin()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getMesinByJenis(ByVal item As model.Mesin) As System.Data.DataTable Implements IMesinService.getMesinByJenis
            Try
                Return lDao.getMesinByJenis(item)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub insertMesin(ByVal go As model.Mesin) Implements IMesinService.insertMesin
            Try
                lDao.insertMesin(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub updateMesin(ByVal go As model.Mesin) Implements IMesinService.updateMesin
            Try
                lDao.updateMesin(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub deleteMesin(ByVal go As model.Mesin) Implements IMesinService.deleteMesin
            Try
                lDao.deleteMesin(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function isExistMesin(ByVal go As model.Mesin) As Boolean Implements IMesinService.isExistMesin
            Try
                If lDao.existMesin(go).Rows.Count > 0 Then
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
