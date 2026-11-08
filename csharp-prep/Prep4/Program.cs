using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int number;
        float total = 0;
        float average;
        int max = 0;
        float item_count;


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);

        } while (numbers.Last() != 0);

        foreach (int item in numbers)
        {
            total += item;

            if (max < item)
            {
                max = item;
            }
        }

        item_count = numbers.Count() - 1;
        average = total / item_count;

        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Maximum: {max}");

    }
}