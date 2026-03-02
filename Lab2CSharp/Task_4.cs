namespace Lab2CSharp;

//Дано східчастий масив з n рядків, у рядках по mj (j=1..n) елементів.
//Для кожного стовпця підрахувати суму від’ємних елементів і записати дані в новий масив.

public class Task_4
{
    static int[][] Input()
    {
        Console.Write("Введіть розмірність масиву: ");

        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Помилка: розмірність має бути додатним числом.");
        }

        int[][] a = new int[n][];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть кількість елементів у рядку {i} (m{i}): ");
            int m = int.Parse(Console.ReadLine() ?? "0");
            a[i] = new int[m];

            for (int j = 0; j < m; ++j)
            {
                Console.Write($"a[{i}][{j}] = ");
                a[i][j] = int.Parse(Console.ReadLine() ?? "0");
            }

        }


        return a;
    }

    static void Print(int[][] a)
    {
        Console.WriteLine("Введена матриця: ");
        if (a.Length == 0) Console.WriteLine("Масив порожній.");
        foreach (var row in a)
        {
            foreach (var item in row)
            {
                Console.Write($"{item,4} ");
            }

            Console.WriteLine();
        }
    }

    static int[] CalculateNegativeSums(int[][] a)
    {
        // Знаходимо максимальну довжину рядка, щоб знати кількість стовпців
        int maxCols = 0;
        foreach (var row in a)
            if (row.Length > maxCols)
                maxCols = row.Length;

        int[] sums = new int[maxCols];

        for (int j = 0; j < maxCols; j++) // Йдемо по стовпцях
        {
            int currentSum = 0;
            for (int i = 0; i < a.Length; i++) // Йдемо по рядках
            {
                // Перевіряємо, чи існує такий стовпець у поточному рядку
                if (j < a[i].Length && a[i][j] < 0)
                {
                    currentSum += a[i][j];
                }
            }

            sums[j] = currentSum;
        }

        return sums;
    }


    public static void Run()
    {
        Console.WriteLine("--- Task_4: Східчастий масив ---");

        int[][] array = Input();
        if (array.Length == 0) return;

        Print(array);

        // Обчислення суми від’ємних елементів по стовпцях
        int[] columnSums = CalculateNegativeSums(array);

        Console.WriteLine("\nСуми від’ємних елементів у стовпцях:");
        for (int j = 0; j < columnSums.Length; j++)
        {
            Console.WriteLine($"Стовпець {j}: {columnSums[j]}");
        }
    }
}
