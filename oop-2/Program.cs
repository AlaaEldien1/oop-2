using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            // 1- Design and implement a Class for the employees in a company:
            //Employee employee = new Employee(1,"ali",SecurityLevel.guest,200, DateTime.Now,'m');
            //Console.WriteLine(employee.ToString());
            #endregion
            #region question2
            //Develop a Class to represent the Hiring Date Data:Consisting of fields to hold the day, month and Years.

            //HiringDate now = new HiringDate(1,1,2020);
            //Console.WriteLine(now.ToString());

            #endregion
            #region question3
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "Ahmed", SecurityLevel.DBA, 15000, new DateTime(2022, 4, 10), 'm');

            EmpArr[1] = new Employee(2, "Sara", SecurityLevel.guest, 3000, new DateTime(2023, 2, 5), 'f');

            EmpArr[2] = new Employee(3, "Kareem", SecurityLevel.secretary, 8000, new DateTime(2024, 1, 20), 'm');
            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp);
            }
            #endregion
        }
    }
}
