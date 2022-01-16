using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Employee : IEmployee
    {
        private string _name;
        private string _dept;
        private string _designation;


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

        public void DisplayDetails()
        {
            Console.WriteLine($"\t{this._name} works in {this._dept} department. Designation: {this._designation}");
        }
    }
}
