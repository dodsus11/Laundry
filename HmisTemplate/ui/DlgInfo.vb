Imports System.Threading
Imports System.Globalization

Public Class DlgInfo

    Dim sb As New System.Text.StringBuilder()

    Private Sub DlgInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim strHostName As String
        Dim strIPAddress As String

        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = Me.GetIPv4Address()

        sb.Clear()

        sb.AppendLine(String.Format("Pc Name    : {0}", strHostName))
        sb.AppendLine(String.Format("IP Address : {0}", strIPAddress))
        sb.AppendLine(String.Format("Regional   : {0}", Thread.CurrentThread.CurrentCulture.DisplayName.ToString()))

        lblData.Text = sb.ToString()

    End Sub

    Private Function GetIPv4Address() As String
        Dim sbIp As New System.Text.StringBuilder()

        GetIPv4Address = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                Return ipheal.ToString()
            End If

            'If ipheal.ToString().Substring(0, 3) = "172" Then
            '    Return ipheal.ToString()
            'End If
        Next

        Return String.Empty

    End Function



End Class