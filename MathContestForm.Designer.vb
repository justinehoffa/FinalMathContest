<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
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
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummeryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.e = New System.Windows.Forms.Label()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.StudentInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.CurrentMathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.MathProblemTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StudentInformationGroupBox.SuspendLayout()
        Me.CurrentMathProblemGroupBox.SuspendLayout()
        Me.MathProblemTypeGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(64, 30)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(277, 104)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(64, 154)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(277, 104)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummeryButton
        '
        Me.SummeryButton.Location = New System.Drawing.Point(64, 278)
        Me.SummeryButton.Name = "SummeryButton"
        Me.SummeryButton.Size = New System.Drawing.Size(277, 104)
        Me.SummeryButton.TabIndex = 12
        Me.SummeryButton.Text = "&Summery"
        Me.SummeryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(64, 402)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(277, 104)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(27, 84)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(275, 31)
        Me.NameTextBox.TabIndex = 0
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(355, 84)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(82, 31)
        Me.AgeTextBox.TabIndex = 1
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(507, 105)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(82, 31)
        Me.GradeTextBox.TabIndex = 2
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(24, 72)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(275, 31)
        Me.FirstNumberTextBox.TabIndex = 3
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(24, 177)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(275, 31)
        Me.SecondNumberTextBox.TabIndex = 4
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(24, 282)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(275, 31)
        Me.StudentAnswerTextBox.TabIndex = 5
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(22, 56)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(68, 25)
        Me.NameLabel.TabIndex = 10
        Me.NameLabel.Text = "Name"
        '
        'e
        '
        Me.e.AutoSize = True
        Me.e.Location = New System.Drawing.Point(350, 56)
        Me.e.Name = "e"
        Me.e.Size = New System.Drawing.Size(50, 25)
        Me.e.TabIndex = 11
        Me.e.Text = "Age"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(490, 56)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(71, 25)
        Me.GradeLabel.TabIndex = 12
        Me.GradeLabel.Text = "Grade"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(19, 44)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(122, 25)
        Me.FirstNumberLabel.TabIndex = 13
        Me.FirstNumberLabel.Text = "1st Number"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(19, 149)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(129, 25)
        Me.SecondNumberLabel.TabIndex = 14
        Me.SecondNumberLabel.Text = "2nd Number"
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(19, 254)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(163, 25)
        Me.StudentAnswerLabel.TabIndex = 15
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(102, 73)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(81, 29)
        Me.AddRadioButton.TabIndex = 6
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(102, 132)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(123, 29)
        Me.SubtractRadioButton.TabIndex = 7
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(102, 191)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(117, 29)
        Me.MultiplyRadioButton.TabIndex = 8
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Mulitply"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(102, 250)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(103, 29)
        Me.DivideRadioButton.TabIndex = 9
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'StudentInformationGroupBox
        '
        Me.StudentInformationGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInformationGroupBox.Controls.Add(Me.NameTextBox)
        Me.StudentInformationGroupBox.Controls.Add(Me.e)
        Me.StudentInformationGroupBox.Controls.Add(Me.NameLabel)
        Me.StudentInformationGroupBox.Controls.Add(Me.AgeTextBox)
        Me.StudentInformationGroupBox.Location = New System.Drawing.Point(12, 21)
        Me.StudentInformationGroupBox.Name = "StudentInformationGroupBox"
        Me.StudentInformationGroupBox.Size = New System.Drawing.Size(680, 171)
        Me.StudentInformationGroupBox.TabIndex = 20
        Me.StudentInformationGroupBox.TabStop = False
        Me.StudentInformationGroupBox.Text = "Student Information"
        '
        'CurrentMathProblemGroupBox
        '
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.CurrentMathProblemGroupBox.Location = New System.Drawing.Point(15, 210)
        Me.CurrentMathProblemGroupBox.Name = "CurrentMathProblemGroupBox"
        Me.CurrentMathProblemGroupBox.Size = New System.Drawing.Size(325, 344)
        Me.CurrentMathProblemGroupBox.TabIndex = 21
        Me.CurrentMathProblemGroupBox.TabStop = False
        Me.CurrentMathProblemGroupBox.Text = "Current Math Problem"
        '
        'MathProblemTypeGroupBox
        '
        Me.MathProblemTypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MathProblemTypeGroupBox.Location = New System.Drawing.Point(367, 210)
        Me.MathProblemTypeGroupBox.Name = "MathProblemTypeGroupBox"
        Me.MathProblemTypeGroupBox.Size = New System.Drawing.Size(325, 344)
        Me.MathProblemTypeGroupBox.TabIndex = 22
        Me.MathProblemTypeGroupBox.TabStop = False
        Me.MathProblemTypeGroupBox.Text = "Math Problem Type"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SubmitButton)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.SummeryButton)
        Me.GroupBox1.Controls.Add(Me.ExitButton)
        Me.GroupBox1.Location = New System.Drawing.Point(717, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 533)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'MathContestForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(1121, 574)
        Me.Controls.Add(Me.GradeTextBox)
        Me.Controls.Add(Me.StudentInformationGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CurrentMathProblemGroupBox)
        Me.Controls.Add(Me.MathProblemTypeGroupBox)
        Me.Name = "MathContestForm"
        Me.Text = "Math Contest"
        Me.StudentInformationGroupBox.ResumeLayout(False)
        Me.StudentInformationGroupBox.PerformLayout()
        Me.CurrentMathProblemGroupBox.ResumeLayout(False)
        Me.CurrentMathProblemGroupBox.PerformLayout()
        Me.MathProblemTypeGroupBox.ResumeLayout(False)
        Me.MathProblemTypeGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummeryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents e As Label
    Friend WithEvents GradeLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents StudentInformationGroupBox As GroupBox
    Friend WithEvents CurrentMathProblemGroupBox As GroupBox
    Friend WithEvents MathProblemTypeGroupBox As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
