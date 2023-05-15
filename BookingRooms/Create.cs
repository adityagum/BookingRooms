/*using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms
{
    public class Create
    {
        private static readonly string connectionString =
        "Data Source=ASUSVIVOBOOK\\SQLSERVER; Database=booking_rooms; Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public static int InsertUniv(Universities universities)
        {
            int result = 0;
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Universities(name) VALUES (@name)";
                command.Transaction = transaction;

                var pName = new SqlParameter();
                pName.ParameterName = "@name";
                pName.SqlDbType = SqlDbType.VarChar;
                pName.Size = 50;
                pName.Value = universities.Name;
                command.Parameters.Add(pName);

                result = command.ExecuteNonQuery();
                transaction.Commit();

                return result;
            }

            catch (Exception e)
            {
                transaction.Rollback();
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public static int InsertEduc(Educations educations)
        {
            int result = 0;
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Educations (major,degree,gpa,university_id) VALUES (@major, @degree, @gpa, @university_id)";
                command.Transaction = transaction;

                var pMajor = new SqlParameter();
                pMajor.ParameterName = "@major";
                pMajor.SqlDbType = SqlDbType.VarChar;
                pMajor.Size = 100;
                pMajor.Value = educations.Major;
                command.Parameters.Add(pMajor);

                var pDegree = new SqlParameter();
                pDegree.ParameterName = "@degree";
                pDegree.SqlDbType = SqlDbType.VarChar;
                pDegree.Size = 100;
                pDegree.Value = educations.Degree;
                command.Parameters.Add(pDegree);

                var pGpa = new SqlParameter();
                pGpa.ParameterName = "@gpa";
                pGpa.SqlDbType = SqlDbType.VarChar;
                pGpa.Size = 5;
                pGpa.Value = educations.Gpa;
                command.Parameters.Add(pGpa);

                var pUniversity_id = new SqlParameter();
                pUniversity_id.ParameterName = "@university_id";
                pUniversity_id.SqlDbType = SqlDbType.Int;
                pUniversity_id.Value = educations.UniversityId;
                command.Parameters.Add(pUniversity_id);

                result = command.ExecuteNonQuery();
                transaction.Commit();

                return result;
            }

            catch (Exception e)
            {
                transaction.Rollback();
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public static int InsertEmplo(Employees employees)
        {
            int result = 0;
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Employees(nik, first_name, last_name, birthdate, gender, hiring_date, email, phone_number, departement_id) VALUES (@nik, @first_name, @last_name, @birthdate, @gender, @hiring_date, @email, @phone_number, @departement_id)";
                command.Transaction = transaction;

           *//*     var pId = new SqlParameter();
                pId.ParameterName = "@id";
                pId.SqlDbType = SqlDbType.UniqueIdentifier;
                pId.Value = employees.Id;
                command.Parameters.Add(pId);*//*

                var pNik = new SqlParameter();
                pNik.ParameterName = "@nik";
                pNik.SqlDbType = SqlDbType.VarChar;
                pNik.Value = employees.Nik;
                command.Parameters.Add(pNik);

                var pFn = new SqlParameter();
                pFn.ParameterName = "@first_name";
                pFn.SqlDbType = SqlDbType.VarChar;
                pFn.Value = employees.FirstName;
                command.Parameters.Add(pFn);

                var pLn = new SqlParameter();
                pLn.ParameterName = "@last_name";
                pLn.SqlDbType = SqlDbType.VarChar;
                pLn.Value = employees.LastName;
                command.Parameters.Add(pLn);

                var pBD = new SqlParameter();
                pBD.ParameterName = "@birthdate";
                pBD.SqlDbType = SqlDbType.DateTime;
                pBD.Value = employees.BirthDate;
                command.Parameters.Add(pBD);

                var pGender = new SqlParameter();
                pGender.ParameterName = "@gender";
                pGender.SqlDbType = SqlDbType.VarChar;
                pGender.Value = employees.Gender;
                command.Parameters.Add(pGender);

                var pHD = new SqlParameter();
                pHD.ParameterName = "@hiring_date";
                pHD.SqlDbType = SqlDbType.DateTime;
                pHD.Value = employees.HiringDate;
                command.Parameters.Add(pHD);

                var pEmail = new SqlParameter();
                pEmail.ParameterName = "@email";
                pEmail.SqlDbType = SqlDbType.VarChar;
                pEmail.Value = employees.Email;
                command.Parameters.Add(pEmail);

                var pPN = new SqlParameter();
                pPN.ParameterName = "@phone_number";
                pPN.SqlDbType = SqlDbType.VarChar;
                pPN.Value = employees.PhoneNumber;
                command.Parameters.Add(pPN);

                var pDeptId = new SqlParameter();
                pDeptId.ParameterName = "@departement_id";
                pDeptId.SqlDbType = SqlDbType.Int;
                pDeptId.Value = employees.DepartementId;
                command.Parameters.Add(pDeptId);

                result = command.ExecuteNonQuery();
                transaction.Commit();

                return result;
            }

            catch (Exception e)
            {
                transaction.Rollback();
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public void InsertAll()
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
*//*                SqlCommand command = new SqlCommand();
*//*                // Insert data ke tabel Employee
                var employees = new Employees();
                Console.Write("Masukkan NIK : ");
                string nik = Console.ReadLine();
                employees.Nik = nik;

                Console.Write("Masukkan First Name : ");
                string fn = Console.ReadLine();
                employees.FirstName = fn;

                Console.Write("Masukkan Last Name : ");
                string ln = Console.ReadLine();
                employees.LastName = ln;

                Console.Write("Masukkan Birthdate : ");
                DateTime bd = DateTime.Parse(Console.ReadLine());
                employees.BirthDate = bd;

                Console.Write("Masukkan Gender : ");
                string gen = Console.ReadLine();
                employees.Gender = gen;

                Console.Write("Masukkan Hiring Date : ");
                DateTime hd = DateTime.Parse(Console.ReadLine());
                employees.HiringDate = hd;

                Console.Write("Masukkan Email : ");
                string mail = Console.ReadLine();
                employees.Email = mail;

                Console.Write("Masukkan Phone Number : ");
                string pn = Console.ReadLine();
                employees.PhoneNumber = pn;

                Console.Write("Masukkan Departement ID : ");
                string deptId = Console.ReadLine();
                employees.DepartementId = deptId;

                // Insert data ke tabel Education
                var education = new Educations();
                Console.Write("Major: ");
                string Major = Console.ReadLine();
                education.Major = Major;

                Console.Write("Degree: ");
                string Degree = Console.ReadLine();
                education.Degree = Degree;

                Console.Write("GPA: ");
                string GPA = Console.ReadLine();
                education.Gpa = GPA;

                // Insert data ke tabel University
                var university = new Universities();
                Console.Write("University Name: ");
                string UniversityName = Console.ReadLine();
                university.Name = UniversityName;

                // Insert data ke tabel Profilling
                var profilling = new Profillings();
                profilling.EmployeeId = employees.Id;
                profilling.EducationId = education.Id;

                // Simpan perubahan ke database
                *//*using var command = new SqlCommand();
                command.Transaction = transaction;
                command.Connection = connection;
                command.Parameters.Add(nik);
                command.Parameters.Add(fn);
                command.Parameters.Add(ln);
                command.Parameters.Add(bd);
                command.Parameters.Add(gen);
                command.Parameters.Add(hd);
                command.Parameters.Add(mail);
                command.Parameters.Add(hd);
                command.Parameters.Add(pn);
                command.Parameters.Add(deptId);
                command.Parameters.Add(Major);
                command.Parameters.Add(Degree);
                command.Parameters.Add(GPA);
                command.Parameters.Add(UniversityName);
                command.SaveChanges();
                transaction.Commit();*//*

                var command = new SqlCommand();
                command.Transaction = transaction;
                command.Connection = connection;

                command.CommandText = @"
                INSERT INTO Employees (Nik, FirstName, LastName, BirthDate, Gender, HiringDate, Email, PhoneNumber, DepartementId)
                VALUES (@nik, @firstName, @lastName, @birthDate, @gender, @hiringDate, @email, @phoneNumber, @departementId);
                SET @employeeId = SCOPE_IDENTITY();
                INSERT INTO Educations (Major, Degree, GPA)
                VALUES (@major, @degree, @gpa);
                SET @educationId = SCOPE_IDENTITY();
                INSERT INTO Universities (Name)
                VALUES (@universityName);
                SET @universityId = SCOPE_IDENTITY();
                INSERT INTO Profillings (EmployeeId, EducationId, UniversityId)
                VALUES (@employeeId, @educationId, @universityId);";

                // Add parameters
                command.Parameters.AddWithValue("@nik", nik);
                command.Parameters.AddWithValue("@firstName", fn);
                command.Parameters.AddWithValue("@lastName", ln);
                command.Parameters.AddWithValue("@birthDate", bd);
                command.Parameters.AddWithValue("@gender", gen);
                command.Parameters.AddWithValue("@hiringDate", hd);
                command.Parameters.AddWithValue("@email", mail);
                command.Parameters.AddWithValue("@phoneNumber", pn);
                command.Parameters.AddWithValue("@departementId", deptId);
                command.Parameters.AddWithValue("@major", Major);
                command.Parameters.AddWithValue("@degree", Degree);
                command.Parameters.AddWithValue("@gpa", GPA);
                command.Parameters.AddWithValue("@universityName", UniversityName);

                // Add output parameters for SCOPE_IDENTITY() values
                command.Parameters.Add("@employeeId", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.Parameters.Add("@educationId", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.Parameters.Add("@universityId", SqlDbType.Int).Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                transaction.Commit();



                Console.WriteLine("Data berhasil disimpan");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Terjadi kesalahan: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        *//*public void InsertAll()
        {
            int result = 0;
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                var employees = new Employees();
                Console.Write("Masukkan NIK : ");
                string nik = Console.ReadLine();
                employees.Nik = nik;

                Console.Write("Masukkan First Name : ");
                string fn = Console.ReadLine();
                employees.FirstName = fn;

                Console.Write("Masukkan Last Name : ");
                string ln = Console.ReadLine();
                employees.LastName = ln;

                Console.Write("Masukkan Birthdate : ");
                DateTime bd = DateTime.Parse(Console.ReadLine());
                employees.BirthDate = bd;

                Console.Write("Masukkan Gender : ");
                string gen = Console.ReadLine();
                employees.Gender = gen;

                Console.Write("Masukkan Hiring Date : ");
                DateTime hd = DateTime.Parse(Console.ReadLine());
                employees.HiringDate = hd;

                Console.Write("Masukkan Email : ");
                string mail = Console.ReadLine();
                employees.Email = mail;

                Console.Write("Masukkan Phone Number : ");
                string pn = Console.ReadLine();
                employees.PhoneNumber = pn;

                Console.Write("Masukkan Departement ID : ");
                string deptId = Console.ReadLine();
                employees.DepartementId = deptId;

                var education = new Educations();
                Console.Write("Masukkan Major : ");
                var major = Console.ReadLine();
                education.Major = major;

                Console.Write("Masukkan Degree : ");
                var degree = Console.ReadLine();
                education.Degree = degree;

                Console.Write("Masukkan GPA : ");
                var gpa = Console.ReadLine();
                education.Gpa = gpa;

                var university = new Universities();
                Console.Write("Masukkan nama : ");
                string nama = Console.ReadLine();
                university.Name = nama;

                SqlCommand command = new SqlCommand();
                using SqlDataReader reader = command.ExecuteReader();
                var profillings = new Profillings();
                profillings.EmployeeId = reader.GetGuid(0).ToString();
                profillings.EducationId = reader.GetInt32(1);

            }


            catch (Exception e)
            {
                transaction.Rollback();
            }
            finally
            {
                connection.Close();
            }
            
        }*//*
    }


}
*/