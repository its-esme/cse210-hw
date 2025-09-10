using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessedNumber = 0;
        int countAttempt = 0;

        do
        {
            Console.Write("What is the magic number? ");
            string guess = Console.ReadLine();
            guessedNumber = int.Parse(guess);

            countAttempt++;

            if (guessedNumber > magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessedNumber < magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it after {countAttempt} attempts.");
            }
            

        } while (guessedNumber != magicNumber);

         

        // Console.WriteLine("Hello World! This is the Exercise3 Project.");
    }
}