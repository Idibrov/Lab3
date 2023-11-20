using System;

public struct Distance
{
    public int feet;
    public int inches;

    public Distance(int ft, int inch)
    {
        feet = ft;
        inches = inch;
    }
}

class Program
{
    static void Main()
    {
        Distance distance1, distance2, distance3;

        Console.Write("Введите расстояние 1 (футы): ");
        int feet1 = int.Parse(Console.ReadLine());
        Console.Write("Введите расстояние 1 (дюймы): ");
        int inches1 = int.Parse(Console.ReadLine());
        distance1 = new Distance(feet1, inches1);

        Console.Write("Введите расстояние 2 (футы): ");
        int feet2 = int.Parse(Console.ReadLine());
        Console.Write("Введите расстояние 2 (дюймы): ");
        int inches2 = int.Parse(Console.ReadLine());
        distance2 = new Distance(feet2, inches2);

        distance3.feet = distance1.feet + distance2.feet + (distance1.inches + distance2.inches) / 12;
        distance3.inches = (distance1.inches + distance2.inches) % 12;

        Console.WriteLine("Расстояние 1: {0}'-{1}\"", distance1.feet, distance1.inches);
        Console.WriteLine("Расстояние 2: {0}'-{1}\"", distance2.feet, distance2.inches);
        Console.WriteLine("Сумма: {0}'-{1}\"", distance3.feet, distance3.inches);

        Console.ReadLine();
    }
}
