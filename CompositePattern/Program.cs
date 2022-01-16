using System;

namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Composire Pattern Demo.***");
            // Maths department
            // 2 lecturers work in mathematics departement
            Employee mathTeacher1 = new Employee { Name = "M.Joy", Dept = "Mathematic", Designation = "Lecturer" };
            Employee mathTeacher2 = new Employee { Name = "M.Roony", Dept = "Mathematic", Designation = "Lecturer" };

            // The college has a head of departement in Mathematics
            CompositeEmployee hodMaths = new CompositeEmployee { Name = "Mrs.S.Das", Dept = "Maths", Designation = "HOD-Maths" };

            // Lecturers of mathematics directly reports to HOD-Maths
            hodMaths.AddEmployee(mathTeacher1);
            hodMaths.AddEmployee(mathTeacher2);


            // CS department
            Employee cseTeacher1 = new Employee { Name = "C.Sam", Dept = "Computer Science", Designation = "Lecturer" };
            Employee cseTeacher2 = new Employee { Name = "C.Jones", Dept = "Computer Science", Designation = "Lecturer" };
            Employee cseTeacher3 = new Employee { Name = "C.Marium", Dept = "Computer Science", Designation = "Lecturer" };

            // The college has a head of departement in CS
            CompositeEmployee hodCompSC = new CompositeEmployee { Name = "Mr.V.Sarcar", Dept = "Computer Sc.", Designation = "HOD-Computer Sc." };

            // Lecturers of comp si directly reports to HOD-CompSC
            hodCompSC.AddEmployee(cseTeacher1);
            hodCompSC.AddEmployee(cseTeacher2);
            hodCompSC.AddEmployee(cseTeacher3);

            // Top level management
            CompositeEmployee principal = new CompositeEmployee { Name = "Dr.S.Som", Dept = "Planning-Supervising-Managing", Designation = "Principal" };

            // HOD of maths and comp sci reports directly to principal
            principal.AddEmployee(hodCompSC);
            principal.AddEmployee(hodMaths);

            Console.WriteLine("Details of a principal object is as follows:");
            principal.DisplayDetails();

            Console.WriteLine("Details of a HOD object is as follows:");
            hodCompSC.DisplayDetails();

            Console.WriteLine("Detials of an individual employee (leaf node) is as follows:");
            mathTeacher1.DisplayDetails();

            // Teacher leaving
            hodCompSC.RemoveEmployee(cseTeacher3);
            Console.WriteLine("After the resignation of C.Jones, the organization has the following members:");
            principal.DisplayDetails();


        }
    }
}
