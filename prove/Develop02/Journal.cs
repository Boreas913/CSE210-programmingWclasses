public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    PromptGenerator _promptGenerator = new PromptGenerator();

    public void AddEntry()
    {
        string thePrompt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine(thePrompt);
        Console.Write("> ");
        string response = Console.ReadLine();
        Entry entry = new Entry();
        entry._prompt = thePrompt;
        entry._response = response;
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename)) 
        {
            foreach (Entry entry in _entries)
            {
                string userentry = entry.ToFile();
                outputFile.WriteLine(userentry);
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry newEntry = new Entry();
            newEntry._date = DateTime.Parse(parts[0]); 
            newEntry._prompt = parts[1];
            newEntry._response = parts[2];
            _entries.Add(newEntry);
            Console.WriteLine();
            Console.WriteLine($"{newEntry._date.ToShortDateString()} {newEntry._prompt}");
            Console.WriteLine($"{newEntry._response}");
        }
    }
}