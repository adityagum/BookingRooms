using BookingRooms.Controller;
using BookingRooms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms.View
{
    public class TableView
    {
        public static void InsertTable(int tabel)
        {
            switch (tabel)
            {
                case 1:
                    Console.WriteLine("-----------------------------------------");
                    var university = new University();
                    Console.Write("Masukkan nama University : ");
                    string nama = Console.ReadLine();
                    university.Name = nama;

                    UniversityController.Insert(university);
                    break;
                case 2:
                    Console.WriteLine("-----------------------------------------");
                    var education = new Education();
                    Console.Write("Masukkan Major : ");
                    education.Major = Console.ReadLine();

                    Console.Write("Masukkan Degree : ");
                    education.Degree = Console.ReadLine();

                    Console.Write("Masukkan GPA : ");
                    education.Gpa = Console.ReadLine();

                    Console.Write("University ID : ");
                    education.UniversityId = Convert.ToInt32(Console.ReadLine());

                    EducationController.Insert(education);
                    break;

                case 3:
                    Console.WriteLine("-----------------------------------------");
                    var employee = new Employee();
                    Console.Write("Nik: ");
                    employee.Nik = Console.ReadLine();
                    Console.Write("FirstName: ");
                    employee.FirstName = Console.ReadLine();
                    Console.Write("LastName: ");
                    employee.LastName = Console.ReadLine();
                    Console.Write("BirthDate: ");
                    employee.Birthdate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Gender: ");
                    employee.Gender = Console.ReadLine();
                    Console.Write("HiringDate: ");
                    employee.HiringDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Email: ");
                    employee.Email = Console.ReadLine();
                    Console.Write("PhoneNumber: ");
                    employee.PhoneNumber = Console.ReadLine();
                    Console.Write("DepartementId: ");
                    employee.DepartmentId = Console.ReadLine();

                    EmployeeController.Insert(employee);
                    Console.Write("-----------------------------------");
                    Console.Write("");
                    break;


                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        public static void SelectTable(int tabel2)
        {
            switch (tabel2)
            {
                case 1:
                    UniversityController.GetAllUniv();
                    break;

                case 2:
                    EducationController.GetAllEd();
                    break;

                case 3:
                    EmployeeController.GetAllEmp();
                    break;
                case 4:
                    ProfillingController.GetAllProf();
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        public static void UpdateTable(int tabel3)
        {
            switch (tabel3)
            {
                case 1:
                    Console.WriteLine("-----------------------------------------");
                    var university = new University();
                    Console.Write("\nMasukkan ID : ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    university.Id = id;

                    Console.Write("Masukkan Nama : ");
                    var name = Console.ReadLine();
                    university.Name = name;

                    UniversityController.Update(university);
                    break;

                case 2:
                    Console.WriteLine("-----------------------------------------");
                    var education = new Education();
                    Console.Write("\nMasukkan ID : ");
                    education.Id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Major: ");
                    education.Major = Console.ReadLine();
                    Console.Write("Degree: ");
                    education.Degree = Console.ReadLine();
                    Console.Write("GPA: ");
                    education.Gpa = Console.ReadLine();
                    Console.Write("Universty Id : ");
                    education.UniversityId = Convert.ToInt32(Console.ReadLine());

                    EducationController.Update(education);
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        public static void DeleteTable(int tabel4)
        {
            switch (tabel4)
            {
                case 1:
                    Console.WriteLine("-----------------------------------------");
                    var university = new University();
                    Console.Write("Masukkan ID : ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    university.Id = id;

                    UniversityController.Delete(university);
                    break;

                case 2:
                    Console.WriteLine("-----------------------------------------");
                    var education = new Education();
                    Console.Write("Masukkan ID : ");
                    education.Id = Convert.ToInt32(Console.ReadLine());

                    EducationController.Delete(education);
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        public static void InsertAll()
        {
            var employee = new Employee();
            var profiling = new Profilling();
            var education = new Education();
            var university = new University();

            Console.Write("NIK : ");
            var niks = Console.ReadLine();
            employee.Nik = niks;

            Console.Write("First Name : ");
            employee.FirstName = Console.ReadLine();

            Console.Write("Lame Name : ");
            employee.LastName = Console.ReadLine();

            Console.Write("Birthdate : ");
            employee.Birthdate = DateTime.Parse(Console.ReadLine());

            Console.Write("Gender : ");
            employee.Gender = Console.ReadLine();

            Console.Write("Hiring Date : ");
            employee.HiringDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Email : ");
            employee.Email = Console.ReadLine();

            Console.Write("Phone Number : ");
            employee.PhoneNumber = Console.ReadLine();

            Console.Write("Department ID : ");
            employee.DepartmentId = Console.ReadLine();

            //EDUCATION
            Console.Write("Major : ");
            education.Major = Console.ReadLine();

            Console.Write("Degree : ");
            education.Degree = Console.ReadLine();

            Console.Write("GPA : ");
            education.Gpa = Console.ReadLine();

            Console.Write("University Name : ");
            university.Name = Console.ReadLine();

            EducationController.Insert(education);
            UniversityController.Insert(university);

            education.UniversityId = university.GetUnivById();
            education.Insert(education);
            EducationController.Insert(education);

            profiling.EmployeeId = employee.GetEmpId(niks);
            profiling.EmployeeId = employee.GetEmpId(niks);

            profiling.EducationId = education.GetEduId();
            ProfillingController.Insert(profiling);
        }

        

        public static void LinqAllData()
        {
            var education = new Education();
            var employee = new Employee();
            var profiling = new Profilling();
            var university = new University();


            var educationGet = education.Get();
            var employeeGet = employee.Get();
            var profilingGet = profiling.Get();
            var universityGet = university.Get();

            var getAll = from emp in employeeGet
                         join pro in profilingGet on emp.Id equals pro.EmployeeId
                         join edu in educationGet on pro.EducationId equals edu.Id
                         join uni in universityGet on edu.UniversityId equals uni.Id
                         select new
                         {
                             NIK = emp.Nik,
                             Fullname = emp.FirstName + " " + emp.LastName,
                             emp.Birthdate,
                             emp.Gender,
                             emp.HiringDate,
                             emp.Email,
                             emp.PhoneNumber,
                             edu.Major,
                             edu.Degree,
                             edu.Gpa,
                             Univesity = uni.Name
                         };

            foreach (var get in getAll)
            {
                Console.WriteLine($"NIK         = {get.NIK}");
                Console.WriteLine($"Fullname    = {get.Fullname}");
                Console.WriteLine($"Birthdate   = {get.Birthdate}");
                Console.WriteLine($"Gender      = {get.Gender}");
                Console.WriteLine($"HiringDate  = {get.HiringDate}");
                Console.WriteLine($"Email       = {get.Email}");
                Console.WriteLine($"PhoneNumber = {get.PhoneNumber}");
                Console.WriteLine($"Major       = {get.Major}");
                Console.WriteLine($"Degree      = {get.Degree}");
                Console.WriteLine($"GPA         = {get.Gpa}");
                Console.WriteLine($"Univesity   = {get.Univesity}");
                Console.WriteLine("-------------------------------------------------------");
            }
        }
    }
}
