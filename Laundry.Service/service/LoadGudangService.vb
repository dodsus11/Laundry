Imports Ninject
Imports DbLibs
Imports System.ServiceModel

Namespace service
    <ServiceContract()>
    Public Interface ILoadGudangService

        <OperationContract()>
        Function getLoadgudangHeader(tglawal, tglakhir) As DataTable

        <OperationContract()>
        Function getLoadgudangDetail(ByVal headerid As Integer) As DataTable

        <OperationContract()>
        Sub deleteLoadgudangHeader(ByVal go As model.LoadGudangHeader)

        <OperationContract()>
        Sub deleteLoadgudangDetail(ByVal item As List(Of model.LoadGudangDetail))

        <OperationContract()>
        Sub AddLoadgudangHeader(ByVal header As model.LoadGudangHeader)

        <OperationContract()>
        Sub EditLoadgudangHeader(ByVal header As model.LoadGudangHeader)

        <OperationContract()>
        Sub EditLoadgudangHeaderJmlJnsLinen(ByVal header As Integer, ByVal jml As Integer)

        <OperationContract()>
        Sub AddItemLoadgudang(ByVal item As List(Of model.LoadGudangDetail))

        <OperationContract()>
        Sub EditItemLoadgudang(ByVal item As List(Of model.LoadGudangDetail))

        <OperationContract()>
        Function AmbilHeaderId() As Integer

        <OperationContract()>
        Sub AddStokGudangUtama(ByVal item As List(Of model.Linen))

        <OperationContract()>
        Sub EditStokGudangUtama(ByVal item As List(Of model.Linen))

        <OperationContract()>
        Function cekStokLinenByKodeLinen_jmlLinen(ByVal kdlinen As String, ByVal jml As Integer) As Integer

        <OperationContract()>
        Function cekStokLinenByIdLoadGudang(ByVal idLoadGudang As Integer) As Integer

        <OperationContract()>
        Sub penguranganStokLinenByIdLoadGudang(ByVal idLoadGudang As Integer)

        <OperationContract()>
        Sub editFlagCancelLoadGudangByIdLoadGudang(ByVal idloadgudang As Integer)
        
    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True,
                      ConcurrencyMode:=ConcurrencyMode.Multiple,
                      InstanceContextMode:=InstanceContextMode.PerCall, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class LoadGudangService
        Implements ILoadGudangService

        Public kernel As IKernel = KernelEngine.ClsKernel.createKernel()
        Public db As ClsDbase
        Public lDao As dao.LoadgudangDao

        Public Sub New()
            db = kernel.Get(Of ClsDbase)()

            lDao = kernel.Get(Of dao.LoadgudangDao)()
            lDao.db = db

        End Sub

        'order service
        Public Function getLoadgudangHeader(ByVal tglawal, ByVal tglakhir) As System.Data.DataTable Implements ILoadGudangService.getLoadgudangHeader
            Try
                Return lDao.getLoadgudangHeader(tglawal, tglakhir)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getLoadgudangDetail(ByVal headerid As Integer) As System.Data.DataTable Implements ILoadGudangService.getLoadgudangDetail
            Try
                Return lDao.getLoadgudangDetail(headerid)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub deleteLoadgudangHeader(ByVal go As model.LoadGudangHeader) Implements ILoadGudangService.deleteLoadgudangHeader
            Try
                lDao.deleteLoadgudangHeader(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub deleteLoadgudangDetail(ByVal item As List(Of model.LoadGudangDetail)) Implements ILoadGudangService.deleteLoadgudangDetail
            Try
                For Each ListItem As model.LoadGudangDetail In item
                    lDao.deleteLoadgudangDetail(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub AddLoadgudangHeader(ByVal header As model.LoadGudangHeader) Implements ILoadGudangService.AddLoadgudangHeader
            Try
                lDao.AddLoadgudangHeader(header)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub EditLoadgudangHeader(ByVal header As model.LoadGudangHeader) Implements ILoadGudangService.EditLoadgudangHeader
            Try
                lDao.EditLoadgudangHeader(header)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub EditLoadgudangHeaderJmlJnsLinen(ByVal header As Integer, ByVal jml As Integer) Implements ILoadGudangService.EditLoadgudangHeaderJmlJnsLinen
            Try
                lDao.EditLoadgudangHeaderJmlJnsLinen(header, jml)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub AddItemLoadgudang(ByVal item As List(Of model.LoadGudangDetail)) Implements ILoadGudangService.AddItemLoadgudang
            Try
                For Each ListItem As model.LoadGudangDetail In item
                    lDao.AddItemLoadgudang(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub EditItemLoadgudang(ByVal item As List(Of model.LoadGudangDetail)) Implements ILoadGudangService.EditItemLoadgudang
            Try

                For Each ListItem As model.LoadGudangDetail In item
                    lDao.EditItemLoadgudang(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function AmbilHeaderId() As Integer Implements ILoadGudangService.AmbilHeaderId
            Try
                Return lDao.AmbilHeaderId()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub AddStokGudangUtama(ByVal item As List(Of model.Linen)) Implements ILoadGudangService.AddStokGudangUtama
            Try
                For Each ListItem As model.Linen In item
                    lDao.AddStokGudangUtama(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub EditStokGudangUtama(ByVal item As List(Of model.Linen)) Implements ILoadGudangService.EditStokGudangUtama
            Try
                For Each ListItem As model.Linen In item
                    lDao.EditStokGudangUtama(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function cekStokLinenByKodeLinen_jmlLinen(ByVal kdlinen As String, ByVal jml As Integer) As Integer Implements ILoadGudangService.cekStokLinenByKodeLinen_jmlLinen
            Try
                Return lDao.cekStokLinenByKodeLinen_jmlLinen(kdlinen, jml)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function cekStokLinenByIdLoadGudang(ByVal idLoadGudang As Integer) As Integer Implements ILoadGudangService.cekStokLinenByIdLoadGudang
            Try
                Return lDao.cekStokLinenByIdLoadGudang(idLoadGudang)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub penguranganStokLinenByIdLoadGudang(ByVal idLoadGudang As Integer) Implements ILoadGudangService.penguranganStokLinenByIdLoadGudang
            Try
                lDao.penguranganStokLinenByIdLoadGudang(idLoadGudang)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub editFlagCancelLoadGudangByIdLoadGudang(ByVal idloadgudang As Integer) Implements ILoadGudangService.editFlagCancelLoadGudangByIdLoadGudang
            Try
                lDao.editFlagCancelLoadGudangByIdLoadGudang(idloadgudang)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

    End Class
End Namespace
