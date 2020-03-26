using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> Employees = new List<string>();
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { EmployeeName = "Nancy Smith", EmployeeId = 1 });
            employees.Add(new Employee() { EmployeeName = "Georgia Rikes", EmployeeId = 2 });
            employees.Add(new Employee() { EmployeeName = "Sally Super", EmployeeId = 3 });
            employees.Add(new Employee() { EmployeeName = "Mike Miles", EmployeeId = 4 });
            employees.Add(new Employee() { EmployeeName = "John Joels", EmployeeId = 5 });
            employees.Add(new Employee() { EmployeeName = "Emma Becks", EmployeeId = 6 });
            employees.Add(new Employee() { EmployeeName = "Scott Teer", EmployeeId = 7 });
            employees.Add(new Employee() { EmployeeName = "Nate Jiles", EmployeeId = 8 });
            employees.Add(new Employee() { EmployeeName = "Joe Smith", EmployeeId = 9 });
            employees.Add(new Employee() { EmployeeName = "Joe Jolly", EmployeeId = 10 });

            foreach (var Joe in <Employee>)
            {
                Console.WriteLine("Joe", Joe.EmployeeName);
            }
            Console.Read();

            //var employeesWithFirstNameJoe = employees.Join(employees,
            //    emp1 => emp1.EmployeeName,
            //    emp2 => emp2.EmployeeId,
            //    (emp1, emp2) => new { EmployeeName = emp1.EmployeeName, FirstNameJoe = emp2.EmployeeName });
        }
    }


            //Employees.Add("Joe Smith");
            //Employees.Add("Joe Blow");
            //Employees.Add("Jane Smith");
            //Employees.Add("Jackie Wright");
            //Employees.Add("Julie Everybody");
            //Employees.Add("Jocelyn Crew");
            //Employees.Add("Janie Franks");
            //Employees.Add("Joy Harvard");
            //Employees.Add("Jolly Joe");
            //Employees.Add("Jippy Jip");

            //Console.WriteLine(Employees);
            //Console.ReadLine();

            //foreach (Employees employee in employees)
        }
    

