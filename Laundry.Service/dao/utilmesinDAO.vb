Imports DbLibs

Namespace dao
    Public Class UtilmesinDao
        Public Property db As ClsDbase

        'DAO untuk utilisasi mesin
        Public Function getUtilMesin(tgl) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilUtilMesinAll", New Object() {tgl})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub insertUtilMesin(ByVal group As model.Util_Mesin)
            Try
                db.execUpdate("LON_AddUtilMesin_Rev1", New Object() {group.tanggal,
                                                                group.nama_mesin,
                                                                group.berat_linen,
                                                                group.pembersih1,
                                                                group.pembersih2,
                                                                group.pembersih3,
                                                                group.pembersih5,
                                                                group.pembersih7,
                                                                group.mulai,
                                                                group.selesai,
                                                                group.jenis_linen,
                                                                group.operator_mesin,
                                                                group.operator_mesin_nama,
                                                                group.keterangan})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub updateUtilMesin(ByVal group As model.Util_Mesin)
            Try
                db.execUpdate("LON_EditUtilMesin_Rev1", New Object() {group.utilisasi_mesin_cuci_id,
                                                                 group.tanggal,
                                                                 group.nama_mesin,
                                                                 group.berat_linen,
                                                                 group.pembersih1,
                                                                 group.pembersih2,
                                                                 group.pembersih3,
                                                                 group.pembersih5,
                                                                 group.pembersih7,
                                                                 group.mulai,
                                                                 group.selesai,
                                                                 group.jenis_linen,
                                                                 group.operator_mesin,
                                                                 group.operator_mesin_nama,
                                                                 group.keterangan})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub deleteUtilMesin(ByVal group As model.Util_Mesin)
            Try
                db.execUpdate("LON_DeleteUtilMesin", New Object() {group.utilisasi_mesin_cuci_id})
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

        Public Function existUtilmesin(ByVal group As model.Util_Mesin) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_EksisUtilMesin", New Object() {group.nama_mesin, group.mulai, group.tanggal})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DataUtilisasiMesinCuci(ByVal fromdate As String, ByVal todate As String) As DataTable
            Try
                'Dim dt As DataTable = db.execQuery("LON_DataUtilisasiMesinCuci", New Object() {fromdate, todate})
                Dim dt As DataTable = db.execQuery("LON_DataUtilisasiMesinCuci_rev1", New Object() {fromdate, todate})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DataUtilisasiMesinCucibyLinen(ByVal fromdate As String, ByVal todate As String, ByVal jns_linen As String) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_DataUtilisasiMesinCuci_byLinen", New Object() {fromdate, todate, jns_linen})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DataUtilisasiMesinPengering(ByVal fromdate As String, ByVal todate As String) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_DataUtilisasiMesinPengering", New Object() {fromdate, todate})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DataUtilisasiMesinSetrika(ByVal fromdate As String, ByVal todate As String) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_DataUtilisasiMesinSetrikaRev1", New Object() {fromdate, todate})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DataPenggunaanChemical(ByVal fromdate As String, ByVal todate As String) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_DataPenggunaanChemical", New Object() {fromdate, todate})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
