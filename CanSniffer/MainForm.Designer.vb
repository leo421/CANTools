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
        Me.miFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.miNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.miOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.miOpenRecent = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.miSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSaveSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.miClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.miExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFindNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFinePrevious = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripSeparator()
        Me.miDeleteAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.miSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.miNav = New System.Windows.Forms.ToolStripMenuItem()
        Me.miPrevious = New System.Windows.Forms.ToolStripMenuItem()
        Me.miNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFirst = New System.Windows.Forms.ToolStripMenuItem()
        Me.miLast = New System.Windows.Forms.ToolStripMenuItem()
        Me.miGotoPacket = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripSeparator()
        Me.miAutoScrollToLast = New System.Windows.Forms.ToolStripMenuItem()
        Me.miAutoSelectLast = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCapture = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSelectInterface = New System.Windows.Forms.ToolStripMenuItem()
        Me.miOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.miStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.miStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.miRestart = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator()
        Me.miFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSend = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSendPacket = New System.Windows.Forms.ToolStripMenuItem()
        Me.miHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.miAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMain = New System.Windows.Forms.ToolStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TCMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TVDetail = New System.Windows.Forms.TreeView()
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
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFile, Me.miEdit, Me.miNav, Me.miCapture, Me.miSend, Me.miHelp})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(1080, 25)
        Me.MenuStripMain.TabIndex = 0
        Me.MenuStripMain.Text = "MenuStrip1"
        '
        'miFile
        '
        Me.miFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miNew, Me.miOpen, Me.miOpenRecent, Me.ToolStripMenuItem3, Me.miSave, Me.miSaveAs, Me.miSaveSelected, Me.ToolStripSeparator1, Me.miClose, Me.ToolStripMenuItem1, Me.miExit})
        Me.miFile.Name = "miFile"
        Me.miFile.Size = New System.Drawing.Size(44, 21)
        Me.miFile.Text = "文件"
        '
        'miNew
        '
        Me.miNew.Name = "miNew"
        Me.miNew.Size = New System.Drawing.Size(180, 22)
        Me.miNew.Text = "新建"
        '
        'miOpen
        '
        Me.miOpen.Name = "miOpen"
        Me.miOpen.Size = New System.Drawing.Size(180, 22)
        Me.miOpen.Text = "打开"
        '
        'miOpenRecent
        '
        Me.miOpenRecent.Name = "miOpenRecent"
        Me.miOpenRecent.Size = New System.Drawing.Size(180, 22)
        Me.miOpenRecent.Text = "打开最近"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(177, 6)
        '
        'miSave
        '
        Me.miSave.Name = "miSave"
        Me.miSave.Size = New System.Drawing.Size(180, 22)
        Me.miSave.Text = "保存"
        '
        'miSaveAs
        '
        Me.miSaveAs.Name = "miSaveAs"
        Me.miSaveAs.Size = New System.Drawing.Size(180, 22)
        Me.miSaveAs.Text = "另存为"
        '
        'miSaveSelected
        '
        Me.miSaveSelected.Name = "miSaveSelected"
        Me.miSaveSelected.Size = New System.Drawing.Size(180, 22)
        Me.miSaveSelected.Text = "保存选择数据"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'miClose
        '
        Me.miClose.Name = "miClose"
        Me.miClose.Size = New System.Drawing.Size(180, 22)
        Me.miClose.Text = "关闭"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'miExit
        '
        Me.miExit.Name = "miExit"
        Me.miExit.Size = New System.Drawing.Size(180, 22)
        Me.miExit.Text = "退出"
        '
        'miEdit
        '
        Me.miEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miCopy, Me.miFind, Me.miFindNext, Me.miFinePrevious, Me.ToolStripMenuItem19, Me.miDeleteAll, Me.ToolStripMenuItem8, Me.miSetup})
        Me.miEdit.Name = "miEdit"
        Me.miEdit.Size = New System.Drawing.Size(44, 21)
        Me.miEdit.Text = "编辑"
        '
        'miCopy
        '
        Me.miCopy.Name = "miCopy"
        Me.miCopy.Size = New System.Drawing.Size(180, 22)
        Me.miCopy.Text = "复制"
        '
        'miFind
        '
        Me.miFind.Name = "miFind"
        Me.miFind.Size = New System.Drawing.Size(180, 22)
        Me.miFind.Text = "查找"
        '
        'miFindNext
        '
        Me.miFindNext.Name = "miFindNext"
        Me.miFindNext.Size = New System.Drawing.Size(180, 22)
        Me.miFindNext.Text = "查找下一个"
        '
        'miFinePrevious
        '
        Me.miFinePrevious.Name = "miFinePrevious"
        Me.miFinePrevious.Size = New System.Drawing.Size(180, 22)
        Me.miFinePrevious.Text = "查找上一个"
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(177, 6)
        '
        'miDeleteAll
        '
        Me.miDeleteAll.Name = "miDeleteAll"
        Me.miDeleteAll.Size = New System.Drawing.Size(180, 22)
        Me.miDeleteAll.Text = "删除所有数据包"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(177, 6)
        '
        'miSetup
        '
        Me.miSetup.Name = "miSetup"
        Me.miSetup.Size = New System.Drawing.Size(180, 22)
        Me.miSetup.Text = "设置"
        '
        'miNav
        '
        Me.miNav.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miPrevious, Me.miNext, Me.miFirst, Me.miLast, Me.miGotoPacket, Me.ToolStripMenuItem17, Me.miAutoScrollToLast, Me.miAutoSelectLast})
        Me.miNav.Name = "miNav"
        Me.miNav.Size = New System.Drawing.Size(44, 21)
        Me.miNav.Text = "导航"
        '
        'miPrevious
        '
        Me.miPrevious.Name = "miPrevious"
        Me.miPrevious.Size = New System.Drawing.Size(196, 22)
        Me.miPrevious.Text = "上一个"
        '
        'miNext
        '
        Me.miNext.Name = "miNext"
        Me.miNext.Size = New System.Drawing.Size(196, 22)
        Me.miNext.Text = "下一个"
        '
        'miFirst
        '
        Me.miFirst.Name = "miFirst"
        Me.miFirst.Size = New System.Drawing.Size(196, 22)
        Me.miFirst.Text = "第一个"
        '
        'miLast
        '
        Me.miLast.Name = "miLast"
        Me.miLast.Size = New System.Drawing.Size(196, 22)
        Me.miLast.Text = "最后一个"
        '
        'miGotoPacket
        '
        Me.miGotoPacket.Name = "miGotoPacket"
        Me.miGotoPacket.Size = New System.Drawing.Size(196, 22)
        Me.miGotoPacket.Text = "转到指定序号"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(193, 6)
        '
        'miAutoScrollToLast
        '
        Me.miAutoScrollToLast.Name = "miAutoScrollToLast"
        Me.miAutoScrollToLast.Size = New System.Drawing.Size(196, 22)
        Me.miAutoScrollToLast.Text = "自动滚动到最后一个包"
        '
        'miAutoSelectLast
        '
        Me.miAutoSelectLast.Name = "miAutoSelectLast"
        Me.miAutoSelectLast.Size = New System.Drawing.Size(196, 22)
        Me.miAutoSelectLast.Text = "自动选择最后一个包"
        '
        'miCapture
        '
        Me.miCapture.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miSelectInterface, Me.miOptions, Me.ToolStripMenuItem11, Me.miStart, Me.miStop, Me.miRestart, Me.ToolStripMenuItem12, Me.miFilter})
        Me.miCapture.Name = "miCapture"
        Me.miCapture.Size = New System.Drawing.Size(44, 21)
        Me.miCapture.Text = "捕获"
        '
        'miSelectInterface
        '
        Me.miSelectInterface.Name = "miSelectInterface"
        Me.miSelectInterface.Size = New System.Drawing.Size(180, 22)
        Me.miSelectInterface.Text = "选择设备"
        '
        'miOptions
        '
        Me.miOptions.Name = "miOptions"
        Me.miOptions.Size = New System.Drawing.Size(180, 22)
        Me.miOptions.Text = "选项"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(177, 6)
        '
        'miStart
        '
        Me.miStart.Name = "miStart"
        Me.miStart.Size = New System.Drawing.Size(180, 22)
        Me.miStart.Text = "开始"
        '
        'miStop
        '
        Me.miStop.Name = "miStop"
        Me.miStop.Size = New System.Drawing.Size(180, 22)
        Me.miStop.Text = "停止"
        '
        'miRestart
        '
        Me.miRestart.Name = "miRestart"
        Me.miRestart.Size = New System.Drawing.Size(180, 22)
        Me.miRestart.Text = "重新开始"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(177, 6)
        '
        'miFilter
        '
        Me.miFilter.Name = "miFilter"
        Me.miFilter.Size = New System.Drawing.Size(180, 22)
        Me.miFilter.Text = "过滤器"
        '
        'miSend
        '
        Me.miSend.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miSendPacket})
        Me.miSend.Name = "miSend"
        Me.miSend.Size = New System.Drawing.Size(44, 21)
        Me.miSend.Text = "发送"
        '
        'miSendPacket
        '
        Me.miSendPacket.Name = "miSendPacket"
        Me.miSendPacket.Size = New System.Drawing.Size(180, 22)
        Me.miSendPacket.Text = "发送数据包"
        '
        'miHelp
        '
        Me.miHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miAbout})
        Me.miHelp.Name = "miHelp"
        Me.miHelp.Size = New System.Drawing.Size(44, 21)
        Me.miHelp.Text = "帮助"
        '
        'miAbout
        '
        Me.miAbout.Name = "miAbout"
        Me.miAbout.Size = New System.Drawing.Size(180, 22)
        Me.miAbout.Text = "关于"
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
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
    Friend WithEvents miFile As ToolStripMenuItem
    Friend WithEvents miNew As ToolStripMenuItem
    Friend WithEvents miOpen As ToolStripMenuItem
    Friend WithEvents miClose As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents miExit As ToolStripMenuItem
    Friend WithEvents miEdit As ToolStripMenuItem
    Friend WithEvents miFind As ToolStripMenuItem
    Friend WithEvents miCapture As ToolStripMenuItem
    Friend WithEvents miStart As ToolStripMenuItem
    Friend WithEvents miStop As ToolStripMenuItem
    Friend WithEvents miRestart As ToolStripMenuItem
    Friend WithEvents miFilter As ToolStripMenuItem
    Friend WithEvents miHelp As ToolStripMenuItem
    Friend WithEvents miAbout As ToolStripMenuItem
    Friend WithEvents TCMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TVDetail As TreeView
    Friend WithEvents DGV As DataGridView
    Friend WithEvents miOpenRecent As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents miSave As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents miSaveAs As ToolStripMenuItem
    Friend WithEvents miSaveSelected As ToolStripMenuItem
    Friend WithEvents miCopy As ToolStripMenuItem
    Friend WithEvents miFindNext As ToolStripMenuItem
    Friend WithEvents miFinePrevious As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Friend WithEvents miSetup As ToolStripMenuItem
    Friend WithEvents miSelectInterface As ToolStripMenuItem
    Friend WithEvents miNav As ToolStripMenuItem
    Friend WithEvents miPrevious As ToolStripMenuItem
    Friend WithEvents miNext As ToolStripMenuItem
    Friend WithEvents miFirst As ToolStripMenuItem
    Friend WithEvents miLast As ToolStripMenuItem
    Friend WithEvents miGotoPacket As ToolStripMenuItem
    Friend WithEvents miOptions As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem12 As ToolStripSeparator
    Friend WithEvents miSend As ToolStripMenuItem
    Friend WithEvents miSendPacket As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem19 As ToolStripSeparator
    Friend WithEvents miDeleteAll As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As ToolStripSeparator
    Friend WithEvents miAutoScrollToLast As ToolStripMenuItem
    Friend WithEvents miAutoSelectLast As ToolStripMenuItem
End Class
