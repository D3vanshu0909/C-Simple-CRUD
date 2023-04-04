using ClassNamesp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQAssignment
{
    class ShowEmployeesByCompany
    {
        public static void Execute(List<Employee> employees)
        {
            var employeesByCompany = employees
                .GroupBy(e => e.CompanyName) // group employees by company name
                .Select(g => g.ToList()) // select the employees in each group and convert to a list
                .ToList(); // convert the groups to a list

            Console.WriteLine("Id\tName\tDepartment\tTechnology\tCompanyName"); // print the table header
            foreach (var company in employeesByCompany)
            {
                foreach (var emp in company)
                {
                    Console.WriteLine($"{emp.Id}\t{emp.Name}\t{emp.Department}\t\t{emp.Technology}\t\t{emp.CompanyName}"); // print the employee data in the table format
                }
                Console.WriteLine(); // add a blank line between each group of employees
            }
        }

    }
}
