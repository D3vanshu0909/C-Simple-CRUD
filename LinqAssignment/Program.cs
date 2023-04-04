using LinQAssignment;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassNamesp
{
    class Employee
    {
        private static int autoincrement = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Technology { get; set; }
        public string CompanyName { get; set; }

        public Employee(string name, string department, string technology, string companyName)
        {
            Id = autoincrement++;

            Name = name;
            Department = department;
            Technology = technology;
            CompanyName = companyName;
        }
    }


    class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
            // sample data
            employees.Add(new Employee("Dev", "HR", "Recruit", "Aspirefox"));
            employees.Add(new Employee("Shubh", "IT", "Backend", "Aspire"));
            employees.Add(new Employee("Saurabh", "Sales", "Market", "Aspire"));
            employees.Add(new Employee("Ravi", "IT", "Front", "Aspirefox"));
            employees.Add(new Employee("Priya", "HR", "Training", "Aspire"));
            employees.Add(new Employee("John", "IT", "DevOps", "Aspire"));
            employees.Add(new Employee("Sam", "Sales", "CR", "Aspirefox"));
            employees.Add(new Employee("Eric", "IT", "Security", "Aspire"));


            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("MENU:");
                Console.WriteLine("1. Show table");
                Console.WriteLine("2. Add row");
                Console.WriteLine("3. Update row");
                Console.WriteLine("4. Delete row");
                Console.WriteLine("5. Show employees by company");
                Console.WriteLine("6. Show company by employee ID");
                Console.WriteLine("0. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        ShowTable.Execute(employees);
                        break;

                    case "2":
                        AddRow.Execute(employees);
                        break;

                    case "3":
                       UpdateRow.Execute(employees);
                        break;

                    case "4":
                        DeleteRow.Execute(employees);
                        break;

                    case "5":
                        ShowEmployeesByCompany.Execute(employees);
                        break;

                    case "6":
                        ShowCompanyByEmployeeId.Execute(employees);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}


