<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.buttonViewData = New System.Windows.Forms.Button()
        Me.buttonPasteText = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonViewData
        '
        Me.buttonViewData.Location = New System.Drawing.Point(131, 12)
        Me.buttonViewData.Name = "buttonViewData"
        Me.buttonViewData.Size = New System.Drawing.Size(113, 53)
        Me.buttonViewData.TabIndex = 1
        Me.buttonViewData.Text = "Visualizar y verificar datos"
        Me.buttonViewData.UseVisualStyleBackColor = True
        '
        'buttonPasteText
        '
        Me.buttonPasteText.Location = New System.Drawing.Point(12, 12)
        Me.buttonPasteText.Name = "buttonPasteText"
        Me.buttonPasteText.Size = New System.Drawing.Size(113, 53)
        Me.buttonPasteText.TabIndex = 2
        Me.buttonPasteText.Text = "Pegar datos desde el portapapeles"
        Me.buttonPasteText.UseVisualStyleBackColor = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 76)
        Me.Controls.Add(Me.buttonPasteText)
        Me.Controls.Add(Me.buttonViewData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppTitle"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents buttonViewData As System.Windows.Forms.Button
    Friend WithEvents buttonPasteText As System.Windows.Forms.Button

End Class
