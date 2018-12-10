<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btnPasteTextV1 = New System.Windows.Forms.Button()
        Me.btnViewData = New System.Windows.Forms.Button()
        Me.btnPasteTextV2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPasteTextV1
        '
        Me.btnPasteTextV1.Location = New System.Drawing.Point(12, 12)
        Me.btnPasteTextV1.Name = "btnPasteTextV1"
        Me.btnPasteTextV1.Size = New System.Drawing.Size(113, 53)
        Me.btnPasteTextV1.TabIndex = 0
        Me.btnPasteTextV1.Text = "Pegar datos desde el portapapeles V1"
        Me.btnPasteTextV1.UseVisualStyleBackColor = True
        '
        'btnViewData
        '
        Me.btnViewData.Location = New System.Drawing.Point(250, 12)
        Me.btnViewData.Name = "btnViewData"
        Me.btnViewData.Size = New System.Drawing.Size(113, 53)
        Me.btnViewData.TabIndex = 1
        Me.btnViewData.Text = "Verificar Datos"
        Me.btnViewData.UseVisualStyleBackColor = True
        '
        'btnPasteTextV2
        '
        Me.btnPasteTextV2.Location = New System.Drawing.Point(131, 12)
        Me.btnPasteTextV2.Name = "btnPasteTextV2"
        Me.btnPasteTextV2.Size = New System.Drawing.Size(113, 53)
        Me.btnPasteTextV2.TabIndex = 2
        Me.btnPasteTextV2.Text = "Pegar datos desde el portapapeles V2"
        Me.btnPasteTextV2.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 262)
        Me.Controls.Add(Me.btnPasteTextV2)
        Me.Controls.Add(Me.btnViewData)
        Me.Controls.Add(Me.btnPasteTextV1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppTitle"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPasteTextV1 As System.Windows.Forms.Button
    Friend WithEvents btnViewData As System.Windows.Forms.Button
    Friend WithEvents btnPasteTextV2 As System.Windows.Forms.Button

End Class
