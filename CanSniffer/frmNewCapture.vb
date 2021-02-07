Public Class frmNewCapture

    Public ComPort As String
    Public Can0 As Boolean
    Public Can1 As Boolean
    Public Bitrate As Integer

    Private Sub tBps_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (e.KeyChar <> "8") And (Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmNewCapture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim ssNames As String()

        Dim search As System.Management.ManagementObjectSearcher
        Dim o As System.Management.ManagementObject

        'search = New System.Management.ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity  WHERE Name LIKE '%STMicroelectronics Virtual COM Port%'")
        search = New System.Management.ManagementObjectSearcher("SELECT * FROM Win32_SerialPort  WHERE Name LIKE '%STMicroelectronics Virtual COM Port%'")

        For Each o In search.Get
            cbCOM.Items.Add(o.Item("Name"))
        Next

        If cbCOM.Items.Count > 0 Then
            cbCOM.SelectedIndex = 0
        End If

        cbBps.SelectedIndex = 0

    End Sub

    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOK.Click
        If Not (cbCan0.Checked Or cbCan0.Checked) Then
            MsgBox("请至少选择一个CAN接口！")
            Exit Sub
        End If

        Me.DialogResult = DialogResult.OK
        ComPort = cbCOM.SelectedItem.ToString.Split(New Char() {"(", ")"})(1)
        Can0 = cbCan0.Checked
        Can1 = cbCan1.Checked
        Bitrate = CInt(cbBps.Text)
        Close()
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class