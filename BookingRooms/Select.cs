/*using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms;

public class Select
{
    *//*private static readonly string connectionString =
        "Data Source=ASUSVIVOBOOK\\SQLSERVER; Database=booking_rooms; Integrated Security=True;Connect Timeout=30;Encrypt=False;";
    public static List<Universities> GetUniv()
    {
        var universities = new List<Universities>();
        using SqlConnection connection = new SqlConnection(connectionString);
        try
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Universities";
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var university = new Universities();
                    university.Id = reader.GetInt32(0);
                    university.Name = reader.GetString(1);

                    universities.Add(university);
                }
                return universities;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            connection.Close();
        }
        return new List<Universities>();
    }*//*

    public static List<Employees> GetEmployees()
    {
        var emp = new List<Employees>();
        using SqlConnection connection = new SqlConnection(connectionString);
        try
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Employees";
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var emplo = new Employees();
                    emplo.Id = reader.GetGuid(0).ToString();
                    emplo.Nik = reader.GetString(1);
                    emplo.FirstName = reader.GetString(2);
                    emplo.LastName = reader.GetString(3);
                    emplo.BirthDate = reader.GetDateTime(4);
                    emplo.Gender = reader.GetString(5);
                    emplo.HiringDate = reader.GetDateTime(6);
                    emplo.Email = reader.GetString(7);
                    emplo.PhoneNumber = reader.GetString(8);
                    emplo.DepartementId = reader.GetString(9);

                    emp.Add(emplo);
                }
                return emp;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            connection.Close();
        }
        return new List<Employees>();
    }

    public static List<Profillings> GetProfilings()
    {
        var pro = new List<Profillings>();
        using SqlConnection connection = new SqlConnection(connectionString);
        try
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Profillings";
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var prof = new Profillings();
                    prof.EmployeeId = reader.GetGuid(0).ToString();
                    prof.EducationId = reader.GetInt32(1);

                    pro.Add(prof);
                }
                return pro;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            connection.Close();
        }
        return new List<Profillings>();
    }
}
*/