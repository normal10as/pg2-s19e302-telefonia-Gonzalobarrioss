Imports TelefoniaEntidades
Module EquipoTest
    Public Sub equipo()
        Dim equipo1 As New Equipo(New Modelo("E5 Play",
            New Marca("Motorola")), "123456789012345")
        Console.WriteLine("serie: " & equipo1.Serie)
        Console.WriteLine("ToString: " & equipo1.toString)
        Console.WriteLine("Fecha de venta:" & equipo1.FechaVenta())
        equipo1.vender(Date.Now())
        Console.WriteLine("Fecha de venta:" & equipo1.FechaVenta())
        Console.WriteLine("Modelo ToString: " & equipo1.Modelo.toString)
    End Sub
End Module
