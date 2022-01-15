using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmpAddress Address { get; set; }

        public Employee(int id, string name, EmpAddress address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        }

        public Employee(Employee original)
        {
            this.Id =original.Id;
            this.Name = original.Name;
            this.Address = original.Address.CloneAddress() as EmpAddress;
        }

        public override string ToString()
        {
            return $"Employee Id is : {this.Id}, Employee name is : {this.Name}, Employee Adress is : {this.Address}";
        }

        public object Clone()
        {
            Employee employee = this.MemberwiseClone() as Employee;
            employee.Address = this.Address.CloneAddress() as EmpAddress;
            return employee;
        }
    }
}
