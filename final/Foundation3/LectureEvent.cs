class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;
    public LectureEvent(string title, string description, string date, string time, Address address,
               string speaker, int capacity): base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        string baseDetails = base.FullDetails();
        return $"{baseDetails}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}