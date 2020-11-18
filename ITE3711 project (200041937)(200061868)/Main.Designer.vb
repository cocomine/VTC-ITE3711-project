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
        Me.Input_gp.Location = New System.Drawing.Point(12, 12)
        Me.Input_gp.Name = "Input_gp"
        Me.Input_gp.Size = New System.Drawing.Size(638, 505)
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
        Me.Result_gb.Location = New System.Drawing.Point(10, 308)
        Me.Result_gb.Name = "Result_gb"
        Me.Result_gb.Size = New System.Drawing.Size(605, 179)
        Me.Result_gb.TabIndex = 11
        Me.Result_gb.TabStop = False
        Me.Result_gb.Text = "Module Result"
        '
        'Remarks_lb
        '
        Me.Remarks_lb.AutoSize = True
        Me.Remarks_lb.Location = New System.Drawing.Point(316, 127)
        Me.Remarks_lb.Name = "Remarks_lb"
        Me.Remarks_lb.Size = New System.Drawing.Size(80, 20)
        Me.Remarks_lb.TabIndex = 12
        Me.Remarks_lb.Text = "Remarks"
        '
        'Module_Grade_lb
        '
        Me.Module_Grade_lb.AutoSize = True
        Me.Module_Grade_lb.Location = New System.Drawing.Point(32, 130)
        Me.Module_Grade_lb.Name = "Module_Grade_lb"
        Me.Module_Grade_lb.Size = New System.Drawing.Size(122, 20)
        Me.Module_Grade_lb.TabIndex = 11
        Me.Module_Grade_lb.Text = "Module Grade"
        '
        'Module_Marks_lb
        '
        Me.Module_Marks_lb.AutoSize = True
        Me.Module_Marks_lb.Location = New System.Drawing.Point(276, 66)
        Me.Module_Marks_lb.Name = "Module_Marks_lb"
        Me.Module_Marks_lb.Size = New System.Drawing.Size(120, 20)
        Me.Module_Marks_lb.TabIndex = 10
        Me.Module_Marks_lb.Text = "Module Marks"
        '
        'CA_Marks_lb
        '
        Me.CA_Marks_lb.AutoSize = True
        Me.CA_Marks_lb.Location = New System.Drawing.Point(63, 63)
        Me.CA_Marks_lb.Name = "CA_Marks_lb"
        Me.CA_Marks_lb.Size = New System.Drawing.Size(91, 20)
        Me.CA_Marks_lb.TabIndex = 9
        Me.CA_Marks_lb.Text = "CA Marks "
        '
        'CA_Mark__tb
        '
        Me.CA_Mark__tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CA_Mark__tb.Cursor = System.Windows.Forms.Cursors.No
        Me.CA_Mark__tb.Location = New System.Drawing.Point(160, 63)
        Me.CA_Mark__tb.Name = "CA_Mark__tb"
        Me.CA_Mark__tb.ReadOnly = True
        Me.CA_Mark__tb.Size = New System.Drawing.Size(110, 26)
        Me.CA_Mark__tb.TabIndex = 101
        Me.CA_Mark__tb.TabStop = False
        Me.CA_Mark__tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Remarks_tb
        '
        Me.Remarks_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Remarks_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Remarks_tb.Location = New System.Drawing.Point(417, 123)
        Me.Remarks_tb.Name = "Remarks_tb"
        Me.Remarks_tb.ReadOnly = True
        Me.Remarks_tb.Size = New System.Drawing.Size(128, 26)
        Me.Remarks_tb.TabIndex = 104
        Me.Remarks_tb.TabStop = False
        Me.Remarks_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Module_Grade_tb
        '
        Me.Module_Grade_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Module_Grade_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Module_Grade_tb.Location = New System.Drawing.Point(160, 127)
        Me.Module_Grade_tb.Name = "Module_Grade_tb"
        Me.Module_Grade_tb.ReadOnly = True
        Me.Module_Grade_tb.Size = New System.Drawing.Size(110, 26)
        Me.Module_Grade_tb.TabIndex = 103
        Me.Module_Grade_tb.TabStop = False
        Me.Module_Grade_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Module_Marks_tb
        '
        Me.Module_Marks_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Module_Marks_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Module_Marks_tb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Module_Marks_tb.Location = New System.Drawing.Point(417, 63)
        Me.Module_Marks_tb.Name = "Module_Marks_tb"
        Me.Module_Marks_tb.ReadOnly = True
        Me.Module_Marks_tb.Size = New System.Drawing.Size(128, 26)
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
        Me.lnput_CA_gb.Location = New System.Drawing.Point(10, 107)
        Me.lnput_CA_gb.Name = "lnput_CA_gb"
        Me.lnput_CA_gb.Size = New System.Drawing.Size(605, 195)
        Me.lnput_CA_gb.TabIndex = 10
        Me.lnput_CA_gb.TabStop = False
        Me.lnput_CA_gb.Text = "Input CA and Exam Marks "
        '
        'Exam_tb
        '
        Me.Exam_tb.Location = New System.Drawing.Point(328, 136)
        Me.Exam_tb.MaxLength = 5
        Me.Exam_tb.Name = "Exam_tb"
        Me.Exam_tb.Size = New System.Drawing.Size(100, 26)
        Me.Exam_tb.TabIndex = 5
        Me.Exam_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Project_tb
        '
        Me.Project_tb.Location = New System.Drawing.Point(96, 136)
        Me.Project_tb.MaxLength = 5
        Me.Project_tb.Name = "Project_tb"
        Me.Project_tb.Size = New System.Drawing.Size(100, 26)
        Me.Project_tb.TabIndex = 4
        Me.Project_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Quizzes_tb
        '
        Me.Quizzes_tb.Location = New System.Drawing.Point(328, 76)
        Me.Quizzes_tb.MaxLength = 5
        Me.Quizzes_tb.Name = "Quizzes_tb"
        Me.Quizzes_tb.Size = New System.Drawing.Size(100, 26)
        Me.Quizzes_tb.TabIndex = 3
        Me.Quizzes_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_tb
        '
        Me.Test_tb.Location = New System.Drawing.Point(96, 76)
        Me.Test_tb.MaxLength = 5
        Me.Test_tb.Name = "Test_tb"
        Me.Test_tb.Size = New System.Drawing.Size(100, 26)
        Me.Test_tb.TabIndex = 2
        Me.Test_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Exam_lb
        '
        Me.Exam_lb.AutoSize = True
        Me.Exam_lb.Location = New System.Drawing.Point(254, 141)
        Me.Exam_lb.Name = "Exam_lb"
        Me.Exam_lb.Size = New System.Drawing.Size(58, 20)
        Me.Exam_lb.TabIndex = 14
        Me.Exam_lb.Text = "Exam:"
        '
        'Quizzes_lb
        '
        Me.Quizzes_lb.AutoSize = True
        Me.Quizzes_lb.Location = New System.Drawing.Point(234, 79)
        Me.Quizzes_lb.Name = "Quizzes_lb"
        Me.Quizzes_lb.Size = New System.Drawing.Size(78, 20)
        Me.Quizzes_lb.TabIndex = 13
        Me.Quizzes_lb.Text = "Quizzes:"
        '
        'Project_lb
        '
        Me.Project_lb.AutoSize = True
        Me.Project_lb.Location = New System.Drawing.Point(7, 136)
        Me.Project_lb.Name = "Project_lb"
        Me.Project_lb.Size = New System.Drawing.Size(70, 20)
        Me.Project_lb.TabIndex = 12
        Me.Project_lb.Text = "Project:"
        '
        'Test_lb
        '
        Me.Test_lb.AutoSize = True
        Me.Test_lb.Location = New System.Drawing.Point(28, 79)
        Me.Test_lb.Name = "Test_lb"
        Me.Test_lb.Size = New System.Drawing.Size(49, 20)
        Me.Test_lb.TabIndex = 11
        Me.Test_lb.Text = "Test:"
        '
        'CA_lb
        '
        Me.CA_lb.AutoSize = True
        Me.CA_lb.Location = New System.Drawing.Point(10, 35)
        Me.CA_lb.Name = "CA_lb"
        Me.CA_lb.Size = New System.Drawing.Size(144, 20)
        Me.CA_lb.TabIndex = 10
        Me.CA_lb.Text = "CA Components:"
        '
        'Confirm_bt
        '
        Me.Confirm_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Confirm_bt.Location = New System.Drawing.Point(463, 101)
        Me.Confirm_bt.Name = "Confirm_bt"
        Me.Confirm_bt.Size = New System.Drawing.Size(114, 43)
        Me.Confirm_bt.TabIndex = 6
        Me.Confirm_bt.Text = "Confirm"
        Me.Confirm_bt.UseVisualStyleBackColor = True
        '
        'Clear_bt
        '
        Me.Clear_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clear_bt.Location = New System.Drawing.Point(473, 41)
        Me.Clear_bt.Name = "Clear_bt"
        Me.Clear_bt.Size = New System.Drawing.Size(114, 38)
        Me.Clear_bt.TabIndex = 7
        Me.Clear_bt.Text = "Clear All"
        Me.Clear_bt.UseVisualStyleBackColor = True
        '
        'Name_lb
        '
        Me.Name_lb.AutoSize = True
        Me.Name_lb.Location = New System.Drawing.Point(20, 49)
        Me.Name_lb.Name = "Name_lb"
        Me.Name_lb.Size = New System.Drawing.Size(60, 20)
        Me.Name_lb.TabIndex = 7
        Me.Name_lb.Text = "Name:"
        '
        'Name_tb
        '
        Me.Name_tb.BackColor = System.Drawing.Color.White
        Me.Name_tb.Location = New System.Drawing.Point(86, 45)
        Me.Name_tb.MaxLength = 100
        Me.Name_tb.Name = "Name_tb"
        Me.Name_tb.Size = New System.Drawing.Size(352, 26)
        Me.Name_tb.TabIndex = 1
        Me.Name_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Find_tb
        '
        Me.Find_tb.Location = New System.Drawing.Point(17, 659)
        Me.Find_tb.Name = "Find_tb"
        Me.Find_tb.Size = New System.Drawing.Size(219, 26)
        Me.Find_tb.TabIndex = 8
        '
        'Student_gb
        '
        Me.Student_gb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Student_gb.Controls.Add(Me.Label1)
        Me.Student_gb.Controls.Add(Me.Find_bt)
        Me.Student_gb.Controls.Add(Me.Record_lib)
        Me.Student_gb.Controls.Add(Me.Find_tb)
        Me.Student_gb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_gb.Location = New System.Drawing.Point(684, 12)
        Me.Student_gb.Name = "Student_gb"
        Me.Student_gb.Size = New System.Drawing.Size(336, 714)
        Me.Student_gb.TabIndex = 9
        Me.Student_gb.TabStop = False
        Me.Student_gb.Text = "Student Record"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 549)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Double-click the name to edit"
        '
        'Find_bt
        '
        Me.Find_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Find_bt.Location = New System.Drawing.Point(242, 659)
        Me.Find_bt.Name = "Find_bt"
        Me.Find_bt.Size = New System.Drawing.Size(75, 28)
        Me.Find_bt.TabIndex = 9
        Me.Find_bt.Text = "Find "
        Me.Find_bt.UseVisualStyleBackColor = True
        '
        'Record_lib
        '
        Me.Record_lib.AllowDrop = True
        Me.Record_lib.Cursor = System.Windows.Forms.Cursors.Default
        Me.Record_lib.FormattingEnabled = True
        Me.Record_lib.ItemHeight = 20
        Me.Record_lib.Location = New System.Drawing.Point(17, 32)
        Me.Record_lib.Name = "Record_lib"
        Me.Record_lib.Size = New System.Drawing.Size(300, 504)
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
        Me.Moduls_Statistics_gb.Location = New System.Drawing.Point(12, 523)
        Me.Moduls_Statistics_gb.Name = "Moduls_Statistics_gb"
        Me.Moduls_Statistics_gb.Size = New System.Drawing.Size(638, 201)
        Me.Moduls_Statistics_gb.TabIndex = 10
        Me.Moduls_Statistics_gb.TabStop = False
        Me.Moduls_Statistics_gb.Text = "Module Statistics "
        '
        'Count_of_F_tb
        '
        Me.Count_of_F_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Count_of_F_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Count_of_F_tb.Location = New System.Drawing.Point(457, 144)
        Me.Count_of_F_tb.Name = "Count_of_F_tb"
        Me.Count_of_F_tb.ReadOnly = True
        Me.Count_of_F_tb.Size = New System.Drawing.Size(100, 26)
        Me.Count_of_F_tb.TabIndex = 108
        Me.Count_of_F_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Count_of_A_tb
        '
        Me.Count_of_A_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Count_of_A_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Count_of_A_tb.Location = New System.Drawing.Point(203, 144)
        Me.Count_of_A_tb.Name = "Count_of_A_tb"
        Me.Count_of_A_tb.ReadOnly = True
        Me.Count_of_A_tb.Size = New System.Drawing.Size(86, 26)
        Me.Count_of_A_tb.TabIndex = 107
        Me.Count_of_A_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Module_Average_tb
        '
        Me.Module_Average_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Module_Average_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Module_Average_tb.Location = New System.Drawing.Point(457, 84)
        Me.Module_Average_tb.Name = "Module_Average_tb"
        Me.Module_Average_tb.ReadOnly = True
        Me.Module_Average_tb.Size = New System.Drawing.Size(100, 26)
        Me.Module_Average_tb.TabIndex = 106
        Me.Module_Average_tb.TabStop = False
        Me.Module_Average_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Number_tb
        '
        Me.Number_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Number_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Number_tb.Location = New System.Drawing.Point(203, 84)
        Me.Number_tb.Name = "Number_tb"
        Me.Number_tb.ReadOnly = True
        Me.Number_tb.Size = New System.Drawing.Size(86, 26)
        Me.Number_tb.TabIndex = 105
        Me.Number_tb.TabStop = False
        Me.Number_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Count_of_F_lb
        '
        Me.Count_of_F_lb.AutoSize = True
        Me.Count_of_F_lb.Location = New System.Drawing.Point(354, 147)
        Me.Count_of_F_lb.Name = "Count_of_F_lb"
        Me.Count_of_F_lb.Size = New System.Drawing.Size(94, 20)
        Me.Count_of_F_lb.TabIndex = 13
        Me.Count_of_F_lb.Text = "Count of F"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox3.Location = New System.Drawing.Point(427, -84)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(128, 26)
        Me.TextBox3.TabIndex = 8
        '
        'Count_of_A_lb
        '
        Me.Count_of_A_lb.AutoSize = True
        Me.Count_of_A_lb.Location = New System.Drawing.Point(92, 147)
        Me.Count_of_A_lb.Name = "Count_of_A_lb"
        Me.Count_of_A_lb.Size = New System.Drawing.Size(100, 20)
        Me.Count_of_A_lb.TabIndex = 12
        Me.Count_of_A_lb.Text = "Count of A "
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox2.Location = New System.Drawing.Point(170, -80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(110, 26)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox1.Location = New System.Drawing.Point(427, -144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(128, 26)
        Me.TextBox1.TabIndex = 5
        '
        'Module_Average_lb
        '
        Me.Module_Average_lb.AutoSize = True
        Me.Module_Average_lb.Location = New System.Drawing.Point(310, 87)
        Me.Module_Average_lb.Name = "Module_Average_lb"
        Me.Module_Average_lb.Size = New System.Drawing.Size(138, 20)
        Me.Module_Average_lb.TabIndex = 11
        Me.Module_Average_lb.Text = "Module Average"
        '
        'Mumber_lb
        '
        Me.Mumber_lb.AutoSize = True
        Me.Mumber_lb.Location = New System.Drawing.Point(17, 88)
        Me.Mumber_lb.Name = "Mumber_lb"
        Me.Mumber_lb.Size = New System.Drawing.Size(175, 20)
        Me.Mumber_lb.TabIndex = 1
        Me.Mumber_lb.Text = "Number of Students "
        '
        'Show_bt
        '
        Me.Show_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Show_bt.Location = New System.Drawing.Point(348, 27)
        Me.Show_bt.Name = "Show_bt"
        Me.Show_bt.Size = New System.Drawing.Size(239, 40)
        Me.Show_bt.TabIndex = 11
        Me.Show_bt.Text = "Show Statistics"
        Me.Show_bt.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 739)
        Me.Controls.Add(Me.Moduls_Statistics_gb)
        Me.Controls.Add(Me.Student_gb)
        Me.Controls.Add(Me.Input_gp)
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
End Class
