Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model

Public Class FormTambahPembersih
    Public pembersih As Pembersih
    Private pembersihSvr As IPembersihService
    Public Property bahanpembersih As String = ""
    Public Property berat_linen As String
    Public Property jenis_linen As Integer

    Public Sub New(ByRef beratlinen As String, ByRef jenislinen As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        berat_linen = beratlinen
        jenis_linen = jenislinen
        loaddata()
    End Sub

    Private Sub loaddata()
        beratlinen.Text = Me.berat_linen
        jenislinen.Text = Me.jenis_linen
    End Sub

    Private Function ValidateForm() As Boolean
        Dim result As Boolean = True
        If txtNamaPembersih.Text = "" Then
            MsgBox("Pemilihan Pembersih Masih Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf txtQtyPembersih.Text = "" Then
            MsgBox("Qty Pembersih Masih Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False        
        End If
        Return result
    End Function

    Private Sub btnLookUpLinen_Click(sender As System.Object, e As System.EventArgs) Handles btnLookUpLinen.Click
        Me.pembersihSvr = InProcFactory.CreateChannel(Of PembersihService, IPembersihService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"nomer", "No", 40},
                              {"idPembersih", "ID Pembersih", 100},
                              {"nama_bahan_pembersih", "Bahan Pembersih", 125},
                              {"vol", "Volume pembersih (cc)", 150},
                              {"linen_infeksius", "Utk linen infeksius (kg)", 150},
                              {"linen_noninfeksius", "Utk linen noninfeksius (kg)", 170}}

        frmLookUp.keyField = "idPembersih"
        frmLookUp.fields = {"nomer", "nama_bahan_pembersih"}

        frmLookUp.dt = Me.pembersihSvr.getMasterPembersihGeneral()

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtNamaPembersih.Text = frmLookUp.returnRow("nama_bahan_pembersih").ToString()
            txtNamaPembersih.Tag = frmLookUp.returnRow("idPembersih").ToString()
            If Me.jenis_linen = 0 Then 'infeksius
                Dim volpembersih As Integer = frmLookUp.returnRow("vol")
                Dim kapasitaslinen As Integer = frmLookUp.returnRow("linen_infeksius")
                Dim hasilbagikapasitaslinen As Double
                Dim volpembersihygdidapatkan As Double
                hasilbagikapasitaslinen = kapasitaslinen / Me.berat_linen
                volpembersihygdidapatkan = volpembersih / hasilbagikapasitaslinen
                txtQtyPembersih.Text = volpembersihygdidapatkan
            Else 'noninfeksius
                Dim volpembersih As Decimal = frmLookUp.returnRow("vol")
                Dim kapasitaslinen As Decimal = frmLookUp.returnRow("linen_noninfeksius")
                Dim hasilbagikapasitaslinen As Decimal
                Dim volpembersihygdidapatkan As Decimal
                Dim brtlinen As Decimal = Me.berat_linen
                hasilbagikapasitaslinen = kapasitaslinen / brtlinen
                volpembersihygdidapatkan = volpembersih / hasilbagikapasitaslinen
                txtQtyPembersih.Text = FormatNumber(volpembersihygdidapatkan, 2)
            End If
        End If
        InProcFactory.CloseChannel(Me.pembersihSvr)
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If Me.ValidateForm Then
            If MsgBox("Anda akan input bahan pembersih  " & txtNamaPembersih.Text & "sebanyak " & txtQtyPembersih.Text & "Cc?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Try
                    bahanpembersih = txtNamaPembersih.Text & " (" & txtQtyPembersih.Text & ")"
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    
End Class