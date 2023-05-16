using BookingRooms.Model;
using BookingRooms.VIew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingRooms.Controller;

public class EmployeeController
{
    private static Employee _employee = new Employee();

    public static void GetAll()
    {
        var results = _employee.Get();
        var view = new EmployeeView();
        
        if (results.Count == 0)
        {
            view.Output("Data Tidak Ditemukan");
        }
        else
        {
            view.Output(results);
        }
    }

    public void Insert(Employee employee)
    {
        var result = _employee.Insert(employee);
        var view = new EmployeeView();
        if (result == 0)
        {
            view.Output("Insert Employee Failed");
        }
        else
        {
            view.Output("Insert Employee Success");
        }
    }

    /*public void GetAllData()
    {
        _employee.Get();
    }*/
    
    
}
