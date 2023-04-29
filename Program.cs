using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeewageManagement;


namespace EmployeewageManagement{
    public class Program{
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            WageManagement obj = new WageManagement(employee);
            obj.EmployeePresent();

            if(employee.EmployeePresent){
                Console.WriteLine("Employee present");
            }else{
                Console.WriteLine("Employee not present");
            }
        }
    }
}