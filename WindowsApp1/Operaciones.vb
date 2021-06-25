Imports Clientes
Imports Vehiculos
Public Class Operaciones
    'Propiedades
    Public Codigo As Integer
    Public Cliente As Object
    Public Vehiculo As Object
    Public Fecha_alta As Date

    Public Sub New()

    End Sub

    Public Sub New(Codigo, Cliente, Vehiculo, Fecha_Alta)
        Me.Codigo = Codigo
        Me.Cliente = Cliente
        Me.Vehiculo = Vehiculo
        Me.Fecha_alta = Fecha_Alta
    End Sub

End Class
