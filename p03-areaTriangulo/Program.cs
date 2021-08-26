// Calcular el Área de un Triángulo

using System;

namespace p03_areaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, area;
            a = b = area = 0;
            Console.WriteLine("Área de un Tiángulo\n");
            Console.Write("Proporciona la base: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Proporciona la altura: ");
            a = float.Parse(Console.ReadLine());
            area = (b * a) / 2;           
            Console.Write($"Área del Triangulo es: {area}");
            

        }
    }
}
