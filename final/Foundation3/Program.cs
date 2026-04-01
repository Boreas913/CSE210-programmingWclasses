using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Lecture");
        Console.WriteLine("2. Reception");
        Console.WriteLine("3. Outdoor Event");
        Console.WriteLine("What event would you like to create?");
        string answer = Console.ReadLine();
        Console.WriteLine("Whats the street name where this will take place?");
        string street = Console.ReadLine();
        Console.WriteLine("Whats the city where this will take place?");
        string city = Console.ReadLine();
        Console.WriteLine("Whats the state where this will take place?");
        string state = Console.ReadLine();
        Console.WriteLine("Whats the country where this will take place?");
        string country = Console.ReadLine();
        Address address = new Address(street, city, state, country);
        Console.WriteLine("What is this event called?");
        string title = Console.ReadLine();
        Console.WriteLine("Write a description for the event:");
        string description = Console.ReadLine();
        Console.WriteLine("What date will it happen?");
        string date = Console.ReadLine();
        Console.WriteLine("What time will it happen?");
        string time = Console.ReadLine();
        switch(answer)
        {
            case "1":
                Console.WriteLine("What is the speaker's name?");
                string speaker = Console.ReadLine();
                Console.WriteLine("How many people can attend?");
                int capacity = int.Parse(Console.ReadLine());
                LectureEvent lecture = new LectureEvent(title, description, date, time, address, speaker, capacity);
                Console.WriteLine("--------------------------");
                Console.WriteLine(lecture.StandardDetails());
                Console.WriteLine("--------------------------");
                Console.WriteLine(lecture.ShortDetails());
                Console.WriteLine("--------------------------");
                Console.WriteLine(lecture.FullDetails());
                break;

            case "2":
                Console.WriteLine("What is the email people should RSVP to?");
                string rsvpEmail = Console.ReadLine();
                ReceptionEvent reception = new ReceptionEvent(title, description, date, time, address, rsvpEmail);
                Console.WriteLine("--------------------------");
                Console.WriteLine(reception.StandardDetails());
                Console.WriteLine("--------------------------");
                Console.WriteLine(reception.ShortDetails());
                Console.WriteLine("--------------------------");
                Console.WriteLine(reception.FullDetails());
                break;

            case "3":
                Console.WriteLine("What is the weather like that day?");
                string weather = Console.ReadLine();
                OutdoorEvent outdoor = new OutdoorEvent(title, description, date, time, address, weather);
                Console.WriteLine("--------------------------");
                Console.WriteLine(outdoor.StandardDetails());
                Console.WriteLine("--------------------------");
                Console.WriteLine(outdoor.ShortDetails());
                Console.WriteLine("--------------------------");
                Console.WriteLine(outdoor.FullDetails());
                break;

            default:
                Console.WriteLine("Invalid choice");
                break; 
        }
    }
}