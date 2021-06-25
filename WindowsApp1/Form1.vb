Public Class Form1

    Public Cliente As New List(Of Clientes)()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cliente
        Dim Cli1 As New Clientes
        Dim Cli2 As New Clientes
        Dim Cli3 As New Clientes

        Cli1.Codigo = 1
        Cli1.Apellido = "Ibarra"
        Cli1.Nombre = "Jose"
        Cli1.Domicilio = "La rioja 243, Balvanera"

        Cli2.Codigo = 2
        Cli2.Apellido = "Alfonso"
        Cli2.Nombre = "Simon"
        Cli2.Domicilio = "La rioja 245, Balvanera"

        Cli3.Codigo = 3
        Cli3.Apellido = "Allende"
        Cli3.Nombre = "Belen"
        Cli3.Domicilio = "La rioja 247, Balvanera"

        Cliente.Add(Cli1)
        Cliente.Add(Cli2)
        Cliente.Add(Cli3)

        Dim Vehiculo As New List(Of Vehiculos)()
        Dim V1 As New Vehiculos
        'Vehiculo
        V1.Codigo = 325
        V1.Nombre_modelo = "Fiat Fiorino"
        V1.Dominio = "AE854585"


        Dim Operacione As New List(Of Operaciones)()
        Dim Ope As New Operaciones

        Ope.Codigo = 123
        Ope.Cliente = New List(Of Clientes)
        Ope.Vehiculo = New List(Of Vehiculos)
        Ope.Fecha_alta = Now()





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Clientes_get
        For Each item As Clientes In Cliente
            MsgBox("Codigo: " + item.Codigo.ToString + ", Apellido: " + item.Apellido + ", Nombre: " + item.Nombre + ", Domicilio: " + item.Domicilio)
        Next

    End Sub
End Class
