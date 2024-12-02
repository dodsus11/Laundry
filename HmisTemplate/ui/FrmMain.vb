Public Class FrmMain

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        Dim uc As New UcPerson()

        Dim tabPage As New TabPage()
        tabPage.Text = "Setup Person  "
        tabPage.ImageIndex = 0
        tabPage.Controls.Add(uc)
        uc.Dock = DockStyle.Fill

        TbControl.TabPages.Add(tabPage)
        TbControl.SelectedIndex = TbControl.TabCount - 1

        
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim uc As New UcBarang()

        Dim tabPage As New TabPage()
        tabPage.Text = "Setup barang  "
        tabPage.ImageIndex = 0
        tabPage.Controls.Add(uc)
        uc.Dock = DockStyle.Fill
        TbControl.TabPages.Add(tabPage)

        TbControl.SelectedIndex = TbControl.TabCount - 1

    End Sub
End Class