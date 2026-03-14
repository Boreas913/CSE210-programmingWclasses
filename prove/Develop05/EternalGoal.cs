using System.Security.Cryptography.X509Certificates;

public class EternalGoal: Goal
{
     public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_name} ({_description})";
    }
    public override bool IsComplete()
    {
        return false;
    }
}
