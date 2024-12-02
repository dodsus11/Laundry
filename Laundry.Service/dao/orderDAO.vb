Imports DbLibs

Namespace dao
    Public Class OrderDao
        Public Property db As ClsDbase

        Public Function getOrderHeader(tglawal, tglakhir) As DataTable
            Try
                'Dim dt As DataTable = db.execQuery("LON_TampilOrderHeaderAll_New", New Object() {tglawal, tglakhir})
                Dim dt As DataTable = db.execQuery("LON_TampilOrderHeaderAll_New_rev1", New Object() {tglawal, tglakhir})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getOrderDetail(ByVal headerid As Integer) As DataTable
            Try

                Dim dt As DataTable = db.execQuery("LON_TampilDetailOrderPerHeader", New Object() {headerid})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub deleteOrderHeader(ByVal group As model.OrderHeader)
            Try
                db.execUpdate("LON_UpdateFlagOrderHeader", New Object() {group.headerId, group.flag})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub deleteOrderDetail(ByVal item As model.OrderDetail)
            Try
                db.execQuery("LON_UpdateFlagOrderDetail", New Object() {
                                   item.detailId,
                                   item.flag})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function roomLookUp() As DataTable
            Try
                'Dim dt As DataTable = db.execQuery("LON_DepartSelect")
                Dim dt As DataTable = db.execQuery("LON_LOAD_RUANG")

                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function InstalasiLookUp() As DataTable
            Try

                Dim dt As DataTable = db.execQuery("LON_LoadInstalasi")

                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub AddHeader(ByVal head As model.OrderHeader)
            Try
                db.execQuery("LON_AddHeader", New Object() {
                                   head.orderNo,
                                   head.ruang,
                                   head.subRuang,
                                   head.namaPegawai,
                                   head.pegawaiLaundy,
                                   head.tanggal,
                                   head.jam,
                                   head.flag})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub EditHeader(ByVal head As model.OrderHeader)
            Try
                db.execQuery("LON_EditHeader", New Object() {
                                   head.headerId,
                                   head.ruang,
                                   head.subRuang,
                                   head.namaPegawai,
                                   head.pegawaiLaundy})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub AddItem(ByVal item As model.OrderDetail)
            Try
                db.execQuery("LON_AddOrderDetail", New Object() {
                                   item.headerId,
                                   item.linen,
                                   item.qtyNon,
                                   item.qtyInf,
                                   item.berat,
                                   item.flag})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub EditItem(ByVal item As model.OrderDetail)
            Try
                db.execQuery("LON_EditOrderDetail", New Object() {
                                   item.detailId,
                                   item.linen,
                                   item.jenis,
                                   item.material,
                                   item.qty})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function AmbilHeaderId() As Integer
            Try
                Dim id As Integer
                'Dim idx As String
                Dim dt As DataTable = db.execQuery("LON_AmbilNoHeader")
                id = dt.Rows(0)(0)
                If IsDBNull(id) Then
                    id = 0
                End If
                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function AmbilIdRuang(ByVal ruang As String) As String
            Try
                Dim id As String
                'Dim idx As String
                Dim dt As DataTable = db.execQuery("LON_AmbilIdRuang_rev1", New Object() {ruang})
                id = dt.Rows(0)(0)
                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function AmbilNomerOrder() As String
            Try
                Dim id As String
                'Dim idx As String
                Dim dt As DataTable = db.execQuery("LON_AmbilNomerOrder")
                id = dt.Rows(0)(0)
                'If IsDBNull(id) Then
                '    id = 0
                'End If
                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub IncrementNomerOrder()
            Try
                db.execQuery("LON_IncrementNomerOrder", New Object())
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getHistoryOrderHeader(ByVal tgl As Date, ByVal ruang As String) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilOrderHeaderHistory", New Object() {tgl, ruang})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function LoadData(ByVal kodeRuang As Object) As DataTable
            Throw New NotImplementedException
        End Function

    End Class
End Namespace
