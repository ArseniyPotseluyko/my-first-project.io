using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число N (1 <= N <= 20):");
        int n = int.Parse(Console.ReadLine());
        double result = 0.0;

        for (int i = 1; i <= n; i++)
        {
            double term = 1.0 + i / 10.0; // вычисляем текущий член последовательности
            if (i % 2 == 0) // если индекс чётный, вычитаем
            {
                result -= term;
            }
            else // если индекс нечётный, прибавляем
            {
                result += term;
            }
        }

        Console.WriteLine($"Результат: {result:F4}");
    }
}
