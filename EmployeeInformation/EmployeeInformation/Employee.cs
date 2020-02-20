using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation
{
   
    public class Employee:IEmployee
    {
        public int empid;
        public String name;
        public int noofdaysWorked;
        public String designation;
        Employee(int empid, String name, int noofdaysWorked,String designation)
        {
            this.empid = empid;
            this.name = name;
            this.noofdaysWorked = noofdaysWorked;
            this.designation = designation;
        }
        public int getPF(int actual)
        {
            return 8 * (actual / 100);
            
        }
        public int  getSalary()
        {
            int basic = 15000;
            int basic_actual=basic*(getDays()/22);
            int other = 0;
            if (getDesignation() == "JSE")
            {
                other = 10000;
            }
            else
            {
                other = 20000;
            }
            int other_actual = other * (getDays() / 22);
            int total = basic_actual + other_actual;

        }
        public int getTax(int actual)
        {
            if()
            
        }
        public int getDays()
        {
            return noofdaysWorked;
        }
        public int getId()
        {
            return empid;
        }
        public String getDesignation()
        {
            return designation;
        }

    }
}
