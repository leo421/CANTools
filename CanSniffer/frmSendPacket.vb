Public Class frmSendPacket


    Private m_Protos As List(Of IProtocol)
    Private m_SPCtl As SendPacketControl

    Public Property Protos As List(Of IProtocol)
        Get
            Return m_Protos
        End Get
        Set(value As List(Of IProtocol))
            m_Protos = value
        End Set
    End Property

    Private Sub frmSendPacket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim proto As IProtocol
        If m_Protos.Count > 0 Then
            proto = m_Protos(0)
            m_SPCtl = proto.GetSendPacketControl()
            pnlProto.Controls.Add(m_SPCtl)

        End If
    End Sub
End Class