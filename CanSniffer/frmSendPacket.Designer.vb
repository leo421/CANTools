﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendPacket
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlProto = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnlProto
        '
        Me.pnlProto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlProto.BackColor = System.Drawing.Color.White
        Me.pnlProto.Location = New System.Drawing.Point(12, 160)
        Me.pnlProto.Name = "pnlProto"
        Me.pnlProto.Size = New System.Drawing.Size(496, 286)
        Me.pnlProto.TabIndex = 0
        '
        'frmSendPacket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 458)
        Me.Controls.Add(Me.pnlProto)
        Me.Name = "frmSendPacket"
        Me.Text = "发送数据包"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlProto As Panel
End Class
