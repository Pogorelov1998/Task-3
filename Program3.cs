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
            Console.WriteLine("������� ���������� ��������� � �������");
            n = int.Parse(Console.ReadLine());
            int[] X = new int[n];
            Console.WriteLine("������� ������� �������");
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
            Console.WriteLine("�������� ������: ");
            for (i = 0; i < n; i++)
                Console.Write(X[i] + " ");
            Console.WriteLine("\n");
            Console.WriteLine("����������� ������� �������: " + min);
            Console.WriteLine("������ ������������ ������: " + nmin);
            Console.ReadKey();
        }
    }
}