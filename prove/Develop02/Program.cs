using System;
using System.Collections.Generic;
using System.IO;

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