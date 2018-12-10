Public Class PasteText
    Private Sub PasteText_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DataTable As New Data.DataTable

        If Not fDatabase.OpenDataTable(DataTable, "SELECT Factura.IDFactura, Factura.Numero + ' - ' + Format(Factura.Fecha, 'dd/mm/yyyy') AS DisplayValue, Count(FacturaDetalle.IDLinea) AS Lineas FROM Factura LEFT JOIN FacturaDetalle ON Factura.IDFactura = FacturaDetalle.IDFactura GROUP BY Factura.IDFactura, [Factura].[Numero]+' - '+Format([Factura].[Fecha],'dd/mm/yyyy'), Factura.Numero ORDER BY Factura.Numero DESC", "Factura", "Error al leer las Facturas.") Then
            Me.Close()
        End If

        cboFactura.ValueMember = "IDFactura"
        cboFactura.DisplayMember = "DisplayValue"
        cboFactura.DataSource = DataTable
    End Sub
End Class