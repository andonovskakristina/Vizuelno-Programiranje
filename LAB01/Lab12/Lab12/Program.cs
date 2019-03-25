using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Min(int[] array, out int min)
        {
            min = int.MaxValue;

            foreach(int i in array)
            {
                if (min > i)
                    min = i;
            }
        }

        static void Max(int[] array, out int max)
        {
            max = int.MinValue;

            foreach (int i in array)
            {
                if (max < i)
                    max = i;
            }
        }

        static double Average(int[] array)
        {
            int sum = 0;
            foreach(int i in array)
            {
                sum += i;
            }
            return (double)sum / array.Length;
        }

        static void Main(string[] args)
        {
            int num;
            bool ifRandom;

            while (true)
            {
                Console.WriteLine("Внесете 1 за внесување на броевите или 2 за случајно генерирање.");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    ifRandom = false;
                    break;
                }
                else if (input == 2)
                {
                    ifRandom = true;
                    break;
                }
                else
                    Console.WriteLine("Невалиден внес, изберете помеѓу 1 и 2!");
            }

            Console.WriteLine("Внесете го бројот N.");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[N];

            if (!ifRandom)
            {
                Console.WriteLine("Внесете {0} броеви одделени со нов ред.", N);
            }

            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                if (!ifRandom)
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    num = random.Next(1, 1000);
                }

                array[i] = num;
            }

            Min(array, out int min);
            Max(array, out int max);

            Console.WriteLine("Од {0}-те броеви:", N);
            Console.WriteLine("\t - минимален број е: {0}\n\t - максимален број е: {1}\n\t - средна вредност е: {2}", min, max, Average(array));
            Console.ReadKey();
        }
    }
}
