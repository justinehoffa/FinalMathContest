'Justine Hoffa
'RCET0265
'Math Contest
'https://github.com/justinehoffa/FinalMathContest

Option Strict On
Option Explicit On
Option Compare Binary

Public Class MathContestForm
    Dim studentAnswer As Integer
    Dim correctAnswer As Integer
    Dim firstNumber As Integer
    Dim secondNumber As Integer
    Dim numbersCorrect As Integer
    Dim numberOfProblems As Integer
    Dim ageNumber As Integer
    Dim gradeNumber As Integer
    Dim studentinfoValidated As Boolean
    Dim ageValidated As Boolean
    Dim studentName As String
    Dim gradeValidated As Boolean
    Dim nameValidated As Boolean
    Dim answerValidated As Boolean

    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        FirstNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
        SecondNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
        FirstNumberTextBox.Enabled = False
        SecondNumberTextBox.Enabled = False
        SummeryButton.Enabled = False
        AddRadioButton.Checked = True
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Try
            studentName = NameTextBox.Text
            If studentName = "" Then
                MsgBox("Please enter Student Name.")
                studentinfoValidated = False
            Else
                nameValidated = True
            End If
        Catch ex As Exception
            MsgBox("Please enter valid name.")
            nameValidated = False
            studentinfoValidated = False
            NameTextBox.Text = ""
        End Try

        Try
            ageNumber = CInt(AgeTextBox.Text)
            If ageNumber < 7 Or ageNumber > 11 Then
                MsgBox("Student must be 7-11 years of age to be eligible to compete.")
                studentinfoValidated = False
            Else
                ageValidated = True
            End If
        Catch ex As Exception
            MsgBox("Please enter valid age.")
            ageValidated = False
            studentinfoValidated = False
            AgeTextBox.Text = ""
        End Try

        Try
            gradeNumber = CInt(GradeTextBox.Text)
            If gradeNumber < 1 Or gradeNumber > 4 Then
                MsgBox("Student must be in grade level 1-4 to be eligble to compete.")
                studentinfoValidated = False
            Else
                gradeValidated = True
            End If
        Catch ex As Exception
            MsgBox("Please enter valid grade.")
            gradeValidated = False
            studentinfoValidated = False
            GradeTextBox.Text = ""
        End Try

        Try
            If StudentAnswerTextBox.Text = "" Then
                MsgBox("Please enter answer to the following math question.")
            Else
                answerValidated = True
            End If
        Catch ex As Exception
            MsgBox("Please enter valid answer.")
            answerValidated = False
            studentinfoValidated = False
            StudentAnswerTextBox.Text = ""
        End Try

        If gradeValidated And ageValidated And nameValidated And answerValidated = True Then
            studentinfoValidated = True
        End If

        If studentinfoValidated = True Then
            firstNumber = CInt(FirstNumberTextBox.Text)
            secondNumber = CInt(SecondNumberTextBox.Text)
            gradeNumber = CInt(GradeTextBox.Text)

            If AddRadioButton.Checked = True Then
                correctAnswer = firstNumber + secondNumber
            ElseIf SubtractRadioButton.Checked = True Then
                correctAnswer = firstNumber - secondNumber
            ElseIf DivideRadioButton.Checked = True Then
                correctAnswer = CInt(firstNumber / secondNumber)
            ElseIf MultiplyRadioButton.Checked = True Then
                correctAnswer = firstNumber * secondNumber
            End If

            Try
                studentAnswer = CInt(StudentAnswerTextBox.Text)
                If studentAnswer = correctAnswer Then
                    MsgBox("Good job, that is correct!")
                    numbersCorrect += 1
                ElseIf studentAnswer <> correctAnswer Then
                    MsgBox("Sorry, that is not correct. The correct answer was " & correctAnswer & ".")
                End If
            Catch ex As Exception
                MsgBox("Sorry, that is not correct. The correct answer was " & correctAnswer & ".")
            End Try

            SummeryButton.Enabled = True
            numberOfProblems += 1
            FirstNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
            SecondNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
            StudentAnswerTextBox.Text = ""
        End If
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummeryButton.Click
        MsgBox(studentName & " got " & numbersCorrect & " answers correct out of " & numberOfProblems & " problems.")
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        GradeTextBox.Text = ""
        AgeTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        AddRadioButton.Enabled = True
        numbersCorrect = 0
        numberOfProblems = 0
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
