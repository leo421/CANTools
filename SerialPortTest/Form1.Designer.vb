<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btTest = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btTest
        '
        Me.btTest.Location = New System.Drawing.Point(12, 12)
        Me.btTest.Name = "btTest"
        Me.btTest.Size = New System.Drawing.Size(75, 23)
        Me.btTest.TabIndex = 0
        Me.btTest.Text = "Test"
        Me.btTest.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(106, 17)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(41, 12)
        Me.lblCount.TabIndex = 1
        Me.lblCount.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btTest)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btTest As Button
    Friend WithEvents lblCount As Label
End Class
