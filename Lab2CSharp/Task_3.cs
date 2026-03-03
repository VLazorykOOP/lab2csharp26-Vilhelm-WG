namespace Lab2CSharp;
using System;

public class Task_3
{

        static int[,] Input(out int n)
        {
            Console.WriteLine("--- Task_3 ---");
            Console.Write("Введіть розмірність масиву: ");

            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Помилка: розмірність має бути додатним числом.");
                return new int[0, 0];
            }

            int[,] a = new int[n, n];
            for (int i = 0; i < n; ++i)
            for (int j = 0; j < n; ++j)
            {
                Console.Write("a[{0},{1}]= ", i, j);
                a[i, j] = int.Parse(Console.ReadLine());
            }

            return a;
        }
        static void Print(int[,] a, int n)
        {
            Console.WriteLine("Введена матриця: ");
            if (a.Length == 0) Console.WriteLine("Масив порожній.");
            else for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Форматуємо вивід, щоб числа стояли рівно (відступ у 4 символи)
                    Console.Write($"{a[i, j],4} ");
                }
                Console.WriteLine();
            }
        }

        public static void CalculateAvarage(int[,] Matrix, int n)
        {
            double sum = 0;
            int count = 0;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j < n - 1)
                    {
                        if (Matrix[i, j] != 0)
                        {
                            sum += Matrix[i, j];
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine("\n--- Результат обчислень ---");
            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine($"Знайдено ненульових елементів: {count}");
                Console.WriteLine($"Сума ненульових елементів: {sum}");
                Console.WriteLine($"Середнє арифметичне: {average:F2}");
            }
            else
            {
                Console.WriteLine("Ненульових елементів над побічною діагоналлю не знайдено.");
            }
        }
        
        

        public static void Run()
        {
            int n;
            int[,] Matrix = Input(out n);

            Print(Matrix, n);
            CalculateAvarage(Matrix, n);
        }
    }
