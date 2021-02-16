
Public Class MainForm


    '数据数组
    'Private m_DataList As New ArrayList()

    Private m_Captures As New ArrayList()

    Private m_Current As Integer = -1

    'Private m_DataGridViewList As New ArrayList()

    'Private m_ListViewList As New ArrayList()

    '协议插件列表
    Private m_Protos As New List(Of IProtocol)

    Private Sub miNew_Click(sender As Object, e As EventArgs) Handles miNew.Click
        Dim tp As TabPage

        Dim fnc As frmNewCapture = New frmNewCapture()
        Dim tpcap As String = ""

        If fnc.ShowDialog <> DialogResult.OK Then
            Exit Sub
        End If
        tpcap = "Capturing (" + fnc.ComPort + ","
        If fnc.Can0 And fnc.Can1 Then
            tpcap += "CAN0/CAN1,"
        ElseIf fnc.Can0 Then
            tpcap += "CAN0,"
        ElseIf fnc.Can1 Then
            tpcap += "CAN1,"
        End If
        tpcap += CStr(fnc.Bitrate) + "kbps)"
        tp = New TabPage(tpcap)
        tp.ImageIndex = 0
        TCMain.TabPages.Add(tp)

        Dim lv As DBListView
        lv = New DBListView
        tp.Controls.Add(lv)
        With lv
            .Dock = DockStyle.Fill
            .BackColor = System.Drawing.SystemColors.ControlLightLight
            .HeaderStyle = ColumnHeaderStyle.Nonclickable
            .HideSelection = False
            .BorderStyle = BorderStyle.FixedSingle
            .View = View.Details
            .FullRowSelect = True
        End With

        TCMain.SelectedIndex = m_Captures.Count

        Dim c As New Capture()
        c.setCOM(fnc.ComPort)
        c.Bitrate = fnc.Bitrate
        c.CAN0 = fnc.Can0
        c.CAN1 = fnc.Can1
        c.MainForm = Me
        c.ListView = lv

        m_Captures.Add(c)
        m_Current = m_Captures.Count - 1
        If Not c.StartCapture() Then
            tp.ImageIndex = 1
        End If

        bindData(lv, c.Data)

        AddHandler lv.SelectedIndexChanged, AddressOf LV_SelectedIndexChanged


    End Sub

    Private Sub miSelectInterface_Click(sender As Object, e As EventArgs) Handles miSelectInterface.Click
        Dim fInf As frmInterfaces
        fInf = New frmInterfaces()
        fInf.ShowDialog()


    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TCMain.TabPages.Clear()

        '加载插件
        loadProtocolPlugins()

        cbProtocol.SelectedIndex = 0
    End Sub

    Private Sub loadProtocolPlugins()
        Dim proto As Reflection.Assembly
        Dim m As Object
        Dim p As IProtocol
        Dim proto_name As String
        Dim protos As String() = {"ProtocolGeneric", "ProtocolAmps", "ProtocolCANOpen"}

        For Each proto_name In protos
            Try
                Try
                    proto = System.Reflection.Assembly.LoadFrom("protocols\" + proto_name + ".dll")
                Catch ex As Exception
                    proto = System.Reflection.Assembly.LoadFrom("..\..\..\" + proto_name.Replace("Protocol", "Protocal") + "\bin\Debug\" + proto_name + ".dll")
                End Try
                'Debug.Print(proto.GetType("ProtocolGeneric.ProtoGeneric").GetMethod("Decode").GetParameters()(0).Name)
                'm = proto.CreateInstance(proto.GetExportedTypes(0).FullName)
                m = proto.CreateInstance(proto_name + ".Protocol")
                p = CallByName(m, "GetObject", vbMethod)
                m_Protos.Add(p)
                'cbProtocol.Items.Add(CallByName(m, "GetName", vbMethod))
                cbProtocol.Items.Add(p.GetName)
            Catch ex As Exception
                Debug.Print(ex.Message)
            End Try
        Next

    End Sub

    Private Function newData() As DataTable
        Dim dt = New DataTable()
        With dt
            .Columns.Add("No")
            .Columns.Add("Time")
            .Columns.Add("CAN")
            .Columns.Add("StdId")
            .Columns.Add("ExtId")
            .Columns.Add("ID")
            .Columns.Add("IDE")
            .Columns.Add("RTR")
            .Columns.Add("DLC")
            .Columns.Add("Payload")
        End With

        Return dt
    End Function

    'Private Sub bindData(lv As DBListView, data As DataTable)
    Private Sub bindData(lv As DBListView, data As List(Of String()))
        'dgv.DataSource = data

        Dim i As Integer
        'Dim dc As ColumnHeader

        'For i = 0 To data.Columns.Count - 1
        '    dc = lv.Columns.Add(data.Columns(i).ColumnName)
        '    'dc = New DataGridViewColumn()
        '    'dc.Name = data.Columns(i).ColumnName
        '    'dc.CellTemplate = New DataGridViewTextBoxCell()
        '    'dgv.Columns.Add(dc)
        'Next

        For i = 0 To CanSniffer.Capture.COLUMNS.Length - 1
            lv.Columns.Add(CanSniffer.Capture.COLUMNS(i))
        Next

        'For Each c As DataGridViewColumn In dgv.Columns
        '    c.SortMode = DataGridViewColumnSortMode.NotSortable
        'Next
        'With dgv
        With lv
            .Columns(0).Width = 40
            .Columns(0).TextAlign = HorizontalAlignment.Right
            '.Columns("No").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '.Columns("No").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns(1).Width = 150
            .Columns(1).TextAlign = HorizontalAlignment.Right
            '.Columns("Time").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '.Columns("Time").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns(2).Width = 30
            .Columns(2).TextAlign = HorizontalAlignment.Center
            '.Columns("CAN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(3).Width = 150

            .Columns(4).Width = 210

            .Columns(5).Width = 70

            .Columns(6).Width = 30
            '.Columns("IDE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).TextAlign = HorizontalAlignment.Center

            .Columns(7).Width = 30
            '.Columns("RTR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).TextAlign = HorizontalAlignment.Center

            .Columns(8).Width = 30
            '.Columns("DLC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).TextAlign = HorizontalAlignment.Center

            .Columns(9).Width = 400
        End With

    End Sub

    Private Sub LV_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Dim dgv As DataGridView
        Dim lv As DBListView
        'Dim r As DataGridViewRow
        Dim r As ListViewItem
        'MsgBox(e.RowIndex)

        Try
            'dgv = m_DataGridViewList(m_Current)
            'lv = m_ListViewList(m_Current)
            lv = CType(m_Captures(m_Current), Capture).ListView
            'r = dgv.Rows(e.RowIndex)
            'r = dgv.Rows(dgv.SelectedRows(0).Index)
            r = lv.Items(lv.SelectedIndices(0))
            tDetail.Clear()
            'tDetail.AppendText(CallByName(m_Protos(cbProtocol.SelectedIndex), "Decode", vbMethod, r))
            tDetail.AppendText(m_Protos(cbProtocol.SelectedIndex).Decode(r))
            'tDetail.AppendText("序号：" + r.Cells("No").Value + vbCrLf)
            'tDetail.AppendText("时间：" + r.Cells("Time").Value + vbCrLf)
            'tDetail.AppendText("接口：" + r.Cells("CAN").Value + vbCrLf)
            'tDetail.AppendText("帧ID：" + r.Cells("ID").Value + vbCrLf)
            'If r.Cells("IDE").Value = "1" Then
            '    tDetail.AppendText("帧类型：扩展帧 (IDE=1)" + vbCrLf)
            'Else
            '    tDetail.AppendText("帧类型：标准帧 (IDE=0)" + vbCrLf)
            'End If
            'tDetail.AppendText("数据长度：" + r.Cells("DLC").Value + vbCrLf)
            'tDetail.AppendText("数据内容：" + r.Cells("Payload").Value + vbCrLf)
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Public Delegate Sub updateDGVdelegate(r As DataRow)
    Public Sub updateDGV(r As DataRow)
        If Me.InvokeRequired Then
            Try
                Me.Invoke(New updateDGVdelegate(AddressOf updateDGV), New Object() {r})
            Catch ex As Exception
            End Try
        Else
            'Dim dgv As DataGridView
            Dim lv As DBListView
            Dim i, j As Integer
            Dim item As ListViewItem
            'dgv = m_DataGridViewList(m_Current)
            'lv = m_ListViewList(m_Current)
            lv = CType(m_Captures(m_Current), Capture).ListView
            'm_DataGridViewList(m_Current).Refresh()
            'dgv.DataSource = m_Captures(m_Current).Data
            'i = dgv.Rows.Add()
            item = lv.Items.Add(r.Item(0))
            For j = 1 To r.ItemArray.Length - 1
                'dgv.Rows(i).Cells(j).Value = r.Item(j)
                item.SubItems.Add(r.Item(j))
            Next

            If miAutoScrollToLast.Checked Then
                'dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1
                lv.EnsureVisible(lv.Items.Count - 1)
            End If
            If miAutoSelectLast.Checked Then
                'For Each row As DataGridViewRow In dgv.SelectedRows
                '    row.Selected = False
                'Next
                For Each item In lv.SelectedItems
                    item.Selected = False
                Next
                'dgv.Rows(dgv.Rows.Count - 1).Selected = True
                lv.Items(lv.Items.Count - 1).Selected = True
            End If

        End If
    End Sub

    Private Sub miDeleteAll_Click(sender As Object, e As EventArgs) Handles miDeleteAll.Click
        'Dim dgv As DataGridView
        Dim lv As DBListView
        Dim cap As Capture

        'dgv = m_DataGridViewList(m_Current)
        'lv = m_ListViewList(m_Current)
        lv = CType(m_Captures(m_Current), Capture).ListView
        cap = m_Captures(m_Current)

        cap.clearData()
        'dgv.Rows.Clear()
        lv.Items.Clear()
    End Sub

    Private Sub tmUpdateData_Tick(sender As Object, e As EventArgs) Handles tmUpdateData.Tick
        Dim i, j As Integer
        'Dim dgv As DataGridView
        Dim lv As DBListView
        Dim item As ListViewItem
        Dim cap As Capture
        'Dim r As DataRow
        Dim r As String()

        'If m_DataGridViewList.Count > 0 Then
        'If m_ListViewList.Count > 0 Then
        If m_Captures.Count > 0 Then

            'dgv = m_DataGridViewList(m_Current)
            'lv = m_ListViewList(m_Current)
            lv = CType(m_Captures(m_Current), Capture).ListView
            cap = m_Captures(m_Current)

            'If cap.Data.Rows.Count > dgv.Rows.Count Then

            'If cap.Data.Rows.Count > lv.Items.Count Then
            If cap.Data.Count > lv.Items.Count Then
                For i = lv.Items.Count To cap.Data.Count - 1
                    'dgv.Rows.Add()
                    'r = cap.Data.Rows(i)
                    r = cap.Data.Item(i)
                    'item = lv.Items.Add(r.Item(0))
                    item = lv.Items.Add(r(0))
                    'For j = 1 To r.ItemArray.Length - 1
                    For j = 1 To r.Length - 1
                        'dgv.Rows(i).Cells(j).Value = r.Item(j)
                        'item.SubItems.Add(r.Item(j))
                        item.SubItems.Add(r(j))
                    Next

                Next

                    'If miAutoScrollToLast.Checked Then
                    '        dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1
                    '    End If
                    '    If miAutoSelectLast.Checked Then
                    '        For Each row As DataGridViewRow In dgv.SelectedRows
                    '            row.Selected = False
                    '        Next
                    '        'dgv.Rows(dgv.Rows.Count - 1).Selected = True
                    '        dgv.CurrentCell = dgv.Rows(dgv.Rows.Count - 1).Cells(0)
                    '    End If

                    'End If
                    If miAutoScrollToLast.Checked Then
                    'dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1
                    lv.EnsureVisible(lv.Items.Count - 1)
                End If
                If miAutoSelectLast.Checked Then
                    'For Each row As DataGridViewRow In dgv.SelectedRows
                    '    row.Selected = False
                    'Next
                    For Each item In lv.SelectedItems
                        item.Selected = False
                    Next
                    'dgv.Rows(dgv.Rows.Count - 1).Selected = True
                    lv.Items(lv.Items.Count - 1).Selected = True
                End If


            End If
        End If

    End Sub

    Private Sub miClose_Click(sender As Object, e As EventArgs) Handles miClose.Click
        'Dim dgv As DataGridView
        Dim lv As DBListView
        Dim cap As Capture

        If m_Current >= 0 Then
            tmUpdateData.Stop()

            'dgv = m_DataGridViewList(m_Current)
            'lv = m_ListViewList(m_Current)
            lv = CType(m_Captures(m_Current), Capture).ListView
            cap = m_Captures(m_Current)

            cap.StopCapture()
            m_Captures.Remove(cap)

            'RemoveHandler dgv.RowEnter, AddressOf DGV_RowEnter
            RemoveHandler lv.SelectedIndexChanged, AddressOf LV_SelectedIndexChanged
            'm_DataGridViewList.Remove(dgv)
            'm_ListViewList.Remove(lv)
            cap.ListView = Nothing
            'TCMain.TabPages.Item(m_Current).Controls.Remove(dgv)
            TCMain.TabPages.Item(m_Current).Controls.Remove(lv)

            TCMain.TabPages.RemoveAt(m_Current)

            If m_Captures.Count > 0 Then
                m_Current = m_Current - 1
                If m_Current < 0 Then
                    m_Current = 0
                End If
                TCMain.SelectedIndex = m_Current
            Else
                m_Current = -1
            End If

            tmUpdateData.Start()
        End If

    End Sub

    Private Sub TCMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TCMain.SelectedIndexChanged
        m_Current = TCMain.SelectedIndex
    End Sub

    Private Sub miStart_Click(sender As Object, e As EventArgs) Handles miStart.Click
        Dim cap As Capture
        If m_Current > -1 Then
            cap = m_Captures(m_Current)
            If cap.State <> CanSniffer.Capture.CAPTURE_STATE.RUNNING Then
                cap.StartCapture()
                TCMain.TabPages.Item(m_Current).ImageIndex = 0
            End If
        End If
    End Sub

    Private Sub miStop_Click(sender As Object, e As EventArgs) Handles miStop.Click
        Dim cap As Capture
        If m_Current > -1 Then
            cap = m_Captures(m_Current)
            If cap.State = CanSniffer.Capture.CAPTURE_STATE.RUNNING Then
                cap.StopCapture()
                TCMain.TabPages.Item(m_Current).ImageIndex = 1
            End If
        End If
    End Sub

    Private Sub miRestart_Click(sender As Object, e As EventArgs) Handles miRestart.Click
        Dim cap As Capture
        If m_Current > -1 Then
            cap = m_Captures(m_Current)
            cap.RestartCapture()
            TCMain.TabPages.Item(m_Current).ImageIndex = 0
        End If
    End Sub

#Region "工具栏"


    Private Sub tsbNew_Click(sender As Object, e As EventArgs) Handles tsbNew.Click
        miNew.PerformClick()
    End Sub

    Private Sub tsbOpen_Click(sender As Object, e As EventArgs) Handles tsbOpen.Click
        miOpen.PerformClick()
    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click
        miSave.PerformClick()
    End Sub

    Private Sub tsbClose_Click(sender As Object, e As EventArgs) Handles tsbClose.Click
        miClose.PerformClick()
    End Sub

    Private Sub tsbDeleteAll_Click(sender As Object, e As EventArgs) Handles tsbDeleteAll.Click
        miDeleteAll.PerformClick()
    End Sub

    Private Sub tsbPrevious_Click(sender As Object, e As EventArgs) Handles tsbPrevious.Click
        miPrevious.PerformClick()
    End Sub

    Private Sub tsbNext_Click(sender As Object, e As EventArgs) Handles tsbNext.Click
        miNext.PerformClick()
    End Sub

    Private Sub tsbJump_Click(sender As Object, e As EventArgs) Handles tsbJump.Click
        miJump.PerformClick()
    End Sub

    Private Sub tsbFirst_Click(sender As Object, e As EventArgs) Handles tsbFirst.Click
        miFirst.PerformClick()
    End Sub

    Private Sub tsbLast_Click(sender As Object, e As EventArgs) Handles tsbLast.Click
        miLast.PerformClick()
    End Sub

    Private Sub tsbAutoScrollToLast_Click(sender As Object, e As EventArgs) Handles tsbAutoScrollToLast.Click
        miAutoScrollToLast.PerformClick()
    End Sub

    Private Sub tsbAutoSelectLast_Click(sender As Object, e As EventArgs) Handles tsbAutoSelectLast.Click
        miAutoSelectLast.PerformClick()
    End Sub

    Private Sub tsbStartCapture_Click(sender As Object, e As EventArgs) Handles tsbStartCapture.Click
        miStart.PerformClick()
    End Sub

    Private Sub tsbStopCapture_Click(sender As Object, e As EventArgs) Handles tsbStopCapture.Click
        miStop.PerformClick()
    End Sub

    Private Sub tsbRestartCapture_Click(sender As Object, e As EventArgs) Handles tsbRestartCapture.Click
        miRestart.PerformClick()
    End Sub

    Private Sub tsbSendPacket_Click(sender As Object, e As EventArgs) Handles tsbSendPacket.Click
        miSendPacket.PerformClick()
    End Sub

#End Region

    Private Sub miAutoScrollToLast_Click(sender As Object, e As EventArgs) Handles miAutoScrollToLast.Click
        tsbAutoScrollToLast.Checked = miAutoScrollToLast.Checked
    End Sub

    Private Sub miAutoSelectLast_Click(sender As Object, e As EventArgs) Handles miAutoSelectLast.Click
        tsbAutoSelectLast.Checked = miAutoSelectLast.Checked
    End Sub

    Private Sub cbProtocol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProtocol.SelectedIndexChanged
        'DGV_RowEnter(Nothing, Nothing)
        LV_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub miSendPacket_Click(sender As Object, e As EventArgs) Handles miSendPacket.Click
        Dim f As New frmSendPacket
        f.Protos = m_Protos
        f.Captures = m_Captures

        If (m_Current > -1) Then
            f.COM = m_Captures(m_Current).SerialPort.PortName
        End If


        f.Show()

    End Sub

    Private Sub miAbout_Click(sender As Object, e As EventArgs) Handles miAbout.Click
        Dim f As New frmAboutBox
        f.Protos = m_Protos
        f.ShowDialog()
    End Sub

    Private Sub miPrevious_Click(sender As Object, e As EventArgs) Handles miPrevious.Click
        Dim lv As ListView
        Dim idx As Integer = 0

        If m_Current < 0 Then
            Exit Sub
        End If

        'lv = m_ListViewList(m_Current)
        lv = CType(m_Captures(m_Current), Capture).ListView
        If lv.Items.Count = 0 Then
            Exit Sub
        End If
        For Each item In lv.SelectedItems
            idx = lv.Items.IndexOf(item)
            item.Selected = False
        Next
        idx -= 1
        If idx < 0 Then idx = 0
        lv.Items(idx).Selected = True

    End Sub

    Private Sub miNext_Click(sender As Object, e As EventArgs) Handles miNext.Click
        Dim lv As ListView
        Dim idx As Integer = 0

        If m_Current < 0 Then
            Exit Sub
        End If

        'lv = m_ListViewList(m_Current)
        lv = CType(m_Captures(m_Current), Capture).ListView
        If lv.Items.Count = 0 Then
            Exit Sub
        End If
        For Each item In lv.SelectedItems
            idx = lv.Items.IndexOf(item)
            item.Selected = False
        Next
        idx += 1
        If idx > (lv.Items.Count - 1) Then idx = lv.Items.Count - 1
        lv.Items(idx).Selected = True
    End Sub

    Private Sub miFirst_Click(sender As Object, e As EventArgs) Handles miFirst.Click
        Dim lv As ListView

        If m_Current < 0 Then
            Exit Sub
        End If

        'lv = m_ListViewList(m_Current)
        lv = CType(m_Captures(m_Current), Capture).ListView
        If lv.Items.Count = 0 Then
            Exit Sub
        End If
        For Each item In lv.SelectedItems
            item.Selected = False
        Next
        lv.Items(0).Selected = True

    End Sub

    Private Sub miLast_Click(sender As Object, e As EventArgs) Handles miLast.Click
        Dim lv As ListView

        If m_Current < 0 Then
            Exit Sub
        End If

        'lv = m_ListViewList(m_Current)
        lv = CType(m_Captures(m_Current), Capture).ListView
        If lv.Items.Count = 0 Then
            Exit Sub
        End If

        For Each item In lv.SelectedItems
            item.Selected = False
        Next
        lv.Items(LV.Items.Count - 1).Selected = True
    End Sub

    Private Sub miJump_Click(sender As Object, e As EventArgs) Handles miJump.Click
        Dim lv As ListView
        Dim idx As Integer = 0
        Dim sIdx As String

        If m_Current < 0 Then
            Exit Sub
        End If

        'lv = m_ListViewList(m_Current)
        lv = CType(m_Captures(m_Current), Capture).ListView
        If lv.Items.Count = 0 Then
            Exit Sub
        End If

        sIdx = InputBox("请输入序号", "转到指定包")
        Try
            idx = CInt(sIdx)
            If (idx < 0) Or (idx > lv.Items.Count - 1) Then
                Throw New Exception("无效序号！")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        For Each item In lv.SelectedItems
            item.Selected = False
        Next
        lv.Items(idx).Selected = True

    End Sub

    Private Sub miSave_Click(sender As Object, e As EventArgs) Handles miSave.Click
        Dim cap As Capture

        If m_Current < 0 Then
            MsgBox("没有需要保存的数据！")
            Exit Sub
        End If

        cap = CType(m_Captures(m_Current), Capture)
        If cap.FileName = "" Then
            If SFD.ShowDialog <> DialogResult.OK Then
                Exit Sub
            End If
            cap.FileName = SFD.FileName
            TCMain.TabPages.Item(m_Current).Text &= " - " & SFD.FileName
        End If

        If Not cap.NewFile Then
            Exit Sub
        End If

        cap.SaveFile()

    End Sub

    Private Sub miSaveAs_Click(sender As Object, e As EventArgs) Handles miSaveAs.Click
        Dim cap As Capture

        If m_Current < 0 Then
            MsgBox("没有需要保存的数据！")
            Exit Sub
        End If

        cap = CType(m_Captures(m_Current), Capture)
        If SFD.ShowDialog <> DialogResult.OK Then
            Exit Sub
        End If
        cap.FileName = SFD.FileName

        TCMain.TabPages.Item(m_Current).Text = Split(TCMain.TabPages.Item(m_Current).Text, " - ")(0)
        TCMain.TabPages.Item(m_Current).Text &= " - " & SFD.FileName

        cap.SaveFile()

    End Sub

    Private Sub miSaveSelected_Click(sender As Object, e As EventArgs) Handles miSaveSelected.Click
        Dim cap As Capture

        If m_Current < 0 Then
            MsgBox("没有需要保存的数据！")
            Exit Sub
        End If

        cap = CType(m_Captures(m_Current), Capture)

        If cap.ListView.SelectedIndices.Count < 1 Then
            MsgBox("请选择需要保存的数据包！")
            Exit Sub
        End If
        If SFD.ShowDialog <> DialogResult.OK Then
            Exit Sub
        End If

        cap.SaveSelectedPacket(SFD.FileName)
    End Sub

    Private Sub miOpen_Click(sender As Object, e As EventArgs) Handles miOpen.Click
        Dim cap As Capture
        Dim tp As TabPage

        Dim fnc As frmNewCapture = New frmNewCapture()
        Dim tpcap As String = ""

        If OFD.ShowDialog <> DialogResult.OK Then
            Exit Sub
        End If

        cap = New Capture()
        cap.FileName = OFD.FileName
        If Not cap.OpenFile() Then
            Exit Sub
        End If

        tpcap = "Capturing (" + cap.getCOM() + ","
        If cap.CAN0 And cap.CAN1 Then
            tpcap += "CAN0/CAN1,"
        ElseIf cap.Can0 Then
            tpcap += "CAN0,"
        ElseIf cap.Can1 Then
            tpcap += "CAN1,"
        End If
        tpcap += CStr(cap.Bitrate) + "kbps) - " + OFD.FileName
        tp = New TabPage(tpcap)
        tp.ImageIndex = 0
        TCMain.TabPages.Add(tp)

        Dim lv As DBListView
        lv = New DBListView
        tp.Controls.Add(lv)
        With lv
            .Dock = DockStyle.Fill
            .BackColor = System.Drawing.SystemColors.ControlLightLight
            .HeaderStyle = ColumnHeaderStyle.Nonclickable
            .HideSelection = False
            .BorderStyle = BorderStyle.FixedSingle
            .View = View.Details
            .FullRowSelect = True
        End With

        TCMain.SelectedIndex = m_Captures.Count

        'c.setCOM(fnc.ComPort)
        'c.Bitrate = fnc.Bitrate
        'c.CAN0 = fnc.Can0
        'c.CAN1 = fnc.Can1
        cap.MainForm = Me
        cap.ListView = lv

        m_Captures.Add(cap)
        m_Current = m_Captures.Count - 1
        tp.ImageIndex = 1

        bindData(lv, cap.Data)

        AddHandler lv.SelectedIndexChanged, AddressOf LV_SelectedIndexChanged

    End Sub


End Class