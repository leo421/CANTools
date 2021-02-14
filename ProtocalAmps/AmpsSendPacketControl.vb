Imports Newtonsoft.Json

Public Class AmpsSendPacketControl

    Private m_Data As ArrayList

    Private m_Signed As Boolean
    Private m_Len As Integer
    Private m_RW As String

    Private m_PacketData As Byte()
    Public Overrides Property PacketData As Byte()
        Get
            Return m_PacketData
        End Get
        Set(value As Byte())
            m_PacketData = value
        End Set
    End Property

    Private Sub ctl_ValueChanged(sender As Object, e As EventArgs) Handles rbReadReq.CheckedChanged, rbWriteReq.CheckedChanged, rbReadRsp.CheckedChanged, rbWriteRsp.CheckedChanged, cbAddrClass.SelectedIndexChanged, cbAddr.SelectedIndexChanged, tData.TextChanged, nudNodeID.TextChanged
        If IsNothing(m_PacketData) Then
            Exit Sub
        End If
        UpdatePacketData()
        MyBase.onPacketDataChanged()
    End Sub

    Private Sub UpdatePacketData()
        Dim d As Int32
        Dim StdID As UInt32
        If rbReadReq.Checked Then
            StdID = &H600 + nudNodeID.Value
        ElseIf rbWriteReq.Checked Then
            StdID = &H600 + nudNodeID.Value
        ElseIf rbReadRsp.Checked Then
            StdID = &H580 + nudNodeID.Value
        ElseIf rbWriteRsp.Checked Then
            StdID = &H600 + nudNodeID.Value
        End If
        Try
            Array.Copy(BitConverter.GetBytes(StdID), 0, m_PacketData, 0, 4)
        Catch ex As Exception
        End Try
        Try
            Array.Copy(BitConverter.GetBytes(Convert.ToUInt32("0", 16)), 0, m_PacketData, 8, 4)
        Catch ex As Exception
        End Try
        Try
            Array.Copy(BitConverter.GetBytes(Convert.ToUInt32("0", 16)), 0, m_PacketData, 12, 4)
        Catch ex As Exception
        End Try
        Try
            Array.Copy(BitConverter.GetBytes(Convert.ToUInt32(8)), 0, m_PacketData, 16, 4)
        Catch ex As Exception
        End Try
        Try
            Array.Copy(BitConverter.GetBytes(Convert.ToUInt32(0)), 0, m_PacketData, 20, 4)
        Catch ex As Exception
        End Try

        '数据场
        Try

            If rbReadReq.Checked Then
                m_PacketData(24 + 0) = &H40
            ElseIf rbWriteReq.Checked Then
                Select Case m_Len
                    Case 1
                        m_PacketData(24 + 0) = &H2F
                    Case 2
                        m_PacketData(24 + 0) = &H2B
                    Case 4
                        m_PacketData(24 + 0) = &H23
                End Select
            ElseIf rbReadRsp.Checked Then
                Select Case m_Len
                    Case 1
                        m_PacketData(24 + 0) = &H4F
                    Case 2
                        m_PacketData(24 + 0) = &H4B
                    Case 4
                        m_PacketData(24 + 0) = &H43
                    Case Else
                        '失败
                        m_PacketData(24 + 0) = &H80
                End Select
            ElseIf rbWriteRsp.Checked Then
                '成功
                m_PacketData(24 + 0) = &H60
                '失败
                'm_PacketData(24 + 0) = &H80
            End If

            m_PacketData(24 + 1) = Convert.ToByte(cbAddr.Text.Substring(4, 2), 16)
            m_PacketData(24 + 2) = Convert.ToByte(cbAddr.Text.Substring(2, 2), 16)
            m_PacketData(24 + 3) = Convert.ToByte(cbAddr.Text.Substring(6, 2), 16)
            For i = 0 To 3
                m_PacketData(24 + 4 + i) = 0
            Next
            Select Case m_Len
                Case 1
                    If m_Signed Then
                        If cbHex.Checked Then
                            d = Convert.ToInt32(tData.Text, 16)
                        Else
                            d = Convert.ToInt32(tData.Text, 10)
                        End If
                        If (d < -128) Or (d > 127) Then
                            MsgBox("数据超出范围[-128,127]")
                        End If
                        m_PacketData(24 + 4) = d
                    Else
                        If cbHex.Checked Then
                            m_PacketData(24 + 4) = Convert.ToByte(tData.Text, 16)
                        Else
                            m_PacketData(24 + 4) = Convert.ToByte(tData.Text, 10)
                        End If
                    End If
                Case 2
                    If m_Signed Then
                        If cbHex.Checked Then
                            Array.Copy(BitConverter.GetBytes(Convert.ToInt16(tData.Text, 16)), 0, m_PacketData, 24 + 4, 2)
                        Else
                            Array.Copy(BitConverter.GetBytes(Convert.ToInt16(tData.Text, 10)), 0, m_PacketData, 24 + 4, 2)
                        End If
                    Else
                        If cbHex.Checked Then
                            Array.Copy(BitConverter.GetBytes(Convert.ToUInt16(tData.Text, 16)), 0, m_PacketData, 24 + 4, 2)
                        Else
                            Array.Copy(BitConverter.GetBytes(Convert.ToUInt16(tData.Text, 10)), 0, m_PacketData, 24 + 4, 2)
                        End If
                    End If
                Case 4
                    If m_Signed Then
                        If cbHex.Checked Then
                            Array.Copy(BitConverter.GetBytes(Convert.ToInt32(tData.Text, 16)), 0, m_PacketData, 24 + 4, 2)
                        Else
                            Array.Copy(BitConverter.GetBytes(Convert.ToInt32(tData.Text, 10)), 0, m_PacketData, 24 + 4, 2)
                        End If
                    Else
                        If cbHex.Checked Then
                            Array.Copy(BitConverter.GetBytes(Convert.ToUInt32(tData.Text, 16)), 0, m_PacketData, 24 + 4, 2)
                        Else
                            Array.Copy(BitConverter.GetBytes(Convert.ToUInt32(tData.Text, 10)), 0, m_PacketData, 24 + 4, 2)
                        End If
                    End If
            End Select

        Catch ex As Exception
        End Try
    End Sub

    Private Sub AmpsSendPacketControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer

        ReDim m_PacketData(31)

        m_Data = JsonConvert.DeserializeObject(Of ArrayList)(My.Resources.ProtoData)
        Dim jClass As Newtonsoft.Json.Linq.JObject
        For i = 0 To m_Data.Count - 1
            jClass = m_Data(i)
            cbAddrClass.Items.Add(jClass.GetValue("table").ToString)
        Next
        cbAddrClass.SelectedIndex = 0
    End Sub

    Private Sub cbAddrClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAddrClass.SelectedIndexChanged
        Dim i As Integer

        Dim jTable, jParam As Newtonsoft.Json.Linq.JObject
        Dim jl As Newtonsoft.Json.Linq.JArray

        If cbAddrClass.SelectedIndex > -1 Then
            jTable = m_Data(cbAddrClass.SelectedIndex)
            jl = jTable.GetValue("list")
            cbAddr.Items.Clear()

            For i = 0 To jl.Count - 1
                jParam = jl(i)
                cbAddr.Items.Add("0x" & Convert.ToString(UInt32.Parse(jParam.GetValue("addr").ToString), 16).ToUpper)
            Next
            cbAddr.SelectedIndex = 0
        End If


    End Sub

    Private Sub cbAddr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAddr.SelectedIndexChanged

        Dim jTable, jParam, jProp As Newtonsoft.Json.Linq.JObject
        Dim jl As Newtonsoft.Json.Linq.JArray

        If (cbAddrClass.SelectedIndex > -1) And (cbAddr.SelectedIndex > -1) Then
            jTable = m_Data(cbAddrClass.SelectedIndex)
            jl = jTable.GetValue("list")
            jParam = jl(cbAddr.SelectedIndex)
            jProp = jParam.GetValue("prop")
            m_RW = jProp.GetValue("rw").ToString
            If (jProp.GetValue("type").ToString.Substring(2).ToUpper = "U") Then
                m_Signed = False
            Else
                m_Signed = True
            End If
            m_Len = Integer.Parse(jProp.GetValue("type").ToString.Substring(0, 2)) / 8
            tDesc.Text = Replace(jParam.GetValue("desc").ToString, vbLf, vbCrLf)
            If IsNothing(jProp.GetValue("save")) Then
                lblProperty.Text = jProp.GetValue("rw").ToString & ", " & jProp.GetValue("type").ToString
            Else
                lblProperty.Text = jProp.GetValue("rw").ToString & ", " & jProp.GetValue("type").ToString & ", " & jProp.GetValue("save").ToString
            End If
            lblUnit.Text = jParam.GetValue("unit").ToString

        End If
    End Sub

    Private Sub cbHex_Click(sender As Object, e As EventArgs) Handles cbHex.Click
        Dim d As Integer
        Try
            If Not cbHex.Checked Then
                If m_Signed Then
                    Select Case m_Len
                        Case 8
                            d = Int32.Parse(tData.Text)
                            If d < -128 Or d > 127 Then
                                Throw New Exception("数据超出范围[-128,127]")
                            End If
                            tData.Text = Convert.ToString(Int32.Parse(tData.Text), 16).ToUpper
                        Case 16
                            tData.Text = Convert.ToString(Int16.Parse(tData.Text), 16).ToUpper
                        Case 32
                            tData.Text = Convert.ToString(Int32.Parse(tData.Text), 16).ToUpper
                    End Select
                Else
                    Select Case m_Len
                        Case 8
                            tData.Text = Convert.ToString(Byte.Parse(tData.Text), 16).ToUpper
                        Case 16
                            tData.Text = Convert.ToString(UInt16.Parse(tData.Text), 16).ToUpper
                        Case 32
                            tData.Text = Convert.ToString(UInt32.Parse(tData.Text), 16).ToUpper
                    End Select
                End If
            Else
                If m_Signed Then
                    Select Case m_Len
                        Case 8
                            d = Convert.ToInt32(tData.Text, 16)
                            If d < -128 Or d > 127 Then
                                Throw New Exception("数据超出范围[-128,127]")
                            End If
                            tData.Text = d
                        Case 16
                            tData.Text = Convert.ToInt16(tData.Text, 16)
                        Case 32
                            tData.Text = Convert.ToInt32(tData.Text, 16)
                    End Select
                Else
                    Select Case m_Len
                        Case 8
                            tData.Text = Convert.ToByte(tData.Text, 16)
                        Case 16
                            tData.Text = Convert.ToUInt16(tData.Text, 16)
                        Case 32
                            tData.Text = Convert.ToUInt32(tData.Text, 16)
                    End Select
                End If
            End If

            cbHex.Checked = Not cbHex.Checked
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
