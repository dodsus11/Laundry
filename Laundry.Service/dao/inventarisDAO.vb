Imports DbLibs
Namespace dao
    Public Class inventarisDAO
        Public Property db As ClsDbase

        Public Function LoadData(ByVal kodeRuang As Object) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_LoadDataInventarisasi", New Object() {kodeRuang})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function AmbilNomerOrder() As String
            Try
                Dim id As String
                'Dim idx As String
                Dim dt As DataTable = db.execQuery("LON_AmbilNomerINVENTARIS")
                id = dt.Rows(0)(0)
                'If IsDBNull(id) Then
                '    id = 0
                'End If
                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub InsertDataInventaris(ByVal data As model.OrderInventaris)
            Try
                db.execQuery("LON_AddDataInventaris", New Object() {
                                   data.noInv,
                                   data.tgl,
                                   data.ruang,
                                   data.Inst,
                                   data.jmlTT,
                                   data.jmlPAR,
                                   data.jmlKM,
                                   data.Petugas,
                                   data.idlinen,
                                   data.jmldisimpan,
                                   data.jmldipakai,
                                   data.jmldicucikan,
                                   data.jmlkotor,
                                   data.totalLinen,
                                   data.createDate,
                                   data.createBy})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub NonAktif_data(ByVal HapusDtInv As model.OrderInventaris)
            Try
                db.execQuery("LON_deleteInventoriDt", New Object() {
                                   HapusDtInv.id,
                                   HapusDtInv.createDate,
                                   HapusDtInv.Petugas})

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Delete_inventori(ByVal go As model.OrderInventaris)
            Try
                db.execQuery("LON_Delete_INV", New Object() {
                                   go.noInv,
                                   go.createDate,
                                   go.Petugas})

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub IncrementNomerInventaris()
            Try
                db.execQuery("LON_IncrementNomerInventaris", New Object())
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function InstLookUp() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_LoadInstalasi")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function roomLookUp() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_LOAD_RUANG")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function LoadDtlInventaris(ByVal no_inv As Object) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_loadDtlInventaris", New Object() {no_inv})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function AmbilIdRuang(ByVal ruang As String) As String
            Try
                Dim id As String
                Dim dt As DataTable = db.execQuery("LON_ambilIdRuangINV", New Object() {ruang})
                id = dt.Rows(0)(0)
                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function AmbilIdInstalasi(ByVal instalasi As String) As String
            Try
                Dim id As String
                Dim dt As DataTable = db.execQuery("LON_ambilIdInstalasiINV", New Object() {instalasi})
                id = dt.Rows(0)(0)
                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CekExistLinen(ByVal group As model.OrderInventaris) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_cekIdLinenExist_INV", New Object() {group.noInv, group.namaLinen})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

