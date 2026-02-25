using System;

namespace Lab2CSharp;

public class Task_2
{
    public static void Run()
    {
        // Локальна функція для введення масиву
        static double[] Input()
        {
            Console.WriteLine("--- Task_2 ---");
            Console.Write("Введіть розмірність масиву: ");
            
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Помилка: розмірність має бути додатним числом.");
                return new double[0];
            }
            
            double[] a = new double[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write($"a[{i}]= ");
                // Додано TryParse для безпеки
                if (!double.TryParse(Console.ReadLine(), out a[i]))
                {
                    Console.WriteLine("Помилка введення, встановлено 0.");
                    a[i] = 0;
                }
            }
            return a;
        }
        
        // Метод для зміни мінімальних елементів
        static void Change(double[] a)
        {
            if (a.Length == 0) return;

            // Шукаємо мінімум
            double minVal = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < minVal) minVal = a[i];
            }

            // Замінюємо всі мінімальні значення на протилежні
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == minVal)
                {
                    a[i] = -a[i];
                }
            }
        }

        // Метод для виведення масиву
        static void Print(double[] a)
        {
            if (a.Length == 0) Console.WriteLine("Масив порожній.");
            else Console.WriteLine(string.Join("  ", a));
        }

        // Основна логіка Run
        double[] myVector = Input();
        
        Console.WriteLine("\nПочатковий масив:");
        Print(myVector);

        Change(myVector);

        Console.WriteLine("\nЗмінений масив (мінімуми замінено на протилежні):");
        Print(myVector);
    }
}