using BookingRooms.Context;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms.Model;

public class Profilling
{
    public string EmployeeId { get; set; }
    public int EducationId { get; set; }

    public int Insert(Profilling profilings)
    {
        int result = 0;
        using var connection = MyConnection.Get();
        connection.Open();

        var employee = new Employee();
        var education = new Education();

        SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO Profillings (employee_id, education_id) VALUES (@EmployeeId, @EducationId)";
            command.Transaction = transaction;

            var pEmpId = new SqlParameter();
            pEmpId.ParameterName = "@EmployeeId";
            pEmpId.Value = profilings.EmployeeId;
            command.Parameters.Add(pEmpId);

            var pEduId = new SqlParameter();
            pEduId.ParameterName = "@EducationId";
            pEduId.Value = profilings.EducationId;
            command.Parameters.Add(pEduId);

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



    /*READ*/
    public List<Profilling> Get()
    {
        var pro = new List<Profilling>();
        using SqlConnection connection = MyConnection.Get();
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
                    var prof = new Profilling();
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
        return new List<Profilling>();
    }
}
