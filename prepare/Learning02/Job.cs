using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

public class Job 
{
public string company {get; set; }
public string  jobtitle {get; set; }
public int  startyear {get; set; }
public int  endyear {get; set; }

public decimal Pay {get; set; }

public void Display()
{
    Console.WriteLine($"{jobtitle},({company}),{startyear}-{endyear}");
}
}