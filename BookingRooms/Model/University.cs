using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingRooms.Context;

namespace BookingRooms.Model;

public class University
{

    public int Id { get; set; }
    public string Name { get; set; }

    /*CREATE*/
    public int Insert(University universities)
    {
        int result = 0;
        using var connection = MyConnection.Get();
        /*connection.Open();*/

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

    /*READ*/
    public List<University> Get()
    {
        var universities = new List<University>();
        using SqlConnection connection = MyConnection.Get();
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
                    var university = new University();
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
        return new List<University>();
    }

    /*UPDATE*/
    public int Update(University university)
    {
        int result = 0;
        using var connection = MyConnection.Get();
        connection.Open();

        SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE Universities SET name = (@name) WHERE id = (@id)";
            command.Transaction = transaction;

            var pName = new SqlParameter();
            var pId = new SqlParameter();

            pName.ParameterName = "@name";
            pId.ParameterName = "@id";
            pName.Value = university.Name;
            pId.Value = university.Id;

            command.Parameters.Add(pName);
            command.Parameters.Add(pId);

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

    /*DELETE*/
    public int Delete(University university)
    {
        int result = 0;
        using var connection = MyConnection.Get();
        connection.Open();

        SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM Universities WHERE id = (@id)";
            command.Transaction = transaction;

            var pId = new SqlParameter();
            pId.ParameterName = "@id";
            pId.Value = university.Id;

            command.Parameters.Add(pId);
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

    public int GetUnivById()
    {
        using var connection = MyConnection.Get();
        connection.Open();
        {
            SqlCommand command = new SqlCommand("SELECT TOP 1 id FROM Universities ORDER BY id DESC", connection);

            int id = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            return id;
        }
    }
}


