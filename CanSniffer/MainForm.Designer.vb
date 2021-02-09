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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
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
        Me.miJump = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.tsbNew = New System.Windows.Forms.ToolStripButton()
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbDeleteAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbPrevious = New System.Windows.Forms.ToolStripButton()
        Me.tsbNext = New System.Windows.Forms.ToolStripButton()
        Me.tsbFirst = New System.Windows.Forms.ToolStripButton()
        Me.tsbLast = New System.Windows.Forms.ToolStripButton()
        Me.tsbJump = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAutoScrollToLast = New System.Windows.Forms.ToolStripButton()
        Me.tsbAutoSelectLast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbStartCapture = New System.Windows.Forms.ToolStripButton()
        Me.tsbStopCapture = New System.Windows.Forms.ToolStripButton()
        Me.tsbRestartCapture = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSendPacket = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TCMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TCIMGLIST = New System.Windows.Forms.ImageList(Me.components)
        Me.tDetail = New System.Windows.Forms.RichTextBox()
        Me.SP = New System.IO.Ports.SerialPort(Me.components)
        Me.tmUpdateData = New System.Windows.Forms.Timer(Me.components)
        Me.cbProtocol = New System.Windows.Forms.ComboBox()
        Me.MenuStripMain.SuspendLayout()
        Me.ToolStripMain.SuspendLayout()
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
        Me.miNav.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miPrevious, Me.miNext, Me.miFirst, Me.miLast, Me.miJump, Me.ToolStripMenuItem17, Me.miAutoScrollToLast, Me.miAutoSelectLast})
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
        'miJump
        '
        Me.miJump.Name = "miJump"
        Me.miJump.Size = New System.Drawing.Size(196, 22)
        Me.miJump.Text = "转到指定序号"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(193, 6)
        '
        'miAutoScrollToLast
        '
        Me.miAutoScrollToLast.CheckOnClick = True
        Me.miAutoScrollToLast.Name = "miAutoScrollToLast"
        Me.miAutoScrollToLast.Size = New System.Drawing.Size(196, 22)
        Me.miAutoScrollToLast.Text = "自动滚动到最后一个包"
        '
        'miAutoSelectLast
        '
        Me.miAutoSelectLast.CheckOnClick = True
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
        Me.miAbout.Size = New System.Drawing.Size(100, 22)
        Me.miAbout.Text = "关于"
        '
        'ToolStripMain
        '
        Me.ToolStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNew, Me.tsbOpen, Me.tsbSave, Me.tsbClose, Me.ToolStripSeparator2, Me.tsbDeleteAll, Me.ToolStripSeparator3, Me.tsbPrevious, Me.tsbNext, Me.tsbFirst, Me.tsbLast, Me.tsbJump, Me.ToolStripSeparator4, Me.tsbAutoScrollToLast, Me.tsbAutoSelectLast, Me.ToolStripSeparator5, Me.tsbStartCapture, Me.tsbStopCapture, Me.tsbRestartCapture, Me.ToolStripSeparator6, Me.tsbSendPacket})
        Me.ToolStripMain.Location = New System.Drawing.Point(0, 25)
        Me.ToolStripMain.Name = "ToolStripMain"
        Me.ToolStripMain.Size = New System.Drawing.Size(1080, 25)
        Me.ToolStripMain.TabIndex = 1
        Me.ToolStripMain.Text = "ToolStrip1"
        '
        'tsbNew
        '
        Me.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNew.Image = CType(resources.GetObject("tsbNew.Image"), System.Drawing.Image)
        Me.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNew.Name = "tsbNew"
        Me.tsbNew.Size = New System.Drawing.Size(23, 22)
        Me.tsbNew.Text = "ToolStripButton1"
        Me.tsbNew.ToolTipText = "新建"
        '
        'tsbOpen
        '
        Me.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbOpen.Image = CType(resources.GetObject("tsbOpen.Image"), System.Drawing.Image)
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(23, 22)
        Me.tsbOpen.Text = "ToolStripButton1"
        Me.tsbOpen.ToolTipText = "打开"
        '
        'tsbSave
        '
        Me.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSave.Image = CType(resources.GetObject("tsbSave.Image"), System.Drawing.Image)
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(23, 22)
        Me.tsbSave.Text = "ToolStripButton1"
        Me.tsbSave.ToolTipText = "保存"
        '
        'tsbClose
        '
        Me.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbClose.Image = CType(resources.GetObject("tsbClose.Image"), System.Drawing.Image)
        Me.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClose.Name = "tsbClose"
        Me.tsbClose.Size = New System.Drawing.Size(23, 22)
        Me.tsbClose.Text = "ToolStripButton1"
        Me.tsbClose.ToolTipText = "关闭"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbDeleteAll
        '
        Me.tsbDeleteAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDeleteAll.Image = CType(resources.GetObject("tsbDeleteAll.Image"), System.Drawing.Image)
        Me.tsbDeleteAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDeleteAll.Name = "tsbDeleteAll"
        Me.tsbDeleteAll.Size = New System.Drawing.Size(23, 22)
        Me.tsbDeleteAll.Text = "ToolStripButton1"
        Me.tsbDeleteAll.ToolTipText = "删除所有数据包"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbPrevious
        '
        Me.tsbPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPrevious.Image = CType(resources.GetObject("tsbPrevious.Image"), System.Drawing.Image)
        Me.tsbPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPrevious.Name = "tsbPrevious"
        Me.tsbPrevious.Size = New System.Drawing.Size(23, 22)
        Me.tsbPrevious.Text = "ToolStripButton1"
        Me.tsbPrevious.ToolTipText = "上一个"
        '
        'tsbNext
        '
        Me.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNext.Image = CType(resources.GetObject("tsbNext.Image"), System.Drawing.Image)
        Me.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNext.Name = "tsbNext"
        Me.tsbNext.Size = New System.Drawing.Size(23, 22)
        Me.tsbNext.Text = "ToolStripButton2"
        Me.tsbNext.ToolTipText = "下一个"
        '
        'tsbFirst
        '
        Me.tsbFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFirst.Image = CType(resources.GetObject("tsbFirst.Image"), System.Drawing.Image)
        Me.tsbFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFirst.Name = "tsbFirst"
        Me.tsbFirst.Size = New System.Drawing.Size(23, 22)
        Me.tsbFirst.Text = "ToolStripButton3"
        Me.tsbFirst.ToolTipText = "转到指定序号"
        '
        'tsbLast
        '
        Me.tsbLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLast.Image = CType(resources.GetObject("tsbLast.Image"), System.Drawing.Image)
        Me.tsbLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLast.Name = "tsbLast"
        Me.tsbLast.Size = New System.Drawing.Size(23, 22)
        Me.tsbLast.Text = "ToolStripButton4"
        Me.tsbLast.ToolTipText = "第一个"
        '
        'tsbJump
        '
        Me.tsbJump.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbJump.Image = CType(resources.GetObject("tsbJump.Image"), System.Drawing.Image)
        Me.tsbJump.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbJump.Name = "tsbJump"
        Me.tsbJump.Size = New System.Drawing.Size(23, 22)
        Me.tsbJump.Text = "ToolStripButton5"
        Me.tsbJump.ToolTipText = "最后一个"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAutoScrollToLast
        '
        Me.tsbAutoScrollToLast.CheckOnClick = True
        Me.tsbAutoScrollToLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAutoScrollToLast.Image = CType(resources.GetObject("tsbAutoScrollToLast.Image"), System.Drawing.Image)
        Me.tsbAutoScrollToLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAutoScrollToLast.Name = "tsbAutoScrollToLast"
        Me.tsbAutoScrollToLast.Size = New System.Drawing.Size(23, 22)
        Me.tsbAutoScrollToLast.Text = "ToolStripButton6"
        Me.tsbAutoScrollToLast.ToolTipText = "自动滚动到最后一个包"
        '
        'tsbAutoSelectLast
        '
        Me.tsbAutoSelectLast.CheckOnClick = True
        Me.tsbAutoSelectLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAutoSelectLast.Image = CType(resources.GetObject("tsbAutoSelectLast.Image"), System.Drawing.Image)
        Me.tsbAutoSelectLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAutoSelectLast.Name = "tsbAutoSelectLast"
        Me.tsbAutoSelectLast.Size = New System.Drawing.Size(23, 22)
        Me.tsbAutoSelectLast.Text = "ToolStripButton7"
        Me.tsbAutoSelectLast.ToolTipText = "自动选择最后一个包"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsbStartCapture
        '
        Me.tsbStartCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbStartCapture.Image = CType(resources.GetObject("tsbStartCapture.Image"), System.Drawing.Image)
        Me.tsbStartCapture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStartCapture.Name = "tsbStartCapture"
        Me.tsbStartCapture.Size = New System.Drawing.Size(23, 22)
        Me.tsbStartCapture.Text = "ToolStripButton6"
        Me.tsbStartCapture.ToolTipText = "开始"
        '
        'tsbStopCapture
        '
        Me.tsbStopCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbStopCapture.Image = CType(resources.GetObject("tsbStopCapture.Image"), System.Drawing.Image)
        Me.tsbStopCapture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStopCapture.Name = "tsbStopCapture"
        Me.tsbStopCapture.Size = New System.Drawing.Size(23, 22)
        Me.tsbStopCapture.Text = "ToolStripButton7"
        Me.tsbStopCapture.ToolTipText = "停止"
        '
        'tsbRestartCapture
        '
        Me.tsbRestartCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRestartCapture.Image = CType(resources.GetObject("tsbRestartCapture.Image"), System.Drawing.Image)
        Me.tsbRestartCapture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRestartCapture.Name = "tsbRestartCapture"
        Me.tsbRestartCapture.Size = New System.Drawing.Size(23, 22)
        Me.tsbRestartCapture.Text = "ToolStripButton8"
        Me.tsbRestartCapture.ToolTipText = "重新开始"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsbSendPacket
        '
        Me.tsbSendPacket.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSendPacket.Image = CType(resources.GetObject("tsbSendPacket.Image"), System.Drawing.Image)
        Me.tsbSendPacket.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSendPacket.Name = "tsbSendPacket"
        Me.tsbSendPacket.Size = New System.Drawing.Size(23, 22)
        Me.tsbSendPacket.Text = "ToolStripButton9"
        Me.tsbSendPacket.ToolTipText = "发送数据包"
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.cbProtocol)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tDetail)
        Me.SplitContainer1.Size = New System.Drawing.Size(1080, 551)
        Me.SplitContainer1.SplitterDistance = 742
        Me.SplitContainer1.TabIndex = 2
        '
        'TCMain
        '
        Me.TCMain.Controls.Add(Me.TabPage1)
        Me.TCMain.Controls.Add(Me.TabPage2)
        Me.TCMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCMain.ImageList = Me.TCIMGLIST
        Me.TCMain.Location = New System.Drawing.Point(0, 0)
        Me.TCMain.Name = "TCMain"
        Me.TCMain.SelectedIndex = 0
        Me.TCMain.Size = New System.Drawing.Size(742, 551)
        Me.TCMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGV)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(734, 524)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(3, 3)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowTemplate.Height = 23
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(728, 518)
        Me.DGV.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(734, 524)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TCIMGLIST
        '
        Me.TCIMGLIST.ImageStream = CType(resources.GetObject("TCIMGLIST.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TCIMGLIST.TransparentColor = System.Drawing.Color.Transparent
        Me.TCIMGLIST.Images.SetKeyName(0, "x-expert-chat.png")
        Me.TCIMGLIST.Images.SetKeyName(1, "x-expert-error.png")
        '
        'tDetail
        '
        Me.tDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tDetail.Location = New System.Drawing.Point(0, 23)
        Me.tDetail.Name = "tDetail"
        Me.tDetail.Size = New System.Drawing.Size(331, 524)
        Me.tDetail.TabIndex = 0
        Me.tDetail.Text = ""
        '
        'tmUpdateData
        '
        Me.tmUpdateData.Enabled = True
        '
        'cbProtocol
        '
        Me.cbProtocol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProtocol.FormattingEnabled = True
        Me.cbProtocol.Items.AddRange(New Object() {"通用协议"})
        Me.cbProtocol.Location = New System.Drawing.Point(0, 0)
        Me.cbProtocol.Name = "cbProtocol"
        Me.cbProtocol.Size = New System.Drawing.Size(331, 20)
        Me.cbProtocol.TabIndex = 1
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
        Me.ToolStripMain.ResumeLayout(False)
        Me.ToolStripMain.PerformLayout()
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
    Friend WithEvents miJump As ToolStripMenuItem
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
    Friend WithEvents SP As IO.Ports.SerialPort
    Friend WithEvents tDetail As RichTextBox
    Friend WithEvents tmUpdateData As Timer
    Friend WithEvents TCIMGLIST As ImageList
    Friend WithEvents tsbNew As ToolStripButton
    Friend WithEvents tsbOpen As ToolStripButton
    Friend WithEvents tsbSave As ToolStripButton
    Friend WithEvents tsbClose As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbDeleteAll As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbPrevious As ToolStripButton
    Friend WithEvents tsbNext As ToolStripButton
    Friend WithEvents tsbFirst As ToolStripButton
    Friend WithEvents tsbLast As ToolStripButton
    Friend WithEvents tsbJump As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbAutoScrollToLast As ToolStripButton
    Friend WithEvents tsbAutoSelectLast As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbStartCapture As ToolStripButton
    Friend WithEvents tsbStopCapture As ToolStripButton
    Friend WithEvents tsbRestartCapture As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbSendPacket As ToolStripButton
    Friend WithEvents cbProtocol As ComboBox
End Class
