using System;

namespace p05_ciclos
{
    class Program
    {
        static int Main(string[] args)
        {
            if(args.Length==0) {
                Menu();
                return 1;
            }
            return 0;
        }

        static void Menu() {
            Console.Clear():
            Console.WriteLine("[ 1 ] 1 al 100 con While");
            Console.WriteLine("[ 2 ] 100 al 1 con do .. while ");
        }


    }
}
