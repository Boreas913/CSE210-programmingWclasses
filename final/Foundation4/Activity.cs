class Activity
{
    protected string _date;
    protected double _lengthInMinutes;
    public Activity(string date, double lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public virtual string Distance()
    {
        return "";
    }
    public virtual string Speed()
    {
        return "";
    }
    public virtual string Pace()
    {
        return "";
    }
    public string GetSummary()
    {
        string activityType = this.GetType().Name;
        return $"{_date}: {activityType} - {_lengthInMinutes} minutes, {Distance()}, {Speed()}, {Pace()}";
    }
}