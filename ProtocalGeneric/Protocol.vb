Imports System.Windows.Forms
Imports CanSniffer
Public Class Protocol
    Implements IProtocol

    Public Function Decode(row As DataGridViewRow) As String Implements IProtocol.Decode
        Dim tDetail As New System.Text.StringBuilder

        tDetail.Clear()
        tDetail.Append("通用协议" + vbCrLf)
        tDetail.Append("===========================" + vbCrLf)
        tDetail.Append("序号：" + row.Cells("No").Value + vbCrLf)
        tDetail.Append("时间：" + row.Cells("Time").Value + vbCrLf)
        tDetail.Append("接口：" + row.Cells("CAN").Value + vbCrLf)
        tDetail.Append("帧ID：" + row.Cells("ID").Value + vbCrLf)
        If row.Cells("IDE").Value = "4" Then
            tDetail.Append("帧格式：扩展帧 (IDE=4)" + vbCrLf)
        ElseIf row.Cells("IDE").Value = "0" Then
            tDetail.Append("帧格式：标准帧 (IDE=0)" + vbCrLf)
        Else
            tDetail.Append("帧格式：未知 (IDE=" + row.Cells("IDE").Value + ")" + vbCrLf)
        End If
        If row.Cells("RTR").Value = "2" Then
            tDetail.Append("帧类型：远程帧 (RTR=2)" + vbCrLf)
        ElseIf row.Cells("RTR").Value = "0" Then
            tDetail.Append("帧类型：数据帧 (RTR=0)" + vbCrLf)
        Else
            tDetail.Append("帧类型：未知 (RTR=" + row.Cells("RTR").Value + ")" + vbCrLf)
        End If
        tDetail.Append("数据长度：" + row.Cells("DLC").Value + vbCrLf)
        tDetail.Append("数据内容：" + row.Cells("Payload").Value + vbCrLf)

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
