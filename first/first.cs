using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int guess;
        int tries = 0;
        bool found = false;

        Console.WriteLine("Welcome to the Number Guessing Game!");

        while (!found)
        {
            Console.Write("Enter your guess (1-100): ");
            guess = Convert.ToInt32(Console.ReadLine());
            tries++;

            if (guess == secretNumber)
            {
                found = true;
                Console.WriteLine("Congratulations! You guessed the number in " + tries + " tries.");
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else
            {
                Console.WriteLine("Too high! Try again.");
            }
        }
    }
}
