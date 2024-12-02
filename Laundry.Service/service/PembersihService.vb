Imports Ninject
Imports DbLibs
Imports System.ServiceModel

Namespace service
    <ServiceContract()>
    Public Interface IPembersihService

        'service master pembersih
        <OperationContract()>
        Function getMasterPembersih() As DataTable

        <OperationContract()>
        Function getMasterDosisPembersih() As DataTable

        <OperationContract()>
        Function getDosisPembersih(ByVal group As model.DosisPembersih) As DataTable

        <OperationContract()>
        Function getMasterPembersihGeneral() As DataTable

        <OperationContract()>
        Sub insertPembersih(ByVal go As model.Pembersih)

        <OperationContract()>
        Sub insertDosisPembersih(ByVal go As model.DosisPembersih)

        <OperationContract()>
        Sub updatePembersih(ByVal go As model.Pembersih)

        <OperationContract()>
        Sub updateDosisPembersih(ByVal go As model.DosisPembersih)

        <OperationContract()>
        Sub deletePembersih(ByVal go As model.Pembersih)

        <OperationContract()>
        Sub nonaktifDosisPembersih(ByVal go As model.DosisPembersih)

        <OperationContract()>
        Function isExistPembersih(ByVal go As model.Pembersih) As Boolean

        <OperationContract()>
        Function isExistDosisPembersih(ByVal go As model.DosisPembersih) As Boolean

    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True,
                      ConcurrencyMode:=ConcurrencyMode.Multiple,
                      InstanceContextMode:=InstanceContextMode.PerCall, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class PembersihService
        Implements IPembersihService

        Public kernel As IKernel = KernelEngine.ClsKernel.createKernel()
        Public db As ClsDbase
        Public lDao As dao.PembersihDao

        Public Sub New()
            db = kernel.Get(Of ClsDbase)()

            lDao = kernel.Get(Of dao.PembersihDao)()
            lDao.db = db

        End Sub

        'service master pembersih
        Public Function getMasterPembersih() As System.Data.DataTable Implements IPembersihService.getMasterPembersih
            Try
                Return lDao.getMasterPembersih()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getMasterDosisPembersih() As System.Data.DataTable Implements IPembersihService.getMasterDosisPembersih
            Try
                Return lDao.getMasterDosisPembersih()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getDosisPembersih(ByVal group As model.DosisPembersih) As System.Data.DataTable Implements IPembersihService.getDosisPembersih
            Try
                Return lDao.getDosisPembersih(group)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getMasterPembersihGeneral() As System.Data.DataTable Implements IPembersihService.getMasterPembersihGeneral
            Try
                Return lDao.getMasterPembersihGeneral()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub insertPembersih(ByVal go As model.Pembersih) Implements IPembersihService.insertPembersih
            Try
                lDao.insertPembersih(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub insertDosisPembersih(ByVal go As model.DosisPembersih) Implements IPembersihService.insertDosisPembersih
            Try
                lDao.insertDosisPembersih(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub updatePembersih(ByVal go As model.Pembersih) Implements IPembersihService.updatePembersih
            Try
                lDao.updatePembersih(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub updateDosisPembersih(ByVal go As model.DosisPembersih) Implements IPembersihService.updateDosisPembersih
            Try
                lDao.updateDosisPembersih(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub deletePembersih(ByVal go As model.Pembersih) Implements IPembersihService.deletePembersih
            Try
                lDao.deletePembersih(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub nonaktifDosisPembersih(ByVal go As model.DosisPembersih) Implements IPembersihService.nonaktifDosisPembersih
            Try
                lDao.nonaktifDosisPembersih(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function isExistPembersih(ByVal go As model.Pembersih) As Boolean Implements IPembersihService.isExistPembersih
            Try
                If lDao.existPembersih(go).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function isExistDosisPembersih(ByVal go As model.DosisPembersih) As Boolean Implements IPembersihService.isExistDosisPembersih
            Try
                If lDao.isExistDosisPembersih(go).Rows.Count > 0 Then
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
