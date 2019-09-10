Imports TelefoniaEntidades
Module PersonaTest
    Public Sub persona()
        Dim persona1 As New Persona("Pepe", "Gomez", 42543098)
        Console.WriteLine("Apellido y nombre: {0} {1}, DNI:{2}", persona1.Nombre, persona1.Apellido, persona1.Documento)
        Console.WriteLine("toString: " & persona1.toString)
    End Sub
End Module
