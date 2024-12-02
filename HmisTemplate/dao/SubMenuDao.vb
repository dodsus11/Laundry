Imports Ninject
Imports DbLibs

Namespace dao

    Public Class SubMenuDao

        Public Property db As ClsDbase

        Public Function getProcessMenuById(ByVal processId As Integer) As DataTable
            Try

                Return db.execQuery("mn_GetProcessMenuById", New Object() {processId})

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub AddProcMenu(ByVal menu As model.MenuProcess)
            Try
                If menu.parentId = 0 Then
                    db.execUpdate("Mn_InsProcessMenu", New Object() {menu.caption, _
                                                                     menu.processId, _
                                                                     Nothing, _
                                                                     menu.icon})
                Else
                    db.execUpdate("Mn_InsProcessMenu", New Object() {menu.caption, _
                                                                     menu.processId, _
                                                                     menu.parentId, _
                                                                     menu.icon})
                End If


            Catch ex As Exception
                Throw ex
            End Try
        End Sub


        Public Sub removeProcMenu(ByVal procMenuId As Integer, ByRef returnVal As Integer)
            Try

                db.execUpdate("Mn_DelProcessMenu", New Object() {procMenuId}, returnVal)


            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub assignControlToMenu(ByVal menuId As Integer, ByVal controlId As Integer)
            Try

                'Mn_AssignControlToProcessMenu
                If controlId = 0 Then
                    db.execUpdate("Mn_AssignControlToProcessMenu", New Object() {menuId, Nothing})
                Else
                    db.execUpdate("Mn_AssignControlToProcessMenu", New Object() {menuId, controlId})
                End If


            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getMenuPermissionByRoleAndProcess(ByVal roleId As Integer, ByVal procId As Integer) As DataTable
            Try

                Return db.execQuery("mn_GetPermissionByRoleAndProcess", New Object() {roleId, procId})

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub assignPermissionToMenu(ByVal roleId As Integer, _
                                          ByVal procId As Integer, _
                                          ByVal permissions As List(Of model.RolePermission))
            Try

                For Each itm As model.RolePermission In permissions

                    Dim values() As Object = {roleId, _
                                              procId, _
                                              itm.procMenuId, _
                                              itm.allowView, _
                                              itm.allowPrint, _
                                              itm.allowSave, _
                                              itm.allowEdit, _
                                              itm.allowDelete,
                                              itm.allowUnlock}

                    db.execUpdate("Sc_InsRolePermission", values)

                Next


            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class

End Namespace

