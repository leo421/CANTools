Public Class frmInterfaces
    Private Sub frmInterfaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ssNames As String()

        Dim search As System.Management.ManagementObjectSearcher
        Dim o As System.Management.ManagementObject

        search = New System.Management.ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity  WHERE Name LIKE '%COM%'")

        For Each o In search.Get
            cbCOM.Items.Add(o.Item("Name"))
        Next



        'ssNames = System.IO.Ports.SerialPort.GetPortNames()
        'cbCOM.Items.Clear()
        'For i = 0 To ssNames.Length - 1
        '    cbCOM.Items.Add(ssNames(i))
        'Next
        'cbCOM.SelectedIndex = 0

    End Sub
End Class