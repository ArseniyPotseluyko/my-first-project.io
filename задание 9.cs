using System;

class Program
{
    static void Main()
    {
        // Заданные параметры
        double A = Math.PI / 4; // Начало интервала
        double B = Math.PI / 2; // Конец интервала
        int M = 15;            // Количество шагов
        double H = (B - A) / M; // Шаг табуляции

        // Вычисление и вывод значений функции
        Console.WriteLine("Табулирование функции F(x) = 2 - sin(x):");
        Console.WriteLine($"A = {A:F4}, B = {B:F4}, M = {M}, H = {H:F4}\n");

        for (int i = 0; i <= M; i++)
        {
            double x = A + i * H; // Вычисление текущего значения x
            double F = 2 - Math.Sin(x); // Вычисление значения функции F(x)
            Console.WriteLine($"x = {x:F4}, F(x) = {F:F4}");
        }
    }
}
