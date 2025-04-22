using System;

class Program
{
    static void Main()
    {
        // Ввод координат точки
        Console.WriteLine("Введите координаты точки (x, y):");
        Console.Write("x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Проверка, находится ли точка во второй координатной четверти
        if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка лежит во второй координатной четверти.");
        }
        else
        {
            Console.WriteLine("Точка не лежит во второй координатной четверти.");
        }
    }
}
