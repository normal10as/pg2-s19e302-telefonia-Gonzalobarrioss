Imports TelefoniaEntidades
Module ModeloTest
    Public Sub modelo()
        Dim modelo1 As New Modelo("E5 PLAY", New Marca("Motorola"))
        Console.WriteLine("Nombre modelo: " & modelo1.Nombre)
        Console.WriteLine("Nombre marca: " & modelo1.Marca.toString)
        Dim marca1 As Marca = modelo1.Marca
        Console.WriteLine("ToString: " & modelo1.toString())
    End Sub
End Module
