<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.关闭ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查找ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.捕获ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.开始ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.停止ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重新开始ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.过滤器ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMain = New System.Windows.Forms.ToolStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TCMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TVDetail = New System.Windows.Forms.TreeView()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.查找下一个ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查找上一个ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.上一个包ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.下一个ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.转到指定序号ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.发送数据包ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripMain.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TCMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件ToolStripMenuItem, Me.编辑ToolStripMenuItem, Me.ToolStripMenuItem13, Me.捕获ToolStripMenuItem, Me.ToolStripMenuItem16, Me.帮助ToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(1080, 25)
        Me.MenuStripMain.TabIndex = 0
        Me.MenuStripMain.Text = "MenuStrip1"
        '
        '文件ToolStripMenuItem
        '
        Me.文件ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开ToolStripMenuItem, Me.打开ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripSeparator1, Me.关闭ToolStripMenuItem, Me.ToolStripMenuItem1, Me.退出ToolStripMenuItem})
        Me.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem"
        Me.文件ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.文件ToolStripMenuItem.Text = "文件"
        '
        '打开ToolStripMenuItem
        '
        Me.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem"
        Me.打开ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.打开ToolStripMenuItem.Text = "新建"
        '
        '打开ToolStripMenuItem1
        '
        Me.打开ToolStripMenuItem1.Name = "打开ToolStripMenuItem1"
        Me.打开ToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.打开ToolStripMenuItem1.Text = "打开"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem2.Text = "打开最近"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem4.Text = "保存"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        '关闭ToolStripMenuItem
        '
        Me.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem"
        Me.关闭ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.关闭ToolStripMenuItem.Text = "关闭"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '编辑ToolStripMenuItem
        '
        Me.编辑ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.查找ToolStripMenuItem, Me.查找下一个ToolStripMenuItem, Me.查找上一个ToolStripMenuItem, Me.ToolStripMenuItem8, Me.设置ToolStripMenuItem})
        Me.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem"
        Me.编辑ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.编辑ToolStripMenuItem.Text = "编辑"
        '
        '查找ToolStripMenuItem
        '
        Me.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem"
        Me.查找ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.查找ToolStripMenuItem.Text = "查找"
        '
        '捕获ToolStripMenuItem
        '
        Me.捕获ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.开始ToolStripMenuItem, Me.停止ToolStripMenuItem, Me.重新开始ToolStripMenuItem, Me.ToolStripMenuItem12, Me.过滤器ToolStripMenuItem})
        Me.捕获ToolStripMenuItem.Name = "捕获ToolStripMenuItem"
        Me.捕获ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.捕获ToolStripMenuItem.Text = "捕获"
        '
        '开始ToolStripMenuItem
        '
        Me.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem"
        Me.开始ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.开始ToolStripMenuItem.Text = "开始"
        '
        '停止ToolStripMenuItem
        '
        Me.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem"
        Me.停止ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.停止ToolStripMenuItem.Text = "停止"
        '
        '重新开始ToolStripMenuItem
        '
        Me.重新开始ToolStripMenuItem.Name = "重新开始ToolStripMenuItem"
        Me.重新开始ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.重新开始ToolStripMenuItem.Text = "重新开始"
        '
        '过滤器ToolStripMenuItem
        '
        Me.过滤器ToolStripMenuItem.Name = "过滤器ToolStripMenuItem"
        Me.过滤器ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.过滤器ToolStripMenuItem.Text = "过滤器"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关于ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'ToolStripMain
        '
        Me.ToolStripMain.Location = New System.Drawing.Point(0, 25)
        Me.ToolStripMain.Name = "ToolStripMain"
        Me.ToolStripMain.Size = New System.Drawing.Size(1080, 25)
        Me.ToolStripMain.TabIndex = 1
        Me.ToolStripMain.Text = "ToolStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 50)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TCMain)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TVDetail)
        Me.SplitContainer1.Size = New System.Drawing.Size(1080, 551)
        Me.SplitContainer1.SplitterDistance = 742
        Me.SplitContainer1.TabIndex = 2
        '
        'TCMain
        '
        Me.TCMain.Controls.Add(Me.TabPage1)
        Me.TCMain.Controls.Add(Me.TabPage2)
        Me.TCMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCMain.Location = New System.Drawing.Point(0, 0)
        Me.TCMain.Name = "TCMain"
        Me.TCMain.SelectedIndex = 0
        Me.TCMain.Size = New System.Drawing.Size(742, 551)
        Me.TCMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGV)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(734, 525)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(3, 3)
        Me.DGV.Name = "DGV"
        Me.DGV.RowTemplate.Height = 23
        Me.DGV.Size = New System.Drawing.Size(728, 519)
        Me.DGV.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(734, 525)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TVDetail
        '
        Me.TVDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVDetail.Location = New System.Drawing.Point(0, 0)
        Me.TVDetail.Name = "TVDetail"
        Me.TVDetail.Size = New System.Drawing.Size(334, 551)
        Me.TVDetail.TabIndex = 0
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(177, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem5.Text = "另存为"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem6.Text = "保存选择数据"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem7.Text = "复制"
        '
        '查找下一个ToolStripMenuItem
        '
        Me.查找下一个ToolStripMenuItem.Name = "查找下一个ToolStripMenuItem"
        Me.查找下一个ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.查找下一个ToolStripMenuItem.Text = "查找下一个"
        '
        '查找上一个ToolStripMenuItem
        '
        Me.查找上一个ToolStripMenuItem.Name = "查找上一个ToolStripMenuItem"
        Me.查找上一个ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.查找上一个ToolStripMenuItem.Text = "查找上一个"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(177, 6)
        '
        '设置ToolStripMenuItem
        '
        Me.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem"
        Me.设置ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.设置ToolStripMenuItem.Text = "设置"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem9.Text = "选择设备"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem10.Text = "选项"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(177, 6)
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(177, 6)
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.上一个包ToolStripMenuItem, Me.下一个ToolStripMenuItem, Me.ToolStripMenuItem14, Me.ToolStripMenuItem15, Me.转到指定序号ToolStripMenuItem})
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(44, 21)
        Me.ToolStripMenuItem13.Text = "导航"
        '
        '上一个包ToolStripMenuItem
        '
        Me.上一个包ToolStripMenuItem.Name = "上一个包ToolStripMenuItem"
        Me.上一个包ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.上一个包ToolStripMenuItem.Text = "上一个"
        '
        '下一个ToolStripMenuItem
        '
        Me.下一个ToolStripMenuItem.Name = "下一个ToolStripMenuItem"
        Me.下一个ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.下一个ToolStripMenuItem.Text = "下一个"
        '
        '转到指定序号ToolStripMenuItem
        '
        Me.转到指定序号ToolStripMenuItem.Name = "转到指定序号ToolStripMenuItem"
        Me.转到指定序号ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.转到指定序号ToolStripMenuItem.Text = "转到指定序号"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem14.Text = "第一个"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem15.Text = "最后一个"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.发送数据包ToolStripMenuItem})
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(44, 21)
        Me.ToolStripMenuItem16.Text = "发送"
        '
        '发送数据包ToolStripMenuItem
        '
        Me.发送数据包ToolStripMenuItem.Name = "发送数据包ToolStripMenuItem"
        Me.发送数据包ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.发送数据包ToolStripMenuItem.Text = "发送数据包"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 601)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStripMain)
        Me.Controls.Add(Me.MenuStripMain)
        Me.MainMenuStrip = Me.MenuStripMain
        Me.Name = "MainForm"
        Me.Text = "CAN Sniffer"
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TCMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripMain As MenuStrip
    Friend WithEvents ToolStripMain As ToolStrip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents 文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 关闭ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 编辑ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 查找ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 捕获ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 开始ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 停止ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 重新开始ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 过滤器ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TCMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TVDetail As TreeView
    Friend WithEvents DGV As DataGridView
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents 查找下一个ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 查找上一个ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Friend WithEvents 设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As ToolStripMenuItem
    Friend WithEvents 上一个包ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 下一个ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As ToolStripMenuItem
    Friend WithEvents 转到指定序号ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem12 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem16 As ToolStripMenuItem
    Friend WithEvents 发送数据包ToolStripMenuItem As ToolStripMenuItem
End Class
