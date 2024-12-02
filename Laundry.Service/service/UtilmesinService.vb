Imports Ninject
Imports DbLibs
Imports System.ServiceModel

Namespace service
    <ServiceContract()>
    Public Interface IUtilmesinService



        'service utilisasi mesin
        <OperationContract()>
        Function getUtilMesin(tgl) As DataTable

        <OperationContract()>
        Sub insertUtilMesin(ByVal go As model.Util_Mesin)

        <OperationContract()>
        Sub updateUtilMesin(ByVal go As model.Util_Mesin)

        <OperationContract()>
        Sub deleteUtilMesin(ByVal go As model.Util_Mesin)

        <OperationContract()>
        Function lookupPegawai() As DataTable

        <OperationContract()>
        Function isExistUtilmesin(ByVal go As model.Util_Mesin) As Boolean

        <OperationContract()>
        Function DataUtilisasiMesinCuci(ByVal fromdate As String, ByVal todate As String) As DataTable

        <OperationContract()>
        Function DataUtilisasiMesinCucibyLinen(ByVal fromdate As String, ByVal todate As String, ByVal jns_linen As String) As DataTable

        <OperationContract()>
        Function DataUtilisasiMesinPengering(ByVal fromdate As String, ByVal todate As String) As DataTable

        <OperationContract()>
        Function DataUtilisasiMesinSetrika(ByVal fromdate As String, ByVal todate As String) As DataTable

        <OperationContract()>
        Function DataPenggunaanChemical(ByVal fromdate As String, ByVal todate As String) As DataTable
    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True,
                      ConcurrencyMode:=ConcurrencyMode.Multiple,
                      InstanceContextMode:=InstanceContextMode.PerCall, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class UtilmesinService
        Implements IUtilmesinService

        Public kernel As IKernel = KernelEngine.ClsKernel.createKernel()
        Public db As ClsDbase
        Public lDao As dao.UtilmesinDao

        Public Sub New()
            db = kernel.Get(Of ClsDbase)()

            lDao = kernel.Get(Of dao.UtilmesinDao)()
            lDao.db = db

        End Sub

        'service utilisasi mesin
        Public Function getUtilMesin(ByVal tgl) As System.Data.DataTable Implements IUtilmesinService.getUtilMesin
            Try
                Return lDao.getUtilMesin(tgl)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub insertUtilMesin(ByVal go As model.Util_Mesin) Implements IUtilmesinService.insertUtilMesin
            Try
                lDao.insertUtilMesin(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub updateUtilMesin(ByVal go As model.Util_Mesin) Implements IUtilmesinService.updateUtilMesin
            Try
                lDao.updateUtilMesin(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub deleteUtilMesin(ByVal go As model.Util_Mesin) Implements IUtilmesinService.deleteUtilMesin
            Try
                lDao.deleteUtilMesin(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function lookupPegawai() As System.Data.DataTable Implements IUtilmesinService.lookupPegawai
            Try
                Return lDao.lookupPegawai()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function isExistUtilmesin(ByVal go As model.Util_Mesin) As Boolean Implements IUtilmesinService.isExistUtilmesin
            Try
                If lDao.existUtilmesin(go).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function DataUtilisasiMesinCuci(ByVal fromdate As String, ByVal todate As String) As System.Data.DataTable Implements IUtilmesinService.DataUtilisasiMesinCuci
            Try
                If lDao.DataUtilisasiMesinCuci(fromdate, todate).Rows.Count > 0 Then
                    Return lDao.DataUtilisasiMesinCuci(fromdate, todate)
                Else
                    Exit Try
                End If
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
        Public Function DataUtilisasiMesinCucibyLinen(ByVal fromdate As String, ByVal todate As String, ByVal jns_linen As String) As System.Data.DataTable Implements IUtilmesinService.DataUtilisasiMesinCucibyLinen
            Try
                If lDao.DataUtilisasiMesinCucibyLinen(fromdate, todate, jns_linen).Rows.Count > 0 Then
                    Return lDao.DataUtilisasiMesinCucibyLinen(fromdate, todate, jns_linen)
                Else
                    Exit Try
                End If
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
        Public Function DataUtilisasiMesinPengering(ByVal fromdate As String, ByVal todate As String) As System.Data.DataTable Implements IUtilmesinService.DataUtilisasiMesinPengering
            Try
                If lDao.DataUtilisasiMesinPengering(fromdate, todate).Rows.Count > 0 Then
                    Return lDao.DataUtilisasiMesinPengering(fromdate, todate)
                Else
                    Exit Try
                End If
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
        Public Function DataUtilisasiMesinSetrika(ByVal fromdate As String, ByVal todate As String) As System.Data.DataTable Implements IUtilmesinService.DataUtilisasiMesinSetrika
            Try
                If lDao.DataUtilisasiMesinSetrika(fromdate, todate).Rows.Count > 0 Then
                    Return lDao.DataUtilisasiMesinSetrika(fromdate, todate)
                Else
                    Exit Try
                End If
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function DataPenggunaanChemical(ByVal fromdate As String, ByVal todate As String) As System.Data.DataTable Implements IUtilmesinService.DataPenggunaanChemical
            Try
                If lDao.DataPenggunaanChemical(fromdate, todate).Rows.Count > 0 Then
                    Return lDao.DataPenggunaanChemical(fromdate, todate)
                Else
                    Exit Try
                End If
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
    End Class
End Namespace
