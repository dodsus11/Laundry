Imports DbLibs

Namespace dao
    Public Class PegawaiDao
        Public Property db As ClsDbase

        'DAO untuk pegawai
        Public Function getPegawai() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilPegawaiAll")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub insertPegawai(ByVal group As model.Pegawai)
            Try
                db.execUpdate("LON_AddPegawai", New Object() {group.nama_pegawai, group.nip_pegawai, group.bagian, group.status_pegawai})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub updatePegawai(ByVal group As model.Pegawai)
            Try
                db.execUpdate("LON_EditPegawai", New Object() {group.id_pegawai, group.nama_pegawai, group.nip_pegawai, group.bagian, group.status_pegawai})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub deletePegawai(ByVal group As model.Pegawai)
            Try
                db.execUpdate("LON_DeletePegawai", New Object() {group.id_pegawai})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function existPegawai(ByVal group As model.Pegawai) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_EksisPegawai", New Object() {group.nama_pegawai})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
End Namespace
