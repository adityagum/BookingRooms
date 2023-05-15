using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms;

public class Bookings
{
    public string Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Remarks { get; set; }
    public int RoomId { get; set; }
    public string EmployeeId { get; set; }
}
