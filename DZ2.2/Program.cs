using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту треугольника: ");
            int vys = int.Parse(Console.ReadLine());


            for (int i = 0; i < vys; i++)
            {
                for (int j = vys; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int o = vys - 2 * i; o <= vys; o++)
                {
                    Console.Write("^");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
