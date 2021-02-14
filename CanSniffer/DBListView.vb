Public Class DBListView
    Inherits ListView

    Public Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        UpdateStyles()
        'SetStyle(ControlStyles.EnableNotifyMessage, True)
    End Sub

    'Protected Overrides Sub OnNotifyMessage(m As Message)
    '    If m.Msg <> &H14 Then
    '        MyBase.OnNotifyMessage(m)
    '    End If
    'End Sub

End Class
