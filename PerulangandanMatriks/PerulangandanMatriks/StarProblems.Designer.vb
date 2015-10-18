<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StarProblems
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
        Me.Design = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Row = New System.Windows.Forms.TextBox()
        Me.Output = New System.Windows.Forms.TextBox()
        Me.Process = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Design
        '
        Me.Design.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Design.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Design.FormattingEnabled = True
        Me.Design.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.Design.Location = New System.Drawing.Point(82, 13)
        Me.Design.Name = "Design"
        Me.Design.Size = New System.Drawing.Size(399, 24)
        Me.Design.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Design   :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Row        :"
        '
        'Row
        '
        Me.Row.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Row.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Row.Location = New System.Drawing.Point(82, 43)
        Me.Row.Multiline = True
        Me.Row.Name = "Row"
        Me.Row.Size = New System.Drawing.Size(299, 22)
        Me.Row.TabIndex = 4
        '
        'Output
        '
        Me.Output.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Output.Location = New System.Drawing.Point(18, 74)
        Me.Output.Multiline = True
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(463, 324)
        Me.Output.TabIndex = 5
        '
        'Process
        '
        Me.Process.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Process.Location = New System.Drawing.Point(387, 43)
        Me.Process.Name = "Process"
        Me.Process.Size = New System.Drawing.Size(94, 23)
        Me.Process.TabIndex = 6
        Me.Process.Text = "Process"
        Me.Process.UseVisualStyleBackColor = True
        '
        'StarsProblem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 436)
        Me.Controls.Add(Me.Process)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.Row)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Design)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "StarsProblem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StarsProblem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Design As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Row As System.Windows.Forms.TextBox
    Friend WithEvents Output As System.Windows.Forms.TextBox
    Friend WithEvents Process As System.Windows.Forms.Button
End Class
