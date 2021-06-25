Public Class Vehiculos
    'Propiedades
    Private _Codigo As Integer
    Private _Nombre_modelo As String
    Private _Dominio As String

    Sub Vehiculo(cod As Integer, Nom As String, Dom As String)
        _Codigo = cod
        _Nombre_modelo = Nom
        _Dominio = Dom
    End Sub
    Public Property Codigo() As Integer
        Get
            Return Me._Codigo
        End Get
        Set(value As Integer)
            Me._Codigo = value
        End Set
    End Property

    Public Property Nombre_modelo() As String
        Get
            Return Me._Nombre_modelo
        End Get
        Set(value As String)
            Me._Nombre_modelo = value
        End Set
    End Property
    Public Property Dominio() As String
        Get
            Return Me._Dominio
        End Get
        Set(value As String)
            Me._Dominio = value
        End Set
    End Property

End Class
