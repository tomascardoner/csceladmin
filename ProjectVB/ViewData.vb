Public Class ViewData

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

    Private Function VerificarEncabezado(ByVal DataGridViewRow As DataGridViewRow, ByVal ShowContinueOption As Boolean) As Boolean
        Dim SumaControl As Decimal

        With DataGridViewRow
            'SUMA DE CARGOS
            SumaControl = 0
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Cargos_ProporcionalesUnicaVez").Value), 0, .Cells("Cargos_ProporcionalesUnicaVez").Value)
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Cargos_FijosMensuales").Value), 0, .Cells("Cargos_FijosMensuales").Value)
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Cargos_ServicioCelular").Value), 0, .Cells("Cargos_ServicioCelular").Value)
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Cargos_Datos").Value), 0, .Cells("Cargos_Datos").Value)
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Cargos_TelefoniaFija").Value), 0, .Cells("Cargos_TelefoniaFija").Value)
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Cargos_Roaming").Value), 0, .Cells("Cargos_Roaming").Value)
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Cargos_EquiposYAccesorios").Value), 0, .Cells("Cargos_EquiposYAccesorios").Value)
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Cargos_Otros").Value), 0, .Cells("Cargos_Otros").Value)
            If SumaControl <> .Cells("Cargos_Subtotal").Value Then
                If ShowContinueOption Then
                    Return (MsgBox("Esta Factura (" & .Cells("Numero").Value & ") tiene una inconstistencia entre la suma de Cargos y el SubTotal de Cargos." & vbCr & vbCr & "¿Desea continuar verificando Facturas?", vbExclamation + MsgBoxStyle.YesNo, My.Application.Info.Title) = MsgBoxResult.Yes)
                Else
                    MsgBox("Esta Factura (" & .Cells("Numero").Value & ") tiene una inconstistencia entre la suma de Cargos y el SubTotal de Cargos.", vbExclamation, My.Application.Info.Title)
                    Return False
                End If
            End If

            'SUMA DE IMPUESTOS
            SumaControl = 0
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Impuesto_IVA105").Value), 0, .Cells("Impuesto_IVA105").Value)
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Impuesto_IVA21").Value), 0, .Cells("Impuesto_IVA21").Value)
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Impuesto_IVA27").Value), 0, .Cells("Impuesto_IVA27").Value)
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Impuesto_Interno").Value), 0, .Cells("Impuesto_Interno").Value)
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Impuesto_InternoEquipos").Value), 0, .Cells("Impuesto_InternoEquipos").Value)
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Impuesto_PercepcionIVA").Value), 0, .Cells("Impuesto_PercepcionIVA").Value)
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Impuesto_PercepcionIIBB").Value), 0, .Cells("Impuesto_PercepcionIIBB").Value)
            SumaControl = SumaControl + IIf(IsDBNull(.Cells("Impuesto_ENARD").Value), 0, .Cells("Impuesto_ENARD").Value)
            If SumaControl <> .Cells("Impuesto_Subtotal").Value Then
                If ShowContinueOption Then
                    Return (MsgBox("Esta Factura (" & .Cells("Numero").Value & ") tiene una inconstistencia entre la suma de Impuestos y el SubTotal de Impuestos." & vbCr & vbCr & "¿Desea continuar verificando Facturas?", vbExclamation + MsgBoxStyle.YesNo, My.Application.Info.Title) = MsgBoxResult.Yes)
                Else
                    MsgBox("Esta Factura (" & .Cells("Numero").Value & ") tiene una inconstistencia entre la suma de Impuestos y el SubTotal de Impuestos.", vbExclamation, My.Application.Info.Title)
                    Return False
                End If
            End If

            Return True
        End With
    End Function

    Private Function VerificarDetalle(ByVal DataRow As DataRow, ByVal ShowContinueOption As Boolean) As Boolean
        Dim SumaControl As Decimal

        With DataRow
            SumaControl = 0
            SumaControl = SumaControl + IIf(IsDBNull(DataRow("AbonoImporte")), 0, DataRow("AbonoImporte"))
            SumaControl = SumaControl + IIf(IsDBNull(DataRow("Servicios")), 0, DataRow("Servicios"))
            SumaControl = SumaControl + IIf(IsDBNull(DataRow("CargosReintegros")), 0, DataRow("CargosReintegros"))
            SumaControl = SumaControl + IIf(IsDBNull(DataRow("AireExcedentesEstabLlamadasPesos")), 0, DataRow("AireExcedentesEstabLlamadasPesos"))
            SumaControl = SumaControl + IIf(IsDBNull(DataRow("AireExcedentesPesos")), 0, DataRow("AireExcedentesPesos"))
            SumaControl = SumaControl + IIf(IsDBNull(DataRow("RedFijaLocalPesos")), 0, DataRow("RedFijaLocalPesos"))
            SumaControl = SumaControl + IIf(IsDBNull(DataRow("RedFijaInternacionalEstabLlamadasPesos")), 0, DataRow("RedFijaInternacionalEstabLlamadasPesos"))
            SumaControl = SumaControl + IIf(IsDBNull(DataRow("RedFijaInternacionalPesos")), 0, DataRow("RedFijaInternacionalPesos"))
            SumaControl = SumaControl + IIf(IsDBNull(DataRow("DatosExcedentesPesos")), 0, DataRow("DatosExcedentesPesos"))
            SumaControl = SumaControl + IIf(IsDBNull(DataRow("EquiposPesos")), 0, DataRow("EquiposPesos"))
            SumaControl = SumaControl + IIf(IsDBNull(DataRow("VariosPesos")), 0, DataRow("VariosPesos"))
            If SumaControl <> DataRow("TotalLineaPesos") Then
                If ShowContinueOption Then
                    Return (MsgBox("Este Detalle de la Factura (" & .Item("IDFactura") & " - " & .Item("IDLinea") & ") tiene una inconstistencia entre la suma de Items y el SubTotal de la Línea." & vbCr & vbCr & "¿Desea continuar verificando Facturas?", vbExclamation + MsgBoxStyle.YesNo, My.Application.Info.Title) = MsgBoxResult.Yes)
                Else
                    MsgBox("Este Detalle de la Factura (" & .Item("IDFactura") & " - " & .Item("IDLinea") & ") tiene una inconstistencia entre la suma de Cargos y el SubTotal de Cargos.", vbExclamation, My.Application.Info.Title)
                    Return False
                End If
            End If
        End With
        Return True
    End Function
End Class