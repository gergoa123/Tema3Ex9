using System;

namespace Tema3Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inrtoduceti lungimea: ");
            int lungime = int.Parse(Console.ReadLine());
            Console.WriteLine("Inrtoduceti latimea: ");
            int latime = int.Parse(Console.ReadLine());

            

            double Calcdiagonala = Diagonal(latime, lungime);
            

            Console.WriteLine("Diagonala = " + Calcdiagonala);
        }

        static double Diagonal(int n, int m)
        {
            double diagonala = Math.Sqrt(n * n + m * m);

            return diagonala;
        }
    }
}
