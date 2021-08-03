using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int nech = 0;
            int sumnech = 0;


            Console.Write("Начало диапазона: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Конец диапазона: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Нечётные числа: ");
            while (x <= y)
            {
                if (x % 2 != 0)
                {

                    sumnech = sumnech + x;
                    nech++;

                    Console.Write($"{x} ");

                }
                x++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nСумма нечётных чисел: {sumnech}");
            Console.ReadLine();
        }

    }
}
