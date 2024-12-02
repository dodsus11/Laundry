Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model

Public Class FormCancelTrans
    Public header As TransaksiDelete
    Public headerIn As TransIn
    Public headerOut As TransOut
    Public linen As Linen
    Private linenSvr As ILinenService
    Public Property kodeLinen As Integer
    Public Property namalinen As String = ""
    Public Property jmllinen As Integer

    Private Function ValidateForm() As Boolean
        Dim result As Boolean = True
        If txtNamaPetugas.Text = "" Then
            MsgBox("Mohon isikan nama petugas", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        End If
        Return result
    End Function

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If Me.ValidateForm Then
            linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
            If MsgBox("Anda ingin membatalkan data transaksi " & label_transId.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") Then
                If header.jenisTransaksi = 1 Then
                    header.idTransaksi = label_transId.Text
                    header.cancelBy = txtNamaPetugas.Text
                    linenSvr.penguranganStokLinenByTransId(header.idTransaksi)
                    linenSvr.editCancelTransIn(header)
                    linenSvr.editCancelTransInDetailByTransId(header.idTransaksi)
                Else
                    header.idTransaksi = label_transId.Text
                    header.cancelBy = txtNamaPetugas.Text
                    linenSvr.penambahanStokLinenByTransId(header.idTransaksi)
                    linenSvr.editCancelTransOut(header)
                    linenSvr.editCancelTransOutDetailByTransId(header.idTransaksi)
                End If
                MsgBox("Data " & label_transId.Text & " berhasil dibatalkan")
            End If
            InProcFactory.CloseChannel(linenSvr)
            Me.Close()
        End If
    End Sub

    Private Sub FormCancelTrans_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        label_transId.Text = header.idTransaksi        
    End Sub
End Class