Imports DbLibs

Namespace dao
    Public Class UtilmesinperasDao
        Public Property db As ClsDbase

        'DAO untuk utilisasi mesin
        Public Function getUtilMesinPeras(tgl) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilUtilMesinPerasAll", New Object() {tgl})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub insertUtilMesinPeras(ByVal group As model.Util_Mesin_Peras)
            Try
                db.execUpdate("LON_AddUtilMesinPeras", New Object() {group.tanggal, group.nama_mesin, group.berat_linen,
                                                                group.mulai, group.selesai, group.keterangan,
                                                                group.operator_mesin, group.operator_mesin_nama})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub updateUtilMesinPeras(ByVal group As model.Util_Mesin_Peras)
            Try
                db.execUpdate("LON_EditUtilMesinPeras", New Object() {group.utilisasi_mesin_peras_id,
                                                                      group.tanggal,
                                                                      group.nama_mesin,
                                                                      group.berat_linen,
                                                                      group.mulai,
                                                                      group.selesai,
                                                                      group.keterangan,
                                                                      group.operator_mesin,
                                                                      group.operator_mesin_nama})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub deleteUtilMesinPeras(ByVal group As model.Util_Mesin_Peras)
            Try
                db.execUpdate("LON_DeleteUtilMesinPeras", New Object() {group.utilisasi_mesin_peras_id})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function lookupPegawai() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_LookupPegawai")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function existUtilmesinPeras(ByVal group As model.Util_Mesin_Peras) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_EksisUtilMesinPeras", New Object() {group.nama_mesin, group.mulai, group.tanggal})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
