using System.ComponentModel;
using System.Runtime.InteropServices;

public class Activity
{
    private string _nameOfActivity;
    private string _description;
    protected int _duration;

    public Activity (string nameOfActivity, string description, int duration)
    {
        _nameOfActivity = nameOfActivity;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_nameOfActivity} activity.");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How long, in seconds would you like your session?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
        ShowSpinner();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_nameOfActivity}");
        ShowSpinner();
    }
    public void ShowSpinner()
    {
        for (int i = 0; i < 3; i++){
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b"); 
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b"); 
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b"); 
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b"); 
        }
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string text = i.ToString();
            Console.Write(text);
            Thread.Sleep(1000);
            for (int j = 0; j < text.Length; j++)
            {
                Console.Write("\b \b");
            }
        }
    }
}