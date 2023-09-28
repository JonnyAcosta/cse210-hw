using System;

public class Resume
{
    public string name {get; set; }
    public List <Job> jobs = new List<Job>();

public void Display()
{
Console.WriteLine($"Name:{name}");
Console.WriteLine($"Job: ");

foreach (Job job in jobs)
{
    job.Display();
}
}
}