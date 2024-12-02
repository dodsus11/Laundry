Imports Ninject
Imports DbLibs
Imports System.ServiceModel
Imports System.Data.SqlClient

Namespace service
    <ServiceContract()>
    Public Interface ILinenService

        <OperationContract()>
        Function getLinenAll() As DataTable

        <OperationContract()>
        Function tampilLinenAktif() As DataTable

        <OperationContract()>
        Sub insertLinen(ByVal go As model.Linen)

        <OperationContract()>
        Sub updateLinen(ByVal go As model.Linen)

        <OperationContract()>
        Sub deleteLinen(ByVal go As model.Linen)

        <OperationContract()>
        Function isExistLinen(ByVal go As model.Linen) As Boolean

        <OperationContract()>
        Function roomLookUp() As DataTable

        <OperationContract()>
        Function AmbilHeaderId() As Integer

        <OperationContract()>
        Sub AddOrder(ByVal header As model.OrderHeader, ByVal item As List(Of model.OrderDetail))

        'service master mesin
        <OperationContract()>
        Function getMasterMesin() As DataTable

        <OperationContract()>
        Sub insertMesin(ByVal go As model.Mesin)

        <OperationContract()>
        Sub updateMesin(ByVal go As model.Mesin)

        <OperationContract()>
        Sub deleteMesin(ByVal go As model.Mesin)

        <OperationContract()>
        Function isExistMesin(ByVal go As model.Mesin) As Boolean

        'service master pembersih
        <OperationContract()>
        Function getMasterPembersih() As DataTable

        <OperationContract()>
        Sub insertPembersih(ByVal go As model.Pembersih)

        <OperationContract()>
        Sub updatePembersih(ByVal go As model.Pembersih)

        <OperationContract()>
        Sub deletePembersih(ByVal go As model.Pembersih)

        <OperationContract()>
        Function isExistPembersih(ByVal go As model.Pembersih) As Boolean

        'service utilisasi mesin
        <OperationContract()>
        Function getUtilMesin() As DataTable

        'service persediaan penambahan stok Linen
        <OperationContract()>
        Function getItemMasuk() As DataTable

        <OperationContract()>
        Function getItemMasukDetail(ByVal headerid As Integer) As DataTable

        <OperationContract()>
        Sub editCancelTransIn(ByVal go As model.TransaksiDelete)

        <OperationContract()>
        Sub insertTransIn(ByVal go As model.TransIn)

        <OperationContract()>
        Function AmbilTransInId() As Integer

        <OperationContract()>
        Sub insertTransInDetail(ByVal item As List(Of model.TransInDetail))

        <OperationContract()>
        Sub editTransIn(ByVal go As model.TransIn)

        <OperationContract()>
        Sub editCancelTransInDetail(ByVal item As List(Of model.TransInDetail))

        <OperationContract()>
        Sub editCancelTransInDetailByTransId(ByVal item As Integer)

        <OperationContract()>
        Sub UpdateJumlahStokPersediaanLinen(ByVal item As List(Of model.Linen))

        <OperationContract()>
        Sub updateJumlahStokLinenIN(ByVal ket As String, ByVal item As List(Of model.Linen))

        <OperationContract()>
        Function cekStokLinenByTransId(ByVal idTransIn As Integer) As Integer

        <OperationContract()>
        Sub penguranganStokLinenByTransId(ByVal idTransIn As Integer)

        'service persediaan pengurangan stok Linen
        <OperationContract()>
        Function getItemKeluar() As DataTable

        <OperationContract()>
        Function getItemKeluarDetail(ByVal headerid As Integer) As DataTable

        <OperationContract()>
        Function LoadDataPerolehanLinen(ByVal kodeLinen As String) As DataTable

        <OperationContract()>
        Function LoadLinenKeluar(ByVal tglfrom As Date, ByVal tglto As Date) As DataTable

        <OperationContract()>
        Function LoadDetailDataLinenRusakbyTanggal(ByVal tgl As Date) As DataTable

        <OperationContract()>
        Sub editCancelTransOut(ByVal go As model.TransaksiDelete)

        '<OperationContract()>
        'Sub cekStokLinenByKodeLinen_jmlLinen(ByVal item As List(Of model.TransOutDetail))

        <OperationContract()>
        Function cekStokLinenByKodeLinen_jmlLinen(ByVal item As List(Of model.TransOutDetail)) As Integer

        <OperationContract()>
        Sub insertTransOut(ByVal go As model.TransOut)

        <OperationContract()>
        Sub insertLinenKeluar(ByVal go As model.TransOut)

        <OperationContract()>
        Sub insertPerolehanLinen(ByVal go As model.PerolehanLinen)

        <OperationContract()>
        Function AmbilTransOutId() As Integer

        <OperationContract()>
        Sub insertTransOutDetail(ByVal item As List(Of model.TransOutDetail))

        <OperationContract()>
        Sub editTransOut(ByVal go As model.TransOut)

        <OperationContract()>
        Sub editCancelTransOutDetail(ByVal item As List(Of model.TransOutDetail))

        <OperationContract()>
        Sub editCancelTransOutDetailByTransId(ByVal item As Integer)

        <OperationContract()>
        Sub penambahanStokLinenByTransId(ByVal idTransOut As Integer)

        <OperationContract()>
        Sub updateJumlahStokLinenOUT(ByVal ket As String, ByVal item As List(Of model.Linen))

        <OperationContract()>
        Function DataStokLinenGudang() As DataTable

    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True,
                      ConcurrencyMode:=ConcurrencyMode.Multiple,
                      InstanceContextMode:=InstanceContextMode.PerCall, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class LinenService
        Implements ILinenService

        Public kernel As IKernel = KernelEngine.ClsKernel.createKernel()
        Public db As ClsDbase
        Public lDao As dao.LinenDao

        Public Sub New()
            db = kernel.Get(Of ClsDbase)()

            lDao = kernel.Get(Of dao.LinenDao)()
            lDao.db = db

        End Sub

        Public Sub deleteLinen(ByVal go As model.Linen) Implements ILinenService.deleteLinen
            Try
                lDao.deleteLinen(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function getLinenAll() As System.Data.DataTable Implements ILinenService.getLinenAll
            Try
                Return lDao.getLinenAll()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function tampilLinenAktif() As System.Data.DataTable Implements ILinenService.tampilLinenAktif
            Try
                Return lDao.tampilLinenAktif()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub insertLinen(ByVal go As model.Linen) Implements ILinenService.insertLinen
            Try
                lDao.insertLinen(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub updateLinen(ByVal go As model.Linen) Implements ILinenService.updateLinen
            Try
                lDao.updateLinen(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        'cek data linen sudah ada atau belum
        Public Function isExistLinen(ByVal go As model.Linen) As Boolean Implements ILinenService.isExistLinen
            Try
                If lDao.existLinen(go).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        'LookUp ruangan
        Public Function roomLookUp() As System.Data.DataTable Implements ILinenService.roomLookUp
            Try
                Return lDao.roomLookUp()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function AmbilHeaderId() As Integer Implements ILinenService.AmbilHeaderId
            Try
                Return lDao.AmbilHeaderId()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub AddOrder(ByVal header As model.OrderHeader, ByVal item As List(Of model.OrderDetail)) Implements ILinenService.AddOrder
            Try
                lDao.AddHeader(header)
                For Each ListItem As model.OrderDetail In item
                    lDao.AddItem(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        'master mesin
        Public Function getMasterMesin() As System.Data.DataTable Implements ILinenService.getMasterMesin
            Try
                Return lDao.getMasterMesin()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub insertMesin(ByVal go As model.Mesin) Implements ILinenService.insertMesin
            Try
                lDao.insertMesin(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub updateMesin(ByVal go As model.Mesin) Implements ILinenService.updateMesin
            Try
                lDao.updateMesin(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub deleteMesin(ByVal go As model.Mesin) Implements ILinenService.deleteMesin
            Try
                lDao.deleteMesin(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function isExistMesin(ByVal go As model.Mesin) As Boolean Implements ILinenService.isExistMesin
            Try
                If lDao.existMesin(go).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        'service master pembersih
        Public Function getMasterPembersih() As System.Data.DataTable Implements ILinenService.getMasterPembersih
            Try
                Return lDao.getMasterPembersih()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub insertPembersih(ByVal go As model.Pembersih) Implements ILinenService.insertPembersih
            Try
                lDao.insertPembersih(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub updatePembersih(ByVal go As model.Pembersih) Implements ILinenService.updatePembersih
            Try
                lDao.updatePembersih(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub deletePembersih(ByVal go As model.Pembersih) Implements ILinenService.deletePembersih
            Try
                lDao.deletePembersih(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function isExistPembersih(ByVal go As model.Pembersih) As Boolean Implements ILinenService.isExistPembersih
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

        'service utilisasi mesin
        Public Function getUtilMesin() As System.Data.DataTable Implements ILinenService.getUtilMesin
            Try
                Return lDao.getUtilMesin()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        'service persediaan penambahan stok linen
        Public Function getItemMasuk() As System.Data.DataTable Implements ILinenService.getItemMasuk
            Try
                Return lDao.getItemMasuk()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getItemMasukDetail(ByVal headerid As Integer) As System.Data.DataTable Implements ILinenService.getItemMasukDetail
            Try
                Return lDao.getItemMasukDetail(headerid)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub editCancelTransIn(ByVal go As model.TransaksiDelete) Implements ILinenService.editCancelTransIn
            Try
                lDao.editCancelTransIn(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub insertTransIn(ByVal go As model.TransIn) Implements ILinenService.insertTransIn
            Try
                lDao.insertTransIn(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function AmbilTransInId() As Integer Implements ILinenService.AmbilTransInId
            Try
                Return lDao.AmbilTransInId()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub insertTransInDetail(ByVal item As List(Of model.TransInDetail)) Implements ILinenService.insertTransInDetail
            Try

                For Each ListItem As model.TransInDetail In item
                    lDao.insertTransInDetail(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub editTransIn(ByVal go As model.TransIn) Implements ILinenService.editTransIn
            Try
                lDao.editTransIn(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub editCancelTransInDetail(ByVal item As List(Of model.TransInDetail)) Implements ILinenService.editCancelTransInDetail
            Try
                For Each listitem As model.TransInDetail In item
                    lDao.editCancelTransInDetail(listitem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub editCancelTransInDetailByTransId(ByVal item As Integer) Implements ILinenService.editCancelTransInDetailByTransId
            Try
                lDao.editCancelTransInDetailByTransId(item)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub UpdateJumlahStokPersediaanLinen(ByVal item As List(Of model.Linen)) Implements ILinenService.UpdateJumlahStokPersediaanLinen
            Try
                For Each listItem As model.Linen In item
                    lDao.UpdateJumlahStokPersediaanLinen(listItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub updateJumlahStokLinenIN(ByVal ket As String, ByVal item As List(Of model.Linen)) Implements ILinenService.updateJumlahStokLinenIN
            Try
                If ket = "kredit" Then
                    For Each ListItem As model.Linen In item
                        lDao.penambahanJumlahStokLinenIN(ListItem)
                    Next
                Else
                    For Each ListItem As model.Linen In item
                        lDao.penguranganJumlahStokLinenIN(ListItem)
                    Next
                End If

            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function cekStokLinenByTransId(ByVal idTransIn As Integer) As Integer Implements ILinenService.cekStokLinenByTransId
            Try
                Return lDao.cekStokLinenByTransId(idTransIn)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub penguranganStokLinenByTransId(ByVal idTransIn As Integer) Implements ILinenService.penguranganStokLinenByTransId
            Try
                lDao.penguranganStokLinenByTransId(idTransIn)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        'service persediaan pengurangan stok linen
        Public Function getItemKeluar() As System.Data.DataTable Implements ILinenService.getItemKeluar
            Try
                Return lDao.getItemKeluar()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function getItemKeluarDetail(ByVal headerid As Integer) As System.Data.DataTable Implements ILinenService.getItemKeluarDetail
            Try
                Return lDao.getItemKeluarDetail(headerid)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function
        Public Function LoadLinenKeluar(ByVal tglfrom As Date, ByVal tglto As Date) As System.Data.DataTable Implements ILinenService.LoadLinenKeluar
            Try
                Return lDao.LoadLinenKeluar(tglfrom, tglto)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function LoadDetailDataLinenRusakbyTanggal(ByVal tgl As Date) As System.Data.DataTable Implements ILinenService.LoadDetailDataLinenRusakbyTanggal
            Try
                Return lDao.LoadDetailDataLinenRusakbyTanggal(tgl)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function LoadDataPerolehanLinen(ByVal kodeLinen As String) As System.Data.DataTable Implements ILinenService.LoadDataPerolehanLinen
            Try
                Return lDao.LoadDataPerolehanLinen(kodeLinen)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub editCancelTransOut(ByVal go As model.TransaksiDelete) Implements ILinenService.editCancelTransOut
            Try
                lDao.editCancelTransOut(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function cekStokLinenByKodeLinen_jmlLinen(ByVal item As List(Of model.TransOutDetail)) As Integer Implements ILinenService.cekStokLinenByKodeLinen_jmlLinen
            Try
                Dim ket As Integer
                Dim jmlerror As Integer
                jmlerror = 0
                For Each ListItem As model.TransOutDetail In item
                    ket = lDao.cekStokLinenByKodeLinen_jmlLinen(ListItem)
                    If ket = 1 Then
                        jmlerror = jmlerror + 1
                    End If
                Next
                Return jmlerror
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub insertTransOut(ByVal go As model.TransOut) Implements ILinenService.insertTransOut
            Try
                lDao.insertTransOut(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub
        Public Sub insertLinenKeluar(ByVal go As model.TransOut) Implements ILinenService.insertLinenKeluar
            Try
                lDao.insertLinenOut(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub
        Public Sub insertPerolehanLinen(ByVal go As model.PerolehanLinen) Implements ILinenService.insertPerolehanLinen
            Try
                lDao.insertPerolehanLInen(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function AmbilTransOutId() As Integer Implements ILinenService.AmbilTransOutId
            Try
                Return lDao.AmbilTransOutId()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Sub insertTransOutDetail(ByVal item As List(Of model.TransOutDetail)) Implements ILinenService.insertTransOutDetail
            Try

                For Each ListItem As model.TransOutDetail In item
                    lDao.insertTransOutDetail(ListItem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub editTransOut(ByVal go As model.TransOut) Implements ILinenService.editTransOut
            Try
                lDao.editTransOut(go)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub editCancelTransOutDetail(ByVal item As List(Of model.TransOutDetail)) Implements ILinenService.editCancelTransOutDetail
            Try
                For Each listitem As model.TransOutDetail In item
                    lDao.editCancelTransOutDetail(listitem)
                Next
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub editCancelTransOutDetailByTransId(ByVal item As Integer) Implements ILinenService.editCancelTransOutDetailByTransId
            Try
                lDao.editCancelTransOutDetailByTransId(item)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub penambahanStokLinenByTransId(ByVal idTransOut As Integer) Implements ILinenService.penambahanStokLinenByTransId
            Try
                lDao.penambahanStokLinenByTransId(idTransOut)
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Sub updateJumlahStokLinenOUT(ByVal ket As String, ByVal item As List(Of model.Linen)) Implements ILinenService.updateJumlahStokLinenOUT
            Try
                If ket = "kredit" Then
                    For Each ListItem As model.Linen In item
                        lDao.penambahanJumlahStokLinenOUT(ListItem)
                    Next
                Else
                    For Each ListItem As model.Linen In item
                        lDao.penguranganJumlahStokLinenOUT(ListItem)
                    Next
                End If

            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Sub

        Public Function DataStokLinenGudang() As System.Data.DataTable Implements ILinenService.DataStokLinenGudang
            Try
                Return lDao.DataStokLinenGudang()
            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

    End Class
End Namespace
