Public Class Indeks

    Private Sub StarsProblemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StarsProblemToolStripMenuItem.Click
        StarProblems.MdiParent = Me
        StarProblems.Show()
    End Sub

    Private Sub MatrixCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatrixCalculatorToolStripMenuItem.Click
        Matrix.MdiParent = Me
        Matrix.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Environment.Exit(0)
    End Sub

End Class
