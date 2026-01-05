using System;
using System.Collections.Generic;
using System.Linq;

class Precios
{
    // Lista con los precios dados en el ejercicio
    private List<int> precios = new List<int>()
    {
        50, 75, 46, 22, 80, 65, 8
    };

    public void MostrarMayorYMenor()
    {
        // Obtenemos el precio menor y mayor
        int menor = precios.Min();
        int mayor = precios.Max();

        Console.WriteLine($"El precio menor es: {menor}");
        Console.WriteLine($"El precio mayor es: {mayor}");
    }
}
