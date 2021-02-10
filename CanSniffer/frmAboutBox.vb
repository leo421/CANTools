Public NotInheritable Class frmAboutBox

    Private m_Protos As List(Of IProtocol)
    Public Property Protos As List(Of IProtocol)
        Get
            Return m_Protos
        End Get
        Set(value As List(Of IProtocol))
            m_Protos = value
        End Set
    End Property

    Private Sub frmAboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 设置此窗体的标题。
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("关于 {0}", ApplicationTitle)

        Dim proto As IProtocol
        Dim sb As New System.Text.StringBuilder
        sb.Append("已加载插件：" + vbCrLf)
        For Each proto In m_Protos
            With sb
                .Append(vbCrLf + "  " + proto.GetName + vbCrLf)
            End With
        Next
        tDesc.Text = sb.ToString

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
