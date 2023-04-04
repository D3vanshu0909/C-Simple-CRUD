using ClassNamesp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQAssignment
{
    class DeleteRow
    {
        public static void Execute(List<Employee> employees)
        {
            int id;
            while (true)
            {
                Console.Write("Enter ID of employee to delete: ");
                if (int.TryParse(Console.ReadLine(), out id))
                {
                    break;
                }
                Console.WriteLine("Please enter a valid integer value.");
            }

            var employeeToDelete = employees.FirstOrDefault(e => e.Id == id);
            if (employeeToDelete == null)
            {
                Console.WriteLine("No employee found with this ID.");
                return;
            }

            employees.Remove(employeeToDelete);
            Console.WriteLine("Employee deleted successfully.");
        }
    }
}
