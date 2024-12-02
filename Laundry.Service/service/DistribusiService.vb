Imports Ninject
Imports DbLibs
Imports System.ServiceModel

Namespace service
    <ServiceContract()>
    Public Interface IDistribusiService

        <OperationContract()>
        Function getOrderHeader(tgl) As DataTable

        <OperationContract()>
        Function getOrderHeaderRange(tglmulai, tglselesai) As DataTable

        <OperationContract()>
        Function getOrderDetail(ByVal headerid As Integer) As DataTable

        '<OperationContract()>
        'Sub EditHeader(ByVal headerid As Integer)

        <OperationContract()>
        Function EditHeaderFlag(ByVal headerid As Integer) As Integer

        <OperationContract()>
        Sub EditOrder(ByVal item As List(Of model.OrderDetail))

        '<OperationContract()>
        'Function AmbilHeaderId() As Integer

        '<OperationContract()>
        'Function AmbilIdRuang(ByVal ruang As String) As String

        <OperationContract()>
        Sub UpdateStokGudangUtama(ByVal item As List(Of model.Linen))

        <OperationContract()>
        Function AmbilIndexPerHeaderId(ByVal headerid As Integer, ByVal linen As String) As Integer

        <OperationContract()>
        Sub AddHistoryDistribusi(ByVal distribusi As List(Of model.OrderDistribusi))

        <OperationContract()>
        Function tampilHistory(ByVal idorder As Integer) As DataTable
    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True,
                      ConcurrencyMode:=ConcurrencyMode.Multiple,
                      InstanceContextMode:=InstanceContextMode.PerCall, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class DistribusiService
        Implements IDistribusiService

        Public kernel As IKernel = KernelEngine.ClsKernel.createKernel()
        Public db As ClsDbase
        Public lDao As dao.DistribusiDao

        Public Sub New()
            db = kernel.Get(Of ClsDbase)()

            lDao = kernel.Get(Of dao.DistribusiDao)()
            lDao.db = db

        End Sub

        Public Function getOrderHeader(ByVal tgl) As System.Data.DataTable Implements IDistribusiService.getOrderHeader
            Try
                Return lDao.getOrderHeader(tgl)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getOrderHeaderRange(ByVal tglmulai, ByVal tglselesai) As System.Data.DataTable Implements IDistribusiService.getOrderHeaderRange
            Try
                Return lDao.getOrderHeaderRange(tglmulai, tglselesai)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getOrderDetail(ByVal headerid As Integer) As System.Data.DataTable Implements IDistribusiService.getOrderDetail
            Try
                Return lDao.getOrderDetail(headerid)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        'Public Sub EditHeader(ByVal headerid As Integer) Implements IDistribusiService.EditHeader
        '    Try
        '        lDao.EditHeader(headerid)
        '    Catch ex As Exception
        '        Throw New FaultException(ex.Message)
        '    End Try
        'End Sub

        Public Function EditHeaderFlag(ByVal headerid As Integer) As Integer Implements IDistribusiService.EditHeaderFlag
            Try
                Return lDao.EditHeaderFlag(headerid)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub EditOrder(ByVal item As List(Of model.OrderDetail)) Implements IDistribusiService.EditOrder
            Try

                For Each ListItem As model.OrderDetail In item
                    lDao.EditItem(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        'Public Function AmbilHeaderId() As Integer Implements IDistribusiService.AmbilHeaderId
        '    Try
        '        Return lDao.AmbilHeaderId()
        '    Catch ex As Exception
        '        Throw New FaultException(ex.Message)
        '    End Try
        'End Function

        'Public Function AmbilIdRuang(ByVal ruang As String) As String Implements IDistribusiService.AmbilIdRuang
        '    Try
        '        Return lDao.AmbilIdRuang(ruang)
        '    Catch ex As Exception
        '        Throw New FaultException(ex.Message)
        '    End Try
        'End Function

        Public Sub UpdateStokGudangUtama(ByVal item As List(Of model.Linen)) Implements IDistribusiService.UpdateStokGudangUtama
            Try
                For Each ListItem As model.Linen In item
                    lDao.UpdateStokGudangUtama(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function AmbilIndexPerHeaderId(ByVal headerid As Integer, ByVal linen As String) As Integer Implements IDistribusiService.AmbilIndexPerHeaderId
            Try
                Return lDao.AmbilIndexPerHeaderId(headerid, linen)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub AddHistoryDistribusi(ByVal distribusi As List(Of model.OrderDistribusi)) Implements IDistribusiService.AddHistoryDistribusi
            Try
                For Each ListItem As model.OrderDistribusi In distribusi
                    lDao.AddHistoryDistribusi(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function tampilHistory(ByVal idorder As Integer) As System.Data.DataTable Implements IDistribusiService.tampilHistory
            Try
                Return lDao.tampilHistory(idorder)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
    End Class
End Namespace
