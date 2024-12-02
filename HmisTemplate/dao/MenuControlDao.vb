Imports Ninject
Imports System.Windows.Forms
Imports DbLibs

Namespace dao

    Public Class MenuControlDao

        Public Property db As ClsDbase

        Public Function getAllControlMenu() As DataTable
            Try

                Return db.execQuery("Mn_GetAllMenuControl")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'Public Function getAllRolesAndDesc() As DataTable
        '    Try

        '        Return db.execQuery("Sc_GetRolesAndDesc")

        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        Public Sub deleteControlMenu(ByVal id As Integer)
            Try

                db.execUpdate("Mn_DeleteControl", New Object() {id})

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub updateControlMenu(ByVal control As model.MenuControl)
            Try

                db.execUpdate("Mn_UpdMenuControl", New Object() {control.id, control.caption, control.dll_name, control.uc_name, control.icon_name, control.description})

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub insertControlMenu(ByVal control As model.MenuControl)
            Try

                db.execUpdate("Mn_InsMenuControl", New Object() {control.caption, control.dll_name, control.uc_name, control.icon_name, control.description})

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function isUsedControlMenu(ByVal id As Integer) As Boolean
            Try
                Dim dt As DataTable = db.execQuery("Mn_IsUsedControlMenu", New Object() {id})

                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function isExistControlMenu(ByVal caption As String) As Boolean
            Try
                Dim dt As DataTable = db.execQuery("Mn_IsExistControlMenu", New Object() {caption})

                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

End Namespace
