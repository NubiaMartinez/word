
Public Class Form1
    Dim dialogo As New SaveFileDialog()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Word = New Microsoft.Office.Interop.Word.Application
        Dim wordApp = Word.Application()


        Dim ruta, dato As String
        If (dialogo.ShowDialog() <> DialogResult.OK) Then
            Return
        End If
        ruta = dialogo.FileName
        wordApp.Visible = True
        wordApp.Documents.Add()
        dato = textBox1.Text

        wordApp.Selection.TypeText(dato)
        wordApp.ActiveDocument.SaveAs2(ruta)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Excel = New Microsoft.Office.Interop.Excel.Application
        Dim excelApp = Excel.Application()
        Dim ruta As String
        If (dialogo.ShowDialog() <> DialogResult.OK) Then
            Return
        End If
        ruta = dialogo.FileName
        excelApp.Visible = True

        Dim workbook = excelApp.Workbooks.Add()
        Dim worksheet = workbook.ActiveSheet

        worksheet.Cells(1, 1) = "Caja de texto"
        worksheet.Cells(2, 1) = textBox1.Text
    End Sub
End Class
