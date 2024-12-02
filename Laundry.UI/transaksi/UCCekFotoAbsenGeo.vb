Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Imports Laundry.UI.Utility

Public Class UCCekFotoAbsenGeo
    Private AbsenGeoService As IAbsenGeoService
    Dim dv As New DataView

    Private Sub UCCekFotoAbsenGeo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Loaddata(txtNip.Text, dtpTanggal.Value)

    End Sub

    Private Sub Loaddata(ByVal nip As String, ByVal tgl As Date)
        Try
            AbsenGeoService = InProcFactory.CreateChannel(Of AbsenGeoService, IAbsenGeoService)()
            Dim dt As New DataTable

            dt = AbsenGeoService.getLogTransaction(nip, tgl)
            dv.Table = dt
            dgv.DataSource = dv

            Dim col As New List(Of GridColumnModel)
            col.Add(GH.AddModelGridColumn("ID", 0))
            col.Add(GH.AddModelGridColumn("NIP", 0))
            col.Add(GH.AddModelGridColumn("Jam Absen", 100))
            col.Add(GH.AddModelGridColumn("Fotobyte", 0))
            col.Add(GH.AddModelGridColumn("Status", 130))
            GH.FormatGrid(dgv, dt, col, True, True, False, True)
            InProcFactory.CloseChannel(AbsenGeoService)

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Me.Loaddata(txtNip.Text, dtpTanggal.Value)
        'menampilkan nama pegawai
        AbsenGeoService = InProcFactory.CreateChannel(Of AbsenGeoService, IAbsenGeoService)()
        Dim nama As String
        nama = AbsenGeoService.getNamaPegawai(txtNip.Text)
        LabelNama.Text = nama
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        'menampilkan image dari geo
        Dim ms As System.IO.MemoryStream
        Dim FotoByte As Byte()
        FotoByte = Convert.FromBase64String(dgv.SelectedRows(0).DataBoundItem(3))
        Dim myimage As System.Drawing.Image
        ms = New System.IO.MemoryStream(FotoByte)
        myimage = System.Drawing.Image.FromStream(ms)
        PictureBox1.Image = myimage
        If myimage.Width > myimage.Height Then
            PictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        End If


        'menampilkan image dari simpeg
        AbsenGeoService = InProcFactory.CreateChannel(Of AbsenGeoService, IAbsenGeoService)()
        Dim foto As String
        Dim urlfoto As String
        foto = AbsenGeoService.getFotoSimpeg(txtNip.Text)
        urlfoto = "http://simpeg.rskariadi.id/" & foto
        Try
            PictureBox2.Load(urlfoto)
        Catch ex As Exception
            MessageBox.Show("Belum ada foto di Simpeg")
        End Try
        InProcFactory.CloseChannel(AbsenGeoService)
    End Sub

    Private Function GetImageFromURL(ByVal url As String) As Image

        Dim retVal As Image = Nothing

        Try
            If Not String.IsNullOrWhiteSpace(url) Then
                Dim req As System.Net.WebRequest = System.Net.WebRequest.Create(url.Trim)

                Using request As System.Net.WebResponse = req.GetResponse
                    Using stream As System.IO.Stream = request.GetResponseStream
                        retVal = New Bitmap(System.Drawing.Image.FromStream(stream))
                    End Using
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show(String.Format("An error occurred:{0}{0}{1}", _
                                          vbCrLf, ex.Message), _
                                          "Exception Thrown", _
                                          MessageBoxButtons.OK, _
                                          MessageBoxIcon.Warning)

        End Try

        Return retVal

    End Function

   
End Class
