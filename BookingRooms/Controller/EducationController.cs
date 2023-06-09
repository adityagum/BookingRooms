﻿using BookingRooms.Model;
using BookingRooms.VIew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms.Controller;

public class EducationController
{
    private static Education _education = new Education();


    public static void GetAllEd()
    {
        var results = _education.Get();
        var view = new EducationView();
        if (results.Count == 0)
        {
            view.Output("Data Not Found");
        }
        else
        {
            view.Output(results);
        }
    }

    public static void Insert(Education education)
    {
        var results = _education.Insert(education);
        var view = new EducationView();
        if (results > 0)
        {
            Console.WriteLine("Insert success.");
        }
        else
        {
            Console.WriteLine("Insert failed.");
        }
    }

    public static void Update(Education education)
    {
        var result = _education.Update(education);
        var view = new EducationView();
        if (result > 0)
        {
            Console.WriteLine("Update success");
        }
        else
        {
            Console.WriteLine("Update Failed");
        }
    }

    public static void Delete(Education education)
    {
        Console.Write("Masukkan ID Educations : ");
        var result = _education.Delete(education);
        var view = new EducationView();
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
