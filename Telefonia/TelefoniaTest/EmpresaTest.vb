Imports TelefoniaEntidades
Module EmpresaTest
    Public Sub empresa()
        Dim empresa1 As New Empresa("S.R.L", "20-439843-2")
        Console.WriteLine("Razon social empresa: {0}, CUIT: {1}", empresa1.RazonSocial, empresa1.Cuit)
        Console.WriteLine("toString: " & empresa1.toString())
    End Sub

End Module
