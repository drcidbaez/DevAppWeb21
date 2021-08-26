// Calculo de pago de un trabajador

using System;

namespace p04_PagoTrabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, salida;
            int horas;
            float pago, pagobruto, impuesto, pagoneto;
            const float TASA = 0.3f;
            //Datos a capturar
            Console.WriteLine("Calculo de pago de un trabajador\n");
            Console.Write("Nombre: "); nombre = Console.ReadLine();
            Console.Write("Horas trabajadas: "); horas = int.Parse(Console.ReadLine());
            Console.Write("Pago por hora: "); pago = float.Parse(Console.ReadLine());
            //Calculo
            pagobruto = horas * pago;
            impuesto  = pagobruto * TASA;
            pagoneto  = pagobruto - impuesto;

            salida = $"\nEl trabajador {nombre}, trabajó {horas} horas, con un pago de $ {pago}\n" +
                     $"-Pago bruto: $ {pagobruto}\n-Impuesto: $ {impuesto}\n-Pago Neto: $ {pagoneto}";

            Console.WriteLine(salida);

        }
    }
}
