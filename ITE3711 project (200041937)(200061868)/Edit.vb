Imports System.Text.RegularExpressions

Public Class Edit_Form
    Public STU As Dictionary(Of String, String)
    Public SelectedIndex As Integer

    'save change
    Private Sub Save_bt_Click(sender As Object, e As EventArgs) Handles Save_bt.Click
        Dim YesNO = MsgBox("Are you sure save change?", 4 + 32 + 256, "Save change?")
        If YesNO = 6 Then
            Main.Change_stu_record(STU, SelectedIndex)
            Me.Close()
        End If
    End Sub

    '初始化
    Private Sub Edit_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Name_tb.Text = STU("Name")
        Project_tb.Text = STU("Project")
        Quizzes_tb.Text = STU("Quizzes")
        Test_tb.Text = STU("Test")
        Exam_tb.Text = STU("Exam")
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
        Dim fistTime As Boolean = True
        For Each value As Dictionary(Of String, String) In Main.STU_DATAS
            If value("Name").Equals(InputBoxs("Name")) Then
                If Not fistTime Then
                    Dim OkNo = MsgBox("Check to have the same name. Are you sure you want to continue typing?", 1 + 32, "Are you sure?")
                    If OkNo = 1 Then
                        STU = InputBoxs
                        Save_bt.Enabled = True
                        Return
                    Else
                        Return
                    End If
                End If
                fistTime = False
            End If
        Next
        STU = InputBoxs
        Save_bt.Enabled = True
    End Sub

    'Enter key down
    Private Sub Key(sender As Object, e As KeyEventArgs) Handles Exam_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            Confirm_bt_Click(sender, e)
        End If
    End Sub

End Class