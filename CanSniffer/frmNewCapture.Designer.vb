<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCapture
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbAll = New System.Windows.Forms.CheckBox()
        Me.cbBps = New System.Windows.Forms.ComboBox()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btOK = New System.Windows.Forms.Button()
        Me.cbCan1 = New System.Windows.Forms.CheckBox()
        Me.cbCan0 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCOM = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbAll)
        Me.GroupBox1.Controls.Add(Me.cbBps)
        Me.GroupBox1.Controls.Add(Me.btCancel)
        Me.GroupBox1.Controls.Add(Me.btOK)
        Me.GroupBox1.Controls.Add(Me.cbCan1)
        Me.GroupBox1.Controls.Add(Me.cbCan0)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbCOM)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 190)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "参数设置"
        '
        'cbAll
        '
        Me.cbAll.AutoSize = True
        Me.cbAll.Location = New System.Drawing.Point(376, 33)
        Me.cbAll.Name = "cbAll"
        Me.cbAll.Size = New System.Drawing.Size(72, 16)
        Me.cbAll.TabIndex = 12
        Me.cbAll.Text = "所有设备"
        Me.cbAll.UseVisualStyleBackColor = True
        '
        'cbBps
        '
        Me.cbBps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBps.FormattingEnabled = True
        Me.cbBps.Items.AddRange(New Object() {"500", "1000"})
        Me.cbBps.Location = New System.Drawing.Point(121, 108)
        Me.cbBps.Name = "cbBps"
        Me.cbBps.Size = New System.Drawing.Size(100, 20)
        Me.cbBps.TabIndex = 11
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(373, 149)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 10
        Me.btCancel.Text = "取  消"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btOK
        '
        Me.btOK.Location = New System.Drawing.Point(281, 149)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(75, 23)
        Me.btOK.TabIndex = 9
        Me.btOK.Text = "确  定"
        Me.btOK.UseVisualStyleBackColor = True
        '
        'cbCan1
        '
        Me.cbCan1.AutoSize = True
        Me.cbCan1.Location = New System.Drawing.Point(196, 74)
        Me.cbCan1.Name = "cbCan1"
        Me.cbCan1.Size = New System.Drawing.Size(48, 16)
        Me.cbCan1.TabIndex = 8
        Me.cbCan1.Text = "Can1"
        Me.cbCan1.UseVisualStyleBackColor = True
        '
        'cbCan0
        '
        Me.cbCan0.AutoSize = True
        Me.cbCan0.Checked = True
        Me.cbCan0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCan0.Location = New System.Drawing.Point(121, 74)
        Me.cbCan0.Name = "cbCan0"
        Me.cbCan0.Size = New System.Drawing.Size(48, 16)
        Me.cbCan0.TabIndex = 7
        Me.cbCan0.Text = "Can0"
        Me.cbCan0.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "kbits/s"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "速率："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CAN接口："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "设备通信接口："
        '
        'cbCOM
        '
        Me.cbCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCOM.FormattingEnabled = True
        Me.cbCOM.Location = New System.Drawing.Point(121, 31)
        Me.cbCOM.Name = "cbCOM"
        Me.cbCOM.Size = New System.Drawing.Size(239, 20)
        Me.cbCOM.TabIndex = 0
        '
        'frmNewCapture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 214)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewCapture"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "新建捕获"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btCancel As Button
    Friend WithEvents btOK As Button
    Friend WithEvents cbCan1 As CheckBox
    Friend WithEvents cbCan0 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCOM As ComboBox
    Friend WithEvents cbBps As ComboBox
    Friend WithEvents cbAll As CheckBox
End Class
