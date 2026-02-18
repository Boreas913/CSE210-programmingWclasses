using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-9");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
        Console.WriteLine(" ");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
    }
}