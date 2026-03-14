public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal( string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }
    public virtual void RecordEvent()
    {
        
    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual string GetDetailsString()
    {
        return "";

    }
    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_name},{_description},{_points}";
    }
}