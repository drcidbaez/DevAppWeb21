// Calcular el área de un circulo

using System;

namespace p02_areaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            float radio=0; //Definir variable
            double area=0;
            Console.WriteLine("Área de un Círculo");
            Console.WriteLine("Proporciona el Radio (r)= ");
            radio = float.Parse(Console.ReadLine() );
            area = Math.PI * Math.Pow(radio,2); //Elevar al cuadrado
            Console.WriteLine($"El área del círculo es {area}");

            /* radio = float.Parse(Console.ReadLine() );
            area = Math.PI * Math.Pow(radio,2); //Elevar al cuadrado
            Console.WriteLine($"El área del círculo es {area}"); */


        }
    }
}