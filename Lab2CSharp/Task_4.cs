namespace Lab2CSharp;

//Дано східчастий масив з n рядків, у рядках по mj (j=1..n) елементів.
//Для кожного стовпця підрахувати суму від’ємних елементів і записати дані в новий масив.

public class Task_4
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
    public static void Run()
    {
        Console.WriteLine("Вихідний масив:");
    }
}
