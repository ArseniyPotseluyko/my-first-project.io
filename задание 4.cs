using System;

class Program
{
    static void Main()
    {
        // Ввод значения x
        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());

        // Вычисление значения функции y
        double y;
        if (x >= 10)
        {
            y = 4 + x * x - Math.Exp(Math.Sqrt(x));
        }
        else
        {
            y = 3.4 - x + 0.1 * x * x * x;
        }

        // Вывод результата
        Console.WriteLine("Значение y: " + y);
    }
}
