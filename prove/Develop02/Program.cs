using System;
using System.Collections.Generic;
using System.IO;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>() 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        int index = Random.Shared.Next(0, _prompts.Count);
        return _prompts[index];
    }
}
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

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string input = "";
        while (input!="5")
        {
            Console.WriteLine("1 Write");
            Console.WriteLine("2 Display");
            Console.WriteLine("3 Save");
            Console.WriteLine("4 Load");
            Console.WriteLine("5 Quit");
            Console.Write("> ");
            input = Console.ReadLine();
            Console.WriteLine();
            if (input == "1" )
            {
                journal.AddEntry();
            }
            else if (input == "2" )
            {
                journal.DisplayAll();
            }
            else if (input == "3" )
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (input == "4" )
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
        }
        
    }
}