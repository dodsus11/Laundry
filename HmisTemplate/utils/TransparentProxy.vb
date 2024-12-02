Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ServiceModel
Imports System.Runtime.Serialization

Namespace TCPClient

    <ServiceContract()>
    Public Interface IEvent

        <OperationContract(isOneway:=True)>
        Sub OnEvent(e As AlertData)

    End Interface

    <ServiceContract(CallbackContract:=GetType(IEvent))>
    Public Interface IRegistration

        <OperationContract()>
        Sub Register()

        <OperationContract()>
        Sub UnRegister()

        <OperationContract()>
        Function GetDateTime() As String

    End Interface

    Partial Public Class RegistrationProxy
        Inherits DuplexClientBase(Of IRegistration)
        Implements IRegistration

        Public Sub New(callbackInstance As System.ServiceModel.InstanceContext)
            MyBase.New(callbackInstance)
        End Sub

        Public Sub New(callbackInstance As System.ServiceModel.InstanceContext, endpointConfigurationName As String)
            MyBase.New(callbackInstance, endpointConfigurationName)
        End Sub

        Public Sub New(callbackInstance As System.ServiceModel.InstanceContext, endpointConfigurationName As String, remoteAddress As String)
            MyBase.New(callbackInstance, endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(callbackInstance As System.ServiceModel.InstanceContext, endpointConfigurationName As String, remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(callbackInstance, endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(callbackInstance As System.ServiceModel.InstanceContext, binding As System.ServiceModel.Channels.Binding, remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(callbackInstance, binding, remoteAddress)
        End Sub


        'implement method
        Public Function GetDateTime() As String Implements IRegistration.GetDateTime
            Return MyBase.Channel.GetDateTime()
        End Function

        Public Sub Register() Implements IRegistration.Register
            Try
                MyBase.Channel.Register()
            Catch ex As EndpointNotFoundException
                ' System.Windows.Forms.MessageBox.Show("CIC is off.Please start the CIC first then try to connect");
                '  throw ex;
                Throw New ApplicationException("cenntral messaging server is off.Please start the cenntral messaging server first then try to connect")
            Catch ex As CommunicationException
                '  System.Windows.Forms.MessageBox.Show("CIC is off.Please start the CIC first then try to connect");
                ' throw ex;
                Throw New ApplicationException("cenntral messaging server is off.Please start the cenntral messaging server first then try to connect")
            End Try
        End Sub

        Public Sub UnRegister() Implements IRegistration.UnRegister
            MyBase.Channel.UnRegister()
        End Sub
    End Class

End Namespace
