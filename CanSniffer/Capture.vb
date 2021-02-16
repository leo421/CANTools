Public Class Capture

    Public Shared COLUMNS() As String = {"No", "Time", "CAN", "StdId", "ExtId", "ID", "IDE", "RTR", "DLC", "Payload"}

    Public Enum CAPTURE_STATE
        NEW_CAPTURE = 1
        RUNNING = 2
        STOPPED = 3
    End Enum

    Private m_No As Integer

    '通信端口
    Private WithEvents m_SerialPort As IO.Ports.SerialPort

    'can端口
    Private m_Can0 As Boolean
    Private m_Can1 As Boolean

    '速率，单位是kbps
    Private m_Bitrate As Integer

    '捕获的数据
    'Private m_Data As DataTable
    Private m_Data As List(Of String())

    '运行状态
    Private m_State As CAPTURE_STATE

    Private m_MainForm As MainForm

    Private m_ListView As DBListView

    Private m_FileName As String = ""
    Private m_NewFile As Boolean = True

    Public ReadOnly Property SerialPort As IO.Ports.SerialPort
        Get
            Return m_SerialPort
        End Get
    End Property

    Public ReadOnly Property Data As List(Of String())
        Get
            Return m_Data
        End Get
    End Property

    Public Property CAN0 As Boolean
        Get
            Return m_Can0
        End Get
        Set(value As Boolean)
            m_Can0 = value
        End Set
    End Property
    Public Property CAN1 As Boolean
        Get
            Return m_Can1
        End Get
        Set(value As Boolean)
            m_Can1 = value
        End Set
    End Property

    Public Property Bitrate As Integer
        Get
            Return m_Bitrate
        End Get
        Set(value As Integer)
            m_Bitrate = value
        End Set
    End Property

    Public ReadOnly Property State As CAPTURE_STATE
        Get
            Return m_State
        End Get
    End Property

    Public Property MainForm As MainForm
        Get
            Return m_MainForm
        End Get
        Set(value As MainForm)
            m_MainForm = value
        End Set
    End Property

    Public Property ListView As DBListView
        Get
            Return m_ListView
        End Get
        Set(value As DBListView)
            m_ListView = value
        End Set
    End Property

    Public Property FileName As String
        Get
            Return m_FileName
        End Get
        Set(value As String)
            m_FileName = value
        End Set
    End Property

    Public Property NewFile As Boolean
        Get
            Return m_NewFile
        End Get
        Set(value As Boolean)
            m_NewFile = value
        End Set
    End Property

    Sub New()
        m_SerialPort = New IO.Ports.SerialPort
        m_Can0 = True
        m_Can1 = False
        m_Bitrate = 500
        m_State = CAPTURE_STATE.NEW_CAPTURE
        'm_Data = newData()
        m_Data = New List(Of String())

        m_No = 0

        ReDim m_RecvBuf(8192)
        m_RecvBufSize = 0

        m_SerialPort.BaudRate = 921600
    End Sub

    Public Sub setCOM(com As String)
        m_SerialPort.PortName = com
    End Sub

    Public Function getCOM() As String
        Return m_SerialPort.PortName
    End Function

    Public Function StartCapture() As Boolean
        '开启串口
        Try
            m_SerialPort.Open()
            m_State = CAPTURE_STATE.RUNNING
            Return True
        Catch ex As Exception
            MsgBox("串口打开失败：" + ex.Message)
            m_State = CAPTURE_STATE.STOPPED
            Return False
        End Try
    End Function

    Public Sub StopCapture()
        '关闭串口
        Try
            m_SerialPort.Close()
        Catch ex As Exception
            MsgBox("串口关闭失败：" + ex.Message)
        End Try
        m_State = CAPTURE_STATE.STOPPED
    End Sub

    Public Sub RestartCapture()
        '关闭串口
        StopCapture()
        '清除数据
        'm_Data.Rows.Clear()
        m_Data.Clear()
        m_No = 0
        '开启串口
        StartCapture()
    End Sub

    'Private Function newData() As DataTable
    '    Dim dt = New DataTable()
    '    With dt
    '        .Columns.Add("No")
    '        .Columns.Add("Time")
    '        .Columns.Add("CAN")
    '        .Columns.Add("StdId")
    '        .Columns.Add("ExtId")
    '        .Columns.Add("ID")
    '        .Columns.Add("IDE")
    '        .Columns.Add("RTR")
    '        .Columns.Add("DLC")
    '        .Columns.Add("Payload")
    '    End With

    '    Return dt
    'End Function

    Private m_RecvBuf As Byte()
    Private m_RecvBufSize As Integer
    Private Sub SP_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles m_SerialPort.DataReceived
        Dim c As Integer
        Dim buf As Byte()
        ReDim buf(4096)
        Try
            c = m_SerialPort.Read(buf, 0, 4096)
            Array.Copy(buf, 0, m_RecvBuf, m_RecvBufSize, c)
            m_RecvBufSize += c
            processPacket()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub processPacket()
        Dim i As Integer
        Dim pos As Integer

        If m_RecvBufSize < 5 Then
            Exit Sub
        End If

        pos = 0
        For i = 0 To m_RecvBufSize - 6
            If (m_RecvBuf(i) = &H55) And (m_RecvBuf(i + 1) = &HAA) Then
                If (i + m_RecvBuf(i + 2) + 3) <= m_RecvBufSize Then
                    addData(m_RecvBuf, i, m_RecvBuf(i + 2) + 3)
                    i += m_RecvBuf(i + 2) + 3
                    pos = i
                    i -= 1
                End If
            End If
        Next
        If pos > 0 Then
            Array.Copy(m_RecvBuf, pos, m_RecvBuf, 0, m_RecvBufSize - pos)
            m_RecvBufSize = m_RecvBufSize - pos
        End If
    End Sub
    Private Sub addData(buf As Byte(), offset As Integer, length As Integer)
        'Dim r As DataRow
        Dim r() As String
        Dim payload As String
        Dim h As String
        Dim stdid, extid As UInt32
        Dim s As String

        'TODO 做数据检查，防止解析失败导致错误

        '判断是否是can数据包
        If buf(offset + 3) <> 2 Then
            Exit Sub
        End If

        '过滤不需要的can接口数据
        If (buf(offset + 4) = 0) And (m_Can0 = False) Then
            Exit Sub
        End If
        If (buf(offset + 4) = 1) And (m_Can1 = False) Then
            Exit Sub
        End If

        'r = m_Data.NewRow
        ReDim r(9)
        'r("No") = m_No
        r(0) = m_No
        m_No += 1
        'r("Time") = Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
        r(1) = Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
        'r("CAN") = CStr(buf(offset + 4))
        r(2) = CStr(buf(offset + 4))
        'r("IDE") = CStr(BitConverter.ToUInt32(buf, offset + 13))
        r(6) = CStr(BitConverter.ToUInt32(buf, offset + 13))
        'r("RTR") = CStr(BitConverter.ToUInt32(buf, offset + 17))
        r(7) = CStr(BitConverter.ToUInt32(buf, offset + 17))
        'r("DLC") = CStr(BitConverter.ToUInt32(buf, offset + 21))
        r(8) = CStr(BitConverter.ToUInt32(buf, offset + 21))
        payload = ""
        For i = 0 To 7
            h = Hex(buf(offset + 33 + i))
            If h.Length < 2 Then
                h = "0" + h
            End If
            payload += h + " "
        Next
        'r("Payload") = payload.Trim()
        r(9) = payload.Trim()


        stdid = BitConverter.ToUInt32(buf, offset + 5)
        s = Convert.ToString(stdid, 2)
        If s.Length < 11 Then
            s = Space(11 - s.Length).Replace(" ", "0") + s
        End If
        s = s.Insert(3, " ")
        s = s.Insert(8, " ")
        'r("StdId") = "0x" + Convert.ToString(stdid, 16) + " [ " + s + " ]"
        r(3) = "0x" + Convert.ToString(stdid, 16) + " [ " + s + " ]"

        extid = BitConverter.ToUInt32(buf, offset + 9)
        s = Convert.ToString(extid, 2)
        If s.Length < 18 Then
            s = Space(18 - s.Length).Replace(" ", "0") + s
        End If
        s = s.Insert(2, " ")
        s = s.Insert(7, " ")
        s = s.Insert(12, " ")
        s = s.Insert(17, " ")
        'r("ExtId") = "0x" + Convert.ToString(extid, 16) + " [ " + s + " ]"
        r(4) = "0x" + Convert.ToString(extid, 16) + " [ " + s + " ]"


        'If r("IDE") = "4" Then
        If r(6) = "4" Then
            '扩展帧
            s = Convert.ToString(extid, 2)
            If s.Length < 18 Then
                s = Space(18 - s.Length).Replace(" ", "0") + s
            End If
            s = Convert.ToString(stdid, 2) + s
            s = Convert.ToString(Convert.ToUInt32(s, 2), 16)
            If s.Length < 8 Then
                s = Space(8 - s.Length).Replace(" ", "0") + s
            End If
            'r("ID") = "0x" + s
            r(5) = "0x" + s
        Else
            '标准帧
            'r("ID") = "0x" + Convert.ToString(stdid, 16)
            r(5) = "0x" + Convert.ToString(stdid, 16)
        End If
        'm_Data.Rows.Add(r)
        'm_Data.AcceptChanges()
        m_Data.Add(r)

        updateDGV(r)
    End Sub

    'Private Sub updateDGV(r As DataRow)
    Private Sub updateDGV(r() As String)
        'TODO 效率太低
        'm_MainForm.updateDGV(r)
    End Sub

    Public Sub clearData()
        'm_Data.Rows.Clear()
        m_Data.Clear()
        m_No = 0
    End Sub

    Public Sub SendPacket(packetdata As Byte())
        m_SerialPort.Write(packetdata, 0, packetdata.Length)
    End Sub

    Public Sub SaveFile()
        Dim doc As New Xml.XmlDocument
        Dim eRoot, eSetting, ep As Xml.XmlElement
        Dim i, j As Integer

        doc.LoadXml("<csp/>")

        eRoot = doc.DocumentElement
        eSetting = doc.CreateElement("setting")
        If m_Can0 Then
            eSetting.SetAttribute("can0", "1")
        Else
            eSetting.SetAttribute("can0", "0")
        End If
        If m_Can1 Then
            eSetting.SetAttribute("can1", "1")
        Else
            eSetting.SetAttribute("can1", "0")
        End If
        eSetting.SetAttribute("bitrate", CStr(m_Bitrate))
        eSetting.SetAttribute("comport", m_SerialPort.PortName)
        eRoot.AppendChild(eSetting)

        For i = 0 To m_Data.Count - 1
            ep = doc.CreateElement("p")
            For j = 0 To COLUMNS.Count - 1
                ep.SetAttribute(COLUMNS(j), m_Data(i)(j))
            Next
            eRoot.AppendChild(ep)
        Next

        Try
            doc.Save(m_FileName)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function OpenFile() As Boolean
        Dim doc As New Xml.XmlDocument
        Dim eRoot, eSetting, ep As Xml.XmlElement
        Dim i, j As Integer

        m_NewFile = False

        Try
            doc.Load(m_FileName)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        eRoot = doc.DocumentElement

        eSetting = eRoot.SelectSingleNode("setting")
        If eSetting.GetAttribute("can0") = "1" Then
            m_Can0 = True
        Else
            m_Can0 = False
        End If
        If eSetting.GetAttribute("can1") = "1" Then
            m_Can1 = True
        Else
            m_Can1 = False
        End If
        m_Bitrate = CInt(eSetting.GetAttribute("bitrate"))
        m_SerialPort.PortName = eSetting.GetAttribute("comport")

        For Each ep In eRoot.ChildNodes
            If ep.Name = "p" Then
                Dim r() As String
                ReDim r(9)
                For i = 0 To 9
                    r(i) = ep.Attributes().Item(i).Value
                Next
                m_Data.Add(r)
            End If
        Next

        Return True

    End Function

End Class
