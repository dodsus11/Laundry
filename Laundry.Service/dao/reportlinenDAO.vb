Imports DbLibs

Namespace dao
    Public Class ReportlinenDao
        Public Property db As ClsDbase

        Public Function getLinenBersih() As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_RekapLinenBersih")
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getLinenKeluar(ByVal tanggal As Date) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_RekapLinenKeluar", New Object() {tanggal})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getKitirOrderDetail(ByVal headerid As Integer) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_KitirOrderDetail", New Object() {headerid})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function rekapLinenTerdistribusi(ByVal fromdate As Date, ByVal todate As Date, ByVal deptid As Integer) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_RekapLinenTerdistribusi", New Object() {fromdate, todate, deptid})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getLinenKotor(ByVal tglmul As Date, ByVal tglsel As Date, ByVal ruang As Long) As DataTable
            Try
                'Dim dt As DataTable = db.execQuery("LON_RekapLinenKotor_New", New Object() {tglmul, tglsel, ruang})
                Dim dt As DataTable = db.execQuery("LON_RekapLinenKotor_New1", New Object() {tglmul, tglsel, ruang})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getLinenPerJnsLinen(ByVal Ftgl As Date, ByVal Ttgl As Date, ByVal ruang As Long) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_RekapLinenPerJnsLinen", New Object() {Ftgl, Ttgl, ruang})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function rekapLinenHilangRusak(ByVal fromdate As Date, ByVal todate As Date) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("LON_TampilLinenRusakHilang", New Object() {fromdate, todate})
                dt.TableName = "group"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
End Namespace
