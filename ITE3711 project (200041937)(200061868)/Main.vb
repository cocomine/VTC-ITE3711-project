Imports System.Text.RegularExpressions

Public Class Main
    Const TEST_PERCENTAGE As Double = 0.5, PROJECT_PERCENTAGE As Double = 0.3, QUIZZES_PERCENTAGE As Double = 0.2, CA_PERCENTAGE As Double = 0.4, EXAM_PERCENTAGE As Double = 0.6
    Dim stu_datas As Dictionary(Of String, Dictionary(Of String, String))

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

    '清除所有'
    Private Sub Clear_bt_Click(sender As Object, e As EventArgs) Handles Clear_bt.Click
        Dim AllTextBoxControl = Get_All_Control(Me, GetType(TextBox))
        For Each textbox As TextBox In AllTextBoxControl.Values
            textbox.Clear()
        Next
        If Record_lib.Items.Count > 0 Then
            Dim YesNo = MsgBox("Also have some data in Student Record list. Do you want clear too?", 4 + 32 + 256, "Clear too?")
            If YesNo = 6 Then
                Record_lib.Items.Clear()
            End If
        End If
    End Sub

    '取得所有控制元件
    Private Function Get_All_Control(ByVal parent As Control, ByVal ctrlType As System.Type) As Dictionary(Of String, Control)
        Dim ControlList As New Dictionary(Of String, Control)
        If parent Is Nothing Then Return ControlList

        For Each child As Control In parent.Controls
            If child.GetType Is GetType(GroupBox) Then
                Dim list = Get_All_Control(child, ctrlType)
                For Each list_child As Control In list.Values
                    ControlList.Add(list_child.Name, list_child)
                Next
            ElseIf child.GetType Is ctrlType Then
                ControlList.Add(child.Name, child)
            End If
        Next
        Return ControlList
    End Function

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
        Dim CheckNameRegex As Regex = New Regex("^[a-zA-z\s]*$")
        If Not CheckNameRegex.IsMatch(InputBoxs("Name")) Then
            MsgBox("Enter the name in English letters in the name field.", 48, "Wrong typing!")
            Name_tb.BackColor = Color.FromArgb(255, 255, 138, 132)
            Return
        End If
        Dim CheckIntRegex As Regex = New Regex("^[0-9]+(.[0-9]{1,})?$")
        For i As Integer = 1 To InputBoxs.Count - 1
            If Not CheckIntRegex.IsMatch(InputBoxs.Values(i)) Then
                MsgBox("Numbers should be entered in the " & InputBoxs.Keys(i) & " field.", 48, "Wrong typing!")
                Dim listAllTextBox = Get_All_Control(Me, GetType(TextBox))
                Dim Box = listAllTextBox(InputBoxs.Keys(i) & "_tb")
                Box.BackColor = Color.FromArgb(255, 255, 138, 132)
                Return
            End If
        Next i

        '檢查範圍
        For i As Integer = 1 To InputBoxs.Count - 1
            If InputBoxs.Values(i) < 0 Or InputBoxs.Values(i) > 100 Then
                MsgBox("The " & InputBoxs.Keys(i) & " field can only accept 0 to 100.", 48, "Wrong typing!")
                Dim listAllTextBox = Get_All_Control(Me, GetType(TextBox))
                Dim Box = listAllTextBox(InputBoxs.Keys(i) & "_tb")
                Box.BackColor = Color.FromArgb(255, 255, 138, 132)
                Return
            End If
        Next i

        '計算分數
        Dim CA_Marks As Double = InputBoxs("Test") * TEST_PERCENTAGE + InputBoxs("Project") * PROJECT_PERCENTAGE + InputBoxs("Quizzes") * QUIZZES_PERCENTAGE
        Dim Module_Marks As Double = CA_Marks * CA_PERCENTAGE + InputBoxs("Exam") * EXAM_PERCENTAGE
        CA_Mark__tb.Text = CA_Marks
        Module_Marks_tb.Text = Module_Marks


        '計級別
        Dim Grade As String
        If CA_Marks >= 40 Or InputBoxs("Exam") >= 40 Then
            If Module_Marks >= 40 And Module_Marks < 65 Then
                Grade = "C"
            ElseIf Module_Marks >= 65 And Module_Marks < 75 Then
                Grade = "B"
            Else
                Grade = "A"
            End If
        Else
                Grade = "F"
        End If
        Module_Grade_tb.Text = Grade

        '計備註
        Dim Remark As String
        If Grade = "F" Then
            If Module_Marks >= 30 Then
                Remark = "Resit Exam"
            Else
                Remark = "Restudy"
            End If
        Else
            Remark = "Pass"
        End If
        Remarks_tb.Text = Remark

        '儲存學生資料
        stu_datas.Add(InputBoxs("Name"), InputBoxs)
        Record_lib.Items.Add(InputBoxs("Name"))

    End Sub

    '將背景改為白色
    Private Sub Test_tb_TextChanged(sender As Object, e As EventArgs) Handles Test_tb.TextChanged, Exam_tb.TextChanged, Quizzes_tb.TextChanged, Project_tb.TextChanged, Name_tb.TextChanged
        sender = CType(sender, TextBox)
        sender.BackColor = Color.White
    End Sub
End Class
