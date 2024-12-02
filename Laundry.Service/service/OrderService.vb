Imports Ninject
Imports DbLibs
Imports System.ServiceModel

Namespace service
    <ServiceContract()>
    Public Interface IOrderService

        <OperationContract()>
        Function getOrderHeader(tglawal, tglakhir) As DataTable

        <OperationContract()>
        Function getOrderDetail(ByVal headerid As Integer) As DataTable

        <OperationContract()>
        Sub deleteOrderHeader(ByVal go As model.OrderHeader)

        <OperationContract()>
        Sub deleteOrderDetail(ByVal item As List(Of model.OrderDetail))

        <OperationContract()>
        Function roomLookUp() As DataTable

        <OperationContract()>
        Function InstalasiLookUp() As DataTable

        <OperationContract()>
        Function AmbilHeaderId() As Integer

        <OperationContract()>
        Function AmbilIdRuang(ByVal ruang As String) As String

        '<OperationContract()>
        'Sub AddOrder(ByVal header As model.OrderHeader, ByVal item As List(Of model.OrderDetail))

        <OperationContract()>
        Sub AddHeader(ByVal header As model.OrderHeader)

        <OperationContract()>
        Sub EditHeader(ByVal header As model.OrderHeader)

        <OperationContract()>
        Sub AddOrder(ByVal item As List(Of model.OrderDetail))

        <OperationContract()>
        Sub EditOrder(ByVal item As List(Of model.OrderDetail))

        <OperationContract()>
        Function AmbilNomerOrder() As String

        <OperationContract()>
        Sub IncrementNomerOrder()

        <OperationContract()>
        Function getHistoryOrderHeader(ByVal tgl As Date, ByVal ruang As String) As DataTable
    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True,
                      ConcurrencyMode:=ConcurrencyMode.Multiple,
                      InstanceContextMode:=InstanceContextMode.PerCall, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class OrderService
        Implements IOrderService

        Public kernel As IKernel = KernelEngine.ClsKernel.createKernel()
        Public db As ClsDbase
        Public lDao As dao.OrderDao

        Public Sub New()
            db = kernel.Get(Of ClsDbase)()

            lDao = kernel.Get(Of dao.OrderDao)()
            lDao.db = db

        End Sub

        'order service
        Public Function getOrderHeader(ByVal tglawal, ByVal tglakhir) As System.Data.DataTable Implements IOrderService.getOrderHeader
            Try
                Return lDao.getOrderHeader(tglawal, tglakhir)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getOrderDetail(ByVal headerid As Integer) As System.Data.DataTable Implements IOrderService.getOrderDetail
            Try
                Return lDao.getOrderDetail(headerid)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub deleteOrderHeader(ByVal go As model.OrderHeader) Implements IOrderService.deleteOrderHeader
            Try
                lDao.deleteOrderHeader(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        'Public Sub deleteOrderDetail(go As model.OrderDetail) Implements IOrderService.deleteOrderDetail
        '    Try
        '        lDao.deleteOrderDetail(go)
        '    Catch ex As Exception
        '        Throw New FaultException(ex.Message)
        '    End Try
        'End Sub

        Public Sub deleteOrderDetail(ByVal item As List(Of model.OrderDetail)) Implements IOrderService.deleteOrderDetail
            Try
                For Each ListItem As model.OrderDetail In item
                    lDao.deleteOrderDetail(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function roomLookUp() As System.Data.DataTable Implements IOrderService.roomLookUp
            Try
                Return lDao.roomLookUp()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
        Public Function InstalasiLookUp() As System.Data.DataTable Implements IOrderService.InstalasiLookUp
            Try
                Return lDao.InstalasiLookUp()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function AmbilHeaderId() As Integer Implements IOrderService.AmbilHeaderId
            Try
                Return lDao.AmbilHeaderId()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function AmbilIdRuang(ByVal ruang As String) As String Implements IOrderService.AmbilIdRuang
            Try
                Return lDao.AmbilIdRuang(ruang)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub AddHeader(ByVal header As model.OrderHeader) Implements IOrderService.AddHeader
            Try
                lDao.AddHeader(header)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub EditHeader(ByVal header As model.OrderHeader) Implements IOrderService.EditHeader
            Try
                lDao.EditHeader(header)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub AddOrder(ByVal item As List(Of model.OrderDetail)) Implements IOrderService.AddOrder
            Try

                For Each ListItem As model.OrderDetail In item
                    lDao.AddItem(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub EditOrder(ByVal item As List(Of model.OrderDetail)) Implements IOrderService.EditOrder
            Try

                For Each ListItem As model.OrderDetail In item
                    lDao.EditItem(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function AmbilNomerOrder() As String Implements IOrderService.AmbilNomerOrder
            Try
                Return lDao.AmbilNomerOrder()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Sub IncrementNomerOrder() Implements IOrderService.IncrementNomerOrder
            Try
                lDao.IncrementNomerOrder()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function getHistoryOrderHeader(ByVal tgl As Date, ByVal ruang As String) As System.Data.DataTable Implements IOrderService.getHistoryOrderHeader
            Try
                Return lDao.getHistoryOrderHeader(tgl, ruang)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
    End Class
End Namespace
