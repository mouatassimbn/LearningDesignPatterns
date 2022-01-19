using System;

namespace VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Visitor Pattern Demo***");
            NumberCollection numberCollection = new();
            numberCollection.DisplayList();

            IncrementNumberVisitor incrementNumberVisitor = new();
            Console.WriteLine("IncrementNumberVisitor is about to visit the list:");
            numberCollection.Accept(incrementNumberVisitor);

            InvestigateNumberVisitor investigateNumberVisitor = new();
            Console.WriteLine("InvestigateNumberVisitor is about to visit the list:");
            numberCollection.Accept(investigateNumberVisitor);

            numberCollection.DisplayList();
        }
    }
}
