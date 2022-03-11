using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int massiveLength = 10;
            double[] massive = new double[massiveLength];
            double temp;

            Random random = new Random();

            for (int i = 0; i < massiveLength; i++)
            {
                massive[i] = random.Next(-50, 50);
                Console.Write(massive[i]);
                Console.Write("  ");
            }
            Console.WriteLine();

            for (int i = 0; i < massiveLength/2; i++)
            {
                for (int j = i+1; j < massiveLength/2; j++)
                {
                    if (massive[i]> massive[j])
                    {
                    temp = massive[i];
                    massive[i]=massive[j];
                    massive[j]=temp;
                    }
                }
            }

            for (int k = massiveLength/2; k < massiveLength; k++)
            {
                for (int s = k+1; s < massiveLength; s++)
                {
                    if (massive[k] < massive[s])
                    {
                        temp = massive[k];
                        massive[k] = massive[s];
                        massive[s] = temp;
                    }
                }
            }
            for (int i = 0; i < massiveLength; i++)
            {
                Console.Write(massive[i]);
                Console.Write("  ");
            }
            Console.ReadKey();
        }
    }
}
