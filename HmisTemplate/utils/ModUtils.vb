Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Environment


Module ModUtils

    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()

        For i As Integer = 0 To nics.Length - 1
            If nics(i).NetworkInterfaceType = NetworkInterfaceType.Ethernet Then
                If nics(i).OperationalStatus = OperationalStatus.Up Then
                    Return nics(i).GetPhysicalAddress.ToString
                End If
            End If
        Next

        Return nics(0).GetPhysicalAddress.ToString

    End Function

End Module
