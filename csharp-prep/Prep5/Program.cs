using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string username = PromptUserName();

        int user_number = PromptUserNumber();

        int birth_year;
        PromptUserBirthYear(out birth_year);

        int squared = SquareNumber(user_number);

        DisplayResult(username, squared, birth_year);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string user_name = Console.ReadLine();

        return user_name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int fav_num = int.Parse(Console.ReadLine());

        return fav_num;
    }

    static void PromptUserBirthYear(out int birth_year)
    {
        Console.Write("Please enter the year you were born: ");
        birth_year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int square_it_baby)
    {
        int squared = square_it_baby * square_it_baby;

        return squared;
    }

    static void DisplayResult(string username, int squared, int birth_year)
    {
        Console.WriteLine($"{username}, the square of your number is {squared}");
        Console.Write($"{username}, you will/have turned {2026 - birth_year} this year.");
    }
}