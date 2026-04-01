using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running("3/04", 12, 2));
        activities.Add(new Cycling("3/12", 30, 50));
        activities.Add(new Swimming("3/29", 60, 12));

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }

    }
}