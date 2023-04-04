using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassNamesp;

namespace LinQAssignment
{
     class ShowTable
    {
        public static void Execute(List<Employee> employees)
        {
            Console.WriteLine("ID\tName\tDepartment\tTechnology\tCompany");
            Console.WriteLine("----------------------------------------------------");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Id}\t{employee.Name}\t{employee.Department}\t\t{employee.Technology}\t\t{employee.CompanyName}");
            }
        }
    }
}
