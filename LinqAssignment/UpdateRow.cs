using ClassNamesp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQAssignment
{
    class UpdateRow
    {
        public static void Execute(List<Employee> employees)
        {
            int id;
            while (true)
            {
                Console.Write("Enter ID of employee to update: ");
                if (int.TryParse(Console.ReadLine(), out id))
                {
                    break;
                }
                Console.WriteLine("Please enter a valid integer value.");
            }

            var employeeToUpdate = employees.FirstOrDefault(e => e.Id == id);
            if (employeeToUpdate == null)
            {
                Console.WriteLine("No employee found with this ID.");
                return;
            }

            Console.Write("Enter new name (or leave blank to keep current value): ");
            string name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name))
            {
                employeeToUpdate.Name = name;
            }

            Console.Write("Enter new department (or leave blank to keep current value): ");
            string department = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(department))
            {
                employeeToUpdate.Department = department;
            }

            Console.Write("Enter new technology (or leave blank to keep current value): ");
            string technology = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(technology))
            {
                employeeToUpdate.Technology = technology;
            }

            Console.Write("Enter new company name (or leave blank to keep current value): ");
            string companyName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(companyName))
            {
                employeeToUpdate.CompanyName = companyName;
            }

            Console.WriteLine("Employee updated successfully.");
        }
    }
}
