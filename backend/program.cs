using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Привет, {name}!");

        DateTime today = DateTime.Now;
        Console.WriteLine($"Сегодня: {today:dddd}");

        Console.Write("Хотите продолжить? (y/n): ");
        string answer = Console.ReadLine().ToLower();

        if (answer == "y" || answer == "yes" || answer == "да")
        {
            Console.WriteLine("Продолжаем работу...");
        }
        else
        {
            Console.WriteLine("Завершение работы...");
        }
        
        Console.ReadLine(); 
    }
}