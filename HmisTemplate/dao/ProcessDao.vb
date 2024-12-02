Imports Ninject
Imports DbLibs

Namespace dao

    Public Class ProcessDao

        Public Property db As ClsDbase

        Public Function getProcessByModID(ByVal modId As Integer) As DataTable
            Try

                Return Me.db.execQuery("Mn_GetProcessByModule", New Object() {modId})

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getAllProcessByRoleId(ByVal roleId As Integer) As DataTable
            Try
                Return db.execQuery("mn_GetAllProcessByRoleId", New Object() {roleId})
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getAllProcess() As DataTable
            Try
                Return db.execQuery("mn_GetAllProcess")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub saveProcess(ByVal process As model.Process)
            Try
                db.execUpdate("Mn_InsProcess", New Object() {process.procName, _
                                                             process.moduleId, _
                                                             process.iconName})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub editProcess(ByVal process As model.Process)
            Try
                db.execUpdate("Mn_EditProcess", New Object() {process.procName, _
                                                             process.tempIdProse, _
                                                             process.iconName})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub removeProcessById(ByVal procId As Integer, ByRef retVal As Integer)
            Try

                db.execUpdate("Mn_DelProcessById", New Object() {procId}, retVal)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub removeProcessFromRole(ByVal roleId As Integer, ByVal procId As Integer)
            Try

                db.execUpdate("Mn_DelRoleProcess", New Object() {roleId, procId})

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub assignProcessToRole(ByVal roleId As Integer, ByVal procId As Integer, ByRef retVal As Integer)
            Try

                db.execUpdate("mn_InsRoleProcess", New Object() {roleId, procId}, retVal)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class

End Namespace


