Public Class ClsConn

    Dim Connection As String = "User ID=sa;password=hmis@rsdk15;Initial Catalog=HMISDATA;Data Source=172.16.1.51;Persist Security Info=False;"
    'Dim Connection As String = "User ID=sa;password=hmis@rsdk15;Initial Catalog=HMISDATA;Data Source=172.16.1.141;Persist Security Info=False;"
    'Dim Connection As String = "User ID=dev;password=pwd4dev;Initial Catalog=HMISDATA;Data Source=172.16.1.141;Persist Security Info=False;"
    'Dim Connection As String = "User ID=developer;password=dev4rsdk#;Initial Catalog=HMISDATA;Data Source=172.16.3.40;Persist Security Info=False;"
    Dim Con As SqlClient.SqlConnection

    Public Function Spd_Gen(ByVal SpdName As String, ByVal objParam() As Object) As DataSet
        Dim ds As New DataSet
        Try
            Con = New SqlClient.SqlConnection(Connection)
            Con.Open()
            If IsNothing(objParam) Then
                ds = ExecuteDataset(Connection, SpdName)
            Else
                ds = ExecuteDataset(Connection, SpdName, objParam)
            End If
            Con.Close()
            Con.Dispose()
            GC.Collect()
            Return ds
        Catch e As Exception
            Con.Close()
            Con.Dispose()
            GC.Collect()
            Throw (e)
        End Try
    End Function

    Private Sub AttachParameters(ByVal command As System.Data.SqlClient.SqlCommand, ByVal commandParameters() As System.Data.SqlClient.SqlParameter)
        Dim p As System.Data.SqlClient.SqlParameter
        For Each p In commandParameters
            If p.Direction = ParameterDirection.InputOutput And p.Value Is Nothing Then
                p.Value = Nothing
            End If
            Try
                If p.Value = Nothing Then
                    p.Value = DBNull.Value
                End If
            Catch ex As Exception

            End Try
            command.Parameters.Add(p)
        Next p
    End Sub

    Private Sub AssignParameterValues(ByVal commandParameters() As System.Data.SqlClient.SqlParameter, ByVal parameterValues() As Object)

        Dim i As Short
        Dim j As Short

        If (commandParameters Is Nothing) And (parameterValues Is Nothing) Then
            Return
        End If

        If commandParameters.Length <> parameterValues.Length Then
            Throw New ArgumentException("Parameter count does not match Parameter Value count.")
        End If

        j = commandParameters.Length - 1
        For i = 0 To j
            commandParameters(i).Value = parameterValues(i)
        Next

    End Sub

    Private Sub PrepareCommand(ByVal command As System.Data.SqlClient.SqlCommand, _
                                      ByVal connection As System.Data.SqlClient.SqlConnection, _
                                      ByVal transaction As System.Data.SqlClient.SqlTransaction, _
                                      ByVal commandType As CommandType, _
                                      ByVal commandText As String, _
                                      ByVal commandParameters() As System.Data.SqlClient.SqlParameter)

        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If

        command.Connection = connection

        command.CommandText = commandText

        If Not (transaction Is Nothing) Then
            command.Transaction = transaction
        End If

        command.CommandType = commandType

        If Not (commandParameters Is Nothing) Then
            AttachParameters(command, commandParameters)
        End If

        Return
    End Sub

    Public Overloads Function ExecuteDataset(ByVal connectionString As String, _
                                                ByVal commandType As CommandType, _
                                                ByVal commandText As String, _
                                                ByVal ParamArray commandParameters() As System.Data.SqlClient.SqlParameter) As DataSet
        Dim cn As New System.Data.SqlClient.SqlConnection(connectionString)
        Try
            cn.Open()
            Return ExecuteDataset(cn, commandType, commandText, commandParameters)
        Finally
            cn.Close()
            cn.Dispose()
        End Try
    End Function

    Public Overloads Function ExecuteDataset(ByVal connectionString As String, _
                                                    ByVal spName As String, _
                                                    ByVal ParamArray parameterValues() As Object) As DataSet

        Dim commandParameters As System.Data.SqlClient.SqlParameter()

        If Not (parameterValues Is Nothing) And parameterValues.Length > 0 Then
            commandParameters = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName)

            AssignParameterValues(commandParameters, parameterValues)

            Return ExecuteDataset(connectionString, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteDataset(connectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    Public Overloads Function ExecuteDataset(ByVal connection As System.Data.SqlClient.SqlConnection, _
                                                    ByVal commandType As CommandType, _
                                                    ByVal commandText As String, _
                                                    ByVal ParamArray commandParameters() As System.Data.SqlClient.SqlParameter) As DataSet

        Dim cmd As New System.Data.SqlClient.SqlCommand
        Dim ds As New DataSet
        Dim da As System.Data.SqlClient.SqlDataAdapter

        PrepareCommand(cmd, connection, CType(Nothing, System.Data.SqlClient.SqlTransaction), commandType, commandText, commandParameters)

        da = New System.Data.SqlClient.SqlDataAdapter(cmd)

        da.Fill(ds)

        cmd.Parameters.Clear()

        Return ds

    End Function

    Public NotInheritable Class SqlHelperParameterCache

        Private Sub New()
        End Sub 'New 

        Private Shared paramCache As Hashtable = Hashtable.Synchronized(New Hashtable)


        Private Shared Function DiscoverSpParameterSet(ByVal connectionString As String, _
                                                       ByVal spName As String, _
                                                       ByVal includeReturnValueParameter As Boolean, _
                                                       ByVal ParamArray parameterValues() As Object) As System.Data.SqlClient.SqlParameter()

            Dim cn As New System.Data.SqlClient.SqlConnection(connectionString)
            Dim cmd As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand(spName, cn)
            Dim discoveredParameters() As System.Data.SqlClient.SqlParameter

            Try
                cn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                System.Data.SqlClient.SqlCommandBuilder.DeriveParameters(cmd)
                If Not includeReturnValueParameter Then
                    cmd.Parameters.RemoveAt(0)
                End If

                discoveredParameters = New System.Data.SqlClient.SqlParameter(cmd.Parameters.Count - 1) {}
                cmd.Parameters.CopyTo(discoveredParameters, 0)
            Finally
                cmd.Dispose()
                cn.Dispose()
                GC.Collect()
            End Try
            Return discoveredParameters
        End Function

        Private Shared Function CloneParameters(ByVal originalParameters() As System.Data.SqlClient.SqlParameter) As System.Data.SqlClient.SqlParameter()

            Dim i As Short
            Dim j As Short = originalParameters.Length - 1
            Dim clonedParameters(j) As System.Data.SqlClient.SqlParameter

            For i = 0 To j
                clonedParameters(i) = CType(CType(originalParameters(i), ICloneable).Clone, System.Data.SqlClient.SqlParameter)
            Next

            Return clonedParameters
        End Function

        Public Overloads Shared Function GetSpParameterSet(ByVal connectionString As String, ByVal spName As String) As System.Data.SqlClient.SqlParameter()
            Return GetSpParameterSet(connectionString, spName, False)

        End Function

        Public Overloads Shared Function GetSpParameterSet(ByVal connectionString As String, _
                                                           ByVal spName As String, _
                                                           ByVal includeReturnValueParameter As Boolean) As System.Data.SqlClient.SqlParameter()

            Dim cachedParameters() As System.Data.SqlClient.SqlParameter
            Dim hashKey As String

            hashKey = connectionString + ":" + spName + IIf(includeReturnValueParameter = True, ":include ReturnValue Parameter", "")

            cachedParameters = CType(paramCache(hashKey), System.Data.SqlClient.SqlParameter())
            If (cachedParameters Is Nothing) Then
                paramCache(hashKey) = DiscoverSpParameterSet(connectionString, spName, includeReturnValueParameter)
                cachedParameters = CType(paramCache(hashKey), System.Data.SqlClient.SqlParameter())

            End If

            Return CloneParameters(cachedParameters)

        End Function
    End Class
End Class

