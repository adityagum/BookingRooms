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

    public static void GetAll()
    {
        Console.WriteLine("Menampilkan semua data");
        var result = _employee.GetEmployees();
        var view = new EmployeeView();
        if (result.Count == 0)
        {
            view.Output("Data Hilang");
        }
        else
        {
            view.Output(result);
        }
    }

    public void Insert(Education education)
    {

        Console.Write("Masukkan Major : ");
        var major = Console.ReadLine();
        education.Major = major;

        Console.Write("Masukkan Degree : ");
        var degree = Console.ReadLine();
        education.Degree = degree;

        Console.Write("Masukkan GPA : ");
        var gpa = Console.ReadLine();
        education.Gpa = gpa;

        Console.Write("University ID : ");
        var university_id = Convert.ToInt32(Console.ReadLine());
        education.UniversityId = university_id;

        var result = _education.Insert(education);
        if (result > 0)
        {
            Console.WriteLine("Insert success.");
        }
        else
        {
            Console.WriteLine("Insert failed.");
        }
    }

    public void Update(Education education)
    {
        Console.Write("Masukkan Education ID : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Major: ");
        string major = Console.ReadLine();
        Console.Write("Degree: ");
        string degree = Console.ReadLine();
        Console.Write("GPA: ");
        string gpa = Console.ReadLine();
        Console.Write("Universty Id : ");
        int univ_id = Convert.ToInt32(Console.ReadLine());

        education.Id = id;
        education.Major = major;
        education.Degree = degree;
        education.Gpa = gpa;
        education.UniversityId = univ_id;

        var results = _education.Update(education);
        if (results > 0)
        {
            Console.WriteLine("Update success");
        }
        else
        {
            Console.WriteLine("Update Failed");
        }
    }

    public void Delete(Education education)
    {
        Console.Write("Masukkan ID Educations : ");
        int id = Convert.ToInt32(Console.ReadLine());
        education.Id = id;

        var result = _education.Update(education);
        if (result > 0)
        {
            Console.WriteLine("Delete success");
        }
        else
        {
            Console.WriteLine("Delete Failed");
        }
    }
}
