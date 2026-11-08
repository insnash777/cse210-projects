using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your number grade? ");
        int grade_num = int.Parse(Console.ReadLine());

        string letter;

        if (grade_num >= 90)
        {
            letter = "A";
        }
        else if (grade_num >= 80)
        {
            letter = "B";
        }
        else if (grade_num >= 70)
        {
            letter = "C";
        }
        else if (grade_num >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"With your {grade_num} you got a(n) {letter}!");

        if (grade_num >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You can do better than that! You got this!");
        }
    }
}