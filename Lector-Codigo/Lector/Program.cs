using System;
using System.IO;

class ProgramaPSP
{
    static void Main(string[] args)
    {
        // Pedir rutas
        Console.WriteLine("Escribe la ruta del archivo ORIGINAL:");
        string rutaOriginal = Console.ReadLine().Trim();

        Console.WriteLine("Escribe la ruta del archivo MODIFICADO:");
        string rutaNuevo = Console.ReadLine().Trim();

        // Verificar existencia
        if (!File.Exists(rutaOriginal) || !File.Exists(rutaNuevo))
        {
            Console.WriteLine("Alguno de los archivos no existe.");
            return;
        }

        // Leer contenido
        string[] original = File.ReadAllLines(rutaOriginal);
        string[] nuevo = File.ReadAllLines(rutaNuevo);

        // Contar diferencias
        int diferencias = ContarDiferenciasLineaPorLinea(original, nuevo);

        // Mostrar análisis del original
        Console.WriteLine("\n--- Análisis del archivo ORIGINAL ---");
        AnalizarArchivo(original);

        // Mostrar análisis del modificado
        Console.WriteLine("\n--- Análisis del archivo MODIFICADO ---");
        AnalizarArchivo(nuevo);

        // Mostrar diferencias
        Console.WriteLine($"\nLíneas modificadas entre ambos archivos: {diferencias}");

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();

    }

    // Método para analizar un archivo (LOC, comentarios, blancos, clases, métodos)
    static void AnalizarArchivo(string[] lineas)
    {
        int totalLineas = lineas.Length;
        int lineasCodigo = 0, lineasComentario = 0, lineasBlanco = 0;
        int clases = 0, metodos = 0;
        bool dentroComentarioMultilinea = false;

        foreach (var linea in lineas)
        {
            string l = linea.Trim();

            // Contar líneas en blanco
            if (string.IsNullOrWhiteSpace(l))
            {
                lineasBlanco++;
                continue;
            }

            // Contar comentarios
            if (dentroComentarioMultilinea)
            {
                lineasComentario++;
                if (l.Contains("*/")) dentroComentarioMultilinea = false;
                continue;
            }
            if (l.StartsWith("//"))
            {
                lineasComentario++;
                continue;
            }
            if (l.StartsWith("/*"))
            {
                lineasComentario++;
                if (!l.Contains("*/")) dentroComentarioMultilinea = true;
                continue;
            }

            // Si no es comentario ni blanco, es línea de código
            lineasCodigo++;

            // Buscar clases
            if (l.Contains("class "))
                clases++;

            // Buscar métodos (simplificado)
            if ((l.StartsWith("public") || l.StartsWith("private") || l.StartsWith("protected") || l.StartsWith("internal"))
                && l.Contains("(") && l.Contains(")"))
            {
                metodos++;
            }
        }

        // Mostrar resultados
        Console.WriteLine($"Total de líneas: {totalLineas}");
        Console.WriteLine($"Líneas de código (LOCs): {lineasCodigo}");
        Console.WriteLine($"Líneas de comentarios (LOCcs): {lineasComentario}");
        Console.WriteLine($"Líneas en blanco: {lineasBlanco}");
        Console.WriteLine($"Clases encontradas: {clases}");
        Console.WriteLine($"Métodos encontrados: {metodos}");
    }

    // Método para contar diferencias línea por línea
    static int ContarDiferenciasLineaPorLinea(string[] a, string[] b)
    {
        int max = Math.Max(a.Length, b.Length);
        int dif = 0;

        for (int i = 0; i < max; i++)
        {
            string lineaA = (i < a.Length) ? a[i].Trim() : "";
            string lineaB = (i < b.Length) ? b[i].Trim() : "";

            if (lineaA != lineaB)
                dif++;
        }

        return dif;
    }
}
