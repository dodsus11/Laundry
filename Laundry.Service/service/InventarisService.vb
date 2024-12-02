
Imports Ninject
Imports DbLibs
Imports System.ServiceModel
Imports System.Data.SqlClient

Namespace service
    <ServiceContract()>
    Public Interface IInventarisService
        
        <OperationContract()>
        Function roomLookUp() As DataTable
        <OperationContract()>
        Function InstLookUp() As DataTable
        <OperationContract()>
        Function LoadDatabyRuang(ByVal kodeRuang As Object) As DataTable
        <OperationContract()>
        Function AmbilNomerOrder() As String
        <OperationContract()>
        Sub InsertDataInventaris(ByVal data As List(Of model.OrderInventaris))
        <OperationContract()>
        Sub IncrementNomerInventaris()
        <OperationContract()>
        Function LoadDetailINV(ByVal no_inv As Object) As DataTable
        <OperationContract()>
        Sub NonAktif_data(ByVal HapusDtInv As List(Of model.OrderInventaris))
        <OperationContract()>
        Function AmbilIdRuang(ByVal ruang As String) As String
        <OperationContract()>
        Function AmbilIdInstalasi(ByVal instalasi As String) As String
        <OperationContract()>
        Function isExistLinen(ByVal go As model.OrderInventaris) As Boolean
        <OperationContract()>
        Sub Delete_inventori(ByVal go As model.OrderInventaris)
    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True,
                 ConcurrencyMode:=ConcurrencyMode.Multiple,
                 InstanceContextMode:=InstanceContextMode.PerCall, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class InventarisService
        Implements IInventarisService

        Public kernel As IKernel = KernelEngine.ClsKernel.createKernel()
        Public db As ClsDbase
        Public lDao As dao.inventarisDAO

        Public Sub New()
            db = kernel.Get(Of ClsDbase)()

            lDao = kernel.Get(Of dao.inventarisDAO)()
            lDao.db = db

        End Sub

        Public Function LoadDatabyRuang(ByVal kodeRuang As Object) As System.Data.DataTable Implements IInventarisService.LoadDatabyRuang
            Try
                Return lDao.LoadData(kodeRuang)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
        Public Function AmbilNomerOrder() As String Implements IInventarisService.AmbilNomerOrder
            Try
                Return lDao.AmbilNomerOrder()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
        Public Sub InsertDataInventaris(ByVal data As List(Of model.OrderInventaris)) Implements IInventarisService.InsertDataInventaris
            Try
                For Each ListItem As model.OrderInventaris In data
                    lDao.InsertDataInventaris(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub
        Public Sub NonAktif_Data(ByVal HapusDtInv As List(Of model.OrderInventaris)) Implements IInventarisService.NonAktif_data
            Try
                For Each ListItem As model.OrderInventaris In HapusDtInv
                    lDao.NonAktif_data(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub
        Sub IncrementNomerOrder() Implements IInventarisService.IncrementNomerInventaris
            Try
                lDao.IncrementNomerInventaris()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function roomLookUp() As System.Data.DataTable Implements IInventarisService.roomLookUp
            Try
                Return lDao.roomLookUp()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
        Public Function InstLookUp() As System.Data.DataTable Implements IInventarisService.InstLookUp
            Try
                Return lDao.InstLookUp()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
        Public Function LoadDetailINV(ByVal no_inv As Object) As System.Data.DataTable Implements IInventarisService.LoadDetailINV
            Try
                Return lDao.LoadDtlInventaris(no_inv)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
        Public Function AmbilIdRuang(ByVal ruang As String) As String Implements IInventarisService.AmbilIdRuang
            Try
                Return lDao.AmbilIdRuang(ruang)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
        Public Function AmbilIdInstalasi(ByVal instalasi As String) As String Implements IInventarisService.AmbilIdInstalasi
            Try
                Return lDao.AmbilIdInstalasi(instalasi)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
        Public Function isExistLinen(ByVal go As model.OrderInventaris) As Boolean Implements IInventarisService.isExistLinen
            Try
                If lDao.CekExistLinen(go).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
        Public Sub Delete_inventori(ByVal go As model.OrderInventaris) Implements IInventarisService.Delete_inventori
            Try

                lDao.Delete_inventori(go)

            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub
    End Class
End Namespace

