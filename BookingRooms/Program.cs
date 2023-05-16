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
                    TableView.InsertTable(tabel);
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
                    EmployeeController.LinqGender();
                    break;

                case 6:
                    EmployeeController.GetAllByLinQ();
                    break;

                case 7:
                    TableView.InsertAll();
                    break;
                default:
                    Console.WriteLine();
                    break;

            }

        } while (choice != 8);
    }
}

