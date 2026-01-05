using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== EJERCICIO 1 =====");
        Asignaturas asignaturas = new Asignaturas();
        asignaturas.MostrarAsignaturas();

        Console.WriteLine("\n===== EJERCICIO 2 =====");
        Estudio estudio = new Estudio();
        estudio.MostrarMensaje();

        Console.WriteLine("\n===== EJERCICIO 3 =====");
        Notas notas = new Notas();
        notas.IngresarNotas();
        notas.MostrarNotas();

        Console.WriteLine("\n===== EJERCICIO 5 =====");
        Numeros numeros = new Numeros();
        numeros.MostrarNumerosInversos();

        Console.WriteLine("\n===== EJERCICIO 10 =====");
        Precios precios = new Precios();
        precios.MostrarMayorYMenor();

        Console.WriteLine("\nPrograma finalizado. Presione una tecla para salir...");
        Console.ReadKey();
    }
}
