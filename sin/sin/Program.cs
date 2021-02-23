using System;

namespace sin
{
    class Program
    {
        static double Factorial(double valor)
        {
            double total = 1;
            for (int cont = 1; cont <= valor; cont++)
            {
                total *= cont;
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular a sin(x)");
            double x = 1.25;
            double sin = 0;
            int n = 100;


            for (int i = 0; i <= n; i++)
            {
                sin += ((Math.Pow(-1, i) / Factorial(2*i+1))*Math.Pow(x,2*i+1));
            }
            Console.WriteLine("Sin(x) >:3..........." + sin);
        }
    }
}
