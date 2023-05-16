using BookingRooms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms.View;

public class ProfillingsView
{
    public void Output(Profilling profilling)
    {
        Console.WriteLine("EmployeeId: " + profilling.EmployeeId);
        Console.WriteLine("EducationId: " + profilling.EducationId);
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("");
    }

    public void Output(List<Profilling> profilings)
    {
        foreach (var profiling in profilings)
        {
            Output(profiling);
        }
    }

    public void Output(string message)
    {
        Console.WriteLine(message);
    }


}
