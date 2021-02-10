Public Class SendPacketControl

    Public Event PacketDataChanged(sender As Object, e As EventArgs)
    Public Overridable Property PacketData As Byte()

    Protected Sub onPacketDataChanged()
        RaiseEvent PacketDataChanged(Me, Nothing)
    End Sub

End Class
