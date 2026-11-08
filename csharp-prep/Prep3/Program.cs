using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();

        // Console.Write("What is the magic number? ");
        int magic_number = randomGenerator.Next(1, 100);
        int your_guess;
        int guess_num = 0;
        string again;

        do
        {        
            do
            {
                guess_num += 1;
                Console.Write("Guess a number between 1 and 100! ");
                your_guess = int.Parse(Console.ReadLine());

                if (magic_number > your_guess)
                {
                    Console.WriteLine("Higher!");
                }
                else if (magic_number < your_guess)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine("Perfect! That's it!");
                }
            } while (your_guess != magic_number);

            Console.WriteLine($"You made {guess_num} guess(es).");

            Console.WriteLine("Would you like to play again? yes/no ");
            again = Console.ReadLine();
        } while (again == "yes");
    }
}