Imports System.Text.RegularExpressions

Public Class Func
    Inherits Main
    '取得所有控制元件
    Public Shared Function Get_All_Control(ByVal parent As Control, ByVal ctrlType As System.Type) As Dictionary(Of String, Control)
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

    '
    Public Shared Function Calculation_CA_Marks(Test As Double, Project As Double, Quizzes As Double) As Double
        Return Test * TEST_PERCENTAGE + Project * PROJECT_PERCENTAGE + Quizzes * QUIZZES_PERCENTAGE
    End Function

    '
    Public Shared Function Calculation_Module_Marks(CA_Marks As Double, Exam As Double) As Double
        Return CA_Marks * CA_PERCENTAGE + Exam * EXAM_PERCENTAGE
    End Function

    Public Shared Function Get_Grade(CA_Marks As Double, Exam As Double, Module_Marks As Double) As String
        Dim Grade As String
        If CA_Marks >= 40 Or Exam >= 40 Then
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
        Return Grade
    End Function

    Public Shared Function Get_Remark(Module_Marks As Double, Grade As String) As String
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
        Return Remark
    End Function

    Public Shared Function Check_Name(var As String) As Boolean
        Dim CheckNameRegex As Regex = New Regex("^[a-zA-z\s]*$")
        Return CheckNameRegex.IsMatch(var)
    End Function

    Public Shared Function Check_Int(var As String) As Boolean
        Dim CheckIntRegex As Regex = New Regex("^[0-9]+(.[0-9]{1,})?$")
        Return CheckIntRegex.IsMatch(var)
    End Function

    Public Shared Function Check_Range(var As Double) As Boolean
        Return var < 0 Or var > 100
    End Function
End Class
