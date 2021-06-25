Public Class Vehiculos
    'Propiedades
    Public Codigo As Integer
    Public Nombre_modelo As String
    Public Dominio As String

    Public Sub New()

    End Sub

    Public Sub New(Codigo, Nombre_modelo, Dominio)
        Me.Codigo = Codigo
        Me.Nombre_modelo = Nombre_modelo
        Me.Dominio = Dominio
    End Sub
End Class
