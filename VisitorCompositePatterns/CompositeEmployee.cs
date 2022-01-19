using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorCompositePatterns
{
    internal class CompositeEmployee : IEmployee
    {
        private string _name;
        private string _dept;
        private string _designation;
        private double _experience;
        private List<IEmployee> _subordinates;

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
        public List<IEmployee> Subordinates
        {
            get => this._subordinates;
        }

        public CompositeEmployee()
        {
            this._subordinates = new List<IEmployee>();
        }

        public void AddEmployee(IEmployee e)
        {
            this._subordinates.Add(e);
        }
        public void RemoveEmployee(IEmployee e)
        {
            this._subordinates.Remove(e);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{this._name} works in {this._dept} department. Designation: {this._designation}. Experience: {this._experience} years.");
            foreach (IEmployee e in this._subordinates)
            {
                e.DisplayDetails();
            }
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitEmployees(this);
        }
    }
}
