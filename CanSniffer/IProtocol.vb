Public Interface IProtocol
    Function Decode(row As DataGridViewRow) As String
    Function GetName() As String
    Function GetObject() As IProtocol
    Function GetSendPacketControl() As SendPacketControl

End Interface
