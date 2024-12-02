Imports Ninject
Imports DbLibs
Imports System.ServiceModel

Namespace service
    <ServiceContract()>
    Public Interface IReportLinenService

        <OperationContract()>
        Function getLinenBersih() As DataTable

        <OperationContract()>
        Function getLinenKeluar(ByVal tanggal As Date) As DataTable

        <OperationContract()>
        Function getKitirOrderDetail(ByVal headerid As Integer) As DataTable

        <OperationContract()>
        Function rekapLinenTerdistribusi(ByVal fromdate As Date, ByVal todate As Date, ByVal deptid As Integer) As DataTable

        <OperationContract()>
        Function getLinenKotor(ByVal tglmul As Date, ByVal tglsel As Date, ByVal ruang As Long) As DataTable

        <OperationContract()>
        Function getLinenPerJnsLinen(ByVal Ftgl As Date, ByVal Ttgl As Date, ByVal ruang As Long) As DataTable

        <OperationContract()>
        Function rekapLinenHilangRusak(ByVal fromdate As Date, ByVal todate As Date) As DataTable

    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True,
                      ConcurrencyMode:=ConcurrencyMode.Multiple,
                      InstanceContextMode:=InstanceContextMode.PerCall, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class ReportLinenService
        Implements IReportLinenService

        Public kernel As IKernel = KernelEngine.ClsKernel.createKernel()
        Public db As ClsDbase
        Public lDao As dao.ReportlinenDao

        Public Sub New()
            db = kernel.Get(Of ClsDbase)()

            lDao = kernel.Get(Of dao.ReportlinenDao)()
            lDao.db = db

        End Sub

        Public Function getLinenBersih() As System.Data.DataTable Implements IReportLinenService.getLinenBersih
            Try
                Return lDao.getLinenBersih()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getLinenKeluar(ByVal tanggal As Date) As System.Data.DataTable Implements IReportLinenService.getLinenKeluar
            Try
                Return lDao.getLinenKeluar(tanggal)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getKitirOrderDetail(ByVal headerid As Integer) As System.Data.DataTable Implements IReportLinenService.getKitirOrderDetail
            Try
                Return lDao.getKitirOrderDetail(headerid)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function rekapLinenTerdistribusi(ByVal fromdate As Date, ByVal todate As Date, ByVal deptid As Integer) As System.Data.DataTable Implements IReportLinenService.rekapLinenTerdistribusi
            Try
                Return lDao.rekapLinenTerdistribusi(fromdate, todate, deptid)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getLinenKotor(ByVal tglmul As Date, ByVal tglsel As Date, ByVal ruang As Long) As System.Data.DataTable Implements IReportLinenService.getLinenKotor
            Try
                Return lDao.getLinenKotor(tglmul, tglsel, ruang)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getLinenPerJnsLinen(ByVal Ftgl As Date, ByVal Ttgl As Date, ByVal ruang As Long) As System.Data.DataTable Implements IReportLinenService.getLinenPerJnsLinen
            Try
                Return lDao.getLinenPerJnsLinen(Ftgl, Ttgl, ruang)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function rekapLinenHilangRusak(ByVal fromdate As Date, ByVal todate As Date) As System.Data.DataTable Implements IReportLinenService.rekapLinenHilangRusak
            Try
                Return lDao.rekapLinenHilangRusak(fromdate, todate)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

    End Class
End Namespace
