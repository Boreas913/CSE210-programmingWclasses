using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Web dev";
        job1._startYear = 2027;
        job1._endYear = 2029;

        job1.Display(); 

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "UX internship";
        job2._startYear = 2027;
        job2._endYear = 2030;

        job2.Display(); 

        Resume myResume = new Resume();
        myResume._name = "Jane Doe";
        myResume. _jobs.Add(job1);
        myResume. _jobs.Add(job2);

        myResume.Display();
    }
}