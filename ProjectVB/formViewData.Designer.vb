<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formViewData
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
        Me.stsbarMain = New System.Windows.Forms.StatusStrip()
        Me.stsbarMainLabelFactura = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsbarMainLabelFacturaDetalle = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.datgrdDataFactura = New System.Windows.Forms.DataGridView()
        Me.datgrdDataFacturaDetalle = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMainVerificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainVerificarFacturaSeleccionada = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainVerificarFacturaDetalleSeleccionada = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuMainVerificarFacturaTodas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainVerificarFacturaDetalleTodas = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsbarMain.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.datgrdDataFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datgrdDataFacturaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'stsbarMain
        '
        Me.stsbarMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsbarMainLabelFactura, Me.stsbarMainLabelFacturaDetalle})
        Me.stsbarMain.Location = New System.Drawing.Point(0, 275)
        Me.stsbarMain.Name = "stsbarMain"
        Me.stsbarMain.Size = New System.Drawing.Size(541, 22)
        Me.stsbarMain.TabIndex = 8
        Me.stsbarMain.Text = "stsbarMain"
        '
        'stsbarMainLabelFactura
        '
        Me.stsbarMainLabelFactura.Name = "stsbarMainLabelFactura"
        Me.stsbarMainLabelFactura.Size = New System.Drawing.Size(0, 17)
        '
        'stsbarMainLabelFacturaDetalle
        '
        Me.stsbarMainLabelFacturaDetalle.Name = "stsbarMainLabelFacturaDetalle"
        Me.stsbarMainLabelFacturaDetalle.Size = New System.Drawing.Size(0, 17)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 27)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.datgrdDataFactura)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.datgrdDataFacturaDetalle)
        Me.SplitContainer1.Size = New System.Drawing.Size(517, 245)
        Me.SplitContainer1.SplitterDistance = 81
        Me.SplitContainer1.TabIndex = 10
        '
        'datgrdDataFactura
        '
        Me.datgrdDataFactura.AllowUserToAddRows = False
        Me.datgrdDataFactura.AllowUserToDeleteRows = False
        Me.datgrdDataFactura.AllowUserToResizeRows = False
        Me.datgrdDataFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datgrdDataFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datgrdDataFactura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datgrdDataFactura.Location = New System.Drawing.Point(0, 0)
        Me.datgrdDataFactura.MultiSelect = False
        Me.datgrdDataFactura.Name = "datgrdDataFactura"
        Me.datgrdDataFactura.ReadOnly = True
        Me.datgrdDataFactura.RowHeadersVisible = False
        Me.datgrdDataFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datgrdDataFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datgrdDataFactura.Size = New System.Drawing.Size(517, 81)
        Me.datgrdDataFactura.TabIndex = 10
        '
        'datgrdDataFacturaDetalle
        '
        Me.datgrdDataFacturaDetalle.AllowUserToAddRows = False
        Me.datgrdDataFacturaDetalle.AllowUserToDeleteRows = False
        Me.datgrdDataFacturaDetalle.AllowUserToResizeRows = False
        Me.datgrdDataFacturaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datgrdDataFacturaDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datgrdDataFacturaDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datgrdDataFacturaDetalle.Location = New System.Drawing.Point(0, 0)
        Me.datgrdDataFacturaDetalle.MultiSelect = False
        Me.datgrdDataFacturaDetalle.Name = "datgrdDataFacturaDetalle"
        Me.datgrdDataFacturaDetalle.ReadOnly = True
        Me.datgrdDataFacturaDetalle.RowHeadersVisible = False
        Me.datgrdDataFacturaDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datgrdDataFacturaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datgrdDataFacturaDetalle.Size = New System.Drawing.Size(517, 160)
        Me.datgrdDataFacturaDetalle.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainVerificar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(541, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMainVerificar
        '
        Me.mnuMainVerificar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainVerificarFacturaSeleccionada, Me.mnuMainVerificarFacturaDetalleSeleccionada, Me.ToolStripMenuItem1, Me.mnuMainVerificarFacturaTodas, Me.mnuMainVerificarFacturaDetalleTodas})
        Me.mnuMainVerificar.Name = "mnuMainVerificar"
        Me.mnuMainVerificar.Size = New System.Drawing.Size(144, 20)
        Me.mnuMainVerificar.Text = "Verificar Inconsistencias"
        '
        'mnuMainVerificarFacturaSeleccionada
        '
        Me.mnuMainVerificarFacturaSeleccionada.Name = "mnuMainVerificarFacturaSeleccionada"
        Me.mnuMainVerificarFacturaSeleccionada.Size = New System.Drawing.Size(313, 22)
        Me.mnuMainVerificarFacturaSeleccionada.Text = "Encabezado de Factura seleccionada"
        '
        'mnuMainVerificarFacturaDetalleSeleccionada
        '
        Me.mnuMainVerificarFacturaDetalleSeleccionada.Name = "mnuMainVerificarFacturaDetalleSeleccionada"
        Me.mnuMainVerificarFacturaDetalleSeleccionada.Size = New System.Drawing.Size(313, 22)
        Me.mnuMainVerificarFacturaDetalleSeleccionada.Text = "Encabezado y detalle de Factura seleccionada"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(310, 6)
        '
        'mnuMainVerificarFacturaTodas
        '
        Me.mnuMainVerificarFacturaTodas.Name = "mnuMainVerificarFacturaTodas"
        Me.mnuMainVerificarFacturaTodas.Size = New System.Drawing.Size(313, 22)
        Me.mnuMainVerificarFacturaTodas.Text = "Encabezado de todas las Facturas"
        '
        'mnuMainVerificarFacturaDetalleTodas
        '
        Me.mnuMainVerificarFacturaDetalleTodas.Name = "mnuMainVerificarFacturaDetalleTodas"
        Me.mnuMainVerificarFacturaDetalleTodas.Size = New System.Drawing.Size(313, 22)
        Me.mnuMainVerificarFacturaDetalleTodas.Text = "Encabezado y detalle de todas las Facturas"
        '
        'formViewData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 297)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.stsbarMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formViewData"
        Me.Text = "Verificar Datos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.stsbarMain.ResumeLayout(False)
        Me.stsbarMain.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.datgrdDataFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datgrdDataFacturaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stsbarMain As System.Windows.Forms.StatusStrip
    Friend WithEvents stsbarMainLabelFactura As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents datgrdDataFactura As System.Windows.Forms.DataGridView
    Friend WithEvents datgrdDataFacturaDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents stsbarMainLabelFacturaDetalle As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMainVerificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMainVerificarFacturaSeleccionada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMainVerificarFacturaDetalleSeleccionada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuMainVerificarFacturaTodas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMainVerificarFacturaDetalleTodas As System.Windows.Forms.ToolStripMenuItem
End Class
