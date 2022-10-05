using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    public class Employee
    {
        public int empno;
        public string firstname;
        public string lastname;
        public double salary;

        public Employee(int empno, string firstname, string lastname, double salary)
        {
            this.empno = empno;
            this.firstname = firstname;
            this.lastname = lastname;
            this.salary = salary;
        }
    }

    public class Overtime : Employee
    {
        public int hours;

        public Overtime(int empno, string firstname, string lastname, double salary, int hours) :base(empno, firstname, lastname, salary)
        {
            this.hours = hours;
        }   

        public double getPay()
        {
            if(hours == 1)
            {
                salary += 1000;
            }else if(hours == 2)
            {
                salary += 2000;
            }
            else
            {
                Console.WriteLine("Overtime can not be greater than 2 hours");
            }
            return salary;
        }

       

        public void display()
        {
            Console.WriteLine(
                "id: {0}", empno
            );
            Console.WriteLine(
                "salary: {0}", salary
            );
            Console.WriteLine(
                "FirstName: {0}, {1}", firstname, lastname
            );
            Console.WriteLine(
                "totalSalary: {0}", getPay()
            ) ;
        }
    }
}
