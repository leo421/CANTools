Imports System.Windows.Forms
Imports CanSniffer
Imports Newtonsoft.Json

Public Class Protocol
    Implements IProtocol

    Private m_Data As ArrayList

    Public Sub New()
        m_Data = JsonConvert.DeserializeObject(Of ArrayList)(My.Resources.ProtoData)
    End Sub

    Private m_Table As String
    Private m_Desc As String
    Private m_Title As String
    Private m_rw As String
    Private m_type As String
    Private m_save As String
    Private m_unit As String
    Private Function GetAmpsObject(idx As Integer) As String
        Dim i, j As Integer
        'Dim sTable As String
        'Dim sDesc, sTitle As String
        'Dim rw, type, save, unit As String
        Dim jClass, jParam, jProp As Newtonsoft.Json.Linq.JObject
        Dim jl As Newtonsoft.Json.Linq.JArray

        For i = 0 To m_Data.Count - 1
            jClass = m_Data(i)
            jl = jClass.GetValue("list")
            For j = 0 To jl.Count - 1
                jParam = jl(j)
                If CInt(jParam.GetValue("addr").ToString) = idx Then
                    m_Table = jClass.GetValue("table").ToString.Trim()
                    m_unit = jParam.GetValue("unit").ToString
                    m_Desc = jParam.GetValue("desc").ToString
                    jProp = jParam.GetValue("prop")
                    m_rw = jProp.GetValue("rw")
                    m_type = jProp.GetValue("type")
                    m_save = jProp.GetValue("save")
                    m_Title = Split(m_Desc, vbLf)(0).Trim()
                    Return "（" & m_Table & " - " & m_Title & "）" & vbCrLf _
                        & "对象属性：" & m_rw & "," & m_type & "," & m_save & vbCrLf _
                        & "    单位：" & m_unit & vbCrLf _
                        & "    描述：" & Replace(m_Desc, vbLf, vbCrLf & Space(10)) & vbCrLf
                End If
            Next
        Next
        Return "(未知)" + vbCrLf
    End Function

    Public Function Decode(row As ListViewItem) As String Implements IProtocol.Decode
        Dim i As Integer
        Dim tDetail As New System.Text.StringBuilder
        Dim sAction As String = ""
        Dim ss As String()
        Dim payload As Byte()
        Dim d As Integer
        Dim s16 As Int16
        Dim u16 As UInt16
        Dim s32 As Int32
        Dim u32 As UInt32

        ReDim payload(7)

        tDetail.Clear()
        tDetail.Append("Amps BLDC" + vbCrLf)
        tDetail.Append("==基本信息=============================" + vbCrLf)
        'tDetail.Append("序号：" + row.Cells("No").Value + vbCrLf)
        tDetail.Append("序号：" + row.SubItems(0).Text + vbCrLf)
        'tDetail.Append("时间：" + row.Cells("Time").Value + vbCrLf)
        tDetail.Append("时间：" + row.SubItems(1).Text + vbCrLf)
        'tDetail.Append("接口：" + row.Cells("CAN").Value + vbCrLf)
        tDetail.Append("接口：" + row.SubItems(2).Text + vbCrLf)
        'tDetail.Append("帧ID：" + row.Cells("ID").Value + vbCrLf)
        tDetail.Append("帧ID：" + row.SubItems(5).Text + vbCrLf)
        If row.SubItems(6).Text = "4" Then
            tDetail.Append("帧格式：扩展帧 (IDE=4)" + vbCrLf)
        ElseIf row.SubItems(6).Text = "0" Then
            tDetail.Append("帧格式：标准帧 (IDE=0)" + vbCrLf)
        Else
            tDetail.Append("帧格式：未知 (IDE=" + row.SubItems(6).Text + ")" + vbCrLf)
        End If
        If row.SubItems(7).Text = "2" Then
            tDetail.Append("帧类型：远程帧 (RTR=2)" + vbCrLf)
        ElseIf row.SubItems(7).Text = "0" Then
            tDetail.Append("帧类型：数据帧 (RTR=0)" + vbCrLf)
        Else
            tDetail.Append("帧类型：未知 (RTR=" + row.SubItems(7).Text + ")" + vbCrLf)
        End If
        tDetail.Append("数据长度：" + row.SubItems(8).Text + vbCrLf)
        tDetail.Append("数据内容：" + row.SubItems(9).Text + vbCrLf)

        tDetail.Append(vbCrLf + "==协议信息=============================" + vbCrLf)

        ss = Split(row.SubItems(9).Text, " ")

        If (row.SubItems(8).Text <> "8") _
            Or (ss.Length <> 8) _
        Then
            tDetail.Append("无法解析！" + vbCrLf)
            Return tDetail.ToString
        End If

        For i = 0 To 7
            payload(i) = Convert.ToByte(ss(i), 16)
        Next

        tDetail.Append("    站号：" + CStr(Convert.ToInt32(row.SubItems(5).Text.Substring(2), 16) And 15) + vbCrLf)

        Dim idx As Integer
        idx = payload(2)
        idx = (idx * 256 + payload(1)) * 256 + payload(3)
        tDetail.Append("数据对象：0x" + Convert.ToString(idx, 16).ToUpper() + " " + GetAmpsObject(idx))

        If (Convert.ToInt32(row.SubItems(5).Text.Substring(2), 16) And &H7FFFFFF0) = &H600 Then
            '请求
            If payload(0) = &H40 Then
                '读请求
                tDetail.Append("    操作：读取请求" + vbCrLf)
            ElseIf payload(0) = &H2F Then
                '写1个字节请求
                tDetail.Append("    操作：写入请求（1个字节）" + vbCrLf)
                If Right(m_type, 1) = "S" Then
                    d = payload(4)
                    If d > 127 Then
                        d = d - 256
                    End If
                    tDetail.Append("    数据：" + CStr(d) + "（0x" + Convert.ToString(payload(4), 16) + "）" + vbCrLf)
                Else
                    tDetail.Append("    数据：" + CStr(payload(4)) + "（0x" + Convert.ToString(payload(4), 16) + "）" + vbCrLf)
                End If
            ElseIf payload(0) = &H2B Then
                '写2个字节请求
                tDetail.Append("    操作：写入请求（2个字节）" + vbCrLf)
                If Right(m_type, 1) = "S" Then
                    s16 = BitConverter.ToInt16(payload, 4)
                    tDetail.Append("    数据：" + CStr(s16) + "（0x" + Convert.ToString(s16, 16) + "）" + vbCrLf)
                Else
                    u16 = BitConverter.ToUInt16(payload, 4)
                    tDetail.Append("    数据：" + CStr(u16) + "（0x" + Convert.ToString(u16, 16) + "）" + vbCrLf)
                End If
            ElseIf payload(0) = &H23 Then
                '写4个字节请求
                tDetail.Append("    操作：写入请求（4个字节）" + vbCrLf)
                If Right(m_type, 1) = "S" Then
                    s32 = BitConverter.ToInt32(payload, 4)
                    tDetail.Append("    数据：" + CStr(s32) + "（0x" + Convert.ToString(s32, 16) + "）" + vbCrLf)
                Else
                    u32 = BitConverter.ToUInt32(payload, 4)
                    tDetail.Append("    数据：" + CStr(u32) + "（0x" + Convert.ToString(u32, 16) + "）" + vbCrLf)
                End If
            Else
                tDetail.Append("无法解析！" + vbCrLf)
                Return tDetail.ToString
            End If
        ElseIf (Convert.ToInt32(row.SubItems(5).Text.Substring(2), 16) And &H7FFFFFF0) = &H580 Then
            '响应
            If payload(0) = &H4F Then
                '收到响应1个字节数据
                tDetail.Append("    操作：读取响应（1个字节）" + vbCrLf)
                If Right(m_type, 1) = "S" Then
                    d = payload(4)
                    If d > 127 Then
                        d = d - 256
                    End If
                    tDetail.Append("    数据：" + CStr(d) + "（0x" + Convert.ToString(payload(4), 16) + "）" + vbCrLf)
                Else
                    tDetail.Append("    数据：" + CStr(payload(4)) + "（0x" + Convert.ToString(payload(4), 16) + "）" + vbCrLf)
                End If
            ElseIf payload(0) = &H4B Then
                '收到响应2个字节数据
                tDetail.Append("    操作：读取响应（2个字节）" + vbCrLf)
                If Right(m_type, 1) = "S" Then
                    s16 = BitConverter.ToInt16(payload, 4)
                    tDetail.Append("    数据：" + CStr(s16) + "（0x" + Convert.ToString(s16, 16) + "）" + vbCrLf)
                Else
                    u16 = BitConverter.ToUInt16(payload, 4)
                    tDetail.Append("    数据：" + CStr(u16) + "（0x" + Convert.ToString(u16, 16) + "）" + vbCrLf)
                End If
            ElseIf payload(0) = &H43 Then
                '收到响应4个字节数据
                tDetail.Append("    操作：读取响应（4个字节）" + vbCrLf)
                If Right(m_type, 1) = "S" Then
                    s32 = BitConverter.ToInt32(payload, 4)
                    tDetail.Append("    数据：" + CStr(s32) + "（0x" + Convert.ToString(s32, 16) + "）" + vbCrLf)
                Else
                    u32 = BitConverter.ToUInt32(payload, 4)
                    tDetail.Append("    数据：" + CStr(u32) + "（0x" + Convert.ToString(u32, 16) + "）" + vbCrLf)
                End If
            ElseIf payload(0) = &H60 Then
                '写数据成功
                tDetail.Append("    操作：写入成功" + vbCrLf)
                If Left(m_type, 2) = "08" Then
                    If Right(m_type, 1) = "S" Then
                        d = payload(4)
                        If d > 127 Then
                            d = d - 256
                        End If
                        tDetail.Append("    数据：" + CStr(d) + "（0x" + Convert.ToString(payload(4), 16) + "）" + vbCrLf)
                    Else
                        tDetail.Append("    数据：" + CStr(payload(4)) + "（0x" + Convert.ToString(payload(4), 16) + "）" + vbCrLf)
                    End If
                ElseIf Left(m_type, 2) = "16" Then
                    If Right(m_type, 1) = "S" Then
                        s16 = BitConverter.ToInt16(payload, 4)
                        tDetail.Append("    数据：" + CStr(s16) + "（0x" + Convert.ToString(s16, 16) + "）" + vbCrLf)
                    Else
                        u16 = BitConverter.ToUInt16(payload, 4)
                        tDetail.Append("    数据：" + CStr(u16) + "（0x" + Convert.ToString(u16, 16) + "）" + vbCrLf)
                    End If
                ElseIf Left(m_type, 2) = "32" Then
                    If Right(m_type, 1) = "S" Then
                        s32 = BitConverter.ToInt32(payload, 4)
                        tDetail.Append("    数据：" + CStr(s32) + "（0x" + Convert.ToString(s32, 16) + "）" + vbCrLf)
                    Else
                        u32 = BitConverter.ToUInt32(payload, 4)
                        tDetail.Append("    数据：" + CStr(u32) + "（0x" + Convert.ToString(u32, 16) + "）" + vbCrLf)
                    End If
                End If
            ElseIf payload(0) = &H80 Then
                '写数据失败
                tDetail.Append("    操作：写入失败" + vbCrLf)
                If Left(m_type, 2) = "08" Then
                    If Right(m_type, 1) = "S" Then
                        d = payload(4)
                        If d > 127 Then
                            d = d - 256
                        End If
                        tDetail.Append("    数据：" + CStr(d) + "（0x" + Convert.ToString(payload(4), 16) + "）" + vbCrLf)
                    Else
                        tDetail.Append("    数据：" + CStr(payload(4)) + "（0x" + Convert.ToString(payload(4), 16) + "）" + vbCrLf)
                    End If
                ElseIf Left(m_type, 2) = "16" Then
                    If Right(m_type, 1) = "S" Then
                        s16 = BitConverter.ToInt16(payload, 4)
                        tDetail.Append("    数据：" + CStr(s16) + "（0x" + Convert.ToString(s16, 16) + "）" + vbCrLf)
                    Else
                        u16 = BitConverter.ToUInt16(payload, 4)
                        tDetail.Append("    数据：" + CStr(u16) + "（0x" + Convert.ToString(u16, 16) + "）" + vbCrLf)
                    End If
                ElseIf Left(m_type, 2) = "32" Then
                    If Right(m_type, 1) = "S" Then
                        s32 = BitConverter.ToInt32(payload, 4)
                        tDetail.Append("    数据：" + CStr(s32) + "（0x" + Convert.ToString(s32, 16) + "）" + vbCrLf)
                    Else
                        u32 = BitConverter.ToUInt32(payload, 4)
                        tDetail.Append("    数据：" + CStr(u32) + "（0x" + Convert.ToString(u32, 16) + "）" + vbCrLf)
                    End If
                End If
            End If
        Else
            tDetail.Append("无法解析！" + vbCrLf)
            Return tDetail.ToString
        End If

        'tDetail.Append("操作：" + sAction + vbCrLf)

        Return tDetail.ToString

    End Function

    Public Function GetName() As String Implements IProtocol.GetName
        Return "Amps BLDC"
    End Function

    Public Function GetObject() As IProtocol Implements IProtocol.GetObject
        Return Me
    End Function

    Public Function GetSendPacketControl() As SendPacketControl Implements IProtocol.GetSendPacketControl
        Return New AmpsSendPacketControl()
    End Function
End Class
