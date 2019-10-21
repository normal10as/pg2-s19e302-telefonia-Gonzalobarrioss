Imports TelefoniaEntidades
Module ModeloTest
    Public Sub modelo()
        Dim modelo1 As New Modelo("E5 PLAY")
        Console.WriteLine("Nombre modelo: " & modelo1.Nombre)
        Console.WriteLine("ToString: " & modelo1.toString())
    End Sub
End Module
