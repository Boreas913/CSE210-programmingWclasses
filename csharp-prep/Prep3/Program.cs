using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int RandomNumber = randomGenerator.Next(1, 100);


        Console.Write("This is the \"guess a number\" game.");
        Console.Write("You try to guess a random number in the smallest number of attempts.");
        Console.Write("");
        Console.Write("Guess a number between 1 and 100.");
        int num_guesses = 0;
        int guess = -1;
        
        while (guess != RandomNumber)
        {  
            guess = int.Parse(Console.ReadLine());
            num_guesses += 1;
            if (guess > RandomNumber){ Console.Write("     Too high!");}
            else if (guess < RandomNumber){Console.Write("     Too low!");}
            else{ Console.Write($"You were able to find the number in {num_guesses} guesses.");};
        };
    }
}