using BookingRooms.Model;
using BookingRooms.VIew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms.Controller;

public class EmployeeController
{
    private static Employee _employee = new Employee();

    public static void GetAllEmp()
    {
        var results = _employee.Get();
        var view = new EmployeeView();
        
        if (results.Count == 0)
        {
            view.Output("Data Not Found");
        }
        else
        {
            view.Output(results);
        }
    }

    public static void Insert(Employee employee)
    {
        var result = _employee.Insert(employee);
        var view = new EmployeeView();
        if (result == 0)
        {
            view.Output("Insert Employee Failed");
        }
        else
        {
            view.Output("Insert Employee Success");
        }
    }

    public static void LinqGender()
    {
        var emp = _employee.Get();
        var gen = emp.Where(e => e.DepartmentId == "1115");
        var view = new EmployeeView();
        if (emp.Count == 0)
        {
            view.Output("Data Not Found");
        }
        else
        {
            view.Output(emp);
        }
    }

    public static void GetAllByLinQ()
    {
        var education = new Education();
        var employee = new Employee();
        var profiling = new Profilling();
        var university = new University();

        var employee_ = employee.Get();
        var profillings_ = profiling.Get();
        var educations_ = education.Get();
        var universities_ = university.Get();

        var query = from emp in employee_
                    join prof in profillings_ on emp.Id equals prof.EmployeeId
                    join edu in educations_ on prof.EducationId equals edu.Id
                    join uni in universities_ on prof.EducationId equals uni.Id
                    select new
                    {
                        emp.Nik,
                        FullName = emp.FirstName + " " + emp.LastName,
                        emp.Birthdate,
                        emp.Gender,
                        emp.HiringDate,
                        emp.Email,
                        emp.PhoneNumber,
                        edu.Major,
                        edu.Degree,
                        edu.Gpa,
                        uni.Name
                    };

        foreach (var emp in query)
        {
            Console.WriteLine($"NIK: {emp.Nik}");
            Console.WriteLine($"Full Name: {emp.FullName}");
            Console.WriteLine($"Birth Date: {emp.Birthdate}");
            Console.WriteLine($"Gender: {emp.Gender}");
            Console.WriteLine($"Hiring Date: {emp.HiringDate}");
            Console.WriteLine($"Email: {emp.Email}");
            Console.WriteLine($"Phone Number: {emp.PhoneNumber}");
            Console.WriteLine($"Major: {emp.Major}");
            Console.WriteLine($"Degree: {emp.Degree}");
            Console.WriteLine($"GPA: {emp.Gpa}");
            Console.WriteLine($"University Name: {emp.Name}");
            Console.WriteLine("-----------------------------------");
        }

    }

}
