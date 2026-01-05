using System;
using System.Collections.Generic;

class Asignaturas
{
    // Lista donde se guardan las materias
    private List<string> materias;

    // Constructor: se ejecuta automáticamente al crear el objeto
    public Asignaturas()
    {
        // Aquí inicializamos la lista con las asignaturas
        materias = new List<string>()
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };
    }

    // Método para mostrar las asignaturas en pantalla
    public void MostrarAsignaturas()
    {
        // Recorremos la lista una por una
        foreach (string materia in materias)
        {
            Console.WriteLine(materia);
        }
    }
}
