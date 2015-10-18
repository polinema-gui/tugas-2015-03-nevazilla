Public Class StarProblems
    Dim result As String = ""

    Private Sub Process_Click(sender As Object, e As EventArgs) Handles Process.Click
        Try
            Select Case Design.Text
                Case "Pyramid"
                    pyramid(Convert.ToInt32(Row.Text))
                Case "Hollow Pyramid"
                    hollowPyramid(Convert.ToInt32(Row.Text))
                Case "Inverted Pyramid"
                    invertedPyramid(Convert.ToInt32(Row.Text))
                Case "Hollow Inverted Pyramid"
                    hollowInvertedPyramid(Convert.ToInt32(Row.Text))
                Case Else
                    Output.Text = "You're not choose a design yet"
            End Select
        Catch ex As Exception
            Output.Text = "Input isn't number"
        End Try
    End Sub

    Private Sub pyramid(border As Integer)
        Dim border1 As Integer = border
        Dim border2 As Integer = border
        For row As Integer = 1 To border
            For column As Integer = 1 To border * 2 - 1
                If (column < border1 Or column > border2) Then
                    Me.result &= "  "
                Else
                    Me.result &= "*"
                End If
            Next
            border1 -= 1
            border2 += 1
            Me.result &= vbCrLf
        Next
        Output.Text = result
        result = ""
    End Sub

    Private Sub hollowPyramid(border As Integer)
        Dim border1 As Integer = border
        Dim border2 As Integer = border
        For row As Integer = 1 To border
            For column As Integer = 1 To border * 2 - 1
                If (row < border) Then
                    If (column = border1 Or column = border2) Then
                        Me.result &= "*"
                    Else
                        Me.result &= "  "
                    End If
                Else
                    Me.result &= "*"
                End If
            Next
            border1 -= 1
            border2 += 1
            Me.result &= vbCrLf
        Next
        Output.Text = result
        result = ""
    End Sub

    Private Sub invertedPyramid(border As Integer)
        Dim border1 As Integer = 0
        Dim border2 As Integer = border * 2
        For row As Integer = 1 To border
            For column As Integer = 1 To border * 2 - 1
                If (column > border1 And column < border2) Then
                    Me.result &= "*"
                Else
                    Me.result &= "  "
                End If
            Next
            Me.result &= vbCrLf
            border1 += 1
            border2 -= 1
        Next
        Output.Text = result
        Me.result = ""
    End Sub

    Private Sub hollowInvertedPyramid(border As Integer)
        Dim border1 As Integer = 1
        Dim border2 As Integer = border * 2 - 1
        For row As Integer = 1 To border
            For column As Integer = 1 To border * 2 - 1
                If (row = 1) Then
                    Me.result &= "*"
                Else
                    If (column = border1 Or column = border2) Then
                        Me.result &= "*"
                    Else
                        Me.result &= "  "
                    End If
                End If
            Next
            border1 += 1
            border2 -= 1
            Me.result &= vbCrLf
        Next
        Output.Text = result
        Me.result = ""
    End Sub

End Class