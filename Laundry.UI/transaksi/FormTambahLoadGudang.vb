﻿Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model

Public Class FormTambahLoadGudang
    Public linen As Linen
    Private linenSvr As ILinenService
    Public Property idlinen As Integer
    Public Property namalinen As String = ""
    Public Property kodelinen As String = ""
    Public Property materiallinen As String = ""
    Public Property jmllinen As Integer

    Private Function ValidateForm() As Boolean
        Dim result As Boolean = True
        If txtKodeLinen.Text = "" Then
            MsgBox("Pemilihan Linen Masih Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf String.IsNullOrEmpty(txtQtyLinen.Text) Then
            MsgBox("Jumlah Linen Masih Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf rbMaterialLinenPutih.Checked = False And rbMaterialLinenWarna.Checked = False Then
            MsgBox("Material Linen Belum Dipilih", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        End If
        Return result
    End Function

    Private Sub btnLookUpLinen_Click(sender As System.Object, e As System.EventArgs) Handles btnLookUpLinen.Click
        Me.linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"jns_linen_kode", "Kode Linen", 80},
                              {"jns_linen_nama", "Nama Linen", 200}}

        frmLookUp.keyField = "jns_linen_kode"        
        frmLookUp.fields = {"jns_linen_nama"}

        frmLookUp.dt = Me.linenSvr.tampilLinenAktif()

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtKodeLinen.Text = frmLookUp.returnRow("jns_linen_kode").ToString()
            txtNamaLinen.Text = frmLookUp.returnRow("jns_linen_nama").ToString()
            txtKodeLinen.Tag = frmLookUp.returnRow("jns_linen_id").ToString()
        End If
        InProcFactory.CloseChannel(Me.linenSvr)
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If Me.ValidateForm Then
            If MsgBox("Anda akan order Laundry  " & txtNamaLinen.Text & " sebanyak " & txtQtyLinen.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Try
                    idlinen = txtKodeLinen.Tag
                    namalinen = txtNamaLinen.Text
                    kodelinen = txtKodeLinen.Text
                    If rbMaterialLinenPutih.Checked = True Then
                        materiallinen = "Putih"
                    End If
                    If rbMaterialLinenWarna.Checked = True Then
                        materiallinen = "Warna"
                    End If
                    jmllinen = CInt(txtQtyLinen.Text)
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

End Class