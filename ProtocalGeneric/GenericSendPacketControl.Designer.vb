Imports CanSniffer

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenericSendPacketControl
    Inherits SendPacketControl


    'UserControl 重写释放以清理组件列表。
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
        Me.tStdID = New System.Windows.Forms.TextBox()
        Me.tExtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbStd = New System.Windows.Forms.RadioButton()
        Me.rbExt = New System.Windows.Forms.RadioButton()
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.rbRemote = New System.Windows.Forms.RadioButton()
        Me.rbError = New System.Windows.Forms.RadioButton()
        Me.rbOverload = New System.Windows.Forms.RadioButton()
        Me.rbSpace = New System.Windows.Forms.RadioButton()
        Me.tPayload = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tStdID
        '
        Me.tStdID.Location = New System.Drawing.Point(88, 99)
        Me.tStdID.Name = "tStdID"
        Me.tStdID.Size = New System.Drawing.Size(272, 21)
        Me.tStdID.TabIndex = 3
        '
        'tExtID
        '
        Me.tExtID.Location = New System.Drawing.Point(88, 139)
        Me.tExtID.Name = "tExtID"
        Me.tExtID.Size = New System.Drawing.Size(272, 21)
        Me.tExtID.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "帧类型："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ExtID："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "StdID："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "数据内容："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "数据长度："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "帧格式："
        '
        'rbStd
        '
        Me.rbStd.AutoSize = True
        Me.rbStd.Checked = True
        Me.rbStd.Location = New System.Drawing.Point(0, 0)
        Me.rbStd.Name = "rbStd"
        Me.rbStd.Size = New System.Drawing.Size(59, 16)
        Me.rbStd.TabIndex = 9
        Me.rbStd.TabStop = True
        Me.rbStd.Text = "标准帧"
        Me.rbStd.UseVisualStyleBackColor = True
        '
        'rbExt
        '
        Me.rbExt.AutoSize = True
        Me.rbExt.Location = New System.Drawing.Point(71, 0)
        Me.rbExt.Name = "rbExt"
        Me.rbExt.Size = New System.Drawing.Size(59, 16)
        Me.rbExt.TabIndex = 10
        Me.rbExt.Text = "扩展帧"
        Me.rbExt.UseVisualStyleBackColor = True
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Checked = True
        Me.rbData.Location = New System.Drawing.Point(0, 0)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(59, 16)
        Me.rbData.TabIndex = 11
        Me.rbData.TabStop = True
        Me.rbData.Text = "数据帧"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'rbRemote
        '
        Me.rbRemote.AutoSize = True
        Me.rbRemote.Location = New System.Drawing.Point(71, 0)
        Me.rbRemote.Name = "rbRemote"
        Me.rbRemote.Size = New System.Drawing.Size(59, 16)
        Me.rbRemote.TabIndex = 12
        Me.rbRemote.Text = "远程帧"
        Me.rbRemote.UseVisualStyleBackColor = True
        '
        'rbError
        '
        Me.rbError.AutoSize = True
        Me.rbError.Location = New System.Drawing.Point(142, 0)
        Me.rbError.Name = "rbError"
        Me.rbError.Size = New System.Drawing.Size(59, 16)
        Me.rbError.TabIndex = 13
        Me.rbError.Text = "错误帧"
        Me.rbError.UseVisualStyleBackColor = True
        '
        'rbOverload
        '
        Me.rbOverload.AutoSize = True
        Me.rbOverload.Location = New System.Drawing.Point(213, 0)
        Me.rbOverload.Name = "rbOverload"
        Me.rbOverload.Size = New System.Drawing.Size(59, 16)
        Me.rbOverload.TabIndex = 14
        Me.rbOverload.Text = "过载帧"
        Me.rbOverload.UseVisualStyleBackColor = True
        '
        'rbSpace
        '
        Me.rbSpace.AutoSize = True
        Me.rbSpace.Location = New System.Drawing.Point(284, 0)
        Me.rbSpace.Name = "rbSpace"
        Me.rbSpace.Size = New System.Drawing.Size(59, 16)
        Me.rbSpace.TabIndex = 15
        Me.rbSpace.Text = "帧间隔"
        Me.rbSpace.UseVisualStyleBackColor = True
        '
        'tPayload
        '
        Me.tPayload.Location = New System.Drawing.Point(88, 219)
        Me.tPayload.Name = "tPayload"
        Me.tPayload.Size = New System.Drawing.Size(343, 21)
        Me.tPayload.TabIndex = 6
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(88, 180)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(47, 21)
        Me.NumericUpDown1.TabIndex = 5
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown1.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbOverload)
        Me.Panel1.Controls.Add(Me.rbData)
        Me.Panel1.Controls.Add(Me.rbRemote)
        Me.Panel1.Controls.Add(Me.rbSpace)
        Me.Panel1.Controls.Add(Me.rbError)
        Me.Panel1.Location = New System.Drawing.Point(88, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 20)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbExt)
        Me.Panel2.Controls.Add(Me.rbStd)
        Me.Panel2.Location = New System.Drawing.Point(88, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(343, 20)
        Me.Panel2.TabIndex = 2
        '
        'GenericSendPacketControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.tPayload)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tExtID)
        Me.Controls.Add(Me.tStdID)
        Me.Name = "GenericSendPacketControl"
        Me.Size = New System.Drawing.Size(461, 268)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tStdID As Windows.Forms.TextBox
    Friend WithEvents tExtID As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents rbStd As Windows.Forms.RadioButton
    Friend WithEvents rbExt As Windows.Forms.RadioButton
    Friend WithEvents rbData As Windows.Forms.RadioButton
    Friend WithEvents rbRemote As Windows.Forms.RadioButton
    Friend WithEvents rbError As Windows.Forms.RadioButton
    Friend WithEvents rbOverload As Windows.Forms.RadioButton
    Friend WithEvents rbSpace As Windows.Forms.RadioButton
    Friend WithEvents tPayload As Windows.Forms.TextBox
    Friend WithEvents NumericUpDown1 As Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
End Class
