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
            Console.WriteLine("=============================");
            Console.WriteLine("=           MENU            =");
            Console.WriteLine("=============================");
            Console.WriteLine("=                           =");
            Console.WriteLine("=        1. Create          =");
            Console.WriteLine("=        2. Read            =");
            Console.WriteLine("=        3. Update          =");
            Console.WriteLine("=        4. Delete          =");
            Console.WriteLine("=        5. Testing         =");
            Console.WriteLine("=        6. LINQ            =");
            Console.WriteLine("=                           =");
            Console.WriteLine("=============================");
            Console.WriteLine("Pilih menu (1/2/3/4/5): ");
        }

        public static void Insert()
        {
            Console.WriteLine("===== INGIN MELAKUKAN INSERT PADA TABEL =====");
            Console.WriteLine("=====                                   =====");
            Console.WriteLine("=====      1. Universities              =====");
            Console.WriteLine("=====      2. Educations                =====");
            Console.WriteLine("=====      3. Employees (Insert All)    =====");
            Console.WriteLine("=====      4. Back                      =====");
            Console.WriteLine("=====      5. Testing                   =====");
            Console.WriteLine("=====                                   =====");
            Console.WriteLine("Pilih menu (1/2/3/4): ");
        }

        public static void Read()
        {
            Console.WriteLine("=====          Tampilkan Tabel          =====");
            Console.WriteLine("=====                                   =====");
            Console.WriteLine("=====      1. Universities              =====");
            Console.WriteLine("=====      2. Educations                =====");
            Console.WriteLine("=====      3. Employees (Insert All)    =====");
            Console.WriteLine("=====      4. Back                      =====");
            Console.WriteLine("=====      5. Testing                   =====");
            Console.WriteLine("=====                                   =====");
            Console.WriteLine("Pilih menu (1/2/3/4): ");
        }

        public static void Update()
        {
            Console.WriteLine("===== PILIH TABEL YANG AKAN DIUBAH =====");
            Console.WriteLine("=====                              =====");
            Console.WriteLine("=====        1. Universities       =====");
            Console.WriteLine("=====        2. Educations         =====");
            Console.WriteLine("=====        3. Back               =====");
            Console.WriteLine("=====                              =====");
            Console.WriteLine("Pilih menu (1/2): ");
        }

        public static void Delete()
        {
            Console.WriteLine("===== PILIH TABEL YANG AKAN DIHAPUS =====");
            Console.WriteLine("=====                               =====");
            Console.WriteLine("=====        1. Universities        =====");
            Console.WriteLine("=====        2. Educations          =====");
            Console.WriteLine("=====        3. Back                =====");
            Console.WriteLine("=====                               =====");
            Console.WriteLine("Pilih menu (1/2): ");
        }
    }
}
