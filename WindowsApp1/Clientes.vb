Public Class Clientes
    'Propiedades
    Public Codigo As Integer
    Public Apellido As String
    Public Nombre As String
    Public Domicilio As String

    Public Sub New()

    End Sub

    Public Sub New(Codigo, Apellido, Nombre, Domicilio)
        Me.Codigo = Codigo
        Me.Apellido = Apellido
        Me.Nombre = Nombre
        Me.Domicilio = Domicilio
    End Sub
End Class
