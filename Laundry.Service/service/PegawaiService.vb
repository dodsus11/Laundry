Imports Ninject
Imports DbLibs
Imports System.ServiceModel
Imports System.Data.SqlClient

Namespace service
    <ServiceContract()>
    Public Interface IPegawailaundryService

        'service pegawai
        <OperationContract()>
        Function getPegawai() As DataTable

        <OperationContract()>
        Sub insertPegawai(ByVal go As model.Pegawai)

        <OperationContract()>
        Sub updatePegawai(ByVal go As model.Pegawai)

        <OperationContract()>
        Sub deletePegawai(ByVal go As model.Pegawai)

        <OperationContract()>
        Function isExistPegawai(ByVal go As model.Pegawai) As Boolean

    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True,
                      ConcurrencyMode:=ConcurrencyMode.Multiple,
                      InstanceContextMode:=InstanceContextMode.PerCall, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class PegawailaundryService
        Implements IPegawailaundryService

        Public kernel As IKernel = KernelEngine.ClsKernel.createKernel()
        Public db As ClsDbase
        Public lDao As dao.PegawaiDao

        Public Sub New()
            db = kernel.Get(Of ClsDbase)()

            lDao = kernel.Get(Of dao.PegawaiDao)()
            lDao.db = db

        End Sub

        'service pegawai
        Public Function getPegawai() As System.Data.DataTable Implements IPegawailaundryService.getPegawai
            Try
                Return lDao.getPegawai()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub insertPegawai(ByVal go As model.Pegawai) Implements IPegawailaundryService.insertPegawai
            Try
                lDao.insertPegawai(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub updatePegawai(ByVal go As model.Pegawai) Implements IPegawailaundryService.updatePegawai
            Try
                lDao.updatePegawai(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub deletePegawai(ByVal go As model.Pegawai) Implements IPegawailaundryService.deletePegawai
            Try
                lDao.deletePegawai(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function isExistPegawai(ByVal go As model.Pegawai) As Boolean Implements IPegawailaundryService.isExistPegawai
            Try
                If lDao.existPegawai(go).Rows.Count > 0 Then
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
