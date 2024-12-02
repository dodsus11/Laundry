Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model
Imports System.Windows.Forms

Public Class FormQtyDistribusi
    Public linen As Linen
    Public detail As OrderDetail
    Private distrSvr As IDistribusiService
    Private loadSvr As ILoadGudangService
    Public Property kodelinen As String = ""
    Public Property namalinen As String = ""    
    Public Property jmlorder As Integer
    Public Property jmlterdist As Integer
    Public Property jmlblmdistr As Integer
    Public Property jmldistr As Integer
    Public Property iddetail As Integer
    Public Property _acl As SessionInfo.ACLUser

    Public Property acl As SessionInfo.ACLUser
        Get
            If _acl Is Nothing Then
                Return CType(Me.Tag, SessionInfo.ACLUser)
            Else
                Return _acl
            End If
        End Get
        Set(ByVal value As SessionInfo.ACLUser)
            _acl = value
        End Set
    End Property

    Public Sub New(ByRef linenkode As String, ByRef linenNama As String, ByRef qty As Integer, ByRef terdisr As Integer, ByRef blmdistr As Integer, ByRef detailid As Integer)
        InitializeComponent()
        kodelinen = linenkode
        namalinen = linenNama
        jmlorder = qty
        jmlterdist = terdisr
        jmlblmdistr = blmdistr
        iddetail = detailid
        Loaddata()
    End Sub

    Private Sub Loaddata()
        txtKodeLinen.Text = Me.kodelinen
        txtNamaLinen.Text = Me.namalinen
        txtQtyOrder.Text = Me.jmlorder
        txtTerdistribusi.Text = Me.jmlterdist
        txtBlmDistr.Text = Me.jmlblmdistr
        txtQtyDistribusi.Text = Me.jmlorder
    End Sub

    Private Function ValidateForm() As Boolean
        Dim result As Boolean = True
        Dim distribusi, blmdistribusi As Integer
        distribusi = txtQtyDistribusi.Text
        blmdistribusi = txtBlmDistr.Text
        If String.IsNullOrEmpty(distribusi) Then
            MsgBox("Jumlah Distribusi Masih Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        End If
        If distribusi > blmdistribusi Then
            MsgBox("Jumlah Distribusi tidak boleh melebihi jumlah yang belum terdistribusi", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        End If
        Return result
    End Function

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If Me.ValidateForm Then
            'memeriksa apakah stok linen gudang mencukupi atau tidak
            loadSvr = InProcFactory.CreateChannel(Of LoadGudangService, ILoadGudangService)()
            Dim jmlerror As Integer
            jmlerror = loadSvr.cekStokLinenByKodeLinen_jmlLinen(txtKodeLinen.Text, txtQtyDistribusi.Text)
            If jmlerror > 0 Then
                MessageBox.Show("Stok gudang linen " & txtNamaLinen.Text & " tidak mencukupi untuk dikurangi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MsgBox("Anda akan distribusi Laundry  " & txtNamaLinen.Text & " sebanyak " & txtQtyDistribusi.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        Me.jmldistr = CInt(txtQtyDistribusi.Text)
                        Me.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If            
        End If
    End Sub

End Class