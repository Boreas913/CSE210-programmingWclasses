public class SensesActivity : Activity
{
    public SensesActivity() : base("Senses Activity", "This activity uses the 5-4-3-2-1 method for grounding yourself into reality.", 0)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
            int secondsPerPrompt = _duration/5;
            Console.WriteLine(); 
            Console.Write("Think of 5 things you can see right now......");
            ShowCountdown(secondsPerPrompt); 
            Console.WriteLine(); 
            Console.Write("Think of 4 things you can feel right now.....");
            ShowCountdown(secondsPerPrompt); 
            Console.WriteLine(); 
            Console.Write("Think of 3 things you cana hear right now....");
            ShowCountdown(secondsPerPrompt); 
            Console.WriteLine(); 
            Console.Write("Think of 2 things you can smell right now....");
            ShowCountdown(secondsPerPrompt); 
            Console.WriteLine(); 
            Console.Write("Think of 1 thing you can taste right now.....5");
            ShowCountdown(secondsPerPrompt); 
            Console.WriteLine(); 
        DisplayEndingMessage();
    }
}