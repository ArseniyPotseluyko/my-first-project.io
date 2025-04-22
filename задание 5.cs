using System;

class Program
{
    static void Main()
    {
        // Ввод числа
        Console.WriteLine("Введите целое число:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Проверка на четность
        if (number % 2 == 0)
        {
            Console.WriteLine("Число является четным.");
        }
        else
        {
            Console.WriteLine("Число является нечетным.");
        }
    }
}
