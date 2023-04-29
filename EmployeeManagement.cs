using System.Collections.Generic;
using System;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageManagement{

    public class WageManagement{
        private int WagePErHour  =  20;
        private int fullHour = 8;

        private int partimeHour = 4;

        Employee employee ;
            public WageManagement(Employee employee){
                this.employee = employee;
            }   

            public void EmployeePresent(){
                int employeecheck ;
                Random random = new Random();
                employeecheck = random.Next(0,3);

                if (employeecheck == 0){
                    employee.EmployeePresent = false;
                }else if(employeecheck == 1){
                    employee.EmployeePresent = true;
                } else{
                    employee.EmployeePresent =  true;
                    employee.isparttime = true;
                }
            }
            public void calcutewage(){
                if(employee.isparttime){
                    employee.wage = WagePErHour * partimeHour;
                }else{
                    employee.wage = WagePErHour * fullHour;
                }
            }


    }

}


