using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    internal class ComputerScience : BasicEngineering
    {
        public override void SpecialPaper()
        {
            Console.WriteLine("3.Object-Oriented Programming");
        }
    }
}
