using ClassNamesp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQAssignment
{
    class AddRow
    {
        public static void Execute(List<Employee> employees)
        {
            string name, department, technology, companyName;

            while (true)
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(name))
                {
                    break;
                }
                Console.WriteLine("Please enter a non-empty value.");
            }

            while (true)
            {
                Console.Write("Enter department: ");
                department = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(department))
                {
                    break;
                }
                Console.WriteLine("Please enter a non-empty value.");
            }

            while (true)
            {
                Console.Write("Enter technology: ");
                technology = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(technology))
                {
                    break;
                }
                Console.WriteLine("Please enter a non-empty value.");
            }

            while (true)
            {
                Console.Write("Enter company name: ");
                companyName = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(companyName))
                {
                    break;
                }
                Console.WriteLine("Please enter a non-empty value.");
            }

            employees.Add(new Employee(name, department, technology, companyName));
            Console.WriteLine("Employee added successfully.");
        }
    }
}
