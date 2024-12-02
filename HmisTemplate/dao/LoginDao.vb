Imports Ninject
Imports SessionInfo

Namespace dao
    Public Class LoginDao
        Public Property Db As DbLibs.ClsDbase

        Public Function validateLogin(ByVal dataLogin As model.User) As Boolean
            Dim tempUsername As String
            Dim dt As DataTable
            Dim obj() As Object = {dataLogin.un, dataLogin.pwd}
            Try

                '[plan to deprecated: 2016-11-08]
                dt = Db.execQuery("mn_ValidateLogin", obj)

                'auth using USERMASTER:67
                'dt = Db.execQuery("ScMan_ValidateLogin", obj)

                tempUsername = dt.Rows(0)("username").ToString
                If tempUsername = dataLogin.un Then
                    ModSessi.un = dt.Rows(0)("username").ToString
                    ModSessi.uid = dt.Rows(0)("user_id").ToString
                    ModSessi.roleId = dt.Rows(0)("role_id").ToString
                    ModSessi.roleName = dt.Rows(0)("role_name").ToString
                    ModSessi.kodePoli = dt.Rows(0)("poliCode").ToString()
                    ModSessi.BuildingID = dt.Rows(0)("building_id").ToString()
                    ModSessi.fullName = dt.Rows(0)("nama_lengkap").ToString()
                    ModSessi.nik = dt.Rows(0)("nik").ToString
                    SessionInfo.notif = New Windows.Forms.NotifyIcon() With {.Tag = ModUtils.getMacAddress()}

                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
            Return False
        End Function

        'Public Function ChangePwd(ByVal dataLogin As model.User, ByVal newPwd As String) As Boolean

        '    Dim encryptPwd As String = CryptoUtil.EncryptTripleDES(newPwd)

        '    Dim dt As DataTable
        '    Dim obj() As Object = {dataLogin.un, dataLogin.pwd}
        '    Try
        '        dt = Db.execQuery("mn_ValidateLogin", obj)

        '        If dt.Rows.Count = 0 Then
        '            Return False
        '        End If

        '        'update password
        '        Dim SQL As String = "UPDATE mn_Users SET password = @pwd WHERE id = @uid"

        '        Db.execSQL(SQL, New String() {"@pwd", "@uid"}, New Object() {encryptPwd, SessionInfo.uid})

        '        Return True

        '    Catch ex As Exception
        '        Return False
        '    End Try
        '    Return False
        'End Function

        Public Function ChangePwd(ByVal dataLogin As model.User, ByVal newPwd As String) As Boolean

            Dim encryptPwd As String = CryptoUtil.EncryptTripleDES(newPwd)

            Dim dt As DataTable
            Dim obj() As Object = {dataLogin.un, dataLogin.pwd}
            Try
                dt = Db.execQuery("mn_ValidateLogin", obj)

                If dt.Rows.Count = 0 Then
                    Return False
                End If

                'update password
                Dim SQL As String = "exec procUpdatePasswordHMIS '" & SessionInfo.uid & "','" & encryptPwd & "','" & newPwd & "','" & SessionInfo.un & "'"

                Db.execSQL(SQL)

                Return True

            Catch ex As Exception
                Return False
            End Try
            Return False
        End Function

        Public Sub setColorToSession()
            Try
                Dim str As String = Db.execScalar("Utils_CPIS", New Object() {"TEXTCOLOR"}).ToString

                Dim tmp() As String = Split(str, ",", , CompareMethod.Text)

                ModSessi.colorText = {tmp(0), tmp(1), tmp(2)}


            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class

End Namespace

