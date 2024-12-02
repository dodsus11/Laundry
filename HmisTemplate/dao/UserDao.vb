Imports Ninject
Imports System.Windows.Forms
Imports DbLibs

Namespace dao

    Public Class UserDao

        Public Property db As ClsDbase

        Public Function getUsers() As DataTable
            Try
                Dim spName As String = "Sc_GetUsers"
                Return db.execQuery(spName)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub saveUserAndRole(ByVal user As model.User)
            Try
                Dim obj(3) As Object
                obj(0) = user.un
                obj(1) = user.pwd
                If 0 = user.karyawan_party_id Then
                    obj(2) = 0
                Else
                    obj(2) = user.karyawan_party_id
                End If

                Dim dt As DataTable = db.execQuery("Sc_InsUsers_Rev1", New Object() {user.un,
                                                                                     user.pwd,
                                                                                     CryptoUtil.DecryptTripleDES(user.pwd),
                                                                                     user.PegawaiId,
                                                                                     user.fullName})

                Dim userId As Integer = CInt(dt.Rows(0)(0))

                'save user to USERMASTER
                'Me.SaveOrUpdateUserMaster(user)

                'Dim userId As Integer = db.insertAndGenId("Sc_InsUsers", New Object() {user.un,
                '                                                                       user.pwd,
                '                                                                       obj(2),
                '                                                                       user.fullName})

                If String.Empty <> user.kodePoli Then
                    db.execUpdate("Sc_InsUserPoli", New Object() {userId, user.kodePoli, SessionInfo.uid})
                End If

                db.execUpdate("Sc_AssignRoleToUser", New Object() {userId, user.roleId})

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Private Sub SaveOrUpdateUserMaster(user As model.User)
            Try

                Me.db.execUpdate("ScMan_UsersAddUpdate", New Object() {user.un,
                                                                       user.pwd,
                                                                       user.Nip,
                                                                       user.fullName,
                                                                       user.Bagian})

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function isExistUn(ByVal un As String) As Boolean
            Try
                Dim dt As DataTable = db.execQuery("Sc_GetUserByUsername", New Object() {un})

                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getUserById(ByVal userId As Integer) As DataTable
            Try
                Dim dt As DataTable = db.execQuery("Sc_GetUserByID", New Object() {userId})
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function isExistRoleInUser(ByVal userName As String) As Boolean
            Try
                Dim jml As Integer = db.execScalar("Sc_GetRoleInUserByUsername", New Object() {userName})

                If jml > 0 Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getRootRoles() As DataTable
            Try

                Return Me.db.execQuery("Sc_GetRootRole")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getChildRolesById(ByVal roleId As Object) As DataTable
            Try

                Return db.execQuery("Sc_GetChildRoleByID", New Object() {roleId})

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub updateUser(ByVal user As model.User)
            Try
                Dim obj(6) As Object
                obj(0) = user.id
                obj(1) = user.un
                obj(2) = user.pwd

                If 0 = user.karyawan_party_id Then
                    obj(3) = DBNull.Value
                Else
                    obj(3) = user.karyawan_party_id
                End If

                If String.Empty <> user.kodePoli Then
                    obj(4) = user.kodePoli
                Else
                    obj(4) = DBNull.Value
                End If

                obj(5) = SessionInfo.uid
                '

                db.execUpdate("Sc_UpdateUsers_Rev1", New Object() {user.id,
                                                                   user.un,
                                                                   user.pwd,
                                                                   CryptoUtil.DecryptTripleDES(user.pwd),
                                                                   user.PegawaiId,
                                                                   obj(4),
                                                                   SessionInfo.uid,
                                                                   user.fullName})
                '[deprecated: 2016-11-08]
                'db.execUpdate("Sc_UpdateUsers", New Object() {user.id,
                '                                              user.un,
                '                                              user.pwd,
                '                                              obj(3),
                '                                              obj(4),
                '                                              SessionInfo.uid,
                '                                              user.fullName})

                db.execUpdate("Sc_UpdRoleByUID", New Object() {user.id, user.roleId})

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        'untuk transaksi role

        Public Function getAllRoles() As DataTable
            Try

                Return db.execQuery("Sc_GetRoles")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getAllRolesAndDesc() As DataTable
            Try

                Return db.execQuery("Sc_GetRolesAndDesc")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub deleteRole(ByVal role As model.Role)
            Try

                db.execUpdate("Sc_DeletetRole", New Object() {role.id})

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub updateRole(ByVal role As model.Role)
            Try

                db.execUpdate("Sc_UpdateRole", New Object() {role.id, role.role_name, role.desc})

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub insertRole(ByVal role As model.Role, ByVal copyRole As model.Role)
            Try
                If IsNothing(copyRole) Then
                    db.execUpdate("Sc_InsRoleTanpaParent", New Object() {role.role_name, role.desc})
                Else
                    Try
                        db.beginTransaction()
                        db.execUpdate("Sc_InsRoleWithCopy", New Object() {role.role_name, role.desc, copyRole.id})
                        db.commitTrans()
                    Catch ex As Exception
                        db.rollBackTrans()
                        Throw ex
                    End Try
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function isExistRole(ByVal role As String) As Boolean
            Try
                Dim dt As DataTable = db.execQuery("Sc_GetRoleByRolename", New Object() {role})

                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub assignRole(ByVal idUser As Integer, ByVal idRole As Integer)
            Try
                Dim dt As DataTable = db.execQuery("Sc_AssignRoleToUser", New Object() {idUser, idRole})
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub deleteUserInRole(ByVal idUser As Integer, ByRef retval As Integer)
            Try
                db.execUpdate("mn_delUserInroles", New Object() {idUser}, retval)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub deleteUser(ByVal idUser As Integer, ByRef retval As Integer)
            Try
                db.execUpdate("mn_delUser", New Object() {idUser}, retval)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getPegawai() As DataTable
            Try
                'Return db.execQuery("HRDPresensi_GetListPegawaiPresensi")
                Return db.execQuery("Emp_DaftarPegawai_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#Region "USER SIRUS -------------------------------------------------------------------------------"

        Public Function SirusUserList() As DataTable
            Try

                Return Me.db.execQuery("Sirs_UserList")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

    End Class

End Namespace

