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

            obj.Conditionalwage();      

            Console.WriteLine("Employee Total Working Hour:  " + employee.Totalworking_hour);
            Console.WriteLine("Employee TotalWorking Days: "+ employee.total_working_day);
            Console.WriteLine("Emplayee Wage : " + employee.monthly_wage);
            
        }
    }
}