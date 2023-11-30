using System;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
                List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 5.0));
        shapes.Add(new Rectangle("Blue", 4.0, 6.0));
        shapes.Add(new Circle("Green", 3.0));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape}, Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}