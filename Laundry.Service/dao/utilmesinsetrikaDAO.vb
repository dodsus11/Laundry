Imports DbLibs

Namespace dao
    Public Class UtilmesinsetrikaDao
        Public Property db As ClsDbase

        'DAO untuk utilisasi mesin
        Public Function getUtilMesinSetrika(tgl) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilUtilMesinSetrikaAll", New Object() {tgl})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub insertUtilMesinSetrika(ByVal group As model.Util_Mesin_Setrika)
            Try
                db.execUpdate("LON_AddUtilMesinSetrika", New Object() {group.tanggal,
                                                                       group.load_ke,
                                                                       group.nama_mesin,
                                                                       group.linen,
                                                                       group.operator_mesin,
                                                                       group.jumlah_linen_bersih,
                                                                       group.jumlah_linen_rusak,
                                                                       group.jumlah_linen_reject,
                                                                       group.jumlah_linen})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub insertUtilMesinSetrikaHeader(ByVal group As model.Util_Mesin_Setrika)
            Try
                db.execUpdate("LON_AddUtilMesinSetrikaHeader", New Object() {group.tanggal,
                                                                             group.nama_mesin,
                                                                             group.load_ke,
                                                                             group.operator_mesin})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub updateUtilMesinSetrikaHeader(ByVal group As model.Util_Mesin_Setrika)
            Try
                db.execUpdate("LON_EditUtilMesinSetrikaHeader", New Object() {group.utilisasi_mesin_setrika_id,
                                                                              group.tanggal,
                                                                             group.nama_mesin,
                                                                             group.load_ke,
                                                                             group.operator_mesin})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function AmbilIdUtilSetrika() As Integer
            Try
                Dim id As Integer
                'Dim idx As String
                Dim dt As DataTable = db.execQuery("LON_AmbilIdUtilSetrika")
                id = dt.Rows(0)(0)
                If IsDBNull(id) Then
                    id = 0
                End If
                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub AddDetailUtilSetrika(ByVal item As model.Util_Mesin_Setrika)
            Try
                db.execQuery("LON_AddDetailUtilSetrika", New Object() {
                                   item.utilisasi_mesin_setrika_id,
                                   item.linen,
                                   item.jumlah_linen_bersih,
                                   item.jumlah_linen_rusak,
                                   item.jumlah_linen_reject})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub updateUtilMesinSetrika(ByVal group As model.Util_Mesin_Setrika)
            Try
                db.execUpdate("LON_EditUtilMesinSetrika", New Object() {group.utilisasi_mesin_setrika_id,
                                                                        group.jumlah_linen_bersih,
                                                                        group.jumlah_linen_rusak,
                                                                        group.jumlah_linen_reject,
                                                                        group.jumlah_linen,
                                                                        group.operator_mesin,
                                                                        group.kodelinen,
                                                                        group.jumlah_linen_bersih_awal,
                                                                        group.jumlah_linen_rusak_awal,
                                                                        group.jumlah_linen_reject_awal})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub deleteUtilMesinSetrika(ByVal group As model.Util_Mesin_Setrika)
            Try
                db.execUpdate("LON_DeleteUtilMesinSetrika", New Object() {group.utilisasi_mesin_setrika_id})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub deleteDetailUtilMesinSetrika(ByVal group As model.Util_Mesin_Setrika)
            Try
                db.execUpdate("LON_DeleteDetailUtilMesinSetrika", New Object() {group.utilisasi_mesin_setrika_id})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function lookupPegawai() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_LookupPegawaiLaundry")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function cariTglSekarang(ByVal tgl As Date, ByVal mesin As String) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_CariTglSekarangUtilSetrika", New Object() {tgl, mesin})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ambilLoad(ByVal tgl As Date, ByVal mesin As String) As Integer
            Try
                Dim id As Integer
                Dim dt As DataTable = db.execQuery("LON_AmbilLoadUtilSetrika", New Object() {tgl, mesin})
                id = dt.Rows(0)(0)
                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getMesinSetrika(ByVal item As model.Mesin) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilMesinSetrika", New Object() {item.jenis_mesin})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ambilIdPegawai(ByVal nama As String) As Integer
            Try
                Dim id As Integer
                Dim dt As DataTable = db.execQuery("LON_AmbilIdPegawai", New Object() {nama})
                id = dt.Rows(0)(0)
                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getLinenTiapMesinSetrika(ByVal mesin As String, ByVal linen As String, ByVal tglAwal As Date, ByVal tglAkhir As Date) As DataTable
            Try
                'Dim dt As DataTable = db.execQuery("LON_TampilJmlLinenDariMesinSetrika", New Object() {mesin, tglAwal, tglAkhir})
                Dim dt As DataTable = db.execQuery("LON_TampilJmlLinenDariMesinSetrikaNew", New Object() {mesin, linen, tglAwal, tglAkhir})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getUtilMesinSetrikaDetail(ByVal id As Int32) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_GetDetailUtilSetrika", New Object() {id})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
