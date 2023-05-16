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
            Console.WriteLine("____________________________");
            Console.WriteLine("|           MENU           |");
            Console.WriteLine("----------------------------");
            Console.WriteLine("|        1. Create         |");
            Console.WriteLine("|        2. Read           |");
            Console.WriteLine("|        3. Update         |");
            Console.WriteLine("|        4. Delete         |");
            Console.WriteLine("|        5. Show Male      |");
            Console.WriteLine("|        6. LINQ           |");
            Console.WriteLine("|        7. Exit           |");
            Console.WriteLine("----------------------------");
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
            Console.WriteLine("|      4. Back to Menu      |");
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
            Console.WriteLine("|      5. Back to Menu      |");
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
            Console.WriteLine("|      3. Back              |");
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
            Console.WriteLine("|      3. Back              |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Pilih menu: ");
        }
    }
}
