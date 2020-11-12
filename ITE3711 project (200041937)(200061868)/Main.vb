Imports System.Text.RegularExpressions

Public Class Main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const TEST_PERCENTAGE As Double = 0.5, PROJECT_PERCENTAGE As Double = 0.3, QUIZZES_PERCENTAGE As Double = 0.2, CA_PERCENTAGE As Double = 0.4, EXAM_PERCENTAGE As Double = 0.6
        CA_lb.Text = "CA Components: Test:" & TEST_PERCENTAGE * 100 & "%, Quiz:" & QUIZZES_PERCENTAGE * 100 & "%, Project:" & PROJECT_PERCENTAGE * 100 & "%"
        Result_gb.Text = "Module Result (CA:" & CA_PERCENTAGE * 100 & "%, Exam:" & EXAM_PERCENTAGE * 100 & "%)"
        CA_Mark__tb.Text = "tes"
    End Sub

    '清除所有'
    Private Sub Clear_bt_Click(sender As Object, e As EventArgs) Handles Clear_bt.Click
        Dim AllTextBoxControl = Get_All_Control(Me, GetType(TextBox))
        For Each textbox As TextBox In AllTextBoxControl
            textbox.Clear()
        Next
        If Record_lib.Items.Count > 0 Then
            Dim YesNo = MsgBox("Also have some data in Student Record list. Do you want clear too?", 4 + 32, "Clear too?")
            If YesNo = 6 Then
                Record_lib.Items.Clear()
            End If
        End If
    End Sub

    'Get the All Control I want
    Private Function Get_All_Control(ByVal parent As Control, ByVal ctrlType As System.Type) As List(Of Control)
        Dim ControlList As New List(Of Control)
        If parent Is Nothing Then Return ControlList

        For Each child As Control In parent.Controls
            If child.GetType Is GetType(GroupBox) Then
                Dim list = Get_All_Control(child, ctrlType)
                For Each list_child As Control In list
                    ControlList.Add(list_child)
                Next
            ElseIf child.GetType Is ctrlType Then
                ControlList.Add(child)
            End If
        Next
        Return ControlList
    End Function

    Private Sub Confirm_bt_Click(sender As Object, e As EventArgs) Handles Confirm_bt.Click
        Dim Name As String = Name_tb.Text

        'Check blank
        If String.IsNullOrEmpty(Name) Or String.IsNullOrEmpty(Test_tb.Text) Or String.IsNullOrEmpty(Quizzes_tb.Text) Or String.IsNullOrEmpty(Project_tb.Text) Or String.IsNullOrEmpty(Exam_tb.Text) Then
            MsgBox("Something data is blank!")
            Return
        End If

        Dim CheckNameRegex As Regex = New Regex("[a-zA-z\s]")
        If CheckNameRegex.IsMatch(Name) Then
            MsgBox("OK")
        End If
        'Dim Test, Quize, Project, Exam As Integer
        'Test = Test_tb.Text
        'Quize = Quizzes_tb.Text
        'Project = Project_tb.Text
        'Exam = Exam_tb.Text
    End Sub
End Class
