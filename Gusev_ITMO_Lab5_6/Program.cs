using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            bool magicSquerYes=false;

            Console.Write("Введите значение N: ");
            N = Convert.ToInt16(Console.ReadLine());

            double[,] massive = new double[N, N];

            double[] massiveSumm = new double[2*N+2];

            double Sum=0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("Введите элемент массива, находящейся на {0} строке и {1} столбце: ", i, j);
                    massive[i, j] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            for (int i = 0; i < N; i++)
            {
                Sum=0;
                for (int j = 0; j < N; j++)
                {
                    Sum += massive[i, j];
                }
                massiveSumm[i]=Sum;
            }

            for (int j = 0; j < N; j++)
            {
                Sum = 0;
                for (int i = 0; i < N; i++)
                {
                    Sum += massive[i, j];
                }
                massiveSumm[N+j] = Sum;
            }

            Sum = 0;
            for (int i = 0; i < N; i++)
            {
                Sum+=massive[i,i];
            }
            massiveSumm[2*N] = Sum;

            Sum = 0;
            for (int i = 0; i < N; i++)
            {
                Sum += massive[i, N-1-i];
            }
            massiveSumm[2 * N + 1] = Sum;

            for (int i = 0; i < 2*N+2; i++)
            {
                if (massiveSumm[i] == massiveSumm[0])
                {
                    magicSquerYes = true;
                }
                else 
                {
                    magicSquerYes = false;
                    break;
                }
            }

            if (magicSquerYes == true)
            {
                Console.WriteLine("Введенный массив является магичекским квадратом");
            }
            else
            {
                Console.WriteLine("Введенный массив не является магичекским квадратом");
            }
            Console.ReadKey();
        }
    }
}
