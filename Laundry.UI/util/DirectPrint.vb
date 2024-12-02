Imports Laundry.Service
Imports Laundry.Service.service
Imports ClientLibs
Imports UtilsLibs.MainMod
Imports System.Windows.Forms

'Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6

Public Class DirectPrint
    Public dtItems As DataTable
    '    Public listAlkes As List(Of model.Alkes)
    '    Public pwt As model.Perawatan
    '    Public TIPE_PENUNJANG As String

    Dim dtResult As DataTable
    '    Dim dtPaket As DataTable

    'Private PharResepsrv As Pharmacy.Service.service.IPharResepService
    Private LinenReportSvr As Laundry.Service.service.IReportLinenService


    Public Shared Sub Export2Excel(ByVal dt As System.Data.DataTable)
        Try

            Dim filename As String = ""

            Dim dlg As New SaveFileDialog()
            dlg.Filter = "Excel (*.xls)|*.xls"

            If dlg.ShowDialog() = DialogResult.OK Then

                filename = dlg.FileName

                Dim Excel As Object = CreateObject("Excel.Application")
                If Excel Is Nothing Then
                    MsgBox("It appears that Excel is not installed on this machine. This operation requires MS Excel to be installed on this machine.", MsgBoxStyle.Critical)
                    Return
                End If

                With Excel
                    .SheetsInNewWorkbook = 1
                    .Workbooks.Add()
                    .Worksheets(1).Select()

                    Dim i As Integer = 1
                    For col = 0 To dt.Columns.Count - 1
                        .cells(1, i).value = dt.Columns(col).ColumnName
                        .cells(1, i).EntireRow.Font.Bold = True
                        i += 1
                    Next
                    i = 2
                    Dim k As Integer = 1
                    For col = 0 To dt.Columns.Count - 1
                        i = 2
                        For row = 0 To dt.Rows.Count - 1
                            .Cells(i, k).Value = dt.Rows(row).ItemArray(col)
                            i += 1
                        Next
                        k += 1
                    Next
                    'filename = "c:\File_Exported" & Format(Now(), "dd-MM-yyyy_hh-mm-ss") & ".xls"
                    'filename = "d:\pasien.xls"
                    .ActiveCell.Worksheet.SaveAs(filename)
                End With
                System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
                Excel = Nothing
                MsgBox("Data berhasil diexport ke Excel Succesfully di '" & filename & "'", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
