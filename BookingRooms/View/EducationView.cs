using BookingRooms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms.VIew
{
    public class EducationView
    {
        /*Console.WriteLine("Menampilkan semua data");
        var results = Education.GetEducation();
        foreach (var result in results)*/
        public void Output(Education education)
        {
            Console.WriteLine("Id: " + education.Id);
            Console.WriteLine("Major: " + education.Major);
            Console.WriteLine("Degree: " + education.Degree);
            Console.WriteLine("GPA: " + education.Gpa);
            Console.WriteLine("Universty Id : " + education.UniversityId);
            Console.WriteLine("-----------------------------------------");
        }

        public void Output(List<Education> educations)
        {
            foreach (var education in educations)
            {
                Output(education);
            }
        }

        public void Output(string message)
        {
            Console.WriteLine(message);
        }

    }
}
