Imports Ninject

Namespace dao

    Public Class CustomerDao

        Public Property db As DbLibs.ClsDbase

        Public Function getCustomer() As DataTable
            Try
                Return db.execQuery("SEL_CUST_ALL")
            Catch ex As Exception
                Throw ex
            End Try
        End Function



    End Class

End Namespace

