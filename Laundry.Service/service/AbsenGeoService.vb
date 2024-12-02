Imports Ninject
Imports DbLibs
Imports System.ServiceModel
Imports KernelEngine

Namespace service
    <ServiceContract()>
    Public Interface IAbsenGeoService

        <OperationContract()>
        Function getLogTransaction(nip, tgl) As DataTable

        <OperationContract()>
        Function getFotoSimpeg(nip) As String

        <OperationContract()>
        Function getNamaPegawai(nip) As String

    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True,
                      ConcurrencyMode:=ConcurrencyMode.Multiple,
                      InstanceContextMode:=InstanceContextMode.PerCall, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class AbsenGeoService
        Implements IAbsenGeoService

        Private kernel As IKernel = ClsKernel.createKernel()
        Private db As ClsDbase
        Private dbGeo As DbLibs.ClsConn
        Private absenGeoDao As dao.AbsenGeoDAO

        Public Sub New()
            dbGeo = New DbLibs.ClsConn(System.Configuration.ConfigurationManager.AppSettings("CONN_STR_GEO").ToString)
            db = kernel.Get(Of ClsDbase)()
            absenGeoDao = kernel.Get(Of dao.AbsenGeoDAO)()
            absenGeoDao.db = db
            absenGeoDao.dbGeo = dbGeo
        End Sub

        Public Function getLogTransaction(ByVal nip, ByVal tgl) As System.Data.DataTable Implements IAbsenGeoService.getLogTransaction
            Try
                Return absenGeoDao.getLogTransaction(nip, tgl)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getFotoSimpeg(ByVal nip) As String Implements IAbsenGeoService.getFotoSimpeg
            Try
                Return absenGeoDao.getFotoSimpeg(nip)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getNamaPegawai(ByVal nip) As String Implements IAbsenGeoService.getNamaPegawai
            Try
                Return absenGeoDao.getNamaPegawai(nip)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

    End Class
End Namespace
