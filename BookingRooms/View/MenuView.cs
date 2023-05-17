using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms.View
{
    public class MenuView
    {
        public static void GetAllMenu()
        {
            Console.WriteLine("__________________________________");
            Console.WriteLine("|               MENU             |");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("|        1. Create               |");
            Console.WriteLine("|        2. Read                 |");
            Console.WriteLine("|        3. Update               |");
            Console.WriteLine("|        4. Delete               |");
            Console.WriteLine("|        5. Get DeptID 1115      |");
            Console.WriteLine("|        6. LINQ                 |");
            Console.WriteLine("|        7. Insert All           |");
            Console.WriteLine("|        8. Exit                 |");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Choose Menu: ");
        }

        public static void Insert()
        {
            Console.WriteLine("_____________________________");
            Console.WriteLine("|    Input Data to table    |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("|      1. University        |");
            Console.WriteLine("|      2. Education         |");
            Console.WriteLine("|      3. Employee          |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Pilih menu: ");
        }

        public static void Read()
        {
            Console.WriteLine("_____________________________");
            Console.WriteLine("|       Display Table       |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("|      1. University        |");
            Console.WriteLine("|      2. Education         |");
            Console.WriteLine("|      3. Employee          |");
            Console.WriteLine("|      4. Profillings       |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Pilih menu: ");

        }

        public static void Update()
        {
            Console.WriteLine("_____________________________");
            Console.WriteLine("|        Update Table       |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("|      1. University        |");
            Console.WriteLine("|      2. Education         |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Pilih menu: ");
        }

        public static void Delete()
        {
            Console.WriteLine("_____________________________");
            Console.WriteLine("|        Delete Table       |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("|      1. University        |");
            Console.WriteLine("|      2. Education         |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Pilih menu: ");
        }
    }
}
