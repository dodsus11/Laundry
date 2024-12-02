Imports Ninject
Imports DbLibs
Imports System.ServiceModel

Namespace service
    <ServiceContract()>
    Public Interface IUtilmesinSetrikaService

        'service utilisasi mesin
        <OperationContract()>
        Function getUtilMesinSetrika(tgl) As DataTable

        <OperationContract()>
        Sub insertUtilMesinSetrika(ByVal go As model.Util_Mesin_Setrika)

        <OperationContract()>
        Function AmbilIdUtilSetrika() As Integer

        <OperationContract()>
        Sub AddDetailUtilSetrika(ByVal item As List(Of model.Util_Mesin_Setrika))

        <OperationContract()>
        Sub insertUtilMesinSetrikaHeader(ByVal go As model.Util_Mesin_Setrika)

        <OperationContract()>
        Sub updateUtilMesinSetrikaHeader(ByVal go As model.Util_Mesin_Setrika)

        <OperationContract()>
        Sub updateUtilMesinSetrika(ByVal go As model.Util_Mesin_Setrika)

        <OperationContract()>
        Sub deleteUtilMesinSetrika(ByVal go As model.Util_Mesin_Setrika)

        <OperationContract()>
        Sub deleteDetailUtilMesinSetrika(ByVal go As model.Util_Mesin_Setrika)

        <OperationContract()>
        Function lookupPegawai() As DataTable

        <OperationContract()>
        Function cariTglSekarang(ByVal tgl As Date, ByVal mesin As String) As Boolean

        <OperationContract()>
        Function ambilLoad(ByVal tgl As Date, ByVal mesin As String) As Integer

        <OperationContract()>
        Function getMesinSetrika(ByVal item As model.Mesin) As DataTable

        <OperationContract()>
        Function ambilIdPegawai(ByVal nama As String) As Integer

        <OperationContract()>
        Function getLinenTiapMesinSetrika(ByVal mesin As String, ByVal linen As String, ByVal tglAwal As Date, ByVal tglAkhir As Date) As DataTable

        <OperationContract()>
        Function getUtilMesinSetrikaDetail(ByVal id As Int32) As DataTable
    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True,
                      ConcurrencyMode:=ConcurrencyMode.Multiple,
                      InstanceContextMode:=InstanceContextMode.PerCall, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class UtilmesinSetrikaService
        Implements IUtilmesinSetrikaService

        Public kernel As IKernel = KernelEngine.ClsKernel.createKernel()
        Public db As ClsDbase
        Public lDao As dao.UtilmesinsetrikaDao

        Public Sub New()
            db = kernel.Get(Of ClsDbase)()

            lDao = kernel.Get(Of dao.UtilmesinsetrikaDao)()
            lDao.db = db

        End Sub

        'service utilisasi mesin setrika
        Public Function getUtilMesinSetrika(tgl) As System.Data.DataTable Implements IUtilmesinSetrikaService.getUtilMesinSetrika
            Try
                Return lDao.getUtilMesinSetrika(tgl)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub insertUtilMesinSetrika(go As model.Util_Mesin_Setrika) Implements IUtilmesinSetrikaService.insertUtilMesinSetrika
            Try
                lDao.insertUtilMesinSetrika(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub insertUtilMesinSetrikaHeader(go As model.Util_Mesin_Setrika) Implements IUtilmesinSetrikaService.insertUtilMesinSetrikaHeader
            Try
                lDao.insertUtilMesinSetrikaHeader(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub updateUtilMesinSetrikaHeader(go As model.Util_Mesin_Setrika) Implements IUtilmesinSetrikaService.updateUtilMesinSetrikaHeader
            Try
                lDao.updateUtilMesinSetrikaHeader(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function AmbilIdUtilSetrika() As Integer Implements IUtilmesinSetrikaService.AmbilIdUtilSetrika
            Try
                Return lDao.AmbilIdUtilSetrika()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub AddDetailUtilSetrika(ByVal item As List(Of model.Util_Mesin_Setrika)) Implements IUtilmesinSetrikaService.AddDetailUtilSetrika
            Try

                For Each ListItem As model.Util_Mesin_Setrika In item
                    lDao.AddDetailUtilSetrika(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub updateUtilMesinSetrika(go As model.Util_Mesin_Setrika) Implements IUtilmesinSetrikaService.updateUtilMesinSetrika
            Try
                lDao.updateUtilMesinSetrika(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub deleteUtilMesinSetrika(go As model.Util_Mesin_Setrika) Implements IUtilmesinSetrikaService.deleteUtilMesinSetrika
            Try
                lDao.deleteUtilMesinSetrika(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub deleteDetailUtilMesinSetrika(go As model.Util_Mesin_Setrika) Implements IUtilmesinSetrikaService.deleteDetailUtilMesinSetrika
            Try
                lDao.deleteDetailUtilMesinSetrika(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function lookupPegawai() As System.Data.DataTable Implements IUtilmesinSetrikaService.lookupPegawai
            Try
                Return lDao.lookupPegawai()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function cariTglSekarang(ByVal tgl As Date, ByVal mesin As String) As Boolean Implements IUtilmesinSetrikaService.cariTglSekarang
            Try
                If lDao.cariTglSekarang(tgl, mesin).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ambilLoad(ByVal tgl As Date, ByVal mesin As String) As Integer Implements IUtilmesinSetrikaService.ambilLoad
            Try
                Return lDao.ambilLoad(tgl, mesin)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getMesinSetrika(ByVal item As model.Mesin) As System.Data.DataTable Implements IUtilmesinSetrikaService.getMesinSetrika
            Try
                Return lDao.getMesinSetrika(item)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ambilIdPegawai(ByVal nama As String) As Integer Implements IUtilmesinSetrikaService.ambilIdPegawai
            Try
                Return lDao.ambilIdPegawai(nama)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getLinenTiapMesinSetrika(ByVal mesin As String, ByVal linen As String, ByVal tglAwal As Date, ByVal tglAkhir As Date) As System.Data.DataTable Implements IUtilmesinSetrikaService.getLinenTiapMesinSetrika
            Try
                Return lDao.getLinenTiapMesinSetrika(mesin, linen, tglAwal, tglAkhir)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getUtilMesinSetrikaDetail(ByVal id As Int32) As System.Data.DataTable Implements IUtilmesinSetrikaService.getUtilMesinSetrikaDetail
            Try
                Return lDao.getUtilMesinSetrikaDetail(id)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
    End Class
End Namespace
