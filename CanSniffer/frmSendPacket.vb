Public Class frmSendPacket

    Private m_SendCount As Integer = 0

    Private m_Protos As List(Of IProtocol)
    Private m_SPCtl As SendPacketControl = Nothing
    Private m_Captures As ArrayList

    Private m_COM As String = ""
    Public Property COM As String
        Get
            Return m_COM
        End Get
        Set(value As String)
            m_COM = value
        End Set
    End Property

    Public Property Captures As ArrayList
        Get
            Return m_Captures
        End Get
        Set(value As ArrayList)
            m_Captures = value
        End Set
    End Property

    Public Property Protos As List(Of IProtocol)
        Get
            Return m_Protos
        End Get
        Set(value As List(Of IProtocol))
            m_Protos = value
        End Set
    End Property

    Private Sub frmSendPacket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer

        Dim proto As IProtocol
        For Each proto In m_Protos
            cbProtocol.Items.Add(proto.GetName())
        Next
        If m_Protos.Count > 0 Then
            cbProtocol.SelectedIndex = 0
            For i = 0 To cbProtocol.Items.Count - 1
                If cbProtocol.Items.Item(i).ToString = "通用协议" Then
                    cbProtocol.SelectedIndex = i
                    Exit For
                End If
            Next
        End If

        Dim search As System.Management.ManagementObjectSearcher
        Dim o As System.Management.ManagementObject
        search = New System.Management.ManagementObjectSearcher("SELECT * FROM Win32_SerialPort  WHERE Name LIKE '%STM%' OR Name LIKE '%USB%'")
        For Each o In search.Get
            cbCOM.Items.Add(o.Item("Name"))
        Next
        If cbCOM.Items.Count > 0 Then
            If m_COM = "" Then
                cbCOM.SelectedIndex = 0
            Else
                For i = 0 To cbCOM.Items.Count - 1
                    If cbCOM.Items(i).ToString.Contains("(" + m_COM + ")") Then
                        cbCOM.SelectedIndex = i
                        Exit For
                    End If
                Next
                If cbCOM.SelectedIndex = -1 Then
                    cbCOM.SelectedIndex = 0
                End If
            End If
        End If



    End Sub

    Private Sub cbAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbAll.CheckedChanged
        Dim search As System.Management.ManagementObjectSearcher
        Dim o As System.Management.ManagementObject

        If cbAll.Checked Then
            search = New System.Management.ManagementObjectSearcher("SELECT * FROM Win32_SerialPort WHERE Name LIKE '%(COM%'")
        Else
            search = New System.Management.ManagementObjectSearcher("SELECT * FROM Win32_SerialPort  WHERE Name LIKE '%STM%' OR Name LIKE '%USB%'")
        End If

        cbCOM.Items.Clear()

        For Each o In search.Get
            cbCOM.Items.Add(o.Item("Name"))
        Next

        If cbCOM.Items.Count > 0 Then
            cbCOM.SelectedIndex = 0
        End If

    End Sub

    Private Sub cbProtocol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProtocol.SelectedIndexChanged
        Dim proto As IProtocol

        If Not IsNothing(m_SPCtl) Then
            RemoveHandler m_SPCtl.PacketDataChanged, AddressOf SPCtl_PacketDataChanged
            pnlProto.Controls.Remove(m_SPCtl)
        End If

        If m_Protos.Count > 0 Then
            proto = m_Protos(cbProtocol.SelectedIndex)
            Try
                m_SPCtl = proto.GetSendPacketControl()
                pnlProto.Controls.Add(m_SPCtl)
                If (m_SPCtl.Width - pnlProto.Width) > 0 Then
                    Me.Width += m_SPCtl.Width - pnlProto.Width
                End If
                If (m_SPCtl.Height - pnlProto.Height) > 0 Then
                    Me.Height += m_SPCtl.Height - pnlProto.Height
                End If
                AddHandler m_SPCtl.PacketDataChanged, AddressOf SPCtl_PacketDataChanged
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub SPCtl_PacketDataChanged(sender As Object, e As EventArgs)
        'Dim i As Integer
        'Dim h As String
        'Dim sb As New System.Text.StringBuilder
        'Dim ctl As SendPacketControl
        'ctl = sender

        'For i = 0 To ctl.PacketData.Length - 1
        '    h = Hex(ctl.PacketData(i))
        '    If h.Length < 2 Then
        '        h = "0" + h
        '    End If
        '    sb.Append(h + " ")
        'Next
        'tData.Text = sb.ToString
        Dim stdid, extid As UInt32
        Dim sb As New System.Text.StringBuilder
        Dim s As String

        stdid = BitConverter.ToUInt32(m_SPCtl.PacketData, 0)
        sb.Append("  StdID：" + "0x" + Convert.ToString(stdid, 16) + vbCrLf)

        extid = BitConverter.ToUInt32(m_SPCtl.PacketData, 4)
        sb.Append("  ExtID：" + "0x" + Convert.ToString(extid, 16) + vbCrLf)

        If BitConverter.ToUInt32(m_SPCtl.PacketData, 8) = 0 Then
            '标准帧
            sb.Append("    IDE：0 (标准帧)" + vbCrLf)
            sb.Append("     ID：" + "0x" + Convert.ToString(stdid, 16) + vbCrLf)
        ElseIf BitConverter.ToUInt32(m_SPCtl.PacketData, 8) = 4 Then
            '扩展帧
            sb.Append("    IDE：4 (扩展帧)" + vbCrLf)
            s = Convert.ToString(extid, 2)
            If s.Length < 18 Then
                s = Space(18 - s.Length).Replace(" ", "0") + s
            End If
            s = Convert.ToString(stdid, 2) + s
            s = Convert.ToString(Convert.ToUInt32(s, 2), 16)
            If s.Length < 8 Then
                s = Space(8 - s.Length).Replace(" ", "0") + s
            End If
            sb.Append("     ID：" + "0x" + s + vbCrLf)
        End If

        If BitConverter.ToUInt32(m_SPCtl.PacketData, 12) = 0 Then
            '数据帧
            sb.Append("    RTR：0 (数据帧)" + vbCrLf)
        ElseIf BitConverter.ToUInt32(m_SPCtl.PacketData, 12) = 2 Then
            '远程帧
            sb.Append("    RTR：2 (远程帧)" + vbCrLf)
        End If

        sb.Append("    DLC：" + Convert.ToString(BitConverter.ToUInt32(m_SPCtl.PacketData, 16), 10) + vbCrLf)

        sb.Append("Payload：")
        For i = 0 To 7
            s = Hex(m_SPCtl.PacketData(24 + i))
            If s.Length < 2 Then
                s = "0" + s
            End If
            sb.Append(s + " ")
        Next



        tData.Text = sb.ToString
    End Sub

    Private Sub btSend_Click(sender As Object, e As EventArgs) Handles btSend.Click
        Dim cap As Capture = Nothing
        Dim packetdata As Byte()

        '查找可用通道
        For Each cap In m_Captures
            If cbCOM.Items(cbCOM.SelectedIndex).ToString.Contains("(" + cap.SerialPort.PortName + ")") Then
                If cap.State = CanSniffer.Capture.CAPTURE_STATE.RUNNING Then
                    Exit For
                End If
            End If
        Next
        If IsNothing(cap) Then
            MsgBox("没有可用的通道。请先开启相应通道的捕获操作。")
            Exit Sub
        End If

        '组织数据
        ReDim packetdata(42)
        Array.Copy(BitConverter.GetBytes(&H55AA), 0, packetdata, 0, 2)
        packetdata(2) = 40
        packetdata(3) = 7
        packetdata(4) = 0
        packetdata(5) = 1
        packetdata(6) = 1
        packetdata(7) = 1
        packetdata(8) = 1
        Array.Copy(m_SPCtl.PacketData, 0, packetdata, 9, 32)
        packetdata(41) = 0
        packetdata(42) = 0

        '发送数据
        Try
            cap.SendPacket(packetdata)
            m_SendCount += 1
            lblMsg.Text = "数据包发送成功 #" & m_SendCount
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class