Imports CanSniffer

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AmpsSendPacketControl
    Inherits SendPacketControl

    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAddrClass = New System.Windows.Forms.ComboBox()
        Me.cbAddr = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbReadReq = New System.Windows.Forms.RadioButton()
        Me.rbWriteReq = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tDesc = New System.Windows.Forms.TextBox()
        Me.lblProperty = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tData = New System.Windows.Forms.TextBox()
        Me.cbHex = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudNodeID = New System.Windows.Forms.NumericUpDown()
        Me.rbWriteRsp = New System.Windows.Forms.RadioButton()
        Me.rbReadRsp = New System.Windows.Forms.RadioButton()
        CType(Me.nudNodeID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CAN对象："
        '
        'cbAddrClass
        '
        Me.cbAddrClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAddrClass.FormattingEnabled = True
        Me.cbAddrClass.Location = New System.Drawing.Point(96, 62)
        Me.cbAddrClass.Name = "cbAddrClass"
        Me.cbAddrClass.Size = New System.Drawing.Size(121, 20)
        Me.cbAddrClass.TabIndex = 8
        '
        'cbAddr
        '
        Me.cbAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAddr.FormattingEnabled = True
        Me.cbAddr.Location = New System.Drawing.Point(223, 62)
        Me.cbAddr.Name = "cbAddr"
        Me.cbAddr.Size = New System.Drawing.Size(228, 20)
        Me.cbAddr.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "操作："
        '
        'rbReadReq
        '
        Me.rbReadReq.AutoSize = True
        Me.rbReadReq.Checked = True
        Me.rbReadReq.Location = New System.Drawing.Point(96, 37)
        Me.rbReadReq.Name = "rbReadReq"
        Me.rbReadReq.Size = New System.Drawing.Size(71, 16)
        Me.rbReadReq.TabIndex = 3
        Me.rbReadReq.TabStop = True
        Me.rbReadReq.Text = "读取请求"
        Me.rbReadReq.UseVisualStyleBackColor = True
        '
        'rbWriteReq
        '
        Me.rbWriteReq.AutoSize = True
        Me.rbWriteReq.Location = New System.Drawing.Point(170, 37)
        Me.rbWriteReq.Name = "rbWriteReq"
        Me.rbWriteReq.Size = New System.Drawing.Size(71, 16)
        Me.rbWriteReq.TabIndex = 4
        Me.rbWriteReq.Text = "写入请求"
        Me.rbWriteReq.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "说明："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "对象属性："
        '
        'tDesc
        '
        Me.tDesc.Location = New System.Drawing.Point(96, 91)
        Me.tDesc.Multiline = True
        Me.tDesc.Name = "tDesc"
        Me.tDesc.ReadOnly = True
        Me.tDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tDesc.Size = New System.Drawing.Size(355, 89)
        Me.tDesc.TabIndex = 11
        Me.tDesc.Text = "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "8" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblProperty
        '
        Me.lblProperty.AutoSize = True
        Me.lblProperty.Location = New System.Drawing.Point(96, 187)
        Me.lblProperty.Name = "lblProperty"
        Me.lblProperty.Size = New System.Drawing.Size(0, 12)
        Me.lblProperty.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "单位："
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(94, 213)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(0, 12)
        Me.lblUnit.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "数据："
        '
        'tData
        '
        Me.tData.Location = New System.Drawing.Point(96, 237)
        Me.tData.Name = "tData"
        Me.tData.Size = New System.Drawing.Size(121, 21)
        Me.tData.TabIndex = 17
        '
        'cbHex
        '
        Me.cbHex.AutoCheck = False
        Me.cbHex.AutoSize = True
        Me.cbHex.Location = New System.Drawing.Point(223, 239)
        Me.cbHex.Name = "cbHex"
        Me.cbHex.Size = New System.Drawing.Size(72, 16)
        Me.cbHex.TabIndex = 18
        Me.cbHex.Text = "十六进制"
        Me.cbHex.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "目标站号："
        '
        'nudNodeID
        '
        Me.nudNodeID.Location = New System.Drawing.Point(96, 8)
        Me.nudNodeID.Maximum = New Decimal(New Integer() {127, 0, 0, 0})
        Me.nudNodeID.Name = "nudNodeID"
        Me.nudNodeID.Size = New System.Drawing.Size(81, 21)
        Me.nudNodeID.TabIndex = 1
        Me.nudNodeID.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rbWriteRsp
        '
        Me.rbWriteRsp.AutoSize = True
        Me.rbWriteRsp.Location = New System.Drawing.Point(321, 37)
        Me.rbWriteRsp.Name = "rbWriteRsp"
        Me.rbWriteRsp.Size = New System.Drawing.Size(71, 16)
        Me.rbWriteRsp.TabIndex = 6
        Me.rbWriteRsp.Text = "写入响应"
        Me.rbWriteRsp.UseVisualStyleBackColor = True
        '
        'rbReadRsp
        '
        Me.rbReadRsp.AutoSize = True
        Me.rbReadRsp.Location = New System.Drawing.Point(247, 37)
        Me.rbReadRsp.Name = "rbReadRsp"
        Me.rbReadRsp.Size = New System.Drawing.Size(71, 16)
        Me.rbReadRsp.TabIndex = 5
        Me.rbReadRsp.Text = "读取响应"
        Me.rbReadRsp.UseVisualStyleBackColor = True
        '
        'AmpsSendPacketControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rbWriteRsp)
        Me.Controls.Add(Me.rbReadRsp)
        Me.Controls.Add(Me.nudNodeID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbHex)
        Me.Controls.Add(Me.tData)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblProperty)
        Me.Controls.Add(Me.tDesc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbWriteReq)
        Me.Controls.Add(Me.rbReadReq)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbAddr)
        Me.Controls.Add(Me.cbAddrClass)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AmpsSendPacketControl"
        Me.Size = New System.Drawing.Size(496, 268)
        CType(Me.nudNodeID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents cbAddrClass As Windows.Forms.ComboBox
    Friend WithEvents cbAddr As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents rbReadReq As Windows.Forms.RadioButton
    Friend WithEvents rbWriteReq As Windows.Forms.RadioButton
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents tDesc As Windows.Forms.TextBox
    Friend WithEvents lblProperty As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents lblUnit As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents tData As Windows.Forms.TextBox
    Friend WithEvents cbHex As Windows.Forms.CheckBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents nudNodeID As Windows.Forms.NumericUpDown
    Friend WithEvents rbWriteRsp As Windows.Forms.RadioButton
    Friend WithEvents rbReadRsp As Windows.Forms.RadioButton
End Class
