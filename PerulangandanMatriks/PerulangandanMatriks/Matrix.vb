Public Class Matrix
Dim columnCheck As Boolean = True
    Private Sub Process_Click(sender As Object, e As EventArgs) Handles Process.Click
        Try
            Dim rowMatrix1 As Integer = Mat1.Lines.Count
            Dim columnMatrix1 As Integer = Mat1.Lines.ElementAt(0).Split(" ").Length
            Dim rowMatrix2 As Integer = Mat1.Lines.Count
            Dim columnMatrix2 As Integer = Mat1.Lines.ElementAt(0).Split(" ").Length
            Dim matrixCopy1(rowMatrix1, columnMatrix1) As Integer
            Dim matrixCopy2(rowMatrix2, columnMatrix2) As Integer
            check(rowMatrix1, rowMatrix2, columnMatrix1, columnMatrix2)
            copyToArray(rowMatrix1, rowMatrix2, columnMatrix1, columnMatrix2, matrixCopy1, matrixCopy2)
            Operating(matrixCopy1, matrixCopy2, rowMatrix1, columnMatrix2)
        Catch ex As Exception
            MsgBox("Invalid Input")
        End Try
    End Sub

    Private Sub check(ByVal row1 As Integer, row2 As Integer, column1 As Integer, column2 As Integer)
        Dim tmp As Boolean = True
        For row = 0 To row1 - 2
            If (Mat1.Lines.ElementAt(row).Split(" ").Length <> Mat1.Lines.ElementAt(row + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        For row = 0 To row2 - 2
            If (Mat2.Lines.ElementAt(row).Split(" ").Length <> Mat2.Lines.ElementAt(row + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        If (tmp = False) Then
            Me.columnCheck = False
            Convert.ToInt32(Mat1.Text)
            Convert.ToInt32(Mat2.Text)
            MsgBox("Invalid Matrix")
        ElseIf (row1 = row2 And column1 = column2) Then
            Me.columnCheck = True
        Else
            Me.columnCheck = False
            MsgBox("All row and column of matrix must same")
        End If
    End Sub

    Private Sub copyToArray(ByVal row1 As Integer, row2 As Integer, column1 As Integer, column2 As Integer, ByRef value1(,) As Integer, ByRef value2(,) As Integer)
        If (Me.columnCheck) Then
            For row As Integer = 0 To row1 - 1
                For column As Integer = 0 To column1 - 1
                    value1(row, column) = Mat1.Lines.ElementAt(row).Split(" ").ElementAt(column)
                    value2(row, column) = Mat2.Lines.ElementAt(row).Split(" ").ElementAt(column)
                Next
            Next
        End If
    End Sub

    Private Sub operating(ByVal matrix1(,) As Integer, matrix2(,) As Integer, borderRow As Integer, borderColumn As Integer)
        Dim result As String = ""
        If (Me.columnCheck) Then
            Select Case Operation.Text
                Case "Plus"
                    For row As Integer = 0 To borderRow - 1
                        For column As Integer = 0 To borderColumn - 1
                            result &= (matrix1(row, column) + matrix2(row, column)).ToString & vbTab
                        Next
                        result &= vbNewLine
                    Next
                Case "Minus"
                    For row As Integer = 0 To borderRow - 1
                        For column As Integer = 0 To borderColumn - 1
                            result &= (matrix1(row, column) - matrix2(row, column)).ToString & vbTab
                        Next
                        result &= vbNewLine
                    Next
                Case Else
                    MsgBox("You're not choose operation yet")
            End Select
            Output.Text = result
        End If
    End Sub

End Class