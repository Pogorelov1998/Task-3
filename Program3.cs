using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, min, nmin;
            Console.WriteLine("Введите количество элементов в массиве");
            n = int.Parse(Console.ReadLine());
            int[] X = new int[n];
            Console.WriteLine("Введите элемнты массива");
            for (i = 0; i < n; i++)
            {
                X[i] = int.Parse(Console.ReadLine());
            }
            min = X[0];
            nmin = 0;
            for (i = 0; i < n; i++)
            {
                if (X[i] < min)
                {
                    min = X[i];
                    nmin = i;
                }
            }
            Console.WriteLine("Исходный массив: ");
            for (i = 0; i < n; i++)
                Console.Write(X[i] + " ");
            Console.WriteLine("\n");
            Console.WriteLine("Минимальный элемент массива: " + min);
            Console.WriteLine("Индекс минимального элемен: " + nmin);
            Console.ReadKey();
        }
    }
}