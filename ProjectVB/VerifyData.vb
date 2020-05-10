Module VerifyData
    Friend Function VerificarEncabezado(ByVal DataGridViewRow As DataGridViewRow, ByVal ShowContinueOption As Boolean) As Boolean
        Dim SumaControl As Decimal

        With DataGridViewRow
            ' Suma de Cargos
            SumaControl = 0
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Cargos_ProporcionalesUnicaVez").Value)
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Cargos_FijosMensuales").Value)
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Cargos_ServicioCelular").Value)
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Cargos_Datos").Value)
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Cargos_TelefoniaFija").Value)
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Cargos_Roaming").Value)
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Cargos_EquiposYAccesorios").Value)
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Cargos_Otros").Value)
            If SumaControl <> FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Cargos_Subtotal").Value) Then
                If ShowContinueOption Then
                    Return (MsgBox("Esta Factura (" & .Cells("Numero").Value & ") tiene una inconstistencia entre la suma de Cargos y el SubTotal de Cargos." & vbCr & vbCr & "¿Desea continuar verificando Facturas?", vbExclamation + MsgBoxStyle.YesNo, My.Application.Info.Title) = MsgBoxResult.Yes)
                Else
                    MsgBox("Esta Factura (" & .Cells("Numero").Value & ") tiene una inconstistencia entre la suma de Cargos y el SubTotal de Cargos.", vbExclamation, My.Application.Info.Title)
                    Return False
                End If
            End If

            ' Suma de Impuestos
            SumaControl = 0
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Impuesto_IVA105").Value)
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Impuesto_IVA21").Value)
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Impuesto_IVA27").Value)
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Impuesto_Interno").Value)
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Impuesto_InternoEquipos").Value)
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Impuesto_PercepcionIVA").Value)
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Impuesto_PercepcionIIBB").Value)
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Impuesto_ENARD").Value)
            If SumaControl <> FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Impuesto_Subtotal").Value) Then
                If ShowContinueOption Then
                    Return (MsgBox("Esta Factura (" & .Cells("Numero").Value & ") tiene una inconstistencia entre la suma de Impuestos y el SubTotal de Impuestos." & vbCr & vbCr & "¿Desea continuar verificando Facturas?", vbExclamation + MsgBoxStyle.YesNo, My.Application.Info.Title) = MsgBoxResult.Yes)
                Else
                    MsgBox("Esta Factura (" & .Cells("Numero").Value & ") tiene una inconstistencia entre la suma de Impuestos y el SubTotal de Impuestos.", vbExclamation, My.Application.Info.Title)
                    Return False
                End If
            End If

            ' Suma de Subtotales
            SumaControl = 0
            SumaControl += FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Cargos_Subtotal").Value)
            SumaControl += FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Impuesto_Subtotal").Value)
            SumaControl += FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Redondeo").Value)
            If SumaControl <> FromDBValueToDecimalValueOrZeroIfIsNull(.Cells("Total").Value) Then
                Dim message As String
                message = String.Format("Esta Factura ({0}) tiene una inconstistencia entre la suma del Subtotal de Cargos + el SubTotal de Impuestos y el Total de la Factura.", .Cells("Numero").Value)

                If ShowContinueOption Then
                    message &= String.Format("{0}{0}¿Desea continuar verificando Facturas?", vbCrLf)
                    Return (MsgBox(message, vbExclamation + MsgBoxStyle.YesNo, My.Application.Info.Title) = MsgBoxResult.Yes)
                Else
                    MsgBox(message, vbExclamation, My.Application.Info.Title)
                    Return False
                End If
            End If

            Return True
        End With
    End Function

    Friend Function VerificarDetalle(ByVal DataRow As DataRow, ByVal ShowContinueOption As Boolean) As Boolean
        Dim SumaControl As Decimal

        With DataRow
            SumaControl = 0
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(DataRow("AbonoImporte"))
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(DataRow("Servicios"))
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(DataRow("CargosReintegros"))
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(DataRow("AireExcedentesEstabLlamadasPesos"))
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(DataRow("AireExcedentesPesos"))
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(DataRow("RedFijaLocalPesos"))
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(DataRow("RedFijaInternacionalEstabLlamadasPesos"))
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(DataRow("RedFijaInternacionalPesos"))
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(DataRow("DatosExcedentesPesos"))
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(DataRow("EquiposPesos"))
            SumaControl = SumaControl + FromDBValueToDecimalValueOrZeroIfIsNull(DataRow("VariosPesos"))
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
End Module
