Public Class Operaciones
    'Propiedades
    Private _Codigo As Integer
    Private _Cliente As Object
    Private _Vehiculo As Object
    Private _Fecha_alta As Date


    Sub Operaciones(Codigo As Integer, Cliente As Object, Vehiculo As Object, Fecha_Alta As Date)
        _Codigo = Codigo
        _Cliente = Cliente
        _Vehiculo = Vehiculo
        _Fecha_alta = Fecha_Alta
    End Sub


    Public Property Codigo() As Integer
        Get
            Return _Codigo
        End Get
        Set(value As Integer)
            Me._Codigo = value
        End Set
    End Property

    Public Property Cliente() As Object
        Get
            Return _Cliente
        End Get
        Set(value As Object)
            Me._Cliente = value
        End Set
    End Property

    Public Property Vehiculo() As Object
        Get
            Return _Vehiculo
        End Get
        Set(value As Object)
            Me._Vehiculo = value
        End Set
    End Property

    Public Property Fecha_alta() As Date
        Get
            Return _Fecha_alta
        End Get
        Set(value As Date)
            Me._Fecha_alta = value
        End Set
    End Property

End Class
