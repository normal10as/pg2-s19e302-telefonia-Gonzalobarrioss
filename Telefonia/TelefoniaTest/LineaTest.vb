Imports TelefoniaEntidades
Module LineaTest
    Public Sub linea()
        Dim marca1 As New Marca("SAmsung")
        Dim modelo1 As New Modelo("S8+", marca1)
        Dim equipo1 As New Equipo(modelo1, "7324632463274")
        Dim linea1 As New Linea(376, 4804323, equipo1)
        Console.WriteLine("Codigo area + numero: {0}{1}", linea1.CodigoArea, linea1.Numero)
        Console.WriteLine("Estado de linea: " & linea1.Estado)
        Console.WriteLine("Suspendo la linea")
        linea1.suspender()
        Console.WriteLine("Estado de linea: " & linea1.Estado)
        Console.WriteLine("toString: " & linea1.toString)
        Console.WriteLine("activo la linea")
        linea1.reactivar()
        Console.WriteLine("Estado de linea: " & linea1.Estado)
        Console.WriteLine("toString: " & linea1.toString)

    End Sub
End Module
