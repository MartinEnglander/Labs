using System;
using ShapeConsole;

namespace ShapeConsole
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(new Circle(new System.Numerics.Vector2(3.0f, 4.0f), 2.0f));
            Console.WriteLine("-------------------------------------");

            Console.WriteLine(new Rectangle(new System.Numerics.Vector2(3.0f, 4.0f), new System.Numerics.Vector2(5.0f, 5.0f)));
            Console.WriteLine("-------------------------------------");

            Console.WriteLine(new Triangle(new System.Numerics.Vector2(0.0f, 0.0f), new System.Numerics.Vector2(3.0f, 3.0f), new System.Numerics.Vector2(6.0f, 0.0f)));
            Console.WriteLine("-------------------------------------");
        }
    }
}
