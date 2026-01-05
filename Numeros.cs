using System;
using System.Collections.Generic;

class Numeros
{
    public void MostrarNumerosInversos()
    {
        // Creamos la lista de números del 1 al 10
        List<int> numeros = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        // Invertimos el orden de la lista
        numeros.Reverse();

        // Mostramos los números separados por comas
        Console.WriteLine(string.Join(", ", numeros));
    }
}
