using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int massiveLength = 7;
            double[] massive = new double[massiveLength];
            double Average=0;

            for (int i = 0; i < massiveLength-1; i++)
            {
                Console.Write("Введите {0}-й член массива: ", (i+1));
                
                massive[i] = Convert.ToDouble(Console.ReadLine());
                Average += massive[i];
            }
            Average = Average /massiveLength;
            Console.WriteLine("Среднее арифметическое элементов массива равно: {0}", Average);
            Console.ReadKey();
        }
    }
}
