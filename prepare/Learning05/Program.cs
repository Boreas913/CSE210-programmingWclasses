using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();
        list.Add(new Square("Red", 5));
        list.Add(new Rectangle("Blue", 4, 6));
        list.Add(new Circle("Green", 3));
        foreach (Shape s in shapes) { 
            Console.WriteLine($"{s.GetColor()} shape area: {s.GetArea()}"); 
        }
    }
}