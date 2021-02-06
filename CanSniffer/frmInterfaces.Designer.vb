<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInterfaces
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
        Me.cbCOM = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cbCOM
        '
        Me.cbCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCOM.FormattingEnabled = True
        Me.cbCOM.Location = New System.Drawing.Point(122, 80)
        Me.cbCOM.Name = "cbCOM"
        Me.cbCOM.Size = New System.Drawing.Size(401, 20)
        Me.cbCOM.TabIndex = 0
        '
        'frmInterfaces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbCOM)
        Me.Name = "frmInterfaces"
        Me.Text = "选择设备"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbCOM As ComboBox
End Class
