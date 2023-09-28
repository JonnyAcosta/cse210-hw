using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.jobtitle = "Software Engineer";
        job1.company = "Microsoft";
        job1.startyear = 2019;
        job1.endyear = 2022;

        Job job2 = new Job();
        job2.jobtitle = "Manager";
        job2.company = "Apple";
        job2.startyear =2022 ;
        job2.endyear = 2023;


        Resume myResume = new Resume();
        myResume.name = "Jonathan Acosta";

        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);
        
        myResume.Display();
    }
}