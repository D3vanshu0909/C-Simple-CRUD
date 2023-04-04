using ClassNamesp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQAssignment
{
    class ShowCompanyByEmployeeId
    {
        public static void Execute(List<Employee> employees)
        {
            int id;
            while (true)
            {
                Console.Write("Enter ID of employee: ");
                if (int.TryParse(Console.ReadLine(), out id))
                {
                    break;
                }
                Console.WriteLine("Please enter a valid integer value.");
            }

            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                Console.WriteLine("No employee found with this ID.");
                return;
            }

            Console.WriteLine($"Company of employee {employee.Name} (ID {employee.Id}): {employee.CompanyName}");
        }
    }
}
