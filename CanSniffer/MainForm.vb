Public Class MainForm


    '数据数组
    Private m_DataList As New ArrayList()

    Private m_Captures As New ArrayList()

    Private m_Current As Integer = 0

    Private m_DataGridViewList As New ArrayList

    Private Sub miNew_Click(sender As Object, e As EventArgs) Handles miNew.Click
        Dim r As DataRow
        Dim dt As DataTable

        Dim tp As TabPage
        Dim dgv As DataGridView

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
        TCMain.TabPages.Add(tp)
        dgv = New DataGridView()
        tp.Controls.Add(dgv)
        With dgv
            .Dock = DockStyle.Fill
            .BackgroundColor = System.Drawing.SystemColors.ControlLightLight
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .AllowUserToDeleteRows = False
            .BorderStyle = BorderStyle.None
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
        m_DataGridViewList.Add(dgv)

        Dim c As New Capture()
        c.setCOM(fnc.ComPort)
        c.Bitrate = fnc.Bitrate
        c.CAN0 = fnc.Can0
        c.CAN1 = fnc.Can1
        c.MainForm = Me

        m_Captures.Add(c)
        m_Current = m_Captures.Count - 1
        c.StartCapture()


        'dt = newData()

        'r = dt.NewRow()
        'r("No") = "1"
        'r("Time") = "2021-02-06 17:57:27.234"
        'r("CAN") = "0"
        'r("StdId") = "0x602"
        'r("ExtId") = "0x035"
        'r("IDE") = "0"
        'r("RTR") = "0"
        'r("DLC") = 8
        'r("Payload") = "f6 00 35 24 43 00 40 43"
        'dt.Rows.Add(r)

        'r = dt.NewRow()
        'r("No") = "2"
        'r("Time") = "2021-02-06 17:57:27.234"
        'r("CAN") = "0"
        'r("StdId") = "0x602 [ 011 0101 0011 ]"
        'r("ExtId") = "0x00035 [ 00 1010 0010 0011 0111 ]"
        'r("ID") = "0x00035223"
        'r("IDE") = "0"
        'r("RTR") = "0"
        'r("DLC") = 8
        'r("Payload") = "f6 00 35 24 43 00 40 43"
        'dt.Rows.Add(r)


        'm_DataList.Add(dt)
        'bindData(dgv, dt)

        bindData(dgv, c.Data)

        AddHandler dgv.RowEnter, AddressOf DGV_RowEnter

    End Sub

    Private Sub miSelectInterface_Click(sender As Object, e As EventArgs) Handles miSelectInterface.Click
        Dim fInf As frmInterfaces
        fInf = New frmInterfaces()
        fInf.ShowDialog()


    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TCMain.TabPages.Clear()
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

    Private Sub bindData(dgv As DataGridView, data As DataTable)
        'dgv.DataSource = data

        Dim i As Integer
        Dim dc As DataGridViewColumn

        For i = 0 To data.Columns.Count - 1
            dc = New DataGridViewColumn()
            dc.Name = data.Columns(i).ColumnName
            dc.CellTemplate = New DataGridViewTextBoxCell()
            dgv.Columns.Add(dc)
        Next

        For Each c As DataGridViewColumn In dgv.Columns
            c.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        With dgv
            .Columns("No").Width = 40
            .Columns("No").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("No").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight


            .Columns("Time").Width = 150
            .Columns("Time").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Time").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns("CAN").Width = 30
            .Columns("CAN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("StdId").Width = 150

            .Columns("ExtId").Width = 210

            .Columns("ID").Width = 70

            .Columns("IDE").Width = 30
            .Columns("IDE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("RTR").Width = 30
            .Columns("RTR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("DLC").Width = 30
            .Columns("DLC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("Payload").Width = 400
        End With

    End Sub

    Private Sub DGV_RowEnter(sender As Object, e As DataGridViewCellEventArgs)
        Dim dgv As DataGridView
        Dim r As DataGridViewRow
        'MsgBox(e.RowIndex)

        dgv = m_DataGridViewList(m_Current)
        r = dgv.Rows(e.RowIndex)
        tDetail.Clear()
        tDetail.AppendText("序号：" + r.Cells("No").Value + vbCrLf)
        tDetail.AppendText("时间：" + r.Cells("Time").Value + vbCrLf)
        tDetail.AppendText("接口：" + r.Cells("CAN").Value + vbCrLf)
        tDetail.AppendText("帧ID：" + r.Cells("ID").Value + vbCrLf)
        If r.Cells("IDE").Value = "1" Then
            tDetail.AppendText("帧类型：扩展帧 (IDE=1)" + vbCrLf)
        Else
            tDetail.AppendText("帧类型：标准帧 (IDE=0)" + vbCrLf)
        End If
        tDetail.AppendText("数据长度：" + r.Cells("DLC").Value + vbCrLf)
        tDetail.AppendText("数据内容：" + r.Cells("Payload").Value + vbCrLf)
    End Sub

    Public Delegate Sub updateDGVdelegate(r As DataRow)
    Public Sub updateDGV(r As DataRow)
        If Me.InvokeRequired Then
            Try
                Me.Invoke(New updateDGVdelegate(AddressOf updateDGV), New Object() {r})
            Catch ex As Exception
            End Try
        Else
            Dim dgv As DataGridView
            Dim i, j As Integer
            dgv = m_DataGridViewList(m_Current)
            'm_DataGridViewList(m_Current).Refresh()
            'dgv.DataSource = m_Captures(m_Current).Data
            i = dgv.Rows.Add()
            For j = 0 To r.ItemArray.Length - 1
                dgv.Rows(i).Cells(j).Value = r.Item(j)
            Next

            If miAutoScrollToLast.Checked Then
                dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1
            End If
            If miAutoSelectLast.Checked Then
                For Each row As DataGridViewRow In dgv.SelectedRows
                    row.Selected = False
                Next
                dgv.Rows(dgv.Rows.Count - 1).Selected = True
            End If

        End If
    End Sub

    Private Sub miDeleteAll_Click(sender As Object, e As EventArgs) Handles miDeleteAll.Click
        Dim dgv As DataGridView
        Dim cap As Capture

        dgv = m_DataGridViewList(m_Current)
        cap = m_Captures(m_Current)

        cap.clearData()
        dgv.Rows.Clear()
    End Sub

    Private Sub tmUpdateData_Tick(sender As Object, e As EventArgs) Handles tmUpdateData.Tick
        Dim i, j As Integer
        Dim dgv As DataGridView
        Dim cap As Capture
        Dim r As DataRow

        If m_DataGridViewList.Count > 0 Then

            dgv = m_DataGridViewList(m_Current)
            cap = m_Captures(m_Current)

            If cap.Data.Rows.Count > dgv.Rows.Count Then
                For i = dgv.Rows.Count To cap.Data.Rows.Count - 1
                    dgv.Rows.Add()
                    r = cap.Data.Rows(i)
                    For j = 0 To r.ItemArray.Length - 1
                        dgv.Rows(i).Cells(j).Value = r.Item(j)
                    Next

                Next

                If miAutoScrollToLast.Checked Then
                    dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1
                End If
                If miAutoSelectLast.Checked Then
                    For Each row As DataGridViewRow In dgv.SelectedRows
                        row.Selected = False
                    Next
                    'dgv.Rows(dgv.Rows.Count - 1).Selected = True
                    dgv.CurrentCell = dgv.Rows(dgv.Rows.Count - 1).Cells(0)
                End If

            End If

        End If
    End Sub
End Class