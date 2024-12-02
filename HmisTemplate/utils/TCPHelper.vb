Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports System.Net
Imports HmisTemplate.TCPClient

Namespace TCPClient

    Public Class TCPHelper

        Private m_Proxy As IRegistration

        Public Sub MakeClient(EndpoindAddress As String, callbackinstance As Object)
            Dim NetTcpbinding As New NetTcpBinding(SecurityMode.None)
            Dim endpointAddress As New EndpointAddress(EndpoindAddress)
            Dim context As New InstanceContext(callbackinstance)
            m_Proxy = New RegistrationProxy(context, NetTcpbinding, endpointAddress)
        End Sub

        Public Sub Subscribe()
            m_Proxy.Register()
        End Sub

        Public Sub UnSubscribe(eventOperation As String)
            m_Proxy.UnRegister()
        End Sub

        Public Function GetDateTime() As [String]
            Return m_Proxy.GetDateTime()
        End Function

    End Class

End Namespace

