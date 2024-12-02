Imports System.Runtime.InteropServices

Public Module mdlprint
    Public Class RawPrinter
        ' ----- Define the data type that supplies basic
        '       <strong class="highlight">print</strong> job information to the spooler.
        <StructLayout(LayoutKind.Sequential, _
            CharSet:=CharSet.Unicode)> _
        Public Structure DOCINFO
            <MarshalAs(UnmanagedType.LPWStr)> _
            Public pDocName As String
            <MarshalAs(UnmanagedType.LPWStr)> _
            Public pOutputFile As String
            <MarshalAs(UnmanagedType.LPWStr)> _
            Public pDataType As String
        End Structure

        ' ----- Define interfaces to the functions supplied
        '       <strong class="highlight">in</strong> the DLL.
        <DllImport("winspool.drv", EntryPoint:="OpenPrinterW", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, _
           CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function OpenPrinter( _
           ByVal printerName As String, ByRef hPrinter As IntPtr, _
           ByVal printerDefaults As Integer) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="ClosePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, _
           CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function ClosePrinter( _
           ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="StartDocPrinterW", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, _
           CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function StartDocPrinter( _
           ByVal hPrinter As IntPtr, ByVal level As Integer, _
           ByRef documentInfo As DOCINFO) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="EndDocPrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, _
           CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EndDocPrinter( _
           ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="StartPagePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, _
           CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function StartPagePrinter( _
           ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="EndPagePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, _
           CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EndPagePrinter( _
           ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="WritePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, _
           CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function WritePrinter( _
           ByVal hPrinter As IntPtr, ByVal buffer As IntPtr, _
           ByVal bufferLength As Integer, _
           ByRef bytesWritten As Integer) As Boolean
        End Function

        Public Shared Function PrintRaw( _
              ByVal printerName As String, _
              ByVal origString As String) As Boolean
            ' ----- Send a string of  raw data to  the printer.
            Dim hPrinter As IntPtr
            Dim spoolData As New DOCINFO
            Dim dataToSend As IntPtr
            Dim dataSize As Integer
            Dim bytesWritten As Integer

            ' ----- The internal format of a .NET String is just
            '       different enough from what the printer expects
            '       that there will be a problem if we send it
            '       directly. Convert it to ANSI format before
            '       sending.
            dataSize = origString.Length()
            dataToSend = Marshal.StringToCoTaskMemAnsi(origString)

            ' ----- Prepare information for the spooler.
            spoolData.pDocName = "Print"
            spoolData.pDataType = "RAW"

            Try
                ' ----- Open a channel to  the printer or spooler.
                Call OpenPrinter(printerName, hPrinter, 0)

                ' ----- Start a new document and Section 1.1.
                Call StartDocPrinter(hPrinter, 1, spoolData)
                Call StartPagePrinter(hPrinter)

                ' ----- Send the data to the printer.
                Call WritePrinter(hPrinter, dataToSend, _
                   dataSize, bytesWritten)

                ' ----- Close everything that we opened.
                EndPagePrinter(hPrinter)
                EndDocPrinter(hPrinter)
                ClosePrinter(hPrinter)
            Catch ex As Exception
                MsgBox("Error occurred: " & ex.ToString)
            Finally
                ' ----- Get rid of the special ANSI version.
                Marshal.FreeCoTaskMem(dataToSend)
            End Try
        End Function
    End Class
End Module