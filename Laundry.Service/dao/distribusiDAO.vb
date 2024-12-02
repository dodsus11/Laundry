Imports DbLibs

Namespace dao
    Public Class DistribusiDao
        Public Property db As ClsDbase

        Public Function getOrderHeader(tgl) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilOrderHeaderDistribusi_New", New Object() {tgl})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getOrderHeaderRange(tglmulai, tglselesai) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilOrderHeaderDistribusi_New", New Object() {tglmulai, tglselesai})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getOrderDetail(ByVal headerid As Integer) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilDetailOrderDistribusi", New Object() {headerid})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'Public Sub EditHeader(ByVal headerid As Integer)
        '    Try
        '        db.execQuery("LON_EditHeaderDistribusi", New Object() {headerid})
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Sub

        Public Function EditHeaderFlag(ByVal headerid As Integer) As Integer
            Try
                Dim label As Integer = 1
                Dim jml As Integer
                Dim a As Integer
                Dim dt As DataTable = db.execQuery("LON_TampilDetailOrderDistribusi", New Object() {headerid})
                jml = dt.Rows.Count
                a = 0
                If jml = 0 Then
                    label = 3 'kondisi linen sudah didistribusi semua
                    db.execQuery("LON_EditHeaderDistribusiFlag", New Object() {headerid, label})
                Else
                    label = 2 'kondisi linen belum didistribusi semua
                    db.execQuery("LON_EditHeaderDistribusiFlag", New Object() {headerid, label})
                End If
                'While (a < jml)
                '    If dt.Rows(a)(3) <> dt.Rows(a)(4) Then
                '        label = 2
                '        db.execQuery("LON_EditHeaderDistribusiFlag", New Object() {headerid, label})
                '        Exit While
                '    End If
                '    a += 1
                '    If a = jml Then
                '        label = 3
                '        db.execQuery("LON_EditHeaderDistribusiFlag", New Object() {headerid, label})
                '    End If
                'End While                
                Return label
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub EditItem(ByVal item As model.OrderDetail)
            Try
                db.execQuery("LON_EditOrderDetailDistribusi", New Object() {
                                   item.detailId,
                                   item.qtyDistribusi})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        'Public Function AmbilHeaderId() As Integer
        '    Try
        '        Dim id As Integer
        '        'Dim idx As String
        '        Dim dt As DataTable = db.execQuery("LON_AmbilNoHeader")
        '        id = dt.Rows(0)(0)
        '        If IsDBNull(id) Then
        '            id = 0
        '        End If
        '        Return id
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        'Public Function AmbilIdRuang(ByVal ruang As String) As String
        '    Try
        '        Dim id As String
        '        'Dim idx As String
        '        Dim dt As DataTable = db.execQuery("LON_AmbilIdRuang", New Object() {ruang})
        '        id = dt.Rows(0)(0)
        '        Return id
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        Public Sub UpdateStokGudangUtama(ByVal item As model.Linen)
            Try
                db.execQuery("LON_EditStokGudangUtama_Distribusi", New Object() {
                                   item.jns_linen_kode,
                                   item.jumlah_linen})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function AmbilIndexPerHeaderId(ByVal headerid As Integer, ByVal linen As String) As Integer
            Try
                Dim id As Integer
                Dim dt As DataTable = db.execQuery("LON_AmbilIndexHeaderTabelDistribusi", New Object() {headerid, linen})
                If IsDBNull(dt.Rows(0)(0)) Then
                    id = 1
                Else
                    id = (dt.Rows(0)(0)) + 1
                End If
                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub AddHistoryDistribusi(ByVal distribusi As model.OrderDistribusi)
            Try
                db.execQuery("LON_AddHistoryDistribusi", New Object() {
                                   distribusi.tanggal,
                                   distribusi.jam,
                                   distribusi.indexperheader,
                                   distribusi.headerId,
                                   distribusi.linen,
                                   distribusi.qtyDistribusi,
                                   distribusi.petugas})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function tampilHistory(ByVal idorder As Integer) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilHistoryDistribusi", New Object() {idorder})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
