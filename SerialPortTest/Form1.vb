Public Class Form1


    Public Delegate Sub updateDGVdelegate(r As Integer)
    Public Sub updateCount(r As Integer)
        If Me.InvokeRequired Then
            Try
                Me.Invoke(New updateDGVdelegate(AddressOf updateCount), New Object() {r})
            Catch ex As Exception
            End Try
        Else
            lblCount.Text = r
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btTest_Click(sender As Object, e As EventArgs) Handles btTest.Click
        Dim c As New Capture()
        c.setCOM("COM12")
        c.Bitrate = 500
        c.CAN0 = True
        c.CAN1 = True
        c.MainForm = Me
        c.StartCapture()
    End Sub
End Class
