Imports System.ServiceModel
Imports System.Runtime.Serialization


Namespace model

    <DataContract()>
    Public Class Linen        
        <DataMember()>
        Public jns_linen_id As Integer
        <DataMember()>
        Public jns_linen_kode As String
        <DataMember()>
        Public jns_linen_nama As String
        <DataMember()>
        Public berat_linen As Decimal
        <DataMember()>
        Public jumlah_linen_awal As Integer
        <DataMember()>
        Public jumlah_linen As Integer
        <DataMember()>
        Public actived_date As Date
        <DataMember()>
        Public linen_flag As Integer
        <DataMember()>
        Public berat_linen_str As String
        <DataMember()>
        Public jumlah_linen_persediaan_masuk As Integer
        <DataMember()>
        Public jumlah_linen_persediaan_keluar As Integer
    End Class

    <DataContract()>
    Public Class OrderHeader
        <DataMember()>
        Public headerId As Integer
        <DataMember()>
        Public orderNo As String
        <DataMember()>
        Public ruang As String
        <DataMember()>
        Public subRuang As String
        <DataMember()>
        Public namaPegawai As String
        <DataMember()>
        Public pegawaiLaundy As String
        <DataMember()>
        Public tanggal As Date
        <DataMember()>
        Public jam As TimeSpan
        <DataMember()>
        Public tanggalstr As String
        <DataMember()>
        Public jamstr As String
        <DataMember()>
        Public flag As String
        <DataMember()>
        Public tglAwal As Date
        <DataMember()>
        Public tglAkhir As Date
    End Class

    <DataContract()>
    Public Class OrderDetail
        <DataMember()>
        Public detailId As Integer
        <DataMember()>
        Public headerId As Integer
        <DataMember()>
        Public linen As Integer        
        <DataMember()>
        Public jenis As String
        <DataMember()>
        Public material As String
        <DataMember()>
        Public qty As Integer
        <DataMember()>
        Public qtyNon As Integer
        <DataMember()>
        Public qtyInf As Integer
        <DataMember()>
        Public berat As String
        <DataMember()>
        Public qtyTerdistribusi As Integer
        <DataMember()>
        Public qtyDistribusi As Integer
        <DataMember()>
        Public flag As String
    End Class

    <DataContract()>
    Public Class OrderDistribusi
        <DataMember()>
        Public distribusiId As Integer
        <DataMember()>
        Public tanggal As Date
        <DataMember()>
        Public jam As TimeSpan
        <DataMember()>
        Public indexperheader As Integer
        <DataMember()>
        Public headerId As Integer
        <DataMember()>
        Public linen As String
        <DataMember()>
        Public qtyDistribusi As Integer
        <DataMember()>
        Public petugas As String
        <DataMember()>
        Public flag As String
    End Class

    <DataContract()>
    Public Class Mesin
        <DataMember()>
        Public id_mesin As Integer
        <DataMember()>
        Public kode_mesin As String
        <DataMember()>
        Public nama_mesin As String
        <DataMember()>
        Public kapasitas_mesin As Integer
        <DataMember()>
        Public maxload_mesin As Integer
        <DataMember()>
        Public flag_mesin As String
        <DataMember()>
        Public jenis_mesin As String
    End Class

    <DataContract()>
    Public Class Pembersih
        <DataMember()>
        Public id_bahan_pembersih As Integer
        <DataMember()>
        Public kode_bahan_pembersih As String
        <DataMember()>
        Public nama_bahan_pembersih As String
        <DataMember()>
        Public vol As Integer
        <DataMember()>
        Public linen_infeksius As Decimal
        <DataMember()>
        Public linen_noninfeksius As Decimal
        <DataMember()>
        Public flag_bahan_pembersih As Integer
        <DataMember()>
        Public linen_infeksius_str As String
        <DataMember()>
        Public linen_noninfeksius_str As String
    End Class

    <DataContract()>
    Public Class DosisPembersih
        <DataMember()>
        Public id As Integer
        <DataMember()>
        Public jenis_ident_kotoran As String
        <DataMember()>
        Public berat_linen As Integer
        <DataMember()>
        Public jml_alkaline As Integer
        <DataMember()>
        Public jml_detergent As Integer
        <DataMember()>
        Public jml_oxybleach As Integer
        <DataMember()>
        Public jml_softener As Integer
        <DataMember()>
        Public jml_penetral As Integer
    End Class

    <DataContract()>
    Public Class Util_Mesin
        <DataMember()>
        Public utilisasi_mesin_cuci_id As Integer
        <DataMember()>
        Public tanggal As Date
        <DataMember()>
        Public id_mesin As String
        <DataMember()>
        Public nama_mesin As String
        <DataMember()>
        Public kapasitas_mesin As Long
        <DataMember()>
        Public berat_linen As Decimal
        <DataMember()>
        Public pembersih1 As String
        <DataMember()>
        Public pembersih2 As String
        <DataMember()>
        Public pembersih3 As String
        <DataMember()>
        Public pembersih4 As String
        <DataMember()>
        Public pembersih5 As String
        <DataMember()>
        Public pembersih6 As String
        <DataMember()>
        Public pembersih7 As String
        <DataMember()>
        Public mulai As TimeSpan
        <DataMember()>
        Public selesai As TimeSpan
        <DataMember()>
        Public temp As Integer
        <DataMember()>
        Public jenis_linen As String
        <DataMember()>
        Public operator_mesin As String
        <DataMember()>
        Public operator_mesin_nama As String
        <DataMember()>
        Public berat_linen_str As String
        <DataMember()>
        Public keterangan As String
    End Class

    <DataContract()>
    Public Class Util_Mesin_Peras
        <DataMember()>
        Public utilisasi_mesin_peras_id As Integer
        <DataMember()>
        Public tanggal As Date
        <DataMember()>
        Public id_mesin As String
        <DataMember()>
        Public nama_mesin As String
        <DataMember()>
        Public berat_linen As Integer        
        <DataMember()>
        Public mulai As TimeSpan
        <DataMember()>
        Public selesai As TimeSpan
        <DataMember()>
        Public keterangan As String        
        <DataMember()>
        Public operator_mesin As String
        <DataMember()>
        Public operator_mesin_nama As String
    End Class

    <DataContract()>
    Public Class Util_Mesin_Pengering
        <DataMember()>
        Public utilisasi_mesin_pengering_id As Integer
        <DataMember()>
        Public tanggal As Date
        <DataMember()>
        Public id_mesin As String
        <DataMember()>
        Public nama_mesin As String
        <DataMember()>
        Public maxload_mesin As Decimal
        <DataMember()>
        Public berat_linen As Decimal
        <DataMember()>
        Public mulai As TimeSpan
        <DataMember()>
        Public selesai As TimeSpan
        <DataMember()>
        Public suhu As Decimal
        <DataMember()>
        Public operator_mesin As String
        <DataMember()>
        Public operator_mesin_nama As String
        <DataMember()>
        Public berat_linen_str As String
    End Class

    <DataContract()>
    Public Class Util_Mesin_Setrika
        <DataMember()>
        Public utilisasi_mesin_setrika_id As Integer
        <DataMember()>
        Public tanggal As Date
        <DataMember()>
        Public kode_mesin As String
        <DataMember()>
        Public nama_mesin As String
        <DataMember()>
        Public load_ke As Integer
        <DataMember()>
        Public kodelinen As String
        <DataMember()>
        Public linen As String
        <DataMember()>
        Public jumlah_linen As Integer
        <DataMember()>
        Public jumlah_linen_bersih As Integer
        <DataMember()>
        Public jumlah_linen_rusak As Integer
        <DataMember()>
        Public jumlah_linen_reject As Integer        
        <DataMember()>
        Public operator_mesin As String
        <DataMember()>
        Public operator_id As Integer
        <DataMember()>
        Public flag As Integer
        <DataMember()>
        Public jumlah_linen_bersih_awal As Integer
        <DataMember()>
        Public jumlah_linen_rusak_awal As Integer
        <DataMember()>
        Public jumlah_linen_reject_awal As Integer
    End Class

    <DataContract()>
    Public Class LoadGudangHeader
        <DataMember()>
        Public idHeaderLoadGudang As Integer       
        <DataMember()>
        Public namaPetugas As String
        <DataMember()>
        Public tanggal As Date
        <DataMember()>
        Public jam As TimeSpan
        <DataMember()>
        Public tanggalstr As String
        <DataMember()>
        Public jamstr As String
        <DataMember()>
        Public jmlJenisLinen As Integer
        <DataMember()>
        Public flag As String
    End Class

    <DataContract()>
    Public Class LoadGudangDetail
        <DataMember()>
        Public idDetailLoadGudang As Integer
        <DataMember()>
        Public idHeader As Integer
        <DataMember()>
        Public linenKode As String
        <DataMember()>
        Public material As String
        <DataMember()>
        Public qty As Integer
        <DataMember()>
        Public flag As String
    End Class

    <DataContract()>
    Public Class GudangUtama
        <DataMember()>
        Public idGudang As Integer
        <DataMember()>
        Public linenKode As String
        <DataMember()>
        Public linenNama As String
        <DataMember()>
        Public jumlah As Integer        
    End Class

    <DataContract()>
    Public Class TransIn
        <DataMember()>
        Public idTransIn As Integer
        <DataMember()>
        Public tglTI As Date
        <DataMember()>
        Public ketTI As String
        <DataMember()>
        Public entryByTI As String
        <DataMember()>
        Public entryDateTI As Date
        <DataMember()>
        Public entryJamTI As TimeSpan
        <DataMember()>
        Public cancelByTI As String
        <DataMember()>
        Public cancelDateTI As Date
        
    End Class

    <DataContract()>
    Public Class TransInDetail
        <DataMember()>
        Public idTransInDetail As Integer
        <DataMember()>
        Public idTransIn As Integer
        <DataMember()>
        Public kode_jenis_linen As String
        <DataMember()>
        Public qty As Integer
        <DataMember()>
        Public cancel_date As Date        
    End Class

    <DataContract()>
    Public Class TransOut
        <DataMember()>
        Public idTransOut As Integer
        <DataMember()>
        Public tglTO As Date
        <DataMember()>
        Public kategoriTO As String
        <DataMember()>
        Public ketTO As String
        <DataMember()>
        Public entryByTO As String
        <DataMember()>
        Public entryDateTO As Date
        <DataMember()>
        Public entryJamTO As TimeSpan
        <DataMember()>
        Public cancelByTO As String
        <DataMember()>
        Public cancelDateTO As Date
        <DataMember()>
        Public tgl As Date
        <DataMember()>
        Public kode_linen As String
        <DataMember()>
        Public jmlJahit As Integer
        <DataMember()>
        Public jmlAfkir As Integer
        <DataMember()>
        Public tgl_awal As Date
        <DataMember()>
        Public tgl_akhir As Date
    End Class

    <DataContract()>
    Public Class TransOutDetail
        <DataMember()>
        Public idTransOutDetail As Integer
        <DataMember()>
        Public idTransOut As Integer
        <DataMember()>
        Public kode_jenis_linen As String
        <DataMember()>
        Public qty As Integer
        <DataMember()>
        Public cancel_date As Date
    End Class

    <DataContract()>
    Public Class TransaksiDelete
        <DataMember()>
        Public idTransaksi As Integer
        <DataMember()>
        Public jenisTransaksi As Integer
        <DataMember()>
        Public cancelBy As String
    End Class

    <DataContract()>
    Public Class Pegawai
        <DataMember()>
        Public id_pegawai As Integer        
        <DataMember()>
        Public nama_pegawai As String
        <DataMember()>
        Public nip_pegawai As String
        <DataMember()>
        Public bagian As String
        <DataMember()>
        Public status_pegawai As String
    End Class
    <DataContract()>
    Public Class PerolehanLinen
        <DataMember()>
        Public namaLinen As String
        <DataMember()>
        Public tahunPerolehan As String
        <DataMember()>
        Public qty As Integer
        <DataMember()>
        Public keterangan As String
        <DataMember()>
        Public kodeLinen As String
        <DataMember()>
        Public entry_by As String
        <DataMember()>
        Public entry_date As Date
    End Class
    <DataContract()>
    Public Class OrderInventaris
        <DataMember()>
        Public id As Integer
        <DataMember()>
        Public noInv As String
        <DataMember()>
        Public tgl As Date
        <DataMember()>
        Public ruang As String
        <DataMember()>
        Public Inst As String
        <DataMember()>
        Public jmlTT As Integer
        <DataMember()>
        Public jmlPAR As Integer
        <DataMember()>
        Public jmlKM As Integer
        <DataMember()>
        Public Petugas As String
        <DataMember()>
        Public idlinen As Integer
        <DataMember()>
        Public jmldisimpan As Integer
        <DataMember()>
        Public jmldipakai As Integer
        <DataMember()>
        Public jmldicucikan As Integer
        <DataMember()>
        Public jmlkotor As Integer
        <DataMember()>
        Public totalLinen As Integer
        <DataMember()>
        Public createDate As Date
        <DataMember()>
        Public createBy As String
        <DataMember()>
        Public namaLinen As String
        

    End Class
    
End Namespace
