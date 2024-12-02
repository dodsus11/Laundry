Imports DbLibs

Namespace dao
    Public Class LoadgudangDao
        Public Property db As ClsDbase

        Public Function getLoadgudangHeader(tglawal, tglakhir) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilLoadGudangHeaderAll_New", New Object() {tglawal, tglakhir})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getLoadgudangDetail(ByVal headerid As Integer) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilLoadgudangDetailPerHeader", New Object() {headerid})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub deleteLoadgudangHeader(ByVal group As model.LoadGudangHeader)
            Try
                db.execUpdate("LON_UpdateFlagLoadgudangHeader", New Object() {group.idHeaderLoadGudang, group.flag})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub deleteLoadgudangDetail(ByVal group As model.LoadGudangDetail)
            Try
                db.execUpdate("LON_UpdateFlagLoadgudangDetail", New Object() {group.idDetailLoadGudang, group.flag})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub AddLoadgudangHeader(ByVal header As model.LoadGudangHeader)
            Try
                db.execQuery("LON_AddLoadgudangHeader", New Object() {
                                   header.namaPetugas,
                                   header.tanggal,
                                   header.jam,
                                   header.jmlJenisLinen,
                                   header.flag})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub EditLoadgudangHeader(ByVal head As model.LoadGudangHeader)
            Try
                db.execQuery("LON_EditLoadgudangHeader", New Object() {
                                   head.idHeaderLoadGudang,
                                   head.namaPetugas,
                                   head.jmlJenisLinen})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub EditLoadgudangHeaderJmlJnsLinen(ByVal head As Integer, ByVal jml As Integer)
            Try
                db.execQuery("LON_EditLoadgudangHeaderJmlJnsLinen", New Object() {head, jml})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub AddItemLoadgudang(ByVal item As model.LoadGudangDetail)
            Try
                db.execQuery("LON_AddLoadgudangDetail", New Object() {
                                   item.idHeader,
                                   item.linenKode,
                                   item.material,
                                   item.qty,
                                   item.flag})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub EditItemLoadgudang(ByVal item As model.LoadGudangDetail)
            Try
                db.execQuery("LON_EditLoadgudangDetail", New Object() {
                                   item.idDetailLoadGudang,
                                   item.linenKode,
                                   item.material,
                                   item.qty})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function AmbilHeaderId() As Integer
            Try                
                Dim id As Integer                
                Dim dt As DataTable = db.execQuery("LON_AmbilNoHeaderLoadgudang")                
                If IsDBNull(dt.Rows(0)(0)) Then
                    id = 0
                Else
                    id = dt.Rows(0)(0)
                End If
                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub AddStokGudangUtama(ByVal item As model.Linen)
            Try
                db.execQuery("LON_EditStokGudangUtama_Input", New Object() {
                                   item.jns_linen_kode,
                                   item.jumlah_linen})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub EditStokGudangUtama(ByVal item As model.Linen)
            Try
                db.execQuery("LON_EditStokGudangUtama_Distribusi", New Object() {
                                   item.jns_linen_kode,
                                   item.jumlah_linen})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function cekStokLinenByKodeLinen_jmlLinen(ByVal kdlinen As String, ByVal jml As Integer) As Integer
            Try
                Dim jmlstok As Integer
                Dim dt As DataTable = db.execQuery("LON_CekStokLinenByKodeLinen_JmlLinen_New", New Object() {kdlinen, jml})
                jmlstok = dt.Rows(0)(0).ToString()
                'jmlstok = db.execUpdate("LON_CekStokLinenByTransId", New Object() {idTransIn})
                Return jmlstok
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function cekStokLinenByIdLoadGudang(ByVal idLoadGudang As Integer) As Integer
            Try
                Dim jmlstok As Integer
                Dim dt As DataTable = db.execQuery("LON_CekStokLinenByIdLoadGudang_New", New Object() {idLoadGudang})
                jmlstok = dt.Rows(0)(0).ToString()
                'jmlstok = db.execUpdate("LON_CekStokLinenByTransId", New Object() {idTransIn})
                Return jmlstok
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub penguranganStokLinenByIdLoadGudang(ByVal idLoadGudang As Integer)
            Try
                db.execUpdate("LON_PenguranganStokLinenByIdLoadGudang", New Object() {idLoadGudang})                
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub editFlagCancelLoadGudangByIdLoadGudang(ByVal idloadgudang As Integer)
            Try
                db.execUpdate("LON_EditFlagCancelLoadGudangByIdLoadGudang", New Object() {idloadgudang})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
    End Class
End Namespace
