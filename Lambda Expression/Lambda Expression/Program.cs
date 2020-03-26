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
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { EmployeeFirstName = "Nancy", EmployeeLastName = "Smith", EmployeeId = 1 });
            employees.Add(new Employee() { EmployeeFirstName = "Georgia", EmployeeLastName = "Rikes", EmployeeId = 2 });
            employees.Add(new Employee() { EmployeeFirstName = "Sally", EmployeeLastName = "Super", EmployeeId = 3 });
            employees.Add(new Employee() { EmployeeFirstName = "Mike", EmployeeLastName = "Miles", EmployeeId = 4 });
            employees.Add(new Employee() { EmployeeFirstName = "John", EmployeeLastName = "Joels", EmployeeId = 5 });
            employees.Add(new Employee() { EmployeeFirstName = "Emma", EmployeeLastName = "Becks", EmployeeId = 6 });
            employees.Add(new Employee() { EmployeeFirstName = "Scott", EmployeeLastName = "Teer", EmployeeId = 7 });
            employees.Add(new Employee() { EmployeeFirstName = "Nate", EmployeeLastName = "Jiles", EmployeeId = 8 });
            employees.Add(new Employee() { EmployeeFirstName = "Joe", EmployeeLastName = "Smith", EmployeeId = 9 });
            employees.Add(new Employee() { EmployeeFirstName = "Joe", EmployeeLastName = "Jolly", EmployeeId = 10 });

            foreach (var Joe in employees)
            {
                if (Joe.EmployeeFirstName == "Joe")
                {
                    Console.WriteLine(Joe.EmployeeFirstName);
                }
            }
            Console.Read();


            List<Employee> nameList = new List<Employee>();
            nameList = employees.Where(x => x.EmployeeFirstName == "Joe").ToList();

            Console.WriteLine(nameList);
            Console.ReadLine();

            List<Employee> idList = new List<Employee>();
            idList = employees.Where(y => y.EmployeeId > 5).ToList();

            Console.WriteLine(idList);
            Console.ReadLine();
        }
    }
}
    

