Imports System.Threading
Imports HmisServer.FrmService

Public Class Service1

    Private svrThread As Thread
    Private bStopThread As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.ServiceName = "Service HMIS"

    End Sub

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.

        bStopThread = False
        Me.svrThread = New Thread(AddressOf callService)
        Me.svrThread.Start()

    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.

        bStopThread = True
        Me.svrThread.Join(TimeSpan.FromSeconds(20))
        Try

            If Me.svrThread.ThreadState = System.Threading.ThreadState.Running Then

                Me.svrThread.Abort()

            End If

        Catch ex As Exception

        End Try

    End Sub


End Class
