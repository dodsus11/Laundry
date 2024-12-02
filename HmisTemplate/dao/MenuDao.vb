Imports Ninject
Imports System.Windows.Forms
Imports DbLibs

Namespace dao

    Public Class MenuDao

        Public Property db As ClsDbase
        Private pathMenu As List(Of model.Menu)


        Public Function getModuleSys() As DataTable
            Try
                Return db.execQuery("MnGetModule")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getModuleSysByRoleId(ByVal roleId As Integer) As DataTable
            Try
                Return db.execQuery("Mn_GetModuleByRoleId", New Object() {roleId})
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getProcessByRoleId(ByVal roleId As Integer, ByVal moduleId As Integer) As DataTable
            Try
                Return db.execQuery("mn_GetProcessByRoleId", New Object() {roleId, moduleId})
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getSubMenu(ByVal moduleId As Integer) As DataTable
            Try
                Return db.execQuery("MnGetSubMenu", New Object() {moduleId})
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getMenuByID(ByVal menuId As Integer) As DataTable
            Try
                Return db.execQuery("MnGetMenuByID", New Object() {menuId})
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getChildMenuByParentId(ByVal parentId As Integer) As DataTable
            Try
                Return db.execQuery("MnGetChildMenu", New Object() {parentId})
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetPathMenuById(ByVal menuId As Integer, ByVal menuText As String) As List(Of model.Menu)
            Try
                pathMenu = New List(Of model.Menu)



                pathMenu.Add(New model.Menu() With {.menuId = menuId, _
                                                     .menuText = menuText})

                Me.makePathMenuById(menuId)

                Return Me.pathMenu

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub makePathMenuById(ByVal menuId As Integer)
            Try

                Dim dtMenu As DataTable = db.execQuery("MnGetParentMenu", New Object() {menuId})

                If dtMenu.Rows.Count > 0 Then

                    pathMenu.Add(New model.Menu() With {.menuId = dtMenu.Rows(0)("id"), _
                                                        .menuText = dtMenu.Rows(0)("caption")})

                    makePathMenuById(dtMenu.Rows(0)("id"))

                End If


            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function GetLinkAddrWebDokter() As String
            Try

                Dim sql As String = "SELECT ParamValue FROM CPIS WHERE ParamCode = 'USERDOKTER'"

                Return Me.db.execSQL(sql).Rows(0)(0).ToString()

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetRunTextBody() As DataTable
            Try

                Return Me.db.execSQL("SELECT TOP 1 * FROM display_run_text WHERE id = 1")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

End Namespace

