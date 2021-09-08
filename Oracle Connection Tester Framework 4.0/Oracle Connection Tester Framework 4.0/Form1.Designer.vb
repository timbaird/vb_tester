<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TestConnectionBtn = New System.Windows.Forms.Button()
        Me.TB_User = New System.Windows.Forms.TextBox()
        Me.TB_Pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TestConnectionBtn
        '
        Me.TestConnectionBtn.Location = New System.Drawing.Point(80, 128)
        Me.TestConnectionBtn.Name = "TestConnectionBtn"
        Me.TestConnectionBtn.Size = New System.Drawing.Size(140, 23)
        Me.TestConnectionBtn.TabIndex = 0
        Me.TestConnectionBtn.Text = "Test Oracle Connection"
        Me.TestConnectionBtn.UseVisualStyleBackColor = True
        '
        'TB_User
        '
        Me.TB_User.Location = New System.Drawing.Point(109, 56)
        Me.TB_User.Name = "TB_User"
        Me.TB_User.Size = New System.Drawing.Size(149, 20)
        Me.TB_User.TabIndex = 1
        '
        'TB_Pass
        '
        Me.TB_Pass.Location = New System.Drawing.Point(109, 83)
        Me.TB_Pass.Name = "TB_Pass"
        Me.TB_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_Pass.Size = New System.Drawing.Size(149, 20)
        Me.TB_Pass.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Oracle Connection Tester"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 169)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_Pass)
        Me.Controls.Add(Me.TB_User)
        Me.Controls.Add(Me.TestConnectionBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TestConnectionBtn As System.Windows.Forms.Button
    Friend WithEvents TB_User As System.Windows.Forms.TextBox
    Friend WithEvents TB_Pass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
