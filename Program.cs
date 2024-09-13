using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Анкета для приема на работу");

        Console.Write("Имя: ");
        string name = Console.ReadLine();

        Console.Write("Возраст: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Телефон: ");
        string phone = Console.ReadLine();

        Console.Write("Опыт работы (лет): ");
        double experience = double.Parse(Console.ReadLine());

        Console.Write("Желаемая зарплата: ");
        decimal salary = decimal.Parse(Console.ReadLine());

        Console.Write("Дата начала работы: ");
        string startDate = Console.ReadLine();

        Console.WriteLine("\nВаша анкета:");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Телефон: {phone}");
        Console.WriteLine($"Опыт работы: {experience} лет");
        Console.WriteLine($"Желаемая зарплата: {salary}");
        Console.WriteLine($"Дата начала работы: {startDate}");
        CalculateSpaceParameters();
    }
    static void CalculateSpaceParameters()
    {
        const double G = 6.67430e-11;
        const double M = 5.97e24;
        const double R = 6.371e6;

        Console.Write("\nВведите высоту над Землей (м): ");
        double h = double.Parse(Console.ReadLine());

        double v = Math.Sqrt(G * M / (R + h));
        Console.WriteLine($"Первая космическая скорость: {v} м/с");

        double g = G * M / Math.Pow(R + h, 2);
        Console.WriteLine($"Ускорение свободного падения: {g} м/с²");

        Console.Write("Введите расстояние до апогея (м): ");
        double ra = double.Parse(Console.ReadLine());
        Console.Write("Введите расстояние до перигея (м): ");
        double rp = double.Parse(Console.ReadLine());

        double e = (ra - rp) / (ra + rp);
        Console.WriteLine($"Эксцентриситет орбиты: {e}");
    }
}

