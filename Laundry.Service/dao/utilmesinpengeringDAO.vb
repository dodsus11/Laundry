Imports DbLibs

Namespace dao
    Public Class UtilmesinpengeringDao
        Public Property db As ClsDbase

        'DAO untuk utilisasi mesin
        Public Function getUtilMesinPengering(tgl) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilUtilMesinPengeringAll", New Object() {tgl})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub insertUtilMesinPengering(ByVal group As model.Util_Mesin_Pengering)
            Try
                db.execUpdate("LON_AddUtilMesinPengering", New Object() {group.tanggal, group.nama_mesin, group.berat_linen,
                                                                group.mulai, group.selesai, group.suhu,
                                                                group.operator_mesin, group.operator_mesin_nama})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub updateUtilMesinPengering(ByVal group As model.Util_Mesin_Pengering)
            Try
                db.execUpdate("LON_EditUtilMesinPengering", New Object() {group.utilisasi_mesin_pengering_id, group.tanggal, group.nama_mesin, group.berat_linen,
                                                                group.mulai, group.selesai, group.suhu,
                                                                group.operator_mesin, group.operator_mesin_nama})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub deleteUtilMesinPengering(ByVal group As model.Util_Mesin_Pengering)
            Try
                db.execUpdate("LON_DeleteUtilMesinPengering", New Object() {group.utilisasi_mesin_pengering_id})
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

        Public Function existUtilmesinPengering(ByVal group As model.Util_Mesin_Pengering) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_EksisUtilMesinPengering", New Object() {group.nama_mesin, group.mulai, group.tanggal})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
