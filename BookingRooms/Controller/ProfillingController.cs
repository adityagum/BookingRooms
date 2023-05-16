using BookingRooms.Model;
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
        var view = new EmployeeView();
        if (result.Count == 0)
        {
            view.Output("Data Hilang");
        }
        else
        {
            view.Output(result);
        }
    }
}
