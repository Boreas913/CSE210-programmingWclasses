using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string gradeResponse = Console.ReadLine();
        int grade = int.Parse(gradeResponse);
        bool pass_class = false;
        string letterGrade;

        if (grade > 93) {pass_class = true; letterGrade = "A";}
        else if (grade <= 93 && grade >= 90){pass_class = true; letterGrade = "A-";}
        else if (grade >=87) {pass_class = true; letterGrade = "B+";}
        else if (grade >83) {pass_class = true; letterGrade = "B";}
        else if (grade <= 83 && grade >= 80) {pass_class = true; letterGrade = "B-";}
        else if (grade >=77){pass_class = true; letterGrade = "C+";}
        else if (grade >73){pass_class = true; letterGrade = "C";}
        else if (grade <= 73 && grade >= 70){pass_class = true; letterGrade = "C-";}
        else if (grade >=67){letterGrade = "D+";}
        else if (grade >63){letterGrade = "D";}
        else if (grade <= 63 && grade >= 60){letterGrade = "D-";}
        else{letterGrade = "F";}

        Console.WriteLine($"You got a {letterGrade}");
        if (pass_class){Console.WriteLine("You passed the class!");}
            
        else {Console.WriteLine("You failed the class. Maybe next time will be better.");}
    }
}