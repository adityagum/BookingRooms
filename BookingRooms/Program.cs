using System.Data.SqlClient;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System;
using BookingRooms.Model;
using BookingRooms.View;
using BookingRooms.Controller;

public class Program
{
    private static readonly string connectionString =
        "Data Source=ASUSVIVOBOOK\\SQLSERVER; Database = booking_rooms; Integrated Security=True;Connect Timeout=30;Encrypt=False;";

    private static UniversityController universityController = new();
    private static EducationController educationController = new();
    private static EmployeeController employeeController = new();
    private static ProfillingController profillingController = new();


    public static void Main()
    {

        int choice;
        do
        {
            MenuView.GetAllMenu();
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    MenuView.Insert();
                    int tabel = Convert.ToInt32(Console.ReadLine());
                    TableView.SelectTable(tabel);
                    break;

                case 2:
                    MenuView.Read();
                    int tabel2 = Convert.ToInt32(Console.ReadLine());
                    TableView.SelectTable(tabel2);
                    break;

                case 3:
                    MenuView.Update();
                    int tabel3 = Convert.ToInt32(Console.ReadLine());
                    TableView.UpdateTable(tabel3);
                    break;

                case 4:
                    MenuView.Delete();
                    int tabel4 = Convert.ToInt32(Console.ReadLine());
                    TableView.DeleteTable(tabel4);
                    break;

                case 5:
                    LinqGender();
                    break;

                case 6:
                    GetAllByLinQ();
                    break;
                default:
                    Console.WriteLine();
                    break;

            }

        } while (choice != 7);
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

