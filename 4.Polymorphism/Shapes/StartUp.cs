using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes;
public class StartUp
{
    static void Main(string[] args)
    {
        Shape shape = new Rectangle(5, 10);

        Console.WriteLine(shape.Draw());
        Console.WriteLine($"Rectangle Area: {shape.CalculateArea()}");
        Console.WriteLine($"Rectangle Perimeter: {shape.CalculatePerimeter()}");

        shape = new Circle(7);
        
        Console.WriteLine(shape.Draw());
        Console.WriteLine($"Circle Area: {shape.CalculateArea()}");
        Console.WriteLine($"Circle Perimeter: {shape.CalculatePerimeter()}");
    }
}
