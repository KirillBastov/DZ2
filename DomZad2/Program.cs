using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double kol = 0;
            double sum = 0;
            double x;

            Console.WriteLine("Введите число!\nЕсли хотите выйти из программы введите 0!  ");

            do
            {
                Console.Write($"Число {kol + 1} = ");
                x = double.Parse(Console.ReadLine());

                if (x != 0)
                {
                    kol++;
                    sum += x;
                }
            } while (x != 0);

            Console.WriteLine($"Количество чисел :  {kol}");
            Console.WriteLine($"Сумма : {sum}");
            Console.WriteLine($"Среднее арифметическое : {sum / kol }");

            Console.ReadLine();

        }

    }
}
