using System;
using System.Threading;

namespace OOP_lab_2_14_5
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Введiть розмiри матрицi");

            string str = Console.ReadLine();

            string[] elements = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(elements[0]);
            int m = int.Parse(elements[1]);

            if (n != m)
            {
                Console.WriteLine("Матриця не квадратна!");

                goto Start;
            }

            int[][] A = new int[n][];

        Key:
            Console.WriteLine("Генерувати елементи матрицi випадково? (Y/N)");

            ConsoleKey key = Console.ReadKey().Key;

            Console.WriteLine();


            if (key == ConsoleKey.Y)
            {
                Random random = new Random();

                for (int i = 0; i < n; ++i)
                {
                    A[i] = new int[n];

                    for (int j = 0; j < n; ++j)
                    {
                        A[i][j] = random.Next(-100, 100);
                    }
                }

                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        Console.Write("{0,-5}", A[i][j]);
                    }

                    Console.WriteLine();
                }
            }
            else if (key == ConsoleKey.N)
            {
                for (int i = 0; i < n; ++i)
                {
                    A[i] = new int[n];

                    str = Console.ReadLine();

                    elements = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    int j = 0;

                    foreach (string element in elements)
                    {
                        A[i][j] = int.Parse(element);

                        ++j;

                        if (j >= n)
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                goto Key;
            }


            int s = 0;

            for (int i = 0; i < n; ++i)
            {
                s += A[i][A[i].Length - 1 - i];
            }

            Console.WriteLine("Cереднє арифметичне елементiв бiчної дiагоналi матрицi: {0}", s / n);
        }
    }
}
