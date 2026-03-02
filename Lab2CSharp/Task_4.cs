namespace Lab2CSharp;

//Дано східчастий масив з n рядків, у рядках по mj (j=1..n) елементів.
//Для кожного стовпця підрахувати суму від’ємних елементів і записати дані в новий масив.

public class Task_4
{
    static int[] [] Input(int n)
    {
        Console.WriteLine("--- Task_3 ---");
        Console.Write("Введіть розмірність масиву: ");

        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
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
    


        public static void Run()
        {
            Console.WriteLine("Вихідний масив:");
        }
    }
