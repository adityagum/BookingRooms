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

    public static void GetAllUniv()
    {   
        var result = _university.Get();
        var view = new UniversityView();
        if (result.Count == 0)
        {
            view.Output("Data Not Found");
        }
        else
        {
            view.Output(result);
        }
    }

    public static void Insert(University university)
    {
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
