using System.Collections.Generic;
using System;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageManagement{

    public class WageManagement{
        private int WagePErHour  =  20;
        private int Maxworking_days = 20;
      

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
                    employee.emphour = 8;
                } else{
                    employee.EmployeePresent =  true;
                    employee.emphour = 4;
                }
            }
            public void calcutewage(){
                
                    employee.wage = WagePErHour * employee.emphour;
        
            }

            public void employeeScitch(){
                int employeecheck;
                Random random = new Random();
                employeecheck = random.Next(0,3);

                switch (employeecheck){
                    case 0:
                        employee.EmployeePresent =  false;
                        break;
                    case 1:
                        employee.EmployeePresent = true;
                        employee.emphour = 8;
                        break;
                    case 2:
                        employee.EmployeePresent = true;
                        employee.emphour = 4;
                        break;
                }

                calcutewage();
            }

            public void Monthlywage(){
                for (int i = 1; i <= Maxworking_days;i++){
                    employeeScitch();
                    calcutewage();
                    employee.monthly_wage += employee.wage; 
                }
            }

            public void Conditionalwage(){
                while(employee.Totalworking_hour <=100 && employee.total_working_day <20){
                     employee.total_working_day ++;
                    employeeScitch();
                    calcutewage();
                  employee.monthly_wage +=employee.wage; 
                    employee.Totalworking_hour += employee.emphour; 
                }
            }


    }

}


