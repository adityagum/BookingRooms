using BookingRooms.Model;
using BookingRooms.View;
using BookingRooms.VIew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms.Controller;

public class ProfillingController
{
    private static Profilling _profilling = new Profilling();

    public static void GetAll()
    {
        Console.WriteLine("Menampilkan semua data");
        var result = _profilling.Get();
        var view = new ProfillingsView();
        if (result.Count == 0)
        {
            view.Output("Data Hilang");
        }
        else
        {
            view.Output(result);
        }
    }

    public static void Insert(Profilling profilings)
    {
        var result = _profilling.Insert(profilings);
        var view = new ProfillingsView();
        if (result == 0)
        {
            view.Output("Insert Profiling Failed");
        }
        else
        {
            view.Output("Insert Profiling Success");
        }
    }
}
