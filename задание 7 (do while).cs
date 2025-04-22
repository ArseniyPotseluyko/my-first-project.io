using System;

class Program
{
    static void Main()
    {
        int number = 80;
        do
        {
            Console.WriteLine(number);
            number -= 2;
        } while (number >= 10);
    }
}
