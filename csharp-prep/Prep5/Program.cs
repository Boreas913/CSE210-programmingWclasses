using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int age = PromptUserNumber();
        int birthyear;
        PromtUserBirthYear(out birthyear);
        int square = SquareNumber(age);
        DisplayResult(name, square, birthyear);


    }
    static void DisplayWelcome()
    {
        //DisplayWelcome - Displays the message, "Welcome to the Program!"
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        //PromptUserName - Asks for and returns the user's name (as a string)
        Console.WriteLine($"Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        //PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        Console.WriteLine($"Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static void PromtUserBirthYear(out int birthYear)
    {
        //PromtUserBirthYear - Accepts out integer parameter and prompts the user for the year they were born.
        Console.WriteLine($"Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        //SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square, int birthYear)
    {
        //DisplayResult - Accepts the user's name, the squared number, and the user's birth year. 
        //Display the user's name and squared number. Calculate hold many years old they will turn this year and display that.
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2025 - birthYear} years old this year.");
    }
    
}