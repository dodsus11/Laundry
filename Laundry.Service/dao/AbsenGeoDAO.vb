Imports DbLibs
Imports KernelEngine
Imports Ninject

Namespace dao
    Public Class AbsenGeoDAO
        Public Property db As ClsDbase
        Public Property dbGeo As DbLibs.ClsConn


        Public Function getLogTransaction(nip, tanggal) As DataTable
            Try
                Dim dt As DataTable = dbGeo.execQuery("procLogTransactionGet", New Object() {nip, tanggal})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getFotoSimpeg(nip) As String
            Try
                Dim hasil As String = String.Empty
                hasil = db.execScalar("sp_geotagging_sel_foto_pegawai", New Object() {nip})
                Return hasil
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getNamaPegawai(nip) As String
            Try
                Dim hasil As String = String.Empty
                hasil = db.execScalar("sp_geotagging_sel_nama_pegawai", New Object() {nip})                
                Return hasil
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
