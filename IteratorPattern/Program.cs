using System;

namespace IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Iterator PAttern Demonsttration. ***");
            Arts arts = new Arts();
            Console.WriteLine("Arts subjects are as follows:");
            foreach (string subject in arts)
            {
                Console.WriteLine(subject);
            }

            Science science = new Science();
            Console.WriteLine("Science subjects are as follows:");
            foreach (string subject in science)
            {
                Console.WriteLine(subject);
            }

        }
    }
}
