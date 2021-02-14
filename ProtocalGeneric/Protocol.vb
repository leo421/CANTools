Imports System.Windows.Forms
Imports CanSniffer
Public Class Protocol
    Implements IProtocol

    Public Function Decode(row As ListViewItem) As String Implements IProtocol.Decode
        Dim tDetail As New System.Text.StringBuilder

        tDetail.Clear()
        tDetail.Append("通用协议" + vbCrLf)
        tDetail.Append("===========================" + vbCrLf)
        tDetail.Append("序号：" + row.SubItems(0).Text + vbCrLf)
        tDetail.Append("时间：" + row.SubItems(1).Text + vbCrLf)
        tDetail.Append("接口：" + row.SubItems(2).Text + vbCrLf)
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

        Return tDetail.ToString

    End Function

    Public Function GetName() As String Implements IProtocol.GetName
        Return "通用协议"
    End Function

    Public Function GetObject() As IProtocol Implements IProtocol.GetObject
        Return Me
    End Function

    Public Function GetSendPacketControl() As SendPacketControl Implements IProtocol.GetSendPacketControl
        Return New GenericSendPacketControl()
    End Function
End Class
