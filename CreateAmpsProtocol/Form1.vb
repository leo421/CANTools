
Public Class Form1
    Private Sub btGen_Click(sender As Object, e As EventArgs) Handles btGen.Click
        Dim ss As String()
        Dim sss As String()
        Dim i As Integer
        Dim protolist As New ArrayList
        Dim p As Proto

        Dim t As ArrayList


        'ss = tSource.Text.Split(CType(vbLf & vbLf, Char()), StringSplitOptions.None)
        ss = Split(tSource.Text, vbLf & vbLf)
        For i = 0 To ss.Length / 5 - 1
            p = New Proto()
            p.addr = Convert.ToInt32(ss(i * 5 + 1).Substring(2).Trim, 16)
            p.prop = New Properties
            sss = ss(i * 5 + 2).Split(",")
            p.prop.type = sss(0).Trim
            p.prop.rw = sss(1).Trim
            p.prop.save = Nothing
            If sss.Length > 2 Then
                p.prop.save = sss(2).Trim
            End If
            p.unit = ss(i * 5 + 3).Trim
            p.desc = ss(i * 5 + 4).Trim
            protolist.Add(p)
        Next

        tData.Text = Newtonsoft.Json.JsonConvert.SerializeObject(protolist, Newtonsoft.Json.Formatting.Indented)

        t = Newtonsoft.Json.JsonConvert.DeserializeObject(Of ArrayList)(tData.Text)
        Debug.Print(t.Count)

        Newtonsoft.Json.JsonConvert.DeserializeObject()

    End Sub

    Public Class Proto
        Public addr As Integer
        Public prop As Properties
        Public unit As String
        Public desc As String
    End Class

    Public Class Properties
        Public rw As String
        Public type As String
        Public save As String
    End Class
End Class
