using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.Write("Введите значение N: ");
            N = Convert.ToInt16(Console.ReadLine());

            double[,] massive = new double[N,N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (((i % 2 == 0) && (j % 2 == 0)) || ((i % 2 == 1) && (j % 2 == 1)))
                    {
                        massive[i, j] = 1;
                    }
                    else
                    {
                        massive[i, j] = 0;
                    }
                    
                    Console.Write(massive[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
