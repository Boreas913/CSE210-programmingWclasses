using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input = -1;
        int sum = 0;
        int largest = 0;

        while (input != 0)
        {
            Console.Write("Enter a Number: ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }
        foreach (int number in numbers)
        {
            sum += number;
        }
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        int average = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}