Imports TelefoniaEntidades
Module MarcaTest
    Public Sub marca()
        Dim marca1 As New Marca("motorola")
        Console.WriteLine("Nombre marca: " & marca1.NombreMarca)
        Console.WriteLine("ToString: " & marca1.toString())
    End Sub
End Module
