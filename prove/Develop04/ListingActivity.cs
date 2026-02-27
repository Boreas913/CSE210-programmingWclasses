public class ListingActivity: Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _entries = new List<string>();
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        string prompt = _prompts[promptIndex];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {prompt} --- ");
        ShowCountdown(5);
        Console.WriteLine("Now list as many things that answer the question as you can.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string entry = Console.ReadLine();
            _entries.Add(entry);
        }
        Console.WriteLine($"You wrote down {_entries.Count} entries");
        DisplayEndingMessage();
    }
}