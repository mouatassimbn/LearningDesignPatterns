using System;

namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Template Method Pattern Demo***");
            BasicEngineering bs = new ComputerScience();
            Console.WriteLine("Computer Science cource includes the following subjects:");
            bs.DisplayCourseStructure();
            Console.WriteLine();
            bs = new Electronics();
            Console.WriteLine("Electronics cource includes the following subjects:");
            bs.DisplayCourseStructure();
        }
    }
}
