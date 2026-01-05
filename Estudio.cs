using System;
using System.Collections.Generic;

class Estudio
{
    // Lista con las materias que estudia el alumno
    private List<string> materias = new List<string>()
    {
        "Matemáticas",
        "Física",
        "Química",
        "Historia",
        "Lengua"
    };

    // Método que muestra el mensaje solicitado
    public void MostrarMensaje()
    {
        // Se recorre la lista y se imprime el mensaje
        foreach (string materia in materias)
        {
            Console.WriteLine($"Yo estudio {materia}");
        }
    }
}
