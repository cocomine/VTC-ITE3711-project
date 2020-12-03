
Imports Microsoft.Office.Interop

Public Class To_Excal
    Private STU_DATAS As List(Of Dictionary(Of String, String))
    Private oExcel As Excel.Application

    Public Sub New(stu_datas As List(Of Dictionary(Of String, String)))
        Me.STU_DATAS = stu_datas
        Build()
    End Sub

    Private Sub Build()
        oExcel = New Excel.Application
        Dim oBook As Excel.Workbook
        Dim oSheet As Excel.Worksheet
        oBook = oExcel.Workbooks.Add

        'Marks and Grade for Individual Student
        Dim DataArray(0 To STU_DATAS.Count, 0 To 9) As Object
        For i As Integer = 0 To STU_DATAS.Count - 1
            Dim stu_data = STU_DATAS(i)
            For r As Integer = 0 To stu_data.Count - 1
                DataArray(i, r) = stu_data.Values(r)
            Next
            Dim CA_Marks As Double = Func.Calculation_CA_Marks(stu_data("Test"), stu_data("Project"), stu_data("Quizzes"))
            Dim Module_Marks As Double = Func.Calculation_Module_Marks(CA_Marks, stu_data("Exam"))
            Dim Grade As String = Func.Get_Grade(CA_Marks, stu_data("Exam"), Module_Marks)
            Dim Remark As String = Func.Get_Remark(Module_Marks, Grade)

            DataArray(i, 5) = CA_Marks
            DataArray(i, 6) = Module_Marks
            DataArray(i, 7) = Grade
            DataArray(i, 8) = Remark
        Next

        oSheet = oBook.Worksheets(1)
        With oSheet
            .Name = "Student Record" '資料表名
            With .Range("A1:I1") '第一表格開頭
                .Merge() '合併
                .Interior.Color = Color.Gold '調整填充顏色
                .Value = "Marks and Grade for Individual Student" '插入文字
                .Font.Size = 16
                .HorizontalAlignment = Excel.Constants.xlCenter '置中文字
            End With
            With .Range("A2:I2") '第一表格開頭 2
                .Value = {"Name", "Test", "Quizzes", "Project", "Exam", "CA_Marks", "Module Marks", "Module Grade", "Remarks"} '插入文字
                .Interior.Color = Color.Gold '調整填充顏色
                .Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous '表格邊界
            End With
            .Range("A2").Columns.ColumnWidth = 20 '調整欄寬
            .Range("F:I").ColumnWidth = 13
            .Range("A3").Resize(STU_DATAS.Count, 9).Value = DataArray '插入資料

            Dim Second_Table_Y As String = STU_DATAS.Count + 5
            With .Range("A" & Second_Table_Y & ":B" & Second_Table_Y) '第二表格開頭
                .Merge() '合併
                .Value = "Module Statistics" '插入文字
                .Interior.Color = Color.Purple '調整填充顏色
                .Font.Color = Color.White '調整文字顏色
                .HorizontalAlignment = Excel.Constants.xlCenter '置中文字
                .Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous '表格邊界
            End With
            .Range("A" & Second_Table_Y + 1).Value = "Number of Students"
            .Range("B" & Second_Table_Y + 1).Formula = "=COUNTA(A3:A" & STU_DATAS.Count + 2 & ")"
            .Range("A" & Second_Table_Y + 2).Value = "Module Average"
            .Range("B" & Second_Table_Y + 2).Formula = "=ROUND(AVERAGE(G3:G" & STU_DATAS.Count + 2 & "), 2)"
            .Range("A" & Second_Table_Y + 3).Value = "Count of A"
            .Range("B" & Second_Table_Y + 3).Formula = "=COUNTIF(H3:H" & STU_DATAS.Count + 2 & ", ""A"")"
            .Range("A" & Second_Table_Y + 4).Value = "Count of F"
            .Range("B" & Second_Table_Y + 4).Formula = "=COUNTIF(H3:H" & STU_DATAS.Count + 2 & ", ""F"")"
        End With

    End Sub

    Public Function Save(Optional path As String = Nothing)
        oExcel.DisplayAlerts = False
        Dim oBook = oExcel.Workbooks(1)
        Try
            If path Is Nothing Then
                Using sfd As New SaveFileDialog
                    sfd.InitialDirectory = Application.StartupPath
                    sfd.Title = "Export Excel"
                    sfd.OverwritePrompt = True
                    sfd.FileName = "Student Record.xlsx"
                    sfd.DefaultExt = ".xlsx"
                    sfd.Filter = "Excel(*.xlsx)|"
                    sfd.AddExtension = True
                    If sfd.ShowDialog() = DialogResult.OK Then
                        oBook.SaveAs(sfd.FileName)
                    End If
                End Using
            Else
                oBook.SaveAs(path)
            End If
        Catch ex As Exception
            Return False
        End Try
        oBook.Close()
        oExcel.Quit()
        Return True
    End Function

End Class
