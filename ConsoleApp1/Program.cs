using System;
using System.Collections.Generic; // Obligatorio para usar Diccionarios

class Program
{
    static void Main()
    {
        // 1. Creamos el diccionario
        Dictionary<string, string> capitales = new Dictionary<string, string>
        {
            { "España", "Madrid" },
            { "Colombia", "Bogotá" },
            { "Japón", "Tokio" }
        };

        // 2. Imprimimos el contenido para verificar que funciona
        Console.WriteLine("--- Lista de Países y Capitales ---");
        foreach (var par in capitales)
        {
            Console.WriteLine($"País: {par.Key} -> Capital: {par.Value}");
        }

        // 3. Esto evita que la consola se cierre sola
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}