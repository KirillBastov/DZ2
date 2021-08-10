using System;
using System.Data;
class Program
{
    static void Main(string[] args)
    {

        bool quit = false;
        bool flag = false;

        double a = 0;
        double b = 0;
        double total;

        char operation = '0';

        coloryelow();
        Console.WriteLine();
        Console.WriteLine(" + : Cложение чисел");
        Console.WriteLine(" - : Вычетание чисел");
        Console.WriteLine(" * : Умножение чисел");
        Console.WriteLine(" / : Деление чисел");
        Console.WriteLine(" ^ : Возведение в степень");
        Console.WriteLine(" F : Факториал");
        Console.WriteLine(" V : Вычисление выражения в одну строку ");
        Console.WriteLine(" Q : ВЫХОД из консольной программы ");
        Console.WriteLine();
        colorwhite();

        do
        {
            try
            {
                coloryelow();
                Console.Write("Укажите операцию: ");
                colorwhite();
                operation = Convert.ToChar(Console.ReadLine());
                if (operation == 'F')
                {
                    a = namber1();
                }

                else if (operation == '^')
                {
                    a = namber();
                    b = namber2();
                }
                else if (operation == '/')
                {
                    colorred();
                    Console.WriteLine("\n    Внимение предупреждение!!!\n      Деление на 0 запрещено\n");
                    colorwhite();
                    a = namber();
                    b = namber0();
                }
                else if (operation == 'V')
                {
                    virazenie();
                }
                else if (operation == 'Q' || operation == 'q')
                {
                    quit = true;
                }
                else
                {
                    a = namber();
                    b = namber0();
                }
            }
            catch
            {
                flag = true;
                colorred();
                Console.WriteLine("\aError: следуйте указаниям!!!");
                colorwhite();
            }
            if (!flag)
            {
                switch (operation)
                {
                    case '+':
                        colorgren();
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        colorwhite();
                        break;
                    case '-':
                        colorgren();
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        colorwhite();
                        break;
                    case '*':
                        colorgren();
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        colorwhite();
                        break;
                    case '/':
                        if (b != 0 && a != 0)
                        {
                            colorgren();
                            Console.WriteLine($"{a} / {b} = {a / b}");
                            colorwhite();
                        }
                        else
                        {
                            colorred();
                            Console.WriteLine("\aError: следуйте указаниям!!!");
                            colorwhite();
                        }
                        break;
                    case '^':
                        total = Math.Pow(a, b);
                        colorgren();
                        Console.WriteLine($"Число {a} в степени {b} = {total}");
                        colorwhite();
                        break;
                    case 'F':
                        {
                            double factorial = 1;
                            for (int i = 1; i <= a; i++)
                            {
                                factorial *= i;
                            }
                            colorgren();
                            Console.WriteLine($"Факториал числа {a} = {factorial}");
                            colorwhite();
                            break;
                        }
                    case 'V':
                        {
                            String s = Console.ReadLine();
                            colorgren();
                            Console.WriteLine($"{s} = {Evaluate(s)}");
                            colorwhite();
                            break;
                        }
                    default:
                        {
                            colorred();
                            Console.WriteLine("\aError: следуйте указаниям!!!");
                            colorwhite();
                        }
                        break;
                }
            }
            flag = false;
        }
        while (!quit);

    }
    static double namber()
    {
        coloryelow();
        Console.WriteLine("Введите число: ");
        colorwhite();
        var user = Console.ReadLine();
        var x = Convert.ToDouble(user);
        return x;
    }
    static double namber0()
    {
        coloryelow();
        Console.WriteLine("Введите второе число: ");
        colorwhite();
        var user = Console.ReadLine();
        var x = Convert.ToDouble(user);
        return x;

    }
    static double namber2()
    {
        coloryelow();
        Console.WriteLine("Введите степень в которую хотите возвести: ");
        colorwhite();
        var user = Console.ReadLine();
        var x = Convert.ToDouble(user);
        return x;
    }
    public static double Evaluate(string e)
    {
        DataTable t = new DataTable();
        t.Columns.Add("e", typeof(string), e);
        DataRow r = t.NewRow();
        t.Rows.Add(r);
        return double.Parse((string)r["e"]);
    }
    static double namber1()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n    Вычисление факториала числа!\n          Введите число: ");
        colorwhite();
        var user = Console.ReadLine();
        var x = Convert.ToDouble(user);
        return x;
    }
    static void virazenie()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n       ИНСТРУКЦИЯ ПОЛЬЗОВАТЕЛЯ\nВведите число:\nЗатем введите один из знаков (*,/,-,+):\nЗатем второе число:\nИ так далее.\nКогда захотите узнать результат нажмите Enter:\n\nВведите выражение:");
        colorwhite();
        return;
    }
    static void colorred()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        return;
    }
    static void colorgren()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        return;
    }
    static void colorwhite()
    {
        Console.ForegroundColor = ConsoleColor.White;
        return;
    }
    static void coloryelow()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        return;
    }
}
