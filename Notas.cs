using System;
using System.Collections.Generic;

class Notas
{
    // Lista donde se guardan las asignaturas del curso
    private List<string> materias = new List<string>()
    {
        "Matemáticas",
        "Física",
        "Química",
        "Historia",
        "Lengua"
    };

    // Diccionario que relaciona cada materia con su nota
    private Dictionary<string, double> notas = new Dictionary<string, double>();

    // Método para pedir las notas al usuario
    public void IngresarNotas()
    {
        foreach (string materia in materias)
        {
            Console.Write($"Ingrese la nota de {materia}: ");

            double nota;

            // Este while evita que el usuario ingrese letras u otros valores incorrectos
            while (!double.TryParse(Console.ReadLine(), out nota))
            {
                Console.Write("Entrada inválida. Ingrese un número válido: ");
            }
            // Guardamos la nota junto con la materia correspondiente
            notas[materia] = nota;
        }
    }

    // Método para mostrar las notas ingresadas
    public void MostrarNotas()
    {
        foreach (var item in notas)
        {
            Console.WriteLine($"En {item.Key} has sacado {item.Value}");
        }
    }
}