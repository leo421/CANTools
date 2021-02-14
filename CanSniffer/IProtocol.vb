Public Interface IProtocol
    Function Decode(row As ListViewItem) As String
    Function GetName() As String
    Function GetObject() As IProtocol
    Function GetSendPacketControl() As SendPacketControl

End Interface
