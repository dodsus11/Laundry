Imports DbLibs

Namespace dao
    Public Class PembersihDao
        Public Property db As ClsDbase

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

        Public Function getMasterDosisPembersih() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilDosisPembersih")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getDosisPembersih(ByVal group As model.DosisPembersih) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_dosis_pembersih", New Object() {group.jenis_ident_kotoran, group.berat_linen})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getMasterPembersihGeneral() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilPembersihGeneral")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub insertPembersih(ByVal group As model.Pembersih)
            Try
                db.execUpdate("LON_AddPembersih", New Object() {group.kode_bahan_pembersih, group.nama_bahan_pembersih, group.vol, group.linen_infeksius, group.linen_noninfeksius})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub insertDosisPembersih(ByVal group As model.DosisPembersih)
            Try
                db.execUpdate("LON_insert_dosis_pembersih", New Object() {group.jenis_ident_kotoran, group.berat_linen, group.jml_alkaline, group.jml_detergent, group.jml_oxybleach, group.jml_softener, group.jml_penetral})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub updatePembersih(ByVal group As model.Pembersih)
            Try
                db.execUpdate("LON_EditPembersih", New Object() {group.id_bahan_pembersih, group.kode_bahan_pembersih, group.nama_bahan_pembersih, group.vol, group.linen_infeksius, group.linen_noninfeksius})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub updateDosisPembersih(ByVal group As model.DosisPembersih)
            Try
                db.execUpdate("LON_edit_dosis_pembersih", New Object() {group.id, group.jenis_ident_kotoran, group.berat_linen, group.jml_alkaline, group.jml_detergent, group.jml_oxybleach, group.jml_softener, group.jml_penetral})
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

        Public Sub nonaktifDosisPembersih(ByVal group As model.DosisPembersih)
            Try
                db.execUpdate("LON_nonaktif_dosis_pembersih", New Object() {group.id})
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

        Public Function isExistDosisPembersih(ByVal group As model.DosisPembersih) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_eksis_dosis_pembersih", New Object() {group.jenis_ident_kotoran, group.berat_linen})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
End Namespace
