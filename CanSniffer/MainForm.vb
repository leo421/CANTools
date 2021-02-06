Public Class MainForm

    Private m_dt As DataTable
    Private Sub miNew_Click(sender As Object, e As EventArgs) Handles miNew.Click
        Dim r As DataRow


        m_dt = New DataTable()
        With m_dt
            .Columns.Add("No")
            .Columns.Add("Time")
            .Columns.Add("CAN")
            .Columns.Add("StdId")
            .Columns.Add("ExtId")
            .Columns.Add("IDE")
            .Columns.Add("RTR")
            .Columns.Add("DLC")
            .Columns.Add("Payload")
        End With


        r = m_dt.NewRow()
        r("No") = "1"
        r("Time") = "2021-02-06 17:57:27.234"
        r("CAN") = "0"
        r("StdId") = "0x602"
        r("ExtId") = "0x035"
        r("IDE") = "0"
        r("RTR") = "0"
        r("DLC") = 8
        r("Payload") = "f6 00 35 24 43 00 40 43"
        m_dt.Rows.Add(r)

        r = m_dt.NewRow()
        r("No") = "2"
        r("Time") = "2021-02-06 17:57:27.234"
        r("CAN") = "0"
        r("StdId") = "0x602"
        r("ExtId") = "0x035"
        r("IDE") = "0"
        r("RTR") = "0"
        r("DLC") = 8
        r("Payload") = "f6 00 35 24 43 00 40 43"
        m_dt.Rows.Add(r)

        DGV.DataSource = m_dt

        For Each c As DataGridViewColumn In DGV.Columns
            c.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

    End Sub

    Private Sub miSelectInterface_Click(sender As Object, e As EventArgs) Handles miSelectInterface.Click
        Dim fInf As frmInterfaces
        fInf = New frmInterfaces()
        fInf.ShowDialog()


    End Sub
End Class