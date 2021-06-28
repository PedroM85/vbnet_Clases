Public Class Form1

    Public Cliente As New List(Of Clientes)()
    Public Vehiculo As New List(Of Vehiculos)()
    Public Operacione As New List(Of Operaciones)()
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


        Dim V1 As New Vehiculos
        'Vehiculo
        V1.Codigo = 325
        V1.Nombre_modelo = "Fiat Fiorino"
        V1.Dominio = "AE854585"



        Dim Ope As New Operaciones
        Ope.Codigo = 124
        Dim cliente1 As Clientes = New Clientes With
        {
        .Codigo = 4,
        .Apellido = "Martinez",
        .Nombre = "Jose",
        .Domicilio = "CABA"
         }
        Ope.Cliente = cliente1
        Dim vehiculo As Vehiculos = New Vehiculos With
            {
            .Codigo = 423,
            .Nombre_modelo = "Fiat Cronos",
            .Dominio = "AE324123"
            }
        Ope.Vehiculo = vehiculo
        Ope.Fecha_alta = Now()


        Dim Ope1 As New Operaciones
        Ope1.Codigo = 323
        Dim cliente2 As Clientes = New Clientes With
        {
        .Codigo = 5,
        .Apellido = "Reati",
        .Nombre = "Diego",
        .Domicilio = "CABA"
         }
        Ope1.Cliente = cliente2
        Dim vehiculo1 As Vehiculos = New Vehiculos With
            {
            .Codigo = 403,
            .Nombre_modelo = "Fiat Uno",
            .Dominio = "AE322323"
            }
        Ope1.Vehiculo = vehiculo1
        Ope1.Fecha_alta = Now()

        Operacione.Add(Ope)
        Operacione.Add(Ope1)




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cliente_get.Click
        'Clientes_get
        For Each item As Clientes In Cliente
            MsgBox("Codigo: " + item.Codigo.ToString + ", Apellido: " + item.Apellido + ", Nombre: " + item.Nombre + ", Domicilio: " + item.Domicilio)
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Operaciones_get(124)

    End Sub

    Public Function Operaciones_get(Cod As Integer)


        For Each item As Operaciones In Operacione
            If item.Codigo = Cod Then
                Return MsgBox(item.Codigo.ToString + " , " + item.Cliente.Apellido + " , " + item.Cliente.Domicilio)
                Exit For
            Else
                Return MsgBox("No Existe el codigo " + Cod.ToString)
            End If
        Next



    End Function

    Private Sub Alta_Click(sender As Object, e As EventArgs) Handles Alta.Click
        Dim Ope As New Operaciones
        Ope.Codigo = 324
        Dim cliente1 As Clientes = New Clientes With
        {
        .Codigo = 5,
        .Apellido = "Reati",
        .Nombre = "Diego",
        .Domicilio = "CABA"
         }
        Ope.Cliente = cliente1
        Dim vehiculo As Vehiculos = New Vehiculos With
            {
            .Codigo = 403,
            .Nombre_modelo = "Fiat Uno",
            .Dominio = "AE322323"
            }
        Ope.Vehiculo = vehiculo
        Ope.Fecha_alta = Now()

        MsgBox("Se agrego a Operaciones: Codigo " + Ope.Codigo.ToString + "," + "Codigo Cliente: " + Ope.Cliente.Codigo.ToString + " Apellido: " + Ope.Cliente.Apellido +
                                                    " Nombre: " + Ope.Cliente.Nombre + " Vehiculo: " + Ope.Vehiculo.Nombre_modelo + " Fecha:" + Ope.Fecha_alta)
    End Sub
End Class
