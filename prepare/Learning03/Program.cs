using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);
        Fraction f4 = new Fraction();
        Random randomGen = new Random();

        int count = 0;

        // Console.WriteLine($"{f1.GetTop()}/{f1.GetBottom()}");
        // Console.WriteLine($"{f2.GetTop()}/{f2.GetBottom()}");
        // Console.WriteLine($"{f3.GetTop()}/{f3.GetBottom()}");

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        do
        {
            int topNum = randomGen.Next(1,100);
            int bottomNum = randomGen.Next(1,100);

            f4.SetTop(topNum);
            f4.SetBottom(bottomNum);

            count += 1;
            Console.WriteLine($"Fraction: {count} String: {f4.GetFractionString()} Number: {f4.GetDecimalValue()}");
        } while (count <= 20);
    }
}