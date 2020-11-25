<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Input_gp = New System.Windows.Forms.GroupBox()
        Me.Result_gb = New System.Windows.Forms.GroupBox()
        Me.Remarks_lb = New System.Windows.Forms.Label()
        Me.Module_Grade_lb = New System.Windows.Forms.Label()
        Me.Module_Marks_lb = New System.Windows.Forms.Label()
        Me.CA_Marks_lb = New System.Windows.Forms.Label()
        Me.CA_Mark__tb = New System.Windows.Forms.TextBox()
        Me.Remarks_tb = New System.Windows.Forms.TextBox()
        Me.Module_Grade_tb = New System.Windows.Forms.TextBox()
        Me.Module_Marks_tb = New System.Windows.Forms.TextBox()
        Me.lnput_CA_gb = New System.Windows.Forms.GroupBox()
        Me.Exam_tb = New System.Windows.Forms.TextBox()
        Me.Project_tb = New System.Windows.Forms.TextBox()
        Me.Quizzes_tb = New System.Windows.Forms.TextBox()
        Me.Test_tb = New System.Windows.Forms.TextBox()
        Me.Exam_lb = New System.Windows.Forms.Label()
        Me.Quizzes_lb = New System.Windows.Forms.Label()
        Me.Project_lb = New System.Windows.Forms.Label()
        Me.Test_lb = New System.Windows.Forms.Label()
        Me.CA_lb = New System.Windows.Forms.Label()
        Me.Confirm_bt = New System.Windows.Forms.Button()
        Me.Clear_bt = New System.Windows.Forms.Button()
        Me.Name_lb = New System.Windows.Forms.Label()
        Me.Name_tb = New System.Windows.Forms.TextBox()
        Me.Find_tb = New System.Windows.Forms.TextBox()
        Me.Student_gb = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Find_bt = New System.Windows.Forms.Button()
        Me.Record_lib = New System.Windows.Forms.ListBox()
        Me.Moduls_Statistics_gb = New System.Windows.Forms.GroupBox()
        Me.Count_of_F_tb = New System.Windows.Forms.TextBox()
        Me.Count_of_A_tb = New System.Windows.Forms.TextBox()
        Me.Module_Average_tb = New System.Windows.Forms.TextBox()
        Me.Number_tb = New System.Windows.Forms.TextBox()
        Me.Count_of_F_lb = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Count_of_A_lb = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Module_Average_lb = New System.Windows.Forms.Label()
        Me.Mumber_lb = New System.Windows.Forms.Label()
        Me.Show_bt = New System.Windows.Forms.Button()
        Me.Excel_bt = New System.Windows.Forms.Button()
        Me.Input_gp.SuspendLayout()
        Me.Result_gb.SuspendLayout()
        Me.lnput_CA_gb.SuspendLayout()
        Me.Student_gb.SuspendLayout()
        Me.Moduls_Statistics_gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'Input_gp
        '
        Me.Input_gp.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Input_gp.Controls.Add(Me.Result_gb)
        Me.Input_gp.Controls.Add(Me.lnput_CA_gb)
        Me.Input_gp.Controls.Add(Me.Clear_bt)
        Me.Input_gp.Controls.Add(Me.Name_lb)
        Me.Input_gp.Controls.Add(Me.Name_tb)
        Me.Input_gp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_gp.ForeColor = System.Drawing.Color.Black
        Me.Input_gp.Location = New System.Drawing.Point(18, 17)
        Me.Input_gp.Margin = New System.Windows.Forms.Padding(4)
        Me.Input_gp.Name = "Input_gp"
        Me.Input_gp.Padding = New System.Windows.Forms.Padding(4)
        Me.Input_gp.Size = New System.Drawing.Size(957, 699)
        Me.Input_gp.TabIndex = 0
        Me.Input_gp.TabStop = False
        Me.Input_gp.Text = " Marks and Grade for Individual Student "
        '
        'Result_gb
        '
        Me.Result_gb.Controls.Add(Me.Remarks_lb)
        Me.Result_gb.Controls.Add(Me.Module_Grade_lb)
        Me.Result_gb.Controls.Add(Me.Module_Marks_lb)
        Me.Result_gb.Controls.Add(Me.CA_Marks_lb)
        Me.Result_gb.Controls.Add(Me.CA_Mark__tb)
        Me.Result_gb.Controls.Add(Me.Remarks_tb)
        Me.Result_gb.Controls.Add(Me.Module_Grade_tb)
        Me.Result_gb.Controls.Add(Me.Module_Marks_tb)
        Me.Result_gb.Location = New System.Drawing.Point(15, 426)
        Me.Result_gb.Margin = New System.Windows.Forms.Padding(4)
        Me.Result_gb.Name = "Result_gb"
        Me.Result_gb.Padding = New System.Windows.Forms.Padding(4)
        Me.Result_gb.Size = New System.Drawing.Size(908, 248)
        Me.Result_gb.TabIndex = 11
        Me.Result_gb.TabStop = False
        Me.Result_gb.Text = "Module Result"
        '
        'Remarks_lb
        '
        Me.Remarks_lb.AutoSize = True
        Me.Remarks_lb.Location = New System.Drawing.Point(474, 176)
        Me.Remarks_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Remarks_lb.Name = "Remarks_lb"
        Me.Remarks_lb.Size = New System.Drawing.Size(116, 29)
        Me.Remarks_lb.TabIndex = 12
        Me.Remarks_lb.Text = "Remarks"
        '
        'Module_Grade_lb
        '
        Me.Module_Grade_lb.AutoSize = True
        Me.Module_Grade_lb.Location = New System.Drawing.Point(48, 180)
        Me.Module_Grade_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Module_Grade_lb.Name = "Module_Grade_lb"
        Me.Module_Grade_lb.Size = New System.Drawing.Size(179, 29)
        Me.Module_Grade_lb.TabIndex = 11
        Me.Module_Grade_lb.Text = "Module Grade"
        '
        'Module_Marks_lb
        '
        Me.Module_Marks_lb.AutoSize = True
        Me.Module_Marks_lb.Location = New System.Drawing.Point(414, 91)
        Me.Module_Marks_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Module_Marks_lb.Name = "Module_Marks_lb"
        Me.Module_Marks_lb.Size = New System.Drawing.Size(177, 29)
        Me.Module_Marks_lb.TabIndex = 10
        Me.Module_Marks_lb.Text = "Module Marks"
        '
        'CA_Marks_lb
        '
        Me.CA_Marks_lb.AutoSize = True
        Me.CA_Marks_lb.Location = New System.Drawing.Point(94, 87)
        Me.CA_Marks_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CA_Marks_lb.Name = "CA_Marks_lb"
        Me.CA_Marks_lb.Size = New System.Drawing.Size(131, 29)
        Me.CA_Marks_lb.TabIndex = 9
        Me.CA_Marks_lb.Text = "CA Marks "
        '
        'CA_Mark__tb
        '
        Me.CA_Mark__tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CA_Mark__tb.Cursor = System.Windows.Forms.Cursors.No
        Me.CA_Mark__tb.Location = New System.Drawing.Point(240, 87)
        Me.CA_Mark__tb.Margin = New System.Windows.Forms.Padding(4)
        Me.CA_Mark__tb.Name = "CA_Mark__tb"
        Me.CA_Mark__tb.ReadOnly = True
        Me.CA_Mark__tb.Size = New System.Drawing.Size(163, 35)
        Me.CA_Mark__tb.TabIndex = 101
        Me.CA_Mark__tb.TabStop = False
        Me.CA_Mark__tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Remarks_tb
        '
        Me.Remarks_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Remarks_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Remarks_tb.Location = New System.Drawing.Point(626, 170)
        Me.Remarks_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.Remarks_tb.Name = "Remarks_tb"
        Me.Remarks_tb.ReadOnly = True
        Me.Remarks_tb.Size = New System.Drawing.Size(190, 35)
        Me.Remarks_tb.TabIndex = 104
        Me.Remarks_tb.TabStop = False
        Me.Remarks_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Module_Grade_tb
        '
        Me.Module_Grade_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Module_Grade_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Module_Grade_tb.Location = New System.Drawing.Point(240, 176)
        Me.Module_Grade_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.Module_Grade_tb.Name = "Module_Grade_tb"
        Me.Module_Grade_tb.ReadOnly = True
        Me.Module_Grade_tb.Size = New System.Drawing.Size(163, 35)
        Me.Module_Grade_tb.TabIndex = 103
        Me.Module_Grade_tb.TabStop = False
        Me.Module_Grade_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Module_Marks_tb
        '
        Me.Module_Marks_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Module_Marks_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Module_Marks_tb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Module_Marks_tb.Location = New System.Drawing.Point(626, 87)
        Me.Module_Marks_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.Module_Marks_tb.Name = "Module_Marks_tb"
        Me.Module_Marks_tb.ReadOnly = True
        Me.Module_Marks_tb.Size = New System.Drawing.Size(190, 35)
        Me.Module_Marks_tb.TabIndex = 102
        Me.Module_Marks_tb.TabStop = False
        Me.Module_Marks_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lnput_CA_gb
        '
        Me.lnput_CA_gb.Controls.Add(Me.Exam_tb)
        Me.lnput_CA_gb.Controls.Add(Me.Project_tb)
        Me.lnput_CA_gb.Controls.Add(Me.Quizzes_tb)
        Me.lnput_CA_gb.Controls.Add(Me.Test_tb)
        Me.lnput_CA_gb.Controls.Add(Me.Exam_lb)
        Me.lnput_CA_gb.Controls.Add(Me.Quizzes_lb)
        Me.lnput_CA_gb.Controls.Add(Me.Project_lb)
        Me.lnput_CA_gb.Controls.Add(Me.Test_lb)
        Me.lnput_CA_gb.Controls.Add(Me.CA_lb)
        Me.lnput_CA_gb.Controls.Add(Me.Confirm_bt)
        Me.lnput_CA_gb.Location = New System.Drawing.Point(15, 148)
        Me.lnput_CA_gb.Margin = New System.Windows.Forms.Padding(4)
        Me.lnput_CA_gb.Name = "lnput_CA_gb"
        Me.lnput_CA_gb.Padding = New System.Windows.Forms.Padding(4)
        Me.lnput_CA_gb.Size = New System.Drawing.Size(908, 270)
        Me.lnput_CA_gb.TabIndex = 10
        Me.lnput_CA_gb.TabStop = False
        Me.lnput_CA_gb.Text = "Input CA and Exam Marks "
        '
        'Exam_tb
        '
        Me.Exam_tb.Location = New System.Drawing.Point(492, 188)
        Me.Exam_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.Exam_tb.MaxLength = 5
        Me.Exam_tb.Name = "Exam_tb"
        Me.Exam_tb.Size = New System.Drawing.Size(148, 35)
        Me.Exam_tb.TabIndex = 5
        Me.Exam_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Project_tb
        '
        Me.Project_tb.Location = New System.Drawing.Point(144, 188)
        Me.Project_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.Project_tb.MaxLength = 5
        Me.Project_tb.Name = "Project_tb"
        Me.Project_tb.Size = New System.Drawing.Size(148, 35)
        Me.Project_tb.TabIndex = 4
        Me.Project_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Quizzes_tb
        '
        Me.Quizzes_tb.Location = New System.Drawing.Point(492, 105)
        Me.Quizzes_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.Quizzes_tb.MaxLength = 5
        Me.Quizzes_tb.Name = "Quizzes_tb"
        Me.Quizzes_tb.Size = New System.Drawing.Size(148, 35)
        Me.Quizzes_tb.TabIndex = 3
        Me.Quizzes_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_tb
        '
        Me.Test_tb.Location = New System.Drawing.Point(144, 105)
        Me.Test_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.Test_tb.MaxLength = 5
        Me.Test_tb.Name = "Test_tb"
        Me.Test_tb.Size = New System.Drawing.Size(148, 35)
        Me.Test_tb.TabIndex = 2
        Me.Test_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Exam_lb
        '
        Me.Exam_lb.AutoSize = True
        Me.Exam_lb.Location = New System.Drawing.Point(381, 195)
        Me.Exam_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Exam_lb.Name = "Exam_lb"
        Me.Exam_lb.Size = New System.Drawing.Size(84, 29)
        Me.Exam_lb.TabIndex = 14
        Me.Exam_lb.Text = "Exam:"
        '
        'Quizzes_lb
        '
        Me.Quizzes_lb.AutoSize = True
        Me.Quizzes_lb.Location = New System.Drawing.Point(351, 109)
        Me.Quizzes_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Quizzes_lb.Name = "Quizzes_lb"
        Me.Quizzes_lb.Size = New System.Drawing.Size(113, 29)
        Me.Quizzes_lb.TabIndex = 13
        Me.Quizzes_lb.Text = "Quizzes:"
        '
        'Project_lb
        '
        Me.Project_lb.AutoSize = True
        Me.Project_lb.Location = New System.Drawing.Point(10, 188)
        Me.Project_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Project_lb.Name = "Project_lb"
        Me.Project_lb.Size = New System.Drawing.Size(103, 29)
        Me.Project_lb.TabIndex = 12
        Me.Project_lb.Text = "Project:"
        '
        'Test_lb
        '
        Me.Test_lb.AutoSize = True
        Me.Test_lb.Location = New System.Drawing.Point(42, 109)
        Me.Test_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Test_lb.Name = "Test_lb"
        Me.Test_lb.Size = New System.Drawing.Size(72, 29)
        Me.Test_lb.TabIndex = 11
        Me.Test_lb.Text = "Test:"
        '
        'CA_lb
        '
        Me.CA_lb.AutoSize = True
        Me.CA_lb.Location = New System.Drawing.Point(15, 48)
        Me.CA_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CA_lb.Name = "CA_lb"
        Me.CA_lb.Size = New System.Drawing.Size(208, 29)
        Me.CA_lb.TabIndex = 10
        Me.CA_lb.Text = "CA Components:"
        '
        'Confirm_bt
        '
        Me.Confirm_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Confirm_bt.Location = New System.Drawing.Point(694, 140)
        Me.Confirm_bt.Margin = New System.Windows.Forms.Padding(4)
        Me.Confirm_bt.Name = "Confirm_bt"
        Me.Confirm_bt.Size = New System.Drawing.Size(171, 60)
        Me.Confirm_bt.TabIndex = 6
        Me.Confirm_bt.Text = "Confirm"
        Me.Confirm_bt.UseVisualStyleBackColor = True
        '
        'Clear_bt
        '
        Me.Clear_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clear_bt.Location = New System.Drawing.Point(710, 57)
        Me.Clear_bt.Margin = New System.Windows.Forms.Padding(4)
        Me.Clear_bt.Name = "Clear_bt"
        Me.Clear_bt.Size = New System.Drawing.Size(171, 53)
        Me.Clear_bt.TabIndex = 7
        Me.Clear_bt.Text = "Clear All"
        Me.Clear_bt.UseVisualStyleBackColor = True
        '
        'Name_lb
        '
        Me.Name_lb.AutoSize = True
        Me.Name_lb.Location = New System.Drawing.Point(30, 68)
        Me.Name_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Name_lb.Name = "Name_lb"
        Me.Name_lb.Size = New System.Drawing.Size(89, 29)
        Me.Name_lb.TabIndex = 7
        Me.Name_lb.Text = "Name:"
        '
        'Name_tb
        '
        Me.Name_tb.BackColor = System.Drawing.Color.White
        Me.Name_tb.Location = New System.Drawing.Point(129, 62)
        Me.Name_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.Name_tb.MaxLength = 100
        Me.Name_tb.Name = "Name_tb"
        Me.Name_tb.Size = New System.Drawing.Size(526, 35)
        Me.Name_tb.TabIndex = 1
        Me.Name_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Find_tb
        '
        Me.Find_tb.Location = New System.Drawing.Point(26, 912)
        Me.Find_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.Find_tb.Name = "Find_tb"
        Me.Find_tb.Size = New System.Drawing.Size(326, 35)
        Me.Find_tb.TabIndex = 8
        '
        'Student_gb
        '
        Me.Student_gb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Student_gb.Controls.Add(Me.Excel_bt)
        Me.Student_gb.Controls.Add(Me.Label2)
        Me.Student_gb.Controls.Add(Me.Label1)
        Me.Student_gb.Controls.Add(Me.Find_bt)
        Me.Student_gb.Controls.Add(Me.Record_lib)
        Me.Student_gb.Controls.Add(Me.Find_tb)
        Me.Student_gb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_gb.Location = New System.Drawing.Point(1026, 17)
        Me.Student_gb.Margin = New System.Windows.Forms.Padding(4)
        Me.Student_gb.Name = "Student_gb"
        Me.Student_gb.Padding = New System.Windows.Forms.Padding(4)
        Me.Student_gb.Size = New System.Drawing.Size(504, 989)
        Me.Student_gb.TabIndex = 9
        Me.Student_gb.TabStop = False
        Me.Student_gb.Text = "Student Record"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 770)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(361, 29)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Press the delete key to delete"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 728)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Double-click the name to edit"
        '
        'Find_bt
        '
        Me.Find_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Find_bt.Location = New System.Drawing.Point(363, 912)
        Me.Find_bt.Margin = New System.Windows.Forms.Padding(4)
        Me.Find_bt.Name = "Find_bt"
        Me.Find_bt.Size = New System.Drawing.Size(112, 39)
        Me.Find_bt.TabIndex = 9
        Me.Find_bt.Text = "Find "
        Me.Find_bt.UseVisualStyleBackColor = True
        '
        'Record_lib
        '
        Me.Record_lib.AllowDrop = True
        Me.Record_lib.Cursor = System.Windows.Forms.Cursors.Default
        Me.Record_lib.FormattingEnabled = True
        Me.Record_lib.ItemHeight = 29
        Me.Record_lib.Location = New System.Drawing.Point(26, 44)
        Me.Record_lib.Margin = New System.Windows.Forms.Padding(4)
        Me.Record_lib.Name = "Record_lib"
        Me.Record_lib.Size = New System.Drawing.Size(448, 671)
        Me.Record_lib.TabIndex = 10
        '
        'Moduls_Statistics_gb
        '
        Me.Moduls_Statistics_gb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Moduls_Statistics_gb.Controls.Add(Me.Count_of_F_tb)
        Me.Moduls_Statistics_gb.Controls.Add(Me.Count_of_A_tb)
        Me.Moduls_Statistics_gb.Controls.Add(Me.Module_Average_tb)
        Me.Moduls_Statistics_gb.Controls.Add(Me.Number_tb)
        Me.Moduls_Statistics_gb.Controls.Add(Me.Count_of_F_lb)
        Me.Moduls_Statistics_gb.Controls.Add(Me.TextBox3)
        Me.Moduls_Statistics_gb.Controls.Add(Me.Count_of_A_lb)
        Me.Moduls_Statistics_gb.Controls.Add(Me.TextBox2)
        Me.Moduls_Statistics_gb.Controls.Add(Me.TextBox1)
        Me.Moduls_Statistics_gb.Controls.Add(Me.Module_Average_lb)
        Me.Moduls_Statistics_gb.Controls.Add(Me.Mumber_lb)
        Me.Moduls_Statistics_gb.Controls.Add(Me.Show_bt)
        Me.Moduls_Statistics_gb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Moduls_Statistics_gb.ForeColor = System.Drawing.Color.Black
        Me.Moduls_Statistics_gb.Location = New System.Drawing.Point(18, 724)
        Me.Moduls_Statistics_gb.Margin = New System.Windows.Forms.Padding(4)
        Me.Moduls_Statistics_gb.Name = "Moduls_Statistics_gb"
        Me.Moduls_Statistics_gb.Padding = New System.Windows.Forms.Padding(4)
        Me.Moduls_Statistics_gb.Size = New System.Drawing.Size(957, 278)
        Me.Moduls_Statistics_gb.TabIndex = 10
        Me.Moduls_Statistics_gb.TabStop = False
        Me.Moduls_Statistics_gb.Text = "Module Statistics "
        '
        'Count_of_F_tb
        '
        Me.Count_of_F_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Count_of_F_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Count_of_F_tb.Location = New System.Drawing.Point(686, 199)
        Me.Count_of_F_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.Count_of_F_tb.Name = "Count_of_F_tb"
        Me.Count_of_F_tb.ReadOnly = True
        Me.Count_of_F_tb.Size = New System.Drawing.Size(148, 35)
        Me.Count_of_F_tb.TabIndex = 108
        Me.Count_of_F_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Count_of_A_tb
        '
        Me.Count_of_A_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Count_of_A_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Count_of_A_tb.Location = New System.Drawing.Point(304, 199)
        Me.Count_of_A_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.Count_of_A_tb.Name = "Count_of_A_tb"
        Me.Count_of_A_tb.ReadOnly = True
        Me.Count_of_A_tb.Size = New System.Drawing.Size(127, 35)
        Me.Count_of_A_tb.TabIndex = 107
        Me.Count_of_A_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Module_Average_tb
        '
        Me.Module_Average_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Module_Average_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Module_Average_tb.Location = New System.Drawing.Point(686, 116)
        Me.Module_Average_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.Module_Average_tb.Name = "Module_Average_tb"
        Me.Module_Average_tb.ReadOnly = True
        Me.Module_Average_tb.Size = New System.Drawing.Size(148, 35)
        Me.Module_Average_tb.TabIndex = 106
        Me.Module_Average_tb.TabStop = False
        Me.Module_Average_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Number_tb
        '
        Me.Number_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Number_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Number_tb.Location = New System.Drawing.Point(304, 116)
        Me.Number_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.Number_tb.Name = "Number_tb"
        Me.Number_tb.ReadOnly = True
        Me.Number_tb.Size = New System.Drawing.Size(127, 35)
        Me.Number_tb.TabIndex = 105
        Me.Number_tb.TabStop = False
        Me.Number_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Count_of_F_lb
        '
        Me.Count_of_F_lb.AutoSize = True
        Me.Count_of_F_lb.Location = New System.Drawing.Point(531, 204)
        Me.Count_of_F_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Count_of_F_lb.Name = "Count_of_F_lb"
        Me.Count_of_F_lb.Size = New System.Drawing.Size(133, 29)
        Me.Count_of_F_lb.TabIndex = 13
        Me.Count_of_F_lb.Text = "Count of F"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox3.Location = New System.Drawing.Point(640, -116)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(190, 35)
        Me.TextBox3.TabIndex = 8
        '
        'Count_of_A_lb
        '
        Me.Count_of_A_lb.AutoSize = True
        Me.Count_of_A_lb.Location = New System.Drawing.Point(138, 204)
        Me.Count_of_A_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Count_of_A_lb.Name = "Count_of_A_lb"
        Me.Count_of_A_lb.Size = New System.Drawing.Size(140, 29)
        Me.Count_of_A_lb.TabIndex = 12
        Me.Count_of_A_lb.Text = "Count of A "
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox2.Location = New System.Drawing.Point(255, -111)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(163, 35)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox1.Location = New System.Drawing.Point(640, -199)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(190, 35)
        Me.TextBox1.TabIndex = 5
        '
        'Module_Average_lb
        '
        Me.Module_Average_lb.AutoSize = True
        Me.Module_Average_lb.Location = New System.Drawing.Point(465, 120)
        Me.Module_Average_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Module_Average_lb.Name = "Module_Average_lb"
        Me.Module_Average_lb.Size = New System.Drawing.Size(203, 29)
        Me.Module_Average_lb.TabIndex = 11
        Me.Module_Average_lb.Text = "Module Average"
        '
        'Mumber_lb
        '
        Me.Mumber_lb.AutoSize = True
        Me.Mumber_lb.Location = New System.Drawing.Point(26, 122)
        Me.Mumber_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Mumber_lb.Name = "Mumber_lb"
        Me.Mumber_lb.Size = New System.Drawing.Size(251, 29)
        Me.Mumber_lb.TabIndex = 1
        Me.Mumber_lb.Text = "Number of Students "
        '
        'Show_bt
        '
        Me.Show_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Show_bt.Location = New System.Drawing.Point(522, 37)
        Me.Show_bt.Margin = New System.Windows.Forms.Padding(4)
        Me.Show_bt.Name = "Show_bt"
        Me.Show_bt.Size = New System.Drawing.Size(358, 55)
        Me.Show_bt.TabIndex = 11
        Me.Show_bt.Text = "Show Statistics"
        Me.Show_bt.UseVisualStyleBackColor = True
        '
        'Excel_bt
        '
        Me.Excel_bt.Location = New System.Drawing.Point(237, 811)
        Me.Excel_bt.Name = "Excel_bt"
        Me.Excel_bt.Size = New System.Drawing.Size(238, 45)
        Me.Excel_bt.TabIndex = 14
        Me.Excel_bt.Text = "Export to Excel"
        Me.Excel_bt.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1546, 1023)
        Me.Controls.Add(Me.Moduls_Statistics_gb)
        Me.Controls.Add(Me.Student_gb)
        Me.Controls.Add(Me.Input_gp)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.Text = "Calculation of Module Grade "
        Me.Input_gp.ResumeLayout(False)
        Me.Input_gp.PerformLayout()
        Me.Result_gb.ResumeLayout(False)
        Me.Result_gb.PerformLayout()
        Me.lnput_CA_gb.ResumeLayout(False)
        Me.lnput_CA_gb.PerformLayout()
        Me.Student_gb.ResumeLayout(False)
        Me.Student_gb.PerformLayout()
        Me.Moduls_Statistics_gb.ResumeLayout(False)
        Me.Moduls_Statistics_gb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Input_gp As GroupBox
    Friend WithEvents Confirm_bt As Button
    Friend WithEvents Clear_bt As Button
    Friend WithEvents Name_lb As Label
    Friend WithEvents Name_tb As TextBox
    Friend WithEvents CA_Mark__tb As TextBox
    Friend WithEvents Find_tb As TextBox
    Friend WithEvents Module_Marks_tb As TextBox
    Friend WithEvents Module_Grade_tb As TextBox
    Friend WithEvents Remarks_tb As TextBox
    Friend WithEvents Student_gb As GroupBox
    Friend WithEvents Record_lib As ListBox
    Friend WithEvents lnput_CA_gb As GroupBox
    Friend WithEvents Exam_lb As Label
    Friend WithEvents Quizzes_lb As Label
    Friend WithEvents Project_lb As Label
    Friend WithEvents Test_lb As Label
    Friend WithEvents CA_lb As Label
    Friend WithEvents Result_gb As GroupBox
    Friend WithEvents Exam_tb As TextBox
    Friend WithEvents Project_tb As TextBox
    Friend WithEvents Quizzes_tb As TextBox
    Friend WithEvents Test_tb As TextBox
    Friend WithEvents Module_Marks_lb As Label
    Friend WithEvents CA_Marks_lb As Label
    Friend WithEvents Remarks_lb As Label
    Friend WithEvents Module_Grade_lb As Label
    Friend WithEvents Moduls_Statistics_gb As GroupBox
    Friend WithEvents Show_bt As Button
    Friend WithEvents Count_of_F_tb As TextBox
    Friend WithEvents Count_of_A_tb As TextBox
    Friend WithEvents Module_Average_tb As TextBox
    Friend WithEvents Number_tb As TextBox
    Friend WithEvents Count_of_F_lb As Label
    Friend WithEvents Count_of_A_lb As Label
    Friend WithEvents Module_Average_lb As Label
    Friend WithEvents Mumber_lb As Label
    Friend WithEvents Find_bt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Excel_bt As Button
End Class
