Imports TelefoniaEntidades
Module EquipoTest
    Public Sub equipo()
        Dim equipo1 As New Equipo()
        ' equipo1.SerieEquipo("1")
        Console.WriteLine("Fecha de venta:" & equipo1.FechaVenta())
        Console.WriteLine("ToString: " & equipo1.toString)
    End Sub
End Module
