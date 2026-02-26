namespace Lab2CSharp;

public class Task_3
{
    public static void Run()
    {
        Console.WriteLine("Вихідний масив:");
    }
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
}