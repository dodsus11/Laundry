Imports Ninject
Imports System.Windows.Forms
Imports DbLibs

Namespace dao

    Public Class TransCodeDao

        Public Property db As ClsDbase
        Private SQL As String

        Public Function TransCodeList() As DataTable
            Try

                Me.SQL = "SELECT * FROM v_TransMenu"

                Return Me.db.execSQL(Me.SQL)

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function TransCodeCollections() As List(Of model.TCode)
            Try

                Me.SQL = _
                     "SELECT * FROM v_TransMenu" &
                     " WHERE trans_code IS NOT NULL"

                Dim dt As DataTable = Me.db.execSQL(Me.SQL)

                Dim tcList As New List(Of model.TCode)

                For Each row As DataRow In dt.Rows

                    Dim tc As New model.TCode()

                    tc.Id = row(model.TCode.ID_TCODE)
                    tc.MenuCaption = row(model.TCode.MENU_CAPTION)
                    tc.ProcessId = row(model.TCode.PROCESS_ID)
                    tc.MenuId = row(model.TCode.MENU_ID)
                    tc.ProcessName = row(model.TCode.PROCESS_NAME).ToString()
                    tc.DllName = row(model.TCode.DLL_NAME).ToString()
                    tc.UcName = row(model.TCode.UC_NAME).ToString()
                    tc.TransCode = row(model.TCode.TRANS_CODE).ToString()
                    tcList.Add(tc)
                Next

                Return tcList

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function TransCodeActiveList() As DataTable
            Try

                Me.SQL = _
                    "SELECT * FROM v_TransMenu" &
                    " WHERE trans_code IS NOT NULL"

                Return Me.db.execSQL(Me.SQL)

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub TransCodeUpdate(ByVal Id As Integer, ByVal tCode As String)
            Try

                Me.SQL = _
                    "UPDATE mn_ProcessMenu SET" &
                    " trans_code = @1" &
                    " WHERE id = @2"

                Me.db.execSQL(Me.SQL, New String() {"@1", "@2"}, New Object() {tCode, Id})

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class

End Namespace

