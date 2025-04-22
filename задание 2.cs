using System;

class Program
{
    static void Main()
    {
        // Ввод чисел A и B
        Console.WriteLine("Введите два целых числа A и B (A < B, 1 <= A, B <= 100):");
        Console.Write("A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        // Проверка входных данных на соответствие условиям
        if (A >= B || A < 1 || B > 100)
        {
            Console.WriteLine("Ошибка: числа должны удовлетворять условиям (A < B и 1 <= A, B <= 100).");
            return;
        }

        // Вывод всех целых чисел от A до B и подсчет их количества
        int count = 0;
        Console.WriteLine("Целые числа между A и B (включительно):");
        for (int i = A; i <= B; i++)
        {
            Console.Write(i + " ");
            count++;
        }

        // Переход на новую строку
        Console.WriteLine();

        // Вывод количества чисел
        Console.WriteLine("Количество чисел N: " + count);
    }
}
