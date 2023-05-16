using BookingRooms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms.View
{
    public class ProfillingsView
    {
        public void Output(Profilling profilling)
        {
            Console.WriteLine("EmployeeId: " + profilling.EmployeeId);
            Console.WriteLine("EducationId: " + profilling.EducationId);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
        }
    }
}
