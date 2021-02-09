Public Interface IProtocal
    Function Decode(row As DataGridViewRow) As String
    Function GetName() As String
    Function GetObject() As IProtocal

End Interface
