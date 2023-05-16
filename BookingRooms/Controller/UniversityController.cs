using BookingRooms.Model;
using BookingRooms.VIew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms.Controller;

public class UniversityController
{
    private static University _university = new University();

    public static void GetAll()
    {   
        var result = _university.Get();
        var view = new UniversityView();
        if (result.Count == 0)
        {
            view.Output("Data Hilang");
        }
        else
        {
            view.Output(result);
        }
    }

    public static void Insert(University university)
    {
        /*Console.WriteLine("-----------------------------------------");
        *//*var university = new University();
        string nama = Console.ReadLine();
        university.Name = nama;*//*

        Console.Write("Masukkan nama Universitas : ");
        string nama = Console.ReadLine();*/
        var result = _university.Insert(university);
        var view = new UniversityView();
        if (result == 0)
        {
            Console.WriteLine("Insert success.");
        }
        else
        {
            Console.WriteLine("Insert failed.");
        }
    }

    public static void Update(University university)
    {
        /*var university1 = new University();*/
        /*Console.Write("Masukkan ID : ");
        int id = Convert.ToInt32(Console.ReadLine());
        university.Id = id;

        Console.Write("Masukkan Nama : ");
        var name = Console.ReadLine();
        university.Name = name;*/

        var result = _university.Update(university);
        var view = new UniversityView();
        if (result > 0)
        {
            Console.WriteLine("Update success");
        }
        else
        {
            Console.WriteLine("Update Failed");
        }
    }

    public static void Delete(University university)
    {
        /*var university2 = new University();*//*
        Console.Write("Masukkan ID Universities : ");
        int id = Convert.ToInt32(Console.ReadLine());
        university.Id = id;*/
        var result = _university.Delete(university);
        var view = new UniversityView();
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
