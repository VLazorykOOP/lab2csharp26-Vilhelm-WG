namespace Lab2CSharp;

public class Task_1
{
        static int[] Input()
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

        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }

        static void Change(int[] a)
        {
            Console.Write("Введіть число для перевірки кратності: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.Length; ++i)
                if (a[i] < 0 && a[i] % k !=0)
                    a[i] = -a[i];
        }

        public static void Run()
        {
            int[] myArray = Input();
            Console.WriteLine("Вихідний масив:");
            Print(myArray);
            Change(myArray);
            Console.WriteLine("Змінений массив:");
            Print(myArray);

        }
    }
