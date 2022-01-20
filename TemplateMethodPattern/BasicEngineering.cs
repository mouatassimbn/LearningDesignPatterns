using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    internal abstract class BasicEngineering
    {
        private void Math()
        {
            Console.WriteLine("1.Mathematics");
        }

        private void SoftSkills()
        {
            Console.WriteLine("2.SoftSkills");
        }

        private void IncludeAdditionalPaper()
        {
            Console.WriteLine("4.Compiler Design");
        }

        public abstract void SpecialPaper();

        public void DisplayCourseStructure()
        {
            Math();
            SoftSkills();
            //Specialized Paper:
            SpecialPaper();
            //Include an additional subject if required.
            if (IsAditionalPaperNeeded())
            {
                IncludeAdditionalPaper();
            }
        }

        public virtual bool IsAditionalPaperNeeded()
        {
            return true;
        }
    }
}
