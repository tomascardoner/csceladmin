Module PasteText
    Friend Const RAW_DATA_SEPARATOR As Char = " "

    Friend Function ReadDataFromPastedTextV1(ByVal IDFactura As Long, ByVal PastedText As String) As Boolean
        Dim aLines() As String
        Dim Line As String
        Dim aLineFields() As String
        Dim ColumnIndex As Byte

        Dim FacturaDetalleDataAdapter As New System.Data.OleDb.OleDbDataAdapter
        Dim FacturaDetalleSet As New Data.DataSet
        Dim FacturaDetalleRow As Data.DataRow

        'Lleno un array con las líneas del texto
        aLines = PastedText.Split(vbCrLf.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
        If aLines.Count > 0 Then
            'Abro la tabla de detalle de facturas
            If fDatabase.OpenDataSet(FacturaDetalleDataAdapter, FacturaDetalleSet, "SELECT * FROM FacturaDetalle WHERE IDFactura = " & IDFactura, "FacturaDetalle", "Error al abrir la tabla de Detalles de Facturas.") Then

                For Each Line In aLines
                    'Por cada línea, lleno un array con las columnas
                    aLineFields = Line.Split(RAW_DATA_SEPARATOR)

                    'Ahora agrego los datos de la fila a la tabla de la base de datos
                    FacturaDetalleRow = FacturaDetalleSet.Tables("FacturaDetalle").NewRow
                    FacturaDetalleRow("IDFactura") = IDFactura

                    ColumnIndex = 0     'Número de Línea
                    FacturaDetalleRow("IDLinea") = aLineFields(ColumnIndex).Replace("-", "")

                    ColumnIndex = ColumnIndex + 2   'Usuario
                    Do While Not IsNumeric(aLineFields(ColumnIndex + 1))
                        ColumnIndex = ColumnIndex + 1
                    Loop

                    'Plan + Abonos
                    FacturaDetalleRow("IDAbono") = aLineFields(ColumnIndex)
                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("AbonoImporte") = Convert.ToDouble(aLineFields(ColumnIndex))

                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("Servicios") = Convert.ToDouble(aLineFields(ColumnIndex))

                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("CargosReintegros") = Convert.ToDouble(aLineFields(ColumnIndex))
                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("AireIncluidoMinutos") = Math.Round(Convert.ToSingle(aLineFields(ColumnIndex)), 0)
                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("AireExcedentesMinutos") = Math.Round(Convert.ToSingle(aLineFields(ColumnIndex)), 0)
                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("AireExcedentesPesos") = Convert.ToDouble(aLineFields(ColumnIndex))
                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("RedFijaLocalMinutos") = Math.Round(Convert.ToSingle(aLineFields(ColumnIndex)), 0)
                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("RedFijaLocalPesos") = Convert.ToDouble(aLineFields(ColumnIndex))
                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("RedFijaInternacionalMinutos") = Math.Round(Convert.ToInt16(Convert.ToSingle(aLineFields(ColumnIndex))))
                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("RedFijaInternacionalPesos") = Convert.ToDouble(aLineFields(ColumnIndex))
                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("DatosUnidades") = Math.Round(Convert.ToInt16(Convert.ToSingle(aLineFields(ColumnIndex))))
                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("DatosExcedentesPesos") = Convert.ToDouble(aLineFields(ColumnIndex))
                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("EquiposPesos") = Convert.ToDouble(aLineFields(ColumnIndex))
                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("VariosPesos") = Convert.ToDouble(aLineFields(ColumnIndex))
                    ColumnIndex = ColumnIndex + 1
                    FacturaDetalleRow("TotalLineaPesos") = Convert.ToDouble(aLineFields(ColumnIndex))

                    FacturaDetalleSet.Tables("FacturaDetalle").Rows.Add(FacturaDetalleRow)
                Next Line
                FacturaDetalleDataAdapter.Update(FacturaDetalleSet, "FacturaDetalle")
            End If
        End If

        Return True
    End Function

    Friend Function ReadDataFromPastedTextV2(ByVal IDFactura As Long, ByVal PastedText As String) As Boolean
        Dim aLines() As String
        Dim Line As String
        Dim aLineFields() As String
        Dim ColumnIndex As Byte

        Dim FacturaDetalleDataAdapter As New System.Data.OleDb.OleDbDataAdapter
        Dim FacturaDetalleSet As New Data.DataSet
        Dim FacturaDetalleRow As Data.DataRow

        'Lleno un array con las líneas del texto
        aLines = PastedText.Split(vbCrLf.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
        If aLines.Count > 0 Then
            'Abro la tabla de detalle de facturas
            If fDatabase.OpenDataSet(FacturaDetalleDataAdapter, FacturaDetalleSet, "SELECT * FROM FacturaDetalle WHERE IDFactura = " & IDFactura, "FacturaDetalle", "Error al abrir la tabla de Detalles de Facturas.") Then

                For Each Line In aLines
                    Try
                        'Por cada línea, lleno un array con las columnas para parsear
                        aLineFields = Line.Split(RAW_DATA_SEPARATOR)

                        'Ahora agrego los datos de la fila a la tabla de la base de datos
                        FacturaDetalleRow = FacturaDetalleSet.Tables("FacturaDetalle").NewRow
                        FacturaDetalleRow("IDFactura") = IDFactura

                        ColumnIndex = 0     'Número de Línea
                        FacturaDetalleRow("IDLinea") = aLineFields(ColumnIndex).Replace("-", "")

                        ColumnIndex = ColumnIndex + 2   'Usuario
                        Do While Not IsNumeric(aLineFields(ColumnIndex + 1))
                            ColumnIndex = ColumnIndex + 1
                        Loop

                        'Plan + Abonos
                        FacturaDetalleRow("IDAbono") = aLineFields(ColumnIndex)
                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("AbonoImporte") = Convert.ToDouble(aLineFields(ColumnIndex))

                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("Servicios") = Convert.ToDouble(aLineFields(ColumnIndex))

                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("CargosReintegros") = Convert.ToDouble(aLineFields(ColumnIndex))
                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("AireIncluidoMinutos") = Math.Round(Convert.ToSingle(aLineFields(ColumnIndex)), 0)
                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("AireExcedentesEstabLlamadasMinutos") = Math.Round(Convert.ToSingle(aLineFields(ColumnIndex)), 0)
                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("AireExcedentesEstabLlamadasPesos") = Convert.ToDouble(aLineFields(ColumnIndex))
                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("AireExcedentesMinutos") = Math.Round(Convert.ToSingle(aLineFields(ColumnIndex)), 0)
                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("AireExcedentesPesos") = Convert.ToDouble(aLineFields(ColumnIndex))
                        FacturaDetalleRow("RedFijaLocalMinutos") = 0
                        FacturaDetalleRow("RedFijaLocalPesos") = 0
                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("RedFijaInternacionalEstabLlamadasMinutos") = Math.Round(Convert.ToSingle(aLineFields(ColumnIndex)), 0)
                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("RedFijaInternacionalEstabLlamadasPesos") = Convert.ToDouble(aLineFields(ColumnIndex))
                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("RedFijaInternacionalMinutos") = Math.Round(Convert.ToInt16(Convert.ToSingle(aLineFields(ColumnIndex))))
                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("RedFijaInternacionalPesos") = Convert.ToDouble(aLineFields(ColumnIndex))
                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("DatosUnidades") = Math.Round(Convert.ToInt16(Convert.ToSingle(aLineFields(ColumnIndex))))
                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("DatosExcedentesPesos") = Convert.ToDouble(aLineFields(ColumnIndex))
                        FacturaDetalleRow("EquiposPesos") = 0
                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("VariosPesos") = Convert.ToDouble(aLineFields(ColumnIndex))
                        ColumnIndex = ColumnIndex + 1
                        FacturaDetalleRow("TotalLineaPesos") = Convert.ToDouble(aLineFields(ColumnIndex))

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, String.Format("Error detectando la información de la línea nº {0}.", FacturaDetalleRow("IDLinea")))
                        Return False

                    End Try

                    Try
                        FacturaDetalleSet.Tables("FacturaDetalle").Rows.Add(FacturaDetalleRow)
                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, String.Format("Error agregando la información de la línea nº {0} a la base de datos.", FacturaDetalleRow("IDLinea")))
                        Return False
                    End Try

                Next Line

                Try
                    FacturaDetalleDataAdapter.Update(FacturaDetalleSet, "FacturaDetalle")
                Catch ex As Exception
                    CardonerSistemas.ErrorHandler.ProcessError(ex, String.Format("Error al actualizar la base de datos.", FacturaDetalleRow("IDLinea")))
                    Return False
                End Try
            End If
        End If

        Return True
    End Function
End Module
