namespace Lab2CSharp;
using System;

public class Task_1
{
    static int[] Input_Vector()
    {
        Console.WriteLine("Розмірність масиву: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; ++i)
        {
            Console.Write("a[{0}]= ", i);
            a[i] = int.Parse(Console.ReadLine());
        }

        return a;
    }

    static void Print_Vector(int[] a)
    {
        for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
        Console.WriteLine();
    }

    static void Change_Vector(int[] a)
    {
        Console.Write("Введіть число для перевірки кратності: ");
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < a.Length; ++i)
            if (a[i] < 0 && a[i] % k != 0)
                a[i] = -a[i];
    }

    static int[,] Input_Matrix(out int n, out int m)
    {
        Console.WriteLine("Розмірність масиву ");
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("m = ");
        m = int.Parse(Console.ReadLine());
        int[,] a = new int[n, m];
        for (int i = 0; i < n; ++i)
        for (int j = 0; j < m; ++j)
        {
            Console.Write("a[{0},{1}]= ", i, j);
            a[i, j] = int.Parse(Console.ReadLine());
        }

        return a;
    }


    static void Print_Matrix(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
        for (int j = 0; j < a.GetLength(1); ++j)
            Console.Write("{0,5} ", a[i, j]);
    }


    static void Change_Matrix(int[,] a)
    {
        Console.Write("Введіть число для перевірки кратності: ");
        int k = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < a.GetLength(0); ++i)
        for (int j = 0; j < a.GetLength(1); ++j)
            if (a[i, j] < 0 && a[i, j] % k !=0)
                a[i, j] = -a[i, j];
    }



    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("\n--- Task 1: Робота з масивами ---");
            Console.WriteLine("1 - Одновимірний масив (Вектор)");
            Console.WriteLine("2 - Двовимірний масив (Матриця)");
            Console.WriteLine("0 - Повернутися до головного меню");
            Console.Write("Ваш вибір: ");

            string? subChoice = Console.ReadLine();

            if (subChoice == "0") break; // Вихід з циклу Task 1

            switch (subChoice)
            {
                case "1":
                    Console.WriteLine("\n-------- Одновимірний масив --------");
                    int[] myVector = Input_Vector();
                    Console.WriteLine("Вихідний масив:");
                    Print_Vector(myVector);

                    Change_Vector(myVector);

                    Console.WriteLine("Змінений масив:");
                    Print_Vector(myVector);
                    break;

                case "2":
                    Console.WriteLine("\n-------- Двовимірний масив --------");
                    int rows, cols;
                    int[,] myMatrix = Input_Matrix(out rows, out cols);

                    Console.WriteLine("Вихідна матриця:");
                    Print_Matrix(myMatrix);

                    Change_Matrix(myMatrix);

                    Console.WriteLine("Змінена матриця:");
                    Print_Matrix(myMatrix);
                    break;

                default:
                    Console.WriteLine("Невірний вибір у підменю.");
                    break;
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу, щоб продовжити...");
            Console.ReadKey();
        }
    }

}
