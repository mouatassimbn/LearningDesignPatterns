using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorCompositePatterns
{
    internal class PromotionCheckerVisitor : IVisitor
    {
        private string _eligibleForPromotion = string.Empty;

        public void VisitEmployees(Employee employee)
        {
            this._eligibleForPromotion = employee.Experience > 12 ? "Yes" : "No";
            Console.WriteLine($"{employee.Name} from {employee.Dept} is eligible for promotion ? {this._eligibleForPromotion}");
        }

        public void VisitEmployees(CompositeEmployee employee)
        {
            this._eligibleForPromotion = employee.Experience > 12 ? "Yes" : "No";
            Console.WriteLine($"{employee.Name} from {employee.Dept} is eligible for promotion? {this._eligibleForPromotion}");
        }
    }
}
