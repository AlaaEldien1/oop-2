using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    public enum SecurityLevel {
        guest,
        developer,
        secretary,
        DBA
    }
    internal class Employee
    {
        private int id;
        private string name;
        private SecurityLevel security;
        private int salary;
        private DateTime hireDate;
        private char gender;
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'm' || value == 'f')
                    gender = value;
                else
                    Console.WriteLine("enter m for male or f for female");
            }
        }
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    Console.WriteLine("name canot be empty");
            }
        }
        public SecurityLevel Security
        {
            get { return security; }
            set
            {
                if (Enum.IsDefined(typeof(SecurityLevel), value))
                    security = value;
                else
                    Console.WriteLine("enter one of the security levels");
            }

        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
        public Employee(int id, string name, SecurityLevel security, int salary, DateTime hireDate,char gender)
        {
            Id = id;
            Name = name;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        public Employee()
        {
        }
        public override string ToString()
        {
            return $"Id : {id} name : {name } salary {String.Format("{0:C}", Salary)} security level : {security} hire date {hireDate} gender {gender}";
        }
    }
}
