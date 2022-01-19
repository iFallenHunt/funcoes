using System;

namespace funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números: ");

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            double resultado = Maior(x, y, z);

            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior (int a, int b, int c)
        {
            int m;
            if (a >b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }

    }

}
