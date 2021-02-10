Imports CanSniffer

Public Class GenericSendPacketControl

    Private m_PacketData As Byte()
    Public Overrides Property PacketData As Byte()
        Get
            Return m_PacketData
        End Get
        Set(value As Byte())
            m_PacketData = value
        End Set
    End Property

    Private Sub ctl_ValueChanged(sender As Object, e As EventArgs) Handles rbStd.CheckedChanged, rbExt.CheckedChanged, rbData.CheckedChanged, rbRemote.CheckedChanged, rbError.CheckedChanged, rbOverload.CheckedChanged, rbSpace.CheckedChanged, tStdID.TextChanged, tExtID.TextChanged, tPayload.TextChanged, nudDataLength.ValueChanged
        UpdatePacketData()
        MyBase.onPacketDataChanged()
    End Sub

    Private Sub UpdatePacketData()
        Try
            Array.Copy(BitConverter.GetBytes(Convert.ToUInt32(tStdID.Text, 16)), 0, m_PacketData, 0, 4)
        Catch ex As Exception
        End Try
        Try
            Array.Copy(BitConverter.GetBytes(Convert.ToUInt32(tExtID.Text, 16)), 0, m_PacketData, 4, 4)
        Catch ex As Exception
        End Try
        Try
            If rbStd.Checked Then
                Array.Copy(BitConverter.GetBytes(Convert.ToUInt32("0", 16)), 0, m_PacketData, 8, 4)
            Else
                Array.Copy(BitConverter.GetBytes(Convert.ToUInt32("4", 16)), 0, m_PacketData, 8, 4)
            End If
        Catch ex As Exception
        End Try
        Try
            If rbData.Checked Then
                Array.Copy(BitConverter.GetBytes(Convert.ToUInt32("0", 16)), 0, m_PacketData, 12, 4)
            ElseIf rbRemote.Checked Then
                Array.Copy(BitConverter.GetBytes(Convert.ToUInt32("2", 16)), 0, m_PacketData, 12, 4)
            End If
        Catch ex As Exception
        End Try
        Try
            Array.Copy(BitConverter.GetBytes(Convert.ToUInt32(nudDataLength.Value)), 0, m_PacketData, 16, 4)
        Catch ex As Exception
        End Try
        Try
            Array.Copy(BitConverter.GetBytes(Convert.ToUInt32(0)), 0, m_PacketData, 20, 4)
        Catch ex As Exception
        End Try
        Try

            Dim ss As String()
            Dim s As Integer
            Dim i, j As Integer
            ss = Split(tPayload.Text, " ")
            j = 0
            For i = 0 To ss.Length - 1
                If ss(i).Length > 0 Then
                    If j < 8 Then
                        m_PacketData(24 + j) = CByte("&h" + ss(i))
                        j += 1
                    End If
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GenericSendPacketControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim m_PacketData(31)
    End Sub

End Class
