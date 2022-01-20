using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    internal class Electronics : BasicEngineering
    {
        public override void SpecialPaper()
        {
            Console.WriteLine("3.Digital Logic and Circuit Theory");
        }

        public override bool IsAditionalPaperNeeded()
        {
            return false;
        }
    }
}
