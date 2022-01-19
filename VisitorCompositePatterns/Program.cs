using System;
using System.Collections.Generic;

namespace VisitorCompositePatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Visitor Pattern with Composite Pattern Demo. ***");

            // Mathematics department
            Employee mathTeacher1 = new Employee { Name = "M.Joy", Dept = "Mathematic", Designation = "Lecturer", Experience = 13.7 };
            Employee mathTeacher2 = new Employee { Name = "M.Roony", Dept = "Mathematic", Designation = "Lecturer", Experience = 6.5 };

            // HOD of Mathematics
            CompositeEmployee hodMaths = new CompositeEmployee { Name = "Mrs.S.Das", Dept = "Maths", Designation = "HOD Maths", Experience = 14 };
            hodMaths.AddEmployee(mathTeacher1);
            hodMaths.AddEmployee(mathTeacher2);

            // Computer Science department
            Employee cseTeacher1 = new Employee { Name = "C.Sam", Dept = "Computer Science", Designation = "Lecturer", Experience = 10.2 };
            Employee cseTeacher2 = new Employee { Name = "C.Jones", Dept = "Computer Science", Designation = "Lecturer", Experience = 13.5 };
            Employee cseTeacher3 = new Employee { Name = "C.Marium", Dept = "Computer Science", Designation = "Lecturer", Experience = 7.3 };

            // HOD of Computer Science
            CompositeEmployee hodCompSc = new CompositeEmployee { Name = "Mr. V.Sarcar", Dept = "Computer Sc.", Designation = "HOD Computer Sc.", Experience = 16.5 };
            hodCompSc.AddEmployee(cseTeacher1);
            hodCompSc.AddEmployee(cseTeacher2);
            hodCompSc.AddEmployee(cseTeacher3);

            // Top level management
            CompositeEmployee principal = new CompositeEmployee { Name = "Dr.S.Som", Dept = "Plannig-Supervising-Managing", Designation = "Principal", Experience = 21 };
            principal.AddEmployee(hodMaths);
            principal.AddEmployee(hodCompSc);

            // Display
            Console.WriteLine("Details of a college structure is as follows:");
            principal.DisplayDetails();

            List<IEmployee> participants = new List<IEmployee>();

            foreach (IEmployee e in hodMaths.Subordinates)
            {
                participants.Add(e);
            }

            foreach (IEmployee e in hodCompSc.Subordinates)
            {
                participants.Add(e);
            }

            Console.WriteLine("Visitor starts visiting our composite structure");
            IVisitor visitor = new PromotionCheckerVisitor();

            foreach (IEmployee emp in participants)
            {
                emp.Accept(visitor);
            }
        }
    }
}
