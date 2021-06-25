Public Class Clientes
    'Propiedades
    Private _Codigo As Integer
    Private _Apellido As String
    Private _Nombre As String
    Private _Domicilio As String

    Sub cliente(cod As Integer, Ape As String, Nom As String, Dir As String)
        _Codigo = cod
        _Apellido = Ape
        _Nombre = Nom
        _Domicilio = Dir
    End Sub
    Public Property Codigo() As Integer
        Get
            Return Me._Codigo
        End Get
        Set(value As Integer)
            Me._Codigo = value
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return Me._Apellido
        End Get
        Set(value As String)
            Me._Apellido = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return Me._Nombre
        End Get
        Set(value As String)
            Me._Nombre = value
        End Set
    End Property
    Public Property Domicilio() As String
        Get
            Return Me._Domicilio
        End Get
        Set(value As String)
            Me._Domicilio = value
        End Set
    End Property

End Class
