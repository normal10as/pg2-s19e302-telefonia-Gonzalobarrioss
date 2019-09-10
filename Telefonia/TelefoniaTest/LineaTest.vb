Imports TelefoniaEntidades
Module LineaTest
    Public Sub linea()
        Dim linea1 As New Linea(3764, 804323)
        Console.WriteLine("Codigo area + numero: {0}{1}", linea1.CodigoArea, linea1.Numero)
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
