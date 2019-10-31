Public Class formViewData

    Private Sub ViewData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim DataTable As New Data.DataTable

        If fDatabase.OpenDataTable(DataTable, "SELECT * FROM Factura ORDER BY IDFactura DESC", "Factura", "Error al leer las Facturas.") Then
            datgrdDataFactura.DataSource = DataTable
            stsbarMainLabelFactura.Text = DataTable.Rows.Count & " facturas."
        End If
    End Sub

    Private Sub datgrdDataFactura_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datgrdDataFactura.SelectionChanged
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim DataTable As New Data.DataTable

        If datgrdDataFactura.SelectedRows.Count > 0 Then
            If fDatabase.OpenDataTable(DataTable, "SELECT * FROM FacturaDetalle WHERE IDFactura = " & datgrdDataFactura.SelectedRows(0).Cells(0).Value & " ORDER BY IDLinea", "FacturaDetalle", "Error al leer el detalle de la Factura.") Then
                datgrdDataFacturaDetalle.DataSource = DataTable
                stsbarMainLabelFacturaDetalle.Text = DataTable.Rows.Count & " líneas."
            End If
        End If
    End Sub

    Private Sub mnuMainVerificarFacturaSeleccionada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMainVerificarFacturaSeleccionada.Click
        If datgrdDataFactura.SelectedRows.Count > 0 Then
            If VerificarEncabezado(datgrdDataFactura.SelectedRows(0), False) Then
                MsgBox("La Factura seleccionada está correcta.", MsgBoxStyle.Information, My.Application.Info.Title)
            End If
        End If
    End Sub

    Private Sub mnuMainVerificarFacturaDetalleSeleccionada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMainVerificarFacturaDetalleSeleccionada.Click
        If datgrdDataFactura.SelectedRows.Count > 0 Then
            If VerificarEncabezado(datgrdDataFactura.SelectedRows(0), False) Then
                For Each DataRow In datgrdDataFacturaDetalle.DataSource.Rows
                    If Not VerificarDetalle(DataRow, True) Then
                        Exit Sub
                    End If
                Next

                MsgBox("La Factura seleccionada está correcta.", MsgBoxStyle.Information, My.Application.Info.Title)
            End If
        End If
    End Sub

    Private Sub mnuMainVerificarFacturaTodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMainVerificarFacturaTodas.Click
        Dim DataGridViewRow As DataGridViewRow

        Cursor.Current = Cursors.WaitCursor

        If datgrdDataFactura.RowCount > 0 Then
            For Each DataGridViewRow In datgrdDataFactura.Rows
                If Not VerificarEncabezado(DataGridViewRow, True) Then
                    Exit Sub
                End If
            Next
        End If

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuMainVerificarFacturaDetalleTodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMainVerificarFacturaDetalleTodas.Click
        Dim DataGridViewRow As DataGridViewRow
        Dim DataTable As New Data.DataTable

        Cursor.Current = Cursors.WaitCursor

        If datgrdDataFactura.RowCount > 0 Then
            For Each DataGridViewRow In datgrdDataFactura.Rows
                If Not VerificarEncabezado(DataGridViewRow, True) Then
                    Exit Sub
                End If

                'ABRO LA TABLA DEL DETALLE DE LA FACTURA
                If fDatabase.OpenDataTable(DataTable, "SELECT * FROM FacturaDetalle WHERE IDFactura = " & DataGridViewRow.Cells("IDFactura").Value & " ORDER BY IDLinea", "FacturaDetalle", "Error al leer el detalle de la Factura.") Then
                End If
                For Each DataRow In DataTable.Rows
                    If Not VerificarDetalle(DataRow, True) Then
                        Exit Sub
                    End If
                Next
            Next
        End If

        Cursor.Current = Cursors.Default

    End Sub
End Class