using System.Collections.Generic;
using System;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageManagement{

    public class WageManagement{
        Employee employee ;
            public WageManagement(Employee employee){
                this.employee = employee;
            }   

            public void EmployeePresent(){
                int employeecheck ;
                Random random = new Random();
                employeecheck = random.Next(0,2);

                if (employeecheck == 0){
                    employee.EmployeePresent = true;
                }else {
                    employee.EmployeePresent = false;
                }

             
                
            }


    }

}


