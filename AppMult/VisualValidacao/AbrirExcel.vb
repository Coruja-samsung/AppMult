Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Module AbrirExcel
    Public excelApp As Object = Nothing
    Public workbook1 As Object = Nothing
    Public xlsFilePath1 As String = ConexaoBD.CaminhoSerial
    Public xlsFilePath2 As String = ConexaoBD.CaminhoEan
    Public Sub OpenExcelSerial()
        excelApp = CreateObject("Excel.Application")
        'excelApp.Visible = True
        workbook1 = excelApp.Workbooks.Open(xlsFilePath1)
    End Sub
    Public Sub OpenExcelEan()
        excelApp = CreateObject("Excel.Application")
        'excelApp.Visible = True
        workbook1 = excelApp.Workbooks.Open(xlsFilePath2)
    End Sub
    Public Sub CloseExcels()
        If workbook1 IsNot Nothing Then
            workbook1.Close(False)
            Marshal.ReleaseComObject(workbook1)
            workbook1 = Nothing
            GC.Collect()
            GC.WaitForPendingFinalizers()
            excelApp.Quit()
            Marshal.ReleaseComObject(excelApp)
            excelApp = Nothing
        End If
    End Sub
End Module
