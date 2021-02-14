<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btGen = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tData = New System.Windows.Forms.RichTextBox()
        Me.tSource = New System.Windows.Forms.RichTextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btGen
        '
        Me.btGen.Location = New System.Drawing.Point(12, 12)
        Me.btGen.Name = "btGen"
        Me.btGen.Size = New System.Drawing.Size(75, 23)
        Me.btGen.TabIndex = 0
        Me.btGen.Text = "Gen"
        Me.btGen.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 41)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tSource)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tData)
        Me.SplitContainer1.Size = New System.Drawing.Size(895, 548)
        Me.SplitContainer1.SplitterDistance = 298
        Me.SplitContainer1.TabIndex = 1
        '
        'tData
        '
        Me.tData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tData.Location = New System.Drawing.Point(0, 0)
        Me.tData.Name = "tData"
        Me.tData.Size = New System.Drawing.Size(593, 548)
        Me.tData.TabIndex = 0
        Me.tData.Text = ""
        '
        'tSource
        '
        Me.tSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tSource.Location = New System.Drawing.Point(0, 0)
        Me.tSource.Name = "tSource"
        Me.tSource.Size = New System.Drawing.Size(298, 548)
        Me.tSource.TabIndex = 0
        Me.tSource.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 601)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.btGen)
        Me.Name = "Form1"
        Me.Text = "Create Amps Protocol"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btGen As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tSource As RichTextBox
    Friend WithEvents tData As RichTextBox
End Class
