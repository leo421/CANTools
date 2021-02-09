﻿Imports System.Windows.Forms

Public Class ProtoAmps

    Public Function Decode(row As DataGridViewRow) As String
        Dim tDetail As New System.Text.StringBuilder

        tDetail.Clear()
        tDetail.Append("Amps BLDC" + vbCrLf)
        tDetail.Append("===========================" + vbCrLf)
        tDetail.Append("序号：" + row.Cells("No").Value + vbCrLf)
        tDetail.Append("时间：" + row.Cells("Time").Value + vbCrLf)
        tDetail.Append("接口：" + row.Cells("CAN").Value + vbCrLf)
        tDetail.Append("帧ID：" + row.Cells("ID").Value + vbCrLf)
        If row.Cells("IDE").Value = "1" Then
            tDetail.Append("帧类型：扩展帧 (IDE=1)" + vbCrLf)
        Else
            tDetail.Append("帧类型：标准帧 (IDE=0)" + vbCrLf)
        End If
        tDetail.Append("数据长度：" + row.Cells("DLC").Value + vbCrLf)
        tDetail.Append("数据内容：" + row.Cells("Payload").Value + vbCrLf)

        Return tDetail.ToString

    End Function
    Public Function GetName() As String
        Return "Amps BLDC"
    End Function

End Class
