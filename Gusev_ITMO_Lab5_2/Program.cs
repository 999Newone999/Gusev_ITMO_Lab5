using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int massiveLength = 15;
            double[] massive = new double[massiveLength];
            double MIN;
            double MAX;

            Random random = new Random();

            for (int i = 0; i < massiveLength; i++)
            {
                massive[i] = random.Next(0, 50);
                Console.WriteLine(massive[i]);
            }
            MIN=massive[0];
            MAX=massive[0];
            for (int i = 0; i < massiveLength; i++)
            {
                if (massive[i] < MIN)
                {
                    MIN= massive[i];
                }
                if (massive[i] > MAX)
                {
                    MAX = massive[i];
                }
            }
            Console.WriteLine("Сумма минимального и максимального элемента {0} + {1} = {2}",MIN, MAX, (MIN+MAX));
            Console.ReadKey();
        }
    }
}
