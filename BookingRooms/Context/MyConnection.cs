﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms.Context
{
    public class MyConnection
    {
        private static readonly string connectionString =
        "Data Source=ASUSVIVOBOOK\\SQLSERVER; Database=booking_rooms; Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public static SqlConnection Get()
        {
            var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connection Open!");
            }

            catch (Exception e)
            {
                Console.WriteLine("Error in connection" + e.Message);
            }

            finally
            {
                connection.Close();
            }
            return connection;

            return new SqlConnection(connectionString);
        }
    }
}
