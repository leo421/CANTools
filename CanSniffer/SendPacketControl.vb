Public Class SendPacketControl

    Public Event PacketDataChanged(sender As Object, e As EventArgs)
    Public Overridable Property PacketData As Byte()

End Class
