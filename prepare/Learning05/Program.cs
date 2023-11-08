using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        foreach (Shape s in shapes)
        {
            string color =s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}