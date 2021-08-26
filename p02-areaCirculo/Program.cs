// Calcular el área de un circulo

using System;

namespace p02_areaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            float radio=0;
            double area=0;
            Console.WriteLine("Área de un Círculo");
            Console.WriteLine("Proporciona el Radio (r)= ");
            radio = float.Parse(Console.ReadLine() );
            area = Math.PI * Math.Pow(radio,2);
            Console.WriteLine($"El área del círculo es {area}");


        }
    }
}