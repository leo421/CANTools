<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendPacket
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
        Me.pnlProto = New System.Windows.Forms.Panel()
        Me.btSend = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbAll = New System.Windows.Forms.CheckBox()
        Me.cbCOM = New System.Windows.Forms.ComboBox()
        Me.tData = New System.Windows.Forms.TextBox()
        Me.cbProtocol = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbCAN0 = New System.Windows.Forms.RadioButton()
        Me.rbCAN1 = New System.Windows.Forms.RadioButton()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pnlProto
        '
        Me.pnlProto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlProto.BackColor = System.Drawing.Color.White
        Me.pnlProto.Location = New System.Drawing.Point(12, 327)
        Me.pnlProto.Name = "pnlProto"
        Me.pnlProto.Size = New System.Drawing.Size(496, 286)
        Me.pnlProto.TabIndex = 0
        '
        'btSend
        '
        Me.btSend.Location = New System.Drawing.Point(12, 12)
        Me.btSend.Name = "btSend"
        Me.btSend.Size = New System.Drawing.Size(75, 23)
        Me.btSend.TabIndex = 1
        Me.btSend.Text = "发  送"
        Me.btSend.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "通道："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "协议："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "数据："
        '
        'cbAll
        '
        Me.cbAll.AutoSize = True
        Me.cbAll.Location = New System.Drawing.Point(436, 49)
        Me.cbAll.Name = "cbAll"
        Me.cbAll.Size = New System.Drawing.Size(72, 16)
        Me.cbAll.TabIndex = 14
        Me.cbAll.Text = "所有设备"
        Me.cbAll.UseVisualStyleBackColor = True
        '
        'cbCOM
        '
        Me.cbCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCOM.FormattingEnabled = True
        Me.cbCOM.Location = New System.Drawing.Point(79, 46)
        Me.cbCOM.Name = "cbCOM"
        Me.cbCOM.Size = New System.Drawing.Size(351, 20)
        Me.cbCOM.TabIndex = 13
        '
        'tData
        '
        Me.tData.Location = New System.Drawing.Point(79, 104)
        Me.tData.Multiline = True
        Me.tData.Name = "tData"
        Me.tData.Size = New System.Drawing.Size(429, 191)
        Me.tData.TabIndex = 15
        '
        'cbProtocol
        '
        Me.cbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProtocol.FormattingEnabled = True
        Me.cbProtocol.Location = New System.Drawing.Point(79, 301)
        Me.cbProtocol.Name = "cbProtocol"
        Me.cbProtocol.Size = New System.Drawing.Size(429, 20)
        Me.cbProtocol.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 12)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "CAN接口："
        '
        'rbCAN0
        '
        Me.rbCAN0.AutoSize = True
        Me.rbCAN0.Checked = True
        Me.rbCAN0.Location = New System.Drawing.Point(79, 76)
        Me.rbCAN0.Name = "rbCAN0"
        Me.rbCAN0.Size = New System.Drawing.Size(47, 16)
        Me.rbCAN0.TabIndex = 18
        Me.rbCAN0.TabStop = True
        Me.rbCAN0.Text = "CAN0"
        Me.rbCAN0.UseVisualStyleBackColor = True
        '
        'rbCAN1
        '
        Me.rbCAN1.AutoSize = True
        Me.rbCAN1.Location = New System.Drawing.Point(138, 76)
        Me.rbCAN1.Name = "rbCAN1"
        Me.rbCAN1.Size = New System.Drawing.Size(47, 16)
        Me.rbCAN1.TabIndex = 19
        Me.rbCAN1.Text = "CAN1"
        Me.rbCAN1.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(102, 17)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(0, 12)
        Me.lblMsg.TabIndex = 20
        '
        'frmSendPacket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 625)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.rbCAN1)
        Me.Controls.Add(Me.rbCAN0)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbProtocol)
        Me.Controls.Add(Me.tData)
        Me.Controls.Add(Me.cbAll)
        Me.Controls.Add(Me.cbCOM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btSend)
        Me.Controls.Add(Me.pnlProto)
        Me.Name = "frmSendPacket"
        Me.Text = "发送数据包"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlProto As Panel
    Friend WithEvents btSend As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbAll As CheckBox
    Friend WithEvents cbCOM As ComboBox
    Friend WithEvents tData As TextBox
    Friend WithEvents cbProtocol As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rbCAN0 As RadioButton
    Friend WithEvents rbCAN1 As RadioButton
    Friend WithEvents lblMsg As Label
End Class
