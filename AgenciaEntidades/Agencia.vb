Public Class Agencia
    Private Shared _ventas As New List(Of Venta)
    Public Shared Sub addVenta(Venta)
        _ventas.Add(Venta)
    End Sub
    Public Shared Sub removeVenta(venta)
        _ventas.Remove(venta)
    End Sub
    Public Shared Function getAllVentas() As List(Of Venta)
        Return _ventas
    End Function
End Class
