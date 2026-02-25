namespace Lab2CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Lab 1 - меню");
                Console.WriteLine("6 - Task 5 (Формула)");
                Console.WriteLine("5 - Task 5 (Добуток цілих чисел)");
                Console.WriteLine("4 - Task 4 (Масті)");
                Console.WriteLine("3 - Task 3 (перевірка належності точки)");
                Console.WriteLine("2 - Task 2 (перевірка парності)");
                Console.WriteLine("1 - Task 1 (відстань між точками)");
                Console.WriteLine("0 - Вихід");
                Console.Write("Ваш вибір: ");

                string? choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "6":
                        Task_6.Run();
                        break;
        
                    case "5":
                        Task_5.Run();
                        break;
        
                    case "4":
                        Task_4.Run();
                        break;
        
                    case "3":
                        Task_3.Run();
                        break;
        
                    case "2":
                        Task_2.Run();
                        break;
        
                    case "1":
                        Task1.Run();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
        }
    }
}
