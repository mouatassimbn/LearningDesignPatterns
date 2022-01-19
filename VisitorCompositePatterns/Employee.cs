using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorCompositePatterns
{
    internal class Employee : IEmployee
    {
        private string _name;
        private string _dept;
        private string _designation;
        private double _experience;

        public string Name
        {
            get => this._name;
            set => this._name = value;
        }
        public string Dept
        {
            get => this._dept;
            set => this._dept = value;
        }
        public string Designation
        {
            get => this._designation;
            set => this._designation = value;
        }
        public double Experience
        {
            get => this._experience;
            set => this._experience = value;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{this._name} works in {this._dept} department. Designation: {this._designation}. Experience: {this._experience} years.");
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitEmployees(this);
        }
    }
}
