public class Entry
{
    public string _prompt;
    public string _response;
    public DateTime _date = DateTime.Now;
    public void Display()
    {
        Console.WriteLine($"Date: {_date.ToShortDateString()} Prompt: {_prompt}");
        Console.WriteLine(_response);
    }
    public string ToFile()
    {
        string entry = $"{_date.ToShortDateString()}|{_prompt}|{_response}";
        return entry;
    }
}