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
                    
                   
                    break;

                case 2:
                    MenuView.Read();
                    int tabel2 = Convert.ToInt32(Console.ReadLine());
                    if (tabel2 == 1)
                    {
                        universityController.GetAll();
                    }

                    else if (tabel2 == 2)
                    {
                        Console.WriteLine("Menampilkan semua data");
                        EducationController.GetAll();
                    }

                    else if (tabel2 == 3)
                    { 
                        Console.WriteLine("Menampilkan semua data");
                        EmployeeController.GetAll();
                        
                    }

                    else if (tabel2 == 4)
                    {
                        Console.WriteLine("Menampilkan semua data");
                        ProfillingController.GetAll();
                    }

                    else if (tabel2 == 5)
                    {
                        MenuView.GetAllMenu();
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                    break;

                case 3:
                    
                    int tabel3 = Convert.ToInt32(Console.ReadLine());
                    if (tabel3 == 1)
                    {
                        /*var university1 = new University();
                        Console.Write("Masukkan ID : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        university1.Id = id;

                        Console.Write("Masukkan Nama : ");
                        var name3 = Console.ReadLine();
                        university1.Name = name3;

                        var result = University.UpdateUniversity(university1);
                        if (result > 0)
                        {
                            Console.WriteLine("Update success");
                        }
                        else
                        {
                            Console.WriteLine("Update Failed");
                        }*/
                    }
                    else if (tabel3 == 2)
                    {
                        var education1 = new Education();
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

                        education1.Id = id;
                        education1.Major = major;
                        education1.Degree = degree;
                        education1.Gpa = gpa;
                        education1.UniversityId = univ_id;

                        var results = Education.UpdateEducation(education1);
                        if (results > 0)
                        {
                            Console.WriteLine("Update success");
                        }
                        else
                        {
                            Console.WriteLine("Update Failed");
                        }
                    }
                    else if (tabel3 == 3)
                    {
                        Menu();
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                    break;

                case 4:
                    Console.WriteLine("===== PILIH TABEL YANG AKAN DIHAPUS =====");
                    Console.WriteLine("=====                               =====");
                    Console.WriteLine("=====        1. Universities        =====");
                    Console.WriteLine("=====        2. Educations          =====");
                    Console.WriteLine("=====        3. Back                =====");
                    Console.WriteLine("=====                               =====");
                    Console.WriteLine("Pilih menu (1/2): ");
                    int tabel4 = Convert.ToInt32(Console.ReadLine());
                    if (tabel4 == 1)
                    {
                        var university2 = new University();
                        Console.Write("Masukkan ID Universities : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        university2.Id = id;

                        var result = University.Delete(university2);
                        if (result > 0)
                        {
                            Console.WriteLine("Delete success");
                        }
                        else
                        {
                            Console.WriteLine("Delete Failed");
                        }
                    }

                    else if (tabel4 == 2)
                    {
                        var education2 = new Education();
                        Console.Write("Masukkan ID Educations : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        education2.Id = id;

                        var result = Education.DeleteEducation(education2);
                        if (result > 0)
                        {
                            Console.WriteLine("Delete success");
                        }
                        else
                        {
                            Console.WriteLine("Delete Failed");
                        }
                    }

                    else if (tabel4 == 3)
                    {
                        Menu();
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
            
                    break;

                /*case 5:
                    var employ = Employee.GetEmployees();
                    var gen = employ.Where(e => e.Gender == "male");

                    foreach (var item in gen)
                    {
                        Console.WriteLine("Id: " + item.Id);
                        Console.WriteLine("First Name: " + item.FirstName);
                        Console.WriteLine("Email: " + item.Email );
                        Console.WriteLine("");
                    }

                    break;
                
                case 6:
                    var employee_ = Employee.GetEmployees();
                    var profillings_ = Profilling.GetProfilings();
                    var educations_ = Education.GetEducation();
                    var universities_ = University.GetUniv();

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

                    break;*/

                default:
                    Console.WriteLine();
                    break;

            }

        } while (choice != 5);
    }
}

