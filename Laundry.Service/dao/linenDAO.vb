Imports DbLibs

Namespace dao
    Public Class LinenDao
        Public Property db As ClsDbase

        Public Function getLinenAll() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilAllLinen")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function tampilLinenAktif() As DataTable
            Try
                'Dim dt As DataTable = db.execQuery("LON_TampilLinenAktif")
                Dim dt As DataTable = db.execQuery("LON_TampilLinenAktifNew")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub insertLinen(ByVal group As model.Linen)
            Try
                'db.execUpdate("LON_AddLinen", New Object() {group.jns_linen_kode, group.jns_linen_nama, group.berat_linen, group.jumlah_linen})
                db.execUpdate("LON_AddLinenNew", New Object() {group.jns_linen_kode, group.jns_linen_nama, group.berat_linen})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub updateLinen(ByVal group As model.Linen)
            Try
                'db.execUpdate("LON_EditLinen", New Object() {group.jns_linen_id, group.jns_linen_kode, group.jns_linen_nama, group.berat_linen})
                db.execUpdate("LON_EditLinenNew", New Object() {group.jns_linen_id, group.jns_linen_kode, group.jns_linen_nama, group.berat_linen})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub deleteLinen(ByVal group As model.Linen)
            Try
                'db.execUpdate("LON_DeleteLinen", New Object() {group.jns_linen_kode})
                db.execUpdate("LON_DeleteLinenNew", New Object() {group.jns_linen_kode})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function existLinen(ByVal group As model.Linen) As DataTable
            Try
                'Dim dt As DataTable = db.execQuery("LON_EksisData", New Object() {group.jns_linen_kode, group.jns_linen_nama})
                Dim dt As DataTable = db.execQuery("LON_EksisDataNew", New Object() {group.jns_linen_kode, group.jns_linen_nama})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function roomLookUp() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_ListPolyRoom_LookUp")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub AddHeader(ByVal head As model.OrderHeader)
            Try
                db.execQuery("LON_AddHeader", New Object() {
                                   head.ruang,
                                   head.namaPegawai,
                                   head.tanggal,
                                   head.jam})                
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub AddItem(ByVal item As model.OrderDetail)
            Try
                db.execQuery("LON_AddOrderDetail", New Object() {
                                   item.headerId,
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
                Dim dt As DataTable = db.execQuery("LON_AmbilNoHeader")
                id = dt.Rows(0)(0).ToString()
                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'DAO untuk Master Mesin
        Public Function getMasterMesin() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilMesinAll")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub insertMesin(ByVal group As model.Mesin)
            Try
                db.execUpdate("LON_AddMesin", New Object() {group.nama_mesin, group.kapasitas_mesin, group.maxload_mesin, group.flag_mesin})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub updateMesin(ByVal group As model.Mesin)
            Try
                db.execUpdate("LON_EditMesin", New Object() {group.id_mesin, group.nama_mesin, group.kapasitas_mesin, group.maxload_mesin, group.flag_mesin})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub deleteMesin(ByVal group As model.Mesin)
            Try
                db.execUpdate("LON_DeleteMesin", New Object() {group.id_mesin})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function existMesin(ByVal group As model.Mesin) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_EksisMesin", New Object() {group.nama_mesin})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'DAO untuk master bahan pembersih
        Public Function getMasterPembersih() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilPembersihAll")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub insertPembersih(ByVal group As model.Pembersih)
            Try
                db.execUpdate("LON_AddPembersih", New Object() {group.nama_bahan_pembersih, group.flag_bahan_pembersih})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub updatePembersih(ByVal group As model.Pembersih)
            Try
                db.execUpdate("LON_EditPembersih", New Object() {group.id_bahan_pembersih, group.nama_bahan_pembersih, group.flag_bahan_pembersih})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub deletePembersih(ByVal group As model.Pembersih)
            Try
                db.execUpdate("LON_DeletePembersih", New Object() {group.id_bahan_pembersih})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function existPembersih(ByVal group As model.Pembersih) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_EksisPembersih", New Object() {group.nama_bahan_pembersih})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'DAO untuk utilisasi mesin
        Public Function getUtilMesin() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilUtilMesinAll")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'DAO untuk penambahan persediaan
        Public Function getItemMasuk() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilItemMasuk")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getItemMasukDetail(ByVal headerid As Integer) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilItemMasukDetail", New Object() {headerid})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub editCancelTransIn(ByVal group As model.TransaksiDelete)
            Try
                db.execUpdate("LON_EditCancelItemMasuk", New Object() {group.idTransaksi, group.cancelBy})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub insertTransIn(ByVal group As model.TransIn)
            Try
                db.execUpdate("LON_AddPersediaanMasukHeader", New Object() {group.tglTI, group.ketTI, group.entryByTI, group.entryJamTI})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function AmbilTransInId() As Integer
            Try
                Dim id As Integer
                Dim dt As DataTable = db.execQuery("LON_AmbilTransInId")
                id = dt.Rows(0)(0).ToString()
                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub insertTransInDetail(ByVal item As model.TransInDetail)
            Try
                db.execQuery("LON_AddPersediaanMasukDetail", New Object() {
                                   item.idTransIn,
                                   item.kode_jenis_linen,
                                   item.qty})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub editTransIn(ByVal group As model.TransIn)
            Try
                db.execUpdate("LON_EditPersediaanMasukHeader", New Object() {group.idTransIn, group.tglTI, group.ketTI, group.entryByTI, group.entryJamTI})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub editCancelTransInDetail(ByVal group As model.TransInDetail)
            Try
                db.execUpdate("LON_EditCancelItemMasukDetail", New Object() {group.idTransInDetail})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub editCancelTransInDetailByTransId(ByVal transid As Integer)
            Try
                db.execUpdate("LON_EditCancelItemMasukDetailByTransId", New Object() {transid})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub UpdateJumlahStokPersediaanLinen(ByVal item As model.Linen)
            Try
                db.execQuery("LON_UpdateJumlahStokPersediaanLinen", New Object() {
                              item.jns_linen_kode,
                              item.jumlah_linen_persediaan_masuk,
                              item.jumlah_linen_persediaan_keluar})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub penambahanJumlahStokLinenIN(ByVal item As model.Linen)
            Try
                db.execQuery("LON_PenambahanJumlahStokLinenIN", New Object() {
                                   item.jns_linen_kode,
                                   item.jumlah_linen})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub penguranganJumlahStokLinenIN(ByVal item As model.Linen)
            Try
                db.execQuery("LON_PenguranganJumlahStokLinenIN", New Object() {
                                   item.jns_linen_kode,
                                   item.jumlah_linen})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function cekStokLinenByTransId(ByVal idTransIn As Integer) As Integer
            Try
                Dim jmlstok As Integer
                Dim dt As DataTable = db.execQuery("LON_CekStokLinenByTransId", New Object() {idTransIn})
                jmlstok = dt.Rows(0)(0).ToString()
                'jmlstok = db.execUpdate("LON_CekStokLinenByTransId", New Object() {idTransIn})
                Return jmlstok
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub penguranganStokLinenByTransId(ByVal idTransIn As Integer)
            Try
                db.execUpdate("LON_PenguranganStokLinenByTransId", New Object() {idTransIn})
                '[LON_PenguranganStokLinenByTransId]()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        'DAO untuk pengurangan persediaan
        Public Function getItemKeluar() As DataTable
            Try
                'Dim dt As DataTable = db.execQuery("LON_TampilItemKeluar")
                Dim dt As DataTable = db.execQuery("LON_TampilItemKeluarRev1")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getItemKeluarDetail(ByVal headerid As Integer) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilItemKeluarDetail", New Object() {headerid})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LoadLinenKeluar(ByVal tglfrom As Date, ByVal tglto As Date) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilPersediaanLinenKeluar", New Object() {tglfrom, tglto})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function LoadDetailDataLinenRusakbyTanggal(ByVal tgl As Date) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_LoadDataLinenRusakByTGL", New Object() {tgl})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function LoadDataPerolehanLinen(ByVal kodeLinen As String) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_loadDataPerolehanLinen", New Object() {kodeLinen})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub editCancelTransOut(ByVal group As model.TransaksiDelete)
            Try
                db.execUpdate("LON_EditCancelItemKeluar", New Object() {group.idTransaksi, group.cancelBy})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function cekStokLinenByKodeLinen_jmlLinen(ByVal item As model.TransOutDetail) As Integer
            Try
                Dim jmlerror As Integer
                'Dim dt As DataTable = db.execQuery("LON_CekStokLinenByKodeLinen_jmlLinen", New Object() {
                Dim dt As DataTable = db.execQuery("LON_CekStokLinenByKodeLinen_jmlLinen_New", New Object() {
                                            item.kode_jenis_linen,
                                            item.qty})
                jmlerror = dt.Rows(0)(0).ToString()
                Return jmlerror
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub insertTransOut(ByVal group As model.TransOut)
            Try
                db.execUpdate("LON_AddPersediaanKeluarHeader", New Object() {group.tglTO, group.kategoriTO, group.ketTO, group.entryByTO, group.entryJamTO})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub insertLinenOut(ByVal group As model.TransOut)
            Try
                db.execUpdate("LON_insertLinenOUT", New Object() {group.tglTO, group.kategoriTO, group.ketTO, group.entryByTO, group.entryDateTO, group.entryJamTO, group.kode_linen, group.jmlJahit, group.jmlAfkir, group.tgl})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub insertPerolehanLInen(ByVal group As model.PerolehanLinen)
            Try
                db.execUpdate("LON_insertPerolehanLinen", New Object() {group.namaLinen, group.tahunPerolehan, group.qty, group.keterangan, group.kodeLinen, group.entry_by, group.entry_date})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function AmbilTransOutId() As Integer
            Try
                Dim id As Integer
                Dim dt As DataTable = db.execQuery("LON_AmbilTransOutId")
                id = dt.Rows(0)(0).ToString()
                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub insertTransOutDetail(ByVal item As model.TransOutDetail)
            Try
                db.execQuery("LON_AddPersediaanKeluarDetail", New Object() {
                                   item.idTransOut,
                                   item.kode_jenis_linen,
                                   item.qty})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub editTransOut(ByVal group As model.TransOut)
            Try
                db.execUpdate("LON_EditPersediaanKeluarHeader", New Object() {group.idTransOut, group.tglTO, group.kategoriTO, group.ketTO, group.entryByTO, group.entryJamTO})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub editCancelTransOutDetail(ByVal group As model.TransOutDetail)
            Try
                db.execUpdate("LON_EditCancelItemKeluarDetail", New Object() {group.idTransOutDetail})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub editCancelTransOutDetailByTransId(ByVal transid As Integer)
            Try
                db.execUpdate("LON_EditCancelItemKeluarDetailByTransId", New Object() {transid})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub penambahanStokLinenByTransId(ByVal idTransOut As Integer)
            Try
                db.execUpdate("LON_PenambahanStokLinenByTransId", New Object() {idTransOut})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub penambahanJumlahStokLinenOUT(ByVal item As model.Linen)
            Try
                db.execQuery("LON_PenambahanJumlahStokLinenOUT", New Object() {
                                   item.jns_linen_kode,
                                   item.jumlah_linen})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub penguranganJumlahStokLinenOUT(ByVal item As model.Linen)
            Try
                db.execQuery("LON_PenguranganJumlahStokLinenOUT", New Object() {
                                   item.jns_linen_kode,
                                   item.jumlah_linen})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        'Tampil stok gudang linen
        Public Function DataStokLinenGudang() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_DataStokLinenGudang")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
