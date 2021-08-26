// Hola Mundo!
using System;

namespace p01_HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            DateTime fecha = DateTime.Now;
            Console.WriteLine("Hola Mundo! \n");
            Console.WriteLine("Nombre ?");
            nombre = Console.ReadLine();
            Console.WriteLine($"{nombre} Bienvenido al C#\n");
            Console.WriteLine($"Hoy es {fecha:d} y son las {fecha:t}");
            Console.WriteLine("\nHasta pronto");
            



        }
    }
}
