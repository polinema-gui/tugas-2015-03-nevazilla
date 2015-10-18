<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matrix
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Mat1 = New System.Windows.Forms.TextBox()
        Me.Operation = New System.Windows.Forms.ComboBox()
        Me.Mat2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Output = New System.Windows.Forms.TextBox()
        Me.Process = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Matrix 1    :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Matrix 2     :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Operation :"
        '
        'Mat1
        '
        Me.Mat1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mat1.Location = New System.Drawing.Point(114, 30)
        Me.Mat1.Multiline = True
        Me.Mat1.Name = "Mat1"
        Me.Mat1.Size = New System.Drawing.Size(354, 103)
        Me.Mat1.TabIndex = 5
        '
        'Operation
        '
        Me.Operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Operation.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Operation.FormattingEnabled = True
        Me.Operation.Items.AddRange(New Object() {"Plus", "Minus"})
        Me.Operation.Location = New System.Drawing.Point(114, 139)
        Me.Operation.Name = "Operation"
        Me.Operation.Size = New System.Drawing.Size(354, 25)
        Me.Operation.TabIndex = 6
        '
        'Mat2
        '
        Me.Mat2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mat2.Location = New System.Drawing.Point(114, 170)
        Me.Mat2.Multiline = True
        Me.Mat2.Name = "Mat2"
        Me.Mat2.Size = New System.Drawing.Size(354, 103)
        Me.Mat2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Result       :"
        '
        'Output
        '
        Me.Output.Location = New System.Drawing.Point(114, 278)
        Me.Output.Multiline = True
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(354, 103)
        Me.Output.TabIndex = 9
        '
        'Process
        '
        Me.Process.Location = New System.Drawing.Point(370, 393)
        Me.Process.Name = "Process"
        Me.Process.Size = New System.Drawing.Size(98, 23)
        Me.Process.TabIndex = 10
        Me.Process.Text = "Process"
        Me.Process.UseVisualStyleBackColor = True
        '
        'Matrix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 437)
        Me.Controls.Add(Me.Process)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Mat2)
        Me.Controls.Add(Me.Operation)
        Me.Controls.Add(Me.Mat1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Matrix"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matrix Calculator "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Mat1 As System.Windows.Forms.TextBox
    Friend WithEvents Operation As System.Windows.Forms.ComboBox
    Friend WithEvents Mat2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Output As System.Windows.Forms.TextBox
    Friend WithEvents Process As System.Windows.Forms.Button
End Class
