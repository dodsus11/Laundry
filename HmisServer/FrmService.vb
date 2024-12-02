Public Class FrmService

    Private Sub FrmService_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "HMIS Service v 3.7.52"

        'server.FinanceService.RunService()
        'server.HRDService.RunService()
        'server.MMHost.RunService()
        server.PharmacyService.RunService()
        server.PISService.RunService()
        server.PISService.RunServiceIRNA()

        'operating theaters
        server.PISService.RunServiceOT()

        'DoctorFingerPrint
        server.DoctorFingerprintService.RunService()
        server.BiosService.RunServiceBIOS()
        server.CSSDService.RunServiceCSSD()

        'laundry
        server.LaundryService.RunService()

        'bloodbank
        server.bloodservice.RunServiceBloodBank()

        lblStatus.Text = "Service Running..."

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        'server.FinanceService.RunService()
        'server.HRDService.RunService()
        'server.MMHost.RunService()
        'server.PharmacyService.RunService()
        server.PISService.RunService()
        server.PISService.RunServiceIRNA()

        MsgBox("Service Running")

        lblStatus.Text = "Service Running..."
    End Sub

    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStop.Click
        lblStatus.Text = "Service Stop"
    End Sub

End Class