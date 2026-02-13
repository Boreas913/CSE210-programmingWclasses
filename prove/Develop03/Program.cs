using System;
using System.Net.Quic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {   
        Boolean quit = false;
        while(!quit){
            Console.WriteLine("Pick a scripture to memorize from the list (enter the number or 'q' to quit)");
            Console.WriteLine("1. Proverbs 3:5-6");
            Console.WriteLine("2. John 3:16");
            Console.WriteLine("3. Mormon 5:23");
//For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.
//Trust in the LORD with all your heart and lean not on your own understanding; in all your ways acknowledge him, and he will make your paths straight.
//Know ye not that ye are in the hands of God? Know ye not that he hath all power, and at his great command the earth shall be rolled together as a scroll?
            string input = Console.ReadLine();
            string text = "";
            string book = "";
            int chapter = 0;
            int verse = 0;
            int endverse = 0;
            if (input == "1")
            {
                text = "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways acknowledge him, and he will make your paths straight.";
                book = "Proverbs";
                chapter = 3;
                verse = 5;
                endverse = 6;

            }
            else if (input == "2")
            {
                text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
                book = "John";
                chapter = 3;
                verse = 16;
                endverse = 0;

            }
            else if (input == "3")
            {
                text = "Know ye not that ye are in the hands of God? Know ye not that he hath all power, and at his great command the earth shall be rolled together as a scroll?";
                book = "Mormon";
                chapter = 5;
                verse = 23;
                endverse = 0;
            }
            else
            {
                quit = true;
            }
            if (text != "")
            {
                Reference reference = new Reference(book, chapter, verse, endverse);
                Scripture scripture = new Scripture(reference, text);
                while (!scripture.IsWholeThingHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("Hit enter to hide words (or 'q' to quit)");
                    string userResponse = Console.ReadLine();
                    if (userResponse.ToLower() == "q")
                    {
                        break;
                    }
                    scripture.HideRandomWords(3);
                }
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nGood job! Press Enter to go back to the menu.");
                Console.ReadLine();
            }
        }
    }
}