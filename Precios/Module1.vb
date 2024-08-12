Module Module1

    Sub Main()
        ' Declarar constantes y variables
        Const IVA As Double = 0.12
        Dim precioT As Double
        Dim montoIVA As Double
        Dim precioSinIVA As Double

        ' Solicitar 
        Console.Write("Ingrese el precio real en quetzales (con IVA incluido): Q")
        precioT = Convert.ToDouble(Console.ReadLine())

        ' Calcular el monto del IVA y el precio sin IVA
        montoIVA = precioT * IVA / (1 + IVA)
        precioSinIVA = precioT - montoIVA

        ' Mostrar los resultados
        Console.WriteLine("Desglose del precio:")
        Console.WriteLine("Precio sin IVA: Q" & Math.Round(precioSinIVA, 2))
        Console.WriteLine("Monto de IVA (12%): Q" & Math.Round(montoIVA, 2))
        Console.WriteLine("Precio total (con IVA): Q" & Math.Round(precioT, 2))

        Console.ReadLine() ' Pausa para ver el resultado final
    End Sub

End Module
