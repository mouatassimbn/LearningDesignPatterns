using System;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Adapter Pattern Demo***");
            IRectangle rectangle = new Rectangle(20, 10);
            Console.WriteLine("For initial verification purposes, printing the areas of both shapes");
            Console.WriteLine($"Rectangle area is: {rectangle.CalculateArea()} Sqaure unit.");

            ITriangle triangle = new Triangle(20, 10);
            Console.WriteLine($"Triangle area is: {triangle.CalculateAreaOfTriangle()} Square unit.");

            // Using adapter
            Console.WriteLine("Now using the adapter.");
            IRectangle adapter = new RectangleAdapter(triangle);
            Console.WriteLine("True fact : ");
            adapter.AboutMe();
            Console.WriteLine($" and my area is : {adapter.CalculateArea()}");

            // Alternative way:
            Console.WriteLine("Using the adapter in a different way now.");
            // Passing a triangle instead of a rectangle
            Console.WriteLine($" area of the triangle using the adapter is : {GetDetails(adapter)} sqaure unit");
        }

        static double GetDetails(IRectangle rectangle)
        {
            rectangle.AboutMe();
            return rectangle.CalculateArea();
        }
    }
}
