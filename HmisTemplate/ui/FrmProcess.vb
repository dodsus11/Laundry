Imports Ninject
Imports DbLibs
Imports System.Drawing

Public Class FrmProcess

    Public menuDao As dao.MenuDao
    Friend moduleId As Integer = 0
    Friend processId As Integer = 0
    Friend processName As String = ""

    Dim dtProcess As DataTable
    Dim iconList As New List(Of DataPanel)
    Dim isEnterPanel As Boolean = True

    Private Sub FrmProcess_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub FrmProcess_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Me.generateIcon()

        Me.populateIcons()
        Me.showIcon2Panel()

        'txtKode.Text = CryptoUtil.getMd5Hash("123")
        pnTop.BackColor = Color.FromArgb(237, 163, 56)
        'pnTop.BackColor = Color.FromArgb(130, 131, 135)

        pnIcon.BackColor = Color.FromArgb(253, 233, 217)
        'pnIcon.BackColor = Color.FromArgb(51, 51, 51)
        'pnIcon.BackgroundImage = Image.FromFile("images/bd-deco.gif")
        pnIcon.BackgroundImage = UILibs.MyResources.GetBitmap("orange copy.png")   'Image.FromFile("images/orange copy.png")
        pnIcon.BackgroundImageLayout = ImageLayout.Stretch

        'load icon from dbase


    End Sub

    Private Sub populateIcons()

        dtProcess = menuDao.getProcessByRoleId(SessionInfo.ModSessi.roleId, Me.moduleId)
        Dim y As Integer = 15
        Dim x As Integer = 1

        Dim i As Integer = 0

        For Each row As DataRow In dtProcess.Rows
            Dim panelData As New DataPanel()

            With panelData
                .index = i
                .id = row("id")
                .caption = row("process_name").ToString()

                '.image = "images\" & row("icon_name").ToString()
                .image = row("icon_name").ToString()
                .tinggi = 95
                .lebar = 85

                'untuk caption jadi 2 kata
                If row("process_name").ToString().Length > 12 Then
                    'MsgBox(row("process_name").ToString().Length)

                    Dim isiTxt As String
                    Dim dibagi() As String
                    Dim kata1 As String = ""
                    Dim kata2 As String = ""
                    Dim kata3 As String = ""

                    isiTxt = row("process_name").ToString()

                    'Split
                    dibagi = Split(isiTxt, " ")
                    Dim m As Integer
                    If dibagi.Length = 2 Then
                        For m = 0 To dibagi.Length
                            kata1 = dibagi(0)
                            kata2 = dibagi(1)
                        Next
                    ElseIf dibagi.Length = 3 Then
                        For m = 0 To dibagi.Length
                            kata1 = dibagi(0)
                            kata2 = dibagi(1)
                            kata3 = dibagi(2)
                        Next
                    End If
                    

                    If kata2.Length + kata3.Length + 1 >= 12 Then
                        If (kata2.Length <= 5) And (kata3.Length <= 5) Then
                            .caption = (kata1 + vbNewLine + "   " + kata2 + vbNewLine + "   " + kata3)
                            '.caption = StringAlignment.Center
                            .tinggi = 110
                        ElseIf (kata2.Length <= 5) And (kata3.Length >= 5) Then
                            .caption = (kata1 + vbNewLine + "   " + kata2 + vbNewLine + kata3)
                            '.caption = StringAlignment.Center
                            .tinggi = 110
                        ElseIf (kata2.Length >= 5) And (kata3.Length <= 5) Then
                            .caption = (kata1 + vbNewLine + kata2 + vbNewLine + "   " + kata3)
                            '.caption = StringAlignment.Center
                            .tinggi = 110
                        Else
                            .caption = (kata1 + vbNewLine + kata2 + vbNewLine + kata3)
                            '.caption = StringAlignment.Center
                            .tinggi = 110
                        End If
                        
                    ElseIf kata2.Length + kata3.Length + 1 <= 5 Then
                        .caption = (kata1 + vbNewLine + "   " + kata2 + " " + kata3)
                        '.caption = StringAlignment.Center
                        .tinggi = 95
                    Else
                        .caption = (kata1 + vbNewLine + kata2 + " " + kata3)
                        '.caption = StringAlignment.Center
                        .tinggi = 100
                    End If


                End If
                'untuk geser kanan
                If x = 1 Then
                    .lokasi_X = 35
                Else
                    .lokasi_X = ((x - 1) * .lebar) + (x * 25)
                End If

                .lokasi_Y = y

                'Me.Controls.Add(panel)
                Me.iconList.Add(panelData)


                i += 1

                'untuk geser bawah
                If i Mod 4 = 0 Then
                    y += .tinggi + 30
                    x = 1
                    Continue For
                End If

                x += 1

            End With


        Next ' end for 

    End Sub

    Sub showIcon2Panel()
        For Each dp As DataPanel In Me.iconList
            Dim myPanel As New Panel()

            myPanel.Tag = dp

            myPanel.Width = dp.lebar
            myPanel.Height = dp.tinggi
            myPanel.BackColor = Color.Transparent

            'paint panel
            AddHandler myPanel.Paint, AddressOf Panel_Paint
            AddHandler myPanel.MouseEnter, AddressOf myPanel_MouseEnter
            AddHandler myPanel.MouseLeave, AddressOf myPanel_MouseLeave

            myPanel.BorderStyle = BorderStyle.None

            'lokasi
            myPanel.Left = dp.lokasi_X
            myPanel.Top = dp.lokasi_Y

            myPanel.Cursor = Cursors.Hand

            'add panel to iconpanel
            Me.pnIcon.Controls.Add(myPanel)
        Next
    End Sub

#Region "Event Mouse for panel"

    Private Sub myPanel_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)


        Dim myPanel As Panel = CType(sender, Panel)

        Dim dp As DataPanel = CType(myPanel.Tag, DataPanel)
        'dp.state = 2

        'If dp.isEnterPanel = False Then Return
        If dp.state = 2 Then Return

        Me.pnIcon.Controls.Remove(sender)

        myPanel.Tag = dp

        myPanel.Width = dp.lebar
        myPanel.Height = dp.tinggi
        myPanel.BackColor = Color.Transparent


        'paint panel
        AddHandler myPanel.Paint, AddressOf Panel_PaintZoomOut
        AddHandler myPanel.Click, AddressOf Panel1_Click

        'AddHandler myPanel.MouseEnter, AddressOf myPanel_MouseEnter


        myPanel.BorderStyle = BorderStyle.None

        'lokasi
        myPanel.Left = dp.lokasi_X
        myPanel.Top = dp.lokasi_Y

        myPanel.Cursor = Cursors.Hand

        'update isenter panel
        dp.state = 2
        myPanel.Tag = dp

        'add panel to iconpanel
        Me.pnIcon.Controls.Add(myPanel)




    End Sub

    Private Sub myPanel_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)

        Dim myPanel As Panel = CType(sender, Panel)

        Dim dp As DataPanel = CType(myPanel.Tag, DataPanel)

        'dp.state = 3

        'If dp.isEnterPanel = True Then Return
        If dp.state = 3 Then Return
        Me.pnIcon.Controls.Remove(sender)

        myPanel.Tag = dp

        myPanel.Width = dp.lebar
        myPanel.Height = dp.tinggi
        myPanel.BackColor = Color.Transparent


        'paint panel
        AddHandler myPanel.Paint, AddressOf Panel_PaintZoomIn
        AddHandler myPanel.Click, AddressOf Panel1_Click
        

        myPanel.BorderStyle = BorderStyle.None

        'lokasi
        myPanel.Left = dp.lokasi_X
        myPanel.Top = dp.lokasi_Y

        myPanel.Cursor = Cursors.Hand

        'update isenter panel
        dp.state = 3
        myPanel.Tag = dp

        'add panel to iconpanel
        Me.pnIcon.Controls.Add(myPanel)


    End Sub

#End Region

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.pnIcon.Controls.RemoveAt(1)

        Dim myPanel As New Panel()
        Dim dp As DataPanel = iconList(1)

        myPanel.Tag = dp

        myPanel.Width = dp.lebar
        myPanel.Height = dp.tinggi
        myPanel.BackColor = Color.Transparent


        'paint panel
        AddHandler myPanel.Paint, AddressOf Panel_PaintZoomOut


        myPanel.BorderStyle = BorderStyle.FixedSingle

        'lokasi
        myPanel.Left = dp.lokasi_X
        myPanel.Top = dp.lokasi_Y

        myPanel.Cursor = Cursors.Hand

        'add panel to iconpanel
        Me.pnIcon.Controls.Add(myPanel)

    End Sub


    Private Sub generateIcon()

        Dim y As Integer = 15
        Dim x As Integer = 1


        'Me.Controls.Clear()
        'Me.Controls.Add(btnSetUlang)
        'Me.pnIcon.Controls.Clear()

        'Dim dtProcess As DataTable = menuDao.getProcessByRoleId(SessionInfo.ModSessi.roleId, Me.moduleId)

        Dim i As Integer = 0

        For Each row As DataRow In dtProcess.Rows

            Dim panel As New Panel
            'panel.Tag = row("id") 'intloop
            panel.Tag = New DataPanel() With {.id = row("id"),
                                              .caption = row("process_name"),
                                              .image = "images\" & row("icon_name")}

            AddHandler panel.Click, New EventHandler(AddressOf Panel1_Click)
            AddHandler panel.MouseEnter, New EventHandler(AddressOf panel_mouseHover)
            AddHandler panel.MouseLeave, New EventHandler(AddressOf panel_mouseLeave)
            AddHandler panel.Paint, AddressOf Panel_Paint


            panel.Width = 80
            panel.Height = 85
            panel.BackColor = Color.Transparent




            panel.BorderStyle = BorderStyle.None

            panel.Top = y

            panel.Cursor = Cursors.Hand

            'set label icon
            'Dim lblcaption As New Label()
            'lblcaption.Text = row("process_name")
            'panel.Controls.Add(lblcaption)
            'lblcaption.Dock = DockStyle.Bottom
            'lblcaption.TextAlign = ContentAlignment.MiddleCenter

            'untuk geser kanan
            If x = 1 Then
                panel.Left = 35
            Else
                panel.Left = ((x - 1) * panel.Width) + (x * 25)
            End If

            'Me.Controls.Add(panel)
            Me.pnIcon.Controls.Add(panel)

            i += 1

            'untuk geser bawah
            If i Mod 4 = 0 Then
                y += panel.Height + 30
                x = 1

                Continue For
            End If

            x += 1


        Next


    End Sub

    Private Sub Panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        'drawing image in panel



        Dim pn As Panel = CType(sender, Panel)

        Dim dp As DataPanel = CType(pn.Tag, DataPanel)

        'MsgBox("paint panel:" & dp.isEnterPanel)

        If dp.state <> 1 Then Return



        Dim g As Graphics = e.Graphics()
        'Dim bm As Bitmap = Bitmap.FromFile(CType(pn.Tag, DataPanel).image)
        Dim bm As Bitmap = UILibs.MyResources.GetBitmap(CType(pn.Tag, DataPanel).image)

        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.DrawImage(bm, New Rectangle(10, 0, 50, 50), New Rectangle(0, 0, bm.Width, _
                    bm.Height), GraphicsUnit.Pixel)

        addStringToPanel(pn, 50)
       

    End Sub

    Private Sub Panel_PaintZoomOut(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim pn As Panel = CType(sender, Panel)
        Dim g As Graphics = e.Graphics()

        Dim dp As DataPanel = CType(pn.Tag, DataPanel)



        If dp.state = 3 Then Return

        'MsgBox("zoom out")

        'Dim bm As Bitmap = Bitmap.FromFile(CType(pn.Tag, DataPanel).image)
        Dim bm As Bitmap = UILibs.MyResources.GetBitmap(CType(pn.Tag, DataPanel).image)

        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.DrawImage(bm, New Rectangle(0, 0, 70, 70), New Rectangle(0, 0, bm.Width, _
                    bm.Height), GraphicsUnit.Pixel)

        addStringToPanel(pn, 70)
    End Sub

    Private Sub Panel_PaintZoomIn(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim pn As Panel = CType(sender, Panel)
        Dim g As Graphics = e.Graphics()

        Dim dp As DataPanel = CType(pn.Tag, DataPanel)

        'If dp.isEnterPanel = True Then Return
        If dp.state = 2 Then Return
        'MsgBox("zoom in")


        'Dim bm As Bitmap = Bitmap.FromFile(CType(pn.Tag, DataPanel).image)
        Dim bm As Bitmap = UILibs.MyResources.GetBitmap(CType(pn.Tag, DataPanel).image)

        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.DrawImage(bm, New Rectangle(10, 0, 50, 50), New Rectangle(0, 0, bm.Width, _
                    bm.Height), GraphicsUnit.Pixel)

        addStringToPanel(pn, 50)
    End Sub

    Private Sub Panel_PaintZoomOut(ByVal pn As Panel)
        'drawing image in panel
        Dim g As Graphics = pn.CreateGraphics()

        'fill backcolor
        'Dim brs As New SolidBrush(pn.BackColor)
        'g.FillRectangle(brs, 0, 0, pn.Width, pn.Height)

        ''draw border
        'g.DrawRectangle(Pens.Blue, 0, 0, pn.Width - 1, pn.Height - 1)

        'Dim bm As Bitmap = Bitmap.FromFile("images/Search.ico")
        Dim bm As Bitmap = Bitmap.FromFile(CType(pn.Tag, DataPanel).image)

        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.DrawImage(bm, New Rectangle(10, 0, 70, 70), New Rectangle(0, 0, bm.Width, _
                    bm.Height), GraphicsUnit.Pixel)
    End Sub

    Private Sub Panel_PaintZoomIn(ByVal pn As Panel)


        'drawing image in panel
        Dim g As Graphics = pn.CreateGraphics()


        ''fill backcolor
        'Dim brs As New SolidBrush(pn.BackColor)
        'g.FillRectangle(brs, 0, 0, pn.Width, pn.Height)


        ''draw border
        'g.DrawRectangle(Pens.Black, 0, 0, pn.Width, pn.Height)

        'Dim bm As Bitmap = Bitmap.FromFile("images/Search.ico")
        Dim bm As Bitmap = Bitmap.FromFile(CType(pn.Tag, DataPanel).image)

        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.DrawImage(bm, New Rectangle(10, 0, 50, 50), New Rectangle(0, 0, bm.Width, _
                    bm.Height), GraphicsUnit.Pixel)

    End Sub

    Private Sub panel_mouseHover(ByVal sender As System.Object, ByVal e As EventArgs)
        generateIcon()

        Dim id As Integer
        Dim btn As Panel = CType(sender, Panel)
        id = CType(btn.Tag, DataPanel).id

       
        Me.Panel_PaintZoomOut(btn)
        addStringToPanel(btn, 70)
       
    End Sub

    Private Sub panel_mouseLeave(ByVal sender As System.Object, ByVal e As EventArgs)
        generateIcon()

        Dim id As Integer
        Dim btn As Panel = CType(sender, Panel)
        id = CType(btn.Tag, DataPanel).id

        Dim g As Graphics = btn.CreateGraphics()
        'g.Clear(btn.BackColor)

        Me.Panel_PaintZoomIn(btn)
        addStringToPanel(btn, 50)
       
    End Sub

    Sub addStringToPanel(ByVal pn As Panel, ByVal y As Integer)

        Dim g As Graphics = pn.CreateGraphics()
        Dim rect As New Rectangle(8, y, 1000, 100)
        Dim dp As DataPanel = CType(pn.Tag, DataPanel)


        Dim strTmp() As String = Split(dp.caption, " ", , CompareMethod.Text)

        If dp.caption.Length < 8 Then
            Dim rect1 As New Rectangle(20, y, 1000, 100)
            g.DrawString(CType(pn.Tag, DataPanel).caption, New Font("Verdana", 8), Brushes.Black, rect1.Location.X, rect1.Location.Y)
        Else
            g.DrawString(CType(pn.Tag, DataPanel).caption, New Font("Verdana", 8), Brushes.Black, rect.Location.X, rect.Location.Y)
        End If


        'pnIcon.Dock = DockStyle.Fill
        'g.DrawString(strTmp(1), New Font("Verdana", 8), Brushes.Black, rect.Location.X, rect.Location.Y + 10)
    End Sub

    Private Sub Panel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim id As Integer
        Dim btn As Panel = CType(sender, Panel)
        id = CType(btn.Tag, DataPanel).id

        Me.processId = id
        Me.processName = CType(btn.Tag, DataPanel).caption

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
        'MsgBox("Hai " & id, MsgBoxStyle.Information, "Testing")
    End Sub


    'Sub generateIcon()
    '    Dim x As Integer = 10
    '    Dim y As Integer = 10

    '    Dim dtProcess As DataTable = menuDao.getProcessByRoleId(SessionInfo.ModSessi.roleId, Me.moduleId)

    '    Dim i As Integer = 1

    '    For Each row As DataRow In dtProcess.Rows
    '        Dim pnItem As New Panel()

    '        pnItem.Location = New Point(x, y)

    '        'set id process to panel
    '        pnItem.Tag = row("id")

    '        pnItem.BorderStyle = BorderStyle.None
    '        pnItem.BackgroundImage = Image.FromFile("images/" & row("icon_name"))
    '        pnItem.BackgroundImageLayout = ImageLayout.Center
    '        pnItem.Cursor = Cursors.Hand
    '        pnItem.Size = New Size(100, 100)

    '        Dim lblcaption As New Label()
    '        lblcaption.Text = row("process_name")

    '        pnItem.Controls.Add(lblcaption)
    '        lblcaption.Dock = DockStyle.Bottom
    '        lblcaption.TextAlign = ContentAlignment.MiddleCenter


    '        AddHandler pnItem.MouseEnter, AddressOf pnItem_MouseEnter
    '        AddHandler pnItem.MouseLeave, AddressOf pnItem_MouseLeave
    '        AddHandler pnItem.Click, AddressOf pnItem_Click

    '        pnIcon.Controls.Add(pnItem)

    '        x += pnItem.Width + 5

    '        If i Mod 3 = 0 Then
    '            x = 10
    '            y += pnItem.Height + 5
    '        End If

    '        i += 1

    '    Next


    'End Sub


    'Private Sub pnItem_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
    '    CType(sender, Panel).BackColor = Color.Azure
    '    CType(sender, Panel).BorderStyle = BorderStyle.FixedSingle
    'End Sub

    'Private Sub pnItem_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
    '    CType(sender, Panel).BackColor = Color.Transparent
    '    CType(sender, Panel).BorderStyle = BorderStyle.None
    'End Sub

    'Private Sub pnItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim pn As Panel = CType(sender, Panel)
    '    'MsgBox("hello, " & pn.Tag)
    '    Me.processId = CInt(pn.Tag)

    '    Me.DialogResult = Windows.Forms.DialogResult.OK
    '    'Me.Close()
    'End Sub

  

    'Private Sub pnIcon_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnIcon.Paint
    '    Dim g As Graphics = e.Graphics
    '    Dim bmp As Bitmap = Bitmap.FromFile("images/bd-deco.gif")
    '    g.DrawImage(bmp, New Rectangle(10, 10, 100, 100), New Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel)

    'End Sub

    Private Sub LblClose_Click(sender As System.Object, e As System.EventArgs) Handles LblClose.Click
        Me.Close()
    End Sub

    Private Sub LblClose_MouseHover(sender As Object, e As System.EventArgs) Handles LblClose.MouseHover
        LblClose.BackColor = Color.Crimson
    End Sub

    Private Sub LblClose_MouseLeave(sender As Object, e As System.EventArgs) Handles LblClose.MouseLeave
        LblClose.BackColor = Color.Transparent
    End Sub

End Class

Class DataPanel
    Public id As Integer
    Public index As Integer
    Public caption As String
    Public image As String
    Public lokasi_X As Integer
    Public lokasi_Y As Integer
    Public lebar As Integer
    Public tinggi As Integer
    Public isEnterPanel As Boolean = True
    Public state As Integer = 1 '=>1,2,3

End Class