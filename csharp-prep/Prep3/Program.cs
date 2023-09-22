using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your magic number? ");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);
    }
}