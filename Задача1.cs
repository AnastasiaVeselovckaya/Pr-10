using System;

namespace Задача1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите до какого члена суммы проводятся вычисления: ");
            var n = int.Parse(Console.ReadLine());
            int x = 1;
            do
            {
                if (x != 0)
                {
                    Console.Write("Введите x: ");
                    x = int.Parse(Console.ReadLine());
                }

                if (x == 0)
                {
                    Console.Write("Введите x не равное нулю: ");
                    x = int.Parse(Console.ReadLine());
                }
            } while (x == 0);
            double Proc;
            double Fin = 0;

            for (int i = 1; i < n + 1; i++)
            {
                Proc = Math.Cos(i * x) / x;
                Fin = Fin + Proc;
            }

            Console.WriteLine("Сумма {0} членов: {1}", n, Fin);
            Console.ReadKey();
        }
    }
}
