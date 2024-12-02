Imports DbLibs

Namespace dao
    Public Class MesinDao
        Public Property db As ClsDbase

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

        Public Function getMesinByJenis(ByVal item As model.Mesin) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilMesinByJenis", New Object() {item.jenis_mesin})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub insertMesin(ByVal group As model.Mesin)
            Try
                db.execUpdate("LON_AddMesin", New Object() {group.kode_mesin, group.nama_mesin, group.kapasitas_mesin, group.maxload_mesin, group.jenis_mesin, group.flag_mesin})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub updateMesin(ByVal group As model.Mesin)
            Try
                db.execUpdate("LON_EditMesin", New Object() {group.id_mesin, group.kode_mesin, group.nama_mesin, group.kapasitas_mesin, group.maxload_mesin, group.flag_mesin})
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

    End Class
End Namespace
