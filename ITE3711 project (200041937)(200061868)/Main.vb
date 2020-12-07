Imports System.Text.RegularExpressions

Public Class Main
    Public Const TEST_PERCENTAGE As Double = 0.5, PROJECT_PERCENTAGE As Double = 0.3, QUIZZES_PERCENTAGE As Double = 0.2, CA_PERCENTAGE As Double = 0.4, EXAM_PERCENTAGE As Double = 0.6
    Public STU_DATAS As New List(Of Dictionary(Of String, String))

    '初始化
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CA_lb.Text = "CA Components: Test:" & TEST_PERCENTAGE * 100 & "%, Quiz:" & QUIZZES_PERCENTAGE * 100 & "%, Project:" & PROJECT_PERCENTAGE * 100 & "%"
        Result_gb.Text = "Module Result (CA:" & CA_PERCENTAGE * 100 & "%, Exam:" & EXAM_PERCENTAGE * 100 & "%)"
    End Sub

    '尋找按鈕按下
    Private Sub Find_bt_Click(sender As Object, e As EventArgs) Handles Find_bt.Click
        Dim Name As String = Trim(Find_tb.Text)
        Dim CheckNameRegex As Regex = New Regex("^[a-zA-z\s]*$")
        If CheckNameRegex.IsMatch(Name) Then

            Dim Fisrt_time = True
            For i As Integer = 0 To Record_lib.Items.Count - 1
                If Record_lib.Items(i).Equals(Name) Then
                    If Not Fisrt_time Then
                        Dim OkNo = MsgBox("We find on more student call " & Name & ". Do you want to show too?", 4 + 32, "Show too?")
                        If OkNo = 6 Then
                            MsgBox(Name & " is on line " & i + 1 & " of the list.", 64, "Find!")
                        End If
                    Else
                        MsgBox(Name & " is on line " & i + 1 & " of the list.", 64, "Find!")
                    End If
                    Fisrt_time = False
                End If
            Next i
            If Fisrt_time Then
                MsgBox("Studuent not found!", 48, "Not Found!")
            End If

        Else
            MsgBox("Enter the name in English letters in the find field.", 48, "Wrong typing")
        End If
    End Sub

    '展示統計
    Private Sub Show_bt_Click(sender As Object, e As EventArgs) Handles Show_bt.Click
        Dim Total_stu As Integer = STU_DATAS.Count
        Dim Total_stu_mark, Avg_mark As Double
        Dim Count_A, Count_F As Integer

        For Each stu As Dictionary(Of String, String) In STU_DATAS
            Dim CA_Marks As Double = stu("Test") * TEST_PERCENTAGE + stu("Project") * PROJECT_PERCENTAGE + stu("Quizzes") * QUIZZES_PERCENTAGE
            Dim Module_Marks As Double = CA_Marks * CA_PERCENTAGE + stu("Exam") * EXAM_PERCENTAGE
            Total_stu_mark += Module_Marks
            '計級別
            If CA_Marks >= 40 Or stu("Exam") >= 40 Then
                If Module_Marks >= 75 Then
                    Count_A += 1
                End If
            Else
                Count_F += 1
            End If
        Next

        If Total_stu > 0 Then
            Avg_mark = Math.Round(Total_stu_mark / Total_stu, 2)
            Number_tb.Text = Total_stu
            Module_Average_tb.Text = Avg_mark
            Count_of_A_tb.Text = Count_A
            Count_of_F_tb.Text = Count_F
        Else
            Number_tb.Text = "N/A"
            Module_Average_tb.Text = "N/A"
            Count_of_A_tb.Text = 0
            Count_of_F_tb.Text = 0
        End If


    End Sub

    '開啟修改介面
    Private Sub Record_lib_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Record_lib.DoubleClick
        If Record_lib.SelectedIndex >= 0 Then
            Dim stu As Dictionary(Of String, String) = STU_DATAS(Record_lib.SelectedIndex)
            Dim Edit_Form As Edit_Form = New Edit_Form(stu, Record_lib.SelectedIndex)
            Edit_Form.Show()
        End If
    End Sub

    '清除所有'
    Private Sub Clear_bt_Click(sender As Object, e As EventArgs) Handles Clear_bt.Click
        Dim AllTextBoxControl = Func.Get_All_Control(Me, GetType(TextBox))
        For Each textbox As TextBox In AllTextBoxControl.Values
            textbox.Clear()
        Next
        If Record_lib.Items.Count > 0 Then
            Dim YesNo = MsgBox("Also have some data in Student Record list. Do you want clear too?", 4 + 32 + 256, "Clear too?")
            If YesNo = 6 Then
                Record_lib.Items.Clear()
                STU_DATAS.Clear()
            End If
        End If
    End Sub

    '匯出Excel
    Private Sub Excel_bt_Click(sender As Object, e As EventArgs) Handles Excel_bt.Click
        If STU_DATAS.Count > 0 Then
            Dim var = New To_Excal(STU_DATAS)
            If Not var.Save() Then
                MsgBox("Could not save file. Please check if the file is open.", 16, "Could not save file.")
            End If
        Else
            MsgBox("No data can be exported.", 48, "No data to exported.")
        End If
    End Sub

    '確認按鈕按下
    Private Sub Confirm_bt_Click(sender As Object, e As EventArgs) Handles Confirm_bt.Click
        '放字典以便迴圈
        Dim InputBoxs As New Dictionary(Of String, String) From {{"Name", Trim(Name_tb.Text)}, {"Test", Trim(Test_tb.Text)}, {"Quizzes", Trim(Quizzes_tb.Text)}, {"Project", Trim(Project_tb.Text)}, {"Exam", Trim(Exam_tb.Text)}}

        '檢查空白
        For Each value As String In InputBoxs.Values
            If String.IsNullOrEmpty(value) Then
                MsgBox("Something data is blank!", 48, "Wrong typing")
                Return
            End If
        Next


        '檢查數據類型
        If Not Func.Check_Name(InputBoxs("Name")) Then
            MsgBox("Enter the name in English letters in the name field.", 48, "Wrong typing!")
            Name_tb.BackColor = Color.FromArgb(255, 255, 138, 132)
            Return
        End If
        For i As Integer = 1 To InputBoxs.Count - 1
            If Not Func.Check_Int(InputBoxs.Values(i)) Then
                MsgBox("Numbers should be entered in the " & InputBoxs.Keys(i) & " field.", 48, "Wrong typing!")
                Dim listAllTextBox = Func.Get_All_Control(Me, GetType(TextBox))
                Dim Box = listAllTextBox(InputBoxs.Keys(i) & "_tb")
                Box.BackColor = Color.FromArgb(255, 255, 138, 132)
                Return
            End If
        Next i

        '檢查範圍
        For i As Integer = 1 To InputBoxs.Count - 1
            If Func.Check_Range(InputBoxs.Values(i)) Then
                MsgBox("The " & InputBoxs.Keys(i) & " field can only accept 0 to 100.", 48, "Wrong typing!")
                Dim listAllTextBox = Func.Get_All_Control(Me, GetType(TextBox))
                Dim Box = listAllTextBox(InputBoxs.Keys(i) & "_tb")
                Box.BackColor = Color.FromArgb(255, 255, 138, 132)
                Return
            End If
        Next i

        '計算分數
        Dim CA_Marks As Double = Func.Calculation_CA_Marks(InputBoxs("Test"), InputBoxs("Project"), InputBoxs("Quizzes"))
        Dim Module_Marks As Double = Func.Calculation_Module_Marks(CA_Marks, InputBoxs("Exam"))
        CA_Mark__tb.Text = CA_Marks
        Module_Marks_tb.Text = Module_Marks

        '計級別
        Dim Grade As String = Func.Get_Grade(CA_Marks, InputBoxs("Exam"), Module_Marks)
        Module_Grade_tb.Text = Grade

        '計備註
        Dim Remark As String = Func.Get_Remark(Module_Marks, Grade)
        Remarks_tb.Text = Remark

        '儲存學生資料
        For Each value As Dictionary(Of String, String) In STU_DATAS
            If value("Name").Equals(InputBoxs("Name")) Then
                Dim OkNo = MsgBox("Check to have the same name. Are you sure you want to continue typing?", 1 + 32, "Are you sure?")
                If OkNo = 1 Then
                    Record_lib.Items.Add(InputBoxs("Name"))
                    STU_DATAS.Add(InputBoxs)
                    Return
                Else
                    Return
                End If
            End If
        Next
        Record_lib.Items.Add(InputBoxs("Name"))
        STU_DATAS.Add(InputBoxs)
    End Sub

    '將背景改為白色
    Private Sub Test_tb_TextChanged(sender As Object, e As EventArgs) Handles Test_tb.TextChanged, Exam_tb.TextChanged, Quizzes_tb.TextChanged, Project_tb.TextChanged, Name_tb.TextChanged
        sender = CType(sender, TextBox)
        sender.BackColor = Color.White
    End Sub

    'Enter Key & Del key 偵測
    Private Sub Key(sender As Object, e As KeyEventArgs) Handles Exam_tb.KeyDown, Record_lib.KeyDown
        If e.KeyCode = Keys.Enter And sender.GetType Is GetType(TextBox) Then
            'Enter key down
            Confirm_bt_Click(sender, e)
        ElseIf e.KeyCode = Keys.Delete And sender.GetType Is GetType(ListBox) Then
            'Del key down
            Dim YesNo = MsgBox("Are you sure want to delete?", 4 + 48 + 256, "Delete?")
            If YesNo = 6 Then
                STU_DATAS.RemoveAt(Record_lib.SelectedIndex)
                Record_lib.Items.RemoveAt(Record_lib.SelectedIndex)
            End If
        End If
    End Sub

    '修改資料
    Public Sub Change_stu_record(stu As Dictionary(Of String, String), SelectedIndex As Integer)
        STU_DATAS(SelectedIndex) = stu
        Record_lib.Items(SelectedIndex) = stu("Name")
    End Sub
End Class
