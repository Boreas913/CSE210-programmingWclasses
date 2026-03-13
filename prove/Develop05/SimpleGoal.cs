using System.Security.Cryptography.X509Certificates;

public class SimpleGoal: Goal
{
    private bool _isComplete;
     public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
     }

    public override void RecordEvent()
    {
        if(!_isComplete){
            _isComplete = true;
        }
    }

    public override string GetDetailsString()
    {
        if (_isComplete)
        {
            return $"[X] {_name} {_description}";
        }
        else
        {
            return $"[] {_name} {_description}";
        }

    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
}
