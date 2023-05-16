using BookingRooms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms.VIew
{
    public class EmployeeView
    {
        public void Output(Employee employee)
        {
            {
                Console.WriteLine("Id: " + employee.Id);
                Console.WriteLine("Nik: " + employee.Nik);
                Console.WriteLine("FirstName: " + employee.FirstName);
                Console.WriteLine("LastName: " + employee.LastName);
                Console.WriteLine("BirthDate: " + employee.Birthdate);
                Console.WriteLine("Gender: " + employee.Gender);
                Console.WriteLine("HiringDate: " + employee.HiringDate);
                Console.WriteLine("Email: " + employee.Email);
                Console.WriteLine("PhoneNumber: " + employee.PhoneNumber);
                Console.WriteLine("DepartementId: " + employee.DepartmentId);
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("");
            }
        }
        public void Output(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Output(employee);
            }
        }

        public void Output(string message)
        {
            Console.WriteLine(message);
        }

        /*public void OutputAll(Employee employee)
        {
        }*/
    }
}
