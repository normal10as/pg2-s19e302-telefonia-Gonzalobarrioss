Imports TelefoniaEntidades
Module LineaTest
    Public Sub linea()
        Dim linea1 As New Linea(3764, 804323)
        Console.WriteLine("Codigo area + numero: {0}{1}", linea1.CodigoArea, linea1.Numero)
    End Sub
End Module
