<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasteText
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
        Me.txtPastedText = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.cboFactura = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtPastedText
        '
        Me.txtPastedText.AcceptsReturn = True
        Me.txtPastedText.AcceptsTab = True
        Me.txtPastedText.AllowDrop = True
        Me.txtPastedText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPastedText.Location = New System.Drawing.Point(12, 33)
        Me.txtPastedText.Multiline = True
        Me.txtPastedText.Name = "txtPastedText"
        Me.txtPastedText.Size = New System.Drawing.Size(772, 297)
        Me.txtPastedText.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(628, 336)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "&Aceptar"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(709, 336)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Location = New System.Drawing.Point(12, 9)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(61, 13)
        Me.lblFactura.TabIndex = 4
        Me.lblFactura.Text = "Factura Nº:"
        '
        'cboFactura
        '
        Me.cboFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFactura.FormattingEnabled = True
        Me.cboFactura.Location = New System.Drawing.Point(79, 6)
        Me.cboFactura.Name = "cboFactura"
        Me.cboFactura.Size = New System.Drawing.Size(254, 21)
        Me.cboFactura.TabIndex = 3
        '
        'PasteText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 371)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblFactura)
        Me.Controls.Add(Me.cboFactura)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtPastedText)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PasteText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pegar información de la factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPastedText As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblFactura As System.Windows.Forms.Label
    Friend WithEvents cboFactura As System.Windows.Forms.ComboBox
End Class
